using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BlazorDemo.DataProviders {
    public class EntityDataProviderBase<T> : DataProviderBase where T : DbContext {
        public EntityDataProviderBase(IDbContextFactory<T> contextFactory, IConfiguration configuration) {
            ContextFactory = contextFactory;
            Configuration = configuration;
        }

        public IDbContextFactory<T> ContextFactory { get; private set; }
        protected IConfiguration Configuration { get; set; }
    }

    public class EntityDataProvider<T> : EntityDataProviderBase<T> where T : DbContext {
        readonly SemaphoreSlim _lock = new SemaphoreSlim(1);
        Dictionary<string, object> dataWrappers = new Dictionary<string, object>();

        public EntityDataProvider(IDbContextFactory<T> contextFactory, IConfiguration configuration): base(contextFactory, configuration) { }

        protected bool UseDataProxy { get { return Configuration.GetValue<bool>("SiteMode"); } }

        protected async Task<List<TEntity>> LoadDataAsync<TEntity>(string dbSetKey, CancellationToken ct = default) where TEntity : class, new() {
            using(var ctx = ContextFactory.CreateDbContext()) {
                var dbSet = ctx.Set<TEntity>();
                if(UseDataProxy) {
                    await _lock.WaitAsync();
                    if(!dataWrappers.ContainsKey(dbSetKey)) {
                        var dataWrapper = new DataWrapper<TEntity>(dbSet.AsNoTracking().ToList());
                        dataWrappers.Add(dbSetKey, dataWrapper);
                    }
                    _lock.Release();
                    return await GetDataWrapper<TEntity>(dbSetKey).GetData();
                } else
                    return await dbSet.ToListAsync();
            }
        }
        protected async Task InsertAsync<TEntity>(string dbSetKey, IDictionary<string, object> newValues, Action<TEntity, string, object> updateFunc = null, Action<IQueryable<TEntity>, TEntity> updateKeyFunc = null, CancellationToken ct = default) where TEntity : class, new() {
            if(UseDataProxy) {
                var dataWrapper = GetDataWrapper<TEntity>(dbSetKey);
                await dataWrapper.Add(newValues, updateFunc, updateKeyFunc);
            }
            else {
                using(var ctx = ContextFactory.CreateDbContext()) {
                    var dbSet = ctx.Set<TEntity>();
                    TEntity dataItem = new TEntity();
                    foreach(var field in newValues.Keys)
                        updateFunc(dataItem, field, newValues[field]);
                    updateKeyFunc(dbSet, dataItem);
                    dbSet.Add(dataItem);
                    await ctx.SaveChangesAsync();
                }
            }
        }
        protected async Task InsertAsync<TEntity>(string dbSetKey, TEntity dataItem, Action<IQueryable<TEntity>, TEntity> updateKeyFunc = null, CancellationToken ct = default) where TEntity : class, new() {
            if(UseDataProxy) {
                var dataWrapper = GetDataWrapper<TEntity>(dbSetKey);
                await dataWrapper.Add(dataItem, updateKeyFunc);
            }
            else {
                using(var ctx = ContextFactory.CreateDbContext()) {
                    var dbSet = ctx.Set<TEntity>();
                    updateKeyFunc(dbSet, dataItem);
                    dbSet.Add(dataItem);
                    await ctx.SaveChangesAsync();
                }
            }
        }
        protected async Task UpdateAsync<TEntity>(string dbSetKey, TEntity dataItem, IDictionary<string, object> newValues, Action<TEntity, string, object> updateFunc = null, CancellationToken ct = default) where TEntity : class, new() {
            if(UseDataProxy) {
                var dataWrapper = GetDataWrapper<TEntity>(dbSetKey);
                await dataWrapper.Update(dataItem, newValues, updateFunc);
            }
            else {
                using(var ctx = ContextFactory.CreateDbContext()) {
                    var dbSet = ctx.Set<TEntity>();
                    foreach(var field in newValues.Keys)
                        updateFunc(dataItem, field, newValues[field]);
                    dbSet.Update(dataItem);
                    await ctx.SaveChangesAsync();
                }
            }
        }
        protected async Task RemoveAsync<TEntity>(string dbSetKey, TEntity dataItem, CancellationToken ct = default) where TEntity : class, new() {
            if(UseDataProxy) {
                var dataWrapper = GetDataWrapper<TEntity>(dbSetKey);
                await dataWrapper.Remove(dataItem);
            }
            else {
                using(var ctx = ContextFactory.CreateDbContext()) {
                    var dbSet = ctx.Set<TEntity>();
                    dbSet.Remove(dataItem);
                    await ctx.SaveChangesAsync();
                }
            }
        }

        protected IDataWrapper<TEntity> GetDataWrapper<TEntity>(string dbSetKey) {
            return (IDataWrapper<TEntity>)dataWrappers[dbSetKey];
        }
    }

    public class EntityQueryableDataProvider<T> : EntityDataProviderBase<T>, IDisposable where T : DbContext {
        public EntityQueryableDataProvider(IDbContextFactory<T> contextFactory, IConfiguration configuration) : base(contextFactory, configuration) {
            Context = ContextFactory.CreateDbContext();
        }

        public T Context { get; private set; }

        protected IQueryable<TEntity> GetNonTrackingDbSet<TEntity>() where TEntity : class, new() {
            return Context.Set<TEntity>().AsNoTracking();
        }

        public void Dispose() {
            Context?.Dispose();
        }
    }
}


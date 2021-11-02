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
                    return await GetDataWrapper<TEntity>(dbSetKey).GetDataAsync();
                } else
                    return await dbSet.ToListAsync();
            }
        }
        protected async Task<List<TItemEntity>> LoadDataAsync<TDbSetEntity, TItemEntity>(string dbSetKey, CancellationToken ct = default) where TDbSetEntity : class, new() where TItemEntity : class, new() {
            using(var ctx = ContextFactory.CreateDbContext()) {
                var dbSet = ctx.Set<TDbSetEntity>();
                if(UseDataProxy) {
                    await _lock.WaitAsync();
                    if(!dataWrappers.ContainsKey(dbSetKey)) {
                        var dataWrapper = new DataWrapper<TItemEntity>(dbSet.AsNoTracking().ToList().Select(e => ConvertItem<TDbSetEntity, TItemEntity>(e)).ToList());
                        dataWrappers.Add(dbSetKey, dataWrapper);
                    }
                    _lock.Release();
                    return await GetDataWrapper<TItemEntity>(dbSetKey).GetDataAsync();
                } else
                    return await Task.FromResult(dbSet.ToList().Select(e => ConvertItem<TDbSetEntity, TItemEntity>(e)).ToList());
            }
        }
        protected async Task InsertAsync<TEntity>(string dbSetKey, IDictionary<string, object> newValues, Action<IQueryable<TEntity>, TEntity> updateKeyFunc = null, CancellationToken ct = default) where TEntity : class, new() {
            if(UseDataProxy) {
                var dataWrapper = GetDataWrapper<TEntity>(dbSetKey);
                await dataWrapper.Add(newValues, UpdateItemProperties, updateKeyFunc);
            }
            else {
                using(var ctx = ContextFactory.CreateDbContext()) {
                    var dbSet = ctx.Set<TEntity>();
                    TEntity dataItem = new TEntity();
                    UpdateItemProperties(dataItem, newValues);
                    updateKeyFunc(dbSet, dataItem);
                    dbSet.Add(dataItem);
                    await ctx.SaveChangesAsync();
                }
            }
        }
        protected async Task InsertAsync<TDbSetEntity, TItemEntity>(string dbSetKey, IDictionary<string, object> newValues, Action<IQueryable<TDbSetEntity>, TDbSetEntity> updateKeyFunc = null, CancellationToken ct = default) where TDbSetEntity : class, new() where TItemEntity : class, new() {
            if(UseDataProxy) {
                var dataWrapper = GetDataWrapper<TItemEntity>(dbSetKey);
                await dataWrapper.Add(newValues, UpdateItemProperties, null);
            } else {
                using(var ctx = ContextFactory.CreateDbContext()) {
                    var dbSet = ctx.Set<TDbSetEntity>();
                    TDbSetEntity dataItem = new TDbSetEntity();
                    UpdateItemProperties(dataItem, newValues);
                    updateKeyFunc(dbSet, dataItem);
                    dbSet.Add(dataItem);
                    await ctx.SaveChangesAsync();
                }
            }
        }
        protected async Task InsertAsync<TEntity>(string dbSetKey, TEntity dataItem, Action<IQueryable<TEntity>, TEntity> updateKeyFunc = null, CancellationToken ct = default) where TEntity : class, new() {
            if(UseDataProxy) {
                var dataWrapper = GetDataWrapper<TEntity>(dbSetKey);
                TEntity newDataItem = new TEntity();
                UpdateItemProperties(newDataItem, dataItem);
                await dataWrapper.Add(newDataItem, updateKeyFunc);
            }
            else {
                using(var ctx = ContextFactory.CreateDbContext()) {
                    var dbSet = ctx.Set<TEntity>();
                    TEntity newDataItem = new TEntity();
                    UpdateItemProperties(newDataItem, dataItem);
                    updateKeyFunc(dbSet, newDataItem);
                    dbSet.Add(newDataItem);
                    await ctx.SaveChangesAsync();
                }
            }
        }
        protected async Task InsertAsync<TDbSetEntity, TItemEntity>(string dbSetKey, TItemEntity dataItem, Action<IQueryable<TDbSetEntity>, TDbSetEntity> updateKeyFunc = null, CancellationToken ct = default) where TDbSetEntity : class, new() where TItemEntity : class, new() {
            if(UseDataProxy) {
                var dataWrapper = GetDataWrapper<TItemEntity>(dbSetKey);
                TItemEntity newDataItem = new TItemEntity();
                UpdateItemProperties(newDataItem, dataItem);
                await dataWrapper.Add(newDataItem, null);
            } else {
                using(var ctx = ContextFactory.CreateDbContext()) {
                    var dbSet = ctx.Set<TDbSetEntity>();
                    TDbSetEntity newDataItem = new TDbSetEntity();
                    UpdateItemProperties(newDataItem, dataItem);
                    updateKeyFunc(dbSet, newDataItem);
                    dbSet.Add(newDataItem);
                    await ctx.SaveChangesAsync();
                }
            }
        }
        protected async Task UpdateAsync<TEntity>(string dbSetKey, TEntity dataItem, IDictionary<string, object> newValues, CancellationToken ct = default) where TEntity : class, new() {
            if(UseDataProxy) {
                var dataWrapper = GetDataWrapper<TEntity>(dbSetKey);
                await dataWrapper.UpdateByValues(dataItem, newValues, UpdateItemProperties);
            }
            else {
                using(var ctx = ContextFactory.CreateDbContext()) {
                    var dbSet = ctx.Set<TEntity>();
                    UpdateItemProperties(dataItem, newValues);
                    dbSet.Update(dataItem);
                    await ctx.SaveChangesAsync();
                }
            }
        }
        protected async Task UpdateAsync<TDbSetEntity, TItemEntity>(string dbSetKey, TItemEntity dataItem, IDictionary<string, object> newValues, Func<IQueryable<TDbSetEntity>, TItemEntity, TDbSetEntity> findItemFunc = null, CancellationToken ct = default) where TDbSetEntity : class, new() where TItemEntity : class, new() {
            if(UseDataProxy) {
                var dataWrapper = GetDataWrapper<TItemEntity>(dbSetKey);
                await dataWrapper.UpdateByValues(dataItem, newValues, UpdateItemProperties);
            } else {
                using(var ctx = ContextFactory.CreateDbContext()) {
                    var dbSet = ctx.Set<TDbSetEntity>();
                    var dbSetItem = findItemFunc(dbSet, dataItem);
                    if(dbSetItem != null) {
                        UpdateItemProperties(dbSetItem, newValues);
                        dbSet.Update(dbSetItem);
                    }
                    await ctx.SaveChangesAsync();
                }
            }
        }
        protected async Task UpdateAsync<TEntity>(string dbSetKey, TEntity dataItem, TEntity newDataItem, CancellationToken ct = default) where TEntity : class, new() {
            if(UseDataProxy) {
                var dataWrapper = GetDataWrapper<TEntity>(dbSetKey);
                await dataWrapper.UpdateByItem(dataItem, newDataItem, UpdateItemProperties);
            } else {
                using(var ctx = ContextFactory.CreateDbContext()) {
                    var dbSet = ctx.Set<TEntity>();
                    UpdateItemProperties(dataItem, newDataItem);
                    dbSet.Update(dataItem);
                    await ctx.SaveChangesAsync();
                }
            }
        }
        protected async Task UpdateAsync<TDbSetEntity, TItemEntity>(string dbSetKey, TItemEntity dataItem, TItemEntity newDataItem, Func<IQueryable<TDbSetEntity>, TItemEntity, TDbSetEntity> findItemFunc = null, CancellationToken ct = default) where TDbSetEntity : class, new() where TItemEntity : class, new() {
            if(UseDataProxy) {
                var dataWrapper = GetDataWrapper<TItemEntity>(dbSetKey);
                await dataWrapper.UpdateByItem(dataItem, newDataItem, UpdateItemProperties);
            } else {
                using(var ctx = ContextFactory.CreateDbContext()) {
                    var dbSet = ctx.Set<TDbSetEntity>();
                    var dbSetItem = findItemFunc(dbSet, dataItem);
                    if(dbSetItem != null) {
                        UpdateItemProperties(dbSetItem, newDataItem);
                        dbSet.Update(dbSetItem);
                    }
                    await ctx.SaveChangesAsync();
                }
            }
        }
        protected async Task RemoveAsync<TEntity>(string dbSetKey, TEntity dataItem, CancellationToken ct = default) where TEntity : class, new() {
            if(UseDataProxy) {
                var dataWrapper = GetDataWrapper<TEntity>(dbSetKey);
                await dataWrapper.Remove(dataItem);
            } else {
                using(var ctx = ContextFactory.CreateDbContext()) {
                    var dbSet = ctx.Set<TEntity>();
                    dbSet.Remove(dataItem);
                    await ctx.SaveChangesAsync();
                }
            }
        }
        protected async Task RemoveAsync<TDbSetEntity, TItemEntity>(string dbSetKey, TItemEntity dataItem, Func<IQueryable<TDbSetEntity>, TItemEntity, TDbSetEntity> findItemFunc = null, CancellationToken ct = default) where TDbSetEntity : class, new() where TItemEntity : class, new() {
            if(UseDataProxy) {
                var dataWrapper = GetDataWrapper<TItemEntity>(dbSetKey);
                await dataWrapper.Remove(dataItem);
            } else {
                using(var ctx = ContextFactory.CreateDbContext()) {
                    var dbSet = ctx.Set<TDbSetEntity>();
                    var dbSetItem = findItemFunc(dbSet, dataItem);
                    if(dbSetItem != null) {
                        dbSet.Remove(dbSetItem);
                    }
                    await ctx.SaveChangesAsync();
                }
            }
        }

#pragma warning disable CS0693 // Type parameter has the same name as the type parameter from outer type
        protected T1 ConvertItem<T, T1>(T item) where T : class, new() where T1 : class, new() {
            T1 result = new T1();
            UpdateItemProperties(result, item);
            return result;
        }
        protected void UpdateItemProperties<T, T1>(T item, T1 sourceItem) where T : class, new() {
            var props = typeof(T1).GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.SetProperty);
            foreach(var prop in props)
                UpdateItemProperty(item, prop.Name, prop.GetValue(sourceItem));
        }
        protected void UpdateItemProperties<T>(T item, IDictionary<string, object> values) where T : class, new() {
            foreach(var field in values.Keys)
                UpdateItemProperty(item, field, values[field]);
        }
        protected void UpdateItemProperty<T>(T item, string name, object value) where T : class, new() {
            var prop = typeof(T).GetProperty(name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.SetProperty);
            if(prop != null && prop.CanWrite)
                prop.SetValue(item, value);
        }
        protected static void UpdateItemKey<T>(IQueryable<T> items, T newItem, Func<T, int> getKey, Action<T, int> setKey) {
            var lastItem = items.OrderBy(getKey).LastOrDefault();
            setKey(newItem, lastItem != null ? getKey(lastItem) + 1 : 1);
        }
#pragma warning restore CS0693 // Type parameter has the same name as the type parameter from outer type

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


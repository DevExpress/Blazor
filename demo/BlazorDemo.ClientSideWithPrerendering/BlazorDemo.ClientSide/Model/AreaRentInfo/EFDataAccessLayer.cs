using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Blazor.Model {
    public class EFDataAccessLayer {
        FMRDemoContext db;
        public EFDataAccessLayer(FMRDemoContext db) {
            this.db = db;
        }

        public IQueryable<Area> GetQueryableArea() {
            try {
                return db.Area.AsQueryable();
            } catch {
                throw;
            }
        }
        public IQueryable<Rentinfo> GetQueryableRentinfo() {
            try {
                return db.Rentinfo.AsQueryable();
            } catch {
                throw;
            }
        }
        public IQueryable<AreaRentInfo> GetQueryableAreaRentInfo() {
            try {
                return db.AreaRentInfo.AsQueryable();
            } catch {
                throw;
            }
        }
        public IEnumerable<Area> GetAllArea() {
            try {
                return db.Area.ToList();
            } catch {
                throw;
            }
        }
    }
}

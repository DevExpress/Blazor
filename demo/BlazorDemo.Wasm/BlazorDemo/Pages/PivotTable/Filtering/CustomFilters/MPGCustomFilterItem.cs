using DevExpress.Data.Filtering;

namespace BlazorDemo.Pages.PivotTable.Filtering.CustomFilters {
    public class MPGCustomFilterItem {
        public int Key { get; set; }
        public string Text { get; set; }
        public CriteriaOperator FilterCriteria { get; set; }
    }
}

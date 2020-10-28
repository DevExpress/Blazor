namespace BlazorDemo.Reports.CachedDocumentSourceReport {
    public struct Term {
        public static readonly Term[] Terms = new Term[] {
            new Term("Payment seven days after invoice date" ),
            new Term("Payment ten days after invoice date" ),
            new Term("End of month" ),
            new Term("21st of the month following invoice date" ),
        };
        readonly string currentName;
        public string Name { get { return currentName; } }
        public Term(string currentName) {
            this.currentName = currentName;
        }
    }
}

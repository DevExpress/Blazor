namespace Demo.Blazor.Reports.CachedDocumentSource {
    public struct Term {
        public static Term[] Terms = new Term[] {
            new Term("Payment seven days after invoice date" ),
            new Term("Payment ten days after invoice date" ),
            new Term("End of month" ),
            new Term("21st of the month following invoice date" ),
        };
        readonly string name;
        public string Name { get { return name; } }
        public Term(string name) {
            this.name = name;
        }
    }
}

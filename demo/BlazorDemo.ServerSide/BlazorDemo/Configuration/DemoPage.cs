using System.Collections.Generic;

namespace BlazorDemo.Configuration
{
    public class DemoPage {
        public string Url { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }
        
        public string OG_Title { get; set; }
        public string OG_Image { get; set; }
        public string OG_Description { get; set; }
        public string OG_Url { get; set; }
        public string OG_Type { get; set; }
        

        public DemoPage[] DemoPages { get; set; }
    }
}
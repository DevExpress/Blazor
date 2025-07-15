using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorDemo.Data {

    public static partial class ResourceCollection {
        public static List<Resource> GetResourcesForGrouping() {
            return GetResources().Take(3).ToList();
        }

        public static List<Resource> GetResources() {
            return new List<Resource>() {
                new Resource() { Id=0 , Name="Nancy Davolio", GroupId=100, BackgroundCss="dxbl-green-color", TextCss="dxbl-white-font-color" },
                new Resource() { Id=1 , Name="Andrew Fuller", GroupId=101, BackgroundCss="dxbl-orange-color", TextCss="dxbl-white-font-color" },
                new Resource() { Id=2 , Name="Janet Leverling", GroupId=100, BackgroundCss="dxbl-purple-color", TextCss="dxbl-white-font-color" },
                new Resource() { Id=3 , Name="Margaret Peacock", GroupId=101, BackgroundCss="dxbl-indigo-color", TextCss="dxbl-white-font-color" },
                new Resource() { Id=4 , Name="Steven Buchanan", GroupId=100, BackgroundCss="dxbl-red-color", TextCss="dxbl-white-font-color" }
            };
        }

        public static List<Resource> GetResourceGroups() {
            return new List<Resource>() {
                new Resource() { Id=100, Name="Sales and Marketing", IsGroup=true },
                new Resource() { Id=101, Name="Engineering", IsGroup=true }
            };
        }
    }
}

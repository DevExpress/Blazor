using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Blazor.Model {
    public static class Emails {
        static readonly Lazy<List<string>> dataSource = new Lazy<List<string>>(() => {
            var dataSource = new List<string>();
            dataSource.Add("paulb@westchestercounty.com");
            dataSource.Add("barkk@barnesfamilywebsite.com");
            dataSource.Add("jerryc@campbellfamilywebsite.com");
            dataSource.Add("carl@lucasfamilywebsite.com");
            dataSource.Add("peter@dolanfamilywebsite.com");
            dataSource.Add("ryan@fischerfamilywebsite.com");
            dataSource.Add("richardf@fischerfamilywebsite.com");
            dataSource.Add("tomh@hamlettfamilywebsite.com");
            dataSource.Add("markh@vegassoftware.com");
            dataSource.Add("stevel@vegassoftware.com");
            dataSource.Add("jimmyl@vegassoftware.com");
            dataSource.Add("jeffreym@vegassoftware.com");
            dataSource.Add("andrewm@vegassoftware.com");
            dataSource.Add("davem@vegassoftware.com");
            dataSource.Add("bertp@vegassoftware.com");
            dataSource.Add("miker@vegassoftware.com");
            dataSource.Add("rays@vegassoftware.com");
            return dataSource;
        });

        public static List<string> DataSource { get { return dataSource.Value; } }
    }
}

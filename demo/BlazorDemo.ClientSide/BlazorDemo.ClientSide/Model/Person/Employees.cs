using System;
using System.Collections.Generic;

namespace Demo.Blazor.Model {
    public static class Employees {
        public static List<Employee> Load() {
            var dataSource = new List<Employee>() {
                new Employee() { Title="Mr.", FirstName="John", LastName="Heart", Position="CEO", BirthDate=DateTime.Parse("1964/03/16"), 
                    HireDate=DateTime.Parse("1995/01/15"), 
                    Notes="John has been in the Audio/Video industry since 1990. He has led DevAv as its CEO since 2003. When not working hard as the CEO, John loves to golf and bowl. He once bowled a perfect game of 300.", FileName="JohnHeart" },
                new Employee() { Title="Mrs.", FirstName="Olivia", LastName="Peyton", Position="Sales Assistant", BirthDate=DateTime.Parse("1981/06/03"), 
                    HireDate=DateTime.Parse("2012/05/14"), 
                    Notes="Olivia loves to sell. She has been selling DevAV products since 2012. Olivia was homecoming queen in high school. She is expecting her first child in 6 months. Good Luck Olivia.", FileName="OliviaPeyton" },
                new Employee() { Title="Mr.", FirstName="Robert", LastName="Reagan", Position="CMO", BirthDate=DateTime.Parse("1974/09/07"), 
                    HireDate=DateTime.Parse("2002/11/08"), 
                    Notes="Robert was recently voted the CMO of the year by CMO Magazine. He is a proud member of the DevAV Management Team. Robert is a championship BBQ chef, so when you get the chance ask him for his secret recipe.", FileName="RobertReagan" },
                new Employee() { Title="Ms.", FirstName="Greta", LastName="Sims", Position="HR Manager", BirthDate=DateTime.Parse("1977/11/22"), 
                    HireDate=DateTime.Parse("1998/04/23"), 
                    Notes="Greta has been DevAV's HR Manager since 2003. She joined DevAV from Sonee Corp. Greta is currently training for the NYC marathon. Her best marathon time is 4 hours. Go Greta.", FileName="GretaSims" },
                new Employee() { Title="Mr.", FirstName="Brett", LastName="Wade", Position="IT Manager", BirthDate=DateTime.Parse("1968/12/01"), 
                    HireDate=DateTime.Parse("2009/03/06"), 
                    Notes="Brett came to DevAv from Microsoft and has led our IT department since 2012. When he is not working hard for DevAV, he coaches Little League (he was a high school pitcher).", FileName="BrettWade" },
                new Employee() { Title="Mrs.", FirstName="Sandra", LastName="Johnson", Position="Controller", BirthDate=DateTime.Parse("1974/11/15"), 
                    HireDate=DateTime.Parse("2005/05/11"), 
                    Notes="Sandra is a CPA and has been our controller since 2008. She loves to interact with staff so if you've not met her, be certain to say hi. Sandra has 2 daughters both of whom are accomplished gymnasts.", FileName="SandraJohnson" },
                new Employee() { Title="Mr.", FirstName="Kevin", LastName="Carter", Position="Shipping Manager", BirthDate=DateTime.Parse("1978/01/09"), 
                    HireDate=DateTime.Parse("2009/08/11"), 
                    Notes="Kevin is our hard-working shipping manager and has been helping that department work like clockwork for 18 months. When not in the office, he is usually on the basketball court playing pick-up games.", FileName="KevinCarter" },
                new Employee() { Title="Ms.", FirstName="Cynthia", LastName="Stanwick", Position="HR Assistant", BirthDate=DateTime.Parse("1985/06/05"), 
                    HireDate=DateTime.Parse("2008/03/24"), 
                    Notes="Cindy joined us in 2008 and has been in the HR department for 2 years. She was recently awarded employee of the month. Way to go Cindy!" , FileName="CynthiaStanwick"},
                new Employee() { Title="Dr.", FirstName="Kent", LastName="Samuelson", Position="Ombudsman", BirthDate=DateTime.Parse("1972/09/11"), 
                    HireDate=DateTime.Parse("2009/04/22"), 
                    Notes="As our ombudsman, Kent is on the front-lines solving customer problems and helping our partners address issues out in the field. He is a classically trained musician and is a member of the Chamber Orchestra." , FileName="KentSamuelson"},
            };
            return dataSource;
        }
        public static List<Employee> DataSource { get { return Load(); } }
    }
}
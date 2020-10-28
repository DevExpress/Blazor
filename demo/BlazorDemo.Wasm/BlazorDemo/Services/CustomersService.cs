using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorDemo.Services {
    public class Customer {
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Country { get; set; }
        public string CustomerID { get; set; }
        public string Fax { get; set; }
        public string Phone { get; set; }
        public string PostalCode { get; set; }
        public string Region { get; set; }

        public Customer(string city, string companyName, string contactName,
            string contactTitle, string country, string customerID,
            string fax, string phone, string postalCode, string region) {
            City = city;
            CompanyName = companyName;
            ContactName = contactName;
            ContactTitle = contactTitle;
            Country = country;
            CustomerID = customerID;
            Fax = fax;
            Phone = phone;
            PostalCode = postalCode;
            Region = region;
        }
    }
    public class CustomersService {
        public CustomersService() { }

        public Task<IEnumerable<Customer>> Load(CancellationToken ct = default) {
            return Task.FromResult<IEnumerable<Customer>>(CreateData());
        }

        //nwind.mdf Customers
        static List<Customer> CreateData() {
            return new List<Customer> {
                new Customer("Aachen", "Drachenblut Delikatessen", "Sven Ottlieb", "Order Administrator", "Germany", "DRACD", "0241-059428", "0241-039123", "52066", " "),
                new Customer("Albuquerque", "Rattlesnake Canyon Grocery", "Paula Wilson", "Assistant Sales Representative", "USA", "RATTC", "(505) 555-3620", "(505) 555-5939", "87110", "NM"),
                new Customer("Anchorage", "Old World Delicatessen", "Rene Phillips", "Sales Representative", "USA", "OLDWO", "(907) 555-2880", "(907) 555-7584", "99508", "AK"),
                new Customer("Århus", "Vaffeljernet", "Palle Ibsen", "Sales Manager", "Denmark", "VAFFE", "86 22 33 44", "86 21 32 43", "8200", " "),
                new Customer("Barcelona", "Galería del gastrónomo", "Eduardo Saavedra", "Marketing Manager", "Spain", "GALED", "(93) 203 4561", "(93) 203 4560", "08022", " "),
                new Customer("Barquisimeto", "LILA-Supermercado", "Carlos González", "Accounting Manager", "Venezuela", "LILAS", "(9) 331-7256", "(9) 331-6954", "3508", "Lara"),
                new Customer("Bergamo", "Magazzini Alimentari Riuniti", "Giovanni Rovelli", "Marketing Manager", "Italy", "MAGAA", "035-640231", "035-640230", "24100", " "),
                new Customer("Berlin", "Alfreds Futterkiste", "Maria Anders", "Sales Representative", "Germany", "ALFKI", "030-0076545", "030-0074321", "12209", " "),
                new Customer("Bern", "Chop-suey Chinese", "Yang Wang", "Owner", "Switzerland", "CHOPS", " ", "0452-076545", "3012", " "),
                new Customer("Boise", "Save-a-lot Markets", "Jose Pavarotti", "Sales Representative", "USA", "SAVEA", " ", "(208) 555-8097", "83720", "ID"),
                new Customer("Bräcke", "Folk och fä HB", "Maria Larsson", "Owner", "Sweden", "FOLKO", " ", "0695-34 67 21", "S-844 67", " "),
                new Customer("Brandenburg", "Königlich Essen", "Philip Cramer", "Sales Associate", "Germany", "KOENE", " ", "0555-09876", "14776", " "),
                new Customer("Bruxelles", "Maison Dewey", "Catherine Dewey", "Sales Agent", "Belgium", "MAISD", "(02) 201 24 68", "(02) 201 24 67", "B-1180", " "),
                new Customer("Buenos Aires", "Cactus Comidas para llevar", "Patricio Simpson", "Sales Agent", "Argentina", "CACTU", "(1) 135-4892", "(1) 135-5555", "1010", " "),
                new Customer("Buenos Aires", "Océano Atlántico Ltda.", "Yvonne Moncada", "Sales Agent", "Argentina", "OCEAN", "(1) 135-5535", "(1) 135-5333", "1010", " "),
                new Customer("Buenos Aires", "Rancho grande", "Sergio Gutiérrez", "Sales Representative", "Argentina", "RANCH", "(1) 123-5556", "(1) 123-5555", "1010", " "),
                new Customer("Butte", "The Cracker Box", "Liu Wong", "Marketing Assistant", "USA", "THECR", "(406) 555-8083", "(406) 555-5834", "59801", "MT"),
                new Customer("Campinas", "Gourmet Lanchonetes", "André Fonseca", "Sales Associate", "Brazil", "GOURL", " ", "(11) 555-9482", "04876-786", "SP"),
                new Customer("Caracas", "GROSELLA-Restaurante", "Manuel Pereira", "Owner", "Venezuela", "GROSR", "(2) 283-3397", "(2) 283-2951", "1081", "DF"),
                new Customer("Charleroi", "Suprêmes délices", "Pascale Cartrain", "Accounting Manager", "Belgium", "SUPRD", "(071) 23 67 22 21", "(071) 23 67 22 20", "B-6000", " "),
                new Customer("Cork", "Hungry Owl All-Night Grocers", "Patricia McKenna", "Sales Associate", "Ireland", "HUNGO", "2967 3333", "2967 542", " ", "Co. Cork"),
                new Customer("Cowes", "Island Trading", "Helen Bennett", "Marketing Manager", "UK", "ISLAT", " ", "(198) 555-8888", "PO31 7PJ", "Isle of Wight"),
                new Customer("Cunewalde", "QUICK-Stop", "Horst Kloss", "Accounting Manager", "Germany", "QUICK", " ", "0372-035188", "01307", " "),
                new Customer("Elgin", "Hungry Coyote Import Store", "Yoshi Latimer", "Sales Representative", "USA", "HUNGC", "(503) 555-2376", "(503) 555-6874", "97827", "OR"),
                new Customer("Eugene", "Great Lakes Food Market", "Howard Snyder", "Marketing Manager", "USA", "GREAL", " ", "(503) 555-7555", "97403", "OR"),
                new Customer("Frankfurt a.M. ", "Lehmanns Marktstand", "Renate Messner", "Sales Representative", "Germany", "LEHMS", "069-0245874", "069-0245984", "60528", " "),
                new Customer("Genève", "Richter Supermarkt", "Michael Holz", "Sales Manager", "Switzerland", "RICSU", " ", "0897-034214", "1203", " "),
                new Customer("Graz", "Ernst Handel", "Roland Mendel", "Sales Manager", "Austria", "ERNSH", "7675-3426", "7675-3425", "8010", " "),
                new Customer("Helsinki", "Wilman Kala", "Matti Karttunen", "Owner/Marketing Assistant", "Finland", "WILMK", "90-224 8858", "90-224 8858", "21240", " "),
                new Customer("I. de Margarita", "LINO-Delicateses", "Felipe Izquierdo", "Owner", "Venezuela", "LINOD", "(8) 34-93-93", "(8) 34-56-12", "4980", "Nueva Esparta"),
                new Customer("Kirkland", "Trail's Head Gourmet Provisioners", "Helvetius Nagy", "Sales Associate", "USA", "TRAIH", "(206) 555-2174", "(206) 555-8257", "98034", "WA"),
                new Customer("København", "Simons bistro", "Jytte Petersen", "Owner", "Denmark", "SIMOB", "31 13 35 57", "31 12 34 56", "1734", " "),
                new Customer("Köln", "Ottilies Käseladen", "Henriette Pfalzheim", "Owner", "Germany", "OTTIK", "0221-0765721", "0221-0644327", "50739", " "),
                new Customer("Lander", "Split Rail Beer & Ale", "Art Braunschweiger", "Sales Manager", "USA", "SPLIR", "(307) 555-6525", "(307) 555-4680", "82520", "WY"),
                new Customer("Leipzig", "Morgenstern Gesundkost", "Alexander Feuer", "Marketing Assistant", "Germany", "MORGK", " ", "0342-023176", "04179", " "),
                new Customer("Lille", "Folies gourmandes", "Martine Rancé", "Assistant Sales Agent", "France", "FOLIG", "20.16.10.17", "20.16.10.16", "59000", " "),
                new Customer("Lisboa", "Furia Bacalhau e Frutos do Mar", "Lino Rodriguez ", "Sales Manager", "Portugal", "FURIB", "(1) 354-2535", "(1) 354-2534", "1675", " "),
                new Customer("Lisboa", "Princesa Isabel Vinhos", "Isabel de Castro", "Sales Representative", "Portugal", "PRINI", " ", "(1) 356-5634", "1756", " "),
                new Customer("London", "Around the Horn", "Thomas Hardy", "Sales Representative", "UK", "AROUT", "(171) 555-6750", "(171) 555-7788", "WA1 1DP", " "),
                new Customer("London", "B's Beverages", "Victoria Ashworth", "Sales Representative", "UK", "BSBEV", " ", "(171) 555-1212", "EC2 5NT", " "),
                new Customer("London", "Consolidated Holdings", "Elizabeth Brown", "Sales Representative", "UK", "CONSH", "(171) 555-9199", "(171) 555-2282", "WX1 6LT", " "),
                new Customer("London", "Eastern Connection", "Ann Devon", "Sales Agent", "UK", "EASTC", "(171) 555-3373", "(171) 555-0297", "WX3 6FW", " "),
                new Customer("London", "North/South", "Simon Crowther", "Sales Associate", "UK", "NORTS", "(171) 555-2530", "(171) 555-7733", "SW7 1RZ", " "),
                new Customer("London", "Seven Seas Imports", "Hari Kumar", "Sales Manager", "UK", "SEVES", "(171) 555-5646", "(171) 555-1717", "OX15 4NB", " "),
                new Customer("Luleå", "Berglunds snabbköp", "Christina Berglund", "Order Administrator", "Sweden", "BERGS", "0921-12 34 67", "0921-12 34 65", "S-958 22", " "),
                new Customer("Lyon", "Victuailles en stock", "Mary Saveley", "Sales Agent", "France", "VICTE", "78.32.54.87", "78.32.54.86", "69004", " "),
                new Customer("Madrid", "Bólido Comidas preparadas", "Martín Sommer", "Owner", "Spain", "BOLID", "(91) 555 91 99", "(91) 555 22 82", "28023", " "),
                new Customer("Madrid", "FISSA Fabrica Inter. Salchichas S.A.", "Diego Roel", "Accounting Manager", "Spain", "FISSA", "(91) 555 55 93", "(91) 555 94 44", "28034", " "),
                new Customer("Madrid", "Romero y tomillo", "Alejandra Camino", "Accounting Manager", "Spain", "ROMEY", "(91) 745 6210", "(91) 745 6200", "28001", " "),
                new Customer("Mannheim", "Blauer See Delikatessen", "Hanna Moos", "Sales Representative", "Germany", "BLAUS", "0621-08924", "0621-08460", "68306", " "),
                new Customer("Marseille", "Bon app'", "Laurence Lebihan", "Owner", "France", "BONAP", "91.24.45.41", "91.24.45.40", "13008", " "),
                new Customer("México D.F.", "Ana Trujillo Emparedados y helados", "Ana Trujillo", "Owner", "Mexico", "ANATR", "(5) 555-3745", "(5) 555-4729", "05021", " "),
                new Customer("México D.F.", "Antonio Moreno Taquería", "Antonio Moreno", "Owner", "Mexico", "ANTON", " ", "(5) 555-3932", "05023", " "),
                new Customer("México D.F.", "Centro comercial Moctezuma", "Francisco Chang", "Marketing Manager", "Mexico", "CENTC", "(5) 555-7293", "(5) 555-3392", "05022", " "),
                new Customer("México D.F.", "Pericles Comidas clásicas", "Guillermo Fernández", "Sales Representative", "Mexico", "PERIC", "(5) 545-3745", "(5) 552-3745", "05033", " "),
                new Customer("México D.F.", "Tortuga Restaurante", "Miguel Angel Paolino", "Owner", "Mexico", "TORTU", " ", "(5) 555-2933", "05033", " "),
                new Customer("Montréal", "Mère Paillarde", "Jean Fresnière", "Marketing Assistant", "Canada", "MEREP", "(514) 555-8055", "(514) 555-8054", "H1J 1C3", "Québec"),
                new Customer("München", "Frankenversand", "Peter Franken", "Marketing Manager", "Germany", "FRANK", "089-0877451", "089-0877310", "80805", " "),
                new Customer("Münster", "Toms Spezialitäten", "Karin Josephs", "Marketing Manager", "Germany", "TOMSP", "0251-035695", "0251-031259", "44087", " "),
                new Customer("Nantes", "Du monde entier", "Janine Labrune", "Owner", "France", "DUMON", "40.67.89.89", "40.67.88.88", "44000", " "),
                new Customer("Nantes", "France restauration", "Carine Schmitt", "Marketing Manager", "France", "FRANR", "40.32.21.20", "40.32.21.21", "44000", " "),
                new Customer("Oulu", "Wartian Herkku", "Pirkko Koskitalo", "Accounting Manager", "Finland", "WARTH", "981-443655", "981-443655", "90110", " "),
                new Customer("Paris", "Paris spécialités", "Marie Bertrand", "Owner", "France", "PARIS", "(1) 42.34.22.77", "(1) 42.34.22.66", "75012", " "),
                new Customer("Paris", "Spécialités du monde", "Dominique Perrier", "Marketing Manager", "France", "SPECD", "(1) 47.55.60.20", "(1) 47.55.60.10", "75016", " "),
                new Customer("Portland", "Lonesome Pine Restaurant", "Fran Wilson", "Sales Manager", "USA", "LONEP", "(503) 555-9646", "(503) 555-9573", "97219", "OR"),
                new Customer("Portland", "The Big Cheese", "Liz Nixon", "Marketing Manager", "USA", "THEBI", " ", "(503) 555-3612", "97201", "OR"),
                new Customer("Reggio Emilia", "Reggiani Caseifici", "Maurizio Moroni", "Sales Associate", "Italy", "REGGC", "0522-556722", "0522-556721", "42100", " "),
                new Customer("Reims", "Vins et alcools Chevalier", "Paul Henriot", "Accounting Manager", "France", "VINET", "26.47.15.11", "26.47.15.10", "51100", " "),
                new Customer("Resende", "Wellington Importadora", "Paula Parente", "Sales Manager", "Brazil", "WELLI", " ", "(14) 555-8122", "08737-363", "SP"),
                new Customer("Rio de Janeiro", "Hanari Carnes", "Mario Pontes", "Accounting Manager", "Brazil", "HANAR", "(21) 555-8765", "(21) 555-0091", "05454-876", "RJ"),
                new Customer("Rio de Janeiro", "Que Delícia", "Bernardo Batista", "Accounting Manager", "Brazil", "QUEDE", "(21) 555-4545", "(21) 555-4252", "02389-673", "RJ"),
                new Customer("Rio de Janeiro", "Ricardo Adocicados", "Janete Limeira", "Assistant Sales Agent", "Brazil", "RICAR", " ", "(21) 555-3412", "02389-890", "RJ"),
                new Customer("Salzburg", "Piccolo und mehr", "Georg Pipps", "Sales Manager", "Austria", "PICCO", "6562-9723", "6562-9722", "5020", " "),
                new Customer("San Cristóbal", "HILARIÓN-Abastos", "Carlos Hernández", "Sales Representative", "Venezuela", "HILAA", "(5) 555-1948", "(5) 555-1340", "5022", "Táchira"),
                new Customer("San Francisco", "Let's Stop N Shop", "Jaime Yorres", "Owner", "USA", "LETSS", " ", "(415) 555-5938", "94117", "CA"),
                new Customer("São Paulo", "Comércio Mineiro", "Pedro Afonso", "Sales Associate", "Brazil", "COMMI", " ", "(11) 555-7647", "05432-043", "SP"),
                new Customer("São Paulo", "Familia Arquibaldo", "Aria Cruz", "Marketing Assistant", "Brazil", "FAMIA", " ", "(11) 555-9857", "05442-030", "SP"),
                new Customer("São Paulo", "Queen Cozinha", "Lúcia Carvalho", "Marketing Assistant", "Brazil", "QUEEN", " ", "(11) 555-1189", "05487-020", "SP"),
                new Customer("São Paulo", "Tradição Hipermercados", "Anabela Domingues", "Sales Representative", "Brazil", "TRADH", "(11) 555-2168", "(11) 555-2167", "05634-030", "SP"),
                new Customer("Seattle", "White Clover Markets", "Karl Jablonski", "Owner", "USA", "WHITC", "(206) 555-4115", "(206) 555-4112", "98128", "WA"),
                new Customer("Sevilla", "Godos Cocina Típica", "José Pedro Freyre", "Sales Manager", "Spain", "GODOS", " ", "(95) 555 82 82", "41101", " "),
                new Customer("Stavern", "Santé Gourmet", "Jonas Bergulfsen", "Owner", "Norway", "SANTG", "07-98 92 47", "07-98 92 35", "4110", " "),
                new Customer("Strasbourg", "Blondel père et fils", "Frédérique Citeaux", "Marketing Manager", "France", "BLONP", "88.60.15.32", "88.60.15.31", "67000", " "),
                new Customer("Stuttgart", "Die Wandernde Kuh", "Rita Müller", "Sales Representative", "Germany", "WANDK", "0711-035428", "0711-020361", "70563", " "),
                new Customer("Torino", "Franchi S.p.A.", "Paolo Accorti", "Sales Representative", "Italy", "FRANS", "011-4988261", "011-4988260", "10100", " "),
                new Customer("Toulouse", "La maison d'Asie", "Annette Roulet", "Sales Manager", "France", "LAMAI", "61.77.61.11", "61.77.61.10", "31000", " "),
                new Customer("Tsawwassen", "Bottom-Dollar Markets", "Elizabeth Lincoln", "Accounting Manager", "Canada", "BOTTM", "(604) 555-3745", "(604) 555-4729", "T2F 8M4", "BC"),
                new Customer("Vancouver", "Laughing Bacchus Wine Cellars", "Yoshi Tannamuri", "Marketing Assistant", "Canada", "LAUGB", "(604) 555-7293", "(604) 555-3392", "V3F 2K1", "BC"),
                new Customer("Versailles", "La corne d'abondance", "Daniel Tonini", "Sales Representative", "France", "LACOR", "30.59.85.11", "30.59.84.10", "78000", " "),
                new Customer("Walla Walla", "Lazy K Kountry Store", "John Steel", "Marketing Manager", "USA", "LAZYK", "(509) 555-6221", "(509) 555-7969", "99362", "WA"),
                new Customer("Warszawa", "Wolski  Zajazd", "Zbyszek Piestrzeniewicz", "Owner", "Poland", "WOLZA", "(26) 642-7012", "(26) 642-7012", "01-012", " ")
            };
        }
    }
}

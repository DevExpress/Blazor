using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Demo.Blazor.Reports.RestaurantMenu {
    [DisplayName("Restaurant Menu Report Data Source")]
    public class DataSource {
        public static IEnumerable<MenuItem> GetMenuData() {
            List<MenuItem> menu = new List<MenuItem>();
            menu.Add(new MenuItem("STEAKS", "Porterhouse", "Expertly aged and cooked to perfection. Finest cuts of filet and New York Strip sliced off the bone and presented Stuffed with Portobello Mushroom", 79.0));
            menu.Add(new MenuItem("STEAKS", "Sirloin Steak", "Our signature center-cut sirloin grilled to perfection served with choice of steak fries or whipped potatoes", 32.0));
            menu.Add(new MenuItem("STEAKS", "Steak & Scallops", "Beef Tenderloin Steak & 6 Large Scallops served with Champagne Butter Sauce", 41.0));
            menu.Add(new MenuItem("STEAKS", "Steak & Chicken Fingers", "Our 8-ounce Ribeye Steak and four strips of breaded white chicken, served with your choice of baked potato, or steak fries", 30.00));
            menu.Add(new MenuItem("STEAKS", "Steak & Ribs", "House Steak Beef & Smoked, wood-fire grilled ribs brushed with our secret sauce", 42.0));
            menu.Add(new MenuItem("STEAKS", "Steak & Chicken Breast", "11 ounces of our most tender cut of lean midwestern beef with our Seasoned and wood-fire grilled chicken breast", 32.0));
            menu.Add(new MenuItem("STEAKS", "Steak & Fried Shrimp", "Garlic Butter Grilled Steak & Cajun Fried Shrimp", 34.0));

            menu.Add(new MenuItem("CHICKEN", "Chicken Breast", "An 8 - ounce boneless, skinless chicken breast marinated and grilled to perfection. Served your choice of baked potato, or steak fries", 26.0));
            menu.Add(new MenuItem("CHICKEN", "Chicken Parmigiana", "Tender pan-fried chicken breast topped with tomato sauce and cheese baked until golden and bubbly", 23.0));
            menu.Add(new MenuItem("CHICKEN", "Alice Springs Chicken", "Marinated chicken breast in honey mustard sauce, topped with mushrooms, bacon, and cheese", 21.0));

            menu.Add(new MenuItem("SEAFOOD", "Baked Scrod", "Baked en casserole with Lemon-Garlic Bread crumbs", 18.0));
            menu.Add(new MenuItem("SEAFOOD", "Grilled Salmon", "8 oz. filet of wild salmon, hand-cut, seasoned and grilled over an open flame", 23.0));
            menu.Add(new MenuItem("SEAFOOD", "Smoked Salmon", "Served on homemade crostini topped with a dollop of crème fresh and Garnished with lemon zest and herbs", 17.00));
            menu.Add(new MenuItem("SEAFOOD", "Octopus", "Braised in sherry grilled and glazed with a tangy ancho chili sauce", 16.00));
            menu.Add(new MenuItem("SEAFOOD", "Seafood platter", "A Feast of Seafood featuring Jumbo Gulf Shrimp, Oysters, Tilapia Filets, and Crab Cakes Served with our homemade Tartar Sauce", 37.0));
            menu.Add(new MenuItem("SEAFOOD", "Fried Shrimp", "Panko Coated with Cajun Seasoning and Air Fried to a Golden Crisp", 28.0));
            menu.Add(new MenuItem("SEAFOOD", "Fried Clam Strips", "Traditional New England Style Fried Clams with Herb Seasonings and Egg Batter", 15.0));
            menu.Add(new MenuItem("SEAFOOD", "Fried Calamari", "Fried Light and Crisp. Served with Garlic Dip and Cocktail Sauce", 21.0));

            menu.Add(new MenuItem("APPETIZERS", "Soup of the Day", "Selection changes daily. Today’s soup roasted butternut squash", 9.00));
            menu.Add(new MenuItem("APPETIZERS", "Barbecued Shrimp", "Fresh shrimp sautéed in a Cajun sauce and flavored with garlic, and lemon juice. Served with crusty French bread", 13.00));
            menu.Add(new MenuItem("APPETIZERS", "Fish and Chips", "Panko Batter, Air Fried Cod served with our homemade Tartar Sauce", 16.00));
            menu.Add(new MenuItem("APPETIZERS", "Mushrooms Stuffed with Crabmeat", "Juicy mushrooms stuffed with tender crab meat and cream cheese filling, topped with seasoned bread crumbs", 18.00));
            menu.Add(new MenuItem("APPETIZERS", "Crispy Lobster Tail", "Cold water lobster tail, lightly fried, tossed in a spicy cream sauce, and served with our tangy cucumber salad", 26.0));
            menu.Add(new MenuItem("APPETIZERS", "Chilled Seafood Tower", "Kona Lobster, Alaskan King Crab, Pacific Oysters, Shrimp Cocktail", 159.0));
            menu.Add(new MenuItem("APPETIZERS", "Sizzling Blue Crab Cakes Lump", "Crab Cakes served with our house made sauce", 28.00));
            menu.Add(new MenuItem("APPETIZERS", "Crab Stack", "Fresh avocado, tomato, cucumber and mango all get pulled together with cilantro lime vinaigrette, and topped with crab", 25.00));

            menu.Add(new MenuItem("SALADS", "Caesar Salad", "Crisp Romaine with our House made Caesar dressing and Reggiano Croutons", 13.00));
            menu.Add(new MenuItem("SALADS", "Seaweed Salad", "Cucumber Seaweed, red onions, bell peppers, cilantro, sesame seeds and seaweed tossed with vinaigrette, and topped off with sesame oil", 11.00));
            menu.Add(new MenuItem("SALADS", "Greek Salad", "Romaine, Tomato, Red Onion, Cucumbers, Feta Cheese and Kalamata Olives tosses in Vinaigrette", 9.00));
            menu.Add(new MenuItem("SALADS", "Tomato Salad", "Ripe Red Heirloom Tomatoes Minced Garlic, Extra Virgin Olive Oil", 8.00));
            menu.Add(new MenuItem("SALADS", "Wedge of Iceberg", "Maytag Blue, Crispy Bacon, Avocado, Tomato", 13.0));
            menu.Add(new MenuItem("SALADS", "Warm Steak Salad", "Top Sirloin Steak pan seared and sliced thinly, paired with , avocado, tomatoes, and a fresh Cilantro Lime Dressing", 17.0));

            menu.Add(new MenuItem("VEGETABLES", "Potatoes", "Au Gratin, Whipped, Baked, Steak Fries", 9.00));
            menu.Add(new MenuItem("VEGETABLES", "Broccoli", "Sautéed, Roasted", 8.00));
            menu.Add(new MenuItem("VEGETABLES", "Spinach", "Creamed, Sautéed", 9.00));
            menu.Add(new MenuItem("VEGETABLES", "Green Beans", "Sautéed with Minced Garlic", 7.00));

            menu.Add(new MenuItem("BURGERS", "All American Burger", "Fresh-ground chuck, cheddar, tomato, lettuce and onion on a toasted bun", 17.00));
            menu.Add(new MenuItem("BURGERS", "Steakburger", "Single Steak Burger Patty on Toasted Bun with Tomato, Onion, Mustard, Pickles", 16.00));
            menu.Add(new MenuItem("BURGERS", "Crisp Chicken Burger", "Made with natural-cut, whole white meat chicken breast. Coated in our very own Southern-style breading, seasoned with onion, garlic and a pinch of cayenne. Served with crispy lettuce, ripe tomato and pickles on a toasted bun", 13.00));


            menu.Add(new MenuItem("DESSERTS", "Chocolate Cheesecake", "Silky Chocolate Cheesecake topped with a layer of Belgian Chocolate Mousse", 9.00));
            menu.Add(new MenuItem("DESSERTS", "Chocolate Mousse", "Light and Airy Mousse set on a Biscuit topped with Whipped Mascarpone", 11.00));
            menu.Add(new MenuItem("DESSERTS", "Carrot Cake", "Exceptionally Moist with a tangy cream cheese icing", 9.00));
            menu.Add(new MenuItem("DESSERTS", "Apple Strudel", "Made in house. Apples rolled in thin Flaky Crust Sprinkled with Brown Sugar & Cinnamon served with Vanilla Bean Ice Cream", 9.00));

            menu.Add(new MenuItem("SOFT DRINKS", "Water Voss (Still or Sparkling)", string.Empty, 8.00));
            menu.Add(new MenuItem("SOFT DRINKS", "Coke, Diet Coke, Dr. Pepper", string.Empty, 4.00));
            menu.Add(new MenuItem("SOFT DRINKS", "Sprite, Lemonade", string.Empty, 4.00));
            menu.Add(new MenuItem("SOFT DRINKS", "Apple Juice, Orange Juice", string.Empty, 3.00));

            menu.Add(new MenuItem("COFFEE & TEA", "Espressso", "Our signature in house blend of several different types of coffee beans", 4, "Hot"));
            menu.Add(new MenuItem("COFFEE & TEA", "Cappuccino", "Espresso Combined with Hot Steamed Milk and topped with Steamed Milk Foam", 7, "Hot"));
            menu.Add(new MenuItem("COFFEE & TEA", "Latte", "Espresso Combined with Hot Steamed Milk", 7, "Hot"));
            menu.Add(new MenuItem("COFFEE & TEA", "Liqueur coffee", "Irish coffee, with whiskey and a layer of cream on top", 9, "Hot"));
            menu.Add(new MenuItem("COFFEE & TEA", "Speciality Tea", "We proudly serve an assortment of Harney & Sons Fine Teas", 6, "Hot"));

            menu.Add(new MenuItem("COFFEE & TEA", "Frappe", "Blended Coffee, milk, sugar and ice drink", 6, "Iced"));
            menu.Add(new MenuItem("COFFEE & TEA", "Freddo espresso", "Made with a double shot of espresso coffee mixed in a mixer with ice cubes", 6, "Iced"));
            menu.Add(new MenuItem("COFFEE & TEA", "Freddo cappuccino", "Iced version of our regular cappuccino coffee, with a small amount of cold frothed milk on top", 6, "Iced"));

            menu.Add(new MenuItem("DRINKS", "Brown Ale", string.Empty, 7, "BEER"));
            menu.Add(new MenuItem("DRINKS", "Amber Ale", string.Empty, 7, "BEER"));
            menu.Add(new MenuItem("DRINKS", "Pale Ale", string.Empty, 6, "BEER"));
            menu.Add(new MenuItem("DRINKS", "Belgian Ale", string.Empty, 6, "BEER"));
            menu.Add(new MenuItem("DRINKS", "Dunkel", string.Empty, 6, "BEER"));
            menu.Add(new MenuItem("DRINKS", "Stout", string.Empty, 6, "BEER"));

            menu.Add(new MenuItem("DRINKS", "Bacardi", string.Empty, 9, "RUM"));
            menu.Add(new MenuItem("DRINKS", "Havana Club", string.Empty, 11, "RUM"));
            menu.Add(new MenuItem("DRINKS", "Captain Morgan", string.Empty, 8, "RUM"));

            menu.Add(new MenuItem("DRINKS", "Johnnie Walker Red Label", string.Empty, 14, "WHISKEY"));
            menu.Add(new MenuItem("DRINKS", "Johnnie Walker Black Label ", string.Empty, 17, "WHISKEY"));
            menu.Add(new MenuItem("DRINKS", "Chivas Regal", string.Empty, 8, "WHISKEY"));
            menu.Add(new MenuItem("DRINKS", "Glenfiddich", string.Empty, 8, "WHISKEY"));
            menu.Add(new MenuItem("DRINKS", "Talisker", string.Empty, 7, "WHISKEY"));
            menu.Add(new MenuItem("DRINKS", "Ballantine’s", string.Empty, 7, "WHISKEY"));

            menu.Add(new MenuItem("DRINKS", "Jim Beam", string.Empty, 7, "WHISKEY"));
            menu.Add(new MenuItem("DRINKS", "Jack Daniels", string.Empty, 8, "WHISKEY"));
            menu.Add(new MenuItem("DRINKS", "Maker's Mark", string.Empty, 11, "WHISKEY"));
            menu.Add(new MenuItem("DRINKS", "Wild Turkey", string.Empty, 9, "WHISKEY"));

            menu.Add(new MenuItem("DRINKS", "Bushmills", string.Empty, 7, "WHISKEY"));
            menu.Add(new MenuItem("DRINKS", "Jameson", string.Empty, 8, "WHISKEY"));
            menu.Add(new MenuItem("DRINKS", "Tullamore Dew", string.Empty, 8, "WHISKEY"));

            menu.Add(new MenuItem("DRINKS", "Smirnoff", string.Empty, 7, "VODKA"));
            menu.Add(new MenuItem("DRINKS", "Absolut", string.Empty, 8, "VODKA"));
            menu.Add(new MenuItem("DRINKS", "Grey Goose", string.Empty, 11, "VODKA"));
            menu.Add(new MenuItem("DRINKS", "Russian Standard", string.Empty, 13, "VODKA"));

            return menu;
        }

        public static IEnumerable<MenuItem> GetMenuData(string categoryName) {
            return GetMenuData().Where(x => x.CategoryName == categoryName).ToList();
        }
    }
    public class MenuItem {
        public string CategoryName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string SubCategoryName { get; set; }
        public bool IsNew { get; set; }
        public MenuItem(string category, string name, string description, double price, string subcategory = "") {
            CategoryName = category;
            Name = name;
            Description = description;
            Price = price;
            SubCategoryName = subcategory;
        }
    }
}

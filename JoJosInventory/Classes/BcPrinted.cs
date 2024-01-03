using JoJosInventory.Data;

namespace JoJosInventory.Classes
{
    public class BcPrinted
    {
        DbSingleton myDb = DbSingleton.Instance;
        private static BcPrinted? instance = null;
        public Base PrintedProductsEdit(int id, string name, string sku, string shortDescription, string fullDescription, string qty, string city, string lista)
        {
            return myDb.PrintedProductsEdit(id,name,sku,shortDescription,fullDescription,qty,city,lista);
        }
        public Base PrintedProductsAdd(string name, string sku, string? shortD, string description, string qty, string city)
        {
            return myDb.PrintedProductsAdd(name, sku, shortD, description, qty, city);
        }
        public Base PrintedProductsDelete(string list)
        {
            return myDb.PrintedProductsDelete(list);
        }
        public Base PrintedProductsDefinition(int id)
        {
            return myDb.PrintedProductsDefinition(id);
        }
        public Base PrintedProductsId(int id)
        {
            return myDb.PrintedProductsId(id);
        }
        public Base PrintedProductsSearch(string? category, string? city, string? SKU, string? description)
        {
            return myDb.PrintedProductsSearch(category, city, SKU, description);
        }
        private BcPrinted()
        {
        }
        public static BcPrinted Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BcPrinted();
                }
                return instance;
            }
        }
    }
}

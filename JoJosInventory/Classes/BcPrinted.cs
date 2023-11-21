using JoJosInventory.Data;

namespace JoJosInventory.Classes
{
    public class BcPrinted
    {
        DbSingleton myDb = DbSingleton.Instance;
        private static BcPrinted? instance = null;
        public Base PrintedEdit(int Id, string name, string sku, DateOnly? dueDate, string qty)
        {
            return myDb.BaseMaterialEdit(Id, name, sku, dueDate, qty);
        }

        public Base BaseMaterialAdd(string name, string sku, DateOnly? dueDate, string qty)
        {
            return myDb.BaseMaterialAdd(name, sku, dueDate, qty);
        }
        public Base BaseMaterialDelete(string list)
        {
            return myDb.BaseMaterialDelete(list);
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

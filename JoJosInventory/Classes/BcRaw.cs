using JoJosInventory.Data;

namespace JoJosInventory.Classes
{
    public class BcRaw
    {
        DbSingleton myDb = DbSingleton.Instance;
        LookUp lookup = LookUp.Instance;
        private static BcRaw? instance = null;
        public Base BaseMaterialEdit(int Id, string name, string sku, DateOnly? dueDate, string qty)
        {
            Base b = myDb.BaseMaterialEdit(Id, name, sku, dueDate, qty);
            if (!b.error) { lookup.UpdateLookUp(); }
            return b;
        }

        public Base BaseMaterialAdd(string name, string sku, DateOnly? dueDate, string qty )
        {            
            Base b = myDb.BaseMaterialAdd(name,sku,dueDate,qty);
            if (!b.error) { lookup.UpdateLookUp(); }
            return b;
        }
        public Base BaseMaterialDelete(string list)
        {
            Base b = myDb.BaseMaterialDelete(list);
            if (!b.error) { lookup.UpdateLookUp(); }
            return b;
        }
        public Base BaseMaterialSearch(string? category, DateOnly? Duedate, string? SKU)
        {
            return myDb.BaseMaterialSearch(category, Duedate, SKU); 
        }

        private BcRaw()
        {
        }
        public static BcRaw Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BcRaw();
                }
                return instance;
            }
        }
    }
}

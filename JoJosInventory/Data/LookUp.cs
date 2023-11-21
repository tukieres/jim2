using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoJosInventory.Data
{
    public class LookUp
    {
        private static LookUp instance = null;
        DbSingleton myDb = DbSingleton.Instance;

        public List<string> RawCategories { get; }
        public List<string> RawSku { get; }
        public List<string> City { get; }


        private LookUp()
        {
            List<List<string>> list = (List<List<string>>)myDb.RawCategoryGetList().objet;
            RawCategories = list[0];
            RawSku = list[1];
            City = list[2];
        }
        public static LookUp Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LookUp();
                }
                return instance;
            }
        }
    }
}

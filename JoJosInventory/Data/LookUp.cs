
namespace JoJosInventory.Data
{
    public class LookUp
    {        
        private static LookUp instance = null;
        DbSingleton myDb = DbSingleton.Instance;

        public List<string> RawCategories { get; set; }
        public List<string> RawSku { get; set; }
        public List<string> City { get; set; }


        private LookUp()
        {
            List<List<string>> list = (List<List<string>>)myDb.RawCategoryGetList().objet;
            RawCategories = list[0];
            RawSku = list[1];
            City = list[2];

        }
        public event EventHandler event_UpdateLookUp;

        protected virtual void OnEvent_UpdateLoopUp(EventArgs e)
        {
            event_UpdateLookUp?.Invoke(this, e);
        }

        public void UpdateLookUp()
        {
            try
            {
                List<List<string>> list = (List<List<string>>)myDb.RawCategoryGetList().objet;
                if (! (list == null))
                {
                    RawCategories.Clear();
                    RawSku.Clear();
                    City.Clear();
                    RawCategories = list[0];
                    RawSku = list[1];
                    City = list[2];
                }
            }
            catch (Exception ex) { }
            OnEvent_UpdateLoopUp(new EventArgs());
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

using EF;

namespace DAL.DAL
{
    public class DataProvider
    {
        private static QuanLyNhanSuEntities db = null;
        public static QuanLyNhanSuEntities dbContext
        {
            get
            {
                if(db == null)
                {
                    db = new QuanLyNhanSuEntities();
                }
                return db;
            }
        }
    }
}

using ExamenProgreso3API_ThyaraVintimilla.TV_Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgreso3API_ThyaraVintimilla.TV_Data
{
    public class TV_APIDataBase
    {
        string _dbPath;
        private SQLiteConnection conn;
        public TV_APIDataBase(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }
        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<TV_Root>();
        }
        public int AddNewBurger(TV_Root root)
        {
            Init();
            //int result = conn.Insert(burger);
            //return result;
            if (root.Id != 0)
            {
                conn.Update(root);
                return root.Id;
            }
            else
            {
                return conn.Insert(root);
            }
        }
        public List<TV_Root> GetAllBurgers()
        {
            Init();
            List<TV_Root> root = conn.Table<TV_Root>().ToList();
            return root;
        }
        public int DeleteItem(TV_Root item)
        {
            Init();
            return conn.Delete(item);
        }
    }
}

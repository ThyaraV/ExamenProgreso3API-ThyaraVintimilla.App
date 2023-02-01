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
        public TV_Root GetRoot(string word)
        {
            Init();
            TV_Root root = conn.Table<TV_Root>().Where(r => r.word == word).FirstOrDefault();
            return root;
        }
        public string UpdateRoot(TV_Root root)
        {
            Init();
            conn.Update(root);
            return root.word;
        }
        /*public string AddNewBurger(TV_Root root)
        {
            Init();
            //int result = conn.Insert(burger);
            //return result;
            if (root.word != null)
            {
                conn.Update(root);
                return root.word;
            }
            else
            {
                return conn.Insert(root);
            }
        }*/
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

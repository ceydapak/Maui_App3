using Microsoft.Maui.Graphics;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Graduation_project
{
    public class DBTrans
    {
        public string path;
        private SQLiteConnection con;

        public DBTrans(string _dbpath)
        {
            path = _dbpath;
        }
        public void Init()
        {
            con = new SQLiteConnection(path);
            con.CreateTable<Note>();

        }
        //GET
        public List<Note> GetNotes()
        {
            Init();
            return con.Table<Note>().ToList();

        }
     
        //ADD

        public void InsertNote(Note n)
        {
            con = new SQLiteConnection(path);
            con.Insert(n);

        }
        //DELETE
        public void DeleteNote(int id)
        {
            con = new SQLiteConnection(path);
            con.Delete(new Note { Id = id });

        }
        //UPDATE
        public void UpdateNote(int i, string title, string des, DateTime date) {
            con = new SQLiteConnection(path);
            con.Update(new Note { Id = i, Title= title, Description = des, Date = date});

        }


    }
}
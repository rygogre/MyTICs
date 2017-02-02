using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MyTICs.Models.Interface;
using SQLite;
using System.IO;

using MyTICs.Droid.Implementations;
using Xamarin.Forms;

[assembly:Dependency(typeof(SQLiteDroid))]
namespace MyTICs.Droid.Implementations
{
    public class SQLiteDroid:ISQLite
    {
        public SQLiteDroid()
        {

        }

        public SQLiteConnection GetConnection()
        {
            SQLitePCL.Batteries.Init();
            var sqlLiteFileName = "MyTICsDB.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqlLiteFileName);

            var cnn = new SQLiteConnection(path);

            return cnn;
        }
    }
}
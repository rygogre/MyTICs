using MyTICs.Models.Interface;
using SQLite;
using System.IO;

using MyTICs.iOS.Implementations;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteIOS))]
namespace MyTICs.iOS.Implementations
{
    public class SQLiteIOS : ISQLite
    {
        public SQLiteIOS()
        {

        }

        public SQLiteConnection GetConnection()
        {            
            var sqlLiteFileName = "MyTICs.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(libraryPath, sqlLiteFileName);

            var cnn = new SQLiteConnection(path);

            return cnn;
        }
    }
}
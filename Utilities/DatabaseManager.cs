using DungeonWiki.Databases.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Data.SQLite;
using System.Xml.Linq;

namespace DungeonWiki.Utilities
{
    public class DatabaseManager
    {
        public static readonly string _databaseFolder = "Databases";
        public DatabaseManager()
        {
        }

        public WikiDatabase GetDatabase(string databaseName)
        {
            return new WikiDatabase(databaseName);
        }
    }

    public class WikiDatabase
    {
        private string databaseName;
        public string name { get { return databaseName.ToLower().Replace(" ", "_"); } }

        private string databaseFolder;
        private string databaseFile;

        private WikiDbContext context;
        public WikiDatabase(string _databaseName)
        {
            databaseName = _databaseName;
            databaseFolder = Path.Combine(Global.GetDirectory(), DatabaseManager._databaseFolder, name);
            databaseFile = Path.Combine(databaseFolder, $"{name}.db");
            context = new WikiDbContext(databaseFile);
        }

        public bool valid { get { return File.Exists(databaseFile) && context.Database.CanConnect(); } }

        public void Create()
        {
            if (!valid)
            {
                if (!File.Exists(databaseFile)) { 
                    if (!Directory.Exists(databaseFolder))
                    {
                        Directory.CreateDirectory(databaseFolder);
                    }
                    context.Database.Migrate();
                }
            }
        }
    }
}

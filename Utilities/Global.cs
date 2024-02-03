using System.Reflection;

namespace DungeonWiki.Utilities
{
    public static class Global
    {
        public static string GetDirectory()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;
        }
    }
}

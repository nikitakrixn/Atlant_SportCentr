
namespace Atlant_Project.Class
{
    internal class Settings
    {
        public static class Interface
        {
            public static bool LightTheme = true;
            public static bool DarkTheme = false;
        };
        
        public static class UserRole
        {
            public static bool admin = false;
            public static bool admin_new = false;
            public static bool guest = false;
            public static bool manager_raspisania = false;
            public static bool manager_clientov = false;
            public static bool manager_group = false;
            public static bool manager_trainer = false;
            public static bool manager_sections = false;
        };

        public static class SettingsConnect
        {
            public static bool Enabled = false;
            public static string Server { get; set; }
            public static string DataBase { get; set; }
            public static string UserName { get; set; }
            public static string Password { get; set; }
            public static string ConnectionString { get; set; }
        };
    }
}

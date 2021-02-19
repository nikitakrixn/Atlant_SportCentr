using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlant_Project.Class
{
    public class SingleConnection
    {
        private SingleConnection() {}
        private static SingleConnection _ConString = null;
        private String _String = null;
        public static string ConString
        {
            get
            {
                if ((_ConString == null))
                {
                    _ConString = new SingleConnection { _String = SingleConnection.Connect() };
                    return _ConString._String;
                }
                else
                    return _ConString._String;
            }
        }

        public static object EntityConnectionStringBulder { get; private set; }

        public static string Connect()
        {
            SqlConnectionStringBuilder cns = new SqlConnectionStringBuilder(Settings.SettingsConnect.ConnectionString);
            SqlConnectionStringBuilder sqlString = new SqlConnectionStringBuilder()
            {
                DataSource = cns.DataSource,
                InitialCatalog = cns.InitialCatalog,
                PersistSecurityInfo = true,
                UserID = cns.UserID,
                Password = cns.Password,
                MultipleActiveResultSets = true,
                ApplicationName = "EntityFramework",
            };

            EntityConnectionStringBuilder entityString = new EntityConnectionStringBuilder()
            {
                Provider = "System.Data.SqlClient",
                Metadata = "res://*/EntityFramework.AtlantModel.csdl|res://*/EntityFramework.AtlantModel.ssdl|res://*/EntityFramework.AtlantModel.msl",
                ProviderConnectionString = sqlString.ConnectionString,
            };

            return entityString.ConnectionString;
        }
    }
}

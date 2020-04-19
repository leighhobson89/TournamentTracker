using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {
            switch (db)
            {
                case DatabaseType.Sql:
                    SQLConnector sql = new SQLConnector();
                    Connection = sql;
                    break;
                case DatabaseType.Textfile:
                    TextConnector text = new TextConnector();
                    Connection = text;
                    break;
                default:
                    break;
            }
            /* if (db == DatabaseType.Sql)
             {
                 // TODO - Setup the SQL Connector properly
                 SQLConnector sql = new SQLConnector();
                 Connections = sql;
             }
             else if (db == DatabaseType.Textfile)
             {
                 // TODO - Create the Text Connection
                 TextConnector text = new TextConnector();
                 Connections = text;
             }*/
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
     public static class GlobalConfig
    {
        //public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static IDataConnection Connections { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {
            
            if (db == DatabaseType.Sql)
            {
                // TODO - Set up the SQL Connector properly
                SQLConnector sql = new SQLConnector();
                //Connections.Add(sql);
                Connections = sql;
                
                // TODO - Create the SQL connection
            }
            else if (db == DatabaseType.TextFile)
            {

                // TODO - Create the text connection
                TextConnector text = new TextConnector();
                //Connections.Add(text);
                Connections = text;
            }
        }

        public static string ConnectionString(string connectionString)
        {
            // we pass the name of the as string and we get back the name of the server.
            return ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;

        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
     public class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - Set up the SQL Connector properly
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
                
                // TODO - Create the SQL connection
            }
            if (textFiles)
            {

                // TODO - Create the text connection
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }

    }
}

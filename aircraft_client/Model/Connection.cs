using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_client.Model
{
    public class Connection
    {
        private readonly string Path = "Resource/config.txt";

        private static Connection DbConnect;


        public string Host { get; private set; }
        public string User { get; private set; }
        public string Port { get; private set; }
        public string Pas { get; private set; }
        public string ServiceName { get; private set; }
        public string connectionString { get; private set; }

        public static Connection Instance
        {
            get
            {
                if (DbConnect == null)
                {
                    DbConnect = new Connection();
                }
                return DbConnect;
            }
        }

        public Connection()
        {
            GetData();
            connectionString = "Data Source= (DESCRIPTION =" +
            "(ADDRESS = (PROTOCOL = TCP)" +
            "(HOST =" + Host + ")" +
            "(PORT = " + Port + "))" +
            "(CONNECT_DATA =(SERVER = DEDICATED)";
            if (ServiceName != null)
            {
                connectionString += "(SERVICE_NAME = " + ServiceName + ")));"
                        + "user id=" + User + "; password =" + Pas + ";";
            }
            else
                connectionString += ")); "
                         + "user id=" + User + "; password =" + Pas + ";";
        }

        private void GetData()
        {
            using (StreamReader sr = new StreamReader(Path))
            {
                while (!sr.EndOfStream)
                {
                    var data = sr.ReadLine().Split('=');
                    if (data[0] == "user")
                    {
                        User = data[1];
                    }
                    else if (data[0] == "password")
                    {
                        Pas = data[1];
                    }
                    else if (data[0] == "port")
                    {
                        Port = data[1];
                    }
                    else if (data[0] == "host")
                    {
                        Host = data[1];
                    }
                    else if (data[0] == "service name")
                    {
                        ServiceName = data[1];
                    }
                }
            }


        }
    }
}

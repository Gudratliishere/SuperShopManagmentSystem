﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SuperShopDatabase.Config
{
    public class Configuration
    {

        private readonly string connectionConfigFilePath = "database_connection.xml";
        private Connection connection = null;

        private static Configuration config = null;

        private Configuration () { }

        public static Configuration GetConfig ()
        {
            if (config == null)
                config = new Configuration();

            return config;
        }

        public void ResetConnection ()
        {
            connection = null;
        }
        
        public Connection GetConnection ()
        {
            if (connection != null)
                return connection;

            connection = new Connection();
            
            if (File.Exists(connectionConfigFilePath))
            {
                var xml = XmlReader.Create(connectionConfigFilePath);
                while (xml.Read())
                    if (xml.IsStartElement())
                        FillConnectionWithXml(connection, xml);
            }
            else
                FillConnectionWithDefault(connection);

            return connection;
        }

        public void WriteConnection (Connection connection)
        {
            if (!File.Exists(connectionConfigFilePath))
            {
                var file = File.Create(connectionConfigFilePath);
                file.Close();
            }

            var xml = XmlWriter.Create(connectionConfigFilePath);
            xml.WriteStartDocument();
            xml.WriteStartElement("details");
            xml.WriteElementString("host", connection.Host);
            xml.WriteElementString("port", connection.Port);
            xml.WriteElementString("username", connection.Encrypt(connection.Username));
            xml.WriteElementString("password", connection.Encrypt(connection.Password));
            xml.WriteElementString("database", connection.Database);
            xml.WriteElementString("crypt_power", connection.CryptPower.ToString());
            xml.WriteEndElement();
            xml.WriteEndDocument();
            xml.Close();
        }

        private void FillConnectionWithXml (Connection connection, XmlReader xml)
        {
            switch (xml.Name.ToString())
            {
                case "host":
                    connection.Host = xml.ReadString();
                    break;
                case "port":
                    connection.Port = xml.ReadString();
                    break;
                case "username":
                    connection.Username = connection.Decrypt(xml.ReadString());
                    break;
                case "password":
                    connection.Password = connection.Decrypt(xml.ReadString());
                    break;
                case "database":
                    connection.Database = xml.ReadString();
                    break;
                case "crypto_power":
                    connection.CryptPower = Int32.Parse(xml.ReadString());
                    break;
            }
        }

        private void FillConnectionWithDefault (Connection connection)
        {
            connection.Host = "localhost";
            connection.Port = "3306";
            connection.Username = "root";
            connection.Password = "12345678";
            connection.Database = "supershop";
        }
    }
}

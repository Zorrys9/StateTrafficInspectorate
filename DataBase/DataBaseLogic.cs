using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class DataBaseLogic
    {

        public static void Change(string conn)
        {
            SqlConnectionStringBuilder connect1 = new SqlConnectionStringBuilder();
            connect1.ConnectionString = conn;
            string conf_name = "GIBDD"; // название строки подключения из app.config
            ConnectionStringSettings cs = ConfigurationManager.ConnectionStrings[conf_name];
            cs = new ConnectionStringSettings(conf_name, connect1.ConnectionString, "System.Data.SqlClient");

            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // Получаем доступ к строкам подключения
            ConnectionStringsSection csSection = config.ConnectionStrings;
            // заменяем строку подключения
            csSection.ConnectionStrings.Remove(cs.Name);
            csSection.ConnectionStrings.Add(cs);
            // сохранение файла конфигурации
            config.Save(ConfigurationSaveMode.Modified);
        }

    }
}

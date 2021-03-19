using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;


namespace AcademiaDoProgramador2021.Helpers
{
    class Database
    {
        private String connectionString;

        public String getConnectionString()
        {
            connectionString = ConfigurationManager.ConnectionStrings["AcademiaDoProgramador2021.Properties.Settings.crudConnectionString"].ConnectionString;
            return connectionString;
        }

    }
}
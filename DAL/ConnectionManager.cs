﻿using System.Data.SqlClient;

namespace DAL
{
    class ConnectionManager
    {

        internal SqlConnection _conexion;
        public ConnectionManager(string connectionString)
        {
            _conexion = new SqlConnection(connectionString);
        }
        public void Open()
        {
            _conexion.Open();
        }
        public void Close()
        {
            _conexion.Close();
        }

    }
}
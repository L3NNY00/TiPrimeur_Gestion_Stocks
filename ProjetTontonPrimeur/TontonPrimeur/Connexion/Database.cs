using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TontonPrimeur.Connexion
{
    internal class Database
    {
        public DataTable requeteBDD(string id, string mdp, string requete)
        {
            string connectionString = $"Server=localhost;Database=stock_fruits_legumes;Uid={id};Pwd={mdp};";

            using (var connection = new MySqlConnector.MySqlConnection(connectionString))
            {
                connection.Open();
                using (var adapter = new MySqlConnector.MySqlDataAdapter(requete, connection))
                {
                    var table = new System.Data.DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
    }
}

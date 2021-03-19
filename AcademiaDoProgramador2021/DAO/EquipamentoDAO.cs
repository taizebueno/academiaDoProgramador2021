using System;
using MySql.Data.MySqlClient;

namespace AcademiaDoProgramador2021.DAO
{
    class EquipamentoDAO
    {
        private Helpers.Database db;
        private MySqlConnection con;

        public EquipamentoDAO()
        {

        }

        public void InserirEquipamento(String nome, Int32 numero_serie, Double preco, String data_fabricacao)
        {
            con = new MySqlConnection();
            db = new Helpers.Database();
            con.ConnectionString = db.getConnectionString();
            String query = "INSERT INTO equipamentos (nome, numero_serie, preco, data_fabricacao) VALUES " +
                "(?nome, ?numero_serie, ?preco, ?data_fabricacao)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?numero_serie", numero_serie);
                cmd.Parameters.AddWithValue("?preco", preco);
                cmd.Parameters.AddWithValue("?data_fabricacao", data_fabricacao);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public void AtualizarEquipamento(String itemcodigo, String itemdescricao, Double itempreco, Int32 itemid)
        {
            con = new MySqlConnection();
            db = new Helpers.Database();
            con.ConnectionString = db.getConnectionString();
            String query = "UPDATE inventario SET itemcodigo = ?itemcodigo, itemdescricao = ?itemdescricao, itempreco = ?itempreco";
            query += " WHERE itemid = ?itemid";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemcodigo", itemcodigo);
                cmd.Parameters.AddWithValue("?itemdescricao", itemdescricao);
                cmd.Parameters.AddWithValue("?itempreco", itempreco);
                cmd.Parameters.AddWithValue("?itemid", itemid);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void RemoverEquipamento(String itemcodigo, Int32 itemid)
        {
            con = new MySqlConnection();
            db = new Helpers.Database();
            con.ConnectionString = db.getConnectionString();
            String query = "DELETE FROM inventario ";
            query += "WHERE itemcodigo = ?itemcodigo AND itemid = ?itemid";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemcodigo", itemcodigo);
                cmd.Parameters.AddWithValue("?itemid", itemid);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
    }

}

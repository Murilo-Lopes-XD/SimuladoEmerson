using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulado.Controller
{
    public class profControll
    {
        MySqlConnection conn = new MySqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\source\\repos\\Simulado\\Simulado\\Database1.mdf;Integrated Security=True");

        public void Inserir(string Nome, string Email, string Senha)
        {
            string sql = "INSERT INTO TbProfessor(Nome,Email,Senha) VALUES (@Nome,@Email,@Senha)";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@Nome", MySqlDbType.String).Value = Nome;
                cmd.Parameters.Add("@Email", MySqlDbType.String).Value = Email;
                cmd.Parameters.Add("@Senha", MySqlDbType.String).Value = Senha;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        public bool Verificar(string Email, string Senha)
        {
            string sql = "SELECT * FROM TbProfessor WHERE Email ='" + Email + "' AND Senha ='" + Senha + "'";
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                MySqlDataReader dr = cmd.ExecuteReader();
                if (Email == dr["Email"].ToString() && Senha == dr["Senha"].ToString())
                {
                    return true;
                }
            }
            conn.Close();
            return false;
        }
    }
}

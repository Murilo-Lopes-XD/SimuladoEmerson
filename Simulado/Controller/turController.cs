using MySqlConnector;
using Simulado.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Simulado.Controller
{
    public class turController
    {
        MySqlConnection conn = new MySqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\source\\repos\\Simulado\\Simulado\\Database1.mdf;Integrated Security=True");

        public void InserirTurma(string Numero, string Nome, string NomeProfessor)
        {
            string sql = "INSERT INTO tbTurma(Numero,Nome,NomeProfessor) VALUES (@Numero,@Nome,@NomeProfessor)";
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@Numero", MySqlDbType.String).Value = Numero;
                cmd.Parameters.Add("@Nome", MySqlDbType.String).Value = Nome;
                cmd.Parameters.Add("@NomeProfessor", MySqlDbType.String).Value = NomeProfessor;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        public void ExcluirTurma(int Id)
        {
            string sql = "DELETE FROM tbTurma WHERE Id = '" + Id + "'";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void AtualizarTurma(int Id, string Numero, string Nome, string NomeProfessor)
        {
            string sql = "UPDATE tbTurma SET Numero=@Numero,Nome=@Nome,NomeProfessor=@NomeProfessor WHERE Id=@Id";
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@Numero", MySqlDbType.String).Value = Numero;
                cmd.Parameters.Add("@Nome", MySqlDbType.String).Value = Nome;
                cmd.Parameters.Add("@NomeProfessor", MySqlDbType.String).Value = NomeProfessor;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        public void LocalizarTurma(int Id)
        {
            Turma turma = new Turma();
            string sql = "SELECT * FROM tbTurma WHERE Id='" + Id + "'";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                turma.Id = (int)dr["Id"];
                turma.Numero = dr["Numero"].ToString();
                turma.Nome = dr["Nome"].ToString();
                turma.NomeProfessor = dr["NomeProfessor"].ToString();
            }
            dr.Close();
            conn.Close();
        }
    }
}

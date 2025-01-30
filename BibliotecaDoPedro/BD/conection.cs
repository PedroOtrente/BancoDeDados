using MySql.Data.MySqlClient;
using Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class conection
    {
        public MySqlConnection conectar()
        {
            string strCon = "server=localhost; uid=root;pwd=;database=pedro";
            MySqlConnection qlqrum = new MySqlConnection(strCon);
            qlqrum.Open();
            return qlqrum;
        }
    }

    public class bdusuario
    {
        conection con = new conection();
        public DataTable login(Usuario usuario)
        {
            MySqlConnection ai = con.conectar();
            MySqlCommand ui = new MySqlCommand("Select * from usuarios where Login = @algumacoisa and Senha = @naosei", ai);
            ui.Parameters.AddWithValue("@algumacoisa", usuario.Login);
            ui.Parameters.AddWithValue("@naosei", usuario.Senha);
            MySqlDataAdapter da = new MySqlDataAdapter(ui);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public bool verificarocaodousuario(Usuario qlqum)
        {
            MySqlConnection tantofaz = con.conectar();
            MySqlCommand oin = new MySqlCommand("select * from usuarios where Login = @aff or Email = @cu ", tantofaz);
            oin.Parameters.AddWithValue("@aff", qlqum.Login);
            oin.Parameters.AddWithValue("@cu", qlqum.Email);
            MySqlDataReader a;
            a = oin.ExecuteReader();
            return (a.Read());
        }

        public void cadastraressecu(Usuario ain)
        {
            MySqlConnection tantofaz = con.conectar();
            MySqlCommand afff = new MySqlCommand("insert into usuarios (Login, Senha, Email) values(@login, @senha, @email)", tantofaz);
            afff.Parameters.AddWithValue("@login", ain.Login);
            afff.Parameters.AddWithValue("@senha", ain.Senha);
            afff.Parameters.AddWithValue("@email", ain.Email);
            afff.ExecuteNonQuery();
        }
    }
}
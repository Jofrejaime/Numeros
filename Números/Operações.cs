using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Bunifu.Framework.UI;
namespace Números
{
    class Operações
    {
        MySqlConnection conecter = new MySqlConnection("Server=localhost; user = root; password=''; database= soma");
        MySqlDataAdapter Adapter;
        MySqlCommand comando;
              
        public void apresentar(BunifuCustomDataGrid dg)
        {
            this.Adapter = new MySqlDataAdapter("SELECT*FROM numeros", conecter);
            DataTable table = new DataTable();
            table.Clear();
            this.Adapter.Fill(table);
            dg.DataSource = table;
        }
        public void somar(BunifuMaterialTextbox num1, BunifuMaterialTextbox num2, BunifuCustomDataGrid dg)
        {
            if (num1.Text.Equals("")|| num2.Text.Equals(null))
            {
                throw new ArgumentNullException();
            }
            else
            {
            this.conecter.Open();
            this.comando = new MySqlCommand("INSERT INTO numeros(nota1, nota2, resultado) values(@nota1, @nota2, @res)", conecter);
            this.comando.Parameters.Add("@nota1", MySqlDbType.Int64).Value= Convert.ToInt64( num1.Text);
            this.comando.Parameters.Add("@nota2", MySqlDbType.Int64).Value = Convert.ToInt64(num2.Text);
                long soma = Convert.ToInt64(num2.Text) + Convert.ToInt64(num1.Text);
            this.comando.Parameters.Add("@res", MySqlDbType.Int64).Value = soma;
            this.comando.ExecuteNonQuery();
            this.conecter.Close();
            this.apresentar(dg);
            }
           
        }
        public void pesquisar(BunifuCustomDataGrid dg, BunifuTextbox texto)
        {
            if (texto.text.Equals("")||texto.text.Equals(null))
            {
                throw new FormatException();
            }
            else
            {
            long id = Convert.ToInt64(texto.text);
            this.Adapter = new MySqlDataAdapter("SELECT*FROM numeros order by id desc limit @num ", conecter);
            Adapter.SelectCommand.Parameters.Add("@num", MySqlDbType.Double).Value = id;
            DataTable table = new DataTable();
            table.Clear();
            this.Adapter.Fill(table);
            dg.DataSource = table;
         
            }
             
        }
    }
}

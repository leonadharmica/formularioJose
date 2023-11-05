using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace formularioJoseArengue
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Server=Jessica;Database=trabajoJoseArengue;
        User Id=sa;Password=rominis2;");
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Insert into formularioJoseArengue (Nombre, Apellido, Domicilio) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", sqlConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Datos ingresados correctamente");
            sqlConnection.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

       
    }
}

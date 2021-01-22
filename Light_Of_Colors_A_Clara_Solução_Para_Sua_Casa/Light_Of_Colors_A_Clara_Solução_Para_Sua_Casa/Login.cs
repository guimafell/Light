using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Light_Of_Colors_A_Clara_Solução_Para_Sua_Casa
{
    public partial class Login : Form
    { 
        
        public Login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if (c is MdiClient)
                {
                    c.BackColor = Color.Black;
                    label1.BackColor = Color.Black;
                    label1.ForeColor = Color.White;
                    label2.BackColor = Color.Black;
                    label2.ForeColor = Color.White;


                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
            this.Close();
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.ShowDialog();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexao conexao = new conexao();
            SqlCommand command = new SqlCommand("SELECT *FROM USUARIO WHERE EMAIL=@EMAIL AND SENHA=@SENHA", conexao.sql);
            command.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = EMAIL.Text;
            command.Parameters.Add("@SENHA", SqlDbType.VarChar).Value = SENHA.Text;

            try
            {




                conexao.sql.Open();
                SqlDataReader drms = command.ExecuteReader();

                if (drms.HasRows == false)
                {

                    throw new Exception("Usuario ou senha incorreto");

                }

                drms.Read();

                MessageBox.Show("Seja bem vindo!!", "SISTEMA DE CADASTRAMENTO", MessageBoxButtons.OK);

                Funcionário funcionário = new Funcionário();

                this.Hide();

                funcionário.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.sql.Close();
            }
        }
    }
}

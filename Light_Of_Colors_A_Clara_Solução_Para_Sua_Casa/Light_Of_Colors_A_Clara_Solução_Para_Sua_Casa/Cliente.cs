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
    public partial class Cliente : Form
    {
        conexao conexao = new conexao();
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                {
                    c.BackColor = Color.Black;
                    label2.BackColor = Color.Black;
                    label2.ForeColor = Color.White;
                    label5.BackColor = Color.Black;
                    label5.ForeColor = Color.White;
                    label6.BackColor = Color.Black;
                    label6.ForeColor = Color.White;
                    label7.BackColor = Color.Black;
                    label7.ForeColor = Color.White;
                    label8.BackColor = Color.Black;
                    label8.ForeColor = Color.White;
                    label9.BackColor = Color.Black;
                    label9.ForeColor = Color.White;
                    label10.BackColor = Color.Black;
                    label10.ForeColor = Color.White;
                    label11.ForeColor = Color.White;
                    label11.BackColor = Color.Black;
                    button1.BackColor = Color.White;
                    button1.ForeColor = Color.Black;


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT *FROM USUARIO WHERE NCASA=@NCASA AND NRUA=@NRUA",conexao.sql);
            command.Parameters.Add("@NRUA", SqlDbType.VarChar).Value = N_RUA.Text;
            command.Parameters.Add("@NCASA", SqlDbType.VarChar).Value = N_CASA.Text;

            try
            {
                conexao.sql.Open();
                SqlDataReader drms = command.ExecuteReader();

                if (drms.HasRows == false)
                {

                    throw new Exception("não encontrei");

                }

                drms.Read();

                NOME.Text = Convert.ToString(drms["NOME"]);
                TELEFONE.Text = Convert.ToString(drms["FONE"]);
                PERFIL.Text = Convert.ToString(drms["PERFIL"]);
                SETOR.Text = Convert.ToString(drms["SETOR"]);
                N_CASA.Text = Convert.ToString(drms["NCASA"]);
                N_RUA.Text = Convert.ToString(drms["NRUA"]);
                CONTA.Text = Convert.ToString(drms["CONTA"]);
                PAGO.Text = Convert.ToString(drms["PAGO"]);

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

        private void button2_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.ShowDialog();
        }
    }
}

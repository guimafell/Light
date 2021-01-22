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
    public partial class Funcionário : Form
    {
        conexao conexao = new conexao();
       
       
       
        public Funcionário()
        {
            InitializeComponent();
           
           
        }

        private void Funcionário_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                {
                    c.BackColor = Color.Black;
                    label1.BackColor = Color.Black;
                    label1.ForeColor = Color.White;
                    label2.BackColor = Color.Black;
                    label2.ForeColor = Color.White;
                    label3.BackColor = Color.Black;
                    label3.ForeColor = Color.White;
                    label4.BackColor = Color.Black;
                    label4.ForeColor = Color.White;
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
                    


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("INSERT INTO USUARIO(IDUSER,NOME,EMAIL,SENHA,FONE,PERFIL,SETOR,NCASA,NRUA,CONTA,PAGO) VALUES(@IDUSER,@NOME,@EMAIL,@SENHA,@FONE,@PERFIL,@SETOR,@NCASA,@NRUA,@CONTA,@PAGO)", conexao.sql);

            command.Parameters.Add("@IDUSER", SqlDbType.Int).Value = ID.Text;

            command.Parameters.Add("@NOME", SqlDbType.VarChar).Value = NOME.Text;

            command.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = EMAIL.Text;

            command.Parameters.Add("@SENHA", SqlDbType.VarChar).Value = SENHA.Text;

            command.Parameters.Add("@FONE", SqlDbType.VarChar).Value = TELEFONE.Text;

            command.Parameters.Add("@PERFIL", SqlDbType.VarChar).Value = PERFIL.Text;

            command.Parameters.Add("@SETOR", SqlDbType.VarChar).Value = SETOR.Text;

            command.Parameters.Add("@NCASA", SqlDbType.VarChar).Value = N_CASA.Text;

            command.Parameters.Add("@NRUA", SqlDbType.VarChar).Value = N_RUA.Text;

            command.Parameters.Add("@CONTA", SqlDbType.VarChar).Value = CONTA.Text;

            command.Parameters.Add("@PAGO", SqlDbType.VarChar).Value = PAGO.Text;




            if (ID.Text != "" && NOME.Text != "" && EMAIL.Text != "" && SENHA.Text != "" && PERFIL.Text != "" && SETOR.Text != "" && N_CASA.Text != "" && N_RUA.Text != "" && CONTA.Text != "" && PAGO.Text != "")
            {
                try
                {
                    conexao.sql.Open();

                    command.ExecuteNonQuery();

                    MessageBox.Show("cadastro efetuado com sucesso", "SISTEMA DE CADASTRAMENTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ID.Text = "";
                    NOME.Text = "";
                    EMAIL.Text = "";
                    SENHA.Text = "";
                    PERFIL.Text = "";
                    SETOR.Text = "";
                    N_CASA.Text = "";
                    N_RUA.Text = "";
                    CONTA.Text = "";
                    PAGO.Text = "";
                    TELEFONE.Text = "";

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
            else
            {

                MessageBox.Show("Preencha todos os campos", "Sistema de cadastramento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ID.Text = "";
            NOME.Text = "";
            EMAIL.Text = "";
            SENHA.Text = "";
            PERFIL.Text = "";
            SETOR.Text = "";
            N_CASA.Text = "";
            N_RUA.Text = "";
            CONTA.Text = "";
            PAGO.Text = "";
            TELEFONE.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE USUARIO SET NOME=@NOME,EMAIL=@EMAIL,SENHA=@SENHA,FONE=@FONE,PERFIL=@PERFIL,SETOR=@SETOR,NCASA=@NCASA,NRUA=@NRUA,CONTA=@CONTA,PAGO=@PAGO WHERE IDUSER=@IDUSER", conexao.sql);

            if (ID.Text != "" & NOME.Text != "" & EMAIL.Text != "" & SENHA.Text != "" & PERFIL.Text != "" & SETOR.Text != "" & N_CASA.Text != "" & N_RUA.Text != "" & CONTA.Text != "" & PAGO.Text != "")

            {
                try

                {

                    conexao.sql.Open();

                    command.ExecuteNonQuery();

                    MessageBox.Show("cadastro alterado com sucesso", "SISTEMA DE CADASTRAMENTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ID.Text = "";

                    NOME.Text = "";

                    EMAIL.Text = "";

                    SENHA.Text = "";

                    PERFIL.Text = "";

                    SETOR.Text = "";

                    N_CASA.Text = "";

                    N_RUA.Text = "";

                    CONTA.Text = "";

                    PAGO.Text = "";

                    TELEFONE.Text = "";

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

            else
            {
                MessageBox.Show("Preencha todos os campos", "Sistema de cadastramento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT *FROM USUARIO WHERE IDUSER=@IDUSER", conexao.sql);
            command.Parameters.Add("@IDUSER", SqlDbType.VarChar).Value = ID.Text;

            try
            {
                conexao.sql.Open();
                SqlDataReader drms = command.ExecuteReader();

                if (drms.HasRows == false)
                {

                    throw new Exception("não encontrei");

                }

                drms.Read();

                ID.Text = Convert.ToString(drms["IDUSER"]);
                NOME.Text = Convert.ToString(drms["NOME"]);
                EMAIL.Text = Convert.ToString(drms["EMAIL"]);
                SENHA.Text = Convert.ToString(drms["SENHA"]);
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

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM USUARIO WHERE IDUSER = @IDUSER", conexao.sql);
            command.Parameters.Add("@IDUSER", SqlDbType.VarChar).Value = ID.Text;

            try
            {




                conexao.sql.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("cadastro excluído com sucesso", "SISTEMA DE CADASTRAMENTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ID.Text = "";
                NOME.Text = "";
                EMAIL.Text = "";
                SENHA.Text = "";
                PERFIL.Text = "";
                SETOR.Text = "";
                N_CASA.Text = "";
                N_RUA.Text = "";
                CONTA.Text = "";
                PAGO.Text = "";
                TELEFONE.Text = "";

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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.ShowDialog();
        }
    }
}

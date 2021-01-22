using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Light_Of_Colors_A_Clara_Solução_Para_Sua_Casa
{
    public partial class Inicio : Form
    {
        //conexão com a classe
        conexao conexao = new conexao();
        public int cores;


#region variáveis
        int n1 =0, n2 = 0, n3 = 0, n4 = 0, n5 = 0, n6 = 0, n7 = 0, n8 = 0;
        double tp1 = 0, tp2 = 0, tp3 = 0, te1 = 0, te2 = 0, te3 = 0, te4 = 0, te5 = 0, te6 = 0, te7 = 0, te8 = 0;
        double v1, v2, v3, v4, v5, v6, v7, v8, total;
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pesquisaPorCasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            this.Hide();
            cliente.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Qcel_TextChanged(object sender, EventArgs e)
        {

        }

        private void Qlamp_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void claroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


                    
                
            
        }

        private void escuroToolStripMenuItem_Click(object sender, EventArgs e)
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
                        menuStrip1.BackColor = Color.Black;
                        menuStrip1.ForeColor = Color.White;
                        checkBox1.BackColor = Color.Black;
                        checkBox1.ForeColor = Color.White;
                        checkBox2.BackColor = Color.Black;
                        checkBox2.ForeColor = Color.White;
                        checkBox3.BackColor = Color.Black;
                        checkBox3.ForeColor = Color.White;
                        checkBox4.BackColor = Color.Black;
                        checkBox4.ForeColor = Color.White;
                        checkBox5.BackColor = Color.Black;
                        checkBox5.ForeColor = Color.White;
                        checkBox6.BackColor = Color.Black;
                        checkBox6.ForeColor = Color.White;
                        checkBox7.BackColor = Color.Black;
                        checkBox7.ForeColor = Color.White;
                        checkBox8.BackColor = Color.Black;
                        checkBox8.ForeColor = Color.White;
                    }
                }
            
        }
 

        public Inicio()
        {
            InitializeComponent();
           
        }
        private void modoClaroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            TPlamp.Text = "Fluorescente";
            Qlamp.Text = "0";
            TLlamp.Text = "0";
            T1.Text = "Horas";


            Qcel.Text = "0";
            TLcel.Text = "0";
            T2.Text = "Hora";

            Qar.Text = "0";
            TPar.Text = "7.500 btu";
            TLar.Text = "0";
            T3.Text = "Hora";

            Qcomp.Text = "0";
            TPcomp.Text = "Notebook";
            TLcomp.Text = "0";
            T4.Text = "Hora";

            Qchuv.Text = "0";
            TLchuv.Text = "0";
            T5.Text = "Hora";

            Qfree.Text = "0";
            TLfree.Text = "0";
            T6.Text = "Hora";

            Qtv.Text = "0";
            TLtv.Text = "0";
            T7.Text = "Hora";

            Qmicro.Text = "0";
            TLmicro.Text = "0";
            T8.Text = "Hora";

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
                    menuStrip1.BackColor = Color.Black;
                    menuStrip1.ForeColor = Color.White;
                    checkBox1.BackColor = Color.Black;
                    checkBox1.ForeColor = Color.White;
                    checkBox2.BackColor = Color.Black;
                    checkBox2.ForeColor = Color.White;
                    checkBox3.BackColor = Color.Black;
                    checkBox3.ForeColor = Color.White;
                    checkBox4.BackColor = Color.Black;
                    checkBox4.ForeColor = Color.White;
                    checkBox5.BackColor = Color.Black;
                    checkBox5.ForeColor = Color.White;
                    checkBox6.BackColor = Color.Black;
                    checkBox6.ForeColor = Color.White;
                    checkBox7.BackColor = Color.Black;
                    checkBox7.ForeColor = Color.White;
                    checkBox8.BackColor = Color.Black;
                    checkBox8.ForeColor = Color.White;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TPlamp.Visible = true;
            Qlamp.Visible = true;
            TLlamp.Visible = true;
            T1.Visible = true;
            TPlamp.Text = "";
            Qlamp.Text = "";
            TLlamp.Text = "";
            T1.Text = "";



        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Qcel.Visible = true;
            TLcel.Visible = true;
            T2.Visible = true;
            Qcel.Text = "";
            TLcel.Text = "";
            T2.Text = "";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Qar.Visible = true;
            TPar.Visible = true;
            TLar.Visible = true;
            T3.Visible = true;
            Qar.Text = "";
            TPar.Text = "";
            TLar.Text = "";
            T3.Text = "";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Qcomp.Visible = true;
            TPcomp.Visible = true;
            TLcomp.Visible = true;
            T4.Visible = true;
            Qcomp.Text = "";
            TPcomp.Text = "";
            TLcomp.Text = "";
            T4.Text = "";


        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Qchuv.Visible = true;
            TLchuv.Visible = true;
            T5.Visible = true;
            Qchuv.Text = "";
            TLchuv.Text = "";
            T5.Text = "";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            Qfree.Visible = true;
            TLfree.Visible = true;
            T6.Visible = true;
            Qfree.Text = "";
            TLfree.Text = "";
            T6.Text = "";
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            Qtv.Visible = true;
            TLtv.Visible = true;
            T7.Visible = true;
            Qtv.Text = "";
            TLtv.Text = "";
            T7.Text = "";
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            Qmicro.Visible = true;
            TLmicro.Visible = true;
            T8.Visible = true;
            Qmicro.Text = "";
            TLmicro.Text = "";
            T8.Text="";
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Quantidade
            
            n1 = Convert.ToInt32(Qlamp.Text);
                            n2 = Convert.ToInt32(Qcel.Text);
            
                n3 = Convert.ToInt32(Qar.Text);
            
                n4 = Convert.ToInt32(Qcomp.Text);
                           n5 = Convert.ToInt32(Qchuv.Text);
            
                n6 = Convert.ToInt32(Qfree.Text);
            
                n7 = Convert.ToInt32(Qtv.Text);
                            n8 = Convert.ToInt32(Qmicro.Text);
            
            #endregion
            #region Tipo
            if (TPlamp.Text == "Fluorescente")
            {
                tp1=16.33;
            }
            if (TPlamp.Text == "Incandescente")
            {
                tp1 = 80;
            }
            
            switch (TPar.Text)
            {
                case "7.500 btu":
                    tp2 = 1000;
                    break;

                case "10.000 btu":
                    tp2 = 1350 ;
                    break;
                case "12.000 btu":
                    tp2 = 1450;
                    break;
                case "15.000 btu":
                    tp2 = 2000;
                    break;
                case "18.000 btu":
                    tp2 = 2100;
                    break;
            }

            if (TPcomp.Text == "Notebook")
            {
                tp3 = 157.5;
            }
            if (TPcomp.Text == "Computador")
            {
                tp3 = 372000;
            }
            #endregion
            #region tempo
            if (TLlamp.Text != "0")
                if (T1.Text == "Minuto")
            {
                
                    te1 = Convert.ToDouble(TLlamp.Text) / 60;
            }
            else
            {
                
                    te1 = Convert.ToDouble(TLlamp.Text);
            }
            
            if (TLcel.Text != "0")
                if (T2.Text == "Minuto")
            {
                te2 = Convert.ToDouble(TLcel.Text) / 60;
            }
            else
            {
                te2 = Convert.ToDouble(TLcel.Text);
            }

            if (TLar.Text != "0")
                if (T3.Text == "Minuto")
            {
                te3 = Convert.ToDouble(TLar.Text) / 60;
            }
            else
            {
                te3 = Convert.ToDouble(TLar.Text);
            }

            if (TLcomp.Text != "0")
                if (T4.Text == "Minuto")
            {
                te4 = Convert.ToDouble(TLcomp.Text) / 60;
            }
            else
            {
                te4 = Convert.ToDouble(TLcomp.Text);
            }

            if (TLchuv.Text != "0")
                if (T5.Text == "Minuto")
            {
                te5 = Convert.ToDouble(TLchuv.Text) / 60;
            }
            else
            {
                te5 = Convert.ToDouble(TLchuv.Text);
            }

            if (TLfree.Text != "0")
                if (T6.Text == "Minuto")
            {
                te6 = Convert.ToDouble(TLfree.Text) / 60;
            }
            else
            {
                te6 = Convert.ToDouble(TLfree.Text);
            }
            if (TLtv.Text != "0")
                if (TLlamp.Text != "0")
                if (T7.Text == "Minuto")
            {
                te7 = Convert.ToDouble(TLtv.Text) / 60;
            }
            else
            {
                te7 = Convert.ToDouble(TLtv.Text);
            }

            if (TLmicro.Text != "0")
                if (T8.Text == "Minuto")
            {
                te8 = Convert.ToDouble(TLmicro.Text) / 60;
            }
            else
            {
                te8 = Convert.ToDouble(TLmicro.Text);
            }
            #endregion
            #region calculo
            v1 = (((n1 * tp1) * te1) / 1000) * 0.30;
            v2 = (((n2 * 3.5) * te2) / 1000) * 0.30;
            v3 = (((n3 * tp2) * te3) / 1000) * 0.30;
            v4 = (((n4 * tp3) * te4) / 1000) * 0.30;
            v5 = (((n5 * 4500) * te5) / 1000) * 0.30;
            v6 = (((n6 * 130) * te6) / 1000) * 0.30;
            v7 = (((n7 * 220) * te7) / 1000) * 0.30;
            v8 = (((n8 * 1400) * te8) / 1000) * 0.30;

            total = v8 + v7 + v6 + v5 + v4 + v3 + v2 + v1;
            #endregion
            try
            {
                textBox1.Text = Convert.ToString(total);
                textBox1.Text = total.ToString("C");
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}

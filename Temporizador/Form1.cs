using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Temporizador
{
    public partial class mainForm : Form
    {
        bool start;
        public mainForm()
        {
            InitializeComponent();
            this.Width = 500;
            this.Height = 300;
            start = false;

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            


            //Fuentes
            Font font = new Font("Times New Roman", 30.0f, FontStyle.Bold);

            //Ajustes contador
            txtContador.Font = font;
            txtContador.Location = new Point((this.Width/2)-txtContador.Width/2, 40);
            txtContador.ReadOnly = true;
            txtContador.Text = "00:00:00";

            //Botones
            btnIniciar.Text = "On";
            btnApagar.Text = "Off";
            btnReiniciar.Text = "Restar";

            btnIniciar.BackColor = Color.FromArgb(52, 204, 235);
            btnReiniciar.BackColor = Color.FromArgb(190, 212, 104);
            btnApagar.BackColor = Color.FromArgb(240, 101, 62);

            btnIniciar.Size = new Size(129, 39);
            btnReiniciar.Size = new Size(129, 39);
            btnApagar.Size = new Size(129, 39);

            btnIniciar.ForeColor = Color.White;
            btnReiniciar.ForeColor = Color.White;
            btnApagar.ForeColor = Color.White;


            btnIniciar.Location = new Point((this.Width / 3) - btnIniciar.Width-20,200);
            btnReiniciar.Location = new Point((this.Width / 3)*2 - btnReiniciar.Width-20,200);
            btnApagar.Location = new Point((this.Width/3)*3 - btnApagar.Width-20,200);


            cmbSegundos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMinutos.DropDownStyle = ComboBoxStyle.DropDownList;

            panelCmbs.Location = new Point((this.Width / 2) - panelCmbs.Width / 2, 100);

            for (int i = 0; i < 60; i++)
            {
                cmbMinutos.Items.Add(i);
                cmbSegundos.Items.Add(i);
            }

        }

        int horas = 0;
        int segundos = 0;
        int minutos = 0;

        int restarH = 0;
        int restarS = 0;
        int restarM = 0;
        int dif = 0;

        DateTime time;

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Hilo
            Thread counter = new Thread(contador);


            if (txtHoras.Text != "" && cmbMinutos.Text != "" && cmbSegundos.Text != "")
            {
                horas = int.Parse(txtHoras.Text);
                segundos = int.Parse(cmbSegundos.Text);
                minutos = int.Parse(cmbMinutos.Text);

                restarH = horas;
                restarS = segundos;
                restarM = minutos;

                txtContador.Text = String.Format("{0}:{1}:{2}", horas, minutos, segundos);
                start = true;
                time = DateTime.Now;
                counter.Start();
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private void contador()
        {

            while (start)
            {
                try
                {
                    txtContador.Invoke(new MethodInvoker(delegate
                    {
                        DateTime fechaActual = DateTime.Now;

                        double diferencia = fechaActual.Subtract(time).TotalSeconds;
                        int sec = (int)diferencia;
                        dif = restarS - sec;
                        if (dif < 0 && minutos > 0)
                        {
                            segundos = 59;
                            minutos--;
                            time = DateTime.Now;


                        }
                        else if(dif < 0 && minutos <= 0 && horas > 0)
                        {
                            segundos = 59;
                            minutos = 59;
                            horas--;
                            time = DateTime.Now;

                        }

                        else if (dif == 0 && minutos == 0 && horas == 0)
                        {
                            segundos = 0;
                            minutos = 0;
                            horas = 0;
                            time = DateTime.Now;

                            start = false;
                        }
                        txtContador.Text = string.Format("{0}:{1}:{2}", horas,minutos, dif);
                    }));
                  
                }
                catch
                {

                }
            
            }
            
     
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            start = false;

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            horas = restarH;
            minutos = restarM;
            segundos = restarS;
        }
    }
}

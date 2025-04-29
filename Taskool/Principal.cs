using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taskool
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

            Task.Run(() =>
            {
                while (!IsDisposed)
                {
                    Invoke((Action)(AtualizarHorario));
                    Thread.Sleep(1000);
                }
            });
        }

        private void AtualizarHorario()
        {
            relogio.Text = DateTime.Now.ToString("HH:mm");

            if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour <= 17)
            {
                msgHorario.Text = "Boa tarde, {nome}!";
            }
            else if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour <= 23)
            {
                msgHorario.Text = "Boa noite, {nome}!";
            }
            else if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour <= 4)
            {
                msgHorario.Text = "Boa madrugada, {nome}!";
            }
            else if (DateTime.Now.Hour >= 4 && DateTime.Now.Hour <= 11)
            {
                msgHorario.Text = "Bom dia, {nome}!";
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

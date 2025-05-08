using GabrielForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GabrielForm
{
    public partial class parent : Form
    {
        public parent()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
        }
        public dbTarefasEntities ctx = new dbTarefasEntities();

        private void parent_Load(object sender, EventArgs e)
        {
            if (UserData.user != null)
            {
                if (UserData.user.Senha != null)
                {
                    try
                    {
                        Color corPanel;
                        var corHex = UserData.user.Senha.Trim().ToLower();

                        corPanel = ColorTranslator.FromHtml(corHex);

                        panel1.BackColor = corPanel;
                    } catch (Exception ex)
                    {
                        panel1.BackColor = Color.Transparent;
                        Debug.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            PutStyle(panel1);
        }

        private void PutStyle(Control panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c.HasChildren)
                    PutStyle(c);

                if (c is ComboBox cmb)
                    cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
    }
}

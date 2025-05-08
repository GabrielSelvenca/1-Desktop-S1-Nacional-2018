using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GabrielForm
{
    public partial class ConfigColors : parent
    {
        public ConfigColors()
        {
            InitializeComponent();
            this.Text = "Select Color | Taskool";
            maskedTextBox1.Text = "rbg(000, 000, 000)";
            maskedTextBox1.TextChanged += MaskedTextBox1_TextChanged;
        }

        private void MaskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskCompleted)
            {
                string text = maskedTextBox1.Text.Replace("rgb(", "").Replace(")", "");
                string[] maskParts = text.Split('.');

                cor = Color.FromArgb(int.Parse(maskParts[0]), int.Parse(maskParts[1]), int.Parse(maskParts[2]));
                panel1.BackColor = cor;

                textBox1.Text = $"#{cor.R:X2}{cor.G:X2}{cor.B:X2}";
            }
        }

        public ConfigColors(HomeForm homeForm)
        {
            InitializeComponent();
            this.Text = "Select Color | Taskool";
            HomeForm = homeForm;
            maskedTextBox1.Mask = "rgb(000, 000, 000)";
            maskedTextBox1.TextChanged += MaskedTextBox1_TextChanged;
        }

        Color cor = new Color();

        public HomeForm HomeForm { get; }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                cor = cd.Color;
                panel1.BackColor = cd.Color;
                textBox1.Text = $"#{cor.R:X2}{cor.G:X2}{cor.B:X2}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserData.user.Senha = $"{cor.Name}";

            var user = ctx.Usuario.Find(UserData.user.Codigo);
            user.Senha = $"rbg({cor.R:X2}, {cor.G:X2}, {cor.B:X2})";

            ctx.Entry(user).CurrentValues.SetValues(user);
            ctx.SaveChanges();

            HomeForm.Close();

            Close();
            new HomeForm().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var newColor = textBox1.Text.Replace("#", "");
            if (string.IsNullOrEmpty(newColor))
                return;

            cor = ColorTranslator.FromHtml($"#{newColor}");

            maskedTextBox1.Text = $"{cor.R}{cor.G}{cor.B}";
            panel1.BackColor = cor;
        }
    }
}

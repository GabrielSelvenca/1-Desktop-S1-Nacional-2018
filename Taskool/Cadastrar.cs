using System.Text.RegularExpressions;

namespace Taskool
{
    public partial class Cadastrar : Form
    {
        string caminhoFotoEnviada = "";

        public Cadastrar()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void input_Enter(object sender, EventArgs e)
        {
            var txtBox = sender as TextBox;
            txtBox.BorderStyle = BorderStyle.Fixed3D;
            var panel = txtBox.Parent as Panel;

            panel.BackColor = Color.Blue;
        }

        private void input_Leave(object sender, EventArgs e)
        {
            var txtBox = sender as TextBox;
            txtBox.BorderStyle = BorderStyle.FixedSingle;
            var panel = txtBox.Parent as Panel;

            panel.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] nome = textBox1.Text.Split(' ');
            string[] dataNasci = dateTimePicker1.Text.Split('/');
            string anoNasci = dataNasci[dataNasci.Length - 1].Substring(2, 2);

            if (nome.Length > 1)
            {
                string primeiroNome = nome[0].ToLower().Trim();
                string ultimoNome = nome[nome.Length - 1].ToLower().Trim();
                textBox4.Text = $"{primeiroNome}.{ultimoNome}{anoNasci}";
            }
            else
            {
                MessageBox.Show("Não foi possível gerar aleatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text;
            string nome = textBox1.Text;
            string telefone = textBox3.Text;
            string usuario = textBox4.Text;

            if (VerificarEmail(email))
            {
                MessageBox.Show("Email está fora do padrão da indústria", "Email inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nome.Length <= 0 || telefone.Length <= 0 || telefone.Length <= 0 || usuario.Length <= 0 || caminhoFotoEnviada.Length <= 0)
            {
                MessageBox.Show("Preencha todos os campos.", "Campos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Principal p = new Principal();
            p.Show();
            this.Hide();
        }

        private bool VerificarEmail(string email)
        {
            var emailValido = Regex.Match(@"^[a-zA-Z0-9._%-+]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", email);
            return emailValido.Success;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagens (*.png;*.jpg)|*.png;*.jpg";

            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.BackgroundImage = Image.FromFile(ofd.FileName);
                caminhoFotoEnviada = ofd.FileName;
            }
        }

        private void Cadastrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

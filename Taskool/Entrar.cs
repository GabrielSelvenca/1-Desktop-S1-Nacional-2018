using System.Diagnostics;

namespace Taskool
{
    public partial class Entrar : Form
    {
        string fotoEnviada = "";
        string caminhoUser_logs = "C:\\USER_LOGS";

        public class Usuario
        {
            public required string nome { get; set; }
            public required string caminhoFoto { get; set; }
            public int id { get; set; }
        }


        List<Usuario> usuarios = new List<Usuario>();


        public Entrar()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;
            KeyDown += Entrar_KeyDown;

            usuarios.Add(new Usuario { nome = "Gabriel", caminhoFoto = @"C:\foto_admin.png", id = 1 });
            usuarios.Add(new Usuario { nome = "Natália", caminhoFoto = @"C:\foto_admin.png", id = 2 });
            usuarios.Add(new Usuario { nome = "Lucas", caminhoFoto = @"C:\foto_admin.png", id = 3 });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuarioDigitado = userTxtbox.Text;

            string imagemAceita = @"C:\foto_admin.png";

            var usuarioOk = usuarios.FirstOrDefault(u => u.nome == usuarioDigitado);

            if (fotoEnviada.Length > 1)
            {
                bool fotoOk = VerificarImagem(imagemAceita, fotoEnviada);
                if (usuarioOk != null && fotoOk)
                {
                    Principal p = new Principal();
                    p.Show();
                    this.Hide();
                    return;
                }
            }

            Console.Beep();
            if (!Directory.Exists(caminhoUser_logs))
                Directory.CreateDirectory(caminhoUser_logs);

            string primeiroNome = usuarioDigitado.Split(' ')[0];
            string idUsuario = "nulo";

            var usuarioEncontrado = usuarios.FirstOrDefault(u => u.nome.Equals(usuarioDigitado, StringComparison.OrdinalIgnoreCase));
            if (usuarioEncontrado != null)
                idUsuario = usuarioEncontrado.id.ToString();

            string nomeDoArquivo = Path.Combine(caminhoUser_logs, $"{primeiroNome}{idUsuario}.txt");

            bool novoArquivo = !File.Exists(nomeDoArquivo);

            using (StreamWriter sw = new StreamWriter(nomeDoArquivo, append: true))
            {
                if (novoArquivo)
                {
                    sw.WriteLine("Data;Hora;Usuario;IP");
                }

                string data = DateTime.Now.ToString("dd/MM/yyyy");
                string hora = DateTime.Now.ToString("HH:mm");
                string usuario = usuarioDigitado;
                string ip = PegarIp();

                sw.WriteLine($"{data};{hora};{usuario};{ip}");
            }

            static string PegarIp()
            {
                return System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName())
                    .AddressList
                    .FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?
                    .ToString() ?? "IP Não encontrado";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c start osk";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.Start();
        }

        private void Entrar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
            {
                VerificarCaps(e);
            }
        }
        private void Entrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
            {
                VerificarCaps(e);
            }
        }

        private void VerificarCaps(KeyEventArgs e)
        {
            bool caps = IsKeyLocked(Keys.CapsLock);

            if (caps)
            {
                capsTxt.Visible = true;
            }
            else
            {
                capsTxt.Visible = false;
            }
        }

        private void emailBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.X))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagens (*.png;*.jpg)|*.png;*.jpg";

            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = Image.FromFile(ofd.FileName);
                fotoEnviada = ofd.FileName;
            }
        }

        private bool VerificarImagem(string caminho1, string caminho2)
        {
            byte[] imagem1 = File.ReadAllBytes(caminho1);
            byte[] imagem2 = File.ReadAllBytes(caminho2);

            if (imagem1.Length != imagem2.Length)
                return false;

            for (int i = 0; i < imagem1.Length; i++)
            {
                if (imagem1[i] != imagem2[i]) return false;
            }

            return true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.Show();
            this.Hide();
        }

        private void Entrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
namespace Taskool
{
    partial class Entrar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userTxtbox = new TextBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            label2 = new Label();
            linkLabel2 = new LinkLabel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            capsTxt = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // userTxtbox
            // 
            userTxtbox.Location = new Point(97, 180);
            userTxtbox.Name = "userTxtbox";
            userTxtbox.Size = new Size(262, 23);
            userTxtbox.TabIndex = 0;
            userTxtbox.KeyDown += emailBox_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 162);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(365, 183);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(85, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Teclado Virtual";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new Point(178, 369);
            button1.Name = "button1";
            button1.Size = new Size(92, 34);
            button1.TabIndex = 3;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(141, 61);
            label2.Name = "label2";
            label2.Size = new Size(205, 28);
            label2.TabIndex = 4;
            label2.Text = "Bem-vindo ao Taskool";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(192, 447);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(69, 15);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Cadastre-se";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.user;
            pictureBox1.Location = new Point(167, 267);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 96);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.DoubleClick += pictureBox1_DoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 249);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 7;
            label3.Text = "Credencial";
            // 
            // capsTxt
            // 
            capsTxt.AutoSize = true;
            capsTxt.Location = new Point(178, 206);
            capsTxt.Name = "capsTxt";
            capsTxt.Size = new Size(102, 15);
            capsTxt.TabIndex = 8;
            capsTxt.Text = "Caps-lock ativado";
            capsTxt.Visible = false;
            // 
            // Entrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 471);
            Controls.Add(capsTxt);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(userTxtbox);
            Name = "Entrar";
            Text = "Entrar";
            KeyDown += Entrar_KeyDown;
            KeyUp += Entrar_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userTxtbox;
        private Label label1;
        private LinkLabel linkLabel1;
        private Button button1;
        private Label label2;
        private LinkLabel linkLabel2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label capsTxt;
    }
}

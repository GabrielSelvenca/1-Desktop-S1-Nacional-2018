namespace Taskool
{
    partial class Cadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            emailBox = new TextBox();
            panel3 = new Panel();
            textBox3 = new TextBox();
            panel4 = new Panel();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(56, 130);
            label1.Name = "label1";
            label1.Size = new Size(46, 19);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(10, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 23);
            textBox1.TabIndex = 0;
            textBox1.Enter += input_Enter;
            textBox1.Leave += input_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(189, 59);
            label2.Name = "label2";
            label2.Size = new Size(157, 37);
            label2.TabIndex = 2;
            label2.Text = "Cadastre-se";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(62, 166);
            label3.Name = "label3";
            label3.Size = new Size(41, 19);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(44, 202);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 5;
            label4.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(47, 238);
            label5.Name = "label5";
            label5.Size = new Size(56, 19);
            label5.TabIndex = 7;
            label5.Text = "Usuário";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(12, 274);
            label6.Name = "label6";
            label6.Size = new Size(91, 19);
            label6.TabIndex = 9;
            label6.Text = "Data de nasc.";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(128, 274);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(95, 23);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.Value = new DateTime(2025, 4, 29, 10, 0, 56, 0);
            // 
            // button1
            // 
            button1.Location = new Point(439, 229);
            button1.Name = "button1";
            button1.Size = new Size(75, 39);
            button1.TabIndex = 4;
            button1.Text = "Gerar Aleatório";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(40, 354);
            label7.Name = "label7";
            label7.Size = new Size(72, 19);
            label7.TabIndex = 12;
            label7.Text = "Credencial";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(128, 324);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.user;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(128, 324);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 80);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(214, 335);
            button2.Name = "button2";
            button2.Size = new Size(92, 29);
            button2.TabIndex = 6;
            button2.Text = "Selecionar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(170, 434);
            button3.Name = "button3";
            button3.Size = new Size(201, 29);
            button3.TabIndex = 8;
            button3.Text = "Salvar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(128, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 30);
            panel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.Controls.Add(emailBox);
            panel2.Location = new Point(128, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(305, 30);
            panel2.TabIndex = 18;
            // 
            // emailBox
            // 
            emailBox.Cursor = Cursors.IBeam;
            emailBox.Location = new Point(10, 3);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(286, 23);
            emailBox.TabIndex = 1;
            emailBox.Enter += input_Enter;
            emailBox.Leave += input_Leave;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox3);
            panel3.Location = new Point(128, 199);
            panel3.Name = "panel3";
            panel3.Size = new Size(305, 30);
            panel3.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Location = new Point(10, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(286, 23);
            textBox3.TabIndex = 2;
            textBox3.Enter += input_Enter;
            textBox3.Leave += input_Leave;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox4);
            panel4.Location = new Point(128, 235);
            panel4.Name = "panel4";
            panel4.Size = new Size(305, 30);
            panel4.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Location = new Point(10, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(286, 23);
            textBox4.TabIndex = 3;
            textBox4.Enter += input_Enter;
            textBox4.Leave += input_Leave;
            // 
            // Cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 475);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cadastrar";
            Text = "Cadastrar";
            FormClosing += Cadastrar_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Panel panel2;
        private TextBox emailBox;
        private Panel panel3;
        private TextBox textBox3;
        private Panel panel4;
        private TextBox textBox4;
    }
}
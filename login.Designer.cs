namespace CrescimentoLimpo
{
    partial class login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.password = new System.Windows.Forms.TextBox();
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.entrar_login = new System.Windows.Forms.Button();
            this.registrar_login = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.relembrar = new System.Windows.Forms.CheckBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.password.Location = new System.Drawing.Point(373, 237);
            this.password.MaxLength = 50;
            this.password.Name = "password";
            this.password.PasswordChar = '•';
            this.password.Size = new System.Drawing.Size(200, 13);
            this.password.TabIndex = 22;
            this.password.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // PictureBox4
            // 
            this.PictureBox4.BackColor = System.Drawing.Color.White;
            this.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBox4.Location = new System.Drawing.Point(300, 222);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(282, 45);
            this.PictureBox4.TabIndex = 25;
            this.PictureBox4.TabStop = false;
            // 
            // Username
            // 
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Username.Location = new System.Drawing.Point(373, 184);
            this.Username.MaxLength = 50;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(200, 13);
            this.Username.TabIndex = 23;
            this.Username.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // PictureBox3
            // 
            this.PictureBox3.BackColor = System.Drawing.Color.White;
            this.PictureBox3.Location = new System.Drawing.Point(300, 168);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(282, 45);
            this.PictureBox3.TabIndex = 24;
            this.PictureBox3.TabStop = false;
            // 
            // entrar_login
            // 
            this.entrar_login.BackColor = System.Drawing.SystemColors.Highlight;
            this.entrar_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entrar_login.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.entrar_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.entrar_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrar_login.ForeColor = System.Drawing.Color.Transparent;
            this.entrar_login.Location = new System.Drawing.Point(374, 353);
            this.entrar_login.Name = "entrar_login";
            this.entrar_login.Size = new System.Drawing.Size(135, 39);
            this.entrar_login.TabIndex = 21;
            this.entrar_login.Text = "Login";
            this.entrar_login.UseVisualStyleBackColor = false;
            this.entrar_login.Click += new System.EventHandler(this.Button2_Click);
            // 
            // registrar_login
            // 
            this.registrar_login.BackColor = System.Drawing.SystemColors.Highlight;
            this.registrar_login.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.registrar_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registrar_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrar_login.ForeColor = System.Drawing.Color.Transparent;
            this.registrar_login.Location = new System.Drawing.Point(363, 411);
            this.registrar_login.Name = "registrar_login";
            this.registrar_login.Size = new System.Drawing.Size(157, 35);
            this.registrar_login.TabIndex = 20;
            this.registrar_login.Text = "Register";
            this.registrar_login.UseVisualStyleBackColor = false;
            this.registrar_login.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(366, 77);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(151, 31);
            this.Label3.TabIndex = 18;
            this.Label3.Text = "Login Now";
            // 
            // relembrar
            // 
            this.relembrar.AutoSize = true;
            this.relembrar.BackColor = System.Drawing.Color.Transparent;
            this.relembrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("relembrar.BackgroundImage")));
            this.relembrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relembrar.ForeColor = System.Drawing.Color.White;
            this.relembrar.Location = new System.Drawing.Point(300, 285);
            this.relembrar.Name = "relembrar";
            this.relembrar.Size = new System.Drawing.Size(117, 20);
            this.relembrar.TabIndex = 17;
            this.relembrar.Text = "Remember Me";
            this.relembrar.UseVisualStyleBackColor = false;
            this.relembrar.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.PictureBox2.Location = new System.Drawing.Point(242, 64);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(398, 56);
            this.PictureBox2.TabIndex = 19;
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox1.BackgroundImage")));
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox1.Location = new System.Drawing.Point(242, 118);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(9);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(398, 379);
            this.PictureBox1.TabIndex = 16;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox5.Location = new System.Drawing.Point(-6, -4);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(897, 27);
            this.pictureBox5.TabIndex = 64;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox6.Location = new System.Drawing.Point(-11, 540);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(929, 24);
            this.pictureBox6.TabIndex = 65;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(303, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 67;
            this.label4.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(304, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 68;
            this.label5.Text = "Password:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(852, -4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 27);
            this.button3.TabIndex = 66;
            this.button3.Text = " X";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(882, 562);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.password);
            this.Controls.Add(this.PictureBox4);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.entrar_login);
            this.Controls.Add(this.registrar_login);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.relembrar);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.PictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox password;
        internal System.Windows.Forms.PictureBox PictureBox4;
        internal System.Windows.Forms.TextBox Username;
        internal System.Windows.Forms.PictureBox PictureBox3;
        internal System.Windows.Forms.Button entrar_login;
        internal System.Windows.Forms.Button registrar_login;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.CheckBox relembrar;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.PictureBox pictureBox5;
        internal System.Windows.Forms.PictureBox pictureBox6;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Button button3;
    }
}


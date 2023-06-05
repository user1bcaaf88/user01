
namespace uvelirka
{
    partial class FormLogin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxCap = new System.Windows.Forms.TextBox();
            this.buttonVhod = new System.Windows.Forms.Button();
            this.buttonRefreshCap = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxCap = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabelVhod = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 94);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(145, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Логин";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(153, 146);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(137, 26);
            this.textBoxLogin.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(153, 243);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(137, 26);
            this.textBoxPassword.TabIndex = 6;
            // 
            // textBoxCap
            // 
            this.textBoxCap.Location = new System.Drawing.Point(168, 476);
            this.textBoxCap.Name = "textBoxCap";
            this.textBoxCap.Size = new System.Drawing.Size(137, 26);
            this.textBoxCap.TabIndex = 7;
            // 
            // buttonVhod
            // 
            this.buttonVhod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonVhod.Location = new System.Drawing.Point(171, 275);
            this.buttonVhod.Name = "buttonVhod";
            this.buttonVhod.Size = new System.Drawing.Size(107, 30);
            this.buttonVhod.TabIndex = 8;
            this.buttonVhod.Text = "Вход";
            this.buttonVhod.UseVisualStyleBackColor = false;
            this.buttonVhod.Click += new System.EventHandler(this.buttonVhod_Click);
            // 
            // buttonRefreshCap
            // 
            this.buttonRefreshCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonRefreshCap.Location = new System.Drawing.Point(186, 508);
            this.buttonRefreshCap.Name = "buttonRefreshCap";
            this.buttonRefreshCap.Size = new System.Drawing.Size(107, 33);
            this.buttonRefreshCap.TabIndex = 9;
            this.buttonRefreshCap.Text = "Обновить";
            this.buttonRefreshCap.UseVisualStyleBackColor = false;
            this.buttonRefreshCap.Click += new System.EventHandler(this.buttonRefreshCap_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxCap
            // 
            this.pictureBoxCap.Location = new System.Drawing.Point(135, 393);
            this.pictureBoxCap.Name = "pictureBoxCap";
            this.pictureBoxCap.Size = new System.Drawing.Size(223, 77);
            this.pictureBoxCap.TabIndex = 1;
            this.pictureBoxCap.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::uvelirka.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(9, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // linkLabelVhod
            // 
            this.linkLabelVhod.AutoSize = true;
            this.linkLabelVhod.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.linkLabelVhod.Location = new System.Drawing.Point(159, 324);
            this.linkLabelVhod.Name = "linkLabelVhod";
            this.linkLabelVhod.Size = new System.Drawing.Size(131, 20);
            this.linkLabelVhod.TabIndex = 10;
            this.linkLabelVhod.TabStop = true;
            this.linkLabelVhod.Text = "Войти как гость";
            this.linkLabelVhod.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVhod_LinkClicked);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 353);
            this.Controls.Add(this.linkLabelVhod);
            this.Controls.Add(this.buttonRefreshCap);
            this.Controls.Add(this.buttonVhod);
            this.Controls.Add(this.textBoxCap);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxCap);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(470, 610);
            this.MinimumSize = new System.Drawing.Size(470, 400);
            this.Name = "FormLogin";
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxCap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxCap;
        private System.Windows.Forms.Button buttonVhod;
        private System.Windows.Forms.Button buttonRefreshCap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabelVhod;
    }
}


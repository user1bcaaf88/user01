
namespace uvelirka
{
    partial class FormProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxFiltr = new System.Windows.Forms.ComboBox();
            this.radioButtonAsc = new System.Windows.Forms.RadioButton();
            this.radioButtonDesc = new System.Windows.Forms.RadioButton();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 94);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(531, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Меню";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(34, 148);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(200, 26);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // comboBoxFiltr
            // 
            this.comboBoxFiltr.FormattingEnabled = true;
            this.comboBoxFiltr.Location = new System.Drawing.Point(279, 148);
            this.comboBoxFiltr.Name = "comboBoxFiltr";
            this.comboBoxFiltr.Size = new System.Drawing.Size(269, 28);
            this.comboBoxFiltr.TabIndex = 3;
            this.comboBoxFiltr.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltr_SelectedIndexChanged);
            // 
            // radioButtonAsc
            // 
            this.radioButtonAsc.AutoSize = true;
            this.radioButtonAsc.Checked = true;
            this.radioButtonAsc.Location = new System.Drawing.Point(592, 146);
            this.radioButtonAsc.Name = "radioButtonAsc";
            this.radioButtonAsc.Size = new System.Drawing.Size(43, 24);
            this.radioButtonAsc.TabIndex = 4;
            this.radioButtonAsc.TabStop = true;
            this.radioButtonAsc.Text = "+";
            this.radioButtonAsc.UseVisualStyleBackColor = true;
            this.radioButtonAsc.CheckedChanged += new System.EventHandler(this.radioButtonAsc_CheckedChanged);
            // 
            // radioButtonDesc
            // 
            this.radioButtonDesc.AutoSize = true;
            this.radioButtonDesc.Location = new System.Drawing.Point(592, 186);
            this.radioButtonDesc.Name = "radioButtonDesc";
            this.radioButtonDesc.Size = new System.Drawing.Size(39, 24);
            this.radioButtonDesc.TabIndex = 5;
            this.radioButtonDesc.Text = "-";
            this.radioButtonDesc.UseVisualStyleBackColor = true;
            this.radioButtonDesc.CheckedChanged += new System.EventHandler(this.radioButtonDesc_CheckedChanged);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(30, 113);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(59, 20);
            this.labelCount.TabIndex = 6;
            this.labelCount.Text = "кол-во";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(688, 113);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(42, 20);
            this.labelFIO.TabIndex = 7;
            this.labelFIO.Text = "фио";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonDelete.Location = new System.Drawing.Point(12, 571);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(105, 29);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Назад";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.buttonInsert.Location = new System.Drawing.Point(539, 571);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(105, 29);
            this.buttonInsert.TabIndex = 9;
            this.buttonInsert.Text = "Добавить";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Location = new System.Drawing.Point(3, 224);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1100, 331);
            this.mainPanel.TabIndex = 10;
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
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 603);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.radioButtonDesc);
            this.Controls.Add(this.radioButtonAsc);
            this.Controls.Add(this.comboBoxFiltr);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProduct";
            this.Text = "Меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProduct_FormClosed);
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxFiltr;
        private System.Windows.Forms.RadioButton radioButtonAsc;
        private System.Windows.Forms.RadioButton radioButtonDesc;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
    }
}
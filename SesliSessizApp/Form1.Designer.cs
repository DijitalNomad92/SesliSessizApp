namespace SesliSessizApp
{
    partial class Form1
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
            this.lbKelime = new System.Windows.Forms.Label();
            this.tbKelime = new System.Windows.Forms.TextBox();
            this.rbSesli = new System.Windows.Forms.RadioButton();
            this.rbSessiz = new System.Windows.Forms.RadioButton();
            this.btBul = new System.Windows.Forms.Button();
            this.btTemizle = new System.Windows.Forms.Button();
            this.rtbSonuc = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbKelime
            // 
            this.lbKelime.AutoSize = true;
            this.lbKelime.Location = new System.Drawing.Point(364, 45);
            this.lbKelime.Name = "lbKelime";
            this.lbKelime.Size = new System.Drawing.Size(43, 15);
            this.lbKelime.TabIndex = 0;
            this.lbKelime.Text = "Kelime";
            // 
            // tbKelime
            // 
            this.tbKelime.Location = new System.Drawing.Point(340, 79);
            this.tbKelime.Name = "tbKelime";
            this.tbKelime.Size = new System.Drawing.Size(100, 23);
            this.tbKelime.TabIndex = 1;
            // 
            // rbSesli
            // 
            this.rbSesli.AutoSize = true;
            this.rbSesli.Checked = true;
            this.rbSesli.Location = new System.Drawing.Point(316, 126);
            this.rbSesli.Name = "rbSesli";
            this.rbSesli.Size = new System.Drawing.Size(48, 19);
            this.rbSesli.TabIndex = 2;
            this.rbSesli.TabStop = true;
            this.rbSesli.Text = "Sesli";
            this.rbSesli.UseVisualStyleBackColor = true;
            // 
            // rbSessiz
            // 
            this.rbSessiz.AutoSize = true;
            this.rbSessiz.Location = new System.Drawing.Point(421, 126);
            this.rbSessiz.Name = "rbSessiz";
            this.rbSessiz.Size = new System.Drawing.Size(55, 19);
            this.rbSessiz.TabIndex = 3;
            this.rbSessiz.Text = "Sessiz";
            this.rbSessiz.UseVisualStyleBackColor = true;
            // 
            // btBul
            // 
            this.btBul.Location = new System.Drawing.Point(307, 166);
            this.btBul.Name = "btBul";
            this.btBul.Size = new System.Drawing.Size(75, 23);
            this.btBul.TabIndex = 4;
            this.btBul.Text = "Bul";
            this.btBul.UseVisualStyleBackColor = true;
            this.btBul.Click += new System.EventHandler(this.btBul_Click);
            // 
            // btTemizle
            // 
            this.btTemizle.Location = new System.Drawing.Point(421, 166);
            this.btTemizle.Name = "btTemizle";
            this.btTemizle.Size = new System.Drawing.Size(75, 23);
            this.btTemizle.TabIndex = 5;
            this.btTemizle.Text = "Temizle";
            this.btTemizle.UseVisualStyleBackColor = true;
            this.btTemizle.Click += new System.EventHandler(this.btTemizle_Click);
            // 
            // rtbSonuc
            // 
            this.rtbSonuc.BackColor = System.Drawing.Color.Khaki;
            this.rtbSonuc.Location = new System.Drawing.Point(307, 242);
            this.rtbSonuc.Name = "rtbSonuc";
            this.rtbSonuc.Size = new System.Drawing.Size(189, 69);
            this.rtbSonuc.TabIndex = 6;
            this.rtbSonuc.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbSonuc);
            this.Controls.Add(this.btTemizle);
            this.Controls.Add(this.btBul);
            this.Controls.Add(this.rbSessiz);
            this.Controls.Add(this.rbSesli);
            this.Controls.Add(this.tbKelime);
            this.Controls.Add(this.lbKelime);
            this.Name = "Form1";
            this.Text = "SesliSessizApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbKelime;
        private TextBox tbKelime;
        private RadioButton rbSesli;
        private RadioButton rbSessiz;
        private Button btBul;
        private Button btTemizle;
        private RichTextBox rtbSonuc;
    }
}
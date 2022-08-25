namespace SesliSessizApp
{
    partial class Form2
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
            this.tbKelime = new System.Windows.Forms.TextBox();
            this.lbKelime = new System.Windows.Forms.Label();
            this.btCuncelle = new System.Windows.Forms.Button();
            this.rtbSonuc = new System.Windows.Forms.RichTextBox();
            this.tbCumle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btBul = new System.Windows.Forms.Button();
            this.rtbCumle = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbKelime
            // 
            this.tbKelime.Location = new System.Drawing.Point(121, 50);
            this.tbKelime.Name = "tbKelime";
            this.tbKelime.Size = new System.Drawing.Size(249, 23);
            this.tbKelime.TabIndex = 3;
            // 
            // lbKelime
            // 
            this.lbKelime.AutoSize = true;
            this.lbKelime.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbKelime.Location = new System.Drawing.Point(61, 50);
            this.lbKelime.Name = "lbKelime";
            this.lbKelime.Size = new System.Drawing.Size(54, 20);
            this.lbKelime.TabIndex = 2;
            this.lbKelime.Text = "Cumle";
            // 
            // btCuncelle
            // 
            this.btCuncelle.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCuncelle.Location = new System.Drawing.Point(121, 79);
            this.btCuncelle.Name = "btCuncelle";
            this.btCuncelle.Size = new System.Drawing.Size(82, 35);
            this.btCuncelle.TabIndex = 5;
            this.btCuncelle.Text = "Cuncelle";
            this.btCuncelle.UseVisualStyleBackColor = true;
            // 
            // rtbSonuc
            // 
            this.rtbSonuc.Location = new System.Drawing.Point(0, 0);
            this.rtbSonuc.Name = "rtbSonuc";
            this.rtbSonuc.Size = new System.Drawing.Size(100, 96);
            this.rtbSonuc.TabIndex = 0;
            this.rtbSonuc.Text = "";
            // 
            // tbCumle
            // 
            this.tbCumle.Location = new System.Drawing.Point(92, 22);
            this.tbCumle.Name = "tbCumle";
            this.tbCumle.Size = new System.Drawing.Size(173, 23);
            this.tbCumle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cumle";
            // 
            // btBul
            // 
            this.btBul.Location = new System.Drawing.Point(92, 51);
            this.btBul.Name = "btBul";
            this.btBul.Size = new System.Drawing.Size(75, 23);
            this.btBul.TabIndex = 5;
            this.btBul.Text = "Guncelle";
            this.btBul.UseVisualStyleBackColor = true;
            this.btBul.Click += new System.EventHandler(this.btBul_Click);
            // 
            // rtbCumle
            // 
            this.rtbCumle.BackColor = System.Drawing.Color.Khaki;
            this.rtbCumle.Location = new System.Drawing.Point(22, 92);
            this.rtbCumle.Name = "rtbCumle";
            this.rtbCumle.Size = new System.Drawing.Size(243, 69);
            this.rtbCumle.TabIndex = 7;
            this.rtbCumle.Text = "";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(567, 398);
            this.Controls.Add(this.rtbCumle);
            this.Controls.Add(this.btBul);
            this.Controls.Add(this.tbCumle);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbKelime;
        private Label lbKelime;
        private Button btCuncelle;
        private RichTextBox rtbSonuc;
        private TextBox tbCumle;
        private Label label1;
        private Button btBul;
        private RichTextBox rtbCumle;
    }
}
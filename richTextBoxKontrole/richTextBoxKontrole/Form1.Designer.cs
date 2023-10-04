namespace richTextBoxKontrole
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.citaj = new System.Windows.Forms.Button();
            this.brisi = new System.Windows.Forms.Button();
            this.spremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(52, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(641, 335);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // citaj
            // 
            this.citaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.citaj.Location = new System.Drawing.Point(52, 12);
            this.citaj.Name = "citaj";
            this.citaj.Size = new System.Drawing.Size(112, 34);
            this.citaj.TabIndex = 1;
            this.citaj.Text = "Čitaj";
            this.citaj.UseVisualStyleBackColor = true;
            this.citaj.Click += new System.EventHandler(this.citaj_Click);
            // 
            // brisi
            // 
            this.brisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brisi.Location = new System.Drawing.Point(570, 12);
            this.brisi.Name = "brisi";
            this.brisi.Size = new System.Drawing.Size(112, 34);
            this.brisi.TabIndex = 2;
            this.brisi.Text = "Briši";
            this.brisi.UseVisualStyleBackColor = true;
            this.brisi.Click += new System.EventHandler(this.brisi_Click);
            // 
            // spremi
            // 
            this.spremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.spremi.Location = new System.Drawing.Point(52, 393);
            this.spremi.Name = "spremi";
            this.spremi.Size = new System.Drawing.Size(112, 34);
            this.spremi.TabIndex = 3;
            this.spremi.Text = "Spremi";
            this.spremi.UseVisualStyleBackColor = true;
            this.spremi.Click += new System.EventHandler(this.spremi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spremi);
            this.Controls.Add(this.brisi);
            this.Controls.Add(this.citaj);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Upotreba RichTextBox  Kontrole";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button citaj;
        private System.Windows.Forms.Button brisi;
        private System.Windows.Forms.Button spremi;
    }
}


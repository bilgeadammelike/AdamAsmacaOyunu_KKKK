namespace AdamAsmacaOyunu
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
            this.flpAlfabe = new System.Windows.Forms.FlowLayoutPanel();
            this.flpTahminAlani = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOyunuBaslat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpAlfabe
            // 
            this.flpAlfabe.Location = new System.Drawing.Point(247, 156);
            this.flpAlfabe.Name = "flpAlfabe";
            this.flpAlfabe.Size = new System.Drawing.Size(372, 268);
            this.flpAlfabe.TabIndex = 0;
            // 
            // flpTahminAlani
            // 
            this.flpTahminAlani.Location = new System.Drawing.Point(247, 30);
            this.flpTahminAlani.Name = "flpTahminAlani";
            this.flpTahminAlani.Size = new System.Drawing.Size(372, 120);
            this.flpTahminAlani.TabIndex = 0;
            // 
            // btnOyunuBaslat
            // 
            this.btnOyunuBaslat.Location = new System.Drawing.Point(483, 1);
            this.btnOyunuBaslat.Name = "btnOyunuBaslat";
            this.btnOyunuBaslat.Size = new System.Drawing.Size(136, 23);
            this.btnOyunuBaslat.TabIndex = 1;
            this.btnOyunuBaslat.Text = "Oyunu Başlat";
            this.btnOyunuBaslat.UseVisualStyleBackColor = true;
            this.btnOyunuBaslat.Click += new System.EventHandler(this.btnOyunuBaslat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 436);
            this.Controls.Add(this.btnOyunuBaslat);
            this.Controls.Add(this.flpTahminAlani);
            this.Controls.Add(this.flpAlfabe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpAlfabe;
        private System.Windows.Forms.FlowLayoutPanel flpTahminAlani;
        private System.Windows.Forms.Button btnOyunuBaslat;
    }
}


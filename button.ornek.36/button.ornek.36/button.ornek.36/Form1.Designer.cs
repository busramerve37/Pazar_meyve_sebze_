namespace button.ornek._36
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
            this.lstMeyveler = new System.Windows.Forms.ListBox();
            this.lstSebzeler = new System.Windows.Forms.ListBox();
            this.btn = new System.Windows.Forms.Button();
            this.lstTum = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstMeyveler
            // 
            this.lstMeyveler.FormattingEnabled = true;
            this.lstMeyveler.Items.AddRange(new object[] {
            "MUZ",
            "ÇİLEK",
            "ŞEFTALİ"});
            this.lstMeyveler.Location = new System.Drawing.Point(171, 12);
            this.lstMeyveler.Name = "lstMeyveler";
            this.lstMeyveler.Size = new System.Drawing.Size(126, 199);
            this.lstMeyveler.TabIndex = 0;
            // 
            // lstSebzeler
            // 
            this.lstSebzeler.FormattingEnabled = true;
            this.lstSebzeler.Items.AddRange(new object[] {
            "SALATALIK",
            "KIVIRCIK",
            "HAVUÇ",
            "MERYEM"});
            this.lstSebzeler.Location = new System.Drawing.Point(322, 12);
            this.lstSebzeler.Name = "lstSebzeler";
            this.lstSebzeler.Size = new System.Drawing.Size(125, 199);
            this.lstSebzeler.TabIndex = 1;
            this.lstSebzeler.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn.Location = new System.Drawing.Point(12, 262);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(497, 87);
            this.btn.TabIndex = 3;
            this.btn.Text = "PARAM OLSADA BEN ALSAAAM GEL ABLA GEL MEYVEYE SEBZEYE GEL";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lstTum
            // 
            this.lstTum.FormattingEnabled = true;
            this.lstTum.Items.AddRange(new object[] {
            "SALATALIK",
            "KIVIRCIK",
            "HAVUÇ",
            "MERYEM",
            "MUZ",
            "ÇİLEK",
            "ŞEFTALİ"});
            this.lstTum.Location = new System.Drawing.Point(12, 12);
            this.lstTum.Name = "lstTum";
            this.lstTum.Size = new System.Drawing.Size(120, 199);
            this.lstTum.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 379);
            this.Controls.Add(this.lstTum);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lstSebzeler);
            this.Controls.Add(this.lstMeyveler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstMeyveler;
        private System.Windows.Forms.ListBox lstSebzeler;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ListBox lstTum;
    }
}


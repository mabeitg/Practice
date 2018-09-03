namespace Practice
{
    partial class frmResultat
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
            this.tbxTid = new System.Windows.Forms.TextBox();
            this.tbxKorrekta = new System.Windows.Forms.TextBox();
            this.tbxTidPerUppgift = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxFelaktiga = new System.Windows.Forms.TextBox();
            this.lblOK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxTid
            // 
            this.tbxTid.Location = new System.Drawing.Point(118, 54);
            this.tbxTid.Name = "tbxTid";
            this.tbxTid.ReadOnly = true;
            this.tbxTid.Size = new System.Drawing.Size(46, 20);
            this.tbxTid.TabIndex = 0;
            // 
            // tbxKorrekta
            // 
            this.tbxKorrekta.Location = new System.Drawing.Point(118, 80);
            this.tbxKorrekta.Name = "tbxKorrekta";
            this.tbxKorrekta.ReadOnly = true;
            this.tbxKorrekta.Size = new System.Drawing.Size(46, 20);
            this.tbxKorrekta.TabIndex = 1;
            // 
            // tbxTidPerUppgift
            // 
            this.tbxTidPerUppgift.Location = new System.Drawing.Point(118, 175);
            this.tbxTidPerUppgift.Name = "tbxTidPerUppgift";
            this.tbxTidPerUppgift.ReadOnly = true;
            this.tbxTidPerUppgift.Size = new System.Drawing.Size(46, 20);
            this.tbxTidPerUppgift.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Korrekta svar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tid per uppgift";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Felaktiga svar";
            // 
            // tbxFelaktiga
            // 
            this.tbxFelaktiga.Location = new System.Drawing.Point(118, 107);
            this.tbxFelaktiga.Name = "tbxFelaktiga";
            this.tbxFelaktiga.ReadOnly = true;
            this.tbxFelaktiga.Size = new System.Drawing.Size(46, 20);
            this.tbxFelaktiga.TabIndex = 7;
            // 
            // lblOK
            // 
            this.lblOK.AutoSize = true;
            this.lblOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOK.ForeColor = System.Drawing.Color.Green;
            this.lblOK.Location = new System.Drawing.Point(9, 9);
            this.lblOK.Name = "lblOK";
            this.lblOK.Size = new System.Drawing.Size(0, 25);
            this.lblOK.TabIndex = 9;
            // 
            // frmResultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(190, 255);
            this.Controls.Add(this.lblOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxFelaktiga);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxTidPerUppgift);
            this.Controls.Add(this.tbxKorrekta);
            this.Controls.Add(this.tbxTid);
            this.Name = "frmResultat";
            this.Text = "Resultat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tbxTid;
        public System.Windows.Forms.TextBox tbxKorrekta;
        public System.Windows.Forms.TextBox tbxTidPerUppgift;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbxFelaktiga;
        public System.Windows.Forms.Label lblOK;
    }
}
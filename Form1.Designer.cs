namespace Practice
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
            this.components = new System.ComponentModel.Container();
            this.lblUppgift = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.stapelKvar = new Practice.Stapel();
            this.SuspendLayout();
            // 
            // lblUppgift
            // 
            this.lblUppgift.AutoSize = true;
            this.lblUppgift.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUppgift.ForeColor = System.Drawing.Color.Green;
            this.lblUppgift.Location = new System.Drawing.Point(33, 28);
            this.lblUppgift.Name = "lblUppgift";
            this.lblUppgift.Size = new System.Drawing.Size(338, 120);
            this.lblUppgift.TabIndex = 0;
            this.lblUppgift.Text = "label1";
            this.lblUppgift.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvar.ForeColor = System.Drawing.Color.Green;
            this.lblSvar.Location = new System.Drawing.Point(33, 148);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(338, 120);
            this.lblSvar.TabIndex = 1;
            this.lblSvar.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.progressBar1.Location = new System.Drawing.Point(0, 305);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(664, 64);
            this.progressBar1.Step = 100;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 100;
            // 
            // timer2
            // 
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // stapelKvar
            // 
            this.stapelKvar.BackColor = System.Drawing.Color.Green;
            this.stapelKvar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stapelKvar.Location = new System.Drawing.Point(563, 55);
            this.stapelKvar.Name = "stapelKvar";
            this.stapelKvar.Size = new System.Drawing.Size(60, 200);
            this.stapelKvar.TabIndex = 2;
            this.stapelKvar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 369);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.stapelKvar);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblUppgift);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Gångertränaren";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUppgift;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Timer timer1;
        private Stapel stapelKvar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer2;
    }
}


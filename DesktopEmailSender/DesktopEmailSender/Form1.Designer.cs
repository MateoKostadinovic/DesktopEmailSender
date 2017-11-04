namespace DesktopEmailSender
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
            this.lblPrimatelj = new System.Windows.Forms.Label();
            this.lblNaslovPoruke = new System.Windows.Forms.Label();
            this.lblTijeloPoruke = new System.Windows.Forms.Label();
            this.inptPrimatelj = new System.Windows.Forms.TextBox();
            this.inptNaslovPoruke = new System.Windows.Forms.TextBox();
            this.inptTijeloPoruke = new System.Windows.Forms.TextBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.outptMailPoslan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPrimatelj
            // 
            this.lblPrimatelj.AutoSize = true;
            this.lblPrimatelj.Location = new System.Drawing.Point(28, 25);
            this.lblPrimatelj.Name = "lblPrimatelj";
            this.lblPrimatelj.Size = new System.Drawing.Size(49, 13);
            this.lblPrimatelj.TabIndex = 0;
            this.lblPrimatelj.Text = "Primatelj:";
            // 
            // lblNaslovPoruke
            // 
            this.lblNaslovPoruke.AutoSize = true;
            this.lblNaslovPoruke.Location = new System.Drawing.Point(28, 84);
            this.lblNaslovPoruke.Name = "lblNaslovPoruke";
            this.lblNaslovPoruke.Size = new System.Drawing.Size(77, 13);
            this.lblNaslovPoruke.TabIndex = 1;
            this.lblNaslovPoruke.Text = "NaslovPoruke:";
            // 
            // lblTijeloPoruke
            // 
            this.lblTijeloPoruke.AutoSize = true;
            this.lblTijeloPoruke.Location = new System.Drawing.Point(285, 25);
            this.lblTijeloPoruke.Name = "lblTijeloPoruke";
            this.lblTijeloPoruke.Size = new System.Drawing.Size(71, 13);
            this.lblTijeloPoruke.TabIndex = 2;
            this.lblTijeloPoruke.Text = "Tijelo poruke:";
            // 
            // inptPrimatelj
            // 
            this.inptPrimatelj.Location = new System.Drawing.Point(112, 22);
            this.inptPrimatelj.Name = "inptPrimatelj";
            this.inptPrimatelj.Size = new System.Drawing.Size(100, 20);
            this.inptPrimatelj.TabIndex = 3;
            // 
            // inptNaslovPoruke
            // 
            this.inptNaslovPoruke.Location = new System.Drawing.Point(112, 84);
            this.inptNaslovPoruke.Name = "inptNaslovPoruke";
            this.inptNaslovPoruke.Size = new System.Drawing.Size(100, 20);
            this.inptNaslovPoruke.TabIndex = 4;
            // 
            // inptTijeloPoruke
            // 
            this.inptTijeloPoruke.Location = new System.Drawing.Point(391, 22);
            this.inptTijeloPoruke.Name = "inptTijeloPoruke";
            this.inptTijeloPoruke.Size = new System.Drawing.Size(163, 20);
            this.inptTijeloPoruke.TabIndex = 5;
            // 
            // btnPosalji
            // 
            this.btnPosalji.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPosalji.Location = new System.Drawing.Point(319, 122);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(163, 97);
            this.btnPosalji.TabIndex = 6;
            this.btnPosalji.Text = "POSALJI";
            this.btnPosalji.UseVisualStyleBackColor = false;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // outptMailPoslan
            // 
            this.outptMailPoslan.Enabled = false;
            this.outptMailPoslan.Location = new System.Drawing.Point(319, 251);
            this.outptMailPoslan.Name = "outptMailPoslan";
            this.outptMailPoslan.Size = new System.Drawing.Size(163, 20);
            this.outptMailPoslan.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 301);
            this.Controls.Add(this.outptMailPoslan);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.inptTijeloPoruke);
            this.Controls.Add(this.inptNaslovPoruke);
            this.Controls.Add(this.inptPrimatelj);
            this.Controls.Add(this.lblTijeloPoruke);
            this.Controls.Add(this.lblNaslovPoruke);
            this.Controls.Add(this.lblPrimatelj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimatelj;
        private System.Windows.Forms.Label lblNaslovPoruke;
        private System.Windows.Forms.Label lblTijeloPoruke;
        private System.Windows.Forms.TextBox inptPrimatelj;
        private System.Windows.Forms.TextBox inptNaslovPoruke;
        private System.Windows.Forms.TextBox inptTijeloPoruke;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.TextBox outptMailPoslan;
    }
}


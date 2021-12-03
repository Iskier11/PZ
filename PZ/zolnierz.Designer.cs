namespace PZ
{
    partial class zolnierz
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
            this.Raport = new System.Windows.Forms.Button();
            this.Stornagl = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Paneldesktop = new System.Windows.Forms.Panel();
            this.PanelPowitanie = new System.Windows.Forms.Panel();
            this.lblPowitanie = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.PanelPowitanie.SuspendLayout();
            this.SuspendLayout();
            // 
            // Raport
            // 
            this.Raport.Dock = System.Windows.Forms.DockStyle.Top;
            this.Raport.FlatAppearance.BorderSize = 0;
            this.Raport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Raport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Raport.ForeColor = System.Drawing.Color.Snow;
            this.Raport.Location = new System.Drawing.Point(0, 79);
            this.Raport.Name = "Raport";
            this.Raport.Size = new System.Drawing.Size(220, 79);
            this.Raport.TabIndex = 2;
            this.Raport.Text = "informacja o broni";
            this.Raport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Raport.UseVisualStyleBackColor = true;
            // 
            // Stornagl
            // 
            this.Stornagl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Stornagl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Stornagl.FlatAppearance.BorderSize = 0;
            this.Stornagl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stornagl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Stornagl.ForeColor = System.Drawing.Color.Snow;
            this.Stornagl.Location = new System.Drawing.Point(0, 0);
            this.Stornagl.Name = "Stornagl";
            this.Stornagl.Size = new System.Drawing.Size(220, 79);
            this.Stornagl.TabIndex = 1;
            this.Stornagl.Text = "Strona glowna";
            this.Stornagl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Stornagl.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Menu.Controls.Add(this.button7);
            this.Menu.Controls.Add(this.Raport);
            this.Menu.Controls.Add(this.Stornagl);
            this.Menu.Controls.Add(this.button1);
            this.Menu.Controls.Add(this.label1);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 78);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(220, 372);
            this.Menu.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button7.Location = new System.Drawing.Point(0, 346);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(220, 26);
            this.button7.TabIndex = 6;
            this.button7.Text = "Wyloguj";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 79);
            this.button1.TabIndex = 1;
            this.button1.Text = "Raporty";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            // 
            // Paneldesktop
            // 
            this.Paneldesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Paneldesktop.Location = new System.Drawing.Point(0, 78);
            this.Paneldesktop.Name = "Paneldesktop";
            this.Paneldesktop.Size = new System.Drawing.Size(800, 372);
            this.Paneldesktop.TabIndex = 6;
            // 
            // PanelPowitanie
            // 
            this.PanelPowitanie.BackColor = System.Drawing.Color.Gold;
            this.PanelPowitanie.Controls.Add(this.lblPowitanie);
            this.PanelPowitanie.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPowitanie.Location = new System.Drawing.Point(0, 0);
            this.PanelPowitanie.Name = "PanelPowitanie";
            this.PanelPowitanie.Size = new System.Drawing.Size(800, 78);
            this.PanelPowitanie.TabIndex = 5;
            // 
            // lblPowitanie
            // 
            this.lblPowitanie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPowitanie.AutoSize = true;
            this.lblPowitanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowitanie.Location = new System.Drawing.Point(356, 25);
            this.lblPowitanie.Name = "lblPowitanie";
            this.lblPowitanie.Size = new System.Drawing.Size(156, 26);
            this.lblPowitanie.TabIndex = 0;
            this.lblPowitanie.Text = "Strona Główna";
            // 
            // zolnierz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Paneldesktop);
            this.Controls.Add(this.PanelPowitanie);
            this.Name = "zolnierz";
            this.Text = "zolnierz";
            this.Load += new System.EventHandler(this.zolnierz_Load);
            this.Menu.ResumeLayout(false);
            this.PanelPowitanie.ResumeLayout(false);
            this.PanelPowitanie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Raport;
        private System.Windows.Forms.Button Stornagl;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Paneldesktop;
        private System.Windows.Forms.Panel PanelPowitanie;
        private System.Windows.Forms.Label lblPowitanie;
    }
}
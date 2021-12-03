namespace PZ.Forms
{
    partial class Bronie
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
            this.Update = new System.Windows.Forms.Button();
            this.ZolnierzeTABEL = new System.Windows.Forms.DataGridView();
            this.ID_UZYTKOWNIKA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_BRONI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_MAGAZYNU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAZWA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KALIBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ZolnierzeTABEL)).BeginInit();
            this.SuspendLayout();
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(116, 79);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(132, 23);
            this.Update.TabIndex = 3;
            this.Update.Text = "Pobranie tabeli";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // ZolnierzeTABEL
            // 
            this.ZolnierzeTABEL.AllowDrop = true;
            this.ZolnierzeTABEL.AllowUserToOrderColumns = true;
            this.ZolnierzeTABEL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ZolnierzeTABEL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_UZYTKOWNIKA,
            this.ID_BRONI,
            this.ID_MAGAZYNU,
            this.NAZWA,
            this.KALIBER});
            this.ZolnierzeTABEL.Location = new System.Drawing.Point(291, 79);
            this.ZolnierzeTABEL.Name = "ZolnierzeTABEL";
            this.ZolnierzeTABEL.Size = new System.Drawing.Size(444, 288);
            this.ZolnierzeTABEL.TabIndex = 2;
            this.ZolnierzeTABEL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ZolnierzeTABEL_CellContentClick);
            // 
            // ID_UZYTKOWNIKA
            // 
            this.ID_UZYTKOWNIKA.DataPropertyName = "ID_UZYTKOWNIKA";
            this.ID_UZYTKOWNIKA.HeaderText = "ID_UZYTKOWNIKA";
            this.ID_UZYTKOWNIKA.Name = "ID_UZYTKOWNIKA";
            // 
            // ID_BRONI
            // 
            this.ID_BRONI.DataPropertyName = "ID_BRONI";
            this.ID_BRONI.HeaderText = "ID_Broni";
            this.ID_BRONI.Name = "ID_BRONI";
            // 
            // ID_MAGAZYNU
            // 
            this.ID_MAGAZYNU.DataPropertyName = "ID_MAGAZYNU";
            this.ID_MAGAZYNU.HeaderText = "ID_Magazynu";
            this.ID_MAGAZYNU.Name = "ID_MAGAZYNU";
            // 
            // NAZWA
            // 
            this.NAZWA.DataPropertyName = "NAZWA";
            this.NAZWA.HeaderText = "NAZWA";
            this.NAZWA.Name = "NAZWA";
            // 
            // KALIBER
            // 
            this.KALIBER.DataPropertyName = "KALIBER";
            this.KALIBER.HeaderText = "KALIBER";
            this.KALIBER.Name = "KALIBER";
            // 
            // Bronie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.ZolnierzeTABEL);
            this.Name = "Bronie";
            this.Text = "Bronie";
            ((System.ComponentModel.ISupportInitialize)(this.ZolnierzeTABEL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.DataGridView ZolnierzeTABEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_UZYTKOWNIKA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_BRONI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MAGAZYNU;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAZWA;
        private System.Windows.Forms.DataGridViewTextBoxColumn KALIBER;
    }
}
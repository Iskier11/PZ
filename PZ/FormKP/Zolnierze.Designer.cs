namespace PZ.Forms
{
    partial class Zolnierze
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
            this.ZolnierzeTABEL = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.Button();
            this.pZ_BDDataSet = new PZ.PZ_BDDataSet();
            this.pZBDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID_UZYTKOWNIKA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAZWISKO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KOMPANIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ZolnierzeTABEL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pZ_BDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pZBDDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ZolnierzeTABEL
            // 
            this.ZolnierzeTABEL.AllowDrop = true;
            this.ZolnierzeTABEL.AllowUserToOrderColumns = true;
            this.ZolnierzeTABEL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ZolnierzeTABEL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_UZYTKOWNIKA,
            this.Imie,
            this.NAZWISKO,
            this.KOMPANIA});
            this.ZolnierzeTABEL.Location = new System.Drawing.Point(273, 54);
            this.ZolnierzeTABEL.Name = "ZolnierzeTABEL";
            this.ZolnierzeTABEL.Size = new System.Drawing.Size(444, 288);
            this.ZolnierzeTABEL.TabIndex = 0;
            this.ZolnierzeTABEL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(98, 54);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(132, 23);
            this.Update.TabIndex = 1;
            this.Update.Text = "Pobranie tabeli";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // pZ_BDDataSet
            // 
            this.pZ_BDDataSet.DataSetName = "PZ_BDDataSet";
            this.pZ_BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pZBDDataSetBindingSource
            // 
            this.pZBDDataSetBindingSource.DataSource = this.pZ_BDDataSet;
            this.pZBDDataSetBindingSource.Position = 0;
            // 
            // ID_UZYTKOWNIKA
            // 
            this.ID_UZYTKOWNIKA.DataPropertyName = "ID_UZYTKOWNIKA";
            this.ID_UZYTKOWNIKA.HeaderText = "ID_UZYTKOWNIKA";
            this.ID_UZYTKOWNIKA.Name = "ID_UZYTKOWNIKA";
            // 
            // Imie
            // 
            this.Imie.DataPropertyName = "IMIE";
            this.Imie.HeaderText = "Imie";
            this.Imie.Name = "Imie";
            // 
            // NAZWISKO
            // 
            this.NAZWISKO.DataPropertyName = "NAZWISKO";
            this.NAZWISKO.HeaderText = "Nazwisko";
            this.NAZWISKO.Name = "NAZWISKO";
            // 
            // KOMPANIA
            // 
            this.KOMPANIA.DataPropertyName = "KOMPANIA";
            this.KOMPANIA.HeaderText = "Kompania";
            this.KOMPANIA.Name = "KOMPANIA";
            // 
            // Zolnierze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.ZolnierzeTABEL);
            this.Name = "Zolnierze";
            this.Text = "Zolnierze";
            ((System.ComponentModel.ISupportInitialize)(this.ZolnierzeTABEL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pZ_BDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pZBDDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ZolnierzeTABEL;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_UZYTKOWNIKA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAZWISKO;
        private System.Windows.Forms.DataGridViewTextBoxColumn KOMPANIA;
        private PZ_BDDataSet pZ_BDDataSet;
        private System.Windows.Forms.BindingSource pZBDDataSetBindingSource;
    }
}
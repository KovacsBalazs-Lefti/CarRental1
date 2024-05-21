namespace CarRental1
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
            this.Cargrid = new System.Windows.Forms.DataGridView();
            this.delete_button = new System.Windows.Forms.Button();
            this.license_plate_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daily_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Cargrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Cargrid
            // 
            this.Cargrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cargrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.license_plate_number,
            this.brand,
            this.model,
            this.daily_cost});
            this.Cargrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Cargrid.Location = new System.Drawing.Point(0, 57);
            this.Cargrid.MultiSelect = false;
            this.Cargrid.Name = "Cargrid";
            this.Cargrid.RowHeadersWidth = 51;
            this.Cargrid.RowTemplate.Height = 24;
            this.Cargrid.Size = new System.Drawing.Size(800, 393);
            this.Cargrid.TabIndex = 0;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(22, 12);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 1;
            this.delete_button.Text = "Törlés";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // license_plate_number
            // 
            this.license_plate_number.DataPropertyName = "License_plate_number";
            this.license_plate_number.HeaderText = "Rendszám";
            this.license_plate_number.MinimumWidth = 6;
            this.license_plate_number.Name = "license_plate_number";
            this.license_plate_number.Width = 125;
            // 
            // brand
            // 
            this.brand.DataPropertyName = "Brand";
            this.brand.HeaderText = "Márka";
            this.brand.MinimumWidth = 6;
            this.brand.Name = "brand";
            this.brand.Width = 125;
            // 
            // model
            // 
            this.model.DataPropertyName = "Model";
            this.model.HeaderText = "Model";
            this.model.MinimumWidth = 6;
            this.model.Name = "model";
            this.model.Width = 125;
            // 
            // daily_cost
            // 
            this.daily_cost.DataPropertyName = "Daily_cost";
            this.daily_cost.HeaderText = "Napidíj";
            this.daily_cost.MinimumWidth = 6;
            this.daily_cost.Name = "daily_cost";
            this.daily_cost.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.Cargrid);
            this.Name = "Form1";
            this.Text = "Petrik autókölcsönző";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cargrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Cargrid;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn license_plate_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn daily_cost;
    }
}


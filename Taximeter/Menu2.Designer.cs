namespace Taximeter
{
    partial class Menu2
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
            this.BttnTtlnTrips = new System.Windows.Forms.Button();
            this.BttnCarsMilage = new System.Windows.Forms.Button();
            this.bttnCarsFlLvl = new System.Windows.Forms.Button();
            this.BttnNetIncome = new System.Windows.Forms.Button();
            this.bttnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BttnTtlnTrips
            // 
            this.BttnTtlnTrips.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnTtlnTrips.Location = new System.Drawing.Point(143, 72);
            this.BttnTtlnTrips.Name = "BttnTtlnTrips";
            this.BttnTtlnTrips.Size = new System.Drawing.Size(116, 46);
            this.BttnTtlnTrips.TabIndex = 11;
            this.BttnTtlnTrips.Text = "Total number of trips";
            this.BttnTtlnTrips.UseVisualStyleBackColor = true;
            this.BttnTtlnTrips.Click += new System.EventHandler(this.BttnTtlnTrips_Click);
            // 
            // BttnCarsMilage
            // 
            this.BttnCarsMilage.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnCarsMilage.Location = new System.Drawing.Point(17, 72);
            this.BttnCarsMilage.Name = "BttnCarsMilage";
            this.BttnCarsMilage.Size = new System.Drawing.Size(105, 31);
            this.BttnCarsMilage.TabIndex = 10;
            this.BttnCarsMilage.Text = "Car’s mileage";
            this.BttnCarsMilage.UseVisualStyleBackColor = true;
            this.BttnCarsMilage.Click += new System.EventHandler(this.BttnCarsMilage_Click);
            // 
            // bttnCarsFlLvl
            // 
            this.bttnCarsFlLvl.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCarsFlLvl.Location = new System.Drawing.Point(143, 25);
            this.bttnCarsFlLvl.Name = "bttnCarsFlLvl";
            this.bttnCarsFlLvl.Size = new System.Drawing.Size(116, 30);
            this.bttnCarsFlLvl.TabIndex = 9;
            this.bttnCarsFlLvl.Text = "Car’s fuel level";
            this.bttnCarsFlLvl.UseVisualStyleBackColor = true;
            this.bttnCarsFlLvl.Click += new System.EventHandler(this.bttnCarsFlLvl_Click);
            // 
            // BttnNetIncome
            // 
            this.BttnNetIncome.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnNetIncome.Location = new System.Drawing.Point(17, 25);
            this.BttnNetIncome.Name = "BttnNetIncome";
            this.BttnNetIncome.Size = new System.Drawing.Size(105, 30);
            this.BttnNetIncome.TabIndex = 8;
            this.BttnNetIncome.Text = "Net income";
            this.BttnNetIncome.UseVisualStyleBackColor = true;
            this.BttnNetIncome.Click += new System.EventHandler(this.BttnNetIncome_Click);
            // 
            // bttnBack
            // 
            this.bttnBack.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBack.Location = new System.Drawing.Point(89, 133);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(105, 30);
            this.bttnBack.TabIndex = 12;
            this.bttnBack.Text = "Back";
            this.bttnBack.UseVisualStyleBackColor = true;
            this.bttnBack.Click += new System.EventHandler(this.bttnBack_Click);
            // 
            // Menu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 189);
            this.Controls.Add(this.bttnBack);
            this.Controls.Add(this.BttnTtlnTrips);
            this.Controls.Add(this.BttnCarsMilage);
            this.Controls.Add(this.bttnCarsFlLvl);
            this.Controls.Add(this.BttnNetIncome);
            this.Name = "Menu2";
            this.Text = "Menu2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BttnTtlnTrips;
        private System.Windows.Forms.Button BttnCarsMilage;
        private System.Windows.Forms.Button bttnCarsFlLvl;
        private System.Windows.Forms.Button BttnNetIncome;
        private System.Windows.Forms.Button bttnBack;
    }
}
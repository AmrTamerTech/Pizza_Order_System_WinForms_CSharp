namespace WindowsFormsApp55_Pizza_Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnOrderNow = new System.Windows.Forms.Button();
            this.lblPizzaName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOrderNow
            // 
            this.btnOrderNow.BackColor = System.Drawing.Color.Red;
            this.btnOrderNow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOrderNow.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderNow.ForeColor = System.Drawing.Color.White;
            this.btnOrderNow.Location = new System.Drawing.Point(85, 365);
            this.btnOrderNow.Name = "btnOrderNow";
            this.btnOrderNow.Size = new System.Drawing.Size(270, 67);
            this.btnOrderNow.TabIndex = 0;
            this.btnOrderNow.Text = "Order Now";
            this.btnOrderNow.UseVisualStyleBackColor = false;
            this.btnOrderNow.Click += new System.EventHandler(this.btnOrderNow_Click);
            // 
            // lblPizzaName
            // 
            this.lblPizzaName.AutoSize = true;
            this.lblPizzaName.BackColor = System.Drawing.Color.Transparent;
            this.lblPizzaName.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaName.ForeColor = System.Drawing.Color.Gold;
            this.lblPizzaName.Location = new System.Drawing.Point(43, 93);
            this.lblPizzaName.Name = "lblPizzaName";
            this.lblPizzaName.Size = new System.Drawing.Size(447, 54);
            this.lblPizzaName.TabIndex = 1;
            this.lblPizzaName.Text = "Amr’s Pizzeria";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(941, 578);
            this.Controls.Add(this.lblPizzaName);
            this.Controls.Add(this.btnOrderNow);
            this.Name = "MainForm";
            this.Text = "Amr’s Pizzeria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrderNow;
        private System.Windows.Forms.Label lblPizzaName;
    }
}


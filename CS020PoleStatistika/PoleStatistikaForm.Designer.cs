namespace CS020PoleStatistika
{
    partial class PoleStatistikaForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.cislaTextBox = new System.Windows.Forms.TextBox();
            this.soucetLabel = new System.Windows.Forms.Label();
            this.minimumLabel = new System.Windows.Forms.Label();
            this.maximumLabel = new System.Windows.Forms.Label();
            this.prumerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cislaTextBox
            // 
            this.cislaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cislaTextBox.Location = new System.Drawing.Point(170, 94);
            this.cislaTextBox.Multiline = true;
            this.cislaTextBox.Name = "cislaTextBox";
            this.cislaTextBox.Size = new System.Drawing.Size(349, 48);
            this.cislaTextBox.TabIndex = 0;
            this.cislaTextBox.TextChanged += new System.EventHandler(this.cislaTextBox_TextChanged);
            // 
            // soucetLabel
            // 
            this.soucetLabel.AutoSize = true;
            this.soucetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.soucetLabel.Location = new System.Drawing.Point(163, 196);
            this.soucetLabel.Name = "soucetLabel";
            this.soucetLabel.Size = new System.Drawing.Size(163, 39);
            this.soucetLabel.TabIndex = 1;
            this.soucetLabel.Text = "Součet: ?";
            // 
            // minimumLabel
            // 
            this.minimumLabel.AutoSize = true;
            this.minimumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimumLabel.Location = new System.Drawing.Point(163, 268);
            this.minimumLabel.Name = "minimumLabel";
            this.minimumLabel.Size = new System.Drawing.Size(198, 39);
            this.minimumLabel.TabIndex = 3;
            this.minimumLabel.Text = "Minimum: ?";
            // 
            // maximumLabel
            // 
            this.maximumLabel.AutoSize = true;
            this.maximumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maximumLabel.Location = new System.Drawing.Point(163, 307);
            this.maximumLabel.Name = "maximumLabel";
            this.maximumLabel.Size = new System.Drawing.Size(208, 39);
            this.maximumLabel.TabIndex = 4;
            this.maximumLabel.Text = "Maximum: ?";
            // 
            // prumerLabel
            // 
            this.prumerLabel.AutoSize = true;
            this.prumerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prumerLabel.Location = new System.Drawing.Point(163, 346);
            this.prumerLabel.Name = "prumerLabel";
            this.prumerLabel.Size = new System.Drawing.Size(170, 39);
            this.prumerLabel.TabIndex = 5;
            this.prumerLabel.Text = "Průměr: ?";
            // 
            // PoleStatistikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prumerLabel);
            this.Controls.Add(this.maximumLabel);
            this.Controls.Add(this.minimumLabel);
            this.Controls.Add(this.soucetLabel);
            this.Controls.Add(this.cislaTextBox);
            this.Name = "PoleStatistikaForm";
            this.Text = "CS020 Pole Statistika - František Krejný";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cislaTextBox;
        private System.Windows.Forms.Label soucetLabel;
        private System.Windows.Forms.Label minimumLabel;
        private System.Windows.Forms.Label maximumLabel;
        private System.Windows.Forms.Label prumerLabel;
    }
}


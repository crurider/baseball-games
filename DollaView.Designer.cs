namespace BaseballGames
{
    partial class DollaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DollaView));
            lblBrojUtakmica = new Label();
            lblPro = new Label();
            lblCollege = new Label();
            lblSoft = new Label();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // lblBrojUtakmica
            // 
            lblBrojUtakmica.AutoSize = true;
            lblBrojUtakmica.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblBrojUtakmica.Location = new Point(46, 29);
            lblBrojUtakmica.Name = "lblBrojUtakmica";
            lblBrojUtakmica.Size = new Size(95, 17);
            lblBrojUtakmica.TabIndex = 0;
            lblBrojUtakmica.Text = "BROJ TEKMI:  ";
            // 
            // lblPro
            // 
            lblPro.AutoSize = true;
            lblPro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPro.Location = new Point(95, 68);
            lblPro.Name = "lblPro";
            lblPro.Size = new Size(46, 17);
            lblPro.TabIndex = 1;
            lblPro.Text = "PRO:  ";
            // 
            // lblCollege
            // 
            lblCollege.AutoSize = true;
            lblCollege.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCollege.Location = new Point(66, 95);
            lblCollege.Name = "lblCollege";
            lblCollege.Size = new Size(75, 17);
            lblCollege.TabIndex = 2;
            lblCollege.Text = "COLLEGE:  ";
            // 
            // lblSoft
            // 
            lblSoft.AutoSize = true;
            lblSoft.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoft.Location = new Point(89, 123);
            lblSoft.Name = "lblSoft";
            lblSoft.Size = new Size(52, 17);
            lblSoft.TabIndex = 3;
            lblSoft.Text = "SOFT:  ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(34, 166);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(107, 17);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "TOTAL DOLLA:  ";
            // 
            // DollaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 224);
            Controls.Add(lblTotal);
            Controls.Add(lblSoft);
            Controls.Add(lblCollege);
            Controls.Add(lblPro);
            Controls.Add(lblBrojUtakmica);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DollaView";
            Text = "Pregled zarade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBrojUtakmica;
        private Label lblPro;
        private Label lblCollege;
        private Label lblSoft;
        private Label lblTotal;
    }
}
namespace BaseballGames
{
    partial class BaseballGames
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseballGames));
            labelGameId = new Label();
            labelPitches = new Label();
            txtGameid = new TextBox();
            txtPitches = new TextBox();
            lblPro = new Label();
            lblSoft = new Label();
            checkBoxPro = new CheckBox();
            checkBoxSoft = new CheckBox();
            buttonOK = new Button();
            buttonDolla = new Button();
            SuspendLayout();
            // 
            // labelGameId
            // 
            labelGameId.AutoSize = true;
            labelGameId.Location = new Point(7, 9);
            labelGameId.Name = "labelGameId";
            labelGameId.Size = new Size(54, 15);
            labelGameId.TabIndex = 0;
            labelGameId.Text = "GAMEID:";
            // 
            // labelPitches
            // 
            labelPitches.AutoSize = true;
            labelPitches.Location = new Point(7, 38);
            labelPitches.Name = "labelPitches";
            labelPitches.Size = new Size(54, 15);
            labelPitches.TabIndex = 1;
            labelPitches.Text = "PITCHES:";
            // 
            // txtGameid
            // 
            txtGameid.Location = new Point(67, 6);
            txtGameid.Name = "txtGameid";
            txtGameid.Size = new Size(100, 23);
            txtGameid.TabIndex = 2;
            // 
            // txtPitches
            // 
            txtPitches.Location = new Point(67, 35);
            txtPitches.Name = "txtPitches";
            txtPitches.Size = new Size(100, 23);
            txtPitches.TabIndex = 3;
            // 
            // lblPro
            // 
            lblPro.AutoSize = true;
            lblPro.Location = new Point(196, 9);
            lblPro.Name = "lblPro";
            lblPro.Size = new Size(30, 15);
            lblPro.TabIndex = 4;
            lblPro.Text = "PRO";
            // 
            // lblSoft
            // 
            lblSoft.AutoSize = true;
            lblSoft.Location = new Point(192, 38);
            lblSoft.Name = "lblSoft";
            lblSoft.Size = new Size(34, 15);
            lblSoft.TabIndex = 5;
            lblSoft.Text = "SOFT";
            // 
            // checkBoxPro
            // 
            checkBoxPro.AutoSize = true;
            checkBoxPro.Location = new Point(232, 10);
            checkBoxPro.Name = "checkBoxPro";
            checkBoxPro.Size = new Size(15, 14);
            checkBoxPro.TabIndex = 6;
            checkBoxPro.UseVisualStyleBackColor = true;
            // 
            // checkBoxSoft
            // 
            checkBoxSoft.AutoSize = true;
            checkBoxSoft.Location = new Point(232, 39);
            checkBoxSoft.Name = "checkBoxSoft";
            checkBoxSoft.Size = new Size(15, 14);
            checkBoxSoft.TabIndex = 7;
            checkBoxSoft.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(12, 74);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(107, 27);
            buttonOK.TabIndex = 8;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonDolla
            // 
            buttonDolla.ForeColor = Color.Green;
            buttonDolla.Location = new Point(141, 74);
            buttonDolla.Name = "buttonDolla";
            buttonDolla.Size = new Size(107, 27);
            buttonDolla.TabIndex = 9;
            buttonDolla.Text = "Dolla $";
            buttonDolla.UseVisualStyleBackColor = true;
            buttonDolla.Click += buttonDolla_Click;
            // 
            // BaseballGames
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 113);
            Controls.Add(buttonDolla);
            Controls.Add(buttonOK);
            Controls.Add(checkBoxSoft);
            Controls.Add(checkBoxPro);
            Controls.Add(lblSoft);
            Controls.Add(lblPro);
            Controls.Add(txtPitches);
            Controls.Add(txtGameid);
            Controls.Add(labelPitches);
            Controls.Add(labelGameId);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "BaseballGames";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Baseball Games";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGameId;
        private Label labelPitches;
        private TextBox txtGameid;
        private TextBox txtPitches;
        private Label lblPro;
        private Label lblSoft;
        private CheckBox checkBoxPro;
        private CheckBox checkBoxSoft;
        private Button buttonOK;
        private Button buttonDolla;
    }
}

namespace M.s.M
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
            this.LisaaMuistiinpanoButton = new System.Windows.Forms.Button();
            this.PoistaMuistiinpanoButton = new System.Windows.Forms.Button();
            this.muistiinpanoLista = new System.Windows.Forms.ListBox();
            this.muistiinpanoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hakuTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LisaaMuistiinpanoButton
            // 
            this.LisaaMuistiinpanoButton.BackColor = System.Drawing.Color.ForestGreen;
            this.LisaaMuistiinpanoButton.ForeColor = System.Drawing.Color.LawnGreen;
            this.LisaaMuistiinpanoButton.Location = new System.Drawing.Point(63, 96);
            this.LisaaMuistiinpanoButton.Name = "LisaaMuistiinpanoButton";
            this.LisaaMuistiinpanoButton.Size = new System.Drawing.Size(75, 23);
            this.LisaaMuistiinpanoButton.TabIndex = 0;
            this.LisaaMuistiinpanoButton.Text = "Lisää";
            this.LisaaMuistiinpanoButton.UseVisualStyleBackColor = false;
            this.LisaaMuistiinpanoButton.Click += new System.EventHandler(this.LisaaMuistiinpanoButton_Click);
            // 
            // PoistaMuistiinpanoButton
            // 
            this.PoistaMuistiinpanoButton.BackColor = System.Drawing.Color.Crimson;
            this.PoistaMuistiinpanoButton.ForeColor = System.Drawing.Color.LightPink;
            this.PoistaMuistiinpanoButton.Location = new System.Drawing.Point(63, 401);
            this.PoistaMuistiinpanoButton.Name = "PoistaMuistiinpanoButton";
            this.PoistaMuistiinpanoButton.Size = new System.Drawing.Size(75, 23);
            this.PoistaMuistiinpanoButton.TabIndex = 1;
            this.PoistaMuistiinpanoButton.Text = "Poista";
            this.PoistaMuistiinpanoButton.UseVisualStyleBackColor = false;
            this.PoistaMuistiinpanoButton.Click += new System.EventHandler(this.PoistaMuistiinpanoButton_Click);
            // 
            // muistiinpanoLista
            // 
            this.muistiinpanoLista.FormattingEnabled = true;
            this.muistiinpanoLista.Location = new System.Drawing.Point(50, 151);
            this.muistiinpanoLista.Name = "muistiinpanoLista";
            this.muistiinpanoLista.Size = new System.Drawing.Size(362, 225);
            this.muistiinpanoLista.TabIndex = 2;
            // 
            // muistiinpanoTextBox
            // 
            this.muistiinpanoTextBox.Location = new System.Drawing.Point(50, 53);
            this.muistiinpanoTextBox.Name = "muistiinpanoTextBox";
            this.muistiinpanoTextBox.Size = new System.Drawing.Size(362, 20);
            this.muistiinpanoTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(554, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "haku";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hakuTextBox
            // 
            this.hakuTextBox.Location = new System.Drawing.Point(508, 111);
            this.hakuTextBox.Name = "hakuTextBox";
            this.hakuTextBox.Size = new System.Drawing.Size(164, 20);
            this.hakuTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(729, 448);
            this.Controls.Add(this.hakuTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.muistiinpanoTextBox);
            this.Controls.Add(this.muistiinpanoLista);
            this.Controls.Add(this.PoistaMuistiinpanoButton);
            this.Controls.Add(this.LisaaMuistiinpanoButton);
            this.Name = "Form1";
            this.Text = "Salrin Muistiinpano";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LisaaMuistiinpanoButton;
        private System.Windows.Forms.Button PoistaMuistiinpanoButton;
        private System.Windows.Forms.ListBox muistiinpanoLista;
        private System.Windows.Forms.TextBox muistiinpanoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox hakuTextBox;
    }
}


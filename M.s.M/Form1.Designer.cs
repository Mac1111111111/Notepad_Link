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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LisaaMuistiinpanoButton = new System.Windows.Forms.Button();
            this.PoistaMuistiinpanoButton = new System.Windows.Forms.Button();
            this.muistiinpanoLista = new System.Windows.Forms.ListBox();
            this.muistiinpanoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hakuTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LisaaMuistiinpanoButton
            // 
            this.LisaaMuistiinpanoButton.BackColor = System.Drawing.Color.ForestGreen;
            resources.ApplyResources(this.LisaaMuistiinpanoButton, "LisaaMuistiinpanoButton");
            this.LisaaMuistiinpanoButton.ForeColor = System.Drawing.Color.LawnGreen;
            this.LisaaMuistiinpanoButton.Name = "LisaaMuistiinpanoButton";
            this.LisaaMuistiinpanoButton.UseVisualStyleBackColor = false;
            this.LisaaMuistiinpanoButton.Click += new System.EventHandler(this.LisaaMuistiinpanoButton_Click);
            // 
            // PoistaMuistiinpanoButton
            // 
            this.PoistaMuistiinpanoButton.BackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.PoistaMuistiinpanoButton, "PoistaMuistiinpanoButton");
            this.PoistaMuistiinpanoButton.ForeColor = System.Drawing.Color.LightPink;
            this.PoistaMuistiinpanoButton.Name = "PoistaMuistiinpanoButton";
            this.PoistaMuistiinpanoButton.UseVisualStyleBackColor = false;
            this.PoistaMuistiinpanoButton.Click += new System.EventHandler(this.PoistaMuistiinpanoButton_Click);
            // 
            // muistiinpanoLista
            // 
            this.muistiinpanoLista.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.muistiinpanoLista.ForeColor = System.Drawing.Color.ForestGreen;
            this.muistiinpanoLista.FormattingEnabled = true;
            resources.ApplyResources(this.muistiinpanoLista, "muistiinpanoLista");
            this.muistiinpanoLista.Name = "muistiinpanoLista";
            // 
            // muistiinpanoTextBox
            // 
            this.muistiinpanoTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.muistiinpanoTextBox.ForeColor = System.Drawing.Color.ForestGreen;
            resources.ApplyResources(this.muistiinpanoTextBox, "muistiinpanoTextBox");
            this.muistiinpanoTextBox.Name = "muistiinpanoTextBox";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Cyan;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hakuTextBox
            // 
            this.hakuTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.hakuTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.hakuTextBox, "hakuTextBox");
            this.hakuTextBox.Name = "hakuTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Name = "label2";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = global::M.s.M.Properties.Resources.hacker_ascii;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hakuTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.muistiinpanoTextBox);
            this.Controls.Add(this.muistiinpanoLista);
            this.Controls.Add(this.PoistaMuistiinpanoButton);
            this.Controls.Add(this.LisaaMuistiinpanoButton);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.LawnGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


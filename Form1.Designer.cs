namespace GepteremProj {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.panelPictureBox = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.panelEvaluation = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.panelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // leftButton
            // 
            this.leftButton.BackgroundImage = global::GepteremProj.Properties.Resources.bal;
            this.leftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftButton.FlatAppearance.BorderSize = 0;
            this.leftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftButton.Location = new System.Drawing.Point(12, 122);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(73, 64);
            this.leftButton.TabIndex = 0;
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.BackColor = System.Drawing.Color.Transparent;
            this.rightButton.BackgroundImage = global::GepteremProj.Properties.Resources.jobb;
            this.rightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rightButton.FlatAppearance.BorderSize = 0;
            this.rightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightButton.Location = new System.Drawing.Point(272, 122);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(73, 64);
            this.rightButton.TabIndex = 1;
            this.rightButton.UseVisualStyleBackColor = false;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // panelPictureBox
            // 
            this.panelPictureBox.Location = new System.Drawing.Point(111, 63);
            this.panelPictureBox.Name = "panelPictureBox";
            this.panelPictureBox.Size = new System.Drawing.Size(141, 175);
            this.panelPictureBox.TabIndex = 2;
            this.panelPictureBox.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.BackgroundImage = global::GepteremProj.Properties.Resources.ment;
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(140, 244);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(73, 64);
            this.saveButton.TabIndex = 3;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // panelEvaluation
            // 
            this.panelEvaluation.AutoSize = true;
            this.panelEvaluation.BackColor = System.Drawing.Color.Transparent;
            this.panelEvaluation.Location = new System.Drawing.Point(371, 63);
            this.panelEvaluation.MaximumSize = new System.Drawing.Size(418, 316);
            this.panelEvaluation.Name = "panelEvaluation";
            this.panelEvaluation.Size = new System.Drawing.Size(418, 0);
            this.panelEvaluation.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelEvaluation);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.panelPictureBox);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panelPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.PictureBox panelPictureBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel panelEvaluation;
    }
}


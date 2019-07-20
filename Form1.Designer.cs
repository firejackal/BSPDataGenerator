namespace BSPDataGenerator
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SerialTextBox = new System.Windows.Forms.TextBox();
            this.SerialLabel = new System.Windows.Forms.Label();
            this.VariantLabel = new System.Windows.Forms.Label();
            this.VariantCombo = new System.Windows.Forms.ComboBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(11, 9);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(357, 26);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Essential PH-1 BSPData Generator";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(13, 35);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(328, 13);
            this.WelcomeLabel.TabIndex = 4;
            this.WelcomeLabel.Text = "Please enter the following information to generate your BSPData file.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SerialTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SerialLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.VariantLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.VariantCombo, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(339, 48);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // SerialTextBox
            // 
            this.SerialTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialTextBox.Location = new System.Drawing.Point(172, 3);
            this.SerialTextBox.Name = "SerialTextBox";
            this.SerialTextBox.Size = new System.Drawing.Size(164, 20);
            this.SerialTextBox.TabIndex = 6;
            // 
            // SerialLabel
            // 
            this.SerialLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialLabel.AutoSize = true;
            this.SerialLabel.Location = new System.Drawing.Point(3, 0);
            this.SerialLabel.Name = "SerialLabel";
            this.SerialLabel.Size = new System.Drawing.Size(163, 24);
            this.SerialLabel.TabIndex = 0;
            this.SerialLabel.Text = "Serial Number:";
            this.SerialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VariantLabel
            // 
            this.VariantLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VariantLabel.AutoSize = true;
            this.VariantLabel.Location = new System.Drawing.Point(3, 24);
            this.VariantLabel.Name = "VariantLabel";
            this.VariantLabel.Size = new System.Drawing.Size(163, 24);
            this.VariantLabel.TabIndex = 1;
            this.VariantLabel.Text = "Variant:";
            this.VariantLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VariantCombo
            // 
            this.VariantCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VariantCombo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.VariantCombo.FormattingEnabled = true;
            this.VariantCombo.Location = new System.Drawing.Point(172, 27);
            this.VariantCombo.Name = "VariantCombo";
            this.VariantCombo.Size = new System.Drawing.Size(164, 21);
            this.VariantCombo.TabIndex = 7;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(265, 134);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(87, 23);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(13, 139);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(93, 13);
            this.lblCopyright.TabIndex = 7;
            this.lblCopyright.Text = "Made by firejackal";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 172);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BSPData Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox SerialTextBox;
        private System.Windows.Forms.Label SerialLabel;
        private System.Windows.Forms.Label VariantLabel;
        private System.Windows.Forms.ComboBox VariantCombo;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label lblCopyright;
    }
}


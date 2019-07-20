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
            this.PropsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.SerialTextBox = new System.Windows.Forms.TextBox();
            this.SerialLabel = new System.Windows.Forms.Label();
            this.VariantLabel = new System.Windows.Forms.Label();
            this.VariantCombo = new System.Windows.Forms.ComboBox();
            this.ColorCombo = new System.Windows.Forms.ComboBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.FlagsBox = new System.Windows.Forms.GroupBox();
            this.X1000CheckBox = new System.Windows.Forms.CheckBox();
            this.RestoreButton = new System.Windows.Forms.Button();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AFFFDataCheckBox = new System.Windows.Forms.CheckBox();
            this.PropsPanel.SuspendLayout();
            this.FlagsBox.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
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
            // PropsPanel
            // 
            this.PropsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PropsPanel.ColumnCount = 2;
            this.PropsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PropsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PropsPanel.Controls.Add(this.ColorLabel, 0, 2);
            this.PropsPanel.Controls.Add(this.SerialTextBox, 1, 0);
            this.PropsPanel.Controls.Add(this.SerialLabel, 0, 0);
            this.PropsPanel.Controls.Add(this.VariantLabel, 0, 1);
            this.PropsPanel.Controls.Add(this.VariantCombo, 1, 1);
            this.PropsPanel.Controls.Add(this.ColorCombo, 1, 2);
            this.PropsPanel.Location = new System.Drawing.Point(16, 63);
            this.PropsPanel.Name = "PropsPanel";
            this.PropsPanel.RowCount = 3;
            this.PropsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PropsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PropsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PropsPanel.Size = new System.Drawing.Size(339, 75);
            this.PropsPanel.TabIndex = 5;
            // 
            // ColorLabel
            // 
            this.ColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(3, 50);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(163, 25);
            this.ColorLabel.TabIndex = 8;
            this.ColorLabel.Text = "Color:";
            this.ColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.SerialLabel.Size = new System.Drawing.Size(163, 25);
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
            this.VariantLabel.Location = new System.Drawing.Point(3, 25);
            this.VariantLabel.Name = "VariantLabel";
            this.VariantLabel.Size = new System.Drawing.Size(163, 25);
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
            this.VariantCombo.Location = new System.Drawing.Point(172, 28);
            this.VariantCombo.Name = "VariantCombo";
            this.VariantCombo.Size = new System.Drawing.Size(164, 21);
            this.VariantCombo.TabIndex = 7;
            // 
            // ColorCombo
            // 
            this.ColorCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorCombo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ColorCombo.FormattingEnabled = true;
            this.ColorCombo.Location = new System.Drawing.Point(172, 53);
            this.ColorCombo.Name = "ColorCombo";
            this.ColorCombo.Size = new System.Drawing.Size(164, 21);
            this.ColorCombo.TabIndex = 7;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateButton.Location = new System.Drawing.Point(98, 3);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(89, 22);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(13, 234);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(93, 13);
            this.lblCopyright.TabIndex = 7;
            this.lblCopyright.Text = "Made by firejackal";
            // 
            // FlagsBox
            // 
            this.FlagsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlagsBox.Controls.Add(this.AFFFDataCheckBox);
            this.FlagsBox.Controls.Add(this.X1000CheckBox);
            this.FlagsBox.Location = new System.Drawing.Point(16, 156);
            this.FlagsBox.Name = "FlagsBox";
            this.FlagsBox.Size = new System.Drawing.Size(339, 65);
            this.FlagsBox.TabIndex = 8;
            this.FlagsBox.TabStop = false;
            this.FlagsBox.Text = "WARNING! DRAGONS AHEAD";
            // 
            // X1000CheckBox
            // 
            this.X1000CheckBox.AutoSize = true;
            this.X1000CheckBox.Location = new System.Drawing.Point(21, 19);
            this.X1000CheckBox.Name = "X1000CheckBox";
            this.X1000CheckBox.Size = new System.Drawing.Size(174, 17);
            this.X1000CheckBox.TabIndex = 0;
            this.X1000CheckBox.Text = "0x00000000 at position 0x1000";
            this.X1000CheckBox.UseVisualStyleBackColor = true;
            // 
            // RestoreButton
            // 
            this.RestoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RestoreButton.Location = new System.Drawing.Point(3, 3);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(89, 22);
            this.RestoreButton.TabIndex = 9;
            this.RestoreButton.Text = "Restore";
            this.RestoreButton.UseVisualStyleBackColor = true;
            this.RestoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.ColumnCount = 2;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsPanel.Controls.Add(this.RestoreButton, 0, 0);
            this.ButtonsPanel.Controls.Add(this.GenerateButton, 1, 0);
            this.ButtonsPanel.Location = new System.Drawing.Point(170, 227);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 1;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsPanel.Size = new System.Drawing.Size(190, 28);
            this.ButtonsPanel.TabIndex = 10;
            // 
            // AFFFDataCheckBox
            // 
            this.AFFFDataCheckBox.AutoSize = true;
            this.AFFFDataCheckBox.Location = new System.Drawing.Point(21, 42);
            this.AFFFDataCheckBox.Name = "AFFFDataCheckBox";
            this.AFFFDataCheckBox.Size = new System.Drawing.Size(148, 17);
            this.AFFFDataCheckBox.TabIndex = 1;
            this.AFFFDataCheckBox.Text = "Unknown AF and FF data";
            this.AFFFDataCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 267);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.FlagsBox);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.PropsPanel);
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
            this.PropsPanel.ResumeLayout(false);
            this.PropsPanel.PerformLayout();
            this.FlagsBox.ResumeLayout(false);
            this.FlagsBox.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.TableLayoutPanel PropsPanel;
        private System.Windows.Forms.TextBox SerialTextBox;
        private System.Windows.Forms.Label SerialLabel;
        private System.Windows.Forms.Label VariantLabel;
        private System.Windows.Forms.ComboBox VariantCombo;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.GroupBox FlagsBox;
        private System.Windows.Forms.Button RestoreButton;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.ComboBox ColorCombo;
        private System.Windows.Forms.CheckBox X1000CheckBox;
        private System.Windows.Forms.CheckBox AFFFDataCheckBox;
    }
}


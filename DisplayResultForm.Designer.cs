namespace Курсова
{
    partial class DisplayResultForm
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
            this.GoBackButton = new System.Windows.Forms.Button();
            this.StartSortibgButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.QuickResultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(0, 1);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GoBackButton.Size = new System.Drawing.Size(41, 30);
            this.GoBackButton.TabIndex = 1;
            this.GoBackButton.Text = "<";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBack);
            // 
            // StartSortibgButton
            // 
            this.StartSortibgButton.Location = new System.Drawing.Point(107, 11);
            this.StartSortibgButton.Name = "StartSortibgButton";
            this.StartSortibgButton.Size = new System.Drawing.Size(185, 48);
            this.StartSortibgButton.TabIndex = 2;
            this.StartSortibgButton.Text = "Start sorting";
            this.StartSortibgButton.UseVisualStyleBackColor = true;
            this.StartSortibgButton.Click += new System.EventHandler(this.StartSorting);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(298, 11);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(185, 48);
            this.PauseButton.TabIndex = 3;
            this.PauseButton.Text = "Pause";
            this.PauseButton.Enabled = false;
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.Pause);
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(298, 12);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(185, 48);
            this.ContinueButton.TabIndex = 4;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.Visible = false;
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.Continue);
            // 
            // QuickResultButton
            // 
            this.QuickResultButton.Location = new System.Drawing.Point(489, 12);
            this.QuickResultButton.Name = "QuickResultButton";
            this.QuickResultButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QuickResultButton.Size = new System.Drawing.Size(185, 48);
            this.QuickResultButton.TabIndex = 5;
            this.QuickResultButton.Text = "Quick result";
            this.QuickResultButton.UseVisualStyleBackColor = true;
            this.QuickResultButton.Click += new System.EventHandler(this.QuickResult);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuickResultButton);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StartSortibgButton);
            this.Controls.Add(this.GoBackButton);
            this.Name = "InputForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Enter an array";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button QuickResultButton;
        private System.Windows.Forms.Button StartSortibgButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Button GoBackButton;
        
        #endregion
    }
}
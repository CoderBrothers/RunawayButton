﻿namespace RunawayButton
{
    partial class Form1
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
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yesBtn
            // 
            this.yesBtn.Location = new System.Drawing.Point(282, 232);
            this.yesBtn.Margin = new System.Windows.Forms.Padding(4);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(118, 36);
            this.yesBtn.TabIndex = 0;
            this.yesBtn.Text = "Да";
            this.yesBtn.UseVisualStyleBackColor = true;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.Location = new System.Drawing.Point(532, 232);
            this.noBtn.Margin = new System.Windows.Forms.Padding(4);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(118, 36);
            this.noBtn.TabIndex = 1;
            this.noBtn.Text = "Нет";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.noBtn_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Довольны ли вы своей зарплатой?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button yesBtn;
        private Button noBtn;
        private Label label1;
    }
}

namespace seperateButtons
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
            this.uc11 = new seperateButtons.uc1();
            this.btnUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uc11
            // 
            this.uc11.Location = new System.Drawing.Point(3, 1);
            this.uc11.Name = "uc11";
            this.uc11.Size = new System.Drawing.Size(794, 427);
            this.uc11.TabIndex = 0;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(54, 276);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "UPDATE";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.uc11);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private uc1 uc11;
        private System.Windows.Forms.Button btnUp;
    }
}


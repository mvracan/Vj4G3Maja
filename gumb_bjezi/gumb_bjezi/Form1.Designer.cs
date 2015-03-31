namespace gumb_bjezi
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
            this.btnBjezi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBjezi
            // 
            this.btnBjezi.Location = new System.Drawing.Point(116, 138);
            this.btnBjezi.Name = "btnBjezi";
            this.btnBjezi.Size = new System.Drawing.Size(75, 23);
            this.btnBjezi.TabIndex = 0;
            this.btnBjezi.Text = "bježi od miša";
            this.btnBjezi.UseVisualStyleBackColor = true;
            this.btnBjezi.MouseEnter += new System.EventHandler(this.btnBjezi_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnBjezi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBjezi;
    }
}


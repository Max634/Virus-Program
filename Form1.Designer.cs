namespace Virus
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
            this.btnclickhere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnclickhere
            // 
            this.btnclickhere.BackColor = System.Drawing.Color.Aqua;
            this.btnclickhere.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclickhere.ForeColor = System.Drawing.Color.Black;
            this.btnclickhere.Location = new System.Drawing.Point(126, 106);
            this.btnclickhere.Name = "btnclickhere";
            this.btnclickhere.Size = new System.Drawing.Size(376, 108);
            this.btnclickhere.TabIndex = 0;
            this.btnclickhere.Text = "Click here for the fun to start 😂";
            this.btnclickhere.UseVisualStyleBackColor = false;
            this.btnclickhere.Click += new System.EventHandler(this.btnclickhere_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnclickhere;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(629, 328);
            this.Controls.Add(this.btnclickhere);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maksim-Botukh-Virus";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnclickhere;
    }
}


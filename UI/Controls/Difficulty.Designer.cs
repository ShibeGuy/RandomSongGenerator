namespace Men.UI.Controls
{
    partial class Difficulty
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.diff = new System.Windows.Forms.Label();
            this.expand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // diff
            // 
            this.diff.AutoSize = true;
            this.diff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diff.Location = new System.Drawing.Point(3, 7);
            this.diff.Name = "diff";
            this.diff.Size = new System.Drawing.Size(76, 21);
            this.diff.TabIndex = 0;
            this.diff.Text = "Difficulty";
            this.diff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // expand
            // 
            this.expand.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expand.Location = new System.Drawing.Point(149, 5);
            this.expand.Name = "expand";
            this.expand.Size = new System.Drawing.Size(25, 25);
            this.expand.TabIndex = 1;
            this.expand.Text = "v";
            this.expand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.expand.UseVisualStyleBackColor = true;
            // 
            // Difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.expand);
            this.Controls.Add(this.diff);
            this.Name = "Difficulty";
            this.Size = new System.Drawing.Size(177, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label diff;
        private System.Windows.Forms.Button expand;
    }
}

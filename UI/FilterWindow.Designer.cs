using System.Windows.Forms;

namespace Men.UI
{
    partial class FilterWindow
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
            this.Apply = new System.Windows.Forms.Button();
            this.Filters = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(40, 310);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(185, 61);
            this.Apply.TabIndex = 0;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // Filters
            // 
            this.Filters.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filters.FormattingEnabled = true;
            this.Filters.Items.AddRange(new object[] {
            "Allow Automapped",
            "Allow Noodle Extensions",
            "Allow Mapping Extensions",
            "Allow Chroma",
            "Allow Cinema ",
            "Only Automapped",
            "Only Noodle Extensions",
            "Only Mapping Extensions",
            "Only Chroma",
            "Only Cinema"});
            this.Filters.Location = new System.Drawing.Point(12, 26);
            this.Filters.Name = "Filters";
            this.Filters.Size = new System.Drawing.Size(251, 264);
            this.Filters.TabIndex = 2;
            this.Filters.ItemCheck += new ItemCheckEventHandler(this.ItemCheck);
            // 
            // FilterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 407);
            this.ControlBox = false;
            this.Controls.Add(this.Filters);
            this.Controls.Add(this.Apply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FilterWindow";
            this.Text = " Filters";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Apply;
        public System.Windows.Forms.CheckedListBox Filters;
    }
}
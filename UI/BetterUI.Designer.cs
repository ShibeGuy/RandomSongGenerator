namespace Men.UI
{
    partial class BetterUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Filters = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.diffPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.subname = new System.Windows.Forms.Label();
            this.mapper = new System.Windows.Forms.Label();
            this.songName = new System.Windows.Forms.Label();
            this.coverArt = new System.Windows.Forms.PictureBox();
            this.gen = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.copy = new System.Windows.Forms.Button();
            this.oneclick = new System.Windows.Forms.Button();
            this.key = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverArt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Filters);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 369);
            this.panel1.TabIndex = 0;
            // 
            // Filters
            // 
            this.Filters.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.Filters.Location = new System.Drawing.Point(15, 31);
            this.Filters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Filters.Name = "Filters";
            this.Filters.Size = new System.Drawing.Size(307, 312);
            this.Filters.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.diffPanel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.subname);
            this.panel2.Controls.Add(this.mapper);
            this.panel2.Controls.Add(this.songName);
            this.panel2.Controls.Add(this.coverArt);
            this.panel2.Location = new System.Drawing.Point(321, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 307);
            this.panel2.TabIndex = 1;
            // 
            // diffPanel
            // 
            this.diffPanel.AutoScroll = true;
            this.diffPanel.Location = new System.Drawing.Point(7, 229);
            this.diffPanel.Name = "diffPanel";
            this.diffPanel.Size = new System.Drawing.Size(332, 61);
            this.diffPanel.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(345, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(123, 307);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Difficulties";
            // 
            // subname
            // 
            this.subname.AutoSize = true;
            this.subname.Font = new System.Drawing.Font("Century Gothic", 13.25F);
            this.subname.Location = new System.Drawing.Point(188, 127);
            this.subname.MaximumSize = new System.Drawing.Size(150, 0);
            this.subname.MinimumSize = new System.Drawing.Size(150, 0);
            this.subname.Name = "subname";
            this.subname.Size = new System.Drawing.Size(150, 21);
            this.subname.TabIndex = 4;
            this.subname.Text = "Song Subname";
            this.subname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mapper
            // 
            this.mapper.AutoSize = true;
            this.mapper.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapper.Location = new System.Drawing.Point(188, 169);
            this.mapper.MaximumSize = new System.Drawing.Size(175, 0);
            this.mapper.Name = "mapper";
            this.mapper.Size = new System.Drawing.Size(84, 22);
            this.mapper.TabIndex = 3;
            this.mapper.Text = "Mapper";
            // 
            // songName
            // 
            this.songName.AutoSize = true;
            this.songName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songName.Location = new System.Drawing.Point(189, 16);
            this.songName.MaximumSize = new System.Drawing.Size(150, 0);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(117, 22);
            this.songName.TabIndex = 1;
            this.songName.Text = "Song Name";
            // 
            // coverArt
            // 
            this.coverArt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coverArt.Location = new System.Drawing.Point(7, 16);
            this.coverArt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.coverArt.Name = "coverArt";
            this.coverArt.Size = new System.Drawing.Size(175, 175);
            this.coverArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverArt.TabIndex = 0;
            this.coverArt.TabStop = false;
            // 
            // gen
            // 
            this.gen.BackColor = System.Drawing.Color.Transparent;
            this.gen.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.gen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gen.Location = new System.Drawing.Point(676, 12);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(98, 45);
            this.gen.TabIndex = 2;
            this.gen.Text = "Generate";
            this.gen.UseVisualStyleBackColor = false;
            this.gen.Click += new System.EventHandler(this.gen_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.status.Location = new System.Drawing.Point(673, 235);
            this.status.MaximumSize = new System.Drawing.Size(100, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(51, 20);
            this.status.TabIndex = 3;
            this.status.Text = "Status";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // copy
            // 
            this.copy.BackColor = System.Drawing.Color.Transparent;
            this.copy.Enabled = false;
            this.copy.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copy.Location = new System.Drawing.Point(677, 78);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(98, 45);
            this.copy.TabIndex = 4;
            this.copy.Text = "Copy Link";
            this.copy.UseVisualStyleBackColor = false;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // oneclick
            // 
            this.oneclick.BackColor = System.Drawing.Color.Transparent;
            this.oneclick.Enabled = false;
            this.oneclick.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.oneclick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneclick.Location = new System.Drawing.Point(677, 131);
            this.oneclick.Name = "oneclick";
            this.oneclick.Size = new System.Drawing.Size(98, 45);
            this.oneclick.TabIndex = 5;
            this.oneclick.Text = "OneClick Download";
            this.oneclick.UseVisualStyleBackColor = false;
            this.oneclick.Click += new System.EventHandler(this.oneclick_Click);
            // 
            // key
            // 
            this.key.BackColor = System.Drawing.Color.Transparent;
            this.key.Enabled = false;
            this.key.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key.Location = new System.Drawing.Point(677, 182);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(98, 45);
            this.key.TabIndex = 6;
            this.key.Text = "Copy Key";
            this.key.UseVisualStyleBackColor = false;
            this.key.Click += new System.EventHandler(this.key_Click);
            // 
            // BetterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(783, 301);
            this.Controls.Add(this.key);
            this.Controls.Add(this.oneclick);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.status);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BetterUI";
            this.Text = "Random Song Generator";
            this.Load += new System.EventHandler(this.BetterUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.CheckedListBox Filters;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label subname;
        private System.Windows.Forms.Label mapper;
        private System.Windows.Forms.Label songName;
        private System.Windows.Forms.PictureBox coverArt;
        private System.Windows.Forms.Button gen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Panel diffPanel;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button oneclick;
        private System.Windows.Forms.Button key;
    }
}
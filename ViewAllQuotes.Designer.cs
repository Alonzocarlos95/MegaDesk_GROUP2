namespace MegaDesk_Bustillos
{
    partial class ViewAllQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllQuotes));
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.custom = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.Label();
            this.depth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.BackColor = System.Drawing.Color.Yellow;
            this.ReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReturnBtn.Location = new System.Drawing.Point(365, 170);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(106, 38);
            this.ReturnBtn.TabIndex = 1;
            this.ReturnBtn.Text = "Return";
            this.ReturnBtn.UseVisualStyleBackColor = false;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // custom
            // 
            this.custom.AutoSize = true;
            this.custom.Location = new System.Drawing.Point(37, 25);
            this.custom.Name = "custom";
            this.custom.Size = new System.Drawing.Size(51, 13);
            this.custom.TabIndex = 2;
            this.custom.Text = "Customer";
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Location = new System.Drawing.Point(37, 62);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(35, 13);
            this.width.TabIndex = 3;
            this.width.Text = "Width";
            // 
            // depth
            // 
            this.depth.AutoSize = true;
            this.depth.Location = new System.Drawing.Point(37, 102);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(36, 13);
            this.depth.TabIndex = 4;
            this.depth.Text = "Depth";
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(483, 217);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.width);
            this.Controls.Add(this.custom);
            this.Controls.Add(this.ReturnBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk - View All Quotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnBtn;
        public System.Windows.Forms.Label custom;
        public System.Windows.Forms.Label width;
        public System.Windows.Forms.Label depth;
    }
}
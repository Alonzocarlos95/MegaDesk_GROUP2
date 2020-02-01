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
            this.CustomerQuotes = new System.Windows.Forms.ListBox();
            this.materialTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.BackColor = System.Drawing.Color.Yellow;
            this.ReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReturnBtn.Location = new System.Drawing.Point(541, 433);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(106, 38);
            this.ReturnBtn.TabIndex = 1;
            this.ReturnBtn.Text = "Return";
            this.ReturnBtn.UseVisualStyleBackColor = false;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // CustomerQuotes
            // 
            this.CustomerQuotes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerQuotes.FormattingEnabled = true;
            this.CustomerQuotes.ItemHeight = 19;
            this.CustomerQuotes.Location = new System.Drawing.Point(27, 42);
            this.CustomerQuotes.MultiColumn = true;
            this.CustomerQuotes.Name = "CustomerQuotes";
            this.CustomerQuotes.Size = new System.Drawing.Size(629, 384);
            this.CustomerQuotes.TabIndex = 2;
            this.CustomerQuotes.Tag = "Name";
            // 
            // materialTitle
            // 
            this.materialTitle.AutoSize = true;
            this.materialTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTitle.Location = new System.Drawing.Point(290, 9);
            this.materialTitle.Name = "materialTitle";
            this.materialTitle.Size = new System.Drawing.Size(80, 23);
            this.materialTitle.TabIndex = 3;
            this.materialTitle.Text = "Material";
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(668, 487);
            this.Controls.Add(this.materialTitle);
            this.Controls.Add(this.CustomerQuotes);
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
        public System.Windows.Forms.ListBox CustomerQuotes;
        public System.Windows.Forms.Label materialTitle;
    }
}
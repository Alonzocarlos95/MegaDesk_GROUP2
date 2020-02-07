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
            this.materialTitle = new System.Windows.Forms.Label();
            this.gridViewQuotes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.BackColor = System.Drawing.Color.Yellow;
            this.ReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReturnBtn.Location = new System.Drawing.Point(658, 437);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(106, 38);
            this.ReturnBtn.TabIndex = 1;
            this.ReturnBtn.Text = "Search";
            this.ReturnBtn.UseVisualStyleBackColor = false;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // materialTitle
            // 
            this.materialTitle.AutoSize = true;
            this.materialTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTitle.Location = new System.Drawing.Point(350, 9);
            this.materialTitle.Name = "materialTitle";
            this.materialTitle.Size = new System.Drawing.Size(0, 23);
            this.materialTitle.TabIndex = 3;
            // 
            // gridViewQuotes
            // 
            this.gridViewQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewQuotes.Location = new System.Drawing.Point(12, 35);
            this.gridViewQuotes.Name = "gridViewQuotes";
            this.gridViewQuotes.ReadOnly = true;
            this.gridViewQuotes.Size = new System.Drawing.Size(884, 392);
            this.gridViewQuotes.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(790, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(908, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridViewQuotes);
            this.Controls.Add(this.materialTitle);
            this.Controls.Add(this.ReturnBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk - View All Quotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnBtn;
        public System.Windows.Forms.Label materialTitle;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView gridViewQuotes;
    }
}
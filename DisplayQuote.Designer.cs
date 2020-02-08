namespace MegaDesk_Bustillos
{
    partial class DisplayQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayQuote));
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.gridViewList = new System.Windows.Forms.DataGridView();
            this.titleSearch = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.BackColor = System.Drawing.Color.Yellow;
            this.ReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReturnBtn.Location = new System.Drawing.Point(790, 436);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(106, 38);
            this.ReturnBtn.TabIndex = 1;
            this.ReturnBtn.Text = "Menu";
            this.ReturnBtn.UseVisualStyleBackColor = false;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // gridViewList
            // 
            this.gridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewList.Location = new System.Drawing.Point(12, 39);
            this.gridViewList.Name = "gridViewList";
            this.gridViewList.ReadOnly = true;
            this.gridViewList.Size = new System.Drawing.Size(884, 381);
            this.gridViewList.TabIndex = 2;
            // 
            // titleSearch
            // 
            this.titleSearch.AutoSize = true;
            this.titleSearch.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleSearch.Location = new System.Drawing.Point(406, 9);
            this.titleSearch.Name = "titleSearch";
            this.titleSearch.Size = new System.Drawing.Size(93, 27);
            this.titleSearch.TabIndex = 3;
            this.titleSearch.Text = "Material";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(658, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(908, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.titleSearch);
            this.Controls.Add(this.gridViewList);
            this.Controls.Add(this.ReturnBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DisplayQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk - Display Quote";
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnBtn;
        public System.Windows.Forms.DataGridView gridViewList;
        public System.Windows.Forms.Label titleSearch;
        private System.Windows.Forms.Button button1;
    }
}
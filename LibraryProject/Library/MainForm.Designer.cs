namespace Library
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ReportsButton = new System.Windows.Forms.Button();
            this.ButtonIconsImageList = new System.Windows.Forms.ImageList(this.components);
            this.ReturnBookButton = new System.Windows.Forms.Button();
            this.BorrowBookButton = new System.Windows.Forms.Button();
            this.ManageMembersButton = new System.Windows.Forms.Button();
            this.ManageBooksButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ReportsButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ReturnBookButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BorrowBookButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ManageMembersButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ManageBooksButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(644, 722);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ReportsButton
            // 
            this.ReportsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportsButton.ImageIndex = 4;
            this.ReportsButton.ImageList = this.ButtonIconsImageList;
            this.ReportsButton.Location = new System.Drawing.Point(122, 599);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(400, 100);
            this.ReportsButton.TabIndex = 4;
            this.ReportsButton.Text = "   Reports";
            this.ReportsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReportsButton.UseVisualStyleBackColor = true;
            this.ReportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // ButtonIconsImageList
            // 
            this.ButtonIconsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ButtonIconsImageList.ImageStream")));
            this.ButtonIconsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ButtonIconsImageList.Images.SetKeyName(0, "Books.png");
            this.ButtonIconsImageList.Images.SetKeyName(1, "Members.png");
            this.ButtonIconsImageList.Images.SetKeyName(2, "Borrow Book.png");
            this.ButtonIconsImageList.Images.SetKeyName(3, "Return Book.png");
            this.ButtonIconsImageList.Images.SetKeyName(4, "Reports.png");
            // 
            // ReturnBookButton
            // 
            this.ReturnBookButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReturnBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBookButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReturnBookButton.ImageIndex = 3;
            this.ReturnBookButton.ImageList = this.ButtonIconsImageList;
            this.ReturnBookButton.Location = new System.Drawing.Point(122, 454);
            this.ReturnBookButton.Name = "ReturnBookButton";
            this.ReturnBookButton.Size = new System.Drawing.Size(400, 100);
            this.ReturnBookButton.TabIndex = 3;
            this.ReturnBookButton.Text = "   Return Book";
            this.ReturnBookButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReturnBookButton.UseVisualStyleBackColor = true;
            this.ReturnBookButton.Click += new System.EventHandler(this.ReturnBookButton_Click);
            // 
            // BorrowBookButton
            // 
            this.BorrowBookButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BorrowBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowBookButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrowBookButton.ImageIndex = 2;
            this.BorrowBookButton.ImageList = this.ButtonIconsImageList;
            this.BorrowBookButton.Location = new System.Drawing.Point(122, 310);
            this.BorrowBookButton.Name = "BorrowBookButton";
            this.BorrowBookButton.Size = new System.Drawing.Size(400, 100);
            this.BorrowBookButton.TabIndex = 2;
            this.BorrowBookButton.Text = "   Borrow Book";
            this.BorrowBookButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BorrowBookButton.UseVisualStyleBackColor = true;
            this.BorrowBookButton.Click += new System.EventHandler(this.BorrowBookButton_Click);
            // 
            // ManageMembersButton
            // 
            this.ManageMembersButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ManageMembersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageMembersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageMembersButton.ImageIndex = 1;
            this.ManageMembersButton.ImageList = this.ButtonIconsImageList;
            this.ManageMembersButton.Location = new System.Drawing.Point(122, 166);
            this.ManageMembersButton.Name = "ManageMembersButton";
            this.ManageMembersButton.Size = new System.Drawing.Size(400, 100);
            this.ManageMembersButton.TabIndex = 1;
            this.ManageMembersButton.Text = "   Manage Members";
            this.ManageMembersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManageMembersButton.UseVisualStyleBackColor = true;
            this.ManageMembersButton.Click += new System.EventHandler(this.ManageMembersButton_Click);
            // 
            // ManageBooksButton
            // 
            this.ManageBooksButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ManageBooksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageBooksButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageBooksButton.ImageIndex = 0;
            this.ManageBooksButton.ImageList = this.ButtonIconsImageList;
            this.ManageBooksButton.Location = new System.Drawing.Point(122, 22);
            this.ManageBooksButton.Name = "ManageBooksButton";
            this.ManageBooksButton.Size = new System.Drawing.Size(400, 100);
            this.ManageBooksButton.TabIndex = 0;
            this.ManageBooksButton.Text = "   Manage Books";
            this.ManageBooksButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManageBooksButton.UseVisualStyleBackColor = true;
            this.ManageBooksButton.Click += new System.EventHandler(this.ManageBooksButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(644, 722);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(662, 769);
            this.MinimumSize = new System.Drawing.Size(662, 726);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Assistant";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ReportsButton;
        private System.Windows.Forms.ImageList ButtonIconsImageList;
        private System.Windows.Forms.Button ReturnBookButton;
        private System.Windows.Forms.Button BorrowBookButton;
        private System.Windows.Forms.Button ManageMembersButton;
        private System.Windows.Forms.Button ManageBooksButton;
    }
}


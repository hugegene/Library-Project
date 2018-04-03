namespace Library
{
    partial class ManageBooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBooks));
            this.LibrarianToolStrip = new System.Windows.Forms.ToolStrip();
            this.UseSelectedToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CancelSearchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.AddBookToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ModifyBookToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteBookToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RequestToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BookFilterTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.PublisherTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.AvailableBooksOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.BooksDataGridView = new System.Windows.Forms.DataGridView();
            this.ISBNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanguageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShelfColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibrarianToolStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.BookFilterTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LibrarianToolStrip
            // 
            this.LibrarianToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.LibrarianToolStrip.ImageScalingSize = new System.Drawing.Size(55, 55);
            this.LibrarianToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UseSelectedToolStripButton,
            this.CancelSearchToolStripButton,
            this.toolStripButton1,
            this.AddBookToolStripButton,
            this.ModifyBookToolStripButton,
            this.DeleteBookToolStripButton,
            this.RequestToolStripButton});
            this.LibrarianToolStrip.Location = new System.Drawing.Point(0, 0);
            this.LibrarianToolStrip.Name = "LibrarianToolStrip";
            this.LibrarianToolStrip.Size = new System.Drawing.Size(1354, 62);
            this.LibrarianToolStrip.TabIndex = 0;
            this.LibrarianToolStrip.Text = "toolStrip1";
            // 
            // UseSelectedToolStripButton
            // 
            this.UseSelectedToolStripButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseSelectedToolStripButton.Image = global::Library.Properties.Resources.Use_Selected_Row;
            this.UseSelectedToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UseSelectedToolStripButton.Name = "UseSelectedToolStripButton";
            this.UseSelectedToolStripButton.Size = new System.Drawing.Size(209, 59);
            this.UseSelectedToolStripButton.Text = "Use Selected Book";
            this.UseSelectedToolStripButton.Visible = false;
            this.UseSelectedToolStripButton.Click += new System.EventHandler(this.UseSelectedToolStripButton_Click);
            // 
            // CancelSearchToolStripButton
            // 
            this.CancelSearchToolStripButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelSearchToolStripButton.Image = global::Library.Properties.Resources.Cancel_Search;
            this.CancelSearchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelSearchToolStripButton.Name = "CancelSearchToolStripButton";
            this.CancelSearchToolStripButton.Size = new System.Drawing.Size(176, 59);
            this.CancelSearchToolStripButton.Text = "Cancel Search";
            this.CancelSearchToolStripButton.Visible = false;
            this.CancelSearchToolStripButton.Click += new System.EventHandler(this.CancelSearchToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = global::Library.Properties.Resources.noun_1067747_cc;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(162, 59);
            this.toolStripButton1.Text = "Locate Book";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // AddBookToolStripButton
            // 
            this.AddBookToolStripButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBookToolStripButton.Image = global::Library.Properties.Resources.Add_Book;
            this.AddBookToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddBookToolStripButton.Name = "AddBookToolStripButton";
            this.AddBookToolStripButton.Size = new System.Drawing.Size(143, 59);
            this.AddBookToolStripButton.Text = "Add Book";
            this.AddBookToolStripButton.Click += new System.EventHandler(this.AddBookToolStripButton_Click);
            // 
            // ModifyBookToolStripButton
            // 
            this.ModifyBookToolStripButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyBookToolStripButton.Image = global::Library.Properties.Resources.Edit_Book;
            this.ModifyBookToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModifyBookToolStripButton.Name = "ModifyBookToolStripButton";
            this.ModifyBookToolStripButton.Size = new System.Drawing.Size(164, 59);
            this.ModifyBookToolStripButton.Text = "Modify Book";
            this.ModifyBookToolStripButton.Click += new System.EventHandler(this.ModifyBookToolStripButton_Click);
            // 
            // DeleteBookToolStripButton
            // 
            this.DeleteBookToolStripButton.Image = global::Library.Properties.Resources.noun_659539_cc;
            this.DeleteBookToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteBookToolStripButton.Name = "DeleteBookToolStripButton";
            this.DeleteBookToolStripButton.Size = new System.Drawing.Size(150, 59);
            this.DeleteBookToolStripButton.Text = "Delete Book";
            this.DeleteBookToolStripButton.Click += new System.EventHandler(this.DeleteBookToolStripButton_Click);
            // 
            // RequestToolStripButton
            // 
            this.RequestToolStripButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestToolStripButton.Image = global::Library.Properties.Resources.Request_Book;
            this.RequestToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RequestToolStripButton.Name = "RequestToolStripButton";
            this.RequestToolStripButton.Size = new System.Drawing.Size(173, 59);
            this.RequestToolStripButton.Text = "Book Request";
            this.RequestToolStripButton.Click += new System.EventHandler(this.RequestToolStripButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BooksDataGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1354, 671);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BookFilterTableLayoutPanel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F);
            this.groupBox1.Location = new System.Drawing.Point(957, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 665);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Filter";
            // 
            // BookFilterTableLayoutPanel
            // 
            this.BookFilterTableLayoutPanel.ColumnCount = 1;
            this.BookFilterTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BookFilterTableLayoutPanel.Controls.Add(this.tableLayoutPanel3, 0, 7);
            this.BookFilterTableLayoutPanel.Controls.Add(this.flowLayoutPanel7, 0, 3);
            this.BookFilterTableLayoutPanel.Controls.Add(this.flowLayoutPanel5, 0, 5);
            this.BookFilterTableLayoutPanel.Controls.Add(this.flowLayoutPanel4, 0, 4);
            this.BookFilterTableLayoutPanel.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.BookFilterTableLayoutPanel.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.BookFilterTableLayoutPanel.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.BookFilterTableLayoutPanel.Controls.Add(this.AvailableBooksOnlyCheckBox, 0, 6);
            this.BookFilterTableLayoutPanel.Controls.Add(this.FilterLabel, 0, 9);
            this.BookFilterTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookFilterTableLayoutPanel.Location = new System.Drawing.Point(3, 23);
            this.BookFilterTableLayoutPanel.Name = "BookFilterTableLayoutPanel";
            this.BookFilterTableLayoutPanel.RowCount = 10;
            this.BookFilterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BookFilterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BookFilterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BookFilterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BookFilterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BookFilterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BookFilterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BookFilterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BookFilterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BookFilterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BookFilterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BookFilterTableLayoutPanel.Size = new System.Drawing.Size(388, 639);
            this.BookFilterTableLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.SearchButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ClearButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 444);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(382, 57);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // SearchButton
            // 
            this.SearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.SearchButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SearchButton.Location = new System.Drawing.Point(194, 3);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(185, 51);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Filter";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.ClearButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ClearButton.Location = new System.Drawing.Point(3, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(185, 51);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.label6);
            this.flowLayoutPanel7.Controls.Add(this.PublisherTextBox);
            this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 192);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(382, 57);
            this.flowLayoutPanel7.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Publisher";
            // 
            // PublisherTextBox
            // 
            this.PublisherTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PublisherTextBox.Location = new System.Drawing.Point(3, 23);
            this.PublisherTextBox.MaxLength = 255;
            this.PublisherTextBox.Name = "PublisherTextBox";
            this.PublisherTextBox.Size = new System.Drawing.Size(376, 30);
            this.PublisherTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label5);
            this.flowLayoutPanel5.Controls.Add(this.GenreComboBox);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 318);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(382, 57);
            this.flowLayoutPanel5.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Genre";
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(3, 23);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(376, 28);
            this.GenreComboBox.TabIndex = 2;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label4);
            this.flowLayoutPanel4.Controls.Add(this.LanguageComboBox);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 255);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(382, 57);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Language";
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Location = new System.Drawing.Point(3, 23);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(376, 28);
            this.LanguageComboBox.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.ISBNTextBox);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 129);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(382, 57);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "ISBN";
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ISBNTextBox.Location = new System.Drawing.Point(3, 23);
            this.ISBNTextBox.MaxLength = 13;
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(376, 30);
            this.ISBNTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.AuthorTextBox);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 66);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(382, 57);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Author";
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AuthorTextBox.Location = new System.Drawing.Point(3, 23);
            this.AuthorTextBox.MaxLength = 50;
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(376, 30);
            this.AuthorTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.TitleTextBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(382, 57);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TitleTextBox.Location = new System.Drawing.Point(3, 23);
            this.TitleTextBox.MaxLength = 255;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(376, 30);
            this.TitleTextBox.TabIndex = 1;
            // 
            // AvailableBooksOnlyCheckBox
            // 
            this.AvailableBooksOnlyCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AvailableBooksOnlyCheckBox.AutoSize = true;
            this.AvailableBooksOnlyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AvailableBooksOnlyCheckBox.Location = new System.Drawing.Point(84, 395);
            this.AvailableBooksOnlyCheckBox.Name = "AvailableBooksOnlyCheckBox";
            this.AvailableBooksOnlyCheckBox.Size = new System.Drawing.Size(220, 29);
            this.AvailableBooksOnlyCheckBox.TabIndex = 5;
            this.AvailableBooksOnlyCheckBox.Text = "Only Available Books";
            this.AvailableBooksOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilterLabel
            // 
            this.FilterLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FilterLabel.Location = new System.Drawing.Point(115, 589);
            this.FilterLabel.MaximumSize = new System.Drawing.Size(223, 40);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(158, 28);
            this.FilterLabel.TabIndex = 14;
            this.FilterLabel.Text = "No Books Found";
            this.FilterLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FilterLabel.UseCompatibleTextRendering = true;
            this.FilterLabel.UseMnemonic = false;
            // 
            // BooksDataGridView
            // 
            this.BooksDataGridView.AllowUserToAddRows = false;
            this.BooksDataGridView.AllowUserToDeleteRows = false;
            this.BooksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BooksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBNColumn,
            this.TitleColumn,
            this.AuthorColumn,
            this.GenreColumn,
            this.PublisherColumn,
            this.LanguageColumn,
            this.TotalColumn,
            this.LoanedColumn,
            this.CostColumn,
            this.ShelfColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BooksDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.BooksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BooksDataGridView.Location = new System.Drawing.Point(3, 3);
            this.BooksDataGridView.MultiSelect = false;
            this.BooksDataGridView.Name = "BooksDataGridView";
            this.BooksDataGridView.ReadOnly = true;
            this.BooksDataGridView.RowTemplate.Height = 33;
            this.BooksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BooksDataGridView.Size = new System.Drawing.Size(948, 665);
            this.BooksDataGridView.TabIndex = 1;
            this.BooksDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.BooksDataGridView_CellMouseDoubleClick);
            // 
            // ISBNColumn
            // 
            this.ISBNColumn.DataPropertyName = "ISBN";
            this.ISBNColumn.HeaderText = "ISBN";
            this.ISBNColumn.MinimumWidth = 80;
            this.ISBNColumn.Name = "ISBNColumn";
            this.ISBNColumn.ReadOnly = true;
            // 
            // TitleColumn
            // 
            this.TitleColumn.DataPropertyName = "BookTitle";
            this.TitleColumn.FillWeight = 50F;
            this.TitleColumn.HeaderText = "Title";
            this.TitleColumn.MinimumWidth = 150;
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.ReadOnly = true;
            // 
            // AuthorColumn
            // 
            this.AuthorColumn.DataPropertyName = "Author";
            this.AuthorColumn.FillWeight = 50F;
            this.AuthorColumn.HeaderText = "Author";
            this.AuthorColumn.MinimumWidth = 100;
            this.AuthorColumn.Name = "AuthorColumn";
            this.AuthorColumn.ReadOnly = true;
            // 
            // GenreColumn
            // 
            this.GenreColumn.DataPropertyName = "Genre";
            this.GenreColumn.HeaderText = "Genre";
            this.GenreColumn.Name = "GenreColumn";
            this.GenreColumn.ReadOnly = true;
            // 
            // PublisherColumn
            // 
            this.PublisherColumn.DataPropertyName = "Publisher";
            this.PublisherColumn.FillWeight = 75F;
            this.PublisherColumn.HeaderText = "Publisher";
            this.PublisherColumn.MinimumWidth = 150;
            this.PublisherColumn.Name = "PublisherColumn";
            this.PublisherColumn.ReadOnly = true;
            // 
            // LanguageColumn
            // 
            this.LanguageColumn.DataPropertyName = "Language";
            this.LanguageColumn.HeaderText = "Language";
            this.LanguageColumn.Name = "LanguageColumn";
            this.LanguageColumn.ReadOnly = true;
            // 
            // TotalColumn
            // 
            this.TotalColumn.DataPropertyName = "TotalStock";
            this.TotalColumn.HeaderText = "Stock";
            this.TotalColumn.Name = "TotalColumn";
            this.TotalColumn.ReadOnly = true;
            // 
            // LoanedColumn
            // 
            this.LoanedColumn.DataPropertyName = "Loaned";
            this.LoanedColumn.HeaderText = "Loan";
            this.LoanedColumn.Name = "LoanedColumn";
            this.LoanedColumn.ReadOnly = true;
            // 
            // CostColumn
            // 
            this.CostColumn.DataPropertyName = "BookCost";
            this.CostColumn.HeaderText = "Cost";
            this.CostColumn.Name = "CostColumn";
            this.CostColumn.ReadOnly = true;
            // 
            // ShelfColumn
            // 
            this.ShelfColumn.DataPropertyName = "Shelf";
            this.ShelfColumn.HeaderText = "Shelf";
            this.ShelfColumn.Name = "ShelfColumn";
            this.ShelfColumn.ReadOnly = true;
            // 
            // ManageBooks
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.LibrarianToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1000, 726);
            this.Name = "ManageBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageBooks_Load);
            this.LibrarianToolStrip.ResumeLayout(false);
            this.LibrarianToolStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.BookFilterTableLayoutPanel.ResumeLayout(false);
            this.BookFilterTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip LibrarianToolStrip;
        private System.Windows.Forms.ToolStripButton ModifyBookToolStripButton;
        private System.Windows.Forms.ToolStripButton AddBookToolStripButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView BooksDataGridView;
        private System.Windows.Forms.TableLayoutPanel BookFilterTableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.CheckBox AvailableBooksOnlyCheckBox;
        private System.Windows.Forms.ToolStripButton RequestToolStripButton;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PublisherTextBox;
        private System.Windows.Forms.ToolStripButton CancelSearchToolStripButton;
        private System.Windows.Forms.ToolStripButton UseSelectedToolStripButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ClearButton;
        protected System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanguageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShelfColumn;
        private System.Windows.Forms.ToolStripButton DeleteBookToolStripButton;
    }
}
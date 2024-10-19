namespace MyApplication;

partial class MainForm
{
	private System.ComponentModel.IContainer components = null;

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
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		searchPanel = new Panel();
		codeToLabel = new Label();
		searchButton = new Button();
		codeToTextBox = new TextBox();
		codeFromTextBox = new TextBox();
		nameTextBox = new TextBox();
		codeFromLabel = new Label();
		nameLabel = new Label();
		paginationPanel = new Panel();
		ofLabel = new Label();
		pageCountLabel = new Label();
		pageIndexLabel = new Label();
		recordCountLabel = new Label();
		goToLastPageButton = new Button();
		goToNextPageButton = new Button();
		goToPreviousPageButton = new Button();
		goToFirstPageButton = new Button();
		pageSizeLabel = new Label();
		pageSizeComboBox = new ComboBox();
		dataPanel = new Panel();
		myDataGridView = new DataGridView();
		searchPanel.SuspendLayout();
		paginationPanel.SuspendLayout();
		dataPanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)myDataGridView).BeginInit();
		SuspendLayout();
		// 
		// searchPanel
		// 
		searchPanel.Controls.Add(codeToLabel);
		searchPanel.Controls.Add(searchButton);
		searchPanel.Controls.Add(codeToTextBox);
		searchPanel.Controls.Add(codeFromTextBox);
		searchPanel.Controls.Add(nameTextBox);
		searchPanel.Controls.Add(codeFromLabel);
		searchPanel.Controls.Add(nameLabel);
		searchPanel.Dock = DockStyle.Top;
		searchPanel.Location = new Point(0, 0);
		searchPanel.Name = "searchPanel";
		searchPanel.Size = new Size(884, 114);
		searchPanel.TabIndex = 0;
		// 
		// codeToLabel
		// 
		codeToLabel.AutoSize = true;
		codeToLabel.Location = new Point(271, 48);
		codeToLabel.Name = "codeToLabel";
		codeToLabel.Size = new Size(25, 20);
		codeToLabel.TabIndex = 4;
		codeToLabel.Text = "&To";
		// 
		// searchButton
		// 
		searchButton.Location = new Point(100, 78);
		searchButton.Name = "searchButton";
		searchButton.Size = new Size(94, 29);
		searchButton.TabIndex = 6;
		searchButton.Text = "&Search";
		searchButton.UseVisualStyleBackColor = true;
		searchButton.Click += SearchButton_Click;
		// 
		// codeToTextBox
		// 
		codeToTextBox.Location = new Point(302, 45);
		codeToTextBox.Name = "codeToTextBox";
		codeToTextBox.Size = new Size(165, 27);
		codeToTextBox.TabIndex = 5;
		// 
		// codeFromTextBox
		// 
		codeFromTextBox.Location = new Point(100, 45);
		codeFromTextBox.Name = "codeFromTextBox";
		codeFromTextBox.Size = new Size(165, 27);
		codeFromTextBox.TabIndex = 3;
		// 
		// nameTextBox
		// 
		nameTextBox.Location = new Point(100, 12);
		nameTextBox.Name = "nameTextBox";
		nameTextBox.Size = new Size(165, 27);
		nameTextBox.TabIndex = 1;
		// 
		// codeFromLabel
		// 
		codeFromLabel.AutoSize = true;
		codeFromLabel.Location = new Point(12, 48);
		codeFromLabel.Name = "codeFromLabel";
		codeFromLabel.Size = new Size(82, 20);
		codeFromLabel.TabIndex = 2;
		codeFromLabel.Text = "&Code From";
		// 
		// nameLabel
		// 
		nameLabel.AutoSize = true;
		nameLabel.Location = new Point(12, 15);
		nameLabel.Name = "nameLabel";
		nameLabel.Size = new Size(49, 20);
		nameLabel.TabIndex = 0;
		nameLabel.Text = "&Name";
		// 
		// paginationPanel
		// 
		paginationPanel.Controls.Add(ofLabel);
		paginationPanel.Controls.Add(pageCountLabel);
		paginationPanel.Controls.Add(pageIndexLabel);
		paginationPanel.Controls.Add(recordCountLabel);
		paginationPanel.Controls.Add(goToLastPageButton);
		paginationPanel.Controls.Add(goToNextPageButton);
		paginationPanel.Controls.Add(goToPreviousPageButton);
		paginationPanel.Controls.Add(goToFirstPageButton);
		paginationPanel.Controls.Add(pageSizeLabel);
		paginationPanel.Controls.Add(pageSizeComboBox);
		paginationPanel.Dock = DockStyle.Bottom;
		paginationPanel.Location = new Point(0, 460);
		paginationPanel.Name = "paginationPanel";
		paginationPanel.Size = new Size(884, 42);
		paginationPanel.TabIndex = 1;
		// 
		// ofLabel
		// 
		ofLabel.AutoSize = true;
		ofLabel.Location = new Point(355, 10);
		ofLabel.Name = "ofLabel";
		ofLabel.Size = new Size(12, 20);
		ofLabel.TabIndex = 4;
		ofLabel.Text = ":";
		// 
		// pageCountLabel
		// 
		pageCountLabel.AutoSize = true;
		pageCountLabel.Location = new Point(373, 10);
		pageCountLabel.Name = "pageCountLabel";
		pageCountLabel.Size = new Size(48, 20);
		pageCountLabel.TabIndex = 5;
		pageCountLabel.Text = "#,###";
		// 
		// pageIndexLabel
		// 
		pageIndexLabel.AutoSize = true;
		pageIndexLabel.Location = new Point(301, 10);
		pageIndexLabel.Name = "pageIndexLabel";
		pageIndexLabel.Size = new Size(48, 20);
		pageIndexLabel.TabIndex = 3;
		pageIndexLabel.Text = "#,###";
		// 
		// recordCountLabel
		// 
		recordCountLabel.AutoSize = true;
		recordCountLabel.Location = new Point(247, 10);
		recordCountLabel.Name = "recordCountLabel";
		recordCountLabel.Size = new Size(48, 20);
		recordCountLabel.TabIndex = 2;
		recordCountLabel.Text = "#,###";
		// 
		// goToLastPageButton
		// 
		goToLastPageButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		goToLastPageButton.Location = new Point(778, 6);
		goToLastPageButton.Name = "goToLastPageButton";
		goToLastPageButton.Size = new Size(94, 29);
		goToLastPageButton.TabIndex = 9;
		goToLastPageButton.Text = "&Last";
		goToLastPageButton.UseVisualStyleBackColor = true;
		goToLastPageButton.Click += GoToLastPageButton_Click;
		// 
		// goToNextPageButton
		// 
		goToNextPageButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		goToNextPageButton.Location = new Point(678, 6);
		goToNextPageButton.Name = "goToNextPageButton";
		goToNextPageButton.Size = new Size(94, 29);
		goToNextPageButton.TabIndex = 8;
		goToNextPageButton.Text = "&Next";
		goToNextPageButton.UseVisualStyleBackColor = true;
		goToNextPageButton.Click += GoToNextPageButton_Click;
		// 
		// goToPreviousPageButton
		// 
		goToPreviousPageButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		goToPreviousPageButton.Location = new Point(578, 6);
		goToPreviousPageButton.Name = "goToPreviousPageButton";
		goToPreviousPageButton.Size = new Size(94, 29);
		goToPreviousPageButton.TabIndex = 7;
		goToPreviousPageButton.Text = "&Previous";
		goToPreviousPageButton.UseVisualStyleBackColor = true;
		goToPreviousPageButton.Click += GoToPreviousPageButton_Click;
		// 
		// goToFirstPageButton
		// 
		goToFirstPageButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		goToFirstPageButton.Location = new Point(478, 6);
		goToFirstPageButton.Name = "goToFirstPageButton";
		goToFirstPageButton.Size = new Size(94, 29);
		goToFirstPageButton.TabIndex = 6;
		goToFirstPageButton.Text = "&First";
		goToFirstPageButton.UseVisualStyleBackColor = true;
		goToFirstPageButton.Click += GoToFirstPageButton_Click;
		// 
		// pageSizeLabel
		// 
		pageSizeLabel.AutoSize = true;
		pageSizeLabel.Location = new Point(12, 10);
		pageSizeLabel.Name = "pageSizeLabel";
		pageSizeLabel.Size = new Size(72, 20);
		pageSizeLabel.TabIndex = 0;
		pageSizeLabel.Text = "&Page Size";
		// 
		// pageSizeComboBox
		// 
		pageSizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
		pageSizeComboBox.FormattingEnabled = true;
		pageSizeComboBox.Items.AddRange(new object[] { "10", "20", "50", "100" });
		pageSizeComboBox.Location = new Point(90, 7);
		pageSizeComboBox.Name = "pageSizeComboBox";
		pageSizeComboBox.Size = new Size(151, 28);
		pageSizeComboBox.TabIndex = 1;
		pageSizeComboBox.SelectedIndexChanged += PageSizeComboBox_SelectedIndexChanged;
		// 
		// dataPanel
		// 
		dataPanel.Controls.Add(myDataGridView);
		dataPanel.Dock = DockStyle.Fill;
		dataPanel.Location = new Point(0, 114);
		dataPanel.Name = "dataPanel";
		dataPanel.Size = new Size(884, 346);
		dataPanel.TabIndex = 2;
		// 
		// myDataGridView
		// 
		myDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		myDataGridView.Dock = DockStyle.Fill;
		myDataGridView.Location = new Point(0, 0);
		myDataGridView.Name = "myDataGridView";
		myDataGridView.RowHeadersWidth = 51;
		myDataGridView.Size = new Size(884, 346);
		myDataGridView.TabIndex = 0;
		// 
		// MainForm
		// 
		AutoScaleDimensions = new SizeF(8F, 20F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(884, 502);
		Controls.Add(dataPanel);
		Controls.Add(paginationPanel);
		Controls.Add(searchPanel);
		Name = "MainForm";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "Search";
		Load += MainForm_Load;
		searchPanel.ResumeLayout(false);
		searchPanel.PerformLayout();
		paginationPanel.ResumeLayout(false);
		paginationPanel.PerformLayout();
		dataPanel.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)myDataGridView).EndInit();
		ResumeLayout(false);
	}

	#endregion

	private Panel searchPanel;
	private Panel paginationPanel;
	private Panel dataPanel;
	private DataGridView myDataGridView;
	private Label codeToLabel;
	private Button searchButton;
	private TextBox codeToTextBox;
	private TextBox codeFromTextBox;
	private TextBox nameTextBox;
	private Label codeFromLabel;
	private Label nameLabel;
	private Button goToLastPageButton;
	private Button goToNextPageButton;
	private Button goToPreviousPageButton;
	private Button goToFirstPageButton;
	private Label pageSizeLabel;
	private ComboBox pageSizeComboBox;
	private Label recordCountLabel;
	private Label ofLabel;
	private Label pageCountLabel;
	private Label pageIndexLabel;
}

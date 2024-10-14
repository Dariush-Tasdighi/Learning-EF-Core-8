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
		paginationPanel = new Panel();
		dataPanel = new Panel();
		myDataGridView = new DataGridView();
		nameLabel = new Label();
		codeFromLabel = new Label();
		nameTextBox = new TextBox();
		codeFromTextBox = new TextBox();
		codeToTextBox = new TextBox();
		searchButton = new Button();
		codeToLabel = new Label();
		pageSizeComboBox = new ComboBox();
		pageSizeLabel = new Label();
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		button4 = new Button();
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
		searchPanel.Size = new Size(800, 114);
		searchPanel.TabIndex = 0;
		// 
		// paginationPanel
		// 
		paginationPanel.Controls.Add(button4);
		paginationPanel.Controls.Add(button3);
		paginationPanel.Controls.Add(button2);
		paginationPanel.Controls.Add(button1);
		paginationPanel.Controls.Add(pageSizeLabel);
		paginationPanel.Controls.Add(pageSizeComboBox);
		paginationPanel.Dock = DockStyle.Bottom;
		paginationPanel.Location = new Point(0, 408);
		paginationPanel.Name = "paginationPanel";
		paginationPanel.Size = new Size(800, 42);
		paginationPanel.TabIndex = 1;
		// 
		// dataPanel
		// 
		dataPanel.Controls.Add(myDataGridView);
		dataPanel.Dock = DockStyle.Fill;
		dataPanel.Location = new Point(0, 114);
		dataPanel.Name = "dataPanel";
		dataPanel.Size = new Size(800, 294);
		dataPanel.TabIndex = 2;
		// 
		// myDataGridView
		// 
		myDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		myDataGridView.Dock = DockStyle.Fill;
		myDataGridView.Location = new Point(0, 0);
		myDataGridView.Name = "myDataGridView";
		myDataGridView.RowHeadersWidth = 51;
		myDataGridView.Size = new Size(800, 294);
		myDataGridView.TabIndex = 0;
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
		// codeFromLabel
		// 
		codeFromLabel.AutoSize = true;
		codeFromLabel.Location = new Point(12, 48);
		codeFromLabel.Name = "codeFromLabel";
		codeFromLabel.Size = new Size(82, 20);
		codeFromLabel.TabIndex = 2;
		codeFromLabel.Text = "&Code From";
		// 
		// nameTextBox
		// 
		nameTextBox.Location = new Point(100, 12);
		nameTextBox.Name = "nameTextBox";
		nameTextBox.Size = new Size(165, 27);
		nameTextBox.TabIndex = 1;
		// 
		// codeFromTextBox
		// 
		codeFromTextBox.Location = new Point(100, 45);
		codeFromTextBox.Name = "codeFromTextBox";
		codeFromTextBox.Size = new Size(165, 27);
		codeFromTextBox.TabIndex = 3;
		// 
		// codeToTextBox
		// 
		codeToTextBox.Location = new Point(302, 45);
		codeToTextBox.Name = "codeToTextBox";
		codeToTextBox.Size = new Size(165, 27);
		codeToTextBox.TabIndex = 5;
		// 
		// searchButton
		// 
		searchButton.Location = new Point(100, 78);
		searchButton.Name = "searchButton";
		searchButton.Size = new Size(94, 29);
		searchButton.TabIndex = 6;
		searchButton.Text = "&Search";
		searchButton.UseVisualStyleBackColor = true;
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
		// pageSizeComboBox
		// 
		pageSizeComboBox.FormattingEnabled = true;
		pageSizeComboBox.Items.AddRange(new object[] { "10", "20", "50", "100" });
		pageSizeComboBox.Location = new Point(90, 7);
		pageSizeComboBox.Name = "pageSizeComboBox";
		pageSizeComboBox.Size = new Size(151, 28);
		pageSizeComboBox.TabIndex = 1;
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
		// button1
		// 
		button1.Location = new Point(247, 6);
		button1.Name = "button1";
		button1.Size = new Size(94, 29);
		button1.TabIndex = 2;
		button1.Text = "&First";
		button1.UseVisualStyleBackColor = true;
		// 
		// button2
		// 
		button2.Location = new Point(347, 6);
		button2.Name = "button2";
		button2.Size = new Size(94, 29);
		button2.TabIndex = 3;
		button2.Text = "&Previous";
		button2.UseVisualStyleBackColor = true;
		// 
		// button3
		// 
		button3.Location = new Point(447, 6);
		button3.Name = "button3";
		button3.Size = new Size(94, 29);
		button3.TabIndex = 4;
		button3.Text = "&Next";
		button3.UseVisualStyleBackColor = true;
		// 
		// button4
		// 
		button4.Location = new Point(547, 6);
		button4.Name = "button4";
		button4.Size = new Size(94, 29);
		button4.TabIndex = 5;
		button4.Text = "&Last";
		button4.UseVisualStyleBackColor = true;
		// 
		// MainForm
		// 
		AutoScaleDimensions = new SizeF(8F, 20F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 450);
		Controls.Add(dataPanel);
		Controls.Add(paginationPanel);
		Controls.Add(searchPanel);
		Name = "MainForm";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "Search";
		Load += Form1_Load;
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
	private Button button4;
	private Button button3;
	private Button button2;
	private Button button1;
	private Label pageSizeLabel;
	private ComboBox pageSizeComboBox;
}

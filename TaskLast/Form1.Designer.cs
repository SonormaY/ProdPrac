namespace TaskLast
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            debug = new Button();
            courseNameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            teacherTextBox = new TextBox();
            label3 = new Label();
            hoursTextBox = new TextBox();
            addButton = new Button();
            label4 = new Label();
            searchTextBox = new TextBox();
            searchButton = new Button();
            filePathLabel = new Label();
            label5 = new Label();
            courseNameRadioButton = new RadioButton();
            teacherRadioButton = new RadioButton();
            hoursRadioButton = new RadioButton();
            sortButton = new Button();
            dataTable = new DataGridView();
            courseNameTableColumn = new DataGridViewTextBoxColumn();
            teacherTableColumn = new DataGridViewTextBoxColumn();
            hoursTableColumn = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataTable).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, clearToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(76, 20);
            openFileToolStripMenuItem.Text = "Open file...";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(52, 20);
            saveToolStripMenuItem.Text = "Save...";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(66, 20);
            saveAsToolStripMenuItem.Text = "Save as...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(55, 20);
            clearToolStripMenuItem.Text = "Clear...";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // debug
            // 
            debug.Location = new Point(713, 422);
            debug.Name = "debug";
            debug.Size = new Size(75, 23);
            debug.TabIndex = 1;
            debug.Text = "debug";
            debug.UseVisualStyleBackColor = true;
            debug.Click += debug_Click;
            // 
            // courseNameTextBox
            // 
            courseNameTextBox.Location = new Point(12, 43);
            courseNameTextBox.Name = "courseNameTextBox";
            courseNameTextBox.Size = new Size(100, 23);
            courseNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(83, 13);
            label1.TabIndex = 0;
            label1.Text = "Course Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Teacher";
            // 
            // teacherTextBox
            // 
            teacherTextBox.Location = new Point(12, 87);
            teacherTextBox.Name = "teacherTextBox";
            teacherTextBox.Size = new Size(100, 23);
            teacherTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Hours";
            // 
            // hoursTextBox
            // 
            hoursTextBox.Location = new Point(12, 131);
            hoursTextBox.Name = "hoursTextBox";
            hoursTextBox.Size = new Size(100, 23);
            hoursTextBox.TabIndex = 6;
            // 
            // addButton
            // 
            addButton.Location = new Point(24, 160);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 7;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 25);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 8;
            label4.Text = "Search";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(141, 43);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(100, 23);
            searchTextBox.TabIndex = 9;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(153, 72);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 10;
            searchButton.Text = "Execute";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // filePathLabel
            // 
            filePathLabel.AutoSize = true;
            filePathLabel.Location = new Point(12, 426);
            filePathLabel.Name = "filePathLabel";
            filePathLabel.Size = new Size(153, 15);
            filePathLabel.TabIndex = 11;
            filePathLabel.Text = "Currently opened file: None";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 25);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 12;
            label5.Text = "Sort";
            // 
            // courseNameRadioButton
            // 
            courseNameRadioButton.AutoSize = true;
            courseNameRadioButton.Location = new Point(264, 43);
            courseNameRadioButton.Name = "courseNameRadioButton";
            courseNameRadioButton.Size = new Size(97, 19);
            courseNameRadioButton.TabIndex = 13;
            courseNameRadioButton.TabStop = true;
            courseNameRadioButton.Text = "Course Name";
            courseNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // teacherRadioButton
            // 
            teacherRadioButton.AutoSize = true;
            teacherRadioButton.Location = new Point(264, 68);
            teacherRadioButton.Name = "teacherRadioButton";
            teacherRadioButton.Size = new Size(65, 19);
            teacherRadioButton.TabIndex = 14;
            teacherRadioButton.TabStop = true;
            teacherRadioButton.Text = "Teacher";
            teacherRadioButton.UseVisualStyleBackColor = true;
            // 
            // hoursRadioButton
            // 
            hoursRadioButton.AutoSize = true;
            hoursRadioButton.Location = new Point(264, 93);
            hoursRadioButton.Name = "hoursRadioButton";
            hoursRadioButton.Size = new Size(57, 19);
            hoursRadioButton.TabIndex = 15;
            hoursRadioButton.TabStop = true;
            hoursRadioButton.Text = "Hours";
            hoursRadioButton.UseVisualStyleBackColor = true;
            // 
            // sortButton
            // 
            sortButton.Location = new Point(264, 118);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(75, 23);
            sortButton.TabIndex = 16;
            sortButton.Text = "Execute";
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click;
            // 
            // dataTable
            // 
            dataTable.AllowUserToAddRows = false;
            dataTable.AllowUserToDeleteRows = false;
            dataTable.AllowUserToResizeColumns = false;
            dataTable.AllowUserToResizeRows = false;
            dataTable.BackgroundColor = SystemColors.Menu;
            dataTable.BorderStyle = BorderStyle.None;
            dataTable.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTable.Columns.AddRange(new DataGridViewColumn[] { courseNameTableColumn, teacherTableColumn, hoursTableColumn });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataTable.DefaultCellStyle = dataGridViewCellStyle1;
            dataTable.GridColor = SystemColors.Menu;
            dataTable.Location = new Point(403, 15);
            dataTable.Name = "dataTable";
            dataTable.ReadOnly = true;
            dataTable.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataTable.ShowCellErrors = false;
            dataTable.ShowCellToolTips = false;
            dataTable.ShowEditingIcon = false;
            dataTable.ShowRowErrors = false;
            dataTable.Size = new Size(369, 401);
            dataTable.TabIndex = 17;
            // 
            // courseNameTableColumn
            // 
            courseNameTableColumn.HeaderText = "Course Name";
            courseNameTableColumn.Name = "courseNameTableColumn";
            courseNameTableColumn.ReadOnly = true;
            // 
            // teacherTableColumn
            // 
            teacherTableColumn.HeaderText = "Teacher";
            teacherTableColumn.Name = "teacherTableColumn";
            teacherTableColumn.ReadOnly = true;
            // 
            // hoursTableColumn
            // 
            hoursTableColumn.HeaderText = "Hours";
            hoursTableColumn.Name = "hoursTableColumn";
            hoursTableColumn.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataTable);
            Controls.Add(sortButton);
            Controls.Add(hoursRadioButton);
            Controls.Add(teacherRadioButton);
            Controls.Add(courseNameRadioButton);
            Controls.Add(label5);
            Controls.Add(filePathLabel);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(label4);
            Controls.Add(addButton);
            Controls.Add(hoursTextBox);
            Controls.Add(label3);
            Controls.Add(teacherTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(courseNameTextBox);
            Controls.Add(debug);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Program_wtf";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private Button debug;
        private TextBox courseNameTextBox;
        private Label label1;
        private Label label2;
        private TextBox teacherTextBox;
        private Label label3;
        private TextBox hoursTextBox;
        private Button addButton;
        private Label label4;
        private TextBox searchTextBox;
        private Button searchButton;
        private Label filePathLabel;
        private Label label5;
        private RadioButton courseNameRadioButton;
        private RadioButton teacherRadioButton;
        private RadioButton hoursRadioButton;
        private Button sortButton;
        private DataGridView dataTable;
        private DataGridViewTextBoxColumn courseNameTableColumn;
        private DataGridViewTextBoxColumn teacherTableColumn;
        private DataGridViewTextBoxColumn hoursTableColumn;
    }
}

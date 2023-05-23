namespace LINQ_Research
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AuthorButton = new System.Windows.Forms.Button();
            this.MainMenuToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ResearchButton = new System.Windows.Forms.Button();
            this.TeacherGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FilterBirthYearRButton = new System.Windows.Forms.RadioButton();
            this.FilterStandingRButton = new System.Windows.Forms.RadioButton();
            this.FilterSalaryRButton = new System.Windows.Forms.RadioButton();
            this.FilterButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SortStandingRButton = new System.Windows.Forms.RadioButton();
            this.SortAgeRButton = new System.Windows.Forms.RadioButton();
            this.SortSalaryRButton = new System.Windows.Forms.RadioButton();
            this.AggregateButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AggregateAverageAgeRButton = new System.Windows.Forms.RadioButton();
            this.AggregateAverageStandingRButton = new System.Windows.Forms.RadioButton();
            this.AggregateAverageSalaryRButton = new System.Windows.Forms.RadioButton();
            this.AggregateTextBox = new System.Windows.Forms.TextBox();
            this.GroupButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GroupTitleRButton = new System.Windows.Forms.RadioButton();
            this.GroupCathedraRButton = new System.Windows.Forms.RadioButton();
            this.GroupSurnameRButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthorButton
            // 
            this.AuthorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.AuthorButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AuthorButton.BackgroundImage")));
            this.AuthorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AuthorButton.FlatAppearance.BorderSize = 0;
            this.AuthorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorButton.Location = new System.Drawing.Point(714, 447);
            this.AuthorButton.Name = "AuthorButton";
            this.AuthorButton.Size = new System.Drawing.Size(98, 96);
            this.AuthorButton.TabIndex = 0;
            this.MainMenuToolTip.SetToolTip(this.AuthorButton, "Information about author");
            this.AuthorButton.UseVisualStyleBackColor = false;
            this.AuthorButton.Click += new System.EventHandler(this.AuthorButton_Click);
            // 
            // ResearchButton
            // 
            this.ResearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ResearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResearchButton.BackgroundImage")));
            this.ResearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResearchButton.FlatAppearance.BorderSize = 0;
            this.ResearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResearchButton.Location = new System.Drawing.Point(714, 345);
            this.ResearchButton.Name = "ResearchButton";
            this.ResearchButton.Size = new System.Drawing.Size(98, 96);
            this.ResearchButton.TabIndex = 11;
            this.MainMenuToolTip.SetToolTip(this.ResearchButton, "Research ");
            this.ResearchButton.UseVisualStyleBackColor = false;
            this.ResearchButton.Click += new System.EventHandler(this.ResearchButton_Click);
            // 
            // TeacherGridView
            // 
            this.TeacherGridView.AllowUserToResizeColumns = false;
            this.TeacherGridView.AllowUserToResizeRows = false;
            this.TeacherGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.TeacherGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeacherGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TeacherGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TeacherGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.TeacherGridView.GridColor = System.Drawing.Color.White;
            this.TeacherGridView.Location = new System.Drawing.Point(12, 12);
            this.TeacherGridView.Name = "TeacherGridView";
            this.TeacherGridView.RowHeadersVisible = false;
            this.TeacherGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TeacherGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TeacherGridView.RowTemplate.Height = 24;
            this.TeacherGridView.Size = new System.Drawing.Size(854, 328);
            this.TeacherGridView.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FilterBirthYearRButton);
            this.groupBox1.Controls.Add(this.FilterStandingRButton);
            this.groupBox1.Controls.Add(this.FilterSalaryRButton);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // FilterBirthYearRButton
            // 
            this.FilterBirthYearRButton.AutoSize = true;
            this.FilterBirthYearRButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterBirthYearRButton.ForeColor = System.Drawing.Color.White;
            this.FilterBirthYearRButton.Location = new System.Drawing.Point(6, 67);
            this.FilterBirthYearRButton.Name = "FilterBirthYearRButton";
            this.FilterBirthYearRButton.Size = new System.Drawing.Size(172, 24);
            this.FilterBirthYearRButton.TabIndex = 2;
            this.FilterBirthYearRButton.Text = "Year of birth > 1990";
            this.FilterBirthYearRButton.UseVisualStyleBackColor = true;
            // 
            // FilterStandingRButton
            // 
            this.FilterStandingRButton.AutoSize = true;
            this.FilterStandingRButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterStandingRButton.ForeColor = System.Drawing.Color.White;
            this.FilterStandingRButton.Location = new System.Drawing.Point(6, 40);
            this.FilterStandingRButton.Name = "FilterStandingRButton";
            this.FilterStandingRButton.Size = new System.Drawing.Size(120, 24);
            this.FilterStandingRButton.TabIndex = 1;
            this.FilterStandingRButton.Text = "Standing > 5";
            this.FilterStandingRButton.UseVisualStyleBackColor = true;
            // 
            // FilterSalaryRButton
            // 
            this.FilterSalaryRButton.AutoSize = true;
            this.FilterSalaryRButton.Checked = true;
            this.FilterSalaryRButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterSalaryRButton.ForeColor = System.Drawing.Color.White;
            this.FilterSalaryRButton.Location = new System.Drawing.Point(6, 14);
            this.FilterSalaryRButton.Name = "FilterSalaryRButton";
            this.FilterSalaryRButton.Size = new System.Drawing.Size(128, 24);
            this.FilterSalaryRButton.TabIndex = 0;
            this.FilterSalaryRButton.TabStop = true;
            this.FilterSalaryRButton.Text = "Salary > 5000";
            this.FilterSalaryRButton.UseVisualStyleBackColor = true;
            // 
            // FilterButton
            // 
            this.FilterButton.BackColor = System.Drawing.Color.White;
            this.FilterButton.FlatAppearance.BorderSize = 0;
            this.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.FilterButton.Location = new System.Drawing.Point(12, 346);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(200, 58);
            this.FilterButton.TabIndex = 3;
            this.FilterButton.Text = "Filter";
            this.MainMenuToolTip.SetToolTip(this.FilterButton, "Filter elements by specific value");
            this.FilterButton.UseVisualStyleBackColor = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.BackColor = System.Drawing.Color.White;
            this.SortButton.FlatAppearance.BorderSize = 0;
            this.SortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SortButton.Location = new System.Drawing.Point(218, 346);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(111, 58);
            this.SortButton.TabIndex = 5;
            this.SortButton.Text = "Sort";
            this.MainMenuToolTip.SetToolTip(this.SortButton, "Sort elements by specific value");
            this.SortButton.UseVisualStyleBackColor = false;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SortStandingRButton);
            this.groupBox2.Controls.Add(this.SortAgeRButton);
            this.groupBox2.Controls.Add(this.SortSalaryRButton);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(218, 410);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(111, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // SortStandingRButton
            // 
            this.SortStandingRButton.AutoSize = true;
            this.SortStandingRButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortStandingRButton.ForeColor = System.Drawing.Color.White;
            this.SortStandingRButton.Location = new System.Drawing.Point(6, 40);
            this.SortStandingRButton.Name = "SortStandingRButton";
            this.SortStandingRButton.Size = new System.Drawing.Size(92, 24);
            this.SortStandingRButton.TabIndex = 2;
            this.SortStandingRButton.Text = "Standing";
            this.SortStandingRButton.UseVisualStyleBackColor = true;
            // 
            // SortAgeRButton
            // 
            this.SortAgeRButton.AutoSize = true;
            this.SortAgeRButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortAgeRButton.ForeColor = System.Drawing.Color.White;
            this.SortAgeRButton.Location = new System.Drawing.Point(6, 67);
            this.SortAgeRButton.Name = "SortAgeRButton";
            this.SortAgeRButton.Size = new System.Drawing.Size(58, 24);
            this.SortAgeRButton.TabIndex = 1;
            this.SortAgeRButton.Text = "Age";
            this.SortAgeRButton.UseVisualStyleBackColor = true;
            // 
            // SortSalaryRButton
            // 
            this.SortSalaryRButton.AutoSize = true;
            this.SortSalaryRButton.Checked = true;
            this.SortSalaryRButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortSalaryRButton.ForeColor = System.Drawing.Color.White;
            this.SortSalaryRButton.Location = new System.Drawing.Point(6, 14);
            this.SortSalaryRButton.Name = "SortSalaryRButton";
            this.SortSalaryRButton.Size = new System.Drawing.Size(73, 24);
            this.SortSalaryRButton.TabIndex = 0;
            this.SortSalaryRButton.TabStop = true;
            this.SortSalaryRButton.Text = "Salary";
            this.SortSalaryRButton.UseVisualStyleBackColor = true;
            // 
            // AggregateButton
            // 
            this.AggregateButton.BackColor = System.Drawing.Color.White;
            this.AggregateButton.FlatAppearance.BorderSize = 0;
            this.AggregateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AggregateButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AggregateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.AggregateButton.Location = new System.Drawing.Point(335, 346);
            this.AggregateButton.Name = "AggregateButton";
            this.AggregateButton.Size = new System.Drawing.Size(200, 58);
            this.AggregateButton.TabIndex = 7;
            this.AggregateButton.Text = "Aggregate";
            this.MainMenuToolTip.SetToolTip(this.AggregateButton, "Aggregate choosen item");
            this.AggregateButton.UseVisualStyleBackColor = false;
            this.AggregateButton.Click += new System.EventHandler(this.AggregateButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AggregateAverageAgeRButton);
            this.groupBox3.Controls.Add(this.AggregateAverageStandingRButton);
            this.groupBox3.Controls.Add(this.AggregateAverageSalaryRButton);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(335, 410);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // AggregateAverageAgeRButton
            // 
            this.AggregateAverageAgeRButton.AutoSize = true;
            this.AggregateAverageAgeRButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AggregateAverageAgeRButton.ForeColor = System.Drawing.Color.White;
            this.AggregateAverageAgeRButton.Location = new System.Drawing.Point(6, 67);
            this.AggregateAverageAgeRButton.Name = "AggregateAverageAgeRButton";
            this.AggregateAverageAgeRButton.Size = new System.Drawing.Size(120, 24);
            this.AggregateAverageAgeRButton.TabIndex = 2;
            this.AggregateAverageAgeRButton.Text = "Average Age";
            this.AggregateAverageAgeRButton.UseVisualStyleBackColor = true;
            // 
            // AggregateAverageStandingRButton
            // 
            this.AggregateAverageStandingRButton.AutoSize = true;
            this.AggregateAverageStandingRButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AggregateAverageStandingRButton.ForeColor = System.Drawing.Color.White;
            this.AggregateAverageStandingRButton.Location = new System.Drawing.Point(6, 40);
            this.AggregateAverageStandingRButton.Name = "AggregateAverageStandingRButton";
            this.AggregateAverageStandingRButton.Size = new System.Drawing.Size(154, 24);
            this.AggregateAverageStandingRButton.TabIndex = 1;
            this.AggregateAverageStandingRButton.Text = "Average Standing";
            this.AggregateAverageStandingRButton.UseVisualStyleBackColor = true;
            // 
            // AggregateAverageSalaryRButton
            // 
            this.AggregateAverageSalaryRButton.AutoSize = true;
            this.AggregateAverageSalaryRButton.Checked = true;
            this.AggregateAverageSalaryRButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AggregateAverageSalaryRButton.ForeColor = System.Drawing.Color.White;
            this.AggregateAverageSalaryRButton.Location = new System.Drawing.Point(6, 14);
            this.AggregateAverageSalaryRButton.Name = "AggregateAverageSalaryRButton";
            this.AggregateAverageSalaryRButton.Size = new System.Drawing.Size(135, 24);
            this.AggregateAverageSalaryRButton.TabIndex = 0;
            this.AggregateAverageSalaryRButton.TabStop = true;
            this.AggregateAverageSalaryRButton.Text = "Average Salary";
            this.AggregateAverageSalaryRButton.UseVisualStyleBackColor = true;
            // 
            // AggregateTextBox
            // 
            this.AggregateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.AggregateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AggregateTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.AggregateTextBox.ForeColor = System.Drawing.Color.White;
            this.AggregateTextBox.Location = new System.Drawing.Point(335, 516);
            this.AggregateTextBox.Name = "AggregateTextBox";
            this.AggregateTextBox.Size = new System.Drawing.Size(200, 27);
            this.AggregateTextBox.TabIndex = 8;
            this.AggregateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MainMenuToolTip.SetToolTip(this.AggregateTextBox, "Result of aggregation");
            // 
            // GroupButton
            // 
            this.GroupButton.BackColor = System.Drawing.Color.White;
            this.GroupButton.FlatAppearance.BorderSize = 0;
            this.GroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.GroupButton.Location = new System.Drawing.Point(541, 346);
            this.GroupButton.Name = "GroupButton";
            this.GroupButton.Size = new System.Drawing.Size(111, 58);
            this.GroupButton.TabIndex = 10;
            this.GroupButton.Text = "Group";
            this.MainMenuToolTip.SetToolTip(this.GroupButton, "Group element by specific data");
            this.GroupButton.UseVisualStyleBackColor = false;
            this.GroupButton.Click += new System.EventHandler(this.GroupButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GroupTitleRButton);
            this.groupBox4.Controls.Add(this.GroupCathedraRButton);
            this.groupBox4.Controls.Add(this.GroupSurnameRButton);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(541, 410);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(111, 100);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // GroupTitleRButton
            // 
            this.GroupTitleRButton.AutoSize = true;
            this.GroupTitleRButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupTitleRButton.ForeColor = System.Drawing.Color.White;
            this.GroupTitleRButton.Location = new System.Drawing.Point(6, 40);
            this.GroupTitleRButton.Name = "GroupTitleRButton";
            this.GroupTitleRButton.Size = new System.Drawing.Size(61, 24);
            this.GroupTitleRButton.TabIndex = 2;
            this.GroupTitleRButton.Text = "Title";
            this.GroupTitleRButton.UseVisualStyleBackColor = true;
            // 
            // GroupCathedraRButton
            // 
            this.GroupCathedraRButton.AutoSize = true;
            this.GroupCathedraRButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupCathedraRButton.ForeColor = System.Drawing.Color.White;
            this.GroupCathedraRButton.Location = new System.Drawing.Point(6, 67);
            this.GroupCathedraRButton.Name = "GroupCathedraRButton";
            this.GroupCathedraRButton.Size = new System.Drawing.Size(93, 24);
            this.GroupCathedraRButton.TabIndex = 1;
            this.GroupCathedraRButton.Text = "Cathedra";
            this.GroupCathedraRButton.UseVisualStyleBackColor = true;
            // 
            // GroupSurnameRButton
            // 
            this.GroupSurnameRButton.AutoSize = true;
            this.GroupSurnameRButton.Checked = true;
            this.GroupSurnameRButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupSurnameRButton.ForeColor = System.Drawing.Color.White;
            this.GroupSurnameRButton.Location = new System.Drawing.Point(6, 14);
            this.GroupSurnameRButton.Name = "GroupSurnameRButton";
            this.GroupSurnameRButton.Size = new System.Drawing.Size(92, 24);
            this.GroupSurnameRButton.TabIndex = 0;
            this.GroupSurnameRButton.TabStop = true;
            this.GroupSurnameRButton.Text = "Surname";
            this.GroupSurnameRButton.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(876, 560);
            this.Controls.Add(this.ResearchButton);
            this.Controls.Add(this.GroupButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.AggregateTextBox);
            this.Controls.Add(this.AuthorButton);
            this.Controls.Add(this.AggregateButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TeacherGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.TeacherGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AuthorButton;
        private System.Windows.Forms.ToolTip MainMenuToolTip;
        private System.Windows.Forms.DataGridView TeacherGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FilterBirthYearRButton;
        private System.Windows.Forms.RadioButton FilterStandingRButton;
        private System.Windows.Forms.RadioButton FilterSalaryRButton;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton SortStandingRButton;
        private System.Windows.Forms.RadioButton SortAgeRButton;
        private System.Windows.Forms.RadioButton SortSalaryRButton;
        private System.Windows.Forms.Button AggregateButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton AggregateAverageAgeRButton;
        private System.Windows.Forms.RadioButton AggregateAverageStandingRButton;
        private System.Windows.Forms.RadioButton AggregateAverageSalaryRButton;
        private System.Windows.Forms.TextBox AggregateTextBox;
        private System.Windows.Forms.Button GroupButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton GroupTitleRButton;
        private System.Windows.Forms.RadioButton GroupCathedraRButton;
        private System.Windows.Forms.RadioButton GroupSurnameRButton;
        private System.Windows.Forms.Button ResearchButton;
    }
}


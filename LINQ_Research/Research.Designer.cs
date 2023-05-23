namespace LINQ_Research
{
    partial class Research
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Research));
            this.ResearchGridView = new System.Windows.Forms.DataGridView();
            this.ResearchButton = new System.Windows.Forms.Button();
            this.ResearchToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ResearchChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ResearchGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResearchChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ResearchGridView
            // 
            this.ResearchGridView.AllowUserToResizeColumns = false;
            this.ResearchGridView.AllowUserToResizeRows = false;
            this.ResearchGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ResearchGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResearchGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ResearchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResearchGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ResearchGridView.GridColor = System.Drawing.Color.White;
            this.ResearchGridView.Location = new System.Drawing.Point(12, 12);
            this.ResearchGridView.Name = "ResearchGridView";
            this.ResearchGridView.RowHeadersVisible = false;
            this.ResearchGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ResearchGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ResearchGridView.RowTemplate.Height = 24;
            this.ResearchGridView.Size = new System.Drawing.Size(220, 326);
            this.ResearchGridView.TabIndex = 2;
            this.ResearchToolTip.SetToolTip(this.ResearchGridView, "Values for research");
            // 
            // ResearchButton
            // 
            this.ResearchButton.BackColor = System.Drawing.Color.White;
            this.ResearchButton.FlatAppearance.BorderSize = 0;
            this.ResearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResearchButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResearchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ResearchButton.Location = new System.Drawing.Point(12, 344);
            this.ResearchButton.Name = "ResearchButton";
            this.ResearchButton.Size = new System.Drawing.Size(719, 58);
            this.ResearchButton.TabIndex = 8;
            this.ResearchButton.Text = "Research";
            this.ResearchToolTip.SetToolTip(this.ResearchButton, "Start research");
            this.ResearchButton.UseVisualStyleBackColor = false;
            this.ResearchButton.Click += new System.EventHandler(this.ResearchButton_Click);
            // 
            // ResearchChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ResearchChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ResearchChart.Legends.Add(legend1);
            this.ResearchChart.Location = new System.Drawing.Point(238, 12);
            this.ResearchChart.Name = "ResearchChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ResearchChart.Series.Add(series1);
            this.ResearchChart.Size = new System.Drawing.Size(493, 326);
            this.ResearchChart.TabIndex = 9;
            this.ResearchChart.Text = "chart1";
            this.ResearchToolTip.SetToolTip(this.ResearchChart, "Result Chart");
            // 
            // Research
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(744, 417);
            this.Controls.Add(this.ResearchChart);
            this.Controls.Add(this.ResearchButton);
            this.Controls.Add(this.ResearchGridView);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Research";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Research";
            ((System.ComponentModel.ISupportInitialize)(this.ResearchGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResearchChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ResearchGridView;
        private System.Windows.Forms.Button ResearchButton;
        private System.Windows.Forms.ToolTip ResearchToolTip;
        private System.Windows.Forms.DataVisualization.Charting.Chart ResearchChart;
    }
}
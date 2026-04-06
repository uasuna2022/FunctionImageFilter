namespace Project3_CustomFunctionImageFilter
{
    partial class MainWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            mainMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openImageToolStripMenuItem = new ToolStripMenuItem();
            saveImageToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            mainTableLayoutPanel = new TableLayoutPanel();
            manageTableLayoutPanel = new TableLayoutPanel();
            filtersGroupBox = new GroupBox();
            gammaCorrectionValueLabel = new Label();
            gammaCorrectionFilterTrackBar = new TrackBar();
            gammaCorrectionFilterRadioButton = new RadioButton();
            contrastValueLabel = new Label();
            contrastFilterTrackBar = new TrackBar();
            contrastFilterRadioButton = new RadioButton();
            brightnessValueLabel = new Label();
            brightnessFilterTrackBar = new TrackBar();
            brightnessFilterRadioButton = new RadioButton();
            customFunctionRadioButton = new RadioButton();
            negationFilterRadioButton = new RadioButton();
            noFilterRadioButton = new RadioButton();
            histogramGroupBox = new GroupBox();
            chartBlue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartGreen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartRed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            wayToApplyFilterGroupBox = new GroupBox();
            brushNumericUpDown = new NumericUpDown();
            brushRadioButton = new RadioButton();
            wholeImageRadioButton = new RadioButton();
            workingPanel = new Helpers.BufferedPanel();
            mainMenuStrip.SuspendLayout();
            mainTableLayoutPanel.SuspendLayout();
            manageTableLayoutPanel.SuspendLayout();
            filtersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gammaCorrectionFilterTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contrastFilterTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brightnessFilterTrackBar).BeginInit();
            histogramGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartRed).BeginInit();
            wayToApplyFilterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)brushNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.ImageScalingSize = new Size(20, 20);
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(1482, 28);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openImageToolStripMenuItem, saveImageToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openImageToolStripMenuItem
            // 
            openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            openImageToolStripMenuItem.Size = new Size(224, 26);
            openImageToolStripMenuItem.Text = "Open Image";
            openImageToolStripMenuItem.Click += openImageToolStripMenuItem_Click;
            // 
            // saveImageToolStripMenuItem
            // 
            saveImageToolStripMenuItem.Enabled = false;
            saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            saveImageToolStripMenuItem.Size = new Size(224, 26);
            saveImageToolStripMenuItem.Text = "Save Image";
            saveImageToolStripMenuItem.Click += saveImageToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 2;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            mainTableLayoutPanel.Controls.Add(manageTableLayoutPanel, 1, 0);
            mainTableLayoutPanel.Controls.Add(workingPanel, 0, 0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 28);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 1;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainTableLayoutPanel.Size = new Size(1482, 925);
            mainTableLayoutPanel.TabIndex = 1;
            // 
            // manageTableLayoutPanel
            // 
            manageTableLayoutPanel.ColumnCount = 1;
            manageTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            manageTableLayoutPanel.Controls.Add(filtersGroupBox, 0, 0);
            manageTableLayoutPanel.Controls.Add(histogramGroupBox, 0, 1);
            manageTableLayoutPanel.Controls.Add(wayToApplyFilterGroupBox, 0, 2);
            manageTableLayoutPanel.Dock = DockStyle.Fill;
            manageTableLayoutPanel.Location = new Point(966, 3);
            manageTableLayoutPanel.Name = "manageTableLayoutPanel";
            manageTableLayoutPanel.Padding = new Padding(3);
            manageTableLayoutPanel.RowCount = 4;
            manageTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            manageTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            manageTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            manageTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            manageTableLayoutPanel.Size = new Size(513, 919);
            manageTableLayoutPanel.TabIndex = 0;
            // 
            // filtersGroupBox
            // 
            filtersGroupBox.Controls.Add(gammaCorrectionValueLabel);
            filtersGroupBox.Controls.Add(gammaCorrectionFilterTrackBar);
            filtersGroupBox.Controls.Add(gammaCorrectionFilterRadioButton);
            filtersGroupBox.Controls.Add(contrastValueLabel);
            filtersGroupBox.Controls.Add(contrastFilterTrackBar);
            filtersGroupBox.Controls.Add(contrastFilterRadioButton);
            filtersGroupBox.Controls.Add(brightnessValueLabel);
            filtersGroupBox.Controls.Add(brightnessFilterTrackBar);
            filtersGroupBox.Controls.Add(brightnessFilterRadioButton);
            filtersGroupBox.Controls.Add(customFunctionRadioButton);
            filtersGroupBox.Controls.Add(negationFilterRadioButton);
            filtersGroupBox.Controls.Add(noFilterRadioButton);
            filtersGroupBox.Dock = DockStyle.Fill;
            filtersGroupBox.Location = new Point(6, 6);
            filtersGroupBox.Name = "filtersGroupBox";
            filtersGroupBox.Size = new Size(501, 222);
            filtersGroupBox.TabIndex = 0;
            filtersGroupBox.TabStop = false;
            filtersGroupBox.Text = "Filters";
            // 
            // gammaCorrectionValueLabel
            // 
            gammaCorrectionValueLabel.AutoSize = true;
            gammaCorrectionValueLabel.Location = new Point(460, 154);
            gammaCorrectionValueLabel.Name = "gammaCorrectionValueLabel";
            gammaCorrectionValueLabel.Size = new Size(28, 20);
            gammaCorrectionValueLabel.TabIndex = 11;
            gammaCorrectionValueLabel.Text = "1.0";
            // 
            // gammaCorrectionFilterTrackBar
            // 
            gammaCorrectionFilterTrackBar.Enabled = false;
            gammaCorrectionFilterTrackBar.Location = new Point(127, 154);
            gammaCorrectionFilterTrackBar.Maximum = 50;
            gammaCorrectionFilterTrackBar.Minimum = 1;
            gammaCorrectionFilterTrackBar.Name = "gammaCorrectionFilterTrackBar";
            gammaCorrectionFilterTrackBar.Size = new Size(333, 56);
            gammaCorrectionFilterTrackBar.TabIndex = 10;
            gammaCorrectionFilterTrackBar.Value = 10;
            gammaCorrectionFilterTrackBar.Scroll += gammaCorrectionFilterTrackBar_Scroll;
            // 
            // gammaCorrectionFilterRadioButton
            // 
            gammaCorrectionFilterRadioButton.AutoSize = true;
            gammaCorrectionFilterRadioButton.Enabled = false;
            gammaCorrectionFilterRadioButton.Location = new Point(19, 154);
            gammaCorrectionFilterRadioButton.Name = "gammaCorrectionFilterRadioButton";
            gammaCorrectionFilterRadioButton.Size = new Size(86, 24);
            gammaCorrectionFilterRadioButton.TabIndex = 9;
            gammaCorrectionFilterRadioButton.Text = "Gamma ";
            gammaCorrectionFilterRadioButton.UseVisualStyleBackColor = true;
            gammaCorrectionFilterRadioButton.CheckedChanged += gammaCorrectionFilterRadioButton_CheckedChanged;
            // 
            // contrastValueLabel
            // 
            contrastValueLabel.AutoSize = true;
            contrastValueLabel.Location = new Point(460, 111);
            contrastValueLabel.Name = "contrastValueLabel";
            contrastValueLabel.Size = new Size(17, 20);
            contrastValueLabel.TabIndex = 8;
            contrastValueLabel.Text = "0";
            // 
            // contrastFilterTrackBar
            // 
            contrastFilterTrackBar.Enabled = false;
            contrastFilterTrackBar.Location = new Point(127, 111);
            contrastFilterTrackBar.Maximum = 127;
            contrastFilterTrackBar.Minimum = -127;
            contrastFilterTrackBar.Name = "contrastFilterTrackBar";
            contrastFilterTrackBar.Size = new Size(333, 56);
            contrastFilterTrackBar.TabIndex = 7;
            contrastFilterTrackBar.Scroll += contrastFilterTrackBar_Scroll;
            // 
            // contrastFilterRadioButton
            // 
            contrastFilterRadioButton.AutoSize = true;
            contrastFilterRadioButton.Enabled = false;
            contrastFilterRadioButton.Location = new Point(19, 111);
            contrastFilterRadioButton.Name = "contrastFilterRadioButton";
            contrastFilterRadioButton.Size = new Size(85, 24);
            contrastFilterRadioButton.TabIndex = 6;
            contrastFilterRadioButton.Text = "Contrast";
            contrastFilterRadioButton.UseVisualStyleBackColor = true;
            contrastFilterRadioButton.CheckedChanged += contrastFilterRadioButton_CheckedChanged;
            // 
            // brightnessValueLabel
            // 
            brightnessValueLabel.AutoSize = true;
            brightnessValueLabel.Location = new Point(460, 69);
            brightnessValueLabel.Name = "brightnessValueLabel";
            brightnessValueLabel.Size = new Size(17, 20);
            brightnessValueLabel.TabIndex = 5;
            brightnessValueLabel.Text = "0";
            // 
            // brightnessFilterTrackBar
            // 
            brightnessFilterTrackBar.Enabled = false;
            brightnessFilterTrackBar.Location = new Point(127, 67);
            brightnessFilterTrackBar.Maximum = 230;
            brightnessFilterTrackBar.Minimum = -230;
            brightnessFilterTrackBar.Name = "brightnessFilterTrackBar";
            brightnessFilterTrackBar.Size = new Size(333, 56);
            brightnessFilterTrackBar.TabIndex = 4;
            brightnessFilterTrackBar.Scroll += brightnessFilterTrackBar_Scroll;
            // 
            // brightnessFilterRadioButton
            // 
            brightnessFilterRadioButton.AutoSize = true;
            brightnessFilterRadioButton.Enabled = false;
            brightnessFilterRadioButton.Location = new Point(19, 67);
            brightnessFilterRadioButton.Name = "brightnessFilterRadioButton";
            brightnessFilterRadioButton.Size = new Size(102, 24);
            brightnessFilterRadioButton.TabIndex = 3;
            brightnessFilterRadioButton.Text = "Brightness ";
            brightnessFilterRadioButton.UseVisualStyleBackColor = true;
            brightnessFilterRadioButton.CheckedChanged += brightnessFilterRadioButton_CheckedChanged;
            // 
            // customFunctionRadioButton
            // 
            customFunctionRadioButton.AutoSize = true;
            customFunctionRadioButton.Enabled = false;
            customFunctionRadioButton.Location = new Point(348, 26);
            customFunctionRadioButton.Name = "customFunctionRadioButton";
            customFunctionRadioButton.Size = new Size(140, 24);
            customFunctionRadioButton.TabIndex = 2;
            customFunctionRadioButton.Text = "Custom Function";
            customFunctionRadioButton.UseVisualStyleBackColor = true;
            customFunctionRadioButton.CheckedChanged += customFunctionRadioButton_CheckedChanged;
            // 
            // negationFilterRadioButton
            // 
            negationFilterRadioButton.AutoSize = true;
            negationFilterRadioButton.Enabled = false;
            negationFilterRadioButton.Location = new Point(188, 26);
            negationFilterRadioButton.Name = "negationFilterRadioButton";
            negationFilterRadioButton.Size = new Size(92, 24);
            negationFilterRadioButton.TabIndex = 1;
            negationFilterRadioButton.Text = "Negation";
            negationFilterRadioButton.UseVisualStyleBackColor = true;
            negationFilterRadioButton.CheckedChanged += negationFilterRadioButton_CheckedChanged;
            // 
            // noFilterRadioButton
            // 
            noFilterRadioButton.AutoSize = true;
            noFilterRadioButton.Checked = true;
            noFilterRadioButton.Enabled = false;
            noFilterRadioButton.Location = new Point(19, 26);
            noFilterRadioButton.Name = "noFilterRadioButton";
            noFilterRadioButton.Size = new Size(87, 24);
            noFilterRadioButton.TabIndex = 0;
            noFilterRadioButton.TabStop = true;
            noFilterRadioButton.Text = "No Filter";
            noFilterRadioButton.UseVisualStyleBackColor = true;
            noFilterRadioButton.CheckedChanged += noFilterRadioButton_CheckedChanged;
            // 
            // histogramGroupBox
            // 
            histogramGroupBox.Controls.Add(chartBlue);
            histogramGroupBox.Controls.Add(chartGreen);
            histogramGroupBox.Controls.Add(chartRed);
            histogramGroupBox.Dock = DockStyle.Fill;
            histogramGroupBox.Location = new Point(6, 234);
            histogramGroupBox.Name = "histogramGroupBox";
            histogramGroupBox.Size = new Size(501, 541);
            histogramGroupBox.TabIndex = 1;
            histogramGroupBox.TabStop = false;
            histogramGroupBox.Text = "Color Histograms";
            // 
            // chartBlue
            // 
            chartArea1.Name = "ChartArea1";
            chartBlue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartBlue.Legends.Add(legend1);
            chartBlue.Location = new Point(6, 362);
            chartBlue.Name = "chartBlue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartBlue.Series.Add(series1);
            chartBlue.Size = new Size(489, 163);
            chartBlue.TabIndex = 2;
            chartBlue.Text = "chart1";
            // 
            // chartGreen
            // 
            chartArea2.Name = "ChartArea1";
            chartGreen.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartGreen.Legends.Add(legend2);
            chartGreen.Location = new Point(6, 194);
            chartGreen.Name = "chartGreen";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartGreen.Series.Add(series2);
            chartGreen.Size = new Size(489, 162);
            chartGreen.TabIndex = 1;
            chartGreen.Text = "chart1";
            // 
            // chartRed
            // 
            chartArea3.Name = "ChartArea1";
            chartRed.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartRed.Legends.Add(legend3);
            chartRed.Location = new Point(6, 26);
            chartRed.Name = "chartRed";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartRed.Series.Add(series3);
            chartRed.Size = new Size(489, 162);
            chartRed.TabIndex = 0;
            chartRed.Text = "chart1";
            // 
            // wayToApplyFilterGroupBox
            // 
            wayToApplyFilterGroupBox.Controls.Add(brushNumericUpDown);
            wayToApplyFilterGroupBox.Controls.Add(brushRadioButton);
            wayToApplyFilterGroupBox.Controls.Add(wholeImageRadioButton);
            wayToApplyFilterGroupBox.Dock = DockStyle.Fill;
            wayToApplyFilterGroupBox.Location = new Point(6, 781);
            wayToApplyFilterGroupBox.Name = "wayToApplyFilterGroupBox";
            wayToApplyFilterGroupBox.Padding = new Padding(0);
            wayToApplyFilterGroupBox.Size = new Size(501, 67);
            wayToApplyFilterGroupBox.TabIndex = 2;
            wayToApplyFilterGroupBox.TabStop = false;
            wayToApplyFilterGroupBox.Text = "Choose a way to apply a filter";
            // 
            // brushNumericUpDown
            // 
            brushNumericUpDown.Enabled = false;
            brushNumericUpDown.Location = new Point(382, 40);
            brushNumericUpDown.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            brushNumericUpDown.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            brushNumericUpDown.Name = "brushNumericUpDown";
            brushNumericUpDown.Size = new Size(55, 27);
            brushNumericUpDown.TabIndex = 2;
            brushNumericUpDown.Value = new decimal(new int[] { 20, 0, 0, 0 });
            brushNumericUpDown.ValueChanged += brushNumericUpDown_ValueChanged;
            // 
            // brushRadioButton
            // 
            brushRadioButton.AutoSize = true;
            brushRadioButton.Enabled = false;
            brushRadioButton.Location = new Point(269, 40);
            brushRadioButton.Name = "brushRadioButton";
            brushRadioButton.Size = new Size(107, 24);
            brushRadioButton.TabIndex = 1;
            brushRadioButton.Text = "Circle Brush";
            brushRadioButton.UseVisualStyleBackColor = true;
            brushRadioButton.CheckedChanged += brushRadioButton_CheckedChanged;
            // 
            // wholeImageRadioButton
            // 
            wholeImageRadioButton.AutoSize = true;
            wholeImageRadioButton.Checked = true;
            wholeImageRadioButton.Enabled = false;
            wholeImageRadioButton.Location = new Point(30, 40);
            wholeImageRadioButton.Name = "wholeImageRadioButton";
            wholeImageRadioButton.Size = new Size(119, 24);
            wholeImageRadioButton.TabIndex = 0;
            wholeImageRadioButton.TabStop = true;
            wholeImageRadioButton.Text = "Whole Image";
            wholeImageRadioButton.UseVisualStyleBackColor = true;
            wholeImageRadioButton.CheckedChanged += wholeImageRadioButton_CheckedChanged;
            // 
            // workingPanel
            // 
            workingPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            workingPanel.BackColor = SystemColors.ControlLight;
            workingPanel.Location = new Point(3, 3);
            workingPanel.Name = "workingPanel";
            workingPanel.Size = new Size(957, 919);
            workingPanel.TabIndex = 1;
            workingPanel.Paint += workingPanel_Paint;
            workingPanel.MouseDown += workingPanel_MouseDown;
            workingPanel.MouseLeave += workingPanel_MouseLeave;
            workingPanel.MouseMove += workingPanel_MouseMove;
            workingPanel.MouseUp += workingPanel_MouseUp;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 953);
            Controls.Add(mainTableLayoutPanel);
            Controls.Add(mainMenuStrip);
            MainMenuStrip = mainMenuStrip;
            MaximizeBox = false;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image Filter";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            mainTableLayoutPanel.ResumeLayout(false);
            manageTableLayoutPanel.ResumeLayout(false);
            filtersGroupBox.ResumeLayout(false);
            filtersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gammaCorrectionFilterTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)contrastFilterTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)brightnessFilterTrackBar).EndInit();
            histogramGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartRed).EndInit();
            wayToApplyFilterGroupBox.ResumeLayout(false);
            wayToApplyFilterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)brushNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveImageToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TableLayoutPanel mainTableLayoutPanel;
        private TableLayoutPanel manageTableLayoutPanel;
        private GroupBox filtersGroupBox;
        private RadioButton negationFilterRadioButton;
        private RadioButton noFilterRadioButton;
        private TrackBar brightnessFilterTrackBar;
        private RadioButton brightnessFilterRadioButton;
        private RadioButton customFunctionRadioButton;
        private Label brightnessValueLabel;
        private RadioButton contrastFilterRadioButton;
        private Label contrastValueLabel;
        private TrackBar contrastFilterTrackBar;
        private RadioButton gammaCorrectionFilterRadioButton;
        private Label gammaCorrectionValueLabel;
        private TrackBar gammaCorrectionFilterTrackBar;
        private ToolStripMenuItem openImageToolStripMenuItem;
        private Helpers.BufferedPanel workingPanel;
        private GroupBox histogramGroupBox;
        private GroupBox wayToApplyFilterGroupBox;
        private RadioButton brushRadioButton;
        private RadioButton wholeImageRadioButton;
        private NumericUpDown brushNumericUpDown;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBlue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGreen;
    }
}

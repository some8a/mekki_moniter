namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonStart = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDownMeasCount1 = new System.Windows.Forms.NumericUpDown();
            this.labelMeasCount1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelMeasCount2 = new System.Windows.Forms.Label();
            this.numericUpDownMeasCount2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMeasInt1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMeasInt2 = new System.Windows.Forms.NumericUpDown();
            this.labelMeasInt1 = new System.Windows.Forms.Label();
            this.labelMeasInt2 = new System.Windows.Forms.Label();
            this.labelVoltStep = new System.Windows.Forms.Label();
            this.numericUpDownVoltStep = new System.Windows.Forms.NumericUpDown();
            this.labelStartVolt = new System.Windows.Forms.Label();
            this.numericUpDownStartVolt = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinVolt = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxVolt = new System.Windows.Forms.NumericUpDown();
            this.labelMinVolt = new System.Windows.Forms.Label();
            this.labelMaxVolt = new System.Windows.Forms.Label();
            this.groupBoxPotentio = new System.Windows.Forms.GroupBox();
            this.groupBoxVoltamm = new System.Windows.Forms.GroupBox();
            this.labelRange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMeasCount1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMeasCount2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMeasInt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMeasInt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVoltStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartVolt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinVolt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxVolt)).BeginInit();
            this.groupBoxPotentio.SuspendLayout();
            this.groupBoxVoltamm.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(250, 75);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 174);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(250, 383);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(268, 174);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(454, 383);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonStop.Location = new System.Drawing.Point(12, 93);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(250, 75);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numericUpDownMeasCount1
            // 
            this.numericUpDownMeasCount1.Location = new System.Drawing.Point(123, 18);
            this.numericUpDownMeasCount1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownMeasCount1.Name = "numericUpDownMeasCount1";
            this.numericUpDownMeasCount1.Size = new System.Drawing.Size(78, 19);
            this.numericUpDownMeasCount1.TabIndex = 4;
            this.numericUpDownMeasCount1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // labelMeasCount1
            // 
            this.labelMeasCount1.AutoSize = true;
            this.labelMeasCount1.Location = new System.Drawing.Point(7, 20);
            this.labelMeasCount1.Name = "labelMeasCount1";
            this.labelMeasCount1.Size = new System.Drawing.Size(80, 12);
            this.labelMeasCount1.TabIndex = 5;
            this.labelMeasCount1.Text = "Measure count";
            // 
            // timer2
            // 
            this.timer2.Interval = 2;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labelMeasCount2
            // 
            this.labelMeasCount2.AutoSize = true;
            this.labelMeasCount2.Location = new System.Drawing.Point(6, 20);
            this.labelMeasCount2.Name = "labelMeasCount2";
            this.labelMeasCount2.Size = new System.Drawing.Size(80, 12);
            this.labelMeasCount2.TabIndex = 6;
            this.labelMeasCount2.Text = "Measure count";
            // 
            // numericUpDownMeasCount2
            // 
            this.numericUpDownMeasCount2.Location = new System.Drawing.Point(123, 18);
            this.numericUpDownMeasCount2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownMeasCount2.Name = "numericUpDownMeasCount2";
            this.numericUpDownMeasCount2.Size = new System.Drawing.Size(78, 19);
            this.numericUpDownMeasCount2.TabIndex = 7;
            this.numericUpDownMeasCount2.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // numericUpDownMeasInt1
            // 
            this.numericUpDownMeasInt1.DecimalPlaces = 1;
            this.numericUpDownMeasInt1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownMeasInt1.Location = new System.Drawing.Point(370, 18);
            this.numericUpDownMeasInt1.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDownMeasInt1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownMeasInt1.Name = "numericUpDownMeasInt1";
            this.numericUpDownMeasInt1.Size = new System.Drawing.Size(78, 19);
            this.numericUpDownMeasInt1.TabIndex = 8;
            this.numericUpDownMeasInt1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMeasInt2
            // 
            this.numericUpDownMeasInt2.DecimalPlaces = 1;
            this.numericUpDownMeasInt2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownMeasInt2.Location = new System.Drawing.Point(370, 18);
            this.numericUpDownMeasInt2.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDownMeasInt2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownMeasInt2.Name = "numericUpDownMeasInt2";
            this.numericUpDownMeasInt2.Size = new System.Drawing.Size(78, 19);
            this.numericUpDownMeasInt2.TabIndex = 9;
            this.numericUpDownMeasInt2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelMeasInt1
            // 
            this.labelMeasInt1.AutoSize = true;
            this.labelMeasInt1.Location = new System.Drawing.Point(241, 20);
            this.labelMeasInt1.Name = "labelMeasInt1";
            this.labelMeasInt1.Size = new System.Drawing.Size(112, 12);
            this.labelMeasInt1.TabIndex = 10;
            this.labelMeasInt1.Text = "Measure interval  (s)";
            // 
            // labelMeasInt2
            // 
            this.labelMeasInt2.AutoSize = true;
            this.labelMeasInt2.Location = new System.Drawing.Point(240, 20);
            this.labelMeasInt2.Name = "labelMeasInt2";
            this.labelMeasInt2.Size = new System.Drawing.Size(112, 12);
            this.labelMeasInt2.TabIndex = 11;
            this.labelMeasInt2.Text = "Measure interval  (s)";
            // 
            // labelVoltStep
            // 
            this.labelVoltStep.AutoSize = true;
            this.labelVoltStep.Location = new System.Drawing.Point(241, 46);
            this.labelVoltStep.Name = "labelVoltStep";
            this.labelVoltStep.Size = new System.Drawing.Size(90, 12);
            this.labelVoltStep.TabIndex = 12;
            this.labelVoltStep.Text = "Voltage step (V)";
            // 
            // numericUpDownVoltStep
            // 
            this.numericUpDownVoltStep.DecimalPlaces = 3;
            this.numericUpDownVoltStep.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownVoltStep.Location = new System.Drawing.Point(370, 43);
            this.numericUpDownVoltStep.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownVoltStep.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownVoltStep.Name = "numericUpDownVoltStep";
            this.numericUpDownVoltStep.Size = new System.Drawing.Size(78, 19);
            this.numericUpDownVoltStep.TabIndex = 13;
            this.numericUpDownVoltStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // labelStartVolt
            // 
            this.labelStartVolt.AutoSize = true;
            this.labelStartVolt.Location = new System.Drawing.Point(7, 45);
            this.labelStartVolt.Name = "labelStartVolt";
            this.labelStartVolt.Size = new System.Drawing.Size(91, 12);
            this.labelStartVolt.TabIndex = 14;
            this.labelStartVolt.Text = "Start voltage (V)";
            // 
            // numericUpDownStartVolt
            // 
            this.numericUpDownStartVolt.DecimalPlaces = 3;
            this.numericUpDownStartVolt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownStartVolt.Location = new System.Drawing.Point(123, 43);
            this.numericUpDownStartVolt.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownStartVolt.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownStartVolt.Name = "numericUpDownStartVolt";
            this.numericUpDownStartVolt.Size = new System.Drawing.Size(78, 19);
            this.numericUpDownStartVolt.TabIndex = 15;
            // 
            // numericUpDownMinVolt
            // 
            this.numericUpDownMinVolt.DecimalPlaces = 3;
            this.numericUpDownMinVolt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownMinVolt.Location = new System.Drawing.Point(123, 68);
            this.numericUpDownMinVolt.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMinVolt.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownMinVolt.Name = "numericUpDownMinVolt";
            this.numericUpDownMinVolt.Size = new System.Drawing.Size(78, 19);
            this.numericUpDownMinVolt.TabIndex = 16;
            this.numericUpDownMinVolt.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownMinVolt.ValueChanged += new System.EventHandler(this.maxOfMin);
            // 
            // numericUpDownMaxVolt
            // 
            this.numericUpDownMaxVolt.DecimalPlaces = 3;
            this.numericUpDownMaxVolt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownMaxVolt.Location = new System.Drawing.Point(370, 68);
            this.numericUpDownMaxVolt.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMaxVolt.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownMaxVolt.Name = "numericUpDownMaxVolt";
            this.numericUpDownMaxVolt.Size = new System.Drawing.Size(78, 19);
            this.numericUpDownMaxVolt.TabIndex = 17;
            this.numericUpDownMaxVolt.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMaxVolt.ValueChanged += new System.EventHandler(this.minOfMax);
            // 
            // labelMinVolt
            // 
            this.labelMinVolt.AutoSize = true;
            this.labelMinVolt.Location = new System.Drawing.Point(6, 70);
            this.labelMinVolt.Name = "labelMinVolt";
            this.labelMinVolt.Size = new System.Drawing.Size(66, 12);
            this.labelMinVolt.TabIndex = 18;
            this.labelMinVolt.Text = "Min volt (V)";
            // 
            // labelMaxVolt
            // 
            this.labelMaxVolt.AutoSize = true;
            this.labelMaxVolt.Location = new System.Drawing.Point(241, 70);
            this.labelMaxVolt.Name = "labelMaxVolt";
            this.labelMaxVolt.Size = new System.Drawing.Size(69, 12);
            this.labelMaxVolt.TabIndex = 19;
            this.labelMaxVolt.Text = "Max volt (V)";
            // 
            // groupBoxPotentio
            // 
            this.groupBoxPotentio.Controls.Add(this.labelMeasInt2);
            this.groupBoxPotentio.Controls.Add(this.labelVoltStep);
            this.groupBoxPotentio.Controls.Add(this.numericUpDownVoltStep);
            this.groupBoxPotentio.Controls.Add(this.numericUpDownMeasInt2);
            this.groupBoxPotentio.Controls.Add(this.numericUpDownMeasCount2);
            this.groupBoxPotentio.Controls.Add(this.labelMaxVolt);
            this.groupBoxPotentio.Controls.Add(this.labelMeasCount2);
            this.groupBoxPotentio.Controls.Add(this.numericUpDownMinVolt);
            this.groupBoxPotentio.Controls.Add(this.numericUpDownMaxVolt);
            this.groupBoxPotentio.Controls.Add(this.labelMinVolt);
            this.groupBoxPotentio.Controls.Add(this.numericUpDownStartVolt);
            this.groupBoxPotentio.Controls.Add(this.labelStartVolt);
            this.groupBoxPotentio.Location = new System.Drawing.Point(268, 66);
            this.groupBoxPotentio.Name = "groupBoxPotentio";
            this.groupBoxPotentio.Size = new System.Drawing.Size(454, 102);
            this.groupBoxPotentio.TabIndex = 20;
            this.groupBoxPotentio.TabStop = false;
            this.groupBoxPotentio.Text = "Potentiostat";
            // 
            // groupBoxVoltamm
            // 
            this.groupBoxVoltamm.Controls.Add(this.numericUpDownMeasInt1);
            this.groupBoxVoltamm.Controls.Add(this.labelMeasInt1);
            this.groupBoxVoltamm.Controls.Add(this.labelMeasCount1);
            this.groupBoxVoltamm.Controls.Add(this.numericUpDownMeasCount1);
            this.groupBoxVoltamm.Location = new System.Drawing.Point(268, 12);
            this.groupBoxVoltamm.Name = "groupBoxVoltamm";
            this.groupBoxVoltamm.Size = new System.Drawing.Size(454, 47);
            this.groupBoxVoltamm.TabIndex = 21;
            this.groupBoxVoltamm.TabStop = false;
            this.groupBoxVoltamm.Text = "Voltammetry";
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.BackColor = System.Drawing.SystemColors.Window;
            this.labelRange.Location = new System.Drawing.Point(705, 177);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(11, 12);
            this.labelRange.TabIndex = 22;
            this.labelRange.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 565);
            this.Controls.Add(this.labelRange);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBoxPotentio);
            this.Controls.Add(this.groupBoxVoltamm);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMeasCount1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMeasCount2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMeasInt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMeasInt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVoltStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartVolt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinVolt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxVolt)).EndInit();
            this.groupBoxPotentio.ResumeLayout(false);
            this.groupBoxPotentio.PerformLayout();
            this.groupBoxVoltamm.ResumeLayout(false);
            this.groupBoxVoltamm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericUpDownMeasCount1;
        private System.Windows.Forms.Label labelMeasCount1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelMeasCount2;
        private System.Windows.Forms.NumericUpDown numericUpDownMeasCount2;
        private System.Windows.Forms.NumericUpDown numericUpDownMeasInt1;
        private System.Windows.Forms.NumericUpDown numericUpDownMeasInt2;
        private System.Windows.Forms.Label labelMeasInt1;
        private System.Windows.Forms.Label labelMeasInt2;
        private System.Windows.Forms.Label labelVoltStep;
        private System.Windows.Forms.NumericUpDown numericUpDownVoltStep;
        private System.Windows.Forms.Label labelStartVolt;
        private System.Windows.Forms.NumericUpDown numericUpDownStartVolt;
        private System.Windows.Forms.NumericUpDown numericUpDownMinVolt;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxVolt;
        private System.Windows.Forms.Label labelMinVolt;
        private System.Windows.Forms.Label labelMaxVolt;
        private System.Windows.Forms.GroupBox groupBoxPotentio;
        private System.Windows.Forms.GroupBox groupBoxVoltamm;
        private System.Windows.Forms.Label labelRange;
    }
}


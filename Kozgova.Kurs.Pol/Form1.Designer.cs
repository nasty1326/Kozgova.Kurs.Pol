
namespace Kozgova.Kurs.Pol
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button2 = new System.Windows.Forms.Button();
            this.numOutMut = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numOutCross = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numOutTurn = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numOutPop = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numOutGen = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.lbmin = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbPok = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btStartExp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOutMut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutCross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutPop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(92, 254);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 78);
            this.button2.TabIndex = 24;
            this.button2.Text = "Старт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numOutMut
            // 
            this.numOutMut.DecimalPlaces = 2;
            this.numOutMut.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numOutMut.Location = new System.Drawing.Point(211, 190);
            this.numOutMut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numOutMut.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOutMut.Name = "numOutMut";
            this.numOutMut.Size = new System.Drawing.Size(85, 22);
            this.numOutMut.TabIndex = 34;
            this.numOutMut.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Число поколений";
            // 
            // numOutCross
            // 
            this.numOutCross.DecimalPlaces = 2;
            this.numOutCross.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numOutCross.Location = new System.Drawing.Point(211, 149);
            this.numOutCross.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numOutCross.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOutCross.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numOutCross.Name = "numOutCross";
            this.numOutCross.Size = new System.Drawing.Size(85, 22);
            this.numOutCross.TabIndex = 33;
            this.numOutCross.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Размер популяции";
            // 
            // numOutTurn
            // 
            this.numOutTurn.Location = new System.Drawing.Point(211, 110);
            this.numOutTurn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numOutTurn.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numOutTurn.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numOutTurn.Name = "numOutTurn";
            this.numOutTurn.Size = new System.Drawing.Size(85, 22);
            this.numOutTurn.TabIndex = 32;
            this.numOutTurn.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Размер турнира";
            // 
            // numOutPop
            // 
            this.numOutPop.Location = new System.Drawing.Point(211, 69);
            this.numOutPop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numOutPop.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numOutPop.Name = "numOutPop";
            this.numOutPop.Size = new System.Drawing.Size(85, 22);
            this.numOutPop.TabIndex = 31;
            this.numOutPop.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Вероятность скрещивания";
            // 
            // numOutGen
            // 
            this.numOutGen.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numOutGen.Location = new System.Drawing.Point(211, 28);
            this.numOutGen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numOutGen.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numOutGen.Name = "numOutGen";
            this.numOutGen.Size = new System.Drawing.Size(85, 22);
            this.numOutGen.TabIndex = 30;
            this.numOutGen.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Вероятность мутации";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(361, 30);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Lime;
            series1.Legend = "Legend1";
            series1.LegendText = "Min в поколении";
            series1.Name = "Series1";
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.DarkOrange;
            series2.Legend = "Legend1";
            series2.LegendText = "Среднее в поколении";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(887, 300);
            this.chart1.TabIndex = 35;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Минимальное найденное решение";
            // 
            // lbmin
            // 
            this.lbmin.AutoSize = true;
            this.lbmin.Location = new System.Drawing.Point(298, 368);
            this.lbmin.Name = "lbmin";
            this.lbmin.Size = new System.Drawing.Size(14, 16);
            this.lbmin.TabIndex = 49;
            this.lbmin.Text = "0";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(364, 364);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(846, 324);
            this.chart2.TabIndex = 56;
            this.chart2.Text = "chart2";
            // 
            // lbPok
            // 
            this.lbPok.AutoSize = true;
            this.lbPok.Location = new System.Drawing.Point(141, 408);
            this.lbPok.Name = "lbPok";
            this.lbPok.Size = new System.Drawing.Size(14, 16);
            this.lbPok.TabIndex = 55;
            this.lbPok.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "Поколение";
            // 
            // btStartExp
            // 
            this.btStartExp.Location = new System.Drawing.Point(60, 491);
            this.btStartExp.Margin = new System.Windows.Forms.Padding(4);
            this.btStartExp.Name = "btStartExp";
            this.btStartExp.Size = new System.Drawing.Size(263, 80);
            this.btStartExp.TabIndex = 53;
            this.btStartExp.Text = "Начать эксперемент";
            this.btStartExp.UseVisualStyleBackColor = true;
            this.btStartExp.Click += new System.EventHandler(this.btStartExp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 699);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.lbPok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btStartExp);
            this.Controls.Add(this.lbmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numOutMut);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numOutCross);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numOutTurn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numOutPop);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numOutGen);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numOutMut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutCross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutPop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numOutMut;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numOutCross;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numOutTurn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numOutPop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numOutGen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbmin;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label lbPok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btStartExp;
    }
}


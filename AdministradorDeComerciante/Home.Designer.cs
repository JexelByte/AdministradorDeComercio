namespace AdministradorDeComerciante
{
    partial class Home
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PrecioDolar = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Seguro = new CircularProgressBar.CircularProgressBar();
            this.Volatil = new CircularProgressBar.CircularProgressBar();
            this.Ganancias = new CircularProgressBar.CircularProgressBar();
            this.Capital = new CircularProgressBar.CircularProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.PrecioDolar);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 788);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ventas a lo largo del tiempo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 39);
            this.label5.TabIndex = 3;
            this.label5.Text = "Precio Dollar$:";
            // 
            // PrecioDolar
            // 
            this.PrecioDolar.AutoSize = true;
            this.PrecioDolar.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioDolar.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.PrecioDolar.Location = new System.Drawing.Point(50, 498);
            this.PrecioDolar.Name = "PrecioDolar";
            this.PrecioDolar.Size = new System.Drawing.Size(112, 58);
            this.PrecioDolar.TabIndex = 3;
            this.PrecioDolar.Text = "0 Bs";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(27)))));
            this.chart1.BorderlineWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Wheat;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 49);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.DarkViolet;
            series1.Legend = "Legend1";
            series1.Name = "ChartData";
            series1.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(630, 380);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(20)))), ((int)(((byte)(37)))));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Seguro);
            this.groupBox1.Controls.Add(this.Volatil);
            this.groupBox1.Controls.Add(this.Ganancias);
            this.groupBox1.Controls.Add(this.Capital);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(675, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 832);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadisticas de la capital";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 779);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Monto en $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 581);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Monto en Bs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "capital";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ganancias Estimada";
            // 
            // Seguro
            // 
            this.Seguro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Seguro.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Seguro.AnimationSpeed = 0;
            this.Seguro.BackColor = System.Drawing.Color.Transparent;
            this.Seguro.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seguro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.Seguro.InnerColor = System.Drawing.Color.White;
            this.Seguro.InnerMargin = 4;
            this.Seguro.InnerWidth = -1;
            this.Seguro.Location = new System.Drawing.Point(10, 616);
            this.Seguro.MarqueeAnimationSpeed = 0;
            this.Seguro.Name = "Seguro";
            this.Seguro.OuterColor = System.Drawing.Color.Transparent;
            this.Seguro.OuterMargin = 0;
            this.Seguro.OuterWidth = 0;
            this.Seguro.ProgressColor = System.Drawing.Color.SeaGreen;
            this.Seguro.ProgressWidth = 40;
            this.Seguro.SecondaryFont = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seguro.Size = new System.Drawing.Size(160, 160);
            this.Seguro.StartAngle = 0;
            this.Seguro.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.Seguro.SubscriptColor = System.Drawing.Color.Gray;
            this.Seguro.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Seguro.SubscriptText = "%";
            this.Seguro.SuperscriptColor = System.Drawing.Color.Gray;
            this.Seguro.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Seguro.SuperscriptText = "";
            this.Seguro.TabIndex = 0;
            this.Seguro.Text = "0";
            this.Seguro.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Seguro.Value = 1;
            // 
            // Volatil
            // 
            this.Volatil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Volatil.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Volatil.AnimationSpeed = 0;
            this.Volatil.BackColor = System.Drawing.Color.Transparent;
            this.Volatil.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volatil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.Volatil.InnerColor = System.Drawing.Color.White;
            this.Volatil.InnerMargin = 4;
            this.Volatil.InnerWidth = -1;
            this.Volatil.Location = new System.Drawing.Point(10, 418);
            this.Volatil.MarqueeAnimationSpeed = 0;
            this.Volatil.Name = "Volatil";
            this.Volatil.OuterColor = System.Drawing.Color.Transparent;
            this.Volatil.OuterMargin = 0;
            this.Volatil.OuterWidth = 0;
            this.Volatil.ProgressColor = System.Drawing.Color.Yellow;
            this.Volatil.ProgressWidth = 40;
            this.Volatil.SecondaryFont = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volatil.Size = new System.Drawing.Size(160, 160);
            this.Volatil.StartAngle = 0;
            this.Volatil.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.Volatil.SubscriptColor = System.Drawing.Color.Gray;
            this.Volatil.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Volatil.SubscriptText = "%";
            this.Volatil.SuperscriptColor = System.Drawing.Color.Gray;
            this.Volatil.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Volatil.SuperscriptText = "";
            this.Volatil.TabIndex = 0;
            this.Volatil.Text = "0";
            this.Volatil.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Volatil.Value = 1;
            // 
            // Ganancias
            // 
            this.Ganancias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ganancias.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Ganancias.AnimationSpeed = 0;
            this.Ganancias.BackColor = System.Drawing.Color.Transparent;
            this.Ganancias.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ganancias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.Ganancias.InnerColor = System.Drawing.Color.White;
            this.Ganancias.InnerMargin = 4;
            this.Ganancias.InnerWidth = -1;
            this.Ganancias.Location = new System.Drawing.Point(10, 223);
            this.Ganancias.MarqueeAnimationSpeed = 0;
            this.Ganancias.Name = "Ganancias";
            this.Ganancias.OuterColor = System.Drawing.Color.Transparent;
            this.Ganancias.OuterMargin = 0;
            this.Ganancias.OuterWidth = 0;
            this.Ganancias.ProgressColor = System.Drawing.Color.Cyan;
            this.Ganancias.ProgressWidth = 40;
            this.Ganancias.SecondaryFont = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ganancias.Size = new System.Drawing.Size(160, 160);
            this.Ganancias.StartAngle = 0;
            this.Ganancias.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.Ganancias.SubscriptColor = System.Drawing.Color.Gray;
            this.Ganancias.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Ganancias.SubscriptText = "%";
            this.Ganancias.SuperscriptColor = System.Drawing.Color.Gray;
            this.Ganancias.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Ganancias.SuperscriptText = "";
            this.Ganancias.TabIndex = 0;
            this.Ganancias.Text = "0";
            this.Ganancias.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Ganancias.Value = 1;
            // 
            // Capital
            // 
            this.Capital.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Capital.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Capital.AnimationSpeed = 0;
            this.Capital.BackColor = System.Drawing.Color.Transparent;
            this.Capital.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Capital.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.Capital.InnerColor = System.Drawing.Color.White;
            this.Capital.InnerMargin = 4;
            this.Capital.InnerWidth = -1;
            this.Capital.Location = new System.Drawing.Point(10, 20);
            this.Capital.MarqueeAnimationSpeed = 0;
            this.Capital.Name = "Capital";
            this.Capital.OuterColor = System.Drawing.Color.Transparent;
            this.Capital.OuterMargin = 0;
            this.Capital.OuterWidth = 0;
            this.Capital.ProgressColor = System.Drawing.Color.Magenta;
            this.Capital.ProgressWidth = 40;
            this.Capital.SecondaryFont = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Capital.Size = new System.Drawing.Size(160, 160);
            this.Capital.StartAngle = 0;
            this.Capital.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.Capital.SubscriptColor = System.Drawing.Color.Gray;
            this.Capital.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Capital.SubscriptText = "";
            this.Capital.SuperscriptColor = System.Drawing.Color.Gray;
            this.Capital.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Capital.SuperscriptText = "";
            this.Capital.TabIndex = 0;
            this.Capital.Text = "0";
            this.Capital.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Capital.Value = 100;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(880, 788);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.DockChanged += new System.EventHandler(this.Home_DockChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CircularProgressBar.CircularProgressBar Volatil;
        private CircularProgressBar.CircularProgressBar Ganancias;
        private CircularProgressBar.CircularProgressBar Capital;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private CircularProgressBar.CircularProgressBar Seguro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PrecioDolar;
    }
}
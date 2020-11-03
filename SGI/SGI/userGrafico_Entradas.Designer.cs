namespace SGI
{
    partial class userGrafico_Entradas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userGrafico_Entradas));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.pc_imprimir = new System.Windows.Forms.PictureBox();
            this.pcRefresh = new System.Windows.Forms.PictureBox();
            this.gr_grafico1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_imprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr_grafico1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxTipo);
            this.panel1.Controls.Add(this.txtAno);
            this.panel1.Controls.Add(this.pc_imprimir);
            this.panel1.Controls.Add(this.pcRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 28);
            this.panel1.TabIndex = 0;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(140)))));
            this.lbTitulo.Location = new System.Drawing.Point(230, 5);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(229, 19);
            this.lbTitulo.TabIndex = 28;
            this.lbTitulo.Text = "Estatística de entradas de valores";
            this.lbTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(536, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ano:";
            // 
            // cbxTipo
            // 
            this.cbxTipo.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.cbxTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(140)))));
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Entrada de valores",
            "Entradas e Saídas"});
            this.cbxTipo.Location = new System.Drawing.Point(88, 2);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(171, 24);
            this.cbxTipo.TabIndex = 30;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // txtAno
            // 
            this.txtAno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAno.BackColor = System.Drawing.Color.White;
            this.txtAno.Font = new System.Drawing.Font("Microsoft Tai Le", 11F);
            this.txtAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(140)))));
            this.txtAno.Location = new System.Drawing.Point(581, 1);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(64, 26);
            this.txtAno.TabIndex = 2;
            this.txtAno.Text = "2019";
            this.txtAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAno_KeyUp);
            // 
            // pc_imprimir
            // 
            this.pc_imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pc_imprimir.BackColor = System.Drawing.Color.Transparent;
            this.pc_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pc_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("pc_imprimir.Image")));
            this.pc_imprimir.Location = new System.Drawing.Point(37, 0);
            this.pc_imprimir.Name = "pc_imprimir";
            this.pc_imprimir.Size = new System.Drawing.Size(26, 26);
            this.pc_imprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pc_imprimir.TabIndex = 29;
            this.pc_imprimir.TabStop = false;
            this.pc_imprimir.Click += new System.EventHandler(this.pc_imprimir_Click);
            // 
            // pcRefresh
            // 
            this.pcRefresh.BackColor = System.Drawing.Color.Transparent;
            this.pcRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcRefresh.Image = global::SGI.Properties.Resources.icons8_Refresh_26px;
            this.pcRefresh.Location = new System.Drawing.Point(0, 0);
            this.pcRefresh.Name = "pcRefresh";
            this.pcRefresh.Size = new System.Drawing.Size(26, 28);
            this.pcRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcRefresh.TabIndex = 0;
            this.pcRefresh.TabStop = false;
            this.pcRefresh.Click += new System.EventHandler(this.pcRefresh_Click);
            // 
            // gr_grafico1
            // 
            this.gr_grafico1.BorderlineWidth = 0;
            this.gr_grafico1.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.gr_grafico1.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.Position;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.PointDepth = 50;
            chartArea1.Area3DStyle.PointGapDepth = 30;
            chartArea1.Area3DStyle.Rotation = 20;
            chartArea1.Area3DStyle.WallWidth = 5;
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Divot;
            chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(140)))));
            this.gr_grafico1.ChartAreas.Add(chartArea1);
            this.gr_grafico1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.gr_grafico1.Legends.Add(legend1);
            this.gr_grafico1.Location = new System.Drawing.Point(0, 28);
            this.gr_grafico1.Name = "gr_grafico1";
            this.gr_grafico1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 6;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            this.gr_grafico1.Series.Add(series1);
            this.gr_grafico1.Series.Add(series2);
            this.gr_grafico1.Series.Add(series3);
            this.gr_grafico1.Size = new System.Drawing.Size(653, 352);
            this.gr_grafico1.TabIndex = 1;
            this.gr_grafico1.Text = "chart1";
            // 
            // userGrafico_Entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gr_grafico1);
            this.Controls.Add(this.panel1);
            this.Name = "userGrafico_Entradas";
            this.Size = new System.Drawing.Size(653, 380);
            this.Load += new System.EventHandler(this.userGrafico_Entradas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_imprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gr_grafico1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcRefresh;
        private System.Windows.Forms.DataVisualization.Charting.Chart gr_grafico1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.PictureBox pc_imprimir;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label label1;
    }
}

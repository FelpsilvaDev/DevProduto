namespace Desenvolvimento_de_Produto
{
    partial class FrmIndicadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIndicadores));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chartTipos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFunc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mskData2 = new System.Windows.Forms.MaskedTextBox();
            this.chartFaltas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartQuant = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskData1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCalcular = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFaltas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuant)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(129)))), ((int)(((byte)(26)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 26);
            this.panel2.TabIndex = 71;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // chartTipos
            // 
            this.chartTipos.BorderSkin.PageColor = System.Drawing.Color.Maroon;
            chartArea1.Name = "ChartArea1";
            this.chartTipos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTipos.Legends.Add(legend1);
            this.chartTipos.Location = new System.Drawing.Point(22, 170);
            this.chartTipos.Margin = new System.Windows.Forms.Padding(2);
            this.chartTipos.Name = "chartTipos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Tipos";
            this.chartTipos.Series.Add(series1);
            this.chartTipos.Size = new System.Drawing.Size(415, 239);
            this.chartTipos.TabIndex = 0;
            this.chartTipos.Text = "chartTipos";
            title1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Frequencia dos Tipos ";
            this.chartTipos.Titles.Add(title1);
            this.chartTipos.UseWaitCursor = true;
            // 
            // chartFunc
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunc.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunc.Legends.Add(legend2);
            this.chartFunc.Location = new System.Drawing.Point(495, 440);
            this.chartFunc.Margin = new System.Windows.Forms.Padding(2);
            this.chartFunc.Name = "chartFunc";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.MarkerSize = 8;
            series2.Name = "Quantidade";
            this.chartFunc.Series.Add(series2);
            this.chartFunc.Size = new System.Drawing.Size(418, 239);
            this.chartFunc.TabIndex = 7;
            this.chartFunc.Text = "chart1";
            title2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Producao";
            title2.Text = "Produção por Funcionario";
            this.chartFunc.Titles.Add(title2);
            this.chartFunc.Click += new System.EventHandler(this.chartFunc_Click);
            // 
            // mskData2
            // 
            this.mskData2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskData2.Location = new System.Drawing.Point(113, 133);
            this.mskData2.Margin = new System.Windows.Forms.Padding(2);
            this.mskData2.Mask = "00/00/0000";
            this.mskData2.Name = "mskData2";
            this.mskData2.Size = new System.Drawing.Size(81, 24);
            this.mskData2.TabIndex = 3;
            this.mskData2.ValidatingType = typeof(System.DateTime);
            // 
            // chartFaltas
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFaltas.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartFaltas.Legends.Add(legend3);
            this.chartFaltas.Location = new System.Drawing.Point(20, 440);
            this.chartFaltas.Margin = new System.Windows.Forms.Padding(2);
            this.chartFaltas.Name = "chartFaltas";
            this.chartFaltas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Faltas";
            this.chartFaltas.Series.Add(series3);
            this.chartFaltas.Size = new System.Drawing.Size(417, 239);
            this.chartFaltas.TabIndex = 8;
            this.chartFaltas.Text = "chart1";
            title3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Faltas";
            title3.Text = "Faltas por Funcionário";
            this.chartFaltas.Titles.Add(title3);
            // 
            // chartQuant
            // 
            chartArea4.Name = "ChartArea1";
            this.chartQuant.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartQuant.Legends.Add(legend4);
            this.chartQuant.Location = new System.Drawing.Point(495, 170);
            this.chartQuant.Margin = new System.Windows.Forms.Padding(2);
            this.chartQuant.Name = "chartQuant";
            this.chartQuant.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Quantidade";
            this.chartQuant.Series.Add(series4);
            this.chartQuant.Size = new System.Drawing.Size(417, 239);
            this.chartQuant.TabIndex = 6;
            this.chartQuant.Text = "chart1";
            title4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Quantidade de Peças por Tipo";
            title4.Text = "Quantidade de Peças por Tipo";
            this.chartQuant.Titles.Add(title4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(110, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Até:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(19, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "De:";
            // 
            // mskData1
            // 
            this.mskData1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskData1.Location = new System.Drawing.Point(22, 133);
            this.mskData1.Margin = new System.Windows.Forms.Padding(2);
            this.mskData1.Mask = "00/00/0000";
            this.mskData1.Name = "mskData1";
            this.mskData1.Size = new System.Drawing.Size(87, 24);
            this.mskData1.TabIndex = 2;
            this.mskData1.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(369, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 38);
            this.label4.TabIndex = 77;
            this.label4.Text = "Indicadores";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcular.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnCalcular.IconColor = System.Drawing.Color.Black;
            this.BtnCalcular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCalcular.IconSize = 23;
            this.BtnCalcular.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnCalcular.Location = new System.Drawing.Point(200, 132);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(71, 27);
            this.BtnCalcular.TabIndex = 73;
            this.BtnCalcular.Text = "Buscar";
            this.BtnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 715);
            this.panel1.TabIndex = 78;
            // 
            // FrmIndicadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(936, 715);
            this.Controls.Add(this.chartQuant);
            this.Controls.Add(this.chartFunc);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mskData1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartTipos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskData2);
            this.Controls.Add(this.chartFaltas);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmIndicadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Indicadores";
            this.Load += new System.EventHandler(this.FrmIndicadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFaltas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuant)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTipos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc;
        private System.Windows.Forms.MaskedTextBox mskData2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFaltas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartQuant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskData1;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton BtnCalcular;
        private System.Windows.Forms.Panel panel1;
    }
}
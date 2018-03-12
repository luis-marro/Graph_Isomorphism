namespace Proyecto_Discreta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtCargar = new System.Windows.Forms.Button();
            this.LbLVertices1 = new System.Windows.Forms.Label();
            this.LBLVertices2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbLFuncion = new System.Windows.Forms.Label();
            this.BtIsomorfismo = new System.Windows.Forms.Button();
            this.BtBorrar = new System.Windows.Forms.Button();
            this.Grafo1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Grafo2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Grafo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafo2)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtCargar
            // 
            this.BtCargar.Location = new System.Drawing.Point(521, 294);
            this.BtCargar.Name = "BtCargar";
            this.BtCargar.Size = new System.Drawing.Size(146, 37);
            this.BtCargar.TabIndex = 0;
            this.BtCargar.Text = "Cargar Archivo";
            this.BtCargar.UseVisualStyleBackColor = true;
            this.BtCargar.Click += new System.EventHandler(this.BtCargar_Click);
            // 
            // LbLVertices1
            // 
            this.LbLVertices1.AutoSize = true;
            this.LbLVertices1.Location = new System.Drawing.Point(485, 67);
            this.LbLVertices1.Name = "LbLVertices1";
            this.LbLVertices1.Size = new System.Drawing.Size(0, 17);
            this.LbLVertices1.TabIndex = 1;
            // 
            // LBLVertices2
            // 
            this.LBLVertices2.AutoSize = true;
            this.LBLVertices2.Location = new System.Drawing.Point(485, 147);
            this.LBLVertices2.Name = "LBLVertices2";
            this.LBLVertices2.Size = new System.Drawing.Size(0, 17);
            this.LBLVertices2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vertices Grafo 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vertices Grafo 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(488, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Función de Isomorfismo";
            // 
            // LbLFuncion
            // 
            this.LbLFuncion.AutoSize = true;
            this.LbLFuncion.Location = new System.Drawing.Point(488, 234);
            this.LbLFuncion.Name = "LbLFuncion";
            this.LbLFuncion.Size = new System.Drawing.Size(0, 17);
            this.LbLFuncion.TabIndex = 6;
            // 
            // BtIsomorfismo
            // 
            this.BtIsomorfismo.Location = new System.Drawing.Point(521, 346);
            this.BtIsomorfismo.Name = "BtIsomorfismo";
            this.BtIsomorfismo.Size = new System.Drawing.Size(146, 49);
            this.BtIsomorfismo.TabIndex = 7;
            this.BtIsomorfismo.Text = "Comprobar Isomorfismo";
            this.BtIsomorfismo.UseVisualStyleBackColor = true;
            this.BtIsomorfismo.Click += new System.EventHandler(this.BtIsomorfismo_Click);
            // 
            // BtBorrar
            // 
            this.BtBorrar.Location = new System.Drawing.Point(688, 322);
            this.BtBorrar.Name = "BtBorrar";
            this.BtBorrar.Size = new System.Drawing.Size(102, 36);
            this.BtBorrar.TabIndex = 8;
            this.BtBorrar.Text = "Borrar";
            this.BtBorrar.UseVisualStyleBackColor = true;
            this.BtBorrar.Click += new System.EventHandler(this.BtBorrar_Click);
            // 
            // Grafo1
            // 
            chartArea1.Name = "ChartArea1";
            this.Grafo1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Grafo1.Legends.Add(legend1);
            this.Grafo1.Location = new System.Drawing.Point(58, 38);
            this.Grafo1.Name = "Grafo1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Grafo1.Series.Add(series1);
            this.Grafo1.Size = new System.Drawing.Size(359, 168);
            this.Grafo1.TabIndex = 9;
            this.Grafo1.Text = "chart1";
            // 
            // Grafo2
            // 
            chartArea2.Name = "ChartArea1";
            this.Grafo2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Grafo2.Legends.Add(legend2);
            this.Grafo2.Location = new System.Drawing.Point(58, 234);
            this.Grafo2.Name = "Grafo2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Grafo2.Series.Add(series2);
            this.Grafo2.Size = new System.Drawing.Size(359, 161);
            this.Grafo2.TabIndex = 10;
            this.Grafo2.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 444);
            this.Controls.Add(this.Grafo2);
            this.Controls.Add(this.Grafo1);
            this.Controls.Add(this.BtBorrar);
            this.Controls.Add(this.BtIsomorfismo);
            this.Controls.Add(this.LbLFuncion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBLVertices2);
            this.Controls.Add(this.LbLVertices1);
            this.Controls.Add(this.BtCargar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Grafo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtCargar;
        private System.Windows.Forms.Label LbLVertices1;
        private System.Windows.Forms.Label LBLVertices2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbLFuncion;
        private System.Windows.Forms.Button BtIsomorfismo;
        private System.Windows.Forms.Button BtBorrar;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafo1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafo2;
    }
}


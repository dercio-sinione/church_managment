namespace SGI
{
    partial class fn_imprimir_saidas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.saidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Igreja = new SGI.DataSet_Igreja();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.saidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Igreja)).BeginInit();
            this.SuspendLayout();
            // 
            // saidasBindingSource
            // 
            this.saidasBindingSource.DataMember = "saidas";
            this.saidasBindingSource.DataSource = this.DataSet_Igreja;
            // 
            // DataSet_Igreja
            // 
            this.DataSet_Igreja.DataSetName = "DataSet_Igreja";
            this.DataSet_Igreja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.saidasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGI.rp_vw_saidas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(797, 460);
            this.reportViewer1.TabIndex = 0;
            // 
            // fn_imprimir_saidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 460);
            this.Controls.Add(this.reportViewer1);
            this.MinimizeBox = false;
            this.Name = "fn_imprimir_saidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir relatório de Saída de valores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fn_imprimir_saidas_FormClosing);
            this.Load += new System.EventHandler(this.fn_imprimir_saidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Igreja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource saidasBindingSource;
        private DataSet_Igreja DataSet_Igreja;

    }
}
namespace SGI
{
    partial class fn_imprimir_vw_entradas
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
            this.vw_entradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Igreja = new SGI.DataSet_Igreja();
            this.rp_vw_entradas = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.vw_entradasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Igreja)).BeginInit();
            this.SuspendLayout();
            // 
            // vw_entradasBindingSource
            // 
            this.vw_entradasBindingSource.DataMember = "vw_entradas";
            this.vw_entradasBindingSource.DataSource = this.DataSet_Igreja;
            // 
            // DataSet_Igreja
            // 
            this.DataSet_Igreja.DataSetName = "DataSet_Igreja";
            this.DataSet_Igreja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rp_vw_entradas
            // 
            this.rp_vw_entradas.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vw_entradasBindingSource;
            this.rp_vw_entradas.LocalReport.DataSources.Add(reportDataSource1);
            this.rp_vw_entradas.LocalReport.ReportEmbeddedResource = "SGI.rp_entradas.rdlc";
            this.rp_vw_entradas.Location = new System.Drawing.Point(0, 0);
            this.rp_vw_entradas.Name = "rp_vw_entradas";
            this.rp_vw_entradas.Size = new System.Drawing.Size(750, 474);
            this.rp_vw_entradas.TabIndex = 0;
            // 
            // fn_imprimir_vw_entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 474);
            this.Controls.Add(this.rp_vw_entradas);
            this.MinimizeBox = false;
            this.Name = "fn_imprimir_vw_entradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fn_imprimir_vw_entradas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fn_imprimir_vw_entradas_FormClosing);
            this.Load += new System.EventHandler(this.fn_imprimir_vw_entradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vw_entradasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Igreja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rp_vw_entradas;
        private System.Windows.Forms.BindingSource vw_entradasBindingSource;
        private DataSet_Igreja DataSet_Igreja;
    }
}
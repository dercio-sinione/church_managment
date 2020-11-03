namespace SGI
{
    partial class fn_imprimir_Caixa
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
            this.entradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Igreja = new SGI.DataSet_Igreja();
            this.rp_entradas = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.entradasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Igreja)).BeginInit();
            this.SuspendLayout();
            // 
            // entradasBindingSource
            // 
            this.entradasBindingSource.DataMember = "entradas";
            this.entradasBindingSource.DataSource = this.DataSet_Igreja;
            // 
            // DataSet_Igreja
            // 
            this.DataSet_Igreja.DataSetName = "DataSet_Igreja";
            this.DataSet_Igreja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rp_entradas
            // 
            this.rp_entradas.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.entradasBindingSource;
            this.rp_entradas.LocalReport.DataSources.Add(reportDataSource1);
            this.rp_entradas.LocalReport.ReportEmbeddedResource = "SGI.rp_enradas_mes.rdlc";
            this.rp_entradas.Location = new System.Drawing.Point(0, 0);
            this.rp_entradas.Name = "rp_entradas";
            this.rp_entradas.Size = new System.Drawing.Size(684, 486);
            this.rp_entradas.TabIndex = 1;
            // 
            // fn_imprimir_Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 486);
            this.Controls.Add(this.rp_entradas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "fn_imprimir_Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fn_imprimir_Caixa_FormClosing);
            this.Load += new System.EventHandler(this.fn_imprimir_Caixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entradasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Igreja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource entradasBindingSource;
        private DataSet_Igreja DataSet_Igreja;
        private Microsoft.Reporting.WinForms.ReportViewer rp_entradas;

    }
}
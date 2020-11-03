namespace SGI
{
    partial class fn_rp_saidas_enttradas
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
            this.Entradas_saidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Igreja = new SGI.DataSet_Igreja();
            this.rp_saidas = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Entradas_saidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Igreja)).BeginInit();
            this.SuspendLayout();
            // 
            // Entradas_saidasBindingSource
            // 
            this.Entradas_saidasBindingSource.DataMember = "Entradas_saidas";
            this.Entradas_saidasBindingSource.DataSource = this.DataSet_Igreja;
            // 
            // DataSet_Igreja
            // 
            this.DataSet_Igreja.DataSetName = "DataSet_Igreja";
            this.DataSet_Igreja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rp_saidas
            // 
            this.rp_saidas.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Entradas_saidasBindingSource;
            this.rp_saidas.LocalReport.DataSources.Add(reportDataSource1);
            this.rp_saidas.LocalReport.ReportEmbeddedResource = "SGI.rp_saidas.rdlc";
            this.rp_saidas.Location = new System.Drawing.Point(0, 0);
            this.rp_saidas.Name = "rp_saidas";
            this.rp_saidas.Size = new System.Drawing.Size(621, 441);
            this.rp_saidas.TabIndex = 0;
            // 
            // fn_rp_saidas_enttradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 441);
            this.Controls.Add(this.rp_saidas);
            this.MinimizeBox = false;
            this.Name = "fn_rp_saidas_enttradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fn_rp_saidas_enttradas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fn_rp_saidas_enttradas_FormClosing);
            this.Load += new System.EventHandler(this.fn_rp_saidas_enttradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Entradas_saidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Igreja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rp_saidas;
        private System.Windows.Forms.BindingSource Entradas_saidasBindingSource;
        private DataSet_Igreja DataSet_Igreja;
    }
}
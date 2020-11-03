namespace SGI
{
    partial class fn_addTipo_actividade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fn_addTipo_actividade));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_operar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pc_close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_close)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Control;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(118, 129);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(238, 30);
            this.txtNome.TabIndex = 37;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(118, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "TIPO";
            // 
            // btn_operar
            // 
            this.btn_operar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(140)))));
            this.btn_operar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_operar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_operar.ForeColor = System.Drawing.Color.White;
            this.btn_operar.Image = global::SGI.Properties.Resources.Save_26px;
            this.btn_operar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_operar.Location = new System.Drawing.Point(118, 183);
            this.btn_operar.Name = "btn_operar";
            this.btn_operar.Size = new System.Drawing.Size(238, 38);
            this.btn_operar.TabIndex = 35;
            this.btn_operar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_operar.UseVisualStyleBackColor = false;
            this.btn_operar.Click += new System.EventHandler(this.btn_operar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.pc_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 37);
            this.panel1.TabIndex = 34;
            // 
            // pc_close
            // 
            this.pc_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pc_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.pc_close.Image = ((System.Drawing.Image)(resources.GetObject("pc_close.Image")));
            this.pc_close.Location = new System.Drawing.Point(453, 0);
            this.pc_close.Name = "pc_close";
            this.pc_close.Size = new System.Drawing.Size(32, 37);
            this.pc_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_close.TabIndex = 25;
            this.pc_close.TabStop = false;
            this.pc_close.Click += new System.EventHandler(this.pc_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "ACTIVIDADES";
            // 
            // fn_addTipo_actividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 290);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_operar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fn_addTipo_actividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fn_addTipo_actividade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fn_addTipo_actividade_FormClosing);
            this.Load += new System.EventHandler(this.fn_addTipo_actividade_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_operar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pc_close;
        private System.Windows.Forms.Label label1;
    }
}
namespace SGI
{
    partial class fn_addMembro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fn_addMembro));
            this.btn_add = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcClose = new System.Windows.Forms.PictureBox();
            this.pc_logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTel2 = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.txtResidencia = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtM = new System.Windows.Forms.RadioButton();
            this.rbtF = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pc_Imagem = new System.Windows.Forms.PictureBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTel1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPai = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMae = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBI = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Imagem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(140)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Image = global::SGI.Properties.Resources.Save_26px;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(266, 563);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(238, 38);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "CADASTRAR  ";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(124, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(316, 30);
            this.txtNome.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.pcClose);
            this.panel1.Controls.Add(this.pc_logo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 66);
            this.panel1.TabIndex = 52;
            // 
            // pcClose
            // 
            this.pcClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcClose.BackColor = System.Drawing.Color.Transparent;
            this.pcClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcClose.Image = ((System.Drawing.Image)(resources.GetObject("pcClose.Image")));
            this.pcClose.Location = new System.Drawing.Point(1139, 7);
            this.pcClose.Name = "pcClose";
            this.pcClose.Size = new System.Drawing.Size(47, 50);
            this.pcClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcClose.TabIndex = 28;
            this.pcClose.TabStop = false;
            this.pcClose.Click += new System.EventHandler(this.pcClose_Click);
            // 
            // pc_logo
            // 
            this.pc_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pc_logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pc_logo.Image = global::SGI.Properties.Resources.logo;
            this.pc_logo.Location = new System.Drawing.Point(0, 0);
            this.pc_logo.Name = "pc_logo";
            this.pc_logo.Size = new System.Drawing.Size(114, 66);
            this.pc_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_logo.TabIndex = 26;
            this.pc_logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(120, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cadastrar Membros";
            // 
            // txtTel2
            // 
            this.txtTel2.BackColor = System.Drawing.Color.White;
            this.txtTel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel2.Location = new System.Drawing.Point(582, 228);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(309, 30);
            this.txtTel2.TabIndex = 12;
            // 
            // txtApelido
            // 
            this.txtApelido.BackColor = System.Drawing.Color.White;
            this.txtApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApelido.Location = new System.Drawing.Point(124, 78);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(316, 30);
            this.txtApelido.TabIndex = 1;
            // 
            // txtResidencia
            // 
            this.txtResidencia.BackColor = System.Drawing.Color.White;
            this.txtResidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResidencia.Location = new System.Drawing.Point(582, 274);
            this.txtResidencia.Name = "txtResidencia";
            this.txtResidencia.Size = new System.Drawing.Size(309, 30);
            this.txtResidencia.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(582, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(309, 30);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Tag = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(7, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 62;
            this.label3.Text = "Nº BI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(7, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 63;
            this.label4.Text = "Data:";
            // 
            // rbtM
            // 
            this.rbtM.AutoSize = true;
            this.rbtM.Checked = true;
            this.rbtM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rbtM.ForeColor = System.Drawing.Color.DimGray;
            this.rbtM.Location = new System.Drawing.Point(63, 9);
            this.rbtM.Name = "rbtM";
            this.rbtM.Size = new System.Drawing.Size(47, 29);
            this.rbtM.TabIndex = 5;
            this.rbtM.TabStop = true;
            this.rbtM.Text = "M";
            this.rbtM.UseVisualStyleBackColor = true;
            // 
            // rbtF
            // 
            this.rbtF.AutoSize = true;
            this.rbtF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rbtF.ForeColor = System.Drawing.Color.DimGray;
            this.rbtF.Location = new System.Drawing.Point(140, 9);
            this.rbtF.Name = "rbtF";
            this.rbtF.Size = new System.Drawing.Size(42, 29);
            this.rbtF.TabIndex = 6;
            this.rbtF.Text = "F";
            this.rbtF.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(473, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 66;
            this.label5.Text = "Residência:";
            // 
            // pc_Imagem
            // 
            this.pc_Imagem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pc_Imagem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pc_Imagem.Location = new System.Drawing.Point(13, 203);
            this.pc_Imagem.Name = "pc_Imagem";
            this.pc_Imagem.Size = new System.Drawing.Size(224, 201);
            this.pc_Imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_Imagem.TabIndex = 67;
            this.pc_Imagem.TabStop = false;
            this.pc_Imagem.DoubleClick += new System.EventHandler(this.pc_Imagem_DoubleClick);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCarregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(140)))));
            this.btnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCarregar.ForeColor = System.Drawing.Color.White;
            this.btnCarregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarregar.Location = new System.Drawing.Point(13, 410);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(224, 27);
            this.btnCarregar.TabIndex = 14;
            this.btnCarregar.Text = "CARREGAR FOTO...";
            this.btnCarregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCarregar.UseVisualStyleBackColor = false;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtData.Location = new System.Drawing.Point(124, 178);
            this.txtData.Mask = "0000-00-00";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(316, 30);
            this.txtData.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(473, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 71;
            this.label7.Text = "Email:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtF);
            this.groupBox1.Controls.Add(this.rbtM);
            this.groupBox1.Location = new System.Drawing.Point(124, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 42);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(7, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 73;
            this.label6.Text = "Sexo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(473, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 25);
            this.label8.TabIndex = 74;
            this.label8.Text = "Tel2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(473, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 25);
            this.label9.TabIndex = 76;
            this.label9.Text = "Tel1:";
            // 
            // txtTel1
            // 
            this.txtTel1.BackColor = System.Drawing.Color.White;
            this.txtTel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel1.Location = new System.Drawing.Point(582, 178);
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(309, 30);
            this.txtTel1.TabIndex = 11;
            this.txtTel1.Tag = "11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(7, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 25);
            this.label10.TabIndex = 78;
            this.label10.Text = "Estado Civíl:";
            // 
            // cbxEstado
            // 
            this.cbxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Casado",
            "Solteiro",
            "Viúvo",
            "Outro"});
            this.cbxEstado.Location = new System.Drawing.Point(124, 271);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(316, 33);
            this.cbxEstado.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(473, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 25);
            this.label11.TabIndex = 81;
            this.label11.Text = "Pai:";
            // 
            // txtPai
            // 
            this.txtPai.BackColor = System.Drawing.Color.White;
            this.txtPai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPai.Location = new System.Drawing.Point(582, 28);
            this.txtPai.Name = "txtPai";
            this.txtPai.Size = new System.Drawing.Size(309, 30);
            this.txtPai.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(473, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 25);
            this.label12.TabIndex = 83;
            this.label12.Text = "Mãe:";
            // 
            // txtMae
            // 
            this.txtMae.BackColor = System.Drawing.Color.White;
            this.txtMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMae.Location = new System.Drawing.Point(582, 78);
            this.txtMae.Name = "txtMae";
            this.txtMae.Size = new System.Drawing.Size(309, 30);
            this.txtMae.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(7, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 25);
            this.label13.TabIndex = 84;
            this.label13.Text = "Apelido:";
            // 
            // txtBI
            // 
            this.txtBI.BackColor = System.Drawing.Color.White;
            this.txtBI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBI.Location = new System.Drawing.Point(124, 128);
            this.txtBI.Name = "txtBI";
            this.txtBI.Size = new System.Drawing.Size(316, 30);
            this.txtBI.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.txtBI);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtMae);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtPai);
            this.groupBox2.Controls.Add(this.cbxEstado);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTel1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtData);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtResidencia);
            this.groupBox2.Controls.Add(this.txtApelido);
            this.groupBox2.Controls.Add(this.txtTel2);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Location = new System.Drawing.Point(263, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(902, 336);
            this.groupBox2.TabIndex = 86;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adicionar informaçãoes";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // fn_addMembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 635);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.pc_Imagem);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fn_addMembro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fn_addMembro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fn_addMembro_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Imagem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcClose;
        private System.Windows.Forms.PictureBox pc_logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTel2;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.TextBox txtResidencia;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtM;
        private System.Windows.Forms.RadioButton rbtF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pc_Imagem;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMae;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBI;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
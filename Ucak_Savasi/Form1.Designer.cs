namespace Ucak_Savasi
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.rad_kolay = new System.Windows.Forms.RadioButton();
            this.rad_orta = new System.Windows.Forms.RadioButton();
            this.rad_zor = new System.Windows.Forms.RadioButton();
            this.btn_duraklat = new System.Windows.Forms.Button();
            this.btn_basla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.lbl_puan = new System.Windows.Forms.Label();
            this.lbl_durum = new System.Windows.Forms.Label();
            this.dusman_3 = new System.Windows.Forms.PictureBox();
            this.dusman_1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.mermi = new System.Windows.Forms.PictureBox();
            this.dusman_2 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.oyunaBaşlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oyunuBitirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zorlukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dusman_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dusman_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mermi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dusman_2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.rad_kolay);
            this.panel1.Controls.Add(this.rad_orta);
            this.panel1.Controls.Add(this.rad_zor);
            this.panel1.Controls.Add(this.btn_duraklat);
            this.panel1.Controls.Add(this.btn_basla);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblsonuc);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 50);
            this.panel1.TabIndex = 4;
            // 
            // rad_kolay
            // 
            this.rad_kolay.AutoSize = true;
            this.rad_kolay.Checked = true;
            this.rad_kolay.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rad_kolay.Location = new System.Drawing.Point(344, 15);
            this.rad_kolay.Name = "rad_kolay";
            this.rad_kolay.Size = new System.Drawing.Size(61, 21);
            this.rad_kolay.TabIndex = 8;
            this.rad_kolay.TabStop = true;
            this.rad_kolay.Text = "Kolay";
            this.rad_kolay.UseVisualStyleBackColor = true;
            // 
            // rad_orta
            // 
            this.rad_orta.AutoSize = true;
            this.rad_orta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rad_orta.Location = new System.Drawing.Point(283, 15);
            this.rad_orta.Name = "rad_orta";
            this.rad_orta.Size = new System.Drawing.Size(55, 21);
            this.rad_orta.TabIndex = 7;
            this.rad_orta.Text = "Orta";
            this.rad_orta.UseVisualStyleBackColor = true;
            // 
            // rad_zor
            // 
            this.rad_zor.AutoSize = true;
            this.rad_zor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rad_zor.Location = new System.Drawing.Point(232, 15);
            this.rad_zor.Name = "rad_zor";
            this.rad_zor.Size = new System.Drawing.Size(45, 21);
            this.rad_zor.TabIndex = 6;
            this.rad_zor.Text = "Zor";
            this.rad_zor.UseVisualStyleBackColor = true;
            // 
            // btn_duraklat
            // 
            this.btn_duraklat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_duraklat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_duraklat.Location = new System.Drawing.Point(411, 0);
            this.btn_duraklat.Name = "btn_duraklat";
            this.btn_duraklat.Size = new System.Drawing.Size(108, 50);
            this.btn_duraklat.TabIndex = 5;
            this.btn_duraklat.Text = "Bitir (S)";
            this.btn_duraklat.UseVisualStyleBackColor = true;
            this.btn_duraklat.Click += new System.EventHandler(this.btn_duraklat_Click);
            // 
            // btn_basla
            // 
            this.btn_basla.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_basla.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_basla.Location = new System.Drawing.Point(519, 0);
            this.btn_basla.Name = "btn_basla";
            this.btn_basla.Size = new System.Drawing.Size(105, 50);
            this.btn_basla.TabIndex = 4;
            this.btn_basla.Text = "Başla (Enter)";
            this.btn_basla.UseVisualStyleBackColor = true;
            this.btn_basla.Click += new System.EventHandler(this.btn_basla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Puan";
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsonuc.ForeColor = System.Drawing.Color.Black;
            this.lblsonuc.Location = new System.Drawing.Point(69, 16);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(21, 23);
            this.lblsonuc.TabIndex = 2;
            this.lblsonuc.Text = "0";
            // 
            // lbl_puan
            // 
            this.lbl_puan.AutoSize = true;
            this.lbl_puan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_puan.Font = new System.Drawing.Font("Vineta BT", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_puan.ForeColor = System.Drawing.Color.Blue;
            this.lbl_puan.Location = new System.Drawing.Point(478, 606);
            this.lbl_puan.Name = "lbl_puan";
            this.lbl_puan.Size = new System.Drawing.Size(134, 25);
            this.lbl_puan.TabIndex = 9;
            this.lbl_puan.Text = "+2 PUAN";
            // 
            // lbl_durum
            // 
            this.lbl_durum.AutoSize = true;
            this.lbl_durum.BackColor = System.Drawing.Color.Transparent;
            this.lbl_durum.Font = new System.Drawing.Font("Vineta BT", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_durum.ForeColor = System.Drawing.Color.Blue;
            this.lbl_durum.Location = new System.Drawing.Point(478, 631);
            this.lbl_durum.Name = "lbl_durum";
            this.lbl_durum.Size = new System.Drawing.Size(116, 25);
            this.lbl_durum.TabIndex = 10;
            this.lbl_durum.Text = "GÜZEL!";
            // 
            // dusman_3
            // 
            this.dusman_3.BackColor = System.Drawing.Color.Transparent;
            this.dusman_3.Image = global::Ucak_Savasi.Properties.Resources.dusman1;
            this.dusman_3.Location = new System.Drawing.Point(438, 126);
            this.dusman_3.Name = "dusman_3";
            this.dusman_3.Size = new System.Drawing.Size(100, 84);
            this.dusman_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dusman_3.TabIndex = 3;
            this.dusman_3.TabStop = false;
            // 
            // dusman_1
            // 
            this.dusman_1.BackColor = System.Drawing.Color.Transparent;
            this.dusman_1.Image = global::Ucak_Savasi.Properties.Resources.dusman1;
            this.dusman_1.Location = new System.Drawing.Point(72, 126);
            this.dusman_1.Name = "dusman_1";
            this.dusman_1.Size = new System.Drawing.Size(100, 84);
            this.dusman_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dusman_1.TabIndex = 2;
            this.dusman_1.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Ucak_Savasi.Properties.Resources.bizim;
            this.player.Location = new System.Drawing.Point(258, 498);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(107, 83);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // mermi
            // 
            this.mermi.BackColor = System.Drawing.Color.Transparent;
            this.mermi.Image = global::Ucak_Savasi.Properties.Resources.ates;
            this.mermi.Location = new System.Drawing.Point(294, 422);
            this.mermi.Name = "mermi";
            this.mermi.Size = new System.Drawing.Size(23, 37);
            this.mermi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mermi.TabIndex = 0;
            this.mermi.TabStop = false;
            // 
            // dusman_2
            // 
            this.dusman_2.BackColor = System.Drawing.Color.Transparent;
            this.dusman_2.Image = global::Ucak_Savasi.Properties.Resources.dusman1;
            this.dusman_2.Location = new System.Drawing.Point(258, 126);
            this.dusman_2.Name = "dusman_2";
            this.dusman_2.Size = new System.Drawing.Size(100, 84);
            this.dusman_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dusman_2.TabIndex = 0;
            this.dusman_2.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oyunaBaşlaToolStripMenuItem,
            this.oyunuBitirToolStripMenuItem,
            this.zorlukToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 70);
            // 
            // oyunaBaşlaToolStripMenuItem
            // 
            this.oyunaBaşlaToolStripMenuItem.Name = "oyunaBaşlaToolStripMenuItem";
            this.oyunaBaşlaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oyunaBaşlaToolStripMenuItem.Text = "Oyuna Başla";
            this.oyunaBaşlaToolStripMenuItem.Click += new System.EventHandler(this.oyunaBaşlaToolStripMenuItem_Click);
            // 
            // oyunuBitirToolStripMenuItem
            // 
            this.oyunuBitirToolStripMenuItem.Enabled = false;
            this.oyunuBitirToolStripMenuItem.Name = "oyunuBitirToolStripMenuItem";
            this.oyunuBitirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oyunuBitirToolStripMenuItem.Text = "Oyunu Bitir";
            this.oyunuBitirToolStripMenuItem.Click += new System.EventHandler(this.oyunuBitirToolStripMenuItem_Click);
            // 
            // zorlukToolStripMenuItem
            // 
            this.zorlukToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zorToolStripMenuItem,
            this.ortaToolStripMenuItem,
            this.kolayToolStripMenuItem});
            this.zorlukToolStripMenuItem.Name = "zorlukToolStripMenuItem";
            this.zorlukToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.zorlukToolStripMenuItem.Text = "Zorluk";
            // 
            // zorToolStripMenuItem
            // 
            this.zorToolStripMenuItem.Name = "zorToolStripMenuItem";
            this.zorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zorToolStripMenuItem.Text = "Zor";
            this.zorToolStripMenuItem.Click += new System.EventHandler(this.zorToolStripMenuItem_Click);
            // 
            // ortaToolStripMenuItem
            // 
            this.ortaToolStripMenuItem.Name = "ortaToolStripMenuItem";
            this.ortaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ortaToolStripMenuItem.Text = "Orta";
            this.ortaToolStripMenuItem.Click += new System.EventHandler(this.ortaToolStripMenuItem_Click);
            // 
            // kolayToolStripMenuItem
            // 
            this.kolayToolStripMenuItem.Checked = true;
            this.kolayToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kolayToolStripMenuItem.Name = "kolayToolStripMenuItem";
            this.kolayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kolayToolStripMenuItem.Text = "Kolay";
            this.kolayToolStripMenuItem.Click += new System.EventHandler(this.kolayToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 55);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(25, 474);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(624, 667);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dusman_3);
            this.Controls.Add(this.dusman_1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.mermi);
            this.Controls.Add(this.dusman_2);
            this.Controls.Add(this.lbl_durum);
            this.Controls.Add(this.lbl_puan);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uçak Savaşı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dusman_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dusman_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mermi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dusman_2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox dusman_2;
        private System.Windows.Forms.PictureBox mermi;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox dusman_1;
        private System.Windows.Forms.PictureBox dusman_3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_basla;
        private System.Windows.Forms.Button btn_duraklat;
        private System.Windows.Forms.RadioButton rad_orta;
        private System.Windows.Forms.RadioButton rad_zor;
        private System.Windows.Forms.RadioButton rad_kolay;
        private System.Windows.Forms.Label lbl_puan;
        private System.Windows.Forms.Label lbl_durum;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oyunaBaşlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oyunuBitirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zorlukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ortaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolayToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}


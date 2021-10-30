
namespace Kronometre
{
    partial class Kronometre
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kronometre));
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBaslatDurdur = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.lblSalise = new System.Windows.Forms.Label();
            this.timerSalise = new System.Windows.Forms.Timer(this.components);
            this.timerSaniye = new System.Windows.Forms.Timer(this.components);
            this.timerDakika = new System.Windows.Forms.Timer(this.components);
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            this.lblSaniye = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDakika = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.pnlTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(343, 32);
            this.pnlTitleBar.TabIndex = 0;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TasimaIslemi);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Aquire", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.lblTitle.Location = new System.Drawing.Point(10, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(116, 16);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Kronometre";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TasimaIslemi);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Aquire", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnExit.Location = new System.Drawing.Point(311, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBaslatDurdur
            // 
            this.btnBaslatDurdur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.btnBaslatDurdur.FlatAppearance.BorderSize = 0;
            this.btnBaslatDurdur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btnBaslatDurdur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaslatDurdur.Font = new System.Drawing.Font("Aquire", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaslatDurdur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnBaslatDurdur.Location = new System.Drawing.Point(24, 316);
            this.btnBaslatDurdur.Name = "btnBaslatDurdur";
            this.btnBaslatDurdur.Size = new System.Drawing.Size(129, 53);
            this.btnBaslatDurdur.TabIndex = 1;
            this.btnBaslatDurdur.Text = "Baslat";
            this.btnBaslatDurdur.UseVisualStyleBackColor = false;
            this.btnBaslatDurdur.Click += new System.EventHandler(this.btnBaslatDurdur_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.btnSifirla.FlatAppearance.BorderSize = 0;
            this.btnSifirla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btnSifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifirla.Font = new System.Drawing.Font("Aquire", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSifirla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnSifirla.Location = new System.Drawing.Point(175, 316);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(129, 53);
            this.btnSifirla.TabIndex = 2;
            this.btnSifirla.Text = "Sifirla";
            this.btnSifirla.UseVisualStyleBackColor = false;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // lblSalise
            // 
            this.lblSalise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSalise.Font = new System.Drawing.Font("Aquire", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.lblSalise.Location = new System.Drawing.Point(280, 28);
            this.lblSalise.Name = "lblSalise";
            this.lblSalise.Size = new System.Drawing.Size(57, 32);
            this.lblSalise.TabIndex = 3;
            this.lblSalise.Text = "00";
            this.lblSalise.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // timerSalise
            // 
            this.timerSalise.Interval = 10;
            this.timerSalise.Tick += new System.EventHandler(this.timerSalise_Tick);
            // 
            // timerSaniye
            // 
            this.timerSaniye.Interval = 1000;
            this.timerSaniye.Tick += new System.EventHandler(this.timerSaniye_Tick);
            // 
            // timerDakika
            // 
            this.timerDakika.Interval = 60000;
            this.timerDakika.Tick += new System.EventHandler(this.timerDakika_Tick);
            // 
            // timerSaat
            // 
            this.timerSaat.Interval = 3600000;
            this.timerSaat.Tick += new System.EventHandler(this.timerSaat_Tick);
            // 
            // lblSaniye
            // 
            this.lblSaniye.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSaniye.Font = new System.Drawing.Font("Aquire", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaniye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.lblSaniye.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblSaniye.Location = new System.Drawing.Point(181, 4);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(110, 56);
            this.lblSaniye.TabIndex = 3;
            this.lblSaniye.Text = "00:";
            this.lblSaniye.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSalise);
            this.panel1.Controls.Add(this.lblSaniye);
            this.panel1.Controls.Add(this.lblDakika);
            this.panel1.Controls.Add(this.lblSaat);
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(337, 61);
            this.panel1.TabIndex = 4;
            // 
            // lblDakika
            // 
            this.lblDakika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDakika.AutoSize = true;
            this.lblDakika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDakika.Font = new System.Drawing.Font("Aquire", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDakika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.lblDakika.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblDakika.Location = new System.Drawing.Point(88, 4);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(110, 56);
            this.lblDakika.TabIndex = 3;
            this.lblDakika.Text = "00:";
            this.lblDakika.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblSaat
            // 
            this.lblSaat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaat.AutoSize = true;
            this.lblSaat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSaat.Font = new System.Drawing.Font("Aquire", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.lblSaat.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblSaat.Location = new System.Drawing.Point(-4, 4);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(110, 56);
            this.lblSaat.TabIndex = 3;
            this.lblSaat.Text = "00:";
            this.lblSaat.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Kronometre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(343, 388);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnBaslatDurdur);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kronometre";
            this.Text = "Kronometre by Kerem Zayim";
            this.Load += new System.EventHandler(this.FormKronometre_Load);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBaslatDurdur;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.Label lblSalise;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer timerSalise;
        private System.Windows.Forms.Timer timerSaniye;
        private System.Windows.Forms.Timer timerDakika;
        private System.Windows.Forms.Timer timerSaat;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label lblSaat;
    }
}


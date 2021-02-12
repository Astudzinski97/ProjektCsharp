namespace ProjektCplotek
{
    partial class Gierka
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
            this.WynikLabel = new System.Windows.Forms.Label();
            this.TimerGierki = new System.Windows.Forms.Timer(this.components);
            this.kaktus2 = new System.Windows.Forms.PictureBox();
            this.kaktus1 = new System.Windows.Forms.PictureBox();
            this.biegacz = new System.Windows.Forms.PictureBox();
            this.podloga = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kaktus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaktus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biegacz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podloga)).BeginInit();
            this.SuspendLayout();
            // 
            // WynikLabel
            // 
            this.WynikLabel.AutoSize = true;
            this.WynikLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WynikLabel.Location = new System.Drawing.Point(20, 20);
            this.WynikLabel.Name = "WynikLabel";
            this.WynikLabel.Size = new System.Drawing.Size(76, 20);
            this.WynikLabel.TabIndex = 4;
            this.WynikLabel.Text = "Wynik: 0";
            // 
            // TimerGierki
            // 
            this.TimerGierki.Enabled = true;
            this.TimerGierki.Interval = 20;
            this.TimerGierki.Tick += new System.EventHandler(this.Event1);
            // 
            // kaktus2
            // 
            this.kaktus2.BackColor = System.Drawing.Color.Transparent;
            this.kaktus2.Image = global::ProjektCplotek.Properties.Resources.kaktus2;
            this.kaktus2.Location = new System.Drawing.Point(534, 400);
            this.kaktus2.Name = "kaktus2";
            this.kaktus2.Size = new System.Drawing.Size(50, 50);
            this.kaktus2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kaktus2.TabIndex = 3;
            this.kaktus2.TabStop = false;
            this.kaktus2.Tag = "kaktus";
            // 
            // kaktus1
            // 
            this.kaktus1.BackColor = System.Drawing.Color.Transparent;
            this.kaktus1.Image = global::ProjektCplotek.Properties.Resources.kaktus1;
            this.kaktus1.Location = new System.Drawing.Point(371, 405);
            this.kaktus1.Name = "kaktus1";
            this.kaktus1.Size = new System.Drawing.Size(23, 46);
            this.kaktus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.kaktus1.TabIndex = 2;
            this.kaktus1.TabStop = false;
            this.kaktus1.Tag = "kaktus";
            // 
            // biegacz
            // 
            this.biegacz.BackColor = System.Drawing.Color.Transparent;
            this.biegacz.Image = global::ProjektCplotek.Properties.Resources.bieganim;
            this.biegacz.Location = new System.Drawing.Point(131, 385);
            this.biegacz.Name = "biegacz";
            this.biegacz.Size = new System.Drawing.Size(44, 60);
            this.biegacz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.biegacz.TabIndex = 1;
            this.biegacz.TabStop = false;
            // 
            // podloga
            // 
            this.podloga.BackColor = System.Drawing.Color.Black;
            this.podloga.Location = new System.Drawing.Point(-4, 445);
            this.podloga.Name = "podloga";
            this.podloga.Size = new System.Drawing.Size(625, 50);
            this.podloga.TabIndex = 0;
            this.podloga.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Spróbuj Ponownie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.resetuj);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Zapisz Wynik";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.ZapiszWynik);
            // 
            // Gierka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 475);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WynikLabel);
            this.Controls.Add(this.kaktus2);
            this.Controls.Add(this.kaktus1);
            this.Controls.Add(this.biegacz);
            this.Controls.Add(this.podloga);
            this.Name = "Gierka";
            this.Text = "Gierka";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyup);
            ((System.ComponentModel.ISupportInitialize)(this.kaktus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaktus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biegacz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podloga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox podloga;
        private System.Windows.Forms.PictureBox biegacz;
        private System.Windows.Forms.PictureBox kaktus1;
        private System.Windows.Forms.PictureBox kaktus2;
        private System.Windows.Forms.Label WynikLabel;
        private System.Windows.Forms.Timer TimerGierki;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
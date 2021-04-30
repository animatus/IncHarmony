
namespace IncHarmony
{
    partial class Welcome_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome_Screen));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_home = new System.Windows.Forms.Panel();
            this.lan_last = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pan_last1 = new System.Windows.Forms.Panel();
            this.pan_last2 = new System.Windows.Forms.Panel();
            this.pan_last3 = new System.Windows.Forms.Panel();
            this.pan_last4 = new System.Windows.Forms.Panel();
            this.pan_last5 = new System.Windows.Forms.Panel();
            this.pan_selected = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pan_selected1 = new System.Windows.Forms.Panel();
            this.pan_selected2 = new System.Windows.Forms.Panel();
            this.pan_selected3 = new System.Windows.Forms.Panel();
            this.pan_selected4 = new System.Windows.Forms.Panel();
            this.pan_selected5 = new System.Windows.Forms.Panel();
            this.pan_play = new System.Windows.Forms.Panel();
            this.pan_sopran = new System.Windows.Forms.Panel();
            this.pan_alt = new System.Windows.Forms.Panel();
            this.pan_bas = new System.Windows.Forms.Panel();
            this.pan_tenor = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.wmp_sopran = new AxWMPLib.AxWindowsMediaPlayer();
            this.wmp_alt = new AxWMPLib.AxWindowsMediaPlayer();
            this.wmp_bass = new AxWMPLib.AxWindowsMediaPlayer();
            this.wmp_tenor = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_home.SuspendLayout();
            this.lan_last.SuspendLayout();
            this.pan_selected.SuspendLayout();
            this.pan_play.SuspendLayout();
            this.pan_sopran.SuspendLayout();
            this.pan_alt.SuspendLayout();
            this.pan_bas.SuspendLayout();
            this.pan_tenor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_sopran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_alt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_bass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_tenor)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1026, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 955);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 38);
            this.button2.TabIndex = 0;
            this.button2.Text = "Home";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(13, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 38);
            this.button3.TabIndex = 1;
            this.button3.Text = "Search";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 63);
            this.label1.TabIndex = 3;
            this.label1.Text = "IncHarmony";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(995, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "D";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(964, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "_";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(13, 100);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(167, 38);
            this.button6.TabIndex = 2;
            this.button6.Text = "Library";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(218, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 103);
            this.panel2.TabIndex = 6;
            // 
            // panel_home
            // 
            this.panel_home.Controls.Add(this.pan_selected);
            this.panel_home.Controls.Add(this.lan_last);
            this.panel_home.Location = new System.Drawing.Point(218, 121);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(1068, 791);
            this.panel_home.TabIndex = 0;
            // 
            // lan_last
            // 
            this.lan_last.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lan_last.Controls.Add(this.pan_last5);
            this.lan_last.Controls.Add(this.pan_last4);
            this.lan_last.Controls.Add(this.pan_last3);
            this.lan_last.Controls.Add(this.pan_last2);
            this.lan_last.Controls.Add(this.pan_last1);
            this.lan_last.Controls.Add(this.label2);
            this.lan_last.Location = new System.Drawing.Point(3, 3);
            this.lan_last.Name = "lan_last";
            this.lan_last.Size = new System.Drawing.Size(1060, 317);
            this.lan_last.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ostatnio odtwarzane";
            // 
            // pan_last1
            // 
            this.pan_last1.Location = new System.Drawing.Point(20, 76);
            this.pan_last1.Name = "pan_last1";
            this.pan_last1.Size = new System.Drawing.Size(200, 200);
            this.pan_last1.TabIndex = 7;
            // 
            // pan_last2
            // 
            this.pan_last2.Location = new System.Drawing.Point(226, 76);
            this.pan_last2.Name = "pan_last2";
            this.pan_last2.Size = new System.Drawing.Size(200, 200);
            this.pan_last2.TabIndex = 8;
            // 
            // pan_last3
            // 
            this.pan_last3.Location = new System.Drawing.Point(432, 76);
            this.pan_last3.Name = "pan_last3";
            this.pan_last3.Size = new System.Drawing.Size(200, 200);
            this.pan_last3.TabIndex = 8;
            // 
            // pan_last4
            // 
            this.pan_last4.Location = new System.Drawing.Point(638, 76);
            this.pan_last4.Name = "pan_last4";
            this.pan_last4.Size = new System.Drawing.Size(200, 200);
            this.pan_last4.TabIndex = 8;
            // 
            // pan_last5
            // 
            this.pan_last5.Location = new System.Drawing.Point(844, 76);
            this.pan_last5.Name = "pan_last5";
            this.pan_last5.Size = new System.Drawing.Size(200, 200);
            this.pan_last5.TabIndex = 8;
            // 
            // pan_selected
            // 
            this.pan_selected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan_selected.Controls.Add(this.pan_selected5);
            this.pan_selected.Controls.Add(this.pan_selected4);
            this.pan_selected.Controls.Add(this.pan_selected3);
            this.pan_selected.Controls.Add(this.pan_selected2);
            this.pan_selected.Controls.Add(this.pan_selected1);
            this.pan_selected.Controls.Add(this.label3);
            this.pan_selected.Location = new System.Drawing.Point(3, 326);
            this.pan_selected.Name = "pan_selected";
            this.pan_selected.Size = new System.Drawing.Size(1060, 421);
            this.pan_selected.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Utwory wybrane";
            // 
            // pan_selected1
            // 
            this.pan_selected1.Location = new System.Drawing.Point(20, 76);
            this.pan_selected1.Name = "pan_selected1";
            this.pan_selected1.Size = new System.Drawing.Size(200, 200);
            this.pan_selected1.TabIndex = 7;
            // 
            // pan_selected2
            // 
            this.pan_selected2.Location = new System.Drawing.Point(226, 76);
            this.pan_selected2.Name = "pan_selected2";
            this.pan_selected2.Size = new System.Drawing.Size(200, 200);
            this.pan_selected2.TabIndex = 8;
            // 
            // pan_selected3
            // 
            this.pan_selected3.Location = new System.Drawing.Point(432, 76);
            this.pan_selected3.Name = "pan_selected3";
            this.pan_selected3.Size = new System.Drawing.Size(200, 200);
            this.pan_selected3.TabIndex = 8;
            // 
            // pan_selected4
            // 
            this.pan_selected4.Location = new System.Drawing.Point(638, 76);
            this.pan_selected4.Name = "pan_selected4";
            this.pan_selected4.Size = new System.Drawing.Size(200, 200);
            this.pan_selected4.TabIndex = 8;
            // 
            // pan_selected5
            // 
            this.pan_selected5.Location = new System.Drawing.Point(844, 76);
            this.pan_selected5.Name = "pan_selected5";
            this.pan_selected5.Size = new System.Drawing.Size(200, 200);
            this.pan_selected5.TabIndex = 8;
            // 
            // pan_play
            // 
            this.pan_play.Controls.Add(this.button8);
            this.pan_play.Controls.Add(this.pan_tenor);
            this.pan_play.Controls.Add(this.pan_bas);
            this.pan_play.Controls.Add(this.pan_alt);
            this.pan_play.Controls.Add(this.pan_sopran);
            this.pan_play.Location = new System.Drawing.Point(218, 118);
            this.pan_play.Name = "pan_play";
            this.pan_play.Size = new System.Drawing.Size(1068, 849);
            this.pan_play.TabIndex = 10;
            // 
            // pan_sopran
            // 
            this.pan_sopran.BackColor = System.Drawing.SystemColors.Desktop;
            this.pan_sopran.Controls.Add(this.wmp_sopran);
            this.pan_sopran.Location = new System.Drawing.Point(12, 19);
            this.pan_sopran.Name = "pan_sopran";
            this.pan_sopran.Size = new System.Drawing.Size(440, 330);
            this.pan_sopran.TabIndex = 0;
            // 
            // pan_alt
            // 
            this.pan_alt.BackColor = System.Drawing.SystemColors.ControlText;
            this.pan_alt.Controls.Add(this.wmp_alt);
            this.pan_alt.Location = new System.Drawing.Point(606, 19);
            this.pan_alt.Name = "pan_alt";
            this.pan_alt.Size = new System.Drawing.Size(440, 330);
            this.pan_alt.TabIndex = 1;
            // 
            // pan_bas
            // 
            this.pan_bas.BackColor = System.Drawing.SystemColors.ControlText;
            this.pan_bas.Controls.Add(this.wmp_bass);
            this.pan_bas.Location = new System.Drawing.Point(12, 439);
            this.pan_bas.Name = "pan_bas";
            this.pan_bas.Size = new System.Drawing.Size(440, 330);
            this.pan_bas.TabIndex = 1;
            // 
            // pan_tenor
            // 
            this.pan_tenor.BackColor = System.Drawing.SystemColors.ControlText;
            this.pan_tenor.Controls.Add(this.wmp_tenor);
            this.pan_tenor.Location = new System.Drawing.Point(606, 439);
            this.pan_tenor.Name = "pan_tenor";
            this.pan_tenor.Size = new System.Drawing.Size(440, 330);
            this.pan_tenor.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(13, 144);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(167, 38);
            this.button7.TabIndex = 3;
            this.button7.Text = "Last";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(492, 376);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 42);
            this.button8.TabIndex = 2;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // wmp_sopran
            // 
            this.wmp_sopran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmp_sopran.Enabled = true;
            this.wmp_sopran.Location = new System.Drawing.Point(0, 0);
            this.wmp_sopran.Name = "wmp_sopran";
            this.wmp_sopran.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp_sopran.OcxState")));
            this.wmp_sopran.Size = new System.Drawing.Size(440, 330);
            this.wmp_sopran.TabIndex = 0;
            // 
            // wmp_alt
            // 
            this.wmp_alt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmp_alt.Enabled = true;
            this.wmp_alt.Location = new System.Drawing.Point(0, 0);
            this.wmp_alt.Name = "wmp_alt";
            this.wmp_alt.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp_alt.OcxState")));
            this.wmp_alt.Size = new System.Drawing.Size(440, 330);
            this.wmp_alt.TabIndex = 1;
            // 
            // wmp_bass
            // 
            this.wmp_bass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmp_bass.Enabled = true;
            this.wmp_bass.Location = new System.Drawing.Point(0, 0);
            this.wmp_bass.Name = "wmp_bass";
            this.wmp_bass.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp_bass.OcxState")));
            this.wmp_bass.Size = new System.Drawing.Size(440, 330);
            this.wmp_bass.TabIndex = 1;
            // 
            // wmp_tenor
            // 
            this.wmp_tenor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmp_tenor.Enabled = true;
            this.wmp_tenor.Location = new System.Drawing.Point(0, 0);
            this.wmp_tenor.Name = "wmp_tenor";
            this.wmp_tenor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp_tenor.OcxState")));
            this.wmp_tenor.Size = new System.Drawing.Size(440, 330);
            this.wmp_tenor.TabIndex = 1;
            // 
            // Welcome_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1298, 979);
            this.ControlBox = false;
            this.Controls.Add(this.pan_play);
            this.Controls.Add(this.panel_home);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welcome_Screen";
            this.Text = "IncHarmony Welcome Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_home.ResumeLayout(false);
            this.lan_last.ResumeLayout(false);
            this.lan_last.PerformLayout();
            this.pan_selected.ResumeLayout(false);
            this.pan_selected.PerformLayout();
            this.pan_play.ResumeLayout(false);
            this.pan_sopran.ResumeLayout(false);
            this.pan_alt.ResumeLayout(false);
            this.pan_bas.ResumeLayout(false);
            this.pan_tenor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmp_sopran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_alt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_bass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_tenor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.Panel pan_selected;
        private System.Windows.Forms.Panel pan_selected5;
        private System.Windows.Forms.Panel pan_selected4;
        private System.Windows.Forms.Panel pan_selected3;
        private System.Windows.Forms.Panel pan_selected2;
        private System.Windows.Forms.Panel pan_selected1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel lan_last;
        private System.Windows.Forms.Panel pan_last5;
        private System.Windows.Forms.Panel pan_last4;
        private System.Windows.Forms.Panel pan_last3;
        private System.Windows.Forms.Panel pan_last2;
        private System.Windows.Forms.Panel pan_last1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pan_play;
        private System.Windows.Forms.Panel pan_tenor;
        private System.Windows.Forms.Panel pan_bas;
        private System.Windows.Forms.Panel pan_alt;
        private System.Windows.Forms.Panel pan_sopran;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private AxWMPLib.AxWindowsMediaPlayer wmp_sopran;
        private AxWMPLib.AxWindowsMediaPlayer wmp_tenor;
        private AxWMPLib.AxWindowsMediaPlayer wmp_bass;
        private AxWMPLib.AxWindowsMediaPlayer wmp_alt;
    }
}
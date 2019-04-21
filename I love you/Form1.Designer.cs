namespace I_love_you
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnCo = new System.Windows.Forms.Button();
            this.btnKhong = new System.Windows.Forms.Button();
            this.btnTroll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("VNI-Ariston", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(114, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(502, 66);
            this.label4.TabIndex = 3;
            this.label4.Text = "Em coù yeâu anh khoâng?";
            // 
            // btnCo
            // 
            this.btnCo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCo.Font = new System.Drawing.Font("VNI-Ariston", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCo.Location = new System.Drawing.Point(44, 152);
            this.btnCo.Name = "btnCo";
            this.btnCo.Size = new System.Drawing.Size(207, 53);
            this.btnCo.TabIndex = 4;
            this.btnCo.Text = "Daï coù ahihi";
            this.btnCo.UseVisualStyleBackColor = false;
            this.btnCo.Click += new System.EventHandler(this.btnCo_Click);
            // 
            // btnKhong
            // 
            this.btnKhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnKhong.Font = new System.Drawing.Font("VNI-Ariston", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhong.Location = new System.Drawing.Point(496, 152);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(207, 53);
            this.btnKhong.TabIndex = 5;
            this.btnKhong.Text = "EÙo nheù!";
            this.btnKhong.UseVisualStyleBackColor = false;
            this.btnKhong.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnKhong_MouseMove);
            // 
            // btnTroll
            // 
            this.btnTroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTroll.Font = new System.Drawing.Font("VNI-Ariston", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroll.Location = new System.Drawing.Point(197, 309);
            this.btnTroll.Name = "btnTroll";
            this.btnTroll.Size = new System.Drawing.Size(323, 56);
            this.btnTroll.TabIndex = 6;
            this.btnTroll.Text = "Yeâu anh nhieàu laém";
            this.btnTroll.UseVisualStyleBackColor = false;
            this.btnTroll.Visible = false;
            this.btnTroll.Click += new System.EventHandler(this.btnTroll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::I_love_you.Properties.Resources.text_love5a58662677ff8_b96f11f3f3c95e6736e1d96dcf452a56;
            this.ClientSize = new System.Drawing.Size(742, 442);
            this.ControlBox = false;
            this.Controls.Add(this.btnTroll);
            this.Controls.Add(this.btnKhong);
            this.Controls.Add(this.btnCo);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I LOVE YOU - KHOA DANG DUONG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCo;
        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.Button btnTroll;
    }
}


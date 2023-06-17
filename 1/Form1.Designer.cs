namespace _1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.x1 = new System.Windows.Forms.PictureBox();
            this.x2 = new System.Windows.Forms.PictureBox();
            this.x3 = new System.Windows.Forms.PictureBox();
            this.a = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            this.SuspendLayout();
            // 
            // x1
            // 
            this.x1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.x1.Enabled = false;
            this.x1.Location = new System.Drawing.Point(0, 0);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(200, 200);
            this.x1.TabIndex = 0;
            this.x1.TabStop = false;
            this.x1.Click += new System.EventHandler(this.x1_Click);
            // 
            // x2
            // 
            this.x2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.x2.Enabled = false;
            this.x2.Location = new System.Drawing.Point(250, 0);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(200, 200);
            this.x2.TabIndex = 1;
            this.x2.TabStop = false;
            this.x2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // x3
            // 
            this.x3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.x3.Enabled = false;
            this.x3.Location = new System.Drawing.Point(500, 0);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(200, 200);
            this.x3.TabIndex = 2;
            this.x3.TabStop = false;
            this.x3.Click += new System.EventHandler(this.x3_Click);
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.a.Location = new System.Drawing.Point(250, 800);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(200, 200);
            this.a.TabIndex = 3;
            this.a.TabStop = false;
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("新細明體", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(0, 999);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 150);
            this.button1.TabIndex = 4;
            this.button1.Text = "左";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("新細明體", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(500, 999);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 150);
            this.button2.TabIndex = 5;
            this.button2.Text = "右";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Location = new System.Drawing.Point(849, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "時間60s 分數0分";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("新細明體", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(250, 999);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 150);
            this.button3.TabIndex = 7;
            this.button3.Text = "中";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(851, 494);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 77);
            this.button4.TabIndex = 8;
            this.button4.Text = "開始";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 800;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(851, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "最高紀錄0分";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 800;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 800;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(902, 335);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "結束";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(851, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "等級0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(756, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 57);
            this.label4.TabIndex = 12;
            this.label4.Text = "每7分上升1等,最高等級4\r\n每上升1等\r\n時間加10秒,落下頻率提升\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 1161);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.a);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox x1;
        private System.Windows.Forms.PictureBox x2;
        private System.Windows.Forms.PictureBox x3;
        private System.Windows.Forms.PictureBox a;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


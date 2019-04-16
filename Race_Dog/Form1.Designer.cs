namespace Race_Dog
{
    partial class betMoney
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.joeButton = new System.Windows.Forms.RadioButton();
            this.bobButton = new System.Windows.Forms.RadioButton();
            this.alButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.betButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dogNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.raceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // dog1
            // 
            this.dog1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.dog1.Location = new System.Drawing.Point(15, 19);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(47, 45);
            this.dog1.TabIndex = 0;
            this.dog1.TabStop = false;
            this.dog1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dog2
            // 
            this.dog2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.dog2.Location = new System.Drawing.Point(15, 70);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(47, 45);
            this.dog2.TabIndex = 0;
            this.dog2.TabStop = false;
            this.dog2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dog3
            // 
            this.dog3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.dog3.Location = new System.Drawing.Point(15, 121);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(47, 45);
            this.dog3.TabIndex = 0;
            this.dog3.TabStop = false;
            this.dog3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dog4
            // 
            this.dog4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.dog4.Location = new System.Drawing.Point(15, 172);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(47, 45);
            this.dog4.TabIndex = 0;
            this.dog4.TabStop = false;
            this.dog4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // joeButton
            // 
            this.joeButton.AutoSize = true;
            this.joeButton.Location = new System.Drawing.Point(18, 290);
            this.joeButton.Name = "joeButton";
            this.joeButton.Size = new System.Drawing.Size(77, 16);
            this.joeButton.TabIndex = 1;
            this.joeButton.TabStop = true;
            this.joeButton.Text = "joeButton";
            this.joeButton.UseVisualStyleBackColor = true;
            // 
            // bobButton
            // 
            this.bobButton.AutoSize = true;
            this.bobButton.Location = new System.Drawing.Point(18, 312);
            this.bobButton.Name = "bobButton";
            this.bobButton.Size = new System.Drawing.Size(77, 16);
            this.bobButton.TabIndex = 1;
            this.bobButton.TabStop = true;
            this.bobButton.Text = "bobButton";
            this.bobButton.UseVisualStyleBackColor = true;
            // 
            // alButton
            // 
            this.alButton.AutoSize = true;
            this.alButton.Location = new System.Drawing.Point(18, 334);
            this.alButton.Name = "alButton";
            this.alButton.Size = new System.Drawing.Size(71, 16);
            this.alButton.TabIndex = 1;
            this.alButton.TabStop = true;
            this.alButton.Text = "alButton";
            this.alButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Betting Parlor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.minimumBetLabel.Location = new System.Drawing.Point(16, 266);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(110, 12);
            this.minimumBetLabel.TabIndex = 3;
            this.minimumBetLabel.Text = "minimumBetLabel";
            this.minimumBetLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(232, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bets";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(234, 293);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(150, 14);
            this.joeBetLabel.TabIndex = 4;
            this.joeBetLabel.Text = "joeBetLabel";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(234, 314);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(150, 14);
            this.bobBetLabel.TabIndex = 4;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Location = new System.Drawing.Point(234, 334);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(150, 14);
            this.alBetLabel.TabIndex = 4;
            this.alBetLabel.Text = "alBetLabel";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(16, 363);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 12);
            this.name.TabIndex = 5;
            this.name.Text = "Name";
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(51, 359);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(38, 20);
            this.betButton.TabIndex = 6;
            this.betButton.Text = "Bets";
            this.betButton.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(95, 358);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 21);
            this.numericUpDown1.TabIndex = 7;
            // 
            // dogNumber
            // 
            this.dogNumber.Location = new System.Drawing.Point(274, 358);
            this.dogNumber.Name = "dogNumber";
            this.dogNumber.Size = new System.Drawing.Size(48, 21);
            this.dogNumber.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "bucks on dog number";
            // 
            // raceButton
            // 
            this.raceButton.Location = new System.Drawing.Point(463, 278);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(172, 81);
            this.raceButton.TabIndex = 9;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            // 
            // betMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 394);
            this.Controls.Add(this.raceButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dogNumber);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.name);
            this.Controls.Add(this.alBetLabel);
            this.Controls.Add(this.bobBetLabel);
            this.Controls.Add(this.joeBetLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minimumBetLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alButton);
            this.Controls.Add(this.bobButton);
            this.Controls.Add(this.joeButton);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Name = "betMoney";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.betMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.RadioButton joeButton;
        private System.Windows.Forms.RadioButton bobButton;
        private System.Windows.Forms.RadioButton alButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown dogNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button raceButton;
    }
}


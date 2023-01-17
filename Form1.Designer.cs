namespace Discord_AI_Messagebot
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Temperature = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TopP = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.PresencePenalty = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.FrequencyPenalty = new System.Windows.Forms.NumericUpDown();
            this.DiscordTokenText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.aitoken = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Temperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresencePenalty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyPenalty)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "On";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(154, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Off";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(14, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status: Bot Running!";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(12, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(278, 123);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Temperature
            // 
            this.Temperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Temperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Temperature.DecimalPlaces = 2;
            this.Temperature.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Temperature.Location = new System.Drawing.Point(12, 243);
            this.Temperature.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(129, 20);
            this.Temperature.TabIndex = 6;
            this.Temperature.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(41, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Temperature:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(203, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Top P:";
            // 
            // TopP
            // 
            this.TopP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TopP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopP.DecimalPlaces = 2;
            this.TopP.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TopP.Location = new System.Drawing.Point(161, 243);
            this.TopP.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TopP.Name = "TopP";
            this.TopP.Size = new System.Drawing.Size(129, 20);
            this.TopP.TabIndex = 8;
            this.TopP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(32, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Presence Penalty:";
            // 
            // PresencePenalty
            // 
            this.PresencePenalty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PresencePenalty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PresencePenalty.DecimalPlaces = 2;
            this.PresencePenalty.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PresencePenalty.Location = new System.Drawing.Point(12, 291);
            this.PresencePenalty.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.PresencePenalty.Name = "PresencePenalty";
            this.PresencePenalty.Size = new System.Drawing.Size(129, 20);
            this.PresencePenalty.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(176, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Frequency Penalty:";
            // 
            // FrequencyPenalty
            // 
            this.FrequencyPenalty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FrequencyPenalty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FrequencyPenalty.DecimalPlaces = 2;
            this.FrequencyPenalty.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.FrequencyPenalty.Location = new System.Drawing.Point(161, 291);
            this.FrequencyPenalty.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.FrequencyPenalty.Name = "FrequencyPenalty";
            this.FrequencyPenalty.Size = new System.Drawing.Size(129, 20);
            this.FrequencyPenalty.TabIndex = 12;
            // 
            // DiscordTokenText
            // 
            this.DiscordTokenText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DiscordTokenText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiscordTokenText.Location = new System.Drawing.Point(12, 195);
            this.DiscordTokenText.Name = "DiscordTokenText";
            this.DiscordTokenText.Size = new System.Drawing.Size(129, 20);
            this.DiscordTokenText.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(35, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Discord Token:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(183, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "OpenAI Token:";
            // 
            // aitoken
            // 
            this.aitoken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aitoken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aitoken.Location = new System.Drawing.Point(161, 195);
            this.aitoken.Name = "aitoken";
            this.aitoken.Size = new System.Drawing.Size(129, 20);
            this.aitoken.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(304, 359);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.aitoken);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DiscordTokenText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FrequencyPenalty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PresencePenalty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TopP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Temperature);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Temperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresencePenalty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyPenalty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown Temperature;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown TopP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown PresencePenalty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown FrequencyPenalty;
        private System.Windows.Forms.TextBox DiscordTokenText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox aitoken;
    }
}


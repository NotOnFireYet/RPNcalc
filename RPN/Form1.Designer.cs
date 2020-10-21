namespace RPN_feeble_tries
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.input = new System.Windows.Forms.TextBox();
			this.input_label = new System.Windows.Forms.Label();
			this.output = new System.Windows.Forms.TextBox();
			this.output_label = new System.Windows.Forms.Label();
			this.calc_button = new System.Windows.Forms.Button();
			this.clear_button = new System.Windows.Forms.Button();
			this.log_label = new System.Windows.Forms.Label();
			this.act_log = new System.Windows.Forms.Label();
			this.loglist = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// input
			// 
			this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.input.Location = new System.Drawing.Point(46, 66);
			this.input.Name = "input";
			this.input.Size = new System.Drawing.Size(221, 26);
			this.input.TabIndex = 0;
			// 
			// input_label
			// 
			this.input_label.AutoSize = true;
			this.input_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.input_label.Location = new System.Drawing.Point(42, 24);
			this.input_label.Name = "input_label";
			this.input_label.Size = new System.Drawing.Size(100, 24);
			this.input_label.TabIndex = 1;
			this.input_label.Text = "Input here:";
			// 
			// output
			// 
			this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.output.Location = new System.Drawing.Point(46, 154);
			this.output.Name = "output";
			this.output.Size = new System.Drawing.Size(221, 26);
			this.output.TabIndex = 2;
			// 
			// output_label
			// 
			this.output_label.AutoSize = true;
			this.output_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.output_label.Location = new System.Drawing.Point(42, 115);
			this.output_label.Name = "output_label";
			this.output_label.Size = new System.Drawing.Size(115, 24);
			this.output_label.TabIndex = 3;
			this.output_label.Text = "Output here:";
			// 
			// calc_button
			// 
			this.calc_button.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.calc_button.Location = new System.Drawing.Point(277, 66);
			this.calc_button.Name = "calc_button";
			this.calc_button.Size = new System.Drawing.Size(66, 26);
			this.calc_button.TabIndex = 4;
			this.calc_button.Text = "Go!";
			this.calc_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.calc_button.UseVisualStyleBackColor = true;
			this.calc_button.Click += new System.EventHandler(this.calc_button_Click);
			// 
			// clear_button
			// 
			this.clear_button.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.clear_button.Location = new System.Drawing.Point(276, 155);
			this.clear_button.Name = "clear_button";
			this.clear_button.Size = new System.Drawing.Size(65, 26);
			this.clear_button.TabIndex = 5;
			this.clear_button.Text = "Clear";
			this.clear_button.UseVisualStyleBackColor = true;
			this.clear_button.Click += new System.EventHandler(this.button1_Click);
			// 
			// log_label
			// 
			this.log_label.AutoSize = true;
			this.log_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.log_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.log_label.Location = new System.Drawing.Point(46, 217);
			this.log_label.Name = "log_label";
			this.log_label.Size = new System.Drawing.Size(292, 194);
			this.log_label.TabIndex = 7;
			this.log_label.Text = "Log\r\n\r\n\r\n\r\n\r\n\r\n\r\n                                                        \r\n";
			this.log_label.Click += new System.EventHandler(this.label2_Click);
			// 
			// act_log
			// 
			this.act_log.AutoSize = true;
			this.act_log.Location = new System.Drawing.Point(62, 257);
			this.act_log.Name = "act_log";
			this.act_log.Size = new System.Drawing.Size(0, 13);
			this.act_log.TabIndex = 8;
			// 
			// loglist
			// 
			this.loglist.BackColor = System.Drawing.SystemColors.Control;
			this.loglist.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.loglist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.loglist.FormattingEnabled = true;
			this.loglist.ItemHeight = 24;
			this.loglist.Location = new System.Drawing.Point(65, 257);
			this.loglist.Name = "loglist";
			this.loglist.Size = new System.Drawing.Size(250, 120);
			this.loglist.TabIndex = 9;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(386, 450);
			this.Controls.Add(this.loglist);
			this.Controls.Add(this.act_log);
			this.Controls.Add(this.log_label);
			this.Controls.Add(this.clear_button);
			this.Controls.Add(this.calc_button);
			this.Controls.Add(this.output_label);
			this.Controls.Add(this.output);
			this.Controls.Add(this.input_label);
			this.Controls.Add(this.input);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label input_label;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label output_label;
        private System.Windows.Forms.Button calc_button;
		private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label log_label;
        private System.Windows.Forms.Label act_log;
        private System.Windows.Forms.ListBox loglist;
	}
}


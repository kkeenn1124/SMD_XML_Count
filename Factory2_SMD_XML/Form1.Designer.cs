namespace Factory2_SMD_XML
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微軟正黑體", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(141, 40);
            label1.Name = "label1";
            label1.Size = new Size(158, 43);
            label1.TabIndex = 0;
            label1.Text = "PASS：0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微軟正黑體", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(156, 104);
            label2.Name = "label2";
            label2.Size = new Size(143, 43);
            label2.TabIndex = 1;
            label2.Text = "FAIL：0";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微軟正黑體", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(116, 170);
            label3.Name = "label3";
            label3.Size = new Size(183, 43);
            label3.TabIndex = 2;
            label3.Text = "TOTAL：0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("微軟正黑體", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(101, 241);
            label4.Name = "label4";
            label4.Size = new Size(198, 43);
            label4.TabIndex = 3;
            label4.Text = "COUNT：0";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(320, 348);
            button1.Name = "button1";
            button1.Size = new Size(93, 47);
            button1.TabIndex = 4;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("微軟正黑體", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 348);
            label5.Name = "label5";
            label5.Size = new Size(99, 36);
            label5.TabIndex = 6;
            label5.Text = "已停止";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(424, 403);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Factory2_SMD_XML";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
    }
}
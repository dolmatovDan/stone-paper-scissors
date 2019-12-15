namespace WindowsFormsApp1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.reset = new System.Windows.Forms.Button();
            this.paperBtn = new System.Windows.Forms.Button();
            this.scissorsBtn = new System.Windows.Forms.Button();
            this.stoneBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 13);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1048, 186);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Transparent;
            this.reset.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._5a0c6dcf9642de34b6b65cc5;
            this.reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reset.Location = new System.Drawing.Point(276, 209);
            this.reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(552, 123);
            this.reset.TabIndex = 5;
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.Button1_Click);
            // 
            // paperBtn
            // 
            this.paperBtn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.paper_sheet_PNG7234;
            this.paperBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paperBtn.Location = new System.Drawing.Point(731, 340);
            this.paperBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paperBtn.Name = "paperBtn";
            this.paperBtn.Size = new System.Drawing.Size(333, 199);
            this.paperBtn.TabIndex = 4;
            this.paperBtn.UseVisualStyleBackColor = true;
            this.paperBtn.Click += new System.EventHandler(this.PaperBtn_Click);
            // 
            // scissorsBtn
            // 
            this.scissorsBtn.BackColor = System.Drawing.Color.Transparent;
            this.scissorsBtn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.w256h2561339195679Cut256x256;
            this.scissorsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scissorsBtn.Location = new System.Drawing.Point(371, 340);
            this.scissorsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scissorsBtn.Name = "scissorsBtn";
            this.scissorsBtn.Size = new System.Drawing.Size(333, 199);
            this.scissorsBtn.TabIndex = 3;
            this.scissorsBtn.UseVisualStyleBackColor = false;
            this.scissorsBtn.Click += new System.EventHandler(this.ScissorsBtn_Click);
            // 
            // stoneBtn
            // 
            this.stoneBtn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.stone_PNG13558;
            this.stoneBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stoneBtn.Location = new System.Drawing.Point(16, 340);
            this.stoneBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stoneBtn.Name = "stoneBtn";
            this.stoneBtn.Size = new System.Drawing.Size(333, 199);
            this.stoneBtn.TabIndex = 1;
            this.stoneBtn.UseVisualStyleBackColor = true;
            this.stoneBtn.Click += new System.EventHandler(this.StoneBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.paperBtn);
            this.Controls.Add(this.scissorsBtn);
            this.Controls.Add(this.stoneBtn);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button stoneBtn;
        private System.Windows.Forms.Button paperBtn;
        private System.Windows.Forms.Button scissorsBtn;
        private System.Windows.Forms.Button reset;
    }
}


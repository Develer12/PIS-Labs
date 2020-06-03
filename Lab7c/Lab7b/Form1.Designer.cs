namespace Lab7b
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
            this.Get = new System.Windows.Forms.Button();
            this.Post = new System.Windows.Forms.Button();
            this.Put = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Get
            // 
            this.Get.Location = new System.Drawing.Point(35, 390);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(75, 23);
            this.Get.TabIndex = 0;
            this.Get.Text = "Get";
            this.Get.UseVisualStyleBackColor = true;
            this.Get.Click += new System.EventHandler(this.Get_Click);
            // 
            // Post
            // 
            this.Post.Location = new System.Drawing.Point(201, 390);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(75, 23);
            this.Post.TabIndex = 1;
            this.Post.Text = "Post";
            this.Post.UseVisualStyleBackColor = true;
            this.Post.Click += new System.EventHandler(this.Post_Click);
            // 
            // Put
            // 
            this.Put.Location = new System.Drawing.Point(402, 390);
            this.Put.Name = "Put";
            this.Put.Size = new System.Drawing.Size(75, 23);
            this.Put.TabIndex = 2;
            this.Put.Text = "Put";
            this.Put.UseVisualStyleBackColor = true;
            this.Put.Click += new System.EventHandler(this.Put_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(633, 390);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(96, 341);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(152, 22);
            this.id.TabIndex = 4;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(325, 341);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(152, 22);
            this.name.TabIndex = 5;
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(565, 341);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(152, 22);
            this.num.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(35, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(719, 295);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Put);
            this.Controls.Add(this.Post);
            this.Controls.Add(this.Get);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Get;
        private System.Windows.Forms.Button Post;
        private System.Windows.Forms.Button Put;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}


namespace WindowsFormsApp2
{
    partial class Form1
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_class = new System.Windows.Forms.Label();
            this.label_names = new System.Windows.Forms.Label();
            this.textBoxNo = new System.Windows.Forms.TextBox();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.button_delect = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(53, 63);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(41, 12);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "学号：";
            this.label_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_class
            // 
            this.label_class.AutoSize = true;
            this.label_class.Location = new System.Drawing.Point(300, 63);
            this.label_class.Name = "label_class";
            this.label_class.Size = new System.Drawing.Size(41, 12);
            this.label_class.TabIndex = 0;
            this.label_class.Text = "班号：";
            // 
            // label_names
            // 
            this.label_names.AutoSize = true;
            this.label_names.Location = new System.Drawing.Point(53, 131);
            this.label_names.Name = "label_names";
            this.label_names.Size = new System.Drawing.Size(41, 12);
            this.label_names.TabIndex = 0;
            this.label_names.Text = "姓名：";
            this.label_names.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNo
            // 
            this.textBoxNo.Location = new System.Drawing.Point(100, 60);
            this.textBoxNo.Name = "textBoxNo";
            this.textBoxNo.Size = new System.Drawing.Size(100, 21);
            this.textBoxNo.TabIndex = 1;
            this.textBoxNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(347, 60);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(100, 21);
            this.textBoxGrade.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(100, 128);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 21);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_delect
            // 
            this.button_delect.Location = new System.Drawing.Point(55, 296);
            this.button_delect.Name = "button_delect";
            this.button_delect.Size = new System.Drawing.Size(75, 23);
            this.button_delect.TabIndex = 4;
            this.button_delect.Text = "删除";
            this.button_delect.UseVisualStyleBackColor = true;
            this.button_delect.Click += new System.EventHandler(this.button_delect_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(200, 296);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "添加";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(347, 296);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 6;
            this.button_update.Text = "更新";
            this.button_update.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_delect);
            this.Controls.Add(this.textBoxGrade);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxNo);
            this.Controls.Add(this.label_class);
            this.Controls.Add(this.label_names);
            this.Controls.Add(this.label_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_class;
        private System.Windows.Forms.Label label_names;
        private System.Windows.Forms.TextBox textBoxNo;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button button_delect;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_update;
    }
}


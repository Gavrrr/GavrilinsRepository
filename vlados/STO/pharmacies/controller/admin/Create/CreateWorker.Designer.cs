namespace carservice.controller.admin.Create
{
    partial class CreateWorker
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
            this.label3 = new System.Windows.Forms.Label();
            this.Post = new System.Windows.Forms.TextBox();
            this.experience = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Должность";
            // 
            // Post
            // 
            this.Post.Location = new System.Drawing.Point(89, 92);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(121, 20);
            this.Post.TabIndex = 21;
            this.Post.TextChanged += new System.EventHandler(this.Name_TextChanged);
            this.Post.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Post_KeyPress);
            // 
            // experience
            // 
            this.experience.Location = new System.Drawing.Point(89, 56);
            this.experience.Name = "experience";
            this.experience.Size = new System.Drawing.Size(121, 20);
            this.experience.TabIndex = 20;
            this.experience.TextChanged += new System.EventHandler(this.Name_TextChanged);
            this.experience.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.experience_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Стаж";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(89, 19);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(121, 20);
            this.Name.TabIndex = 16;
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            this.Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "ФИО";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Post);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.experience);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(0, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 182);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите данные";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(18, 118);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(192, 40);
            this.save.TabIndex = 23;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(46, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 37);
            this.label6.TabIndex = 26;
            this.label6.Text = "Работник";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CreateWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 247);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            /*this.Name = "CreateWorker";*/
            this.Text = "Form2";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CreateWorker_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Post;
        private System.Windows.Forms.TextBox experience;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label6;
    }
}
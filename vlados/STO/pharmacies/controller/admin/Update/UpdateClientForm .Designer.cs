namespace carservice.controller.admin.Update
{
    partial class UpdateClientForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClientBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.TextBox();
            this.AvtoName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CarNumber = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(62, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 42);
            this.label6.TabIndex = 13;
            this.label6.Text = "Клиенты";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CarNumber);
            this.groupBox1.Controls.Add(this.ClientBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.Number);
            this.groupBox1.Controls.Add(this.AvtoName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 214);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите данные";
            // 
            // ClientBox
            // 
            this.ClientBox.FormattingEnabled = true;
            this.ClientBox.Location = new System.Drawing.Point(137, 27);
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.Size = new System.Drawing.Size(121, 21);
            this.ClientBox.TabIndex = 22;
            this.ClientBox.SelectedIndexChanged += new System.EventHandler(this.ClientBox_SelectedIndexChanged);
            this.ClientBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Клиент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Номер автомобиля";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(14, 161);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(244, 40);
            this.save.TabIndex = 10;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(137, 109);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(121, 20);
            this.Number.TabIndex = 9;
            this.Number.TextChanged += new System.EventHandler(this.name_TextChanged);
            this.Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // AvtoName
            // 
            this.AvtoName.Location = new System.Drawing.Point(137, 80);
            this.AvtoName.Name = "AvtoName";
            this.AvtoName.Size = new System.Drawing.Size(121, 20);
            this.AvtoName.TabIndex = 8;
            this.AvtoName.TextChanged += new System.EventHandler(this.name_TextChanged);
            this.AvtoName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Название автомобиля";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(137, 54);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(121, 20);
            this.Name.TabIndex = 3;
            this.Name.TextChanged += new System.EventHandler(this.name_TextChanged);
            this.Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ФИО";
            // 
            // CarNumber
            // 
            this.CarNumber.Location = new System.Drawing.Point(137, 138);
            this.CarNumber.Mask = "L000LL000";
            this.CarNumber.Name = "CarNumber";
            this.CarNumber.Size = new System.Drawing.Size(121, 20);
            this.CarNumber.TabIndex = 23;
            this.CarNumber.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CarNumber_MaskInputRejected);
            this.CarNumber.TabIndexChanged += new System.EventHandler(this.CarNumber_TabIndexChanged);
            // 
            // UpdateClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 267);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.TextBox AvtoName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ClientBox;
        private System.Windows.Forms.MaskedTextBox CarNumber;
    }
}
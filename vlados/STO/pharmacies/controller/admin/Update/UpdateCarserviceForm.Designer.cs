namespace carservice.controller.admin.Update
{
    partial class UpdateCarserviceForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.carserviceBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.repairBox = new System.Windows.Forms.ComboBox();
            this.WorkerBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.carserviceBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.repairBox);
            this.groupBox1.Controls.Add(this.WorkerBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 157);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите данные";
            // 
            // carserviceBox
            // 
            this.carserviceBox.FormattingEnabled = true;
            this.carserviceBox.Location = new System.Drawing.Point(128, 26);
            this.carserviceBox.Name = "carserviceBox";
            this.carserviceBox.Size = new System.Drawing.Size(106, 21);
            this.carserviceBox.TabIndex = 15;
            this.carserviceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.carserviceBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Услуга";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // repairBox
            // 
            this.repairBox.FormattingEnabled = true;
            this.repairBox.Items.AddRange(new object[] {
            "двигатель",
            "кузов",
            "подвеска",
            "электрика",
            "техническое обслуживание ",
            "шиномонтаж",
            "диагностика"});
            this.repairBox.Location = new System.Drawing.Point(127, 52);
            this.repairBox.Name = "repairBox";
            this.repairBox.Size = new System.Drawing.Size(107, 21);
            this.repairBox.TabIndex = 10;
            this.repairBox.SelectedIndexChanged += new System.EventHandler(this.repairBox_SelectedIndexChanged);
            this.repairBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.carserviceBox_KeyPress);
            // 
            // WorkerBox
            // 
            this.WorkerBox.FormattingEnabled = true;
            this.WorkerBox.Location = new System.Drawing.Point(127, 81);
            this.WorkerBox.Name = "WorkerBox";
            this.WorkerBox.Size = new System.Drawing.Size(107, 21);
            this.WorkerBox.TabIndex = 9;
            this.WorkerBox.SelectedIndexChanged += new System.EventHandler(this.repairBox_SelectedIndexChanged);
            this.WorkerBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.carserviceBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Код работника";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(28, 117);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(193, 32);
            this.save.TabIndex = 5;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ремонтируемый узел";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Услуги";
            // 
            // UpdateCarserviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 208);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateCarserviceForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox repairBox;
        private System.Windows.Forms.ComboBox WorkerBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox carserviceBox;
        private System.Windows.Forms.Label label9;
    }
}
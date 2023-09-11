using System;

namespace carservice.controller.admin.Create
{
    partial class CreateCarserviceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.repairBox = new System.Windows.Forms.ComboBox();
            this.WorkerBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Услуги";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.repairBox);
            this.groupBox1.Controls.Add(this.WorkerBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите данные";
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
            this.repairBox.Location = new System.Drawing.Point(128, 13);
            this.repairBox.Name = "repairBox";
            this.repairBox.Size = new System.Drawing.Size(107, 21);
            this.repairBox.TabIndex = 10;
            this.repairBox.SelectedIndexChanged += new System.EventHandler(this.repairBox_SelectedIndexChanged);
            this.repairBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.repairBox_KeyPress);
            // 
            // WorkerBox
            // 
            this.WorkerBox.FormattingEnabled = true;
            this.WorkerBox.Location = new System.Drawing.Point(128, 42);
            this.WorkerBox.Name = "WorkerBox";
            this.WorkerBox.Size = new System.Drawing.Size(107, 21);
            this.WorkerBox.TabIndex = 9;
            this.WorkerBox.SelectedIndexChanged += new System.EventHandler(this.repairBox_SelectedIndexChanged);
            this.WorkerBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WorkerBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Код работника";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(9, 69);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(226, 32);
            this.save.TabIndex = 5;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ремонтируемый узел";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CreateCarserviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 167);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "CreateCarserviceForm";
            this.Text = "CreateCarservicesForm";
            this.Load += new System.EventHandler(this.CreateCarservicesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ordersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox WorkerBox;
        private System.Windows.Forms.ComboBox repairBox;
    }
}
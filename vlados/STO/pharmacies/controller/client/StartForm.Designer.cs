﻿namespace carservice.controller.boyer
{
    partial class StartForm
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
            this.wellcome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WhereCanBuyCost = new System.Windows.Forms.Button();
            this.WhereCanBuy = new System.Windows.Forms.Button();
            this.ordersBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wellcome
            // 
            this.wellcome.AutoSize = true;
            this.wellcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wellcome.ForeColor = System.Drawing.Color.Black;
            this.wellcome.Location = new System.Drawing.Point(47, 7);
            this.wellcome.Name = "wellcome";
            this.wellcome.Size = new System.Drawing.Size(287, 33);
            this.wellcome.TabIndex = 1;
            this.wellcome.Text = "Добро пожаловать";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WhereCanBuyCost);
            this.groupBox1.Controls.Add(this.WhereCanBuy);
            this.groupBox1.Location = new System.Drawing.Point(56, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 121);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбирите действие";
            // 
            // WhereCanBuyCost
            // 
            this.WhereCanBuyCost.Location = new System.Drawing.Point(7, 70);
            this.WhereCanBuyCost.Name = "WhereCanBuyCost";
            this.WhereCanBuyCost.Size = new System.Drawing.Size(268, 44);
            this.WhereCanBuyCost.TabIndex = 1;
            this.WhereCanBuyCost.Text = "Посмотреть сроки";
            this.WhereCanBuyCost.UseVisualStyleBackColor = true;
            // 
            // WhereCanBuy
            // 
            this.WhereCanBuy.Location = new System.Drawing.Point(7, 20);
            this.WhereCanBuy.Name = "WhereCanBuy";
            this.WhereCanBuy.Size = new System.Drawing.Size(268, 44);
            this.WhereCanBuy.TabIndex = 0;
            this.WhereCanBuy.Text = "Посмотреть перечень работ";
            this.WhereCanBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.WhereCanBuy.UseVisualStyleBackColor = true;
            // 
            // ordersBox
            // 
            this.ordersBox.FormattingEnabled = true;
            this.ordersBox.Location = new System.Drawing.Point(172, 44);
            this.ordersBox.Name = "ordersBox";
            this.ordersBox.Size = new System.Drawing.Size(165, 21);
            this.ordersBox.TabIndex = 3;
            this.ordersBox.SelectedIndexChanged += new System.EventHandler(this.ordersBox_SelectedIndexChanged);
            this.ordersBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ordersBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выбирите машину";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ordersBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wellcome);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wellcome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button WhereCanBuyCost;
        private System.Windows.Forms.Button WhereCanBuy;
        private System.Windows.Forms.ComboBox ordersBox;
        private System.Windows.Forms.Label label1;
    }
}
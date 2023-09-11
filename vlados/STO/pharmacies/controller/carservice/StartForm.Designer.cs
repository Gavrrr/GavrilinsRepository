namespace carservice.controller.pharmacist
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
            this.label1 = new System.Windows.Forms.Label();
            this.ordersBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WhereCanBuyCost = new System.Windows.Forms.Button();
            this.WhereCanBuy = new System.Windows.Forms.Button();
            this.wellcome = new System.Windows.Forms.Label();
            this.PostingThisMonth = new System.Windows.Forms.Button();
            this.avtoButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.avtoBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.carservicesBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выбирите лекарство";
            // 
            // ordersBox
            // 
            this.ordersBox.FormattingEnabled = true;
            this.ordersBox.Location = new System.Drawing.Point(131, 47);
            this.ordersBox.Name = "ordersBox";
            this.ordersBox.Size = new System.Drawing.Size(165, 21);
            this.ordersBox.TabIndex = 7;
            this.ordersBox.SelectedIndexChanged += new System.EventHandler(this.ordersBox_SelectedIndexChanged);
            this.ordersBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ordersBox_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WhereCanBuyCost);
            this.groupBox1.Controls.Add(this.WhereCanBuy);
            this.groupBox1.Location = new System.Drawing.Point(15, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 127);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбирите действие";
            // 
            // WhereCanBuyCost
            // 
            this.WhereCanBuyCost.Location = new System.Drawing.Point(7, 70);
            this.WhereCanBuyCost.Name = "WhereCanBuyCost";
            this.WhereCanBuyCost.Size = new System.Drawing.Size(268, 44);
            this.WhereCanBuyCost.TabIndex = 1;
            this.WhereCanBuyCost.Text = "По названию лекарства информацию о том, где можно купить данное лекарство дешевле" +
    "";
            this.WhereCanBuyCost.UseVisualStyleBackColor = true;
            // 
            // WhereCanBuy
            // 
            this.WhereCanBuy.Location = new System.Drawing.Point(7, 20);
            this.WhereCanBuy.Name = "WhereCanBuy";
            this.WhereCanBuy.Size = new System.Drawing.Size(268, 44);
            this.WhereCanBuy.TabIndex = 0;
            this.WhereCanBuy.Text = "По названию лекарства определить, где его можно купить";
            this.WhereCanBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.WhereCanBuy.UseVisualStyleBackColor = true;
            // 
            // wellcome
            // 
            this.wellcome.AutoSize = true;
            this.wellcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wellcome.ForeColor = System.Drawing.Color.Black;
            this.wellcome.Location = new System.Drawing.Point(58, 9);
            this.wellcome.Name = "wellcome";
            this.wellcome.Size = new System.Drawing.Size(287, 33);
            this.wellcome.TabIndex = 5;
            this.wellcome.Text = "Добро пожаловать";
            // 
            // PostingThisMonth
            // 
            this.PostingThisMonth.Location = new System.Drawing.Point(7, 20);
            this.PostingThisMonth.Name = "PostingThisMonth";
            this.PostingThisMonth.Size = new System.Drawing.Size(275, 44);
            this.PostingThisMonth.TabIndex = 2;
            this.PostingThisMonth.Text = "Какие лекарства определённой аптеки подлежат списанию в данном месяце";
            this.PostingThisMonth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PostingThisMonth.UseVisualStyleBackColor = true;
            // 
            // avtoButton
            // 
            this.avtoButton.Location = new System.Drawing.Point(7, 19);
            this.avtoButton.Name = "avtoButton";
            this.avtoButton.Size = new System.Drawing.Size(268, 44);
            this.avtoButton.TabIndex = 3;
            this.avtoButton.Text = "По изготовителю перечень лекарств, находящихся в данной аптеке";
            this.avtoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.avtoButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.avtoBox);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.PostingThisMonth);
            this.groupBox2.Location = new System.Drawing.Point(302, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 171);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбирите действие";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Выбирите фирму";
            // 
            // avtoBox
            // 
            this.avtoBox.FormattingEnabled = true;
            this.avtoBox.Location = new System.Drawing.Point(106, 69);
            this.avtoBox.Name = "avtoBox";
            this.avtoBox.Size = new System.Drawing.Size(176, 21);
            this.avtoBox.TabIndex = 11;
            this.avtoBox.SelectedIndexChanged += new System.EventHandler(this.avtoBox_SelectedIndexChanged);
            this.avtoBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.avtoBox_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.avtoButton);
            this.groupBox3.Location = new System.Drawing.Point(7, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 71);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выбирите действие";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Выбирите аптеку";
            // 
            // carservicesBox
            // 
            this.carservicesBox.FormattingEnabled = true;
            this.carservicesBox.Location = new System.Drawing.Point(402, 47);
            this.carservicesBox.Name = "carservicesBox";
            this.carservicesBox.Size = new System.Drawing.Size(175, 21);
            this.carservicesBox.TabIndex = 9;
            this.carservicesBox.SelectedIndexChanged += new System.EventHandler(this.carservicesBox_SelectedIndexChanged);
            this.carservicesBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.carservicesBox_KeyPress);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 399);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.carservicesBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ordersBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wellcome);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ordersBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button WhereCanBuyCost;
        private System.Windows.Forms.Button WhereCanBuy;
        private System.Windows.Forms.Label wellcome;
        private System.Windows.Forms.Button avtoButton;
        private System.Windows.Forms.Button PostingThisMonth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox carservicesBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox avtoBox;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
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
            this.addTour = new System.Windows.Forms.Button();
            this.listTour = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listExc = new System.Windows.Forms.ListBox();
            this.addExc = new System.Windows.Forms.Button();
            this.listInfo = new System.Windows.Forms.ListBox();
            this.infoText = new System.Windows.Forms.RichTextBox();
            this.addEx = new System.Windows.Forms.Button();
            this.deleteEx = new System.Windows.Forms.Button();
            this.redactEx = new System.Windows.Forms.Button();
            this.orgInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTour
            // 
            this.addTour.Location = new System.Drawing.Point(6, 172);
            this.addTour.Name = "addTour";
            this.addTour.Size = new System.Drawing.Size(155, 23);
            this.addTour.TabIndex = 0;
            this.addTour.Text = "Add";
            this.addTour.UseVisualStyleBackColor = true;
            this.addTour.Click += new System.EventHandler(this.addTour_Click);
            // 
            // listTour
            // 
            this.listTour.FormattingEnabled = true;
            this.listTour.Location = new System.Drawing.Point(6, 19);
            this.listTour.Name = "listTour";
            this.listTour.Size = new System.Drawing.Size(250, 147);
            this.listTour.TabIndex = 1;
            this.listTour.SelectedValueChanged += new System.EventHandler(this.listTour_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, -24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Інформація про тур";
            // 
            // listExc
            // 
            this.listExc.FormattingEnabled = true;
            this.listExc.Location = new System.Drawing.Point(16, 41);
            this.listExc.Name = "listExc";
            this.listExc.Size = new System.Drawing.Size(250, 147);
            this.listExc.TabIndex = 11;
            this.listExc.SelectedIndexChanged += new System.EventHandler(this.listExc_SelectedIndexChanged);
            // 
            // addExc
            // 
            this.addExc.Location = new System.Drawing.Point(16, 195);
            this.addExc.Name = "addExc";
            this.addExc.Size = new System.Drawing.Size(155, 23);
            this.addExc.TabIndex = 13;
            this.addExc.Text = "Add";
            this.addExc.UseVisualStyleBackColor = true;
            this.addExc.Click += new System.EventHandler(this.addExc_Click);
            // 
            // listInfo
            // 
            this.listInfo.FormattingEnabled = true;
            this.listInfo.Location = new System.Drawing.Point(6, 36);
            this.listInfo.Name = "listInfo";
            this.listInfo.Size = new System.Drawing.Size(331, 147);
            this.listInfo.TabIndex = 19;
            // 
            // infoText
            // 
            this.infoText.Location = new System.Drawing.Point(22, 21);
            this.infoText.Name = "infoText";
            this.infoText.ReadOnly = true;
            this.infoText.Size = new System.Drawing.Size(331, 147);
            this.infoText.TabIndex = 21;
            this.infoText.Text = "";
            // 
            // addEx
            // 
            this.addEx.Location = new System.Drawing.Point(6, 189);
            this.addEx.Name = "addEx";
            this.addEx.Size = new System.Drawing.Size(75, 23);
            this.addEx.TabIndex = 22;
            this.addEx.Text = "Add";
            this.addEx.UseVisualStyleBackColor = true;
            this.addEx.Click += new System.EventHandler(this.addEx_Click);
            // 
            // deleteEx
            // 
            this.deleteEx.Location = new System.Drawing.Point(88, 189);
            this.deleteEx.Name = "deleteEx";
            this.deleteEx.Size = new System.Drawing.Size(75, 23);
            this.deleteEx.TabIndex = 23;
            this.deleteEx.Text = "Delete";
            this.deleteEx.UseVisualStyleBackColor = true;
            this.deleteEx.Click += new System.EventHandler(this.deleteEx_Click);
            // 
            // redactEx
            // 
            this.redactEx.Location = new System.Drawing.Point(169, 189);
            this.redactEx.Name = "redactEx";
            this.redactEx.Size = new System.Drawing.Size(75, 23);
            this.redactEx.TabIndex = 24;
            this.redactEx.Text = "Edit";
            this.redactEx.UseVisualStyleBackColor = true;
            this.redactEx.Click += new System.EventHandler(this.redactEx_Click);
            // 
            // orgInfo
            // 
            this.orgInfo.Location = new System.Drawing.Point(178, 195);
            this.orgInfo.Name = "orgInfo";
            this.orgInfo.Size = new System.Drawing.Size(88, 23);
            this.orgInfo.TabIndex = 25;
            this.orgInfo.Text = "Participants";
            this.orgInfo.UseVisualStyleBackColor = true;
            this.orgInfo.Click += new System.EventHandler(this.orgInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listExc);
            this.groupBox1.Controls.Add(this.orgInfo);
            this.groupBox1.Controls.Add(this.addExc);
            this.groupBox1.Location = new System.Drawing.Point(18, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 231);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список виступів які будуть записані в змагання";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listTour);
            this.groupBox2.Controls.Add(this.addTour);
            this.groupBox2.Location = new System.Drawing.Point(12, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 203);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список змаганнь";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listInfo);
            this.groupBox3.Controls.Add(this.addEx);
            this.groupBox3.Controls.Add(this.redactEx);
            this.groupBox3.Controls.Add(this.deleteEx);
            this.groupBox3.Location = new System.Drawing.Point(326, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 223);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Редагувати змагання";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.infoText);
            this.groupBox4.Location = new System.Drawing.Point(316, 296);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(366, 183);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Додаткова інформація";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 502);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTour;
        private System.Windows.Forms.ListBox listTour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listExc;
        private System.Windows.Forms.Button addExc;
        private System.Windows.Forms.ListBox listInfo;
        private System.Windows.Forms.RichTextBox infoText;
        private System.Windows.Forms.Button addEx;
        private System.Windows.Forms.Button deleteEx;
        private System.Windows.Forms.Button redactEx;
        private System.Windows.Forms.Button orgInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}


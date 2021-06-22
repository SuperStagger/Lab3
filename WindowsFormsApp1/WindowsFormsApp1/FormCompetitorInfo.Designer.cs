namespace WindowsFormsApp1
{
    partial class FormCompetitorInfo
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
            this.orgList = new System.Windows.Forms.ListBox();
            this.addOrg = new System.Windows.Forms.Button();
            this.delOrg = new System.Windows.Forms.Button();
            this.editOrg = new System.Windows.Forms.Button();
            this.orgName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.orgSurname = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orgList
            // 
            this.orgList.FormattingEnabled = true;
            this.orgList.Location = new System.Drawing.Point(34, 12);
            this.orgList.Name = "orgList";
            this.orgList.Size = new System.Drawing.Size(198, 199);
            this.orgList.TabIndex = 0;
            // 
            // addOrg
            // 
            this.addOrg.Location = new System.Drawing.Point(28, 414);
            this.addOrg.Name = "addOrg";
            this.addOrg.Size = new System.Drawing.Size(55, 23);
            this.addOrg.TabIndex = 1;
            this.addOrg.Text = "Додати";
            this.addOrg.UseVisualStyleBackColor = true;
            this.addOrg.Click += new System.EventHandler(this.addOrg_Click);
            // 
            // delOrg
            // 
            this.delOrg.Location = new System.Drawing.Point(89, 414);
            this.delOrg.Name = "delOrg";
            this.delOrg.Size = new System.Drawing.Size(64, 23);
            this.delOrg.TabIndex = 2;
            this.delOrg.Text = "Видалити";
            this.delOrg.UseVisualStyleBackColor = true;
            this.delOrg.Click += new System.EventHandler(this.delOrg_Click);
            // 
            // editOrg
            // 
            this.editOrg.Location = new System.Drawing.Point(159, 414);
            this.editOrg.Name = "editOrg";
            this.editOrg.Size = new System.Drawing.Size(73, 23);
            this.editOrg.TabIndex = 3;
            this.editOrg.Text = "Редагувати";
            this.editOrg.UseVisualStyleBackColor = true;
            this.editOrg.Click += new System.EventHandler(this.editOrg_Click);
            // 
            // orgName
            // 
            this.orgName.Location = new System.Drawing.Point(34, 242);
            this.orgName.Name = "orgName";
            this.orgName.Size = new System.Drawing.Size(199, 20);
            this.orgName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ім\'я учасник";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(6, 453);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(123, 23);
            this.save.TabIndex = 21;
            this.save.Text = "Зберегти і закрити";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(135, 453);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(122, 23);
            this.cancel.TabIndex = 25;
            this.cancel.Text = "Скасувати і закрити";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Прізвище учасника";
            // 
            // orgSurname
            // 
            this.orgSurname.Location = new System.Drawing.Point(34, 284);
            this.orgSurname.Name = "orgSurname";
            this.orgSurname.Size = new System.Drawing.Size(199, 20);
            this.orgSurname.TabIndex = 26;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 336);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Дата народження учасника";
            // 
            // FormCompetitorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 496);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orgSurname);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orgName);
            this.Controls.Add(this.editOrg);
            this.Controls.Add(this.delOrg);
            this.Controls.Add(this.addOrg);
            this.Controls.Add(this.orgList);
            this.Name = "FormCompetitorInfo";
            this.Text = "OrgInfo";
            this.Load += new System.EventHandler(this.FormCompetitorInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox orgList;
        private System.Windows.Forms.Button addOrg;
        private System.Windows.Forms.Button delOrg;
        private System.Windows.Forms.Button editOrg;
        private System.Windows.Forms.TextBox orgName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orgSurname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
    }
}
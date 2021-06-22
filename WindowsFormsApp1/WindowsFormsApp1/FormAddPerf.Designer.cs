namespace WindowsFormsApp1
{
    partial class FormAddPerf
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
            this.formExc = new System.Windows.Forms.ComboBox();
            this.addExc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orgExc = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // formExc
            // 
            this.formExc.AutoCompleteCustomSource.AddRange(new string[] {
            "Автобусна екскурсія",
            "Прогулянка пішки",
            "Кінна прогулянка",
            "Рейсовим транспортом"});
            this.formExc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formExc.FormattingEnabled = true;
            this.formExc.Items.AddRange(new object[] {
            "Індивідуальне",
            "Командне"});
            this.formExc.Location = new System.Drawing.Point(88, 69);
            this.formExc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.formExc.Name = "formExc";
            this.formExc.Size = new System.Drawing.Size(205, 24);
            this.formExc.TabIndex = 23;
            // 
            // addExc
            // 
            this.addExc.Location = new System.Drawing.Point(16, 252);
            this.addExc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addExc.Name = "addExc";
            this.addExc.Size = new System.Drawing.Size(163, 28);
            this.addExc.TabIndex = 20;
            this.addExc.Text = "Зберегти і закрити";
            this.addExc.UseVisualStyleBackColor = true;
            this.addExc.Click += new System.EventHandler(this.addExc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Тип змагань";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Учасник";
            // 
            // orgExc
            // 
            this.orgExc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orgExc.FormattingEnabled = true;
            this.orgExc.Location = new System.Drawing.Point(88, 118);
            this.orgExc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orgExc.Name = "orgExc";
            this.orgExc.Size = new System.Drawing.Size(205, 24);
            this.orgExc.TabIndex = 17;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(203, 252);
            this.cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(163, 28);
            this.cancel.TabIndex = 24;
            this.cancel.Text = "Скасувати і закрити";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // FormAddExc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 295);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.formExc);
            this.Controls.Add(this.addExc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orgExc);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAddExc";
            this.Text = "FormAddExc";
            this.Load += new System.EventHandler(this.FormAddExc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox formExc;
        private System.Windows.Forms.Button addExc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox orgExc;
        private System.Windows.Forms.Button cancel;
    }
}
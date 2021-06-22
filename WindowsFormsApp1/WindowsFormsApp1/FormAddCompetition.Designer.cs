namespace WindowsFormsApp1
{
    partial class FormAddCompetition
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
            this.dateTour = new System.Windows.Forms.DateTimePicker();
            this.cancel = new System.Windows.Forms.Button();
            this.addExc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Дата початку";
            // 
            // dateTour
            // 
            this.dateTour.Location = new System.Drawing.Point(70, 42);
            this.dateTour.Name = "dateTour";
            this.dateTour.Size = new System.Drawing.Size(155, 20);
            this.dateTour.TabIndex = 5;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(149, 89);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(122, 23);
            this.cancel.TabIndex = 26;
            this.cancel.Text = "Скасувати і закрити";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // addExc
            // 
            this.addExc.Location = new System.Drawing.Point(9, 89);
            this.addExc.Name = "addExc";
            this.addExc.Size = new System.Drawing.Size(122, 23);
            this.addExc.TabIndex = 25;
            this.addExc.Text = "Зберегти і закрити";
            this.addExc.UseVisualStyleBackColor = true;
            this.addExc.Click += new System.EventHandler(this.addExc_Click);
            // 
            // FormAddCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 121);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.addExc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTour);
            this.Name = "FormAddCompetition";
            this.Text = "FormAddTour";
            this.Load += new System.EventHandler(this.FormAddCompetition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTour;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button addExc;
    }
}
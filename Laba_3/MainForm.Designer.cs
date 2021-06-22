namespace Laba_3
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.contentListBox = new System.Windows.Forms.ListBox();
            this.addAnimalButton = new System.Windows.Forms.Button();
            this.editListButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveRoomsButton = new System.Windows.Forms.Button();
            this.openRoomsButton = new System.Windows.Forms.Button();
            this.detailViewButton = new System.Windows.Forms.Button();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contentListBox
            // 
            this.contentListBox.FormattingEnabled = true;
            this.contentListBox.Location = new System.Drawing.Point(273, 39);
            this.contentListBox.Name = "contentListBox";
            this.contentListBox.Size = new System.Drawing.Size(271, 186);
            this.contentListBox.TabIndex = 0;
            // 
            // addAnimalButton
            // 
            this.addAnimalButton.Location = new System.Drawing.Point(13, 245);
            this.addAnimalButton.Name = "addAnimalButton";
            this.addAnimalButton.Size = new System.Drawing.Size(154, 51);
            this.addAnimalButton.TabIndex = 1;
            this.addAnimalButton.Text = "Add_Animal";
            this.addAnimalButton.UseVisualStyleBackColor = true;
            this.addAnimalButton.Click += new System.EventHandler(this.Add_Animal_Click);
            // 
            // editListButton
            // 
            this.editListButton.Location = new System.Drawing.Point(390, 245);
            this.editListButton.Name = "editListButton";
            this.editListButton.Size = new System.Drawing.Size(154, 51);
            this.editListButton.TabIndex = 2;
            this.editListButton.Text = "Edit_Content";
            this.editListButton.UseVisualStyleBackColor = true;
            this.editListButton.Click += new System.EventHandler(this.editListButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rooms";
            // 
            // addRoomButton
            // 
            this.addRoomButton.Location = new System.Drawing.Point(200, 245);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(154, 51);
            this.addRoomButton.TabIndex = 5;
            this.addRoomButton.Text = "Add_Room";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // roomsListBox
            // 
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(15, 39);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(252, 186);
            this.roomsListBox.TabIndex = 6;
            this.roomsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Content";
            // 
            // saveRoomsButton
            // 
            this.saveRoomsButton.Location = new System.Drawing.Point(13, 305);
            this.saveRoomsButton.Name = "saveRoomsButton";
            this.saveRoomsButton.Size = new System.Drawing.Size(154, 51);
            this.saveRoomsButton.TabIndex = 8;
            this.saveRoomsButton.Text = "Save";
            this.saveRoomsButton.UseVisualStyleBackColor = true;
            this.saveRoomsButton.Click += new System.EventHandler(this.saveRoomsButton_Click);
            // 
            // openRoomsButton
            // 
            this.openRoomsButton.Location = new System.Drawing.Point(200, 302);
            this.openRoomsButton.Name = "openRoomsButton";
            this.openRoomsButton.Size = new System.Drawing.Size(154, 51);
            this.openRoomsButton.TabIndex = 9;
            this.openRoomsButton.Text = "Open";
            this.openRoomsButton.UseVisualStyleBackColor = true;
            this.openRoomsButton.Click += new System.EventHandler(this.openRoomsButton_Click);
            // 
            // detailViewButton
            // 
            this.detailViewButton.Location = new System.Drawing.Point(390, 302);
            this.detailViewButton.Name = "detailViewButton";
            this.detailViewButton.Size = new System.Drawing.Size(154, 51);
            this.detailViewButton.TabIndex = 10;
            this.detailViewButton.Text = "Detail";
            this.detailViewButton.UseVisualStyleBackColor = true;
            this.detailViewButton.Click += new System.EventHandler(this.detailViewButton_Click);
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(Laba_3.Room);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 368);
            this.Controls.Add(this.detailViewButton);
            this.Controls.Add(this.openRoomsButton);
            this.Controls.Add(this.saveRoomsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomsListBox);
            this.Controls.Add(this.addRoomButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editListButton);
            this.Controls.Add(this.addAnimalButton);
            this.Controls.Add(this.contentListBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox contentListBox;
        private System.Windows.Forms.Button addAnimalButton;
        private System.Windows.Forms.Button editListButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveRoomsButton;
        private System.Windows.Forms.Button openRoomsButton;
        private System.Windows.Forms.Button detailViewButton;
    }
}


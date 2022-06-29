namespace BTN
{
    partial class QLSV
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
            this.labelheader = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDestroy = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comBoxSex = new System.Windows.Forms.ComboBox();
            this.comBoxBirthDate = new System.Windows.Forms.ComboBox();
            this.tBoxDepartment = new System.Windows.Forms.TextBox();
            this.tBoxInputName = new System.Windows.Forms.TextBox();
            this.tBoxInputFName = new System.Windows.Forms.TextBox();
            this.tBoxInputMSSV = new System.Windows.Forms.TextBox();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelBirthdate = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMSSV = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelheader
            // 
            this.labelheader.AutoSize = true;
            this.labelheader.Location = new System.Drawing.Point(267, 22);
            this.labelheader.Name = "labelheader";
            this.labelheader.Size = new System.Drawing.Size(241, 16);
            this.labelheader.TabIndex = 0;
            this.labelheader.Text = "CHƯƠNG TRÌNH QUẢN LÝ SINH VIÊN";
            this.labelheader.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnDestroy);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnFix);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(39, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(727, 57);
            this.panel3.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(630, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnDestroy
            // 
            this.btnDestroy.Location = new System.Drawing.Point(538, 21);
            this.btnDestroy.Name = "btnDestroy";
            this.btnDestroy.Size = new System.Drawing.Size(75, 23);
            this.btnDestroy.TabIndex = 4;
            this.btnDestroy.Text = "Hủy";
            this.btnDestroy.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(315, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(208, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnFix
            // 
            this.btnFix.Location = new System.Drawing.Point(111, 21);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(75, 23);
            this.btnFix.TabIndex = 1;
            this.btnFix.Text = "Sửa";
            this.btnFix.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comBoxSex);
            this.panel2.Controls.Add(this.comBoxBirthDate);
            this.panel2.Controls.Add(this.tBoxDepartment);
            this.panel2.Controls.Add(this.labelFName);
            this.panel2.Controls.Add(this.tBoxInputName);
            this.panel2.Controls.Add(this.tBoxInputFName);
            this.panel2.Controls.Add(this.tBoxInputMSSV);
            this.panel2.Controls.Add(this.labelDepartment);
            this.panel2.Controls.Add(this.labelSex);
            this.panel2.Controls.Add(this.labelBirthdate);
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Controls.Add(this.labelMSSV);
            this.panel2.Location = new System.Drawing.Point(39, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 81);
            this.panel2.TabIndex = 5;
            // 
            // comBoxSex
            // 
            this.comBoxSex.FormattingEnabled = true;
            this.comBoxSex.Location = new System.Drawing.Point(318, 46);
            this.comBoxSex.Name = "comBoxSex";
            this.comBoxSex.Size = new System.Drawing.Size(134, 24);
            this.comBoxSex.TabIndex = 11;
            // 
            // comBoxBirthDate
            // 
            this.comBoxBirthDate.FormattingEnabled = true;
            this.comBoxBirthDate.Location = new System.Drawing.Point(92, 51);
            this.comBoxBirthDate.Name = "comBoxBirthDate";
            this.comBoxBirthDate.Size = new System.Drawing.Size(137, 24);
            this.comBoxBirthDate.TabIndex = 7;
            this.comBoxBirthDate.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tBoxDepartment
            // 
            this.tBoxDepartment.Location = new System.Drawing.Point(586, 51);
            this.tBoxDepartment.Name = "tBoxDepartment";
            this.tBoxDepartment.Size = new System.Drawing.Size(137, 22);
            this.tBoxDepartment.TabIndex = 10;
            // 
            // tBoxInputName
            // 
            this.tBoxInputName.Location = new System.Drawing.Point(586, 15);
            this.tBoxInputName.Name = "tBoxInputName";
            this.tBoxInputName.Size = new System.Drawing.Size(137, 22);
            this.tBoxInputName.TabIndex = 9;
            // 
            // tBoxInputFName
            // 
            this.tBoxInputFName.Location = new System.Drawing.Point(315, 18);
            this.tBoxInputFName.Name = "tBoxInputFName";
            this.tBoxInputFName.Size = new System.Drawing.Size(137, 22);
            this.tBoxInputFName.TabIndex = 8;
            // 
            // tBoxInputMSSV
            // 
            this.tBoxInputMSSV.Location = new System.Drawing.Point(92, 15);
            this.tBoxInputMSSV.Name = "tBoxInputMSSV";
            this.tBoxInputMSSV.Size = new System.Drawing.Size(137, 22);
            this.tBoxInputMSSV.TabIndex = 7;
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(520, 54);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(60, 16);
            this.labelDepartment.TabIndex = 6;
            this.labelDepartment.Text = "Mã Khoa";
            this.labelDepartment.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(258, 54);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(54, 16);
            this.labelSex.TabIndex = 5;
            this.labelSex.Text = "Giới tính";
            // 
            // labelBirthdate
            // 
            this.labelBirthdate.AutoSize = true;
            this.labelBirthdate.Location = new System.Drawing.Point(14, 54);
            this.labelBirthdate.Name = "labelBirthdate";
            this.labelBirthdate.Size = new System.Drawing.Size(67, 16);
            this.labelBirthdate.TabIndex = 2;
            this.labelBirthdate.Text = "Ngày sinh";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(520, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 16);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Tên SV";
            // 
            // labelMSSV
            // 
            this.labelMSSV.AutoSize = true;
            this.labelMSSV.Location = new System.Drawing.Point(14, 18);
            this.labelMSSV.Name = "labelMSSV";
            this.labelMSSV.Size = new System.Drawing.Size(47, 16);
            this.labelMSSV.TabIndex = 3;
            this.labelMSSV.Text = "Mã SV";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(258, 18);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(46, 16);
            this.labelFName.TabIndex = 1;
            this.labelFName.Text = "Họ SV";
            // 
            // QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelheader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "QLSV";
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ SINH VIÊN";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelheader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelBirthdate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMSSV;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDestroy;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comBoxBirthDate;
        private System.Windows.Forms.TextBox tBoxDepartment;
        private System.Windows.Forms.TextBox tBoxInputName;
        private System.Windows.Forms.TextBox tBoxInputFName;
        private System.Windows.Forms.TextBox tBoxInputMSSV;
        private System.Windows.Forms.ComboBox comBoxSex;
    }
}
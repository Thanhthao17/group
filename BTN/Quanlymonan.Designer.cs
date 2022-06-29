namespace BTN
{
    partial class Quanlymonan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxSeclected = new System.Windows.Forms.TextBox();
            this.textBoxSelect = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelFood = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteMenu = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInputFood = new System.Windows.Forms.Button();
            this.labelNameFood = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxSeclected);
            this.panel1.Controls.Add(this.textBoxSelect);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnInputFood);
            this.panel1.Controls.Add(this.labelNameFood);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 460);
            this.panel1.TabIndex = 0;
            // 
            // textBoxSeclected
            // 
            this.textBoxSeclected.Location = new System.Drawing.Point(523, 110);
            this.textBoxSeclected.Multiline = true;
            this.textBoxSeclected.Name = "textBoxSeclected";
            this.textBoxSeclected.Size = new System.Drawing.Size(167, 204);
            this.textBoxSeclected.TabIndex = 9;
            this.textBoxSeclected.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxSelect
            // 
            this.textBoxSelect.Location = new System.Drawing.Point(74, 110);
            this.textBoxSelect.Multiline = true;
            this.textBoxSelect.Name = "textBoxSelect";
            this.textBoxSelect.Size = new System.Drawing.Size(167, 204);
            this.textBoxSelect.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelFood);
            this.panel4.Controls.Add(this.labelName);
            this.panel4.Location = new System.Drawing.Point(49, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(672, 50);
            this.panel4.TabIndex = 7;
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.Location = new System.Drawing.Point(519, 14);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(84, 16);
            this.labelFood.TabIndex = 7;
            this.labelFood.Text = "Món đã chọn";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(49, 14);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(78, 16);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Tên món ăn";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDeleteMenu);
            this.panel3.Controls.Add(this.btnFinish);
            this.panel3.Controls.Add(this.btnDeleteFood);
            this.panel3.Location = new System.Drawing.Point(49, 335);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(672, 76);
            this.panel3.TabIndex = 5;
            // 
            // btnDeleteMenu
            // 
            this.btnDeleteMenu.Location = new System.Drawing.Point(42, 33);
            this.btnDeleteMenu.Name = "btnDeleteMenu";
            this.btnDeleteMenu.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteMenu.TabIndex = 9;
            this.btnDeleteMenu.Text = "Xóa thực đơn";
            this.btnDeleteMenu.UseVisualStyleBackColor = true;
            this.btnDeleteMenu.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(282, 33);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 7;
            this.btnFinish.Text = "Kết thúc";
            this.btnFinish.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(501, 33);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(111, 23);
            this.btnDeleteFood.TabIndex = 8;
            this.btnDeleteFood.Text = "Xóa món chọn";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(285, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 204);
            this.panel2.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(60, 162);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "<<";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(60, 119);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "<";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(60, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(60, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(615, 25);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnInputFood
            // 
            this.btnInputFood.Location = new System.Drawing.Point(110, 25);
            this.btnInputFood.Name = "btnInputFood";
            this.btnInputFood.Size = new System.Drawing.Size(416, 23);
            this.btnInputFood.TabIndex = 1;
            this.btnInputFood.UseVisualStyleBackColor = true;
            // 
            // labelNameFood
            // 
            this.labelNameFood.AutoSize = true;
            this.labelNameFood.Location = new System.Drawing.Point(26, 28);
            this.labelNameFood.Name = "labelNameFood";
            this.labelNameFood.Size = new System.Drawing.Size(78, 16);
            this.labelNameFood.TabIndex = 0;
            this.labelNameFood.Text = "Tên món ăn";
            // 
            // Quanlymonan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Quanlymonan";
            this.Text = "QUẢN LÝ CÁC MÓN ĂN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInputFood;
        private System.Windows.Forms.Label labelNameFood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBoxSeclected;
        private System.Windows.Forms.TextBox textBoxSelect;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelFood;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnDeleteMenu;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnDeleteFood;
    }
}
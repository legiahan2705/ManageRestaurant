namespace RestaurantManagement
{
    partial class AddEmployees
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
            txtName = new TextBox();
            txtSalary = new TextBox();
            txtWorkYears = new TextBox();
            txtRole = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(27, 75);
            txtName.Name = "txtName";
            txtName.Size = new Size(278, 27);
            txtName.TabIndex = 0;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(27, 142);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(278, 27);
            txtSalary.TabIndex = 1;
            // 
            // txtWorkYears
            // 
            txtWorkYears.Location = new Point(27, 211);
            txtWorkYears.Name = "txtWorkYears";
            txtWorkYears.Size = new Size(278, 27);
            txtWorkYears.TabIndex = 2;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(27, 278);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(278, 27);
            txtRole.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(27, 332);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(211, 332);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(123, 22);
            label1.Name = "label1";
            label1.Size = new Size(80, 38);
            label1.TabIndex = 6;
            label1.Text = "Staff";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 52);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 119);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 8;
            label3.Text = "Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 188);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 9;
            label4.Text = "Work Years";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 255);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 10;
            label5.Text = "Role";
            // 
            // AddEmployees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 383);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtRole);
            Controls.Add(txtWorkYears);
            Controls.Add(txtSalary);
            Controls.Add(txtName);
            Name = "AddEmployees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEmployees";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtSalary;
        private TextBox txtWorkYears;
        private TextBox txtRole;
        private Button btnSave;
        private Button btnClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
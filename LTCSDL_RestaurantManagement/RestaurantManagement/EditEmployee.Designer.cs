namespace RestaurantManagement
{
    partial class EditEmployee
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
            txtId = new TextBox();
            txtName = new TextBox();
            txtSalary = new TextBox();
            txtWorkYears = new TextBox();
            txtRole = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ButtonFace;
            txtId.Location = new Point(78, 99);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(255, 27);
            txtId.TabIndex = 0;
            txtId.TabStop = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(78, 154);
            txtName.Name = "txtName";
            txtName.Size = new Size(255, 27);
            txtName.TabIndex = 1;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(78, 217);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(255, 27);
            txtSalary.TabIndex = 2;
            // 
            // txtWorkYears
            // 
            txtWorkYears.Location = new Point(78, 283);
            txtWorkYears.Name = "txtWorkYears";
            txtWorkYears.Size = new Size(255, 27);
            txtWorkYears.TabIndex = 3;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(78, 350);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(255, 27);
            txtRole.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(149, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 76);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 6;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 131);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 194);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 8;
            label3.Text = "Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 260);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 9;
            label4.Text = "WorkYears";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 327);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 10;
            label5.Text = "Role";
            // 
            // EditEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtRole);
            Controls.Add(txtWorkYears);
            Controls.Add(txtSalary);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Name = "EditEmployee";
            Text = "EditEmployee";
            Load += EditEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtSalary;
        private TextBox txtWorkYears;
        private TextBox txtRole;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
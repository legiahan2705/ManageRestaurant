namespace RestaurantManagement
{
    partial class Dashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnStaff = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Salary = new DataGridViewTextBoxColumn();
            WorkYears = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label3 = new Label();
            panel3 = new Panel();
            picExit = new PictureBox();
            panel2 = new Panel();
            picAdd = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picExit).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAdd).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 103);
            button1.Name = "button1";
            button1.Size = new Size(181, 34);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 143);
            button2.Name = "button2";
            button2.Size = new Size(181, 34);
            button2.TabIndex = 1;
            button2.Text = "Categories";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 183);
            button3.Name = "button3";
            button3.Size = new Size(181, 34);
            button3.TabIndex = 3;
            button3.Text = "Customer";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 223);
            button4.Name = "button4";
            button4.Size = new Size(181, 34);
            button4.TabIndex = 2;
            button4.Text = "Tables";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnStaff
            // 
            btnStaff.Location = new Point(12, 268);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(181, 34);
            btnStaff.TabIndex = 7;
            btnStaff.Text = "Staff";
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 308);
            button6.Name = "button6";
            button6.Size = new Size(181, 34);
            button6.TabIndex = 6;
            button6.Text = "Pos";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(12, 348);
            button7.Name = "button7";
            button7.Size = new Size(181, 34);
            button7.TabIndex = 5;
            button7.Text = "Kitchen";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(12, 388);
            button8.Name = "button8";
            button8.Size = new Size(181, 34);
            button8.TabIndex = 4;
            button8.Text = "Setting";
            button8.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(181, 89);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 45);
            label2.Margin = new Padding(10, 0, 10, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(60, 30);
            label2.TabIndex = 9;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 0;
            label1.Text = "Restaurant Management";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.LightGray;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(204, 675);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(flowLayoutPanel2);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(210, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(795, 609);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Name, Salary, WorkYears, Role, Edit, Delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(6, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(775, 373);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 58;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 93;
            // 
            // Salary
            // 
            Salary.HeaderText = "Salary";
            Salary.MinimumWidth = 6;
            Salary.Name = "Salary";
            Salary.Width = 94;
            // 
            // WorkYears
            // 
            WorkYears.HeaderText = "WorkYears";
            WorkYears.MinimumWidth = 6;
            WorkYears.Name = "WorkYears";
            WorkYears.Width = 132;
            // 
            // Role
            // 
            Role.HeaderText = "Role";
            Role.MinimumWidth = 6;
            Role.Name = "Role";
            Role.Width = 79;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Width = 75;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Width = 97;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(882, 97);
            flowLayoutPanel2.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 38);
            label3.TabIndex = 14;
            label3.Text = "Staff";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(picExit);
            panel3.Location = new Point(228, 506);
            panel3.Name = "panel3";
            panel3.Size = new Size(167, 72);
            panel3.TabIndex = 13;
            // 
            // picExit
            // 
            picExit.Image = (Image)resources.GetObject("picExit.Image");
            picExit.Location = new Point(48, 1);
            picExit.Name = "picExit";
            picExit.Size = new Size(79, 68);
            picExit.SizeMode = PictureBoxSizeMode.Zoom;
            picExit.TabIndex = 0;
            picExit.TabStop = false;
            picExit.Click += picExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(picAdd);
            panel2.Location = new Point(23, 506);
            panel2.Name = "panel2";
            panel2.Size = new Size(167, 72);
            panel2.TabIndex = 12;
            // 
            // picAdd
            // 
            picAdd.Image = (Image)resources.GetObject("picAdd.Image");
            picAdd.Location = new Point(45, 3);
            picAdd.Name = "picAdd";
            picAdd.Size = new Size(75, 65);
            picAdd.SizeMode = PictureBoxSizeMode.Zoom;
            picAdd.TabIndex = 0;
            picAdd.TabStop = false;
            picAdd.Click += picAdd_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 608);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(btnStaff);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            this.dataGridView1.Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            FormClosing += Dashboard_FormClosing;
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picExit).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAdd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnStaff;
        private Button button6;
        private Button button7;
        private Button button8;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Salary;
        private DataGridViewTextBoxColumn WorkYears;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private Panel panel2;
        private PictureBox picAdd;
        private Panel panel3;
        private PictureBox picExit;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label3;
    }
}
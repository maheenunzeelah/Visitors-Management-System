namespace loginForm
{
    partial class vms
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label visitor_NameLabel;
            System.Windows.Forms.Label cNICLabel;
            System.Windows.Forms.Label cellLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label check_InLabel;
            System.Windows.Forms.Label check_OutLabel;
            System.Windows.Forms.Label meeting_WithLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label center_IdLabel;
            this.visitorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new loginForm.DataSet1();
            this.visitor_NameTextBox = new System.Windows.Forms.TextBox();
            this.cNICTextBox = new System.Windows.Forms.TextBox();
            this.cellTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.check_InTextBox = new System.Windows.Forms.TextBox();
            this.check_OutTextBox = new System.Windows.Forms.TextBox();
            this.meeting_WithTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.centerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new loginForm.DataSet1();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.visitor_IdLabel1 = new System.Windows.Forms.Label();
            this.visitorViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.visitorViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitorsTableAdapter = new loginForm.DataSet1TableAdapters.VisitorsTableAdapter();
            this.tableAdapterManager = new loginForm.DataSet1TableAdapters.TableAdapterManager();
            this.centerTableAdapter = new loginForm.DataSet1TableAdapters.CenterTableAdapter();
            this.visitorViewTableAdapter = new loginForm.DataSet1TableAdapters.VisitorViewTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            visitor_NameLabel = new System.Windows.Forms.Label();
            cNICLabel = new System.Windows.Forms.Label();
            cellLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            check_InLabel = new System.Windows.Forms.Label();
            check_OutLabel = new System.Windows.Forms.Label();
            meeting_WithLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            center_IdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitorViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // visitor_NameLabel
            // 
            visitor_NameLabel.AutoSize = true;
            visitor_NameLabel.Location = new System.Drawing.Point(28, 42);
            visitor_NameLabel.Name = "visitor_NameLabel";
            visitor_NameLabel.Size = new System.Drawing.Size(69, 13);
            visitor_NameLabel.TabIndex = 3;
            visitor_NameLabel.Text = "Visitor Name:";
            // 
            // cNICLabel
            // 
            cNICLabel.AutoSize = true;
            cNICLabel.Location = new System.Drawing.Point(28, 68);
            cNICLabel.Name = "cNICLabel";
            cNICLabel.Size = new System.Drawing.Size(35, 13);
            cNICLabel.TabIndex = 5;
            cNICLabel.Text = "CNIC:";
            // 
            // cellLabel
            // 
            cellLabel.AutoSize = true;
            cellLabel.Location = new System.Drawing.Point(28, 94);
            cellLabel.Name = "cellLabel";
            cellLabel.Size = new System.Drawing.Size(27, 13);
            cellLabel.TabIndex = 7;
            cellLabel.Text = "Cell:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(28, 121);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 9;
            dateLabel.Text = "Date:";
            // 
            // check_InLabel
            // 
            check_InLabel.AutoSize = true;
            check_InLabel.Location = new System.Drawing.Point(28, 146);
            check_InLabel.Name = "check_InLabel";
            check_InLabel.Size = new System.Drawing.Size(53, 13);
            check_InLabel.TabIndex = 11;
            check_InLabel.Text = "Check In:";
            // 
            // check_OutLabel
            // 
            check_OutLabel.AutoSize = true;
            check_OutLabel.Location = new System.Drawing.Point(28, 172);
            check_OutLabel.Name = "check_OutLabel";
            check_OutLabel.Size = new System.Drawing.Size(61, 13);
            check_OutLabel.TabIndex = 13;
            check_OutLabel.Text = "Check Out:";
            // 
            // meeting_WithLabel
            // 
            meeting_WithLabel.AutoSize = true;
            meeting_WithLabel.Location = new System.Drawing.Point(28, 198);
            meeting_WithLabel.Name = "meeting_WithLabel";
            meeting_WithLabel.Size = new System.Drawing.Size(73, 13);
            meeting_WithLabel.TabIndex = 15;
            meeting_WithLabel.Text = "Meeting With:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(28, 224);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 17;
            typeLabel.Text = "Type:";
            // 
            // center_IdLabel
            // 
            center_IdLabel.AutoSize = true;
            center_IdLabel.Location = new System.Drawing.Point(28, 250);
            center_IdLabel.Name = "center_IdLabel";
            center_IdLabel.Size = new System.Drawing.Size(53, 13);
            center_IdLabel.TabIndex = 19;
            center_IdLabel.Text = "Center Id:";
            // 
            // visitorsBindingSource
            // 
            this.visitorsBindingSource.DataMember = "Visitors";
            this.visitorsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitor_NameTextBox
            // 
            this.visitor_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitorsBindingSource, "Visitor_Name", true));
            this.visitor_NameTextBox.Location = new System.Drawing.Point(107, 39);
            this.visitor_NameTextBox.Name = "visitor_NameTextBox";
            this.visitor_NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.visitor_NameTextBox.TabIndex = 4;
            // 
            // cNICTextBox
            // 
            this.cNICTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitorsBindingSource, "CNIC", true));
            this.cNICTextBox.Location = new System.Drawing.Point(107, 65);
            this.cNICTextBox.Name = "cNICTextBox";
            this.cNICTextBox.Size = new System.Drawing.Size(200, 20);
            this.cNICTextBox.TabIndex = 6;
            // 
            // cellTextBox
            // 
            this.cellTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitorsBindingSource, "Cell", true));
            this.cellTextBox.Location = new System.Drawing.Point(107, 91);
            this.cellTextBox.Name = "cellTextBox";
            this.cellTextBox.Size = new System.Drawing.Size(200, 20);
            this.cellTextBox.TabIndex = 8;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.visitorsBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(107, 117);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 10;
            // 
            // check_InTextBox
            // 
            this.check_InTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitorsBindingSource, "Check_In", true));
            this.check_InTextBox.Location = new System.Drawing.Point(107, 143);
            this.check_InTextBox.Name = "check_InTextBox";
            this.check_InTextBox.Size = new System.Drawing.Size(200, 20);
            this.check_InTextBox.TabIndex = 12;
            // 
            // check_OutTextBox
            // 
            this.check_OutTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitorsBindingSource, "Check_Out", true));
            this.check_OutTextBox.Location = new System.Drawing.Point(107, 169);
            this.check_OutTextBox.Name = "check_OutTextBox";
            this.check_OutTextBox.Size = new System.Drawing.Size(200, 20);
            this.check_OutTextBox.TabIndex = 14;
            // 
            // meeting_WithTextBox
            // 
            this.meeting_WithTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitorsBindingSource, "Meeting_With", true));
            this.meeting_WithTextBox.Location = new System.Drawing.Point(107, 195);
            this.meeting_WithTextBox.Name = "meeting_WithTextBox";
            this.meeting_WithTextBox.Size = new System.Drawing.Size(200, 20);
            this.meeting_WithTextBox.TabIndex = 16;
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitorsBindingSource, "Type", true));
            this.typeTextBox.Location = new System.Drawing.Point(107, 221);
            this.typeTextBox.Multiline = true;
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(200, 20);
            this.typeTextBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "AddNew";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.visitorsBindingSource, "Center_Id", true));
            this.comboBox1.DataSource = this.centerBindingSource;
            this.comboBox1.DisplayMember = "Center_Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 247);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.ValueMember = "Center_Id";
            // 
            // centerBindingSource
            // 
            this.centerBindingSource.DataMember = "Center";
            this.centerBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(328, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(328, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "First";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(328, 90);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 26;
            this.button5.Text = "Next";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(328, 120);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 27;
            this.button6.Text = "Previous";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(328, 150);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 28;
            this.button7.Text = "Last";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(328, 180);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 29;
            this.button8.Text = "Search";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(visitor_NameLabel);
            this.groupBox1.Controls.Add(this.visitor_NameTextBox);
            this.groupBox1.Controls.Add(cNICLabel);
            this.groupBox1.Controls.Add(this.cNICTextBox);
            this.groupBox1.Controls.Add(cellLabel);
            this.groupBox1.Controls.Add(this.cellTextBox);
            this.groupBox1.Controls.Add(dateLabel);
            this.groupBox1.Controls.Add(this.dateDateTimePicker);
            this.groupBox1.Controls.Add(check_InLabel);
            this.groupBox1.Controls.Add(this.check_InTextBox);
            this.groupBox1.Controls.Add(check_OutLabel);
            this.groupBox1.Controls.Add(this.check_OutTextBox);
            this.groupBox1.Controls.Add(meeting_WithLabel);
            this.groupBox1.Controls.Add(this.meeting_WithTextBox);
            this.groupBox1.Controls.Add(typeLabel);
            this.groupBox1.Controls.Add(this.typeTextBox);
            this.groupBox1.Controls.Add(center_IdLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 310);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(328, 210);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 30;
            this.button9.Text = "Delete";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.visitor_IdLabel1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.visitorViewDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 310);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(184, 23);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(98, 23);
            this.button11.TabIndex = 8;
            this.button11.Text = "Search by Center ";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // visitor_IdLabel1
            // 
            this.visitor_IdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitorViewBindingSource, "Visitor_Id", true));
            this.visitor_IdLabel1.Location = new System.Drawing.Point(35, 252);
            this.visitor_IdLabel1.Name = "visitor_IdLabel1";
            this.visitor_IdLabel1.Size = new System.Drawing.Size(46, 23);
            this.visitor_IdLabel1.TabIndex = 7;
            this.visitor_IdLabel1.Text = "label1";
            this.visitor_IdLabel1.Click += new System.EventHandler(this.visitor_IdLabel1_Click_1);
            // 
            // visitorViewBindingSource
            // 
            this.visitorViewBindingSource.DataMember = "VisitorView";
            this.visitorViewBindingSource.DataSource = this.dataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label2";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(375, 252);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 3;
            this.button10.Text = "Go to record";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 1;
            // 
            // visitorViewDataGridView
            // 
            this.visitorViewDataGridView.AutoGenerateColumns = false;
            this.visitorViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitorViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.visitorViewDataGridView.DataSource = this.visitorViewBindingSource;
            this.visitorViewDataGridView.Location = new System.Drawing.Point(15, 68);
            this.visitorViewDataGridView.Name = "visitorViewDataGridView";
            this.visitorViewDataGridView.Size = new System.Drawing.Size(480, 180);
            this.visitorViewDataGridView.TabIndex = 0;
            this.visitorViewDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.visitorViewDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Center_Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Center_Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Visitor_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Visitor_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Visitor_Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Visitor_Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn4.HeaderText = "Type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Meeting_With";
            this.dataGridViewTextBoxColumn5.HeaderText = "Meeting_With";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CNIC";
            this.dataGridViewTextBoxColumn6.HeaderText = "CNIC";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Cell";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cell";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // visitorsTableAdapter
            // 
            this.visitorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CenterTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = loginForm.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VisitorsTableAdapter = this.visitorsTableAdapter;
            // 
            // centerTableAdapter
            // 
            this.centerTableAdapter.ClearBeforeFill = true;
            // 
            // visitorViewTableAdapter
            // 
            this.visitorViewTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 33);
            this.label2.TabIndex = 32;
            this.label2.Text = "Visitors\' Detail";
            // 
            // vms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "vms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vms";
            this.Load += new System.EventHandler(this.vms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visitorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitorViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorViewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource visitorsBindingSource;
        private DataSet1TableAdapters.VisitorsTableAdapter visitorsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox visitor_NameTextBox;
        private System.Windows.Forms.TextBox cNICTextBox;
        private System.Windows.Forms.TextBox cellTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox check_InTextBox;
        private System.Windows.Forms.TextBox check_OutTextBox;
        private System.Windows.Forms.TextBox meeting_WithTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource centerBindingSource;
        private DataSet1TableAdapters.CenterTableAdapter centerTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource visitorViewBindingSource;
        private DataSet1TableAdapters.VisitorViewTableAdapter visitorViewTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView visitorViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label visitor_IdLabel1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
    }
}
namespace NfaWindowsFormsApplication
{
    partial class NewMachineForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox9 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(590, 292);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(582, 266);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Machine Type";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 254);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Machine Type";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(22, 72);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(119, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "DFA based machine";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 49);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(119, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "NFA Based Machine";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idntify type of Machine ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(582, 266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alphapit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alphapit";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(182, 92);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Delete";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(10, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 147);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 47);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add each Alphapet individually";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(582, 266);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "States";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkLabel2);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.listBox2);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(570, 254);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "States";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(182, 92);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(38, 13);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Delete";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(10, 73);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(165, 147);
            this.listBox2.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 47);
            this.textBox2.MaxLength = 2;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add each State individually";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(582, 266);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Initial state";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Enter += new System.EventHandler(this.tabPage4_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.linkLabel4);
            this.groupBox4.Controls.Add(this.linkLabel3);
            this.groupBox4.Controls.Add(this.listBox4);
            this.groupBox4.Controls.Add(this.listBox3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(570, 254);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Initial State";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(182, 100);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(26, 13);
            this.linkLabel4.TabIndex = 5;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Add";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(261, 165);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(38, 13);
            this.linkLabel3.TabIndex = 4;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Delete";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(305, 60);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(165, 160);
            this.listBox4.TabIndex = 2;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(10, 60);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(165, 160);
            this.listBox3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Select State To be Initial the Click Add";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(582, 266);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Final states";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Enter += new System.EventHandler(this.tabPage5_Enter);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.groupBox6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(582, 266);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Transtion functions";
            this.tabPage6.UseVisualStyleBackColor = true;
            this.tabPage6.Enter += new System.EventHandler(this.tabPage6_Enter);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Location = new System.Drawing.Point(417, 309);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(75, 23);
            this.btn_Previous.TabIndex = 1;
            this.btn_Previous.Text = "Previous";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(498, 310);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.linkLabel5);
            this.groupBox5.Controls.Add(this.linkLabel6);
            this.groupBox5.Controls.Add(this.listBox5);
            this.groupBox5.Controls.Add(this.listBox6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(570, 254);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Final States";
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(183, 103);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(26, 13);
            this.linkLabel5.TabIndex = 5;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Add";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(178, 129);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(38, 13);
            this.linkLabel6.TabIndex = 4;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Delete";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(6, 60);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(165, 160);
            this.listBox5.TabIndex = 2;
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.Location = new System.Drawing.Point(226, 60);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(165, 160);
            this.listBox6.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Select State To be Final then Click Add";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBox1);
            this.groupBox6.Controls.Add(this.linkLabel7);
            this.groupBox6.Controls.Add(this.linkLabel8);
            this.groupBox6.Controls.Add(this.listBox7);
            this.groupBox6.Controls.Add(this.listBox9);
            this.groupBox6.Controls.Add(this.listBox8);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(570, 254);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Final States";
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new System.Drawing.Point(354, 108);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(26, 13);
            this.linkLabel7.TabIndex = 5;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Add";
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Location = new System.Drawing.Point(348, 134);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(38, 13);
            this.linkLabel8.TabIndex = 4;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Delete";
            this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.Location = new System.Drawing.Point(6, 60);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(123, 160);
            this.listBox7.TabIndex = 2;
            // 
            // listBox8
            // 
            this.listBox8.FormattingEnabled = true;
            this.listBox8.Location = new System.Drawing.Point(209, 60);
            this.listBox8.Name = "listBox8";
            this.listBox8.Size = new System.Drawing.Size(123, 160);
            this.listBox8.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Create Transition Function coresponding to this Automata";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // listBox9
            // 
            this.listBox9.FormattingEnabled = true;
            this.listBox9.Location = new System.Drawing.Point(395, 60);
            this.listBox9.Name = "listBox9";
            this.listBox9.Size = new System.Drawing.Size(156, 160);
            this.listBox9.TabIndex = 2;
            // 
            // NewMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 344);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_Previous);
            this.Controls.Add(this.tabControl1);
            this.Name = "NewMachineForm";
            this.Text = "NewMachineForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.ListBox listBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox9;
    }
}
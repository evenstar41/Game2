namespace NesneLabDeneme1
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.redTri = new System.Windows.Forms.CheckBox();
            this.redSqr = new System.Windows.Forms.CheckBox();
            this.redCrc = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.greenCrc = new System.Windows.Forms.CheckBox();
            this.greenSqr = new System.Windows.Forms.CheckBox();
            this.greenTri = new System.Windows.Forms.CheckBox();
            this.admingirisi = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
<<<<<<< Updated upstream
=======
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsutun = new System.Windows.Forms.TextBox();
            this.txtsatir = new System.Windows.Forms.TextBox();
            this.chkCustom = new System.Windows.Forms.CheckBox();
            this.yellowtri = new System.Windows.Forms.CheckBox();
            this.yellowSqr = new System.Windows.Forms.CheckBox();
            this.yellowCrc = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chKsHAPES = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Difficulties";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "easy",
            "normal",
            "hard"});
            this.comboBox1.Location = new System.Drawing.Point(3, 68);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shape";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 126);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Triangle";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 147);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Square";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(3, 168);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(52, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Circle";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 222);
=======
            // redTri
            // 
            this.redTri.AutoSize = true;
            this.redTri.Location = new System.Drawing.Point(12, 20);
            this.redTri.Margin = new System.Windows.Forms.Padding(2);
            this.redTri.Name = "redTri";
            this.redTri.Size = new System.Drawing.Size(64, 30);
            this.redTri.TabIndex = 4;
            this.redTri.Text = "Red \r\nTriangle";
            this.redTri.UseVisualStyleBackColor = true;
            // 
            // redSqr
            // 
            this.redSqr.AutoSize = true;
            this.redSqr.Location = new System.Drawing.Point(12, 60);
            this.redSqr.Margin = new System.Windows.Forms.Padding(2);
            this.redSqr.Name = "redSqr";
            this.redSqr.Size = new System.Drawing.Size(60, 30);
            this.redSqr.TabIndex = 5;
            this.redSqr.Text = "Red\r\nSquare";
            this.redSqr.UseVisualStyleBackColor = true;
            // 
            // redCrc
            // 
            this.redCrc.AutoSize = true;
            this.redCrc.Location = new System.Drawing.Point(12, 102);
            this.redCrc.Margin = new System.Windows.Forms.Padding(2);
            this.redCrc.Name = "redCrc";
            this.redCrc.Size = new System.Drawing.Size(52, 30);
            this.redCrc.TabIndex = 6;
            this.redCrc.Text = "Red\r\nCircle";
            this.redCrc.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 412);
>>>>>>> Stashed changes
=======
            // redTri
            // 
            this.redTri.AutoSize = true;
            this.redTri.Location = new System.Drawing.Point(12, 20);
            this.redTri.Margin = new System.Windows.Forms.Padding(2);
            this.redTri.Name = "redTri";
            this.redTri.Size = new System.Drawing.Size(64, 30);
            this.redTri.TabIndex = 4;
            this.redTri.Text = "Red \r\nTriangle";
            this.redTri.UseVisualStyleBackColor = true;
            // 
            // redSqr
            // 
            this.redSqr.AutoSize = true;
            this.redSqr.Location = new System.Drawing.Point(12, 60);
            this.redSqr.Margin = new System.Windows.Forms.Padding(2);
            this.redSqr.Name = "redSqr";
            this.redSqr.Size = new System.Drawing.Size(60, 30);
            this.redSqr.TabIndex = 5;
            this.redSqr.Text = "Red\r\nSquare";
            this.redSqr.UseVisualStyleBackColor = true;
            // 
            // redCrc
            // 
            this.redCrc.AutoSize = true;
            this.redCrc.Location = new System.Drawing.Point(12, 102);
            this.redCrc.Margin = new System.Windows.Forms.Padding(2);
            this.redCrc.Name = "redCrc";
            this.redCrc.Size = new System.Drawing.Size(52, 30);
            this.redCrc.TabIndex = 6;
            this.redCrc.Text = "Red\r\nCircle";
            this.redCrc.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 412);
>>>>>>> Stashed changes
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 19);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            this.button2.Location = new System.Drawing.Point(61, 222);
=======
            this.button2.Location = new System.Drawing.Point(66, 412);
>>>>>>> Stashed changes
=======
            this.button2.Location = new System.Drawing.Point(66, 412);
>>>>>>> Stashed changes
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 19);
            this.button2.TabIndex = 8;
            this.button2.Text = "Quit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            // chkboxGreen
            // 
            this.chkboxGreen.AutoSize = true;
            this.chkboxGreen.Location = new System.Drawing.Point(67, 168);
            this.chkboxGreen.Margin = new System.Windows.Forms.Padding(2);
            this.chkboxGreen.Name = "chkboxGreen";
            this.chkboxGreen.Size = new System.Drawing.Size(55, 17);
            this.chkboxGreen.TabIndex = 12;
            this.chkboxGreen.Text = "Green";
            this.chkboxGreen.UseVisualStyleBackColor = true;
            // 
            // chkboxYellow
            // 
            this.chkboxYellow.AutoSize = true;
            this.chkboxYellow.Location = new System.Drawing.Point(67, 147);
            this.chkboxYellow.Margin = new System.Windows.Forms.Padding(2);
            this.chkboxYellow.Name = "chkboxYellow";
            this.chkboxYellow.Size = new System.Drawing.Size(57, 17);
            this.chkboxYellow.TabIndex = 11;
            this.chkboxYellow.Text = "Yellow";
            this.chkboxYellow.UseVisualStyleBackColor = true;
            // 
            // chkboxRed
            // 
            this.chkboxRed.AutoSize = true;
            this.chkboxRed.Location = new System.Drawing.Point(67, 126);
            this.chkboxRed.Margin = new System.Windows.Forms.Padding(2);
            this.chkboxRed.Name = "chkboxRed";
            this.chkboxRed.Size = new System.Drawing.Size(46, 17);
            this.chkboxRed.TabIndex = 10;
            this.chkboxRed.Text = "Red";
            this.chkboxRed.UseVisualStyleBackColor = true;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(68, 100);
            this.lblColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(40, 16);
            this.lblColor.TabIndex = 9;
            this.lblColor.Text = "Color";
            // 
            // admingirisi
            // 
            this.admingirisi.Location = new System.Drawing.Point(2, 246);
=======
            // greenCrc
            // 
            this.greenCrc.AutoSize = true;
            this.greenCrc.Location = new System.Drawing.Point(88, 102);
            this.greenCrc.Margin = new System.Windows.Forms.Padding(2);
            this.greenCrc.Name = "greenCrc";
            this.greenCrc.Size = new System.Drawing.Size(55, 30);
            this.greenCrc.TabIndex = 12;
            this.greenCrc.Text = "Green\r\nCircle";
            this.greenCrc.UseVisualStyleBackColor = true;
            // 
            // greenSqr
            // 
            this.greenSqr.AutoSize = true;
            this.greenSqr.Location = new System.Drawing.Point(88, 60);
            this.greenSqr.Margin = new System.Windows.Forms.Padding(2);
            this.greenSqr.Name = "greenSqr";
            this.greenSqr.Size = new System.Drawing.Size(60, 30);
            this.greenSqr.TabIndex = 11;
            this.greenSqr.Text = "Green \r\nSquare\r\n";
            this.greenSqr.UseVisualStyleBackColor = true;
            // 
            // greenTri
            // 
            this.greenTri.AutoSize = true;
            this.greenTri.Location = new System.Drawing.Point(88, 20);
            this.greenTri.Margin = new System.Windows.Forms.Padding(2);
            this.greenTri.Name = "greenTri";
            this.greenTri.Size = new System.Drawing.Size(64, 30);
            this.greenTri.TabIndex = 10;
            this.greenTri.Text = "Green\r\nTriangle";
            this.greenTri.UseVisualStyleBackColor = true;
            // 
            // admingirisi
            // 
            this.admingirisi.Location = new System.Drawing.Point(7, 436);
>>>>>>> Stashed changes
=======
            // greenCrc
            // 
            this.greenCrc.AutoSize = true;
            this.greenCrc.Location = new System.Drawing.Point(88, 102);
            this.greenCrc.Margin = new System.Windows.Forms.Padding(2);
            this.greenCrc.Name = "greenCrc";
            this.greenCrc.Size = new System.Drawing.Size(55, 30);
            this.greenCrc.TabIndex = 12;
            this.greenCrc.Text = "Green\r\nCircle";
            this.greenCrc.UseVisualStyleBackColor = true;
            // 
            // greenSqr
            // 
            this.greenSqr.AutoSize = true;
            this.greenSqr.Location = new System.Drawing.Point(88, 60);
            this.greenSqr.Margin = new System.Windows.Forms.Padding(2);
            this.greenSqr.Name = "greenSqr";
            this.greenSqr.Size = new System.Drawing.Size(60, 30);
            this.greenSqr.TabIndex = 11;
            this.greenSqr.Text = "Green \r\nSquare\r\n";
            this.greenSqr.UseVisualStyleBackColor = true;
            // 
            // greenTri
            // 
            this.greenTri.AutoSize = true;
            this.greenTri.Location = new System.Drawing.Point(88, 20);
            this.greenTri.Margin = new System.Windows.Forms.Padding(2);
            this.greenTri.Name = "greenTri";
            this.greenTri.Size = new System.Drawing.Size(64, 30);
            this.greenTri.TabIndex = 10;
            this.greenTri.Text = "Green\r\nTriangle";
            this.greenTri.UseVisualStyleBackColor = true;
            // 
            // admingirisi
            // 
            this.admingirisi.Location = new System.Drawing.Point(7, 436);
>>>>>>> Stashed changes
            this.admingirisi.Name = "admingirisi";
            this.admingirisi.Size = new System.Drawing.Size(117, 25);
            this.admingirisi.TabIndex = 15;
            this.admingirisi.Text = "Administrator page";
            this.admingirisi.UseVisualStyleBackColor = true;
            this.admingirisi.Visible = false;
            this.admingirisi.Click += new System.EventHandler(this.admingirisi_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(465, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 23);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit Profile";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
<<<<<<< Updated upstream
=======
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(224, 13);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 74);
            this.button3.TabIndex = 19;
            this.button3.Text = "PLAY";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(465, 47);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(120, 23);
            this.btnHelp.TabIndex = 20;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(465, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "About";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chKsHAPES);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtsutun);
            this.panel1.Controls.Add(this.txtsatir);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(6, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 217);
            this.panel1.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Create Table";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "X";
            // 
            // txtsutun
            // 
            this.txtsutun.Location = new System.Drawing.Point(60, 18);
            this.txtsutun.Name = "txtsutun";
            this.txtsutun.Size = new System.Drawing.Size(25, 20);
            this.txtsutun.TabIndex = 25;
            this.txtsutun.TextChanged += new System.EventHandler(this.txtsutun_TextChanged);
            this.txtsutun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsutun_KeyPress);
            // 
            // txtsatir
            // 
            this.txtsatir.Location = new System.Drawing.Point(8, 17);
            this.txtsatir.Name = "txtsatir";
            this.txtsatir.Size = new System.Drawing.Size(25, 20);
            this.txtsatir.TabIndex = 24;
            this.txtsatir.TextChanged += new System.EventHandler(this.txtsatir_TextChanged);
            this.txtsatir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsatir_KeyPress);
            // 
            // chkCustom
            // 
            this.chkCustom.AutoSize = true;
            this.chkCustom.Location = new System.Drawing.Point(12, 106);
            this.chkCustom.Name = "chkCustom";
            this.chkCustom.Size = new System.Drawing.Size(107, 17);
            this.chkCustom.TabIndex = 23;
            this.chkCustom.Text = "CUSTOM MODE";
            this.chkCustom.UseVisualStyleBackColor = true;
            this.chkCustom.CheckedChanged += new System.EventHandler(this.chkCustom_CheckedChanged);
            // 
            // yellowtri
            // 
            this.yellowtri.AutoSize = true;
            this.yellowtri.Location = new System.Drawing.Point(167, 20);
            this.yellowtri.Margin = new System.Windows.Forms.Padding(2);
            this.yellowtri.Name = "yellowtri";
            this.yellowtri.Size = new System.Drawing.Size(64, 30);
            this.yellowtri.TabIndex = 27;
            this.yellowtri.Text = "Yellow\r\nTriangle";
            this.yellowtri.UseVisualStyleBackColor = true;
            // 
            // yellowSqr
            // 
            this.yellowSqr.AutoSize = true;
            this.yellowSqr.Location = new System.Drawing.Point(167, 60);
            this.yellowSqr.Margin = new System.Windows.Forms.Padding(2);
            this.yellowSqr.Name = "yellowSqr";
            this.yellowSqr.Size = new System.Drawing.Size(60, 30);
            this.yellowSqr.TabIndex = 28;
            this.yellowSqr.Text = "Yellow\r\nSquare";
            this.yellowSqr.UseVisualStyleBackColor = true;
            // 
            // yellowCrc
            // 
            this.yellowCrc.AutoSize = true;
            this.yellowCrc.Location = new System.Drawing.Point(167, 102);
            this.yellowCrc.Margin = new System.Windows.Forms.Padding(2);
            this.yellowCrc.Name = "yellowCrc";
            this.yellowCrc.Size = new System.Drawing.Size(57, 30);
            this.yellowCrc.TabIndex = 29;
            this.yellowCrc.Text = "Yellow\r\nCircle";
            this.yellowCrc.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.yellowtri);
            this.panel2.Controls.Add(this.greenSqr);
            this.panel2.Controls.Add(this.yellowSqr);
            this.panel2.Controls.Add(this.greenCrc);
            this.panel2.Controls.Add(this.yellowCrc);
            this.panel2.Controls.Add(this.greenTri);
            this.panel2.Controls.Add(this.redCrc);
            this.panel2.Controls.Add(this.redSqr);
            this.panel2.Controls.Add(this.redTri);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(1, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 142);
            this.panel2.TabIndex = 24;
            // 
            // chKsHAPES
            // 
            this.chKsHAPES.AutoSize = true;
            this.chKsHAPES.Location = new System.Drawing.Point(8, 49);
            this.chKsHAPES.Name = "chKsHAPES";
            this.chKsHAPES.Size = new System.Drawing.Size(117, 17);
            this.chKsHAPES.TabIndex = 24;
            this.chKsHAPES.Text = "CHOOSE SHAPES";
            this.chKsHAPES.UseVisualStyleBackColor = true;
            this.chKsHAPES.CheckedChanged += new System.EventHandler(this.chKsHAPES_CheckedChanged);
            // 
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            this.ClientSize = new System.Drawing.Size(600, 366);
=======
=======
>>>>>>> Stashed changes
            this.ClientSize = new System.Drawing.Size(600, 469);
            this.Controls.Add(this.chkCustom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
>>>>>>> Stashed changes
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.admingirisi);
            this.Controls.Add(this.chkboxGreen);
            this.Controls.Add(this.chkboxYellow);
            this.Controls.Add(this.chkboxRed);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
<<<<<<< Updated upstream
=======
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox redTri;
        private System.Windows.Forms.CheckBox redSqr;
        private System.Windows.Forms.CheckBox redCrc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox greenCrc;
        private System.Windows.Forms.CheckBox greenSqr;
        private System.Windows.Forms.CheckBox greenTri;
        private System.Windows.Forms.Button admingirisi;
        private System.Windows.Forms.Button btnEdit;
<<<<<<< Updated upstream
=======
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsutun;
        private System.Windows.Forms.TextBox txtsatir;
        private System.Windows.Forms.CheckBox chkCustom;
        private System.Windows.Forms.CheckBox yellowtri;
        private System.Windows.Forms.CheckBox yellowSqr;
        private System.Windows.Forms.CheckBox yellowCrc;
        private System.Windows.Forms.CheckBox chKsHAPES;
        private System.Windows.Forms.Panel panel2;
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    }
}
namespace Object_Robo_Tracker
{
    partial class RoboTrack
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.output_lab = new System.Windows.Forms.Label();
            this.normal_lab = new System.Windows.Forms.Label();
            this.threshold_lab = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.filtered_lab = new System.Windows.Forms.Label();
            this.cam1_lab = new System.Windows.Forms.Label();
            this.cam2_lab = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.trackBarLabel1 = new System.Windows.Forms.Label();
            this.trackBarLabel2 = new System.Windows.Forms.Label();
            this.trackBarLabel3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cam1LabX = new System.Windows.Forms.TextBox();
            this.cam1LabY = new System.Windows.Forms.TextBox();
            this.cam2LabX = new System.Windows.Forms.TextBox();
            this.cam2LabY = new System.Windows.Forms.TextBox();
            this.camMarkLab1 = new System.Windows.Forms.Label();
            this.camMarkLab2 = new System.Windows.Forms.Label();
            this.camMarkLab3 = new System.Windows.Forms.Label();
            this.camMarkLab4 = new System.Windows.Forms.Label();
            this.camMarkLab5 = new System.Windows.Forms.Label();
            this.camMarkLab6 = new System.Windows.Forms.Label();
            this.comPortDropDownList = new System.Windows.Forms.ComboBox();
            this.robotInfoLab1 = new System.Windows.Forms.Label();
            this.comPortInfoLab1 = new System.Windows.Forms.Label();
            this.returnHomeLab1 = new System.Windows.Forms.Label();
            this.returnHomeBtn = new System.Windows.Forms.Button();
            this.returnNestLab1 = new System.Windows.Forms.Label();
            this.returnNestBtn1 = new System.Windows.Forms.Button();
            this.trackBtn1 = new System.Windows.Forms.Button();
            this.resetRoboErrBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(48, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Location = new System.Drawing.Point(12, 426);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(584, 216);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(188, 233);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(585, 39);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(188, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 20;
            this.trackBar1.Visible = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar2.Location = new System.Drawing.Point(585, 90);
            this.trackBar2.Maximum = 500;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(188, 45);
            this.trackBar2.TabIndex = 5;
            this.trackBar2.Value = 20;
            this.trackBar2.Visible = false;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar3.Location = new System.Drawing.Point(585, 141);
            this.trackBar3.Maximum = 1000;
            this.trackBar3.Minimum = 1;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(187, 45);
            this.trackBar3.TabIndex = 6;
            this.trackBar3.Value = 200;
            this.trackBar3.Visible = false;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(214, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 120);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // output_lab
            // 
            this.output_lab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.output_lab.AutoSize = true;
            this.output_lab.Location = new System.Drawing.Point(581, 200);
            this.output_lab.Name = "output_lab";
            this.output_lab.Size = new System.Drawing.Size(39, 13);
            this.output_lab.TabIndex = 17;
            this.output_lab.Text = "Output";
            // 
            // normal_lab
            // 
            this.normal_lab.AutoSize = true;
            this.normal_lab.Location = new System.Drawing.Point(45, 23);
            this.normal_lab.Name = "normal_lab";
            this.normal_lab.Size = new System.Drawing.Size(40, 13);
            this.normal_lab.TabIndex = 18;
            this.normal_lab.Text = "Normal";
            this.normal_lab.Visible = false;
            // 
            // threshold_lab
            // 
            this.threshold_lab.AutoSize = true;
            this.threshold_lab.Location = new System.Drawing.Point(211, 23);
            this.threshold_lab.Name = "threshold_lab";
            this.threshold_lab.Size = new System.Drawing.Size(54, 13);
            this.threshold_lab.TabIndex = 19;
            this.threshold_lab.Text = "Threshold";
            this.threshold_lab.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(380, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(160, 120);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // filtered_lab
            // 
            this.filtered_lab.AutoSize = true;
            this.filtered_lab.Location = new System.Drawing.Point(377, 23);
            this.filtered_lab.Name = "filtered_lab";
            this.filtered_lab.Size = new System.Drawing.Size(44, 13);
            this.filtered_lab.TabIndex = 21;
            this.filtered_lab.Text = "Filterred";
            this.filtered_lab.Visible = false;
            // 
            // cam1_lab
            // 
            this.cam1_lab.AutoSize = true;
            this.cam1_lab.Location = new System.Drawing.Point(6, 39);
            this.cam1_lab.Name = "cam1_lab";
            this.cam1_lab.Size = new System.Drawing.Size(36, 13);
            this.cam1_lab.TabIndex = 22;
            this.cam1_lab.Text = "CAM1";
            this.cam1_lab.Visible = false;
            // 
            // cam2_lab
            // 
            this.cam2_lab.AutoSize = true;
            this.cam2_lab.Location = new System.Drawing.Point(6, 165);
            this.cam2_lab.Name = "cam2_lab";
            this.cam2_lab.Size = new System.Drawing.Size(36, 13);
            this.cam2_lab.TabIndex = 23;
            this.cam2_lab.Text = "CAM2";
            this.cam2_lab.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(48, 165);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(160, 120);
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(214, 165);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(160, 120);
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Location = new System.Drawing.Point(380, 165);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(160, 120);
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // trackBarLabel1
            // 
            this.trackBarLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarLabel1.AutoSize = true;
            this.trackBarLabel1.Location = new System.Drawing.Point(582, 23);
            this.trackBarLabel1.Name = "trackBarLabel1";
            this.trackBarLabel1.Size = new System.Drawing.Size(79, 13);
            this.trackBarLabel1.TabIndex = 27;
            this.trackBarLabel1.Text = "Sensivity Value";
            this.trackBarLabel1.Visible = false;
            // 
            // trackBarLabel2
            // 
            this.trackBarLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarLabel2.AutoSize = true;
            this.trackBarLabel2.Location = new System.Drawing.Point(582, 71);
            this.trackBarLabel2.Name = "trackBarLabel2";
            this.trackBarLabel2.Size = new System.Drawing.Size(48, 13);
            this.trackBarLabel2.TabIndex = 28;
            this.trackBarLabel2.Text = "Blur Size";
            this.trackBarLabel2.Visible = false;
            // 
            // trackBarLabel3
            // 
            this.trackBarLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarLabel3.AutoSize = true;
            this.trackBarLabel3.Location = new System.Drawing.Point(582, 125);
            this.trackBarLabel3.Name = "trackBarLabel3";
            this.trackBarLabel3.Size = new System.Drawing.Size(81, 13);
            this.trackBarLabel3.TabIndex = 29;
            this.trackBarLabel3.Text = "Min Object Size";
            this.trackBarLabel3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "X";
            this.label4.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Y";
            this.label6.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Y";
            this.label9.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "X";
            this.label11.Visible = false;
            // 
            // cam1LabX
            // 
            this.cam1LabX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cam1LabX.Enabled = false;
            this.cam1LabX.Location = new System.Drawing.Point(9, 78);
            this.cam1LabX.Name = "cam1LabX";
            this.cam1LabX.Size = new System.Drawing.Size(33, 13);
            this.cam1LabX.TabIndex = 38;
            // 
            // cam1LabY
            // 
            this.cam1LabY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cam1LabY.Enabled = false;
            this.cam1LabY.Location = new System.Drawing.Point(9, 129);
            this.cam1LabY.Name = "cam1LabY";
            this.cam1LabY.Size = new System.Drawing.Size(33, 13);
            this.cam1LabY.TabIndex = 39;
            // 
            // cam2LabX
            // 
            this.cam2LabX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cam2LabX.Enabled = false;
            this.cam2LabX.Location = new System.Drawing.Point(9, 204);
            this.cam2LabX.Name = "cam2LabX";
            this.cam2LabX.Size = new System.Drawing.Size(33, 13);
            this.cam2LabX.TabIndex = 40;
            // 
            // cam2LabY
            // 
            this.cam2LabY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cam2LabY.Enabled = false;
            this.cam2LabY.Location = new System.Drawing.Point(9, 255);
            this.cam2LabY.Name = "cam2LabY";
            this.cam2LabY.Size = new System.Drawing.Size(33, 13);
            this.cam2LabY.TabIndex = 41;
            // 
            // camMarkLab1
            // 
            this.camMarkLab1.AutoSize = true;
            this.camMarkLab1.BackColor = System.Drawing.Color.Transparent;
            this.camMarkLab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camMarkLab1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.camMarkLab1.Location = new System.Drawing.Point(91, 51);
            this.camMarkLab1.Name = "camMarkLab1";
            this.camMarkLab1.Size = new System.Drawing.Size(30, 31);
            this.camMarkLab1.TabIndex = 42;
            this.camMarkLab1.Text = "..";
            this.camMarkLab1.Visible = false;
            // 
            // camMarkLab2
            // 
            this.camMarkLab2.AutoSize = true;
            this.camMarkLab2.BackColor = System.Drawing.Color.Transparent;
            this.camMarkLab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camMarkLab2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.camMarkLab2.Location = new System.Drawing.Point(258, 51);
            this.camMarkLab2.Name = "camMarkLab2";
            this.camMarkLab2.Size = new System.Drawing.Size(30, 31);
            this.camMarkLab2.TabIndex = 42;
            this.camMarkLab2.Text = "..";
            this.camMarkLab2.Visible = false;
            this.camMarkLab2.Click += new System.EventHandler(this.camMarkLab2_Click);
            // 
            // camMarkLab3
            // 
            this.camMarkLab3.AutoSize = true;
            this.camMarkLab3.BackColor = System.Drawing.Color.Transparent;
            this.camMarkLab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camMarkLab3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.camMarkLab3.Location = new System.Drawing.Point(421, 51);
            this.camMarkLab3.Name = "camMarkLab3";
            this.camMarkLab3.Size = new System.Drawing.Size(30, 31);
            this.camMarkLab3.TabIndex = 42;
            this.camMarkLab3.Text = "..";
            this.camMarkLab3.Visible = false;
            this.camMarkLab3.Click += new System.EventHandler(this.camMarkLab3_Click);
            // 
            // camMarkLab4
            // 
            this.camMarkLab4.AutoSize = true;
            this.camMarkLab4.BackColor = System.Drawing.Color.Transparent;
            this.camMarkLab4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camMarkLab4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.camMarkLab4.Location = new System.Drawing.Point(91, 177);
            this.camMarkLab4.Name = "camMarkLab4";
            this.camMarkLab4.Size = new System.Drawing.Size(30, 31);
            this.camMarkLab4.TabIndex = 42;
            this.camMarkLab4.Text = "..";
            this.camMarkLab4.Visible = false;
            this.camMarkLab4.Click += new System.EventHandler(this.camMarkLab4_Click);
            // 
            // camMarkLab5
            // 
            this.camMarkLab5.AutoSize = true;
            this.camMarkLab5.BackColor = System.Drawing.Color.Transparent;
            this.camMarkLab5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camMarkLab5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.camMarkLab5.Location = new System.Drawing.Point(258, 177);
            this.camMarkLab5.Name = "camMarkLab5";
            this.camMarkLab5.Size = new System.Drawing.Size(30, 31);
            this.camMarkLab5.TabIndex = 42;
            this.camMarkLab5.Text = "..";
            this.camMarkLab5.Visible = false;
            this.camMarkLab5.Click += new System.EventHandler(this.camMarkLab5_Click);
            // 
            // camMarkLab6
            // 
            this.camMarkLab6.AutoSize = true;
            this.camMarkLab6.BackColor = System.Drawing.Color.Transparent;
            this.camMarkLab6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camMarkLab6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.camMarkLab6.Location = new System.Drawing.Point(421, 176);
            this.camMarkLab6.Name = "camMarkLab6";
            this.camMarkLab6.Size = new System.Drawing.Size(30, 31);
            this.camMarkLab6.TabIndex = 42;
            this.camMarkLab6.Text = "..";
            this.camMarkLab6.Visible = false;
            this.camMarkLab6.Click += new System.EventHandler(this.camMarkLab6_Click);
            // 
            // comPortDropDownList
            // 
            this.comPortDropDownList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comPortDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPortDropDownList.FormattingEnabled = true;
            this.comPortDropDownList.Items.AddRange(new object[] {
            "no one"});
            this.comPortDropDownList.Location = new System.Drawing.Point(93, 341);
            this.comPortDropDownList.Name = "comPortDropDownList";
            this.comPortDropDownList.Size = new System.Drawing.Size(75, 21);
            this.comPortDropDownList.TabIndex = 43;
            this.comPortDropDownList.Visible = false;
            // 
            // robotInfoLab1
            // 
            this.robotInfoLab1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.robotInfoLab1.AutoSize = true;
            this.robotInfoLab1.Location = new System.Drawing.Point(12, 315);
            this.robotInfoLab1.Name = "robotInfoLab1";
            this.robotInfoLab1.Size = new System.Drawing.Size(57, 13);
            this.robotInfoLab1.TabIndex = 44;
            this.robotInfoLab1.Text = "Robot Info";
            this.robotInfoLab1.Visible = false;
            // 
            // comPortInfoLab1
            // 
            this.comPortInfoLab1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comPortInfoLab1.AutoSize = true;
            this.comPortInfoLab1.Location = new System.Drawing.Point(12, 344);
            this.comPortInfoLab1.Name = "comPortInfoLab1";
            this.comPortInfoLab1.Size = new System.Drawing.Size(56, 13);
            this.comPortInfoLab1.TabIndex = 45;
            this.comPortInfoLab1.Text = "COM Port:";
            this.comPortInfoLab1.Visible = false;
            // 
            // returnHomeLab1
            // 
            this.returnHomeLab1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.returnHomeLab1.AutoSize = true;
            this.returnHomeLab1.Location = new System.Drawing.Point(12, 402);
            this.returnHomeLab1.Name = "returnHomeLab1";
            this.returnHomeLab1.Size = new System.Drawing.Size(70, 13);
            this.returnHomeLab1.TabIndex = 46;
            this.returnHomeLab1.Text = "Return Home";
            this.returnHomeLab1.Visible = false;
            // 
            // returnHomeBtn
            // 
            this.returnHomeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.returnHomeBtn.Location = new System.Drawing.Point(93, 397);
            this.returnHomeBtn.Name = "returnHomeBtn";
            this.returnHomeBtn.Size = new System.Drawing.Size(75, 23);
            this.returnHomeBtn.TabIndex = 47;
            this.returnHomeBtn.Text = "Home";
            this.returnHomeBtn.UseVisualStyleBackColor = true;
            this.returnHomeBtn.Visible = false;
            this.returnHomeBtn.Click += new System.EventHandler(this.returnHomeBtn_Click);
            // 
            // returnNestLab1
            // 
            this.returnNestLab1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.returnNestLab1.AutoSize = true;
            this.returnNestLab1.Location = new System.Drawing.Point(12, 373);
            this.returnNestLab1.Name = "returnNestLab1";
            this.returnNestLab1.Size = new System.Drawing.Size(64, 13);
            this.returnNestLab1.TabIndex = 48;
            this.returnNestLab1.Text = "Return Nest";
            this.returnNestLab1.Visible = false;
            // 
            // returnNestBtn1
            // 
            this.returnNestBtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.returnNestBtn1.Location = new System.Drawing.Point(93, 368);
            this.returnNestBtn1.Name = "returnNestBtn1";
            this.returnNestBtn1.Size = new System.Drawing.Size(75, 23);
            this.returnNestBtn1.TabIndex = 49;
            this.returnNestBtn1.Text = "Nest";
            this.returnNestBtn1.UseVisualStyleBackColor = true;
            this.returnNestBtn1.Visible = false;
            this.returnNestBtn1.Click += new System.EventHandler(this.returnNestBtn1_Click);
            // 
            // trackBtn1
            // 
            this.trackBtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.trackBtn1.Location = new System.Drawing.Point(93, 426);
            this.trackBtn1.Name = "trackBtn1";
            this.trackBtn1.Size = new System.Drawing.Size(75, 23);
            this.trackBtn1.TabIndex = 50;
            this.trackBtn1.Text = "Track";
            this.trackBtn1.UseVisualStyleBackColor = false;
            this.trackBtn1.Visible = false;
            this.trackBtn1.Click += new System.EventHandler(this.trackBtn1_Click);
            // 
            // resetRoboErrBtn
            // 
            this.resetRoboErrBtn.Location = new System.Drawing.Point(93, 312);
            this.resetRoboErrBtn.Name = "resetRoboErrBtn";
            this.resetRoboErrBtn.Size = new System.Drawing.Size(75, 23);
            this.resetRoboErrBtn.TabIndex = 51;
            this.resetRoboErrBtn.Text = "Reset Error";
            this.resetRoboErrBtn.UseVisualStyleBackColor = true;
            this.resetRoboErrBtn.Visible = false;
            this.resetRoboErrBtn.Click += new System.EventHandler(this.resetRoboErrBtn_Click);
            // 
            // RoboTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.resetRoboErrBtn);
            this.Controls.Add(this.trackBtn1);
            this.Controls.Add(this.returnNestBtn1);
            this.Controls.Add(this.returnNestLab1);
            this.Controls.Add(this.returnHomeBtn);
            this.Controls.Add(this.returnHomeLab1);
            this.Controls.Add(this.comPortInfoLab1);
            this.Controls.Add(this.robotInfoLab1);
            this.Controls.Add(this.comPortDropDownList);
            this.Controls.Add(this.camMarkLab3);
            this.Controls.Add(this.camMarkLab2);
            this.Controls.Add(this.camMarkLab6);
            this.Controls.Add(this.camMarkLab5);
            this.Controls.Add(this.camMarkLab4);
            this.Controls.Add(this.camMarkLab1);
            this.Controls.Add(this.cam2LabY);
            this.Controls.Add(this.cam2LabX);
            this.Controls.Add(this.cam1LabY);
            this.Controls.Add(this.cam1LabX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBarLabel3);
            this.Controls.Add(this.trackBarLabel2);
            this.Controls.Add(this.trackBarLabel1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.cam2_lab);
            this.Controls.Add(this.cam1_lab);
            this.Controls.Add(this.filtered_lab);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.threshold_lab);
            this.Controls.Add(this.normal_lab);
            this.Controls.Add(this.output_lab);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "RoboTrack";
            this.Text = "Obejct Robo Tracker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RoboTrack_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label output_lab;
        private System.Windows.Forms.Label normal_lab;
        private System.Windows.Forms.Label threshold_lab;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label filtered_lab;
        private System.Windows.Forms.Label cam1_lab;
        private System.Windows.Forms.Label cam2_lab;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label trackBarLabel1;
        private System.Windows.Forms.Label trackBarLabel2;
        private System.Windows.Forms.Label trackBarLabel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cam1LabX;
        private System.Windows.Forms.TextBox cam1LabY;
        private System.Windows.Forms.TextBox cam2LabX;
        private System.Windows.Forms.TextBox cam2LabY;
        private System.Windows.Forms.Label camMarkLab1;
        private System.Windows.Forms.Label camMarkLab2;
        private System.Windows.Forms.Label camMarkLab3;
        private System.Windows.Forms.Label camMarkLab4;
        private System.Windows.Forms.Label camMarkLab5;
        private System.Windows.Forms.Label camMarkLab6;
        private System.Windows.Forms.ComboBox comPortDropDownList;
        private System.Windows.Forms.Label robotInfoLab1;
        private System.Windows.Forms.Label comPortInfoLab1;
        private System.Windows.Forms.Label returnHomeLab1;
        private System.Windows.Forms.Button returnHomeBtn;
        private System.Windows.Forms.Label returnNestLab1;
        private System.Windows.Forms.Button returnNestBtn1;
        private System.Windows.Forms.Button trackBtn1;
        private System.Windows.Forms.Button resetRoboErrBtn;
    }
}


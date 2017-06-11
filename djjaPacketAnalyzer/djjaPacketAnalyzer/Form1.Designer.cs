namespace djjaPacketAnalyzer
{
    partial class Form1
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
            this.btnLoadPacket = new System.Windows.Forms.Button();
            this.tboxPacketPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPacketLength = new System.Windows.Forms.Label();
            this.nudRangeStart = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudRangeStop = new System.Windows.Forms.NumericUpDown();
            this.tboxByteBuffer = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSelectedBytesCount = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnTrigger = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.tboxUInt8 = new System.Windows.Forms.TextBox();
            this.tboxInt8 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tboxUInt64 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tboxUInt32 = new System.Windows.Forms.TextBox();
            this.cboxIsBigEndian = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tboxInt64 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tboxStringUnicode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tboxStringUTF8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tboxStringASCII = new System.Windows.Forms.TextBox();
            this.tboxDouble = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxSingle = new System.Windows.Forms.TextBox();
            this.tboxInt32 = new System.Windows.Forms.TextBox();
            this.tboxUInt16 = new System.Windows.Forms.TextBox();
            this.tboxInt16 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxByteArray = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearchInPacket = new System.Windows.Forms.Button();
            this.btnSearchMultiplePackets = new System.Windows.Forms.Button();
            this.tboxSearchConverted = new System.Windows.Forms.TextBox();
            this.lblSearchResult = new System.Windows.Forms.Label();
            this.btnSearchNext = new System.Windows.Forms.Button();
            this.btnSearchPrevious = new System.Windows.Forms.Button();
            this.cboxSearchType = new System.Windows.Forms.ComboBox();
            this.tboxSearchValue = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPayloadToString = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRangeStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRangeStop)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadPacket
            // 
            this.btnLoadPacket.Location = new System.Drawing.Point(917, 12);
            this.btnLoadPacket.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadPacket.Name = "btnLoadPacket";
            this.btnLoadPacket.Size = new System.Drawing.Size(33, 28);
            this.btnLoadPacket.TabIndex = 0;
            this.btnLoadPacket.Text = "...";
            this.btnLoadPacket.UseVisualStyleBackColor = true;
            this.btnLoadPacket.Click += new System.EventHandler(this.btnLoadPacket_Click);
            // 
            // tboxPacketPath
            // 
            this.tboxPacketPath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tboxPacketPath.Location = new System.Drawing.Point(16, 15);
            this.tboxPacketPath.Margin = new System.Windows.Forms.Padding(4);
            this.tboxPacketPath.Name = "tboxPacketPath";
            this.tboxPacketPath.ReadOnly = true;
            this.tboxPacketPath.Size = new System.Drawing.Size(892, 22);
            this.tboxPacketPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Packet Length:";
            // 
            // lblPacketLength
            // 
            this.lblPacketLength.AutoSize = true;
            this.lblPacketLength.Location = new System.Drawing.Point(111, 18);
            this.lblPacketLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPacketLength.Name = "lblPacketLength";
            this.lblPacketLength.Size = new System.Drawing.Size(45, 16);
            this.lblPacketLength.TabIndex = 3;
            this.lblPacketLength.Text = "label2";
            // 
            // nudRangeStart
            // 
            this.nudRangeStart.Location = new System.Drawing.Point(1235, 1348);
            this.nudRangeStart.Margin = new System.Windows.Forms.Padding(4);
            this.nudRangeStart.Name = "nudRangeStart";
            this.nudRangeStart.Size = new System.Drawing.Size(70, 22);
            this.nudRangeStart.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1232, 1328);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Range:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1313, 1350);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "-";
            // 
            // nudRangeStop
            // 
            this.nudRangeStop.Location = new System.Drawing.Point(1333, 1348);
            this.nudRangeStop.Margin = new System.Windows.Forms.Padding(4);
            this.nudRangeStop.Name = "nudRangeStop";
            this.nudRangeStop.Size = new System.Drawing.Size(70, 22);
            this.nudRangeStop.TabIndex = 7;
            // 
            // tboxByteBuffer
            // 
            this.tboxByteBuffer.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tboxByteBuffer.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxByteBuffer.HideSelection = false;
            this.tboxByteBuffer.Location = new System.Drawing.Point(42, 77);
            this.tboxByteBuffer.Multiline = true;
            this.tboxByteBuffer.Name = "tboxByteBuffer";
            this.tboxByteBuffer.ReadOnly = true;
            this.tboxByteBuffer.Size = new System.Drawing.Size(965, 408);
            this.tboxByteBuffer.TabIndex = 14;
            this.tboxByteBuffer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tboxByteBuffer_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblSelectedBytesCount);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.btnTrigger);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.tboxUInt8);
            this.groupBox1.Controls.Add(this.tboxInt8);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.tboxUInt64);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tboxUInt32);
            this.groupBox1.Controls.Add(this.cboxIsBigEndian);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tboxInt64);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tboxStringUnicode);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tboxStringUTF8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tboxStringASCII);
            this.groupBox1.Controls.Add(this.tboxDouble);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tboxSingle);
            this.groupBox1.Controls.Add(this.tboxInt32);
            this.groupBox1.Controls.Add(this.tboxUInt16);
            this.groupBox1.Controls.Add(this.tboxInt16);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tboxByteArray);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboxByteBuffer);
            this.groupBox1.Controls.Add(this.lblPacketLength);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 915);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 731);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(426, 23);
            this.button1.TabIndex = 54;
            this.button1.Text = "Get partystate header unknown bits";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSelectedBytesCount
            // 
            this.lblSelectedBytesCount.AutoSize = true;
            this.lblSelectedBytesCount.Location = new System.Drawing.Point(541, 617);
            this.lblSelectedBytesCount.Name = "lblSelectedBytesCount";
            this.lblSelectedBytesCount.Size = new System.Drawing.Size(139, 16);
            this.lblSelectedBytesCount.TabIndex = 53;
            this.lblSelectedBytesCount.Text = "Selected Bytes Count:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(396, 617);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 16);
            this.label16.TabIndex = 52;
            this.label16.Text = "Selected Bytes Count:";
            // 
            // btnTrigger
            // 
            this.btnTrigger.Location = new System.Drawing.Point(932, 613);
            this.btnTrigger.Name = "btnTrigger";
            this.btnTrigger.Size = new System.Drawing.Size(75, 24);
            this.btnTrigger.TabIndex = 51;
            this.btnTrigger.Text = "Trigger";
            this.btnTrigger.UseVisualStyleBackColor = true;
            this.btnTrigger.Click += new System.EventHandler(this.btnTrigger_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 643);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 16);
            this.label18.TabIndex = 50;
            this.label18.Text = "Unsigned Int8:";
            // 
            // tboxUInt8
            // 
            this.tboxUInt8.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tboxUInt8.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxUInt8.Location = new System.Drawing.Point(124, 641);
            this.tboxUInt8.Multiline = true;
            this.tboxUInt8.Name = "tboxUInt8";
            this.tboxUInt8.ReadOnly = true;
            this.tboxUInt8.Size = new System.Drawing.Size(200, 24);
            this.tboxUInt8.TabIndex = 49;
            // 
            // tboxInt8
            // 
            this.tboxInt8.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tboxInt8.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxInt8.Location = new System.Drawing.Point(124, 611);
            this.tboxInt8.Multiline = true;
            this.tboxInt8.Name = "tboxInt8";
            this.tboxInt8.ReadOnly = true;
            this.tboxInt8.Size = new System.Drawing.Size(200, 24);
            this.tboxInt8.TabIndex = 48;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(87, 613);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 16);
            this.label19.TabIndex = 47;
            this.label19.Text = "int8:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 823);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 16);
            this.label15.TabIndex = 42;
            this.label15.Text = "Unsigned Int64:";
            // 
            // tboxUInt64
            // 
            this.tboxUInt64.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tboxUInt64.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxUInt64.Location = new System.Drawing.Point(124, 821);
            this.tboxUInt64.Multiline = true;
            this.tboxUInt64.Name = "tboxUInt64";
            this.tboxUInt64.ReadOnly = true;
            this.tboxUInt64.Size = new System.Drawing.Size(200, 24);
            this.tboxUInt64.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 763);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 16);
            this.label14.TabIndex = 40;
            this.label14.Text = "Unsigned Int32:";
            // 
            // tboxUInt32
            // 
            this.tboxUInt32.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tboxUInt32.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxUInt32.Location = new System.Drawing.Point(124, 761);
            this.tboxUInt32.Multiline = true;
            this.tboxUInt32.Name = "tboxUInt32";
            this.tboxUInt32.ReadOnly = true;
            this.tboxUInt32.Size = new System.Drawing.Size(200, 24);
            this.tboxUInt32.TabIndex = 39;
            // 
            // cboxIsBigEndian
            // 
            this.cboxIsBigEndian.AutoSize = true;
            this.cboxIsBigEndian.Checked = true;
            this.cboxIsBigEndian.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxIsBigEndian.Location = new System.Drawing.Point(909, 14);
            this.cboxIsBigEndian.Name = "cboxIsBigEndian";
            this.cboxIsBigEndian.Size = new System.Drawing.Size(105, 20);
            this.cboxIsBigEndian.TabIndex = 15;
            this.cboxIsBigEndian.Text = "Is Big Endian";
            this.cboxIsBigEndian.UseVisualStyleBackColor = true;
            this.cboxIsBigEndian.CheckedChanged += new System.EventHandler(this.cboxIsBigEndian_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(80, 793);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 16);
            this.label13.TabIndex = 38;
            this.label13.Text = "Int64:";
            // 
            // tboxInt64
            // 
            this.tboxInt64.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tboxInt64.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxInt64.Location = new System.Drawing.Point(124, 791);
            this.tboxInt64.Multiline = true;
            this.tboxInt64.Name = "tboxInt64";
            this.tboxInt64.ReadOnly = true;
            this.tboxInt64.Size = new System.Drawing.Size(200, 24);
            this.tboxInt64.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 583);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 16);
            this.label12.TabIndex = 36;
            this.label12.Text = "String (Unicode):";
            // 
            // tboxStringUnicode
            // 
            this.tboxStringUnicode.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tboxStringUnicode.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxStringUnicode.Location = new System.Drawing.Point(124, 581);
            this.tboxStringUnicode.Multiline = true;
            this.tboxStringUnicode.Name = "tboxStringUnicode";
            this.tboxStringUnicode.ReadOnly = true;
            this.tboxStringUnicode.Size = new System.Drawing.Size(883, 24);
            this.tboxStringUnicode.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 553);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "String (UTF-8):";
            // 
            // tboxStringUTF8
            // 
            this.tboxStringUTF8.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tboxStringUTF8.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxStringUTF8.Location = new System.Drawing.Point(124, 551);
            this.tboxStringUTF8.Multiline = true;
            this.tboxStringUTF8.Name = "tboxStringUTF8";
            this.tboxStringUTF8.ReadOnly = true;
            this.tboxStringUTF8.Size = new System.Drawing.Size(883, 24);
            this.tboxStringUTF8.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 523);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "String (ASCII):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 883);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Double:";
            // 
            // tboxStringASCII
            // 
            this.tboxStringASCII.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tboxStringASCII.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxStringASCII.Location = new System.Drawing.Point(124, 521);
            this.tboxStringASCII.Multiline = true;
            this.tboxStringASCII.Name = "tboxStringASCII";
            this.tboxStringASCII.ReadOnly = true;
            this.tboxStringASCII.Size = new System.Drawing.Size(883, 24);
            this.tboxStringASCII.TabIndex = 30;
            // 
            // tboxDouble
            // 
            this.tboxDouble.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tboxDouble.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDouble.Location = new System.Drawing.Point(124, 881);
            this.tboxDouble.Multiline = true;
            this.tboxDouble.Name = "tboxDouble";
            this.tboxDouble.ReadOnly = true;
            this.tboxDouble.Size = new System.Drawing.Size(200, 24);
            this.tboxDouble.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 853);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Float:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 733);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Int32:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 703);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Unsigned Int16:";
            // 
            // tboxSingle
            // 
            this.tboxSingle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tboxSingle.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxSingle.Location = new System.Drawing.Point(124, 851);
            this.tboxSingle.Multiline = true;
            this.tboxSingle.Name = "tboxSingle";
            this.tboxSingle.ReadOnly = true;
            this.tboxSingle.Size = new System.Drawing.Size(200, 24);
            this.tboxSingle.TabIndex = 25;
            // 
            // tboxInt32
            // 
            this.tboxInt32.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tboxInt32.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxInt32.Location = new System.Drawing.Point(124, 731);
            this.tboxInt32.Multiline = true;
            this.tboxInt32.Name = "tboxInt32";
            this.tboxInt32.ReadOnly = true;
            this.tboxInt32.Size = new System.Drawing.Size(200, 24);
            this.tboxInt32.TabIndex = 24;
            // 
            // tboxUInt16
            // 
            this.tboxUInt16.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tboxUInt16.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxUInt16.Location = new System.Drawing.Point(124, 701);
            this.tboxUInt16.Multiline = true;
            this.tboxUInt16.Name = "tboxUInt16";
            this.tboxUInt16.ReadOnly = true;
            this.tboxUInt16.Size = new System.Drawing.Size(200, 24);
            this.tboxUInt16.TabIndex = 23;
            // 
            // tboxInt16
            // 
            this.tboxInt16.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tboxInt16.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxInt16.Location = new System.Drawing.Point(124, 671);
            this.tboxInt16.Multiline = true;
            this.tboxInt16.Name = "tboxInt16";
            this.tboxInt16.ReadOnly = true;
            this.tboxInt16.Size = new System.Drawing.Size(200, 24);
            this.tboxInt16.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 673);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Int16:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Byte Array:";
            // 
            // tboxByteArray
            // 
            this.tboxByteArray.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tboxByteArray.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxByteArray.Location = new System.Drawing.Point(124, 491);
            this.tboxByteArray.Multiline = true;
            this.tboxByteArray.Name = "tboxByteArray";
            this.tboxByteArray.ReadOnly = true;
            this.tboxByteArray.Size = new System.Drawing.Size(883, 24);
            this.tboxByteArray.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(6, 77);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(30, 408);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "01\r\n02\r\n03\r\n04\r\n05\r\n06\r\n07\r\n08\r\n09\r\n10\r\n11\r\n12\r\n13\r\n14\r\n15\r\n16\r\n17\r\n18\r\n19\r\n20\r\n2" +
                "1\r\n22\r\n23\r\n24\r\n25";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(42, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(965, 24);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "01 02 03 04 05 06 07 08 09 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 " +
                "28 29 30 31 32 33 34 35 36 37 38 39 40";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearchInPacket);
            this.groupBox2.Controls.Add(this.btnSearchMultiplePackets);
            this.groupBox2.Controls.Add(this.tboxSearchConverted);
            this.groupBox2.Controls.Add(this.lblSearchResult);
            this.groupBox2.Controls.Add(this.btnSearchNext);
            this.groupBox2.Controls.Add(this.btnSearchPrevious);
            this.groupBox2.Controls.Add(this.cboxSearchType);
            this.groupBox2.Controls.Add(this.tboxSearchValue);
            this.groupBox2.Location = new System.Drawing.Point(1038, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 198);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search in packet";
            // 
            // btnSearchInPacket
            // 
            this.btnSearchInPacket.Location = new System.Drawing.Point(6, 110);
            this.btnSearchInPacket.Name = "btnSearchInPacket";
            this.btnSearchInPacket.Size = new System.Drawing.Size(418, 23);
            this.btnSearchInPacket.TabIndex = 58;
            this.btnSearchInPacket.Text = "Search in Packet...";
            this.btnSearchInPacket.UseVisualStyleBackColor = true;
            this.btnSearchInPacket.Click += new System.EventHandler(this.btnSearchInPacket_Click);
            // 
            // btnSearchMultiplePackets
            // 
            this.btnSearchMultiplePackets.Location = new System.Drawing.Point(6, 168);
            this.btnSearchMultiplePackets.Name = "btnSearchMultiplePackets";
            this.btnSearchMultiplePackets.Size = new System.Drawing.Size(418, 23);
            this.btnSearchMultiplePackets.TabIndex = 57;
            this.btnSearchMultiplePackets.Text = "Search Packets For...";
            this.btnSearchMultiplePackets.UseVisualStyleBackColor = true;
            this.btnSearchMultiplePackets.Click += new System.EventHandler(this.btnSearchMultiplePackets_Click);
            // 
            // tboxSearchConverted
            // 
            this.tboxSearchConverted.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tboxSearchConverted.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxSearchConverted.Location = new System.Drawing.Point(6, 82);
            this.tboxSearchConverted.Name = "tboxSearchConverted";
            this.tboxSearchConverted.ReadOnly = true;
            this.tboxSearchConverted.Size = new System.Drawing.Size(418, 22);
            this.tboxSearchConverted.TabIndex = 56;
            // 
            // lblSearchResult
            // 
            this.lblSearchResult.Location = new System.Drawing.Point(162, 138);
            this.lblSearchResult.Name = "lblSearchResult";
            this.lblSearchResult.Size = new System.Drawing.Size(106, 24);
            this.lblSearchResult.TabIndex = 55;
            this.lblSearchResult.Text = "label20";
            this.lblSearchResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearchNext
            // 
            this.btnSearchNext.Location = new System.Drawing.Point(274, 139);
            this.btnSearchNext.Name = "btnSearchNext";
            this.btnSearchNext.Size = new System.Drawing.Size(150, 23);
            this.btnSearchNext.TabIndex = 54;
            this.btnSearchNext.Text = "Next";
            this.btnSearchNext.UseVisualStyleBackColor = true;
            this.btnSearchNext.Click += new System.EventHandler(this.btnSearchNext_Click);
            // 
            // btnSearchPrevious
            // 
            this.btnSearchPrevious.Location = new System.Drawing.Point(6, 139);
            this.btnSearchPrevious.Name = "btnSearchPrevious";
            this.btnSearchPrevious.Size = new System.Drawing.Size(150, 23);
            this.btnSearchPrevious.TabIndex = 53;
            this.btnSearchPrevious.Text = "Previous";
            this.btnSearchPrevious.UseVisualStyleBackColor = true;
            this.btnSearchPrevious.Click += new System.EventHandler(this.btnSearchPrevious_Click);
            // 
            // cboxSearchType
            // 
            this.cboxSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSearchType.FormattingEnabled = true;
            this.cboxSearchType.Items.AddRange(new object[] {
            "Byte Array (HEX)",
            "String ASCII",
            "String UTF-8",
            "String Unicode",
            "Integer",
            "Unsigned Integer",
            "Float",
            "Double"});
            this.cboxSearchType.Location = new System.Drawing.Point(6, 21);
            this.cboxSearchType.Name = "cboxSearchType";
            this.cboxSearchType.Size = new System.Drawing.Size(418, 24);
            this.cboxSearchType.TabIndex = 52;
            this.cboxSearchType.SelectedIndexChanged += new System.EventHandler(this.tboxSearchValue_TextChanged);
            // 
            // tboxSearchValue
            // 
            this.tboxSearchValue.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tboxSearchValue.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxSearchValue.Location = new System.Drawing.Point(6, 54);
            this.tboxSearchValue.Name = "tboxSearchValue";
            this.tboxSearchValue.Size = new System.Drawing.Size(418, 22);
            this.tboxSearchValue.TabIndex = 51;
            this.tboxSearchValue.TextChanged += new System.EventHandler(this.tboxSearchValue_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPayloadToString);
            this.groupBox3.Location = new System.Drawing.Point(1038, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 255);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Call of Duty: Modern Warfare 2";
            // 
            // btnPayloadToString
            // 
            this.btnPayloadToString.Location = new System.Drawing.Point(6, 21);
            this.btnPayloadToString.Name = "btnPayloadToString";
            this.btnPayloadToString.Size = new System.Drawing.Size(418, 24);
            this.btnPayloadToString.TabIndex = 0;
            this.btnPayloadToString.Text = "Payload to String";
            this.btnPayloadToString.UseVisualStyleBackColor = true;
            this.btnPayloadToString.Click += new System.EventHandler(this.btnPayloadToString_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(502, 816);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(394, 23);
            this.button2.TabIndex = 55;
            this.button2.Text = "Same as above, but for every packet in the current root folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 975);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tboxPacketPath);
            this.Controls.Add(this.btnLoadPacket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudRangeStop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudRangeStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Packet Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.nudRangeStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRangeStop)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadPacket;
        private System.Windows.Forms.TextBox tboxPacketPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPacketLength;
        private System.Windows.Forms.NumericUpDown nudRangeStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudRangeStop;
        private System.Windows.Forms.TextBox tboxByteBuffer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cboxIsBigEndian;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tboxStringASCII;
        private System.Windows.Forms.TextBox tboxDouble;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxSingle;
        private System.Windows.Forms.TextBox tboxInt32;
        private System.Windows.Forms.TextBox tboxUInt16;
        private System.Windows.Forms.TextBox tboxInt16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxByteArray;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tboxStringUnicode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tboxStringUTF8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tboxInt64;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tboxUInt32;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tboxUInt64;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tboxUInt8;
        private System.Windows.Forms.TextBox tboxInt8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboxSearchType;
        private System.Windows.Forms.TextBox tboxSearchValue;
        private System.Windows.Forms.Label lblSearchResult;
        private System.Windows.Forms.Button btnSearchNext;
        private System.Windows.Forms.Button btnSearchPrevious;
        private System.Windows.Forms.TextBox tboxSearchConverted;
        private System.Windows.Forms.Button btnSearchMultiplePackets;
        private System.Windows.Forms.Button btnSearchInPacket;
        private System.Windows.Forms.Button btnTrigger;
        private System.Windows.Forms.Label lblSelectedBytesCount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPayloadToString;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


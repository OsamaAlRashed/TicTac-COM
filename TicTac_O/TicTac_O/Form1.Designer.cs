
namespace TicTac_O
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort_O = new System.IO.Ports.SerialPort(this.components);
            this.Score_O = new System.Windows.Forms.Button();
            this.Score_X = new System.Windows.Forms.Button();
            this.Finish = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Default_Setting = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboParity = new System.Windows.Forms.ComboBox();
            this.comboStopBox = new System.Windows.Forms.ComboBox();
            this.comboBaudRate = new System.Windows.Forms.ComboBox();
            this.comboDataBit = new System.Windows.Forms.ComboBox();
            this.comboPortName = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TicTac1_1 = new System.Windows.Forms.PictureBox();
            this.TicTac1_2 = new System.Windows.Forms.PictureBox();
            this.TicTac1_3 = new System.Windows.Forms.PictureBox();
            this.TicTac2_1 = new System.Windows.Forms.PictureBox();
            this.TicTac2_2 = new System.Windows.Forms.PictureBox();
            this.TicTac2_3 = new System.Windows.Forms.PictureBox();
            this.TicTac3_1 = new System.Windows.Forms.PictureBox();
            this.TicTac3_2 = new System.Windows.Forms.PictureBox();
            this.TicTac3_3 = new System.Windows.Forms.PictureBox();
            this.Label_Result = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicTac1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicTac1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicTac1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicTac2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicTac2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicTac2_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicTac3_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicTac3_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicTac3_3)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort_O
            // 
            this.serialPort_O.DataBits = 5;
            this.serialPort_O.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_O_DataReceived);
            // 
            // Score_O
            // 
            this.Score_O.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Score_O.ForeColor = System.Drawing.Color.Black;
            this.Score_O.Location = new System.Drawing.Point(428, 34);
            this.Score_O.Name = "Score_O";
            this.Score_O.Size = new System.Drawing.Size(56, 41);
            this.Score_O.TabIndex = 45;
            this.Score_O.UseVisualStyleBackColor = false;
            this.Score_O.Click += new System.EventHandler(this.Score_O_Click);
            // 
            // Score_X
            // 
            this.Score_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Score_X.ForeColor = System.Drawing.Color.Black;
            this.Score_X.Location = new System.Drawing.Point(366, 34);
            this.Score_X.Name = "Score_X";
            this.Score_X.Size = new System.Drawing.Size(56, 41);
            this.Score_X.TabIndex = 44;
            this.Score_X.UseVisualStyleBackColor = false;
            // 
            // Finish
            // 
            this.Finish.Location = new System.Drawing.Point(280, 376);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(110, 40);
            this.Finish.TabIndex = 43;
            this.Finish.Text = "Finish";
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(154, 376);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(110, 40);
            this.Start.TabIndex = 42;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Default_Setting
            // 
            this.Default_Setting.Location = new System.Drawing.Point(30, 376);
            this.Default_Setting.Name = "Default_Setting";
            this.Default_Setting.Size = new System.Drawing.Size(118, 40);
            this.Default_Setting.TabIndex = 41;
            this.Default_Setting.Text = "Default Setting";
            this.Default_Setting.UseVisualStyleBackColor = true;
            this.Default_Setting.Click += new System.EventHandler(this.Default_Setting_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.comboParity);
            this.groupBox3.Controls.Add(this.comboStopBox);
            this.groupBox3.Controls.Add(this.comboBaudRate);
            this.groupBox3.Controls.Add(this.comboDataBit);
            this.groupBox3.Controls.Add(this.comboPortName);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox3.Location = new System.Drawing.Point(30, 85);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(368, 271);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Com setting";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 228);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Parity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Stop Bit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "BaudRate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "DataBit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "PortName";
            // 
            // comboParity
            // 
            this.comboParity.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboParity.FormattingEnabled = true;
            this.comboParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.comboParity.Location = new System.Drawing.Point(176, 228);
            this.comboParity.Margin = new System.Windows.Forms.Padding(4);
            this.comboParity.Name = "comboParity";
            this.comboParity.Size = new System.Drawing.Size(160, 29);
            this.comboParity.TabIndex = 17;
            // 
            // comboStopBox
            // 
            this.comboStopBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStopBox.FormattingEnabled = true;
            this.comboStopBox.Items.AddRange(new object[] {
            "One",
            "Two",
            "OneFivePoint"});
            this.comboStopBox.Location = new System.Drawing.Point(176, 181);
            this.comboStopBox.Margin = new System.Windows.Forms.Padding(4);
            this.comboStopBox.Name = "comboStopBox";
            this.comboStopBox.Size = new System.Drawing.Size(160, 29);
            this.comboStopBox.TabIndex = 16;
            // 
            // comboBaudRate
            // 
            this.comboBaudRate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBaudRate.FormattingEnabled = true;
            this.comboBaudRate.Items.AddRange(new object[] {
            "9600",
            "1155",
            "4800",
            "19200"});
            this.comboBaudRate.Location = new System.Drawing.Point(176, 133);
            this.comboBaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBaudRate.Name = "comboBaudRate";
            this.comboBaudRate.Size = new System.Drawing.Size(160, 29);
            this.comboBaudRate.TabIndex = 15;
            // 
            // comboDataBit
            // 
            this.comboDataBit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDataBit.FormattingEnabled = true;
            this.comboDataBit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboDataBit.Location = new System.Drawing.Point(176, 85);
            this.comboDataBit.Margin = new System.Windows.Forms.Padding(4);
            this.comboDataBit.Name = "comboDataBit";
            this.comboDataBit.Size = new System.Drawing.Size(160, 29);
            this.comboDataBit.TabIndex = 14;
            // 
            // comboPortName
            // 
            this.comboPortName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPortName.FormattingEnabled = true;
            this.comboPortName.Items.AddRange(new object[] {
            "COM1"});
            this.comboPortName.Location = new System.Drawing.Point(176, 38);
            this.comboPortName.Margin = new System.Windows.Forms.Padding(4);
            this.comboPortName.Name = "comboPortName";
            this.comboPortName.Size = new System.Drawing.Size(160, 29);
            this.comboPortName.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(471, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // TicTac1_1
            // 
            this.TicTac1_1.Location = new System.Drawing.Point(486, 109);
            this.TicTac1_1.Name = "TicTac1_1";
            this.TicTac1_1.Size = new System.Drawing.Size(70, 70);
            this.TicTac1_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TicTac1_1.TabIndex = 31;
            this.TicTac1_1.TabStop = false;
            this.TicTac1_1.Click += new System.EventHandler(this.TicTac1_1_Click);
            // 
            // TicTac1_2
            // 
            this.TicTac1_2.Location = new System.Drawing.Point(586, 109);
            this.TicTac1_2.Name = "TicTac1_2";
            this.TicTac1_2.Size = new System.Drawing.Size(70, 70);
            this.TicTac1_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TicTac1_2.TabIndex = 32;
            this.TicTac1_2.TabStop = false;
            this.TicTac1_2.Click += new System.EventHandler(this.TicTac1_2_Click);
            // 
            // TicTac1_3
            // 
            this.TicTac1_3.Location = new System.Drawing.Point(685, 109);
            this.TicTac1_3.Name = "TicTac1_3";
            this.TicTac1_3.Size = new System.Drawing.Size(70, 70);
            this.TicTac1_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TicTac1_3.TabIndex = 33;
            this.TicTac1_3.TabStop = false;
            this.TicTac1_3.Click += new System.EventHandler(this.TicTac1_3_Click);
            // 
            // TicTac2_1
            // 
            this.TicTac2_1.Location = new System.Drawing.Point(486, 209);
            this.TicTac2_1.Name = "TicTac2_1";
            this.TicTac2_1.Size = new System.Drawing.Size(70, 70);
            this.TicTac2_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TicTac2_1.TabIndex = 34;
            this.TicTac2_1.TabStop = false;
            this.TicTac2_1.Click += new System.EventHandler(this.TicTac2_1_Click);
            // 
            // TicTac2_2
            // 
            this.TicTac2_2.Location = new System.Drawing.Point(586, 209);
            this.TicTac2_2.Name = "TicTac2_2";
            this.TicTac2_2.Size = new System.Drawing.Size(70, 70);
            this.TicTac2_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TicTac2_2.TabIndex = 35;
            this.TicTac2_2.TabStop = false;
            this.TicTac2_2.Click += new System.EventHandler(this.TicTac2_2_Click);
            // 
            // TicTac2_3
            // 
            this.TicTac2_3.Location = new System.Drawing.Point(685, 209);
            this.TicTac2_3.Name = "TicTac2_3";
            this.TicTac2_3.Size = new System.Drawing.Size(70, 70);
            this.TicTac2_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TicTac2_3.TabIndex = 36;
            this.TicTac2_3.TabStop = false;
            this.TicTac2_3.Click += new System.EventHandler(this.TicTac2_3_Click);
            // 
            // TicTac3_1
            // 
            this.TicTac3_1.Location = new System.Drawing.Point(486, 308);
            this.TicTac3_1.Name = "TicTac3_1";
            this.TicTac3_1.Size = new System.Drawing.Size(70, 70);
            this.TicTac3_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TicTac3_1.TabIndex = 37;
            this.TicTac3_1.TabStop = false;
            this.TicTac3_1.Click += new System.EventHandler(this.TicTac3_1_Click);
            // 
            // TicTac3_2
            // 
            this.TicTac3_2.Location = new System.Drawing.Point(586, 308);
            this.TicTac3_2.Name = "TicTac3_2";
            this.TicTac3_2.Size = new System.Drawing.Size(70, 70);
            this.TicTac3_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TicTac3_2.TabIndex = 38;
            this.TicTac3_2.TabStop = false;
            this.TicTac3_2.Click += new System.EventHandler(this.TicTac3_2_Click);
            // 
            // TicTac3_3
            // 
            this.TicTac3_3.Location = new System.Drawing.Point(685, 308);
            this.TicTac3_3.Name = "TicTac3_3";
            this.TicTac3_3.Size = new System.Drawing.Size(70, 70);
            this.TicTac3_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TicTac3_3.TabIndex = 39;
            this.TicTac3_3.TabStop = false;
            this.TicTac3_3.Click += new System.EventHandler(this.TicTac3_3_Click);
            // 
            // Label_Result
            // 
            this.Label_Result.AutoSize = true;
            this.Label_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Result.Location = new System.Drawing.Point(618, 395);
            this.Label_Result.Name = "Label_Result";
            this.Label_Result.Size = new System.Drawing.Size(0, 20);
            this.Label_Result.TabIndex = 46;
            this.Label_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_Result);
            this.Controls.Add(this.Score_O);
            this.Controls.Add(this.Score_X);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Default_Setting);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.TicTac3_3);
            this.Controls.Add(this.TicTac3_2);
            this.Controls.Add(this.TicTac3_1);
            this.Controls.Add(this.TicTac2_3);
            this.Controls.Add(this.TicTac2_2);
            this.Controls.Add(this.TicTac2_1);
            this.Controls.Add(this.TicTac1_3);
            this.Controls.Add(this.TicTac1_2);
            this.Controls.Add(this.TicTac1_1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Player_O";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicTac1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicTac1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicTac1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicTac2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicTac2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicTac2_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicTac3_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicTac3_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicTac3_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort_O;
        private System.Windows.Forms.Button Score_O;
        private System.Windows.Forms.Button Score_X;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Default_Setting;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboParity;
        private System.Windows.Forms.ComboBox comboStopBox;
        private System.Windows.Forms.ComboBox comboBaudRate;
        private System.Windows.Forms.ComboBox comboDataBit;
        private System.Windows.Forms.ComboBox comboPortName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox TicTac1_1;
        private System.Windows.Forms.PictureBox TicTac1_2;
        private System.Windows.Forms.PictureBox TicTac1_3;
        private System.Windows.Forms.PictureBox TicTac2_1;
        private System.Windows.Forms.PictureBox TicTac2_2;
        private System.Windows.Forms.PictureBox TicTac2_3;
        private System.Windows.Forms.PictureBox TicTac3_1;
        private System.Windows.Forms.PictureBox TicTac3_2;
        private System.Windows.Forms.PictureBox TicTac3_3;
        private System.Windows.Forms.Label Label_Result;
    }
}


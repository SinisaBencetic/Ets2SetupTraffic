namespace Ets2SetupTraffic
{
    partial class MainForm
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTruckMinSpeed = new System.Windows.Forms.TextBox();
            this.txtTruckMaxSpeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCarMaxSpeed = new System.Windows.Forms.TextBox();
            this.txtCarMinSpeed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBusMaxSpeed = new System.Windows.Forms.TextBox();
            this.txtBusMinSpeed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSinTruckCycleMultiplier = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSinTruckSpikeZone = new System.Windows.Forms.TextBox();
            this.txtSinTruckSpikeFactor = new System.Windows.Forms.TextBox();
            this.btnSinSpikeGenerate = new System.Windows.Forms.Button();
            this.txtSinBusMinCritical = new System.Windows.Forms.TextBox();
            this.txtSinBusMax = new System.Windows.Forms.TextBox();
            this.txtSinBusMin = new System.Windows.Forms.TextBox();
            this.txtSinCarMinCritical = new System.Windows.Forms.TextBox();
            this.txtSinCarMax = new System.Windows.Forms.TextBox();
            this.txtSinCarMin = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSinTruckMinCritical = new System.Windows.Forms.TextBox();
            this.txtSinTruckMax = new System.Windows.Forms.TextBox();
            this.txtSinTruckMin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTruckDebug = new System.Windows.Forms.Button();
            this.btnCarDebug = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSinSpikeCarCycleMultiplier = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSinSpikeCarZone = new System.Windows.Forms.TextBox();
            this.txtSinSpikeCarSpikeFactor = new System.Windows.Forms.TextBox();
            this.btnSinSpikeBusDebug = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.txtSinBusCycleMultiplier = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtSinBusSpikeZone = new System.Windows.Forms.TextBox();
            this.txtSinBusSpikeFactor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(13, 13);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Truck";
            // 
            // txtTruckMinSpeed
            // 
            this.txtTruckMinSpeed.Location = new System.Drawing.Point(86, 85);
            this.txtTruckMinSpeed.Name = "txtTruckMinSpeed";
            this.txtTruckMinSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtTruckMinSpeed.TabIndex = 2;
            // 
            // txtTruckMaxSpeed
            // 
            this.txtTruckMaxSpeed.Location = new System.Drawing.Point(277, 85);
            this.txtTruckMaxSpeed.Name = "txtTruckMaxSpeed";
            this.txtTruckMaxSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtTruckMaxSpeed.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Min speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Max speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Max speed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Min speed";
            // 
            // txtCarMaxSpeed
            // 
            this.txtCarMaxSpeed.Location = new System.Drawing.Point(277, 165);
            this.txtCarMaxSpeed.Name = "txtCarMaxSpeed";
            this.txtCarMaxSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtCarMaxSpeed.TabIndex = 8;
            // 
            // txtCarMinSpeed
            // 
            this.txtCarMinSpeed.Location = new System.Drawing.Point(86, 165);
            this.txtCarMinSpeed.Name = "txtCarMinSpeed";
            this.txtCarMinSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtCarMinSpeed.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cars";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Max speed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Min speed";
            // 
            // txtBusMaxSpeed
            // 
            this.txtBusMaxSpeed.Location = new System.Drawing.Point(277, 215);
            this.txtBusMaxSpeed.Name = "txtBusMaxSpeed";
            this.txtBusMaxSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtBusMaxSpeed.TabIndex = 12;
            // 
            // txtBusMinSpeed
            // 
            this.txtBusMinSpeed.Location = new System.Drawing.Point(86, 215);
            this.txtBusMinSpeed.Name = "txtBusMinSpeed";
            this.txtBusMinSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtBusMinSpeed.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Bus";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSinSpikeBusDebug);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txtSinBusCycleMultiplier);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.txtSinBusSpikeZone);
            this.panel1.Controls.Add(this.txtSinBusSpikeFactor);
            this.panel1.Controls.Add(this.btnCarDebug);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtSinSpikeCarCycleMultiplier);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.txtSinSpikeCarZone);
            this.panel1.Controls.Add(this.txtSinSpikeCarSpikeFactor);
            this.panel1.Controls.Add(this.btnTruckDebug);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtSinTruckCycleMultiplier);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtSinTruckSpikeZone);
            this.panel1.Controls.Add(this.txtSinTruckSpikeFactor);
            this.panel1.Controls.Add(this.btnSinSpikeGenerate);
            this.panel1.Controls.Add(this.txtSinBusMinCritical);
            this.panel1.Controls.Add(this.txtSinBusMax);
            this.panel1.Controls.Add(this.txtSinBusMin);
            this.panel1.Controls.Add(this.txtSinCarMinCritical);
            this.panel1.Controls.Add(this.txtSinCarMax);
            this.panel1.Controls.Add(this.txtSinCarMin);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtSinTruckMinCritical);
            this.panel1.Controls.Add(this.txtSinTruckMax);
            this.panel1.Controls.Add(this.txtSinTruckMin);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(436, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 401);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(867, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Sinus cycle multiplier";
            // 
            // txtSinTruckCycleMultiplier
            // 
            this.txtSinTruckCycleMultiplier.Location = new System.Drawing.Point(870, 66);
            this.txtSinTruckCycleMultiplier.Name = "txtSinTruckCycleMultiplier";
            this.txtSinTruckCycleMultiplier.Size = new System.Drawing.Size(100, 20);
            this.txtSinTruckCycleMultiplier.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(655, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(167, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Spike zone - smaller -> less spikes";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(439, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Spike factor - smaller -> bigger spike";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtSinTruckSpikeZone
            // 
            this.txtSinTruckSpikeZone.Location = new System.Drawing.Point(658, 66);
            this.txtSinTruckSpikeZone.Name = "txtSinTruckSpikeZone";
            this.txtSinTruckSpikeZone.Size = new System.Drawing.Size(100, 20);
            this.txtSinTruckSpikeZone.TabIndex = 30;
            // 
            // txtSinTruckSpikeFactor
            // 
            this.txtSinTruckSpikeFactor.Location = new System.Drawing.Point(442, 66);
            this.txtSinTruckSpikeFactor.Name = "txtSinTruckSpikeFactor";
            this.txtSinTruckSpikeFactor.Size = new System.Drawing.Size(100, 20);
            this.txtSinTruckSpikeFactor.TabIndex = 29;
            // 
            // btnSinSpikeGenerate
            // 
            this.btnSinSpikeGenerate.Location = new System.Drawing.Point(41, 309);
            this.btnSinSpikeGenerate.Name = "btnSinSpikeGenerate";
            this.btnSinSpikeGenerate.Size = new System.Drawing.Size(383, 23);
            this.btnSinSpikeGenerate.TabIndex = 17;
            this.btnSinSpikeGenerate.Text = "Sinus Spike Generate";
            this.btnSinSpikeGenerate.UseVisualStyleBackColor = true;
            this.btnSinSpikeGenerate.Click += new System.EventHandler(this.btnSinSpikeGenerate_Click);
            // 
            // txtSinBusMinCritical
            // 
            this.txtSinBusMinCritical.Location = new System.Drawing.Point(324, 237);
            this.txtSinBusMinCritical.Name = "txtSinBusMinCritical";
            this.txtSinBusMinCritical.Size = new System.Drawing.Size(100, 20);
            this.txtSinBusMinCritical.TabIndex = 28;
            // 
            // txtSinBusMax
            // 
            this.txtSinBusMax.Location = new System.Drawing.Point(207, 237);
            this.txtSinBusMax.Name = "txtSinBusMax";
            this.txtSinBusMax.Size = new System.Drawing.Size(100, 20);
            this.txtSinBusMax.TabIndex = 27;
            // 
            // txtSinBusMin
            // 
            this.txtSinBusMin.Location = new System.Drawing.Point(88, 237);
            this.txtSinBusMin.Name = "txtSinBusMin";
            this.txtSinBusMin.Size = new System.Drawing.Size(100, 20);
            this.txtSinBusMin.TabIndex = 26;
            // 
            // txtSinCarMinCritical
            // 
            this.txtSinCarMinCritical.Location = new System.Drawing.Point(324, 146);
            this.txtSinCarMinCritical.Name = "txtSinCarMinCritical";
            this.txtSinCarMinCritical.Size = new System.Drawing.Size(100, 20);
            this.txtSinCarMinCritical.TabIndex = 25;
            // 
            // txtSinCarMax
            // 
            this.txtSinCarMax.Location = new System.Drawing.Point(207, 146);
            this.txtSinCarMax.Name = "txtSinCarMax";
            this.txtSinCarMax.Size = new System.Drawing.Size(100, 20);
            this.txtSinCarMax.TabIndex = 24;
            // 
            // txtSinCarMin
            // 
            this.txtSinCarMin.Location = new System.Drawing.Point(88, 146);
            this.txtSinCarMin.Name = "txtSinCarMin";
            this.txtSinCarMin.Size = new System.Drawing.Size(100, 20);
            this.txtSinCarMin.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(200, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Min, Max, Min Critical";
            // 
            // txtSinTruckMinCritical
            // 
            this.txtSinTruckMinCritical.Location = new System.Drawing.Point(324, 66);
            this.txtSinTruckMinCritical.Name = "txtSinTruckMinCritical";
            this.txtSinTruckMinCritical.Size = new System.Drawing.Size(100, 20);
            this.txtSinTruckMinCritical.TabIndex = 21;
            this.txtSinTruckMinCritical.TextChanged += new System.EventHandler(this.txtSinTruckMinCritical_TextChanged);
            // 
            // txtSinTruckMax
            // 
            this.txtSinTruckMax.Location = new System.Drawing.Point(207, 66);
            this.txtSinTruckMax.Name = "txtSinTruckMax";
            this.txtSinTruckMax.Size = new System.Drawing.Size(100, 20);
            this.txtSinTruckMax.TabIndex = 20;
            this.txtSinTruckMax.TextChanged += new System.EventHandler(this.txtSinTruckMax_TextChanged);
            // 
            // txtSinTruckMin
            // 
            this.txtSinTruckMin.Location = new System.Drawing.Point(88, 66);
            this.txtSinTruckMin.Name = "txtSinTruckMin";
            this.txtSinTruckMin.Size = new System.Drawing.Size(100, 20);
            this.txtSinTruckMin.TabIndex = 19;
            this.txtSinTruckMin.TextChanged += new System.EventHandler(this.txtSinTruckMin_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Bus";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Cars";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Truck";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sinus spike";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnTruckDebug
            // 
            this.btnTruckDebug.Location = new System.Drawing.Point(998, 66);
            this.btnTruckDebug.Name = "btnTruckDebug";
            this.btnTruckDebug.Size = new System.Drawing.Size(75, 23);
            this.btnTruckDebug.TabIndex = 17;
            this.btnTruckDebug.Text = "Debug";
            this.btnTruckDebug.UseVisualStyleBackColor = true;
            this.btnTruckDebug.Click += new System.EventHandler(this.btnTruckDebug_Click);
            // 
            // btnCarDebug
            // 
            this.btnCarDebug.Location = new System.Drawing.Point(998, 146);
            this.btnCarDebug.Name = "btnCarDebug";
            this.btnCarDebug.Size = new System.Drawing.Size(75, 23);
            this.btnCarDebug.TabIndex = 35;
            this.btnCarDebug.Text = "Debug";
            this.btnCarDebug.UseVisualStyleBackColor = true;
            this.btnCarDebug.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(867, 118);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 13);
            this.label18.TabIndex = 41;
            this.label18.Text = "Sinus cycle multiplier";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // txtSinSpikeCarCycleMultiplier
            // 
            this.txtSinSpikeCarCycleMultiplier.Location = new System.Drawing.Point(870, 146);
            this.txtSinSpikeCarCycleMultiplier.Name = "txtSinSpikeCarCycleMultiplier";
            this.txtSinSpikeCarCycleMultiplier.Size = new System.Drawing.Size(100, 20);
            this.txtSinSpikeCarCycleMultiplier.TabIndex = 40;
            this.txtSinSpikeCarCycleMultiplier.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(655, 118);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(167, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "Spike zone - smaller -> less spikes";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(439, 118);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(177, 13);
            this.label20.TabIndex = 38;
            this.label20.Text = "Spike factor - smaller -> bigger spike";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // txtSinSpikeCarZone
            // 
            this.txtSinSpikeCarZone.Location = new System.Drawing.Point(658, 146);
            this.txtSinSpikeCarZone.Name = "txtSinSpikeCarZone";
            this.txtSinSpikeCarZone.Size = new System.Drawing.Size(100, 20);
            this.txtSinSpikeCarZone.TabIndex = 37;
            this.txtSinSpikeCarZone.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSinSpikeCarSpikeFactor
            // 
            this.txtSinSpikeCarSpikeFactor.Location = new System.Drawing.Point(442, 146);
            this.txtSinSpikeCarSpikeFactor.Name = "txtSinSpikeCarSpikeFactor";
            this.txtSinSpikeCarSpikeFactor.Size = new System.Drawing.Size(100, 20);
            this.txtSinSpikeCarSpikeFactor.TabIndex = 36;
            this.txtSinSpikeCarSpikeFactor.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnSinSpikeBusDebug
            // 
            this.btnSinSpikeBusDebug.Location = new System.Drawing.Point(998, 237);
            this.btnSinSpikeBusDebug.Name = "btnSinSpikeBusDebug";
            this.btnSinSpikeBusDebug.Size = new System.Drawing.Size(75, 23);
            this.btnSinSpikeBusDebug.TabIndex = 42;
            this.btnSinSpikeBusDebug.Text = "Debug";
            this.btnSinSpikeBusDebug.UseVisualStyleBackColor = true;
            this.btnSinSpikeBusDebug.Click += new System.EventHandler(this.btnSinSpikeBusDebug_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(867, 209);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 13);
            this.label21.TabIndex = 48;
            this.label21.Text = "Sinus cycle multiplier";
            // 
            // txtSinBusCycleMultiplier
            // 
            this.txtSinBusCycleMultiplier.Location = new System.Drawing.Point(870, 237);
            this.txtSinBusCycleMultiplier.Name = "txtSinBusCycleMultiplier";
            this.txtSinBusCycleMultiplier.Size = new System.Drawing.Size(100, 20);
            this.txtSinBusCycleMultiplier.TabIndex = 47;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(655, 209);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(167, 13);
            this.label22.TabIndex = 46;
            this.label22.Text = "Spike zone - smaller -> less spikes";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(439, 209);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(177, 13);
            this.label23.TabIndex = 45;
            this.label23.Text = "Spike factor - smaller -> bigger spike";
            // 
            // txtSinBusSpikeZone
            // 
            this.txtSinBusSpikeZone.Location = new System.Drawing.Point(658, 237);
            this.txtSinBusSpikeZone.Name = "txtSinBusSpikeZone";
            this.txtSinBusSpikeZone.Size = new System.Drawing.Size(100, 20);
            this.txtSinBusSpikeZone.TabIndex = 44;
            // 
            // txtSinBusSpikeFactor
            // 
            this.txtSinBusSpikeFactor.Location = new System.Drawing.Point(442, 237);
            this.txtSinBusSpikeFactor.Name = "txtSinBusSpikeFactor";
            this.txtSinBusSpikeFactor.Size = new System.Drawing.Size(100, 20);
            this.txtSinBusSpikeFactor.TabIndex = 43;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBusMaxSpeed);
            this.Controls.Add(this.txtBusMinSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCarMaxSpeed);
            this.Controls.Add(this.txtCarMinSpeed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTruckMaxSpeed);
            this.Controls.Add(this.txtTruckMinSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Name = "MainForm";
            this.Text = "Ets2 - Setup traffic";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTruckMinSpeed;
        private System.Windows.Forms.TextBox txtTruckMaxSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCarMaxSpeed;
        private System.Windows.Forms.TextBox txtCarMinSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBusMaxSpeed;
        private System.Windows.Forms.TextBox txtBusMinSpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSinTruckMin;
        private System.Windows.Forms.TextBox txtSinTruckMax;
        private System.Windows.Forms.TextBox txtSinBusMinCritical;
        private System.Windows.Forms.TextBox txtSinBusMax;
        private System.Windows.Forms.TextBox txtSinBusMin;
        private System.Windows.Forms.TextBox txtSinCarMinCritical;
        private System.Windows.Forms.TextBox txtSinCarMax;
        private System.Windows.Forms.TextBox txtSinCarMin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSinTruckMinCritical;
        private System.Windows.Forms.Button btnSinSpikeGenerate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSinTruckSpikeZone;
        private System.Windows.Forms.TextBox txtSinTruckSpikeFactor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSinTruckCycleMultiplier;
        private System.Windows.Forms.Button btnTruckDebug;
        private System.Windows.Forms.Button btnCarDebug;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSinSpikeCarCycleMultiplier;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSinSpikeCarZone;
        private System.Windows.Forms.TextBox txtSinSpikeCarSpikeFactor;
        private System.Windows.Forms.Button btnSinSpikeBusDebug;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtSinBusCycleMultiplier;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtSinBusSpikeZone;
        private System.Windows.Forms.TextBox txtSinBusSpikeFactor;
    }
}


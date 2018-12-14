namespace Demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CubeButton = new System.Windows.Forms.Button();
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.GeometriesListBox = new System.Windows.Forms.ListBox();
            this.PyramidButton = new System.Windows.Forms.Button();
            this.PrismaticButton = new System.Windows.Forms.Button();
            this.rotateXTrackbar = new System.Windows.Forms.TrackBar();
            this.rotateYTrackbar = new System.Windows.Forms.TrackBar();
            this.rotateZTrackbar = new System.Windows.Forms.TrackBar();
            this.rotateXTextBox = new System.Windows.Forms.TextBox();
            this.rotateYTextBox = new System.Windows.Forms.TextBox();
            this.rotateZTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.scaleZTextBox = new System.Windows.Forms.TextBox();
            this.scaleYTextBox = new System.Windows.Forms.TextBox();
            this.scaleXTextBox = new System.Windows.Forms.TextBox();
            this.scaleZTrackbar = new System.Windows.Forms.TrackBar();
            this.scaleYTrackbar = new System.Windows.Forms.TrackBar();
            this.scaleXTrackbar = new System.Windows.Forms.TrackBar();
            this.transXTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.transYTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.transZTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.countLabels = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gridSizeTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.camZTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.camYTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.camXTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.viewAngleTextBox = new System.Windows.Forms.TextBox();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label19 = new System.Windows.Forms.Label();
            this.objectNameLabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.viewZTextBox = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.viewYTextBox = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.viewXTextBox = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateXTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateYTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateZTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleZTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleYTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleXTrackbar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CubeButton
            // 
            this.CubeButton.Location = new System.Drawing.Point(119, 553);
            this.CubeButton.Name = "CubeButton";
            this.CubeButton.Size = new System.Drawing.Size(217, 54);
            this.CubeButton.TabIndex = 0;
            this.CubeButton.Text = "CUBE";
            this.CubeButton.UseVisualStyleBackColor = true;
            this.CubeButton.Click += new System.EventHandler(this.CubeButton_Click);
            // 
            // openGLControl1
            // 
            this.openGLControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openGLControl1.DrawFPS = false;
            this.openGLControl1.Location = new System.Drawing.Point(119, 142);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(660, 407);
            this.openGLControl1.TabIndex = 2;
            this.openGLControl1.OpenGLInitialized += new System.EventHandler(this.openGLControl1_OpenGLInitialized);
            this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl1_OpenGLDraw);
            this.openGLControl1.Resized += new System.EventHandler(this.openGLControl1_Resized);
            this.openGLControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.openGLControl1_KeyDown);
            // 
            // GeometriesListBox
            // 
            this.GeometriesListBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.GeometriesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeometriesListBox.FormattingEnabled = true;
            this.GeometriesListBox.Location = new System.Drawing.Point(5, 161);
            this.GeometriesListBox.Name = "GeometriesListBox";
            this.GeometriesListBox.Size = new System.Drawing.Size(108, 446);
            this.GeometriesListBox.TabIndex = 3;
            this.GeometriesListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawItem);
            this.GeometriesListBox.SelectedIndexChanged += new System.EventHandler(this.GeometriesListBox_SelectedIndexChanged);
            // 
            // PyramidButton
            // 
            this.PyramidButton.Location = new System.Drawing.Point(341, 553);
            this.PyramidButton.Name = "PyramidButton";
            this.PyramidButton.Size = new System.Drawing.Size(217, 54);
            this.PyramidButton.TabIndex = 4;
            this.PyramidButton.Text = "PYRAMID";
            this.PyramidButton.UseVisualStyleBackColor = true;
            this.PyramidButton.Click += new System.EventHandler(this.PyramidButton_Click);
            // 
            // PrismaticButton
            // 
            this.PrismaticButton.Location = new System.Drawing.Point(562, 553);
            this.PrismaticButton.Name = "PrismaticButton";
            this.PrismaticButton.Size = new System.Drawing.Size(217, 54);
            this.PrismaticButton.TabIndex = 5;
            this.PrismaticButton.Text = "PRISMATIC";
            this.PrismaticButton.UseVisualStyleBackColor = true;
            this.PrismaticButton.Click += new System.EventHandler(this.PrismaticButton_Click);
            // 
            // rotateXTrackbar
            // 
            this.rotateXTrackbar.Enabled = false;
            this.rotateXTrackbar.LargeChange = 1;
            this.rotateXTrackbar.Location = new System.Drawing.Point(809, 344);
            this.rotateXTrackbar.Maximum = 360;
            this.rotateXTrackbar.Minimum = -360;
            this.rotateXTrackbar.Name = "rotateXTrackbar";
            this.rotateXTrackbar.Size = new System.Drawing.Size(139, 45);
            this.rotateXTrackbar.TabIndex = 6;
            this.rotateXTrackbar.ValueChanged += new System.EventHandler(this.rotateTrackbar_ValueChanged);
            // 
            // rotateYTrackbar
            // 
            this.rotateYTrackbar.Enabled = false;
            this.rotateYTrackbar.LargeChange = 1;
            this.rotateYTrackbar.Location = new System.Drawing.Point(809, 382);
            this.rotateYTrackbar.Maximum = 360;
            this.rotateYTrackbar.Minimum = -360;
            this.rotateYTrackbar.Name = "rotateYTrackbar";
            this.rotateYTrackbar.Size = new System.Drawing.Size(139, 45);
            this.rotateYTrackbar.TabIndex = 7;
            this.rotateYTrackbar.ValueChanged += new System.EventHandler(this.rotateTrackbar_ValueChanged);
            // 
            // rotateZTrackbar
            // 
            this.rotateZTrackbar.Enabled = false;
            this.rotateZTrackbar.LargeChange = 1;
            this.rotateZTrackbar.Location = new System.Drawing.Point(809, 419);
            this.rotateZTrackbar.Maximum = 360;
            this.rotateZTrackbar.Minimum = -360;
            this.rotateZTrackbar.Name = "rotateZTrackbar";
            this.rotateZTrackbar.Size = new System.Drawing.Size(139, 45);
            this.rotateZTrackbar.TabIndex = 8;
            this.rotateZTrackbar.ValueChanged += new System.EventHandler(this.rotateTrackbar_ValueChanged);
            // 
            // rotateXTextBox
            // 
            this.rotateXTextBox.Enabled = false;
            this.rotateXTextBox.Location = new System.Drawing.Point(947, 344);
            this.rotateXTextBox.Name = "rotateXTextBox";
            this.rotateXTextBox.Size = new System.Drawing.Size(29, 20);
            this.rotateXTextBox.TabIndex = 9;
            this.rotateXTextBox.Text = "0";
            this.rotateXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transTextBox_KeyPress);
            this.rotateXTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rotateTextBox_KeyUp);
            // 
            // rotateYTextBox
            // 
            this.rotateYTextBox.Enabled = false;
            this.rotateYTextBox.Location = new System.Drawing.Point(947, 382);
            this.rotateYTextBox.Name = "rotateYTextBox";
            this.rotateYTextBox.Size = new System.Drawing.Size(29, 20);
            this.rotateYTextBox.TabIndex = 10;
            this.rotateYTextBox.Text = "0";
            this.rotateYTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transTextBox_KeyPress);
            this.rotateYTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rotateTextBox_KeyUp);
            // 
            // rotateZTextBox
            // 
            this.rotateZTextBox.Enabled = false;
            this.rotateZTextBox.Location = new System.Drawing.Point(947, 419);
            this.rotateZTextBox.Name = "rotateZTextBox";
            this.rotateZTextBox.Size = new System.Drawing.Size(29, 20);
            this.rotateZTextBox.TabIndex = 11;
            this.rotateZTextBox.Text = "0";
            this.rotateZTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transTextBox_KeyPress);
            this.rotateZTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rotateTextBox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(788, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(788, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(788, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Z";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(788, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Rotate";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(788, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Scale";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(788, 568);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Z";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(788, 531);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Y";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(788, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "X";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scaleZTextBox
            // 
            this.scaleZTextBox.Enabled = false;
            this.scaleZTextBox.Location = new System.Drawing.Point(947, 568);
            this.scaleZTextBox.Name = "scaleZTextBox";
            this.scaleZTextBox.Size = new System.Drawing.Size(29, 20);
            this.scaleZTextBox.TabIndex = 21;
            this.scaleZTextBox.Text = "0";
            this.scaleZTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transTextBox_KeyPress);
            this.scaleZTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.scaleTextBox_KeyUp);
            // 
            // scaleYTextBox
            // 
            this.scaleYTextBox.Enabled = false;
            this.scaleYTextBox.Location = new System.Drawing.Point(947, 531);
            this.scaleYTextBox.Name = "scaleYTextBox";
            this.scaleYTextBox.Size = new System.Drawing.Size(29, 20);
            this.scaleYTextBox.TabIndex = 20;
            this.scaleYTextBox.Text = "0";
            this.scaleYTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transTextBox_KeyPress);
            this.scaleYTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.scaleTextBox_KeyUp);
            // 
            // scaleXTextBox
            // 
            this.scaleXTextBox.Enabled = false;
            this.scaleXTextBox.Location = new System.Drawing.Point(947, 493);
            this.scaleXTextBox.Name = "scaleXTextBox";
            this.scaleXTextBox.Size = new System.Drawing.Size(29, 20);
            this.scaleXTextBox.TabIndex = 19;
            this.scaleXTextBox.Text = "0";
            this.scaleXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transTextBox_KeyPress);
            this.scaleXTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.scaleTextBox_KeyUp);
            // 
            // scaleZTrackbar
            // 
            this.scaleZTrackbar.Enabled = false;
            this.scaleZTrackbar.LargeChange = 1;
            this.scaleZTrackbar.Location = new System.Drawing.Point(809, 568);
            this.scaleZTrackbar.Maximum = 1000;
            this.scaleZTrackbar.Name = "scaleZTrackbar";
            this.scaleZTrackbar.Size = new System.Drawing.Size(139, 45);
            this.scaleZTrackbar.TabIndex = 18;
            this.scaleZTrackbar.Value = 100;
            this.scaleZTrackbar.ValueChanged += new System.EventHandler(this.scaleTrackbar_ValueChanged);
            // 
            // scaleYTrackbar
            // 
            this.scaleYTrackbar.Enabled = false;
            this.scaleYTrackbar.LargeChange = 1;
            this.scaleYTrackbar.Location = new System.Drawing.Point(809, 531);
            this.scaleYTrackbar.Maximum = 1000;
            this.scaleYTrackbar.Name = "scaleYTrackbar";
            this.scaleYTrackbar.Size = new System.Drawing.Size(139, 45);
            this.scaleYTrackbar.TabIndex = 17;
            this.scaleYTrackbar.Value = 100;
            this.scaleYTrackbar.ValueChanged += new System.EventHandler(this.scaleTrackbar_ValueChanged);
            // 
            // scaleXTrackbar
            // 
            this.scaleXTrackbar.Enabled = false;
            this.scaleXTrackbar.LargeChange = 1;
            this.scaleXTrackbar.Location = new System.Drawing.Point(809, 493);
            this.scaleXTrackbar.Maximum = 1000;
            this.scaleXTrackbar.Name = "scaleXTrackbar";
            this.scaleXTrackbar.Size = new System.Drawing.Size(139, 45);
            this.scaleXTrackbar.TabIndex = 16;
            this.scaleXTrackbar.Value = 100;
            this.scaleXTrackbar.ValueChanged += new System.EventHandler(this.scaleTrackbar_ValueChanged);
            // 
            // transXTextBox
            // 
            this.transXTextBox.Enabled = false;
            this.transXTextBox.Location = new System.Drawing.Point(817, 280);
            this.transXTextBox.MaxLength = 5;
            this.transXTextBox.Name = "transXTextBox";
            this.transXTextBox.Size = new System.Drawing.Size(29, 20);
            this.transXTextBox.TabIndex = 26;
            this.transXTextBox.Text = "0";
            this.transXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transTextBox_KeyPress);
            this.transXTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.transTextBox_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(788, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "X";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(856, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "Y";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transYTextBox
            // 
            this.transYTextBox.Enabled = false;
            this.transYTextBox.Location = new System.Drawing.Point(881, 280);
            this.transYTextBox.MaxLength = 5;
            this.transYTextBox.Name = "transYTextBox";
            this.transYTextBox.Size = new System.Drawing.Size(29, 20);
            this.transYTextBox.TabIndex = 30;
            this.transYTextBox.Text = "0";
            this.transYTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transTextBox_KeyPress);
            this.transYTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.transTextBox_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(924, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Z";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transZTextBox
            // 
            this.transZTextBox.Enabled = false;
            this.transZTextBox.Location = new System.Drawing.Point(946, 280);
            this.transZTextBox.MaxLength = 5;
            this.transZTextBox.Name = "transZTextBox";
            this.transZTextBox.Size = new System.Drawing.Size(29, 20);
            this.transZTextBox.TabIndex = 32;
            this.transZTextBox.Text = "0";
            this.transZTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transTextBox_KeyPress);
            this.transZTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.transTextBox_KeyUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(787, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 20);
            this.label12.TabIndex = 34;
            this.label12.Text = "Translate";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countLabels
            // 
            this.countLabels.AutoSize = true;
            this.countLabels.Location = new System.Drawing.Point(100, 142);
            this.countLabels.Name = "countLabels";
            this.countLabels.Size = new System.Drawing.Size(13, 13);
            this.countLabels.TabIndex = 35;
            this.countLabels.Text = "0";
            this.countLabels.TextChanged += new System.EventHandler(this.countLabels_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(745, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 17);
            this.label13.TabIndex = 36;
            this.label13.Text = "Grid Size: ";
            // 
            // gridSizeTextBox
            // 
            this.gridSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridSizeTextBox.Location = new System.Drawing.Point(812, 58);
            this.gridSizeTextBox.MaxLength = 2;
            this.gridSizeTextBox.Name = "gridSizeTextBox";
            this.gridSizeTextBox.Size = new System.Drawing.Size(32, 22);
            this.gridSizeTextBox.TabIndex = 37;
            this.gridSizeTextBox.Text = "0";
            this.gridSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gridSizeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transTextBox_KeyPress);
            this.gridSizeTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridSizeTextBox_KeyUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(84, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 17);
            this.label14.TabIndex = 44;
            this.label14.Text = "Position";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(220, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 20);
            this.label15.TabIndex = 43;
            this.label15.Text = "Z";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // camZTextBox
            // 
            this.camZTextBox.Location = new System.Drawing.Point(241, 60);
            this.camZTextBox.MaxLength = 5;
            this.camZTextBox.Name = "camZTextBox";
            this.camZTextBox.Size = new System.Drawing.Size(29, 20);
            this.camZTextBox.TabIndex = 42;
            this.camZTextBox.Text = "5";
            this.camZTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.camTextBox_KeyUp);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Lime;
            this.label16.Location = new System.Drawing.Point(152, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 20);
            this.label16.TabIndex = 41;
            this.label16.Text = "Y";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // camYTextBox
            // 
            this.camYTextBox.Location = new System.Drawing.Point(173, 60);
            this.camYTextBox.MaxLength = 5;
            this.camYTextBox.Name = "camYTextBox";
            this.camYTextBox.Size = new System.Drawing.Size(29, 20);
            this.camYTextBox.TabIndex = 40;
            this.camYTextBox.Text = "5";
            this.camYTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.camTextBox_KeyUp);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(84, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 20);
            this.label17.TabIndex = 39;
            this.label17.Text = "X";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // camXTextBox
            // 
            this.camXTextBox.Location = new System.Drawing.Point(105, 60);
            this.camXTextBox.MaxLength = 5;
            this.camXTextBox.Name = "camXTextBox";
            this.camXTextBox.Size = new System.Drawing.Size(29, 20);
            this.camXTextBox.TabIndex = 38;
            this.camXTextBox.Text = "5";
            this.camXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transTextBox_KeyPress);
            this.camXTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.camTextBox_KeyUp);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(84, 97);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 17);
            this.label18.TabIndex = 45;
            this.label18.Text = "View angle";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewAngleTextBox
            // 
            this.viewAngleTextBox.Location = new System.Drawing.Point(158, 95);
            this.viewAngleTextBox.MaxLength = 5;
            this.viewAngleTextBox.Name = "viewAngleTextBox";
            this.viewAngleTextBox.Size = new System.Drawing.Size(112, 20);
            this.viewAngleTextBox.TabIndex = 46;
            this.viewAngleTextBox.Text = "60";
            this.viewAngleTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transTextBox_KeyPress);
            this.viewAngleTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.viewAngleTextBox_KeyUp);
            // 
            // colorPanel
            // 
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel.Enabled = false;
            this.colorPanel.Location = new System.Drawing.Point(844, 217);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(59, 20);
            this.colorPanel.TabIndex = 47;
            this.colorPanel.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Transparent;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(788, 217);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 20);
            this.label19.TabIndex = 48;
            this.label19.Text = "Color";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // objectNameLabel
            // 
            this.objectNameLabel.AutoSize = true;
            this.objectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectNameLabel.ForeColor = System.Drawing.Color.Black;
            this.objectNameLabel.Location = new System.Drawing.Point(825, 142);
            this.objectNameLabel.Name = "objectNameLabel";
            this.objectNameLabel.Size = new System.Drawing.Size(0, 20);
            this.objectNameLabel.TabIndex = 49;
            this.objectNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(790, 179);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 16);
            this.label20.TabIndex = 50;
            this.label20.Text = "Length:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(883, 179);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 16);
            this.label21.TabIndex = 51;
            this.label21.Text = "Height:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Enabled = false;
            this.lengthTextBox.Location = new System.Drawing.Point(843, 175);
            this.lengthTextBox.MaxLength = 5;
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(29, 20);
            this.lengthTextBox.TabIndex = 52;
            this.lengthTextBox.Text = "0";
            this.lengthTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lengthTextBox_KeyUp);
            // 
            // heightTextBox
            // 
            this.heightTextBox.Enabled = false;
            this.heightTextBox.Location = new System.Drawing.Point(936, 175);
            this.heightTextBox.MaxLength = 5;
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(29, 20);
            this.heightTextBox.TabIndex = 53;
            this.heightTextBox.Text = "0";
            this.heightTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.heightTextBox_KeyUp);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(116, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(136, 31);
            this.label22.TabIndex = 54;
            this.label22.Text = "CAMERA";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(4, 142);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(97, 13);
            this.label23.TabIndex = 55;
            this.label23.Text = "Objcet number: ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(405, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(176, 31);
            this.label24.TabIndex = 63;
            this.label24.Text = "VIEWPOINT";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(396, 39);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 17);
            this.label25.TabIndex = 62;
            this.label25.Text = "Position";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Blue;
            this.label26.Location = new System.Drawing.Point(532, 60);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(19, 20);
            this.label26.TabIndex = 61;
            this.label26.Text = "Z";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewZTextBox
            // 
            this.viewZTextBox.Location = new System.Drawing.Point(553, 60);
            this.viewZTextBox.MaxLength = 5;
            this.viewZTextBox.Name = "viewZTextBox";
            this.viewZTextBox.Size = new System.Drawing.Size(29, 20);
            this.viewZTextBox.TabIndex = 60;
            this.viewZTextBox.Text = "0";
            this.viewZTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transTextBox_KeyPress);
            this.viewZTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.viewTextBox_KeyUp);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Lime;
            this.label27.Location = new System.Drawing.Point(464, 60);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(20, 20);
            this.label27.TabIndex = 59;
            this.label27.Text = "Y";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewYTextBox
            // 
            this.viewYTextBox.Location = new System.Drawing.Point(485, 60);
            this.viewYTextBox.MaxLength = 5;
            this.viewYTextBox.Name = "viewYTextBox";
            this.viewYTextBox.Size = new System.Drawing.Size(29, 20);
            this.viewYTextBox.TabIndex = 58;
            this.viewYTextBox.Text = "0";
            this.viewYTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transTextBox_KeyPress);
            this.viewYTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.viewTextBox_KeyUp);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(396, 60);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(20, 20);
            this.label28.TabIndex = 57;
            this.label28.Text = "X";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewXTextBox
            // 
            this.viewXTextBox.Location = new System.Drawing.Point(417, 60);
            this.viewXTextBox.MaxLength = 5;
            this.viewXTextBox.Name = "viewXTextBox";
            this.viewXTextBox.Size = new System.Drawing.Size(29, 20);
            this.viewXTextBox.TabIndex = 56;
            this.viewXTextBox.Text = "0";
            this.viewXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transTextBox_KeyPress);
            this.viewXTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.viewTextBox_KeyUp);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(712, 9);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(192, 31);
            this.label29.TabIndex = 64;
            this.label29.Text = "SENSE GRID";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.viewZTextBox);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.viewYTextBox);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.viewXTextBox);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.viewAngleTextBox);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.camZTextBox);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.camYTextBox);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.camXTextBox);
            this.panel1.Controls.Add(this.gridSizeTextBox);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 130);
            this.panel1.TabIndex = 65;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(980, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.objectNameLabel);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.countLabels);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.transZTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.transYTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.transXTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.scaleZTextBox);
            this.Controls.Add(this.scaleYTextBox);
            this.Controls.Add(this.scaleXTextBox);
            this.Controls.Add(this.scaleZTrackbar);
            this.Controls.Add(this.scaleYTrackbar);
            this.Controls.Add(this.scaleXTrackbar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rotateZTextBox);
            this.Controls.Add(this.rotateYTextBox);
            this.Controls.Add(this.rotateXTextBox);
            this.Controls.Add(this.rotateZTrackbar);
            this.Controls.Add(this.rotateYTrackbar);
            this.Controls.Add(this.rotateXTrackbar);
            this.Controls.Add(this.PrismaticButton);
            this.Controls.Add(this.PyramidButton);
            this.Controls.Add(this.GeometriesListBox);
            this.Controls.Add(this.openGLControl1);
            this.Controls.Add(this.CubeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(996, 650);
            this.MinimumSize = new System.Drawing.Size(996, 650);
            this.Name = "Form1";
            this.Text = "FAKE";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateXTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateYTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateZTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleZTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleYTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleXTrackbar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CubeButton;
        private SharpGL.OpenGLControl openGLControl1;
        private System.Windows.Forms.ListBox GeometriesListBox;
        private System.Windows.Forms.Button PyramidButton;
        private System.Windows.Forms.Button PrismaticButton;
        private System.Windows.Forms.TrackBar rotateXTrackbar;
        private System.Windows.Forms.TrackBar rotateYTrackbar;
        private System.Windows.Forms.TrackBar rotateZTrackbar;
        private System.Windows.Forms.TextBox rotateXTextBox;
        private System.Windows.Forms.TextBox rotateYTextBox;
        private System.Windows.Forms.TextBox rotateZTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox scaleZTextBox;
        private System.Windows.Forms.TextBox scaleYTextBox;
        private System.Windows.Forms.TextBox scaleXTextBox;
        private System.Windows.Forms.TrackBar scaleZTrackbar;
        private System.Windows.Forms.TrackBar scaleYTrackbar;
        private System.Windows.Forms.TrackBar scaleXTrackbar;
        private System.Windows.Forms.TextBox transXTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox transYTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox transZTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label countLabels;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox gridSizeTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox camZTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox camYTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox camXTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox viewAngleTextBox;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label objectNameLabel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox viewZTextBox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox viewYTextBox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox viewXTextBox;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Panel panel1;
    }
}


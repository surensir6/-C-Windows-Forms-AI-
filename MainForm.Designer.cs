namespace AIRecognitionTool
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVehicleRecognize = new System.Windows.Forms.Button();
            this.btnVehicleSelect = new System.Windows.Forms.Button();
            this.txtVehicleResult = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPlateRecognize = new System.Windows.Forms.Button();
            this.btnPlateSelect = new System.Windows.Forms.Button();
            this.txtPlateResult = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDishRecognize = new System.Windows.Forms.Button();
            this.btnDishSelect = new System.Windows.Forms.Button();
            this.txtDishResult = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGeneralRecognize = new System.Windows.Forms.Button();
            this.btnGeneralSelect = new System.Windows.Forms.Button();
            this.txtGeneralResult = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 537);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "软件介绍";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(870, 465);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(870, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "🤖 AI图像识别工具 - 软件介绍";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "接口说明";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox2.Location = new System.Drawing.Point(3, 43);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(870, 465);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(870, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "🔗 API接口说明";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(876, 511);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "车型识别";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVehicleRecognize);
            this.groupBox1.Controls.Add(this.btnVehicleSelect);
            this.groupBox1.Controls.Add(this.txtVehicleResult);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 511);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "🚗 车型识别";
            // 
            // btnVehicleRecognize
            // 
            this.btnVehicleRecognize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVehicleRecognize.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVehicleRecognize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicleRecognize.ForeColor = System.Drawing.Color.White;
            this.btnVehicleRecognize.Location = new System.Drawing.Point(580, 80);
            this.btnVehicleRecognize.Name = "btnVehicleRecognize";
            this.btnVehicleRecognize.Size = new System.Drawing.Size(120, 40);
            this.btnVehicleRecognize.TabIndex = 3;
            this.btnVehicleRecognize.Text = "开始识别";
            this.btnVehicleRecognize.UseVisualStyleBackColor = false;
            this.btnVehicleRecognize.Click += new System.EventHandler(this.btnVehicleRecognize_Click);
            // 
            // btnVehicleSelect
            // 
            this.btnVehicleSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVehicleSelect.BackColor = System.Drawing.Color.SeaGreen;
            this.btnVehicleSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicleSelect.ForeColor = System.Drawing.Color.White;
            this.btnVehicleSelect.Location = new System.Drawing.Point(580, 30);
            this.btnVehicleSelect.Name = "btnVehicleSelect";
            this.btnVehicleSelect.Size = new System.Drawing.Size(120, 40);
            this.btnVehicleSelect.TabIndex = 2;
            this.btnVehicleSelect.Text = "选择图片";
            this.btnVehicleSelect.UseVisualStyleBackColor = false;
            this.btnVehicleSelect.Click += new System.EventHandler(this.btnVehicleSelect_Click);
            // 
            // txtVehicleResult
            // 
            this.txtVehicleResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVehicleResult.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtVehicleResult.Location = new System.Drawing.Point(450, 130);
            this.txtVehicleResult.Multiline = true;
            this.txtVehicleResult.Name = "txtVehicleResult";
            this.txtVehicleResult.ReadOnly = true;
            this.txtVehicleResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVehicleResult.Size = new System.Drawing.Size(410, 365);
            this.txtVehicleResult.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(20, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 465);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(876, 511);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "车牌识别";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPlateRecognize);
            this.groupBox2.Controls.Add(this.btnPlateSelect);
            this.groupBox2.Controls.Add(this.txtPlateResult);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 511);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "🚙 车牌识别";
            // 
            // btnPlateRecognize
            // 
            this.btnPlateRecognize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlateRecognize.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPlateRecognize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlateRecognize.ForeColor = System.Drawing.Color.White;
            this.btnPlateRecognize.Location = new System.Drawing.Point(580, 80);
            this.btnPlateRecognize.Name = "btnPlateRecognize";
            this.btnPlateRecognize.Size = new System.Drawing.Size(120, 40);
            this.btnPlateRecognize.TabIndex = 3;
            this.btnPlateRecognize.Text = "开始识别";
            this.btnPlateRecognize.UseVisualStyleBackColor = false;
            this.btnPlateRecognize.Click += new System.EventHandler(this.btnPlateRecognize_Click);
            // 
            // btnPlateSelect
            // 
            this.btnPlateSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlateSelect.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPlateSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlateSelect.ForeColor = System.Drawing.Color.White;
            this.btnPlateSelect.Location = new System.Drawing.Point(580, 30);
            this.btnPlateSelect.Name = "btnPlateSelect";
            this.btnPlateSelect.Size = new System.Drawing.Size(120, 40);
            this.btnPlateSelect.TabIndex = 2;
            this.btnPlateSelect.Text = "选择图片";
            this.btnPlateSelect.UseVisualStyleBackColor = false;
            this.btnPlateSelect.Click += new System.EventHandler(this.btnPlateSelect_Click);
            // 
            // txtPlateResult
            // 
            this.txtPlateResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlateResult.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPlateResult.Location = new System.Drawing.Point(450, 130);
            this.txtPlateResult.Multiline = true;
            this.txtPlateResult.Name = "txtPlateResult";
            this.txtPlateResult.ReadOnly = true;
            this.txtPlateResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlateResult.Size = new System.Drawing.Size(410, 365);
            this.txtPlateResult.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(20, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(420, 465);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(876, 511);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "菜品识别";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDishRecognize);
            this.groupBox3.Controls.Add(this.btnDishSelect);
            this.groupBox3.Controls.Add(this.txtDishResult);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(876, 511);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "🍽️ 菜品识别";
            // 
            // btnDishRecognize
            // 
            this.btnDishRecognize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDishRecognize.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDishRecognize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDishRecognize.ForeColor = System.Drawing.Color.White;
            this.btnDishRecognize.Location = new System.Drawing.Point(580, 80);
            this.btnDishRecognize.Name = "btnDishRecognize";
            this.btnDishRecognize.Size = new System.Drawing.Size(120, 40);
            this.btnDishRecognize.TabIndex = 3;
            this.btnDishRecognize.Text = "开始识别";
            this.btnDishRecognize.UseVisualStyleBackColor = false;
            this.btnDishRecognize.Click += new System.EventHandler(this.btnDishRecognize_Click);
            // 
            // btnDishSelect
            // 
            this.btnDishSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDishSelect.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDishSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDishSelect.ForeColor = System.Drawing.Color.White;
            this.btnDishSelect.Location = new System.Drawing.Point(580, 30);
            this.btnDishSelect.Name = "btnDishSelect";
            this.btnDishSelect.Size = new System.Drawing.Size(120, 40);
            this.btnDishSelect.TabIndex = 2;
            this.btnDishSelect.Text = "选择图片";
            this.btnDishSelect.UseVisualStyleBackColor = false;
            this.btnDishSelect.Click += new System.EventHandler(this.btnDishSelect_Click);
            // 
            // txtDishResult
            // 
            this.txtDishResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDishResult.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDishResult.Location = new System.Drawing.Point(450, 130);
            this.txtDishResult.Multiline = true;
            this.txtDishResult.Name = "txtDishResult";
            this.txtDishResult.ReadOnly = true;
            this.txtDishResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDishResult.Size = new System.Drawing.Size(410, 365);
            this.txtDishResult.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(20, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(420, 465);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.groupBox4);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(876, 511);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "通用识别";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGeneralRecognize);
            this.groupBox4.Controls.Add(this.btnGeneralSelect);
            this.groupBox4.Controls.Add(this.txtGeneralResult);
            this.groupBox4.Controls.Add(this.pictureBox4);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(876, 511);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "🔍 通用物体识别";
            // 
            // btnGeneralRecognize
            // 
            this.btnGeneralRecognize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneralRecognize.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGeneralRecognize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneralRecognize.ForeColor = System.Drawing.Color.White;
            this.btnGeneralRecognize.Location = new System.Drawing.Point(580, 80);
            this.btnGeneralRecognize.Name = "btnGeneralRecognize";
            this.btnGeneralRecognize.Size = new System.Drawing.Size(120, 40);
            this.btnGeneralRecognize.TabIndex = 3;
            this.btnGeneralRecognize.Text = "开始识别";
            this.btnGeneralRecognize.UseVisualStyleBackColor = false;
            this.btnGeneralRecognize.Click += new System.EventHandler(this.btnGeneralRecognize_Click);
            // 
            // btnGeneralSelect
            // 
            this.btnGeneralSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneralSelect.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGeneralSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneralSelect.ForeColor = System.Drawing.Color.White;
            this.btnGeneralSelect.Location = new System.Drawing.Point(580, 30);
            this.btnGeneralSelect.Name = "btnGeneralSelect";
            this.btnGeneralSelect.Size = new System.Drawing.Size(120, 40);
            this.btnGeneralSelect.TabIndex = 2;
            this.btnGeneralSelect.Text = "选择图片";
            this.btnGeneralSelect.UseVisualStyleBackColor = false;
            this.btnGeneralSelect.Click += new System.EventHandler(this.btnGeneralSelect_Click);
            // 
            // txtGeneralResult
            // 
            this.txtGeneralResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGeneralResult.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGeneralResult.Location = new System.Drawing.Point(450, 130);
            this.txtGeneralResult.Multiline = true;
            this.txtGeneralResult.Name = "txtGeneralResult";
            this.txtGeneralResult.ReadOnly = true;
            this.txtGeneralResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGeneralResult.Size = new System.Drawing.Size(410, 365);
            this.txtGeneralResult.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(20, 30);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(420, 465);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 19);
            this.toolStripStatusLabel1.Text = "准备就绪";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 18);
            this.toolStripProgressBar1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AI图像识别工具 v1.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtVehicleResult;
        private System.Windows.Forms.Button btnVehicleSelect;
        private System.Windows.Forms.Button btnVehicleRecognize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPlateRecognize;
        private System.Windows.Forms.Button btnPlateSelect;
        private System.Windows.Forms.TextBox txtPlateResult;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDishRecognize;
        private System.Windows.Forms.Button btnDishSelect;
        private System.Windows.Forms.TextBox txtDishResult;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGeneralRecognize;
        private System.Windows.Forms.Button btnGeneralSelect;
        private System.Windows.Forms.TextBox txtGeneralResult;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
} 
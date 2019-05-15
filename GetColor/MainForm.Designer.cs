namespace GetColor
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
            if (disposing && components != null)
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
            this.components = new System.ComponentModel.Container();
            this.lblColor0 = new System.Windows.Forms.Label();
            this.btnPickColor = new System.Windows.Forms.Button();
            this.btnSelectColor = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.gpbColorStack = new System.Windows.Forms.GroupBox();
            this.lblColor7 = new System.Windows.Forms.Label();
            this.lblColor6 = new System.Windows.Forms.Label();
            this.lblColor5 = new System.Windows.Forms.Label();
            this.lblColor4 = new System.Windows.Forms.Label();
            this.lblColor3 = new System.Windows.Forms.Label();
            this.txtARGB = new System.Windows.Forms.TextBox();
            this.lblColor2 = new System.Windows.Forms.Label();
            this.lblColor1 = new System.Windows.Forms.Label();
            this.lblARGB = new System.Windows.Forms.Label();
            this.gpbValue = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRGBdec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBGR = new System.Windows.Forms.TextBox();
            this.txtHSB = new System.Windows.Forms.TextBox();
            this.txtRGB = new System.Windows.Forms.TextBox();
            this.lblCMYK = new System.Windows.Forms.Label();
            this.lblRGB = new System.Windows.Forms.Label();
            this.ctnMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolPickColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolClose = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDlg = new System.Windows.Forms.ColorDialog();
            this.lab = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.gpbColorStack.SuspendLayout();
            this.gpbValue.SuspendLayout();
            this.ctnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblColor0
            // 
            this.lblColor0.BackColor = System.Drawing.Color.White;
            this.lblColor0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor0.Location = new System.Drawing.Point(16, 80);
            this.lblColor0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor0.Name = "lblColor0";
            this.lblColor0.Size = new System.Drawing.Size(117, 106);
            this.lblColor0.TabIndex = 0;
            this.lblColor0.Click += new System.EventHandler(this.lblColor_Click);
            this.lblColor0.DoubleClick += new System.EventHandler(this.lblColor_DoubleClick);
            // 
            // btnPickColor
            // 
            this.btnPickColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPickColor.Location = new System.Drawing.Point(264, 8);
            this.btnPickColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnPickColor.Name = "btnPickColor";
            this.btnPickColor.Size = new System.Drawing.Size(81, 29);
            this.btnPickColor.TabIndex = 1;
            this.btnPickColor.Text = "拾色器";
            this.btnPickColor.UseVisualStyleBackColor = true;
            this.btnPickColor.Click += new System.EventHandler(this.btnPickColor_Click);
            // 
            // btnSelectColor
            // 
            this.btnSelectColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSelectColor.Location = new System.Drawing.Point(164, 8);
            this.btnSelectColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectColor.Name = "btnSelectColor";
            this.btnSelectColor.Size = new System.Drawing.Size(81, 29);
            this.btnSelectColor.TabIndex = 2;
            this.btnSelectColor.Text = "调色板";
            this.btnSelectColor.UseVisualStyleBackColor = true;
            this.btnSelectColor.Click += new System.EventHandler(this.btnSelectColor_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAbout.Location = new System.Drawing.Point(361, 8);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(81, 29);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "关于";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // gpbColorStack
            // 
            this.gpbColorStack.Controls.Add(this.lblColor7);
            this.gpbColorStack.Controls.Add(this.lblColor6);
            this.gpbColorStack.Controls.Add(this.lblColor5);
            this.gpbColorStack.Controls.Add(this.lblColor4);
            this.gpbColorStack.Controls.Add(this.lblColor3);
            this.gpbColorStack.Controls.Add(this.txtARGB);
            this.gpbColorStack.Controls.Add(this.lblColor2);
            this.gpbColorStack.Controls.Add(this.lblColor1);
            this.gpbColorStack.Location = new System.Drawing.Point(83, 256);
            this.gpbColorStack.Margin = new System.Windows.Forms.Padding(4);
            this.gpbColorStack.Name = "gpbColorStack";
            this.gpbColorStack.Padding = new System.Windows.Forms.Padding(4);
            this.gpbColorStack.Size = new System.Drawing.Size(291, 94);
            this.gpbColorStack.TabIndex = 5;
            this.gpbColorStack.TabStop = false;
            this.gpbColorStack.Text = "颜色栈";
            this.gpbColorStack.Visible = false;
            // 
            // lblColor7
            // 
            this.lblColor7.BackColor = System.Drawing.Color.White;
            this.lblColor7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColor7.Location = new System.Drawing.Point(224, 20);
            this.lblColor7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor7.Name = "lblColor7";
            this.lblColor7.Size = new System.Drawing.Size(27, 25);
            this.lblColor7.TabIndex = 6;
            this.lblColor7.Click += new System.EventHandler(this.lblColor_Click);
            this.lblColor7.DoubleClick += new System.EventHandler(this.lblColor_DoubleClick);
            // 
            // lblColor6
            // 
            this.lblColor6.BackColor = System.Drawing.Color.White;
            this.lblColor6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColor6.Location = new System.Drawing.Point(189, 20);
            this.lblColor6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor6.Name = "lblColor6";
            this.lblColor6.Size = new System.Drawing.Size(27, 25);
            this.lblColor6.TabIndex = 5;
            this.lblColor6.Click += new System.EventHandler(this.lblColor_Click);
            this.lblColor6.DoubleClick += new System.EventHandler(this.lblColor_DoubleClick);
            // 
            // lblColor5
            // 
            this.lblColor5.BackColor = System.Drawing.Color.White;
            this.lblColor5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColor5.Location = new System.Drawing.Point(155, 20);
            this.lblColor5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor5.Name = "lblColor5";
            this.lblColor5.Size = new System.Drawing.Size(27, 25);
            this.lblColor5.TabIndex = 4;
            this.lblColor5.Click += new System.EventHandler(this.lblColor_Click);
            this.lblColor5.DoubleClick += new System.EventHandler(this.lblColor_DoubleClick);
            // 
            // lblColor4
            // 
            this.lblColor4.BackColor = System.Drawing.Color.White;
            this.lblColor4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColor4.Location = new System.Drawing.Point(120, 20);
            this.lblColor4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor4.Name = "lblColor4";
            this.lblColor4.Size = new System.Drawing.Size(27, 25);
            this.lblColor4.TabIndex = 3;
            this.lblColor4.Click += new System.EventHandler(this.lblColor_Click);
            this.lblColor4.DoubleClick += new System.EventHandler(this.lblColor_DoubleClick);
            // 
            // lblColor3
            // 
            this.lblColor3.BackColor = System.Drawing.Color.White;
            this.lblColor3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColor3.Location = new System.Drawing.Point(85, 20);
            this.lblColor3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor3.Name = "lblColor3";
            this.lblColor3.Size = new System.Drawing.Size(27, 25);
            this.lblColor3.TabIndex = 2;
            this.lblColor3.Click += new System.EventHandler(this.lblColor_Click);
            this.lblColor3.DoubleClick += new System.EventHandler(this.lblColor_DoubleClick);
            // 
            // txtARGB
            // 
            this.txtARGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtARGB.Location = new System.Drawing.Point(85, 49);
            this.txtARGB.Margin = new System.Windows.Forms.Padding(4);
            this.txtARGB.Name = "txtARGB";
            this.txtARGB.ReadOnly = true;
            this.txtARGB.Size = new System.Drawing.Size(167, 30);
            this.txtARGB.TabIndex = 3;
            // 
            // lblColor2
            // 
            this.lblColor2.BackColor = System.Drawing.Color.White;
            this.lblColor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColor2.Location = new System.Drawing.Point(51, 20);
            this.lblColor2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor2.Name = "lblColor2";
            this.lblColor2.Size = new System.Drawing.Size(27, 25);
            this.lblColor2.TabIndex = 1;
            this.lblColor2.Click += new System.EventHandler(this.lblColor_Click);
            this.lblColor2.DoubleClick += new System.EventHandler(this.lblColor_DoubleClick);
            // 
            // lblColor1
            // 
            this.lblColor1.BackColor = System.Drawing.Color.White;
            this.lblColor1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColor1.Location = new System.Drawing.Point(16, 20);
            this.lblColor1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor1.Name = "lblColor1";
            this.lblColor1.Size = new System.Drawing.Size(27, 25);
            this.lblColor1.TabIndex = 0;
            this.lblColor1.Click += new System.EventHandler(this.lblColor_Click);
            this.lblColor1.DoubleClick += new System.EventHandler(this.lblColor_DoubleClick);
            // 
            // lblARGB
            // 
            this.lblARGB.AutoSize = true;
            this.lblARGB.Location = new System.Drawing.Point(11, 54);
            this.lblARGB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblARGB.Name = "lblARGB";
            this.lblARGB.Size = new System.Drawing.Size(31, 15);
            this.lblARGB.TabIndex = 2;
            this.lblARGB.Text = "RGB";
            // 
            // gpbValue
            // 
            this.gpbValue.Controls.Add(this.label3);
            this.gpbValue.Controls.Add(this.txtRGBdec);
            this.gpbValue.Controls.Add(this.label1);
            this.gpbValue.Controls.Add(this.txtBGR);
            this.gpbValue.Controls.Add(this.txtHSB);
            this.gpbValue.Controls.Add(this.lblARGB);
            this.gpbValue.Controls.Add(this.txtRGB);
            this.gpbValue.Controls.Add(this.lblCMYK);
            this.gpbValue.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gpbValue.Location = new System.Drawing.Point(141, 44);
            this.gpbValue.Margin = new System.Windows.Forms.Padding(4);
            this.gpbValue.Name = "gpbValue";
            this.gpbValue.Padding = new System.Windows.Forms.Padding(4);
            this.gpbValue.Size = new System.Drawing.Size(320, 158);
            this.gpbValue.TabIndex = 6;
            this.gpbValue.TabStop = false;
            this.gpbValue.Text = "颜色值";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "RGB(d)";
            // 
            // txtRGBdec
            // 
            this.txtRGBdec.Location = new System.Drawing.Point(93, 86);
            this.txtRGBdec.Margin = new System.Windows.Forms.Padding(4);
            this.txtRGBdec.Name = "txtRGBdec";
            this.txtRGBdec.ReadOnly = true;
            this.txtRGBdec.Size = new System.Drawing.Size(207, 25);
            this.txtRGBdec.TabIndex = 10;
            this.txtRGBdec.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRGBdec_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "ASS";
            // 
            // txtBGR
            // 
            this.txtBGR.Location = new System.Drawing.Point(93, 16);
            this.txtBGR.Margin = new System.Windows.Forms.Padding(4);
            this.txtBGR.Name = "txtBGR";
            this.txtBGR.ReadOnly = true;
            this.txtBGR.Size = new System.Drawing.Size(207, 25);
            this.txtBGR.TabIndex = 6;
            this.txtBGR.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBGR_MouseClick);
            // 
            // txtHSB
            // 
            this.txtHSB.Location = new System.Drawing.Point(93, 121);
            this.txtHSB.Margin = new System.Windows.Forms.Padding(4);
            this.txtHSB.Name = "txtHSB";
            this.txtHSB.ReadOnly = true;
            this.txtHSB.Size = new System.Drawing.Size(207, 25);
            this.txtHSB.TabIndex = 5;
            this.txtHSB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtHSB_MouseClick);
            // 
            // txtRGB
            // 
            this.txtRGB.Location = new System.Drawing.Point(93, 51);
            this.txtRGB.Margin = new System.Windows.Forms.Padding(4);
            this.txtRGB.Name = "txtRGB";
            this.txtRGB.ReadOnly = true;
            this.txtRGB.Size = new System.Drawing.Size(207, 25);
            this.txtRGB.TabIndex = 1;
            this.txtRGB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRGB_MouseClick);
            // 
            // lblCMYK
            // 
            this.lblCMYK.AutoSize = true;
            this.lblCMYK.Location = new System.Drawing.Point(11, 124);
            this.lblCMYK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCMYK.Name = "lblCMYK";
            this.lblCMYK.Size = new System.Drawing.Size(31, 15);
            this.lblCMYK.TabIndex = 4;
            this.lblCMYK.Text = "HSB";
            // 
            // lblRGB
            // 
            this.lblRGB.AutoSize = true;
            this.lblRGB.Location = new System.Drawing.Point(149, 58);
            this.lblRGB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRGB.Name = "lblRGB";
            this.lblRGB.Size = new System.Drawing.Size(31, 15);
            this.lblRGB.TabIndex = 0;
            this.lblRGB.Text = "RGB";
            // 
            // ctnMenu
            // 
            this.ctnMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctnMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolPickColor,
            this.toolShow,
            this.toolAbout,
            this.toolStripMenuItem1,
            this.toolClose});
            this.ctnMenu.Name = "ctnMenu";
            this.ctnMenu.Size = new System.Drawing.Size(121, 106);
            // 
            // toolPickColor
            // 
            this.toolPickColor.Name = "toolPickColor";
            this.toolPickColor.Size = new System.Drawing.Size(120, 24);
            this.toolPickColor.Text = "取色";
            this.toolPickColor.Click += new System.EventHandler(this.btnPickColor_Click);
            // 
            // toolShow
            // 
            this.toolShow.Name = "toolShow";
            this.toolShow.Size = new System.Drawing.Size(120, 24);
            this.toolShow.Text = "显示";
            this.toolShow.Click += new System.EventHandler(this.toolShow_Click);
            // 
            // toolAbout
            // 
            this.toolAbout.Name = "toolAbout";
            this.toolAbout.Size = new System.Drawing.Size(120, 24);
            this.toolAbout.Text = "关于...";
            this.toolAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 6);
            // 
            // toolClose
            // 
            this.toolClose.Name = "toolClose";
            this.toolClose.Size = new System.Drawing.Size(120, 24);
            this.toolClose.Text = "退出";
            this.toolClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab.Location = new System.Drawing.Point(16, 14);
            this.lab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(97, 30);
            this.lab.TabIndex = 9;
            this.lab.Text = "单击颜色代码\r\n复制到剪贴板";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "颜色预览";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 209);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gpbColorStack);
            this.Controls.Add(this.gpbValue);
            this.Controls.Add(this.lblColor0);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.lblRGB);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSelectColor);
            this.Controls.Add(this.btnPickColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "小丸拾色器";
            this.gpbColorStack.ResumeLayout(false);
            this.gpbColorStack.PerformLayout();
            this.gpbValue.ResumeLayout(false);
            this.gpbValue.PerformLayout();
            this.ctnMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}


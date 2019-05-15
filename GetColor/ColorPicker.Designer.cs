namespace GetColor
{
    partial class ColorPicker
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
            this.pnlColorWindow = new System.Windows.Forms.Panel();
            this.lblYValue = new System.Windows.Forms.Label();
            this.lblXValue = new System.Windows.Forms.Label();
            this.txtColorValue = new System.Windows.Forms.TextBox();
            this.lblShowColor = new System.Windows.Forms.Label();
            this.picZoom = new System.Windows.Forms.PictureBox();
            this.lblYName = new System.Windows.Forms.Label();
            this.lblXName = new System.Windows.Forms.Label();
            this.tckZoomSize = new System.Windows.Forms.TrackBar();
            this.pnlColorWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckZoomSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlColorWindow
            // 
            this.pnlColorWindow.BackColor = System.Drawing.Color.White;
            this.pnlColorWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColorWindow.Controls.Add(this.lblYValue);
            this.pnlColorWindow.Controls.Add(this.lblXValue);
            this.pnlColorWindow.Controls.Add(this.txtColorValue);
            this.pnlColorWindow.Controls.Add(this.lblShowColor);
            this.pnlColorWindow.Controls.Add(this.picZoom);
            this.pnlColorWindow.Controls.Add(this.lblYName);
            this.pnlColorWindow.Controls.Add(this.lblXName);
            this.pnlColorWindow.Controls.Add(this.tckZoomSize);
            this.pnlColorWindow.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlColorWindow.Location = new System.Drawing.Point(37, 47);
            this.pnlColorWindow.Name = "pnlColorWindow";
            this.pnlColorWindow.Size = new System.Drawing.Size(198, 102);
            this.pnlColorWindow.TabIndex = 0;
            this.pnlColorWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlColorWindow_MouseDown);
            this.pnlColorWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlColorWindow_MouseMove);
            this.pnlColorWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlColorWindow_MouseUp);
            // 
            // lblYValue
            // 
            this.lblYValue.Location = new System.Drawing.Point(86, 67);
            this.lblYValue.Name = "lblYValue";
            this.lblYValue.Size = new System.Drawing.Size(33, 15);
            this.lblYValue.TabIndex = 7;
            this.lblYValue.Text = "1000";
            // 
            // lblXValue
            // 
            this.lblXValue.Location = new System.Drawing.Point(24, 66);
            this.lblXValue.Name = "lblXValue";
            this.lblXValue.Size = new System.Drawing.Size(33, 15);
            this.lblXValue.TabIndex = 5;
            this.lblXValue.Text = "1000";
            this.lblXValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtColorValue
            // 
            this.txtColorValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorValue.Location = new System.Drawing.Point(49, 34);
            this.txtColorValue.Name = "txtColorValue";
            this.txtColorValue.ReadOnly = true;
            this.txtColorValue.Size = new System.Drawing.Size(70, 24);
            this.txtColorValue.TabIndex = 9;
            // 
            // lblShowColor
            // 
            this.lblShowColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShowColor.Location = new System.Drawing.Point(12, 34);
            this.lblShowColor.Name = "lblShowColor";
            this.lblShowColor.Size = new System.Drawing.Size(30, 20);
            this.lblShowColor.TabIndex = 2;
            // 
            // picZoom
            // 
            this.picZoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picZoom.Location = new System.Drawing.Point(130, 6);
            this.picZoom.Name = "picZoom";
            this.picZoom.Size = new System.Drawing.Size(60, 56);
            this.picZoom.TabIndex = 0;
            this.picZoom.TabStop = false;
            // 
            // lblYName
            // 
            this.lblYName.AutoSize = true;
            this.lblYName.Location = new System.Drawing.Point(67, 67);
            this.lblYName.Name = "lblYName";
            this.lblYName.Size = new System.Drawing.Size(23, 15);
            this.lblYName.TabIndex = 6;
            this.lblYName.Text = "Y:";
            // 
            // lblXName
            // 
            this.lblXName.AutoSize = true;
            this.lblXName.Location = new System.Drawing.Point(8, 67);
            this.lblXName.Name = "lblXName";
            this.lblXName.Size = new System.Drawing.Size(23, 15);
            this.lblXName.TabIndex = 4;
            this.lblXName.Text = "X:";
            // 
            // tckZoomSize
            // 
            this.tckZoomSize.AutoSize = false;
            this.tckZoomSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.tckZoomSize.Location = new System.Drawing.Point(122, 63);
            this.tckZoomSize.Margin = new System.Windows.Forms.Padding(0);
            this.tckZoomSize.Maximum = 8;
            this.tckZoomSize.Minimum = 1;
            this.tckZoomSize.Name = "tckZoomSize";
            this.tckZoomSize.Size = new System.Drawing.Size(77, 23);
            this.tckZoomSize.TabIndex = 0;
            this.tckZoomSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tckZoomSize.Value = 4;
            this.tckZoomSize.ValueChanged += new System.EventHandler(this.tckZoomSize_ValueChanged);
            // 
            // ColorPicker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.pnlColorWindow);
            this.Name = "ColorPicker";
            this.ShowInTaskbar = false;
            this.pnlColorWindow.ResumeLayout(false);
            this.pnlColorWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckZoomSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
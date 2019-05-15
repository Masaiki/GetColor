// Xianfen.Net.GetColor.ColorPicker
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GetColor
{

    public partial class ColorPicker : Form
    {
        private PictureBox pictureBox;

        private Bitmap bmp;

        //private Graphics g;

        private bool isDown;

        private Point downPoint;

        private Panel pnlColorWindow;

        private TrackBar tckZoomSize;

        private PictureBox picZoom;

        private Label lblYValue;

        private Label lblYName;

        private Label lblXValue;

        private Label lblXName;

        private Label lblShowColor;

        private TextBox txtColorValue;

        //private Rectangle rect;

        private Pen pen;

        private Bitmap bmpZoom;

        private Graphics zoom;

        private int zoomSize;

        private Color selectedColor = Color.White;

        public Color SelectedColor
        {
            get
            {
                return selectedColor;
            }
            set
            {
                selectedColor = value;
            }
        }

        public ColorPicker()
        {
            InitializeComponent();
            pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.BorderStyle = BorderStyle.None;
            pictureBox.MouseUp += pictureBox_MouseUp;
            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.Cursor = Cursors.Cross;
            base.Controls.Add(pictureBox);
            base.Size = new Size(0, 0);
            DoubleBuffered = true;
            base.Load += ColorPicker_Load;
            bmpZoom = new Bitmap(picZoom.Width, picZoom.Height);
            zoom = Graphics.FromImage(bmpZoom);
            picZoom.Image = bmpZoom;
            pen = new Pen(Color.Black, 1f);
            pen.DashCap = DashCap.Round;
            pen.DashStyle = DashStyle.Dash;
            zoomSize = tckZoomSize.Value;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePosition = Control.MousePosition;
            lblXValue.Text = mousePosition.X.ToString();
            lblYValue.Text = mousePosition.Y.ToString();
            Color pixel = bmp.GetPixel(mousePosition.X, mousePosition.Y);
            lblShowColor.BackColor = pixel;
            txtColorValue.Text = string.Format("#{0,2:X2}{1,2:X2}{2,2:X2}", pixel.R.ToString("X"), pixel.G.ToString("X"), pixel.B.ToString("X")).Replace(" ", "0");
            zoom.InterpolationMode = InterpolationMode.NearestNeighbor;
            zoom.DrawImage(bmp, new Rectangle(0, 0, bmpZoom.Width, bmpZoom.Height), Control.MousePosition.X - bmpZoom.Width / (2 * zoomSize), Control.MousePosition.Y - bmpZoom.Height / (2 * zoomSize), bmpZoom.Width / zoomSize, bmpZoom.Height / zoomSize, GraphicsUnit.Pixel);
            zoom.DrawLine(pen, picZoom.Width / 2 - 1, 0, picZoom.Width / 2 - 1, picZoom.Height);
            zoom.DrawLine(pen, 0, picZoom.Height / 2 - 1, picZoom.Width, picZoom.Height / 2 - 1);
            picZoom.Refresh();
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            selectedColor = bmp.GetPixel(e.Location.X, e.Location.Y);
            pen.Dispose();
            bmp.Dispose();
            bmpZoom.Dispose();
            zoom.Dispose();
            //g.Dispose();
            Close();
        }

        private void ColorPicker_Load(object sender, EventArgs e)
        {
            bmp = ScreenPicture.GetFullScreen();
            pictureBox.Image = bmp;
            base.TopMost = true;
            base.FormBorderStyle = FormBorderStyle.None;
            base.WindowState = FormWindowState.Maximized;
        }

        private void pnlColorWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDown = true;
                downPoint = e.Location;
            }
        }

        private void pnlColorWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown)
            {
                pnlColorWindow.Left = Control.MousePosition.X - downPoint.X;
                pnlColorWindow.Top = Control.MousePosition.Y - downPoint.Y;
            }
        }

        private void pnlColorWindow_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDown = false;
            }
        }

        private void tckZoomSize_ValueChanged(object sender, EventArgs e)
        {
            zoomSize = tckZoomSize.Value;
        }

    }

}

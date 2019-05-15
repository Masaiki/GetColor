using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GetColor
{

    public partial class MainForm : Form
    {
        private Label lblColor0;

        private Button btnPickColor;

        private Button btnSelectColor;

        private Button btnAbout;

        private GroupBox gpbColorStack;

        private Label lblColor5;

        private Label lblColor4;

        private Label lblColor3;

        private Label lblColor2;

        private Label lblColor1;

        private GroupBox gpbValue;

        private Label lblColor7;

        private Label lblColor6;

        private Label lblCMYK;

        private Label lblARGB;

        private Label lblRGB;

        private TextBox txtHSB;

        private TextBox txtARGB;

        private TextBox txtRGB;

        private ContextMenuStrip ctnMenu;

        private ToolStripMenuItem toolPickColor;

        private ToolStripMenuItem toolShow;

        private ToolStripMenuItem toolAbout;

        private ToolStripSeparator toolStripMenuItem1;

        private ToolStripMenuItem toolClose;

        private ColorDialog colorDlg;

        private Label label1;

        private TextBox txtBGR;

        private Label lab;

        private Timer timer1;

        private Label label2;

        private TextBox txtRGBdec;

        private Label label3;



        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorPicker colorPicker = new ColorPicker();
            Hide();
            colorPicker.ShowDialog();
            Show();
            BackColor = colorPicker.SelectedColor;
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            using (ColorPicker colorPicker = new ColorPicker())
            {
                base.WindowState = FormWindowState.Minimized;
                base.Visible = false;
                colorPicker.ShowDialog();
                for (int num = 7; num > 0; num--)
                {
                    ((Label)base.Controls.Find("lblColor" + num.ToString(), searchAllChildren: true)[0]).BackColor = ((Label)base.Controls.Find("lblColor" + (num - 1).ToString(), searchAllChildren: true)[0]).BackColor;
                }
                lblColor0.BackColor = colorPicker.SelectedColor;
                toolShow_Click(null, null);
                lblColor_Click(lblColor0, null);
            }
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            colorDlg.Color = lblColor0.BackColor;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                lblColor0.BackColor = colorDlg.Color;
                lblColor_Click(lblColor0, null);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("小丸为获取用于ASS字幕的BGR颜色值而修改此软件。\n原作者：周振兴 Blog：http://www.xianfen.net \n发布日期：2013年12月11日\n2019年5月15日更新 菜姬修改以适配高DPI 修复部分区域白块问题", "关于 小丸拾色器", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lnkCopyRights_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.xianfen.net");
        }

        private void lblColor_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                Color backColor = label.BackColor;
                txtRGB.Text = string.Format("{0,2:X2}{1,2:X2}{2,2:X2}", backColor.R.ToString("X"), backColor.G.ToString("X"), backColor.B.ToString("X")).Replace(" ", "0");
                txtRGBdec.Text = $"{backColor.R.ToString()} {backColor.G.ToString()} {backColor.B.ToString()}";
                txtARGB.Text = string.Format("{0,3:D3} {1,3:D3} {2,3:D3} {3,2:D3}", backColor.A, backColor.R, backColor.G, backColor.B);
                txtBGR.Text = string.Format("&H00{0,2:X2}{1,2:X2}{2,2:X2}", backColor.B.ToString("X"), backColor.G.ToString("X"), backColor.R.ToString("X")).Replace(" ", "0");
                int num = (int)((double)(backColor.GetHue() / 360f * 240f) + 0.5);
                int num2 = (int)((double)(backColor.GetSaturation() * 241f) + 0.5);
                int num3 = (int)((double)(backColor.GetBrightness() * 241f) + 0.5);
                if (num > 239)
                {
                    num = 239;
                }
                if (num2 > 240)
                {
                    num2 = 240;
                }
                if (num3 > 240)
                {
                    num3 = 240;
                }
                txtHSB.Text = string.Format("{0,3:D3} {1,3:D3} {2,3:D3}", num, num2, num3);
            }
        }

        private void lblColor_DoubleClick(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                Color backColor = label.BackColor;
                colorDlg.Color = backColor;
                if (colorDlg.ShowDialog() == DialogResult.OK)
                {
                    label.BackColor = colorDlg.Color;
                }
            }
        }

        private void toolShow_Click(object sender, EventArgs e)
        {
            Show();
            base.WindowState = FormWindowState.Normal;
            Activate();
        }

        private void ntyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            toolShow_Click(null, null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lab.Text = "";
            timer1.Enabled = false;
        }

        private void txtBGR_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "")
            {
                Clipboard.SetDataObject(textBox.Text);
                lab.Text = "已经复制到剪贴板！";
                timer1.Enabled = true;
            }
        }

        private void txtHSB_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "")
            {
                Clipboard.SetDataObject(textBox.Text);
                lab.Text = "已经复制到剪贴板！";
                timer1.Enabled = true;
            }
        }

        private void txtRGBdec_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "")
            {
                Clipboard.SetDataObject(textBox.Text);
                lab.Text = "已经复制到剪贴板！";
                timer1.Enabled = true;
            }
        }

        private void txtRGB_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "")
            {
                Clipboard.SetDataObject(textBox.Text);
                lab.Text = "已经复制到剪贴板！";
                timer1.Enabled = true;
            }
        }
    }

}

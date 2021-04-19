using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CCWin;

namespace NB.Forms
{
    public partial class BaseFrm : CCSkinMain
    {
        public class Win32
        {
            public const Int32 AW_HOR_POSITIVE = 0x00000001; // 从左到右打开窗口
            public const Int32 AW_HOR_NEGATIVE = 0x00000002; // 从右到左打开窗口
            public const Int32 AW_VER_POSITIVE = 0x00000004; // 从上到下打开窗口
            public const Int32 AW_VER_NEGATIVE = 0x00000008; // 从下到上打开窗口
            public const Int32 AW_CENTER = 0x00000010; //若使用了AW_HIDE标志，则使窗口向内重叠；若未使用AW_HIDE标志，则使窗口向外扩展。
            public const Int32 AW_HIDE = 0x00010000; //隐藏窗口，缺省则显示窗口。
            public const Int32 AW_ACTIVATE = 0x00020000; //激活窗口。在使用了AW_HIDE标志后不要使用这个标志。
            public const Int32 AW_SLIDE = 0x00040000; //使用滑动类型。缺省则为滚动动画类型。当使用AW_CENTER标志时，这个标志就被忽略。
            public const Int32 AW_BLEND = 0x00080000; //使用淡出效果。只有当hWnd为顶层窗口的时候才可以使用此标志。
            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern bool AnimateWindow(
          IntPtr hwnd, // handle to window
              int dwTime, // duration of animation
              int dwFlags // animation type
              );
        }

        public BaseFrm()
        {
            //m_aeroEnabled = false;
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
        }

        #region 窗体开启双缓冲,减少卡顿
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000; // 用双缓冲绘制窗口的所有子控件
        //        return cp;
        //    }
        //}
        #endregion

        #region 窗体按钮事件

        private void sysClose_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void sysMin_MouseUp(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        //#region 窗体四周阴影效果,不用了(设计器会很卡,而且有个bug,最小化后窗体会透明)
        //[DllImport("dwmapi.dll")]
        //public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        //[DllImport("dwmapi.dll")]
        //public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        //[DllImport("dwmapi.dll")]
        //public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        //private bool m_aeroEnabled;                     // variables for box shadow
        //private const int CS_DROPSHADOW = 0x00020000;
        //private const int WM_NCPAINT = 0x0085;
        //private const int WM_ACTIVATEAPP = 0x001C;

        //public struct MARGINS                           // struct for box shadow
        //{
        //    public int leftWidth;
        //    public int rightWidth;
        //    public int topHeight;
        //    public int bottomHeight;
        //}

        //private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        //private const int HTCLIENT = 0x1;
        //private const int HTCAPTION = 0x2;

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        m_aeroEnabled = CheckAeroEnabled();
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000; // 用双缓冲绘制窗口的所有子控件
        //        if (!m_aeroEnabled)
        //            cp.ClassStyle |= CS_DROPSHADOW;

        //        return cp;
        //    }
        //}

        //private bool CheckAeroEnabled()
        //{
        //    if (Environment.OSVersion.Version.Major >= 6)
        //    {
        //        int enabled = 0;
        //        DwmIsCompositionEnabled(ref enabled);
        //        return enabled == 1 ? true : false;
        //    }
        //    return false;
        //}

        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == 0xa3)//取消双击窗体最大化
        //    {
        //        return;
        //    }
        //    switch (m.Msg)
        //    {
        //        case WM_NCPAINT:                        // box shadow
        //            if (m_aeroEnabled)
        //            {
        //                var v = 2;
        //                DwmSetWindowAttribute(Handle, 2, ref v, 4);
        //                MARGINS margins = new MARGINS()
        //                {
        //                    bottomHeight = 1,
        //                    leftWidth = 0,
        //                    rightWidth = 0,
        //                    topHeight = 0
        //                };
        //                DwmExtendFrameIntoClientArea(Handle, ref margins);

        //            }
        //            break;
        //        default:
        //            break;
        //    }
        //    base.WndProc(ref m);

        //    if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
        //        m.Result = (IntPtr)HTCAPTION;

        //}
        //#endregion

        #region 窗体淡出淡入
        private void BaseFrm_Load(object sender, EventArgs e)
        {
            sysClose.Location = new Point(this.Width-35,15);
            //Win32.AnimateWindow(this.Handle, 1000, Win32.AW_BLEND);//淡入窗体
        }

        /// <summary>
        /// 淡出窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BaseFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Win32.AnimateWindow(this.Handle, 1000, Win32.AW_SLIDE | Win32.AW_HIDE | Win32.AW_BLEND);//淡入出窗体
        }
        #endregion

        private void BaseFrm_Paint(object sender, PaintEventArgs e)
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true);
        }
    }
}

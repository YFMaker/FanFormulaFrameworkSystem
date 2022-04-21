using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FanFormulaFramework.APP.ControlLibaray
{
    public partial class LogonPictureBox : UserControl
    {
        public LogonPictureBox()
        {
            InitializeComponent();
        }

        private Image _UserPhotoSet = null;
        [Description("修改此值可更改控件背景图片"), Category("自定义属性")]
        public Image UserPhotoSet
        {
            get
            {
                return _UserPhotoSet;
            }
            set
            {
                _UserPhotoSet = value;
                this.Region = BmpRgn((Bitmap)value, Color.FromArgb(0, 0, 0));
            }
        }


        /// <summary>
        /// 取得一个图片中非透明色部分的区域。
        /// </summary>
        /// <param name="Picture">取其区域的图片。</param>
        /// <param name="TransparentColor">透明色。</param>
        /// <returns>图片中非透明色部分的区域</returns>
        private Region BmpRgn(Bitmap Picture, Color TransparentColor)
        {
            int nWidth = Picture.Width;
            int nHeight = Picture.Height;
            Region rgn = new Region();
            rgn.MakeEmpty();
            bool isTransRgn;//前一个点是否在透明区
            Color curColor;//当前点的颜色
            Rectangle curRect = new Rectangle();
            curRect.Height = 1;
            int x = 0, y = 0;
            //逐像素扫描这个图片，找出非透明色部分区域并合并起来。
            for (y = 0; y < nHeight; ++y)
            {
                isTransRgn = true;
                for (x = 0; x < nWidth; ++x)
                {
                    curColor = Picture.GetPixel(x, y);
                    if (curColor == TransparentColor || x == nWidth - 1)//如果遇到透明色或行尾
                    {
                        if (isTransRgn == false)//退出有效区
                        {
                            curRect.Width = x - curRect.X;
                            rgn.Union(curRect);
                        }
                    }
                    else//非透明色
                    {
                        if (isTransRgn == true)//进入有效区
                        {
                            curRect.X = x;
                            curRect.Y = y;
                        }
                    }//if curColor
                    isTransRgn = curColor == TransparentColor;
                }//for x
            }//for y
            return rgn;
        }


    }
}

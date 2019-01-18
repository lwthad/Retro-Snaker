using System;
using System.Drawing;

namespace 贪吃蛇
{
    /// <summary>
    /// bean 的摘要说明。
    /// </summary>
    public class Bean
    {
        public Bean()//构造函数
        {
        }
        private Point origin;                           //定义位置字段
        public Point Origin                             //定义位置属性
        {
            get { return origin; }
            set { origin = value; }
        }
        public void Display(Graphics g)                 //显示豆方法
        {
            SolidBrush b = new SolidBrush(Color.Red);     //定义红色画刷
            g.FillRectangle(b, origin.X, origin.Y, 5, 5);   //画实心矩形
            //Bitmap b = new Bitmap(Image.FromFile("Blue.gif"));
            //g.DrawImage(b, origin.X, origin.Y, 5, 5);   
        }
        public void UnDisplay(Graphics g)               //消除豆方法
        {
            SolidBrush b = new SolidBrush(Color.Silver);  //定义背景色画刷
            //用背景色重画原来矩形即消除原矩形
            g.FillRectangle(b, origin.X, origin.Y, 5, 5);
        }
    }
}


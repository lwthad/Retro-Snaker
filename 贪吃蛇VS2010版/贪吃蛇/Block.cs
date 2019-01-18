using System;
using System.Drawing;

namespace 贪吃蛇
{
    /// <summary>
    /// block 的摘要说明。
    /// </summary>
    public class Block
    {
        public Block()                                 //构造函数
        {

        }
        private int number;                             //定义序数字段
        private Point origin;                           //定义位置字段
        private bool ishead=false;                      //定义蛇头标志字段
        public int Number                               //属性
        {
            get { return number; }
            set { number = value; }
        }
        public bool Ishead                               //属性
        {
            get { return ishead; }
            set { ishead = value; }
        }
        public Point Origin
        {
            get { return origin; }
            set { origin = value; }
        }
        public void Display(Graphics g)             //显示块方法
        {
            //Pen p = new Pen(Color.Red);
            //g.DrawRectangle(p, origin.X, origin.Y, 5, 5);
            if (Ishead)                            //是蛇头
            {
                Bitmap b = new Bitmap(Image.FromFile("Blue.gif"));
                g.DrawImage(b, origin.X, origin.Y, 5, 5);
            }
            else
            {
                UnDisplay(g);
                Pen p = new Pen(Color.Red);
                g.DrawRectangle(p, origin.X, origin.Y, 5, 5);
            }
        }
        public void UnDisplay(Graphics g)           //消除块方法
        {
            //Pen p = new Pen(Color.Silver);            //建立背景色笔
            //g.DrawRectangle(p, origin.X, origin.Y, 5, 5);
            SolidBrush b = new SolidBrush(Color.Silver);  //定义背景色画刷
            //用背景色重画原来矩形即消除原矩形
            g.FillRectangle(b, origin.X, origin.Y, 5+1, 5+1);
        }
    }
}


using System;
using System.Drawing;

namespace 贪吃蛇
{
    /// <summary>
    /// floor 的摘要说明。
    /// </summary>
    public class Floor
    {
        public Floor(Point d)                           //构造函数，参数为运动场左上角位置
        {
            dot = d;                                    //d赋给左上角位置字段
            s = new Snake(d, 10);                       //由运动场位置d和组成蛇的块数实例化蛇对象字段
            bean1 = new Bean();                         //实例化豆对象字段
            bean1.Origin = new Point(d.X + 30, d.Y + 30); //由参数d实例化豆位置
        }
        private static int unit = 5;                     //定义静态单位长度，因后面字段初始化要用此，故需静态
        private int length = 80 * unit;                 //运动场长度，并排个蛇
        private int width = 50 * unit;                  //运动场宽度，并排个蛇
        private Point dot;                              //运动场左上角位置
        public int score;                               //游戏分数
        private Snake s;                                //蛇对象字段
        private Bean bean1;                             //豆对象字段
        public Snake S                                 //蛇对象只读属性
        {
            get { return s; }
        }

        public void displaybean(Graphics g)             //显示新豆方法
        {
            bean1.UnDisplay(g);                         //消除原来豆
            bean1 = randombean();                       //产生随机豆
            bean1.Display(g);                           //显示新豆
        }

        public void ReSet(Graphics g)                   //重新设置蛇方法
        {
            s.UnDisplay(g);                             //消除以前蛇
            s.Reset(dot, 10);                           //重设置蛇

        }
        private Bean randombean()                       //产生随机豆方法
        {
            Random random = new Random();                 //创建伪随机数对象并实例化
            int x = random.Next(length / unit - 2) + 1;         //由Next方法产生—之间的一个整数
            int y = random.Next(width / unit - 2) + 1;          //由Next方法产生—之间的一个整数
            Point d = new Point(dot.X + x * 5, dot.Y + y * 5);     //由运动场位置和x,y随机整数实例化点对象
            Bean bb = new Bean();
            bb.Origin = d;                                //点赋给新豆位置属性
            return bb;                                  //返回新豆
        }
        public void Display(Graphics g)                 //显示运动场方法，参数为一图形对象
        {
            Pen p = new Pen(Color.Red);                   //创建笔并用红色实例化它
            g.DrawRectangle(p, dot.X, dot.Y, length, width);//用上笔画一位置在dot，长、宽分别为length和width的矩形
            s.Display(g);                               //显示蛇
            CheckBean(g);                               //检查豆是否被吃
            bean1.Display(g);                           //显示豆
        }

        public void CheckBean(Graphics g)               //检查豆是否被吃，参数为图形对象
        {
            if (bean1.Origin.Equals(s.getHeadPoint))    //判断豆的位置是否与蛇头位置相同
            {
                score = score + 10;                     //分数加
                this.displaybean(g);                    //显示新豆
                s.Growth();                             //蛇自动增长
            }
        }

        //检查蛇是否撞墙
        public bool CheckSnake()
        {
            if ((dot.X < s.getHeadPoint.X && s.getHeadPoint.X < (dot.X + length) - 5) &&
                (dot.Y < s.getHeadPoint.Y && s.getHeadPoint.Y < (dot.Y + width) - 5) && !s.getHitSelf)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}


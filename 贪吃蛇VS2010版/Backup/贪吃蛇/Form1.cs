using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 贪吃蛇
{
    public partial class Form1 : Form
    {
        private Floor floor;                            //运动场对象字段
        private int jibei;                              //游戏级别
        private bool ren_speed=false;                   //玩家设置速度  
        public Form1()
        {
            InitializeComponent();
            //用坐标为（50，50）的点实例化运动场
            this.floor = new Floor(new Point(50, 50));
            this.BackColor = Color.Silver; 
        }

        private void MemuStart_Click(object sender, EventArgs e)
        //开始/重新开始菜单单击事件方法
		{
			timer1.Enabled=true;                          //开始运行游戏
            if (this.MemuStart.Text == "开始")            //如果标题为“开始”
			{
                this.MemuStart.Text = "重新开始";         //改为“重新开始”
			}
			else
            {                                            //否则
				floor.ReSet(this.CreateGraphics());      //重新开始游戏
				floor.score=0;
			}
            MemuPause.Enabled = true;                    //暂停/继续菜单可用
		}

        private void MemuPause_Click(object sender, EventArgs e)
        {
            if (MemuPause.Text == "暂停")            //如果菜单原标题为“暂停”
            {
                this.timer1.Enabled = false;         //停止游戏
                MemuPause.Text = "继续";             //菜单标题改为“继续”
            }
            else
            {                                        //否则
                this.timer1.Enabled = true;          //继续游戏
                MemuPause.Text = "暂停";            //菜单标题改为“暂停”
            }
        }
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.BackgroundImage = bmp;
            //Graphics g = this.CreateGraphics();
            Graphics g = Graphics.FromImage(bmp); 
            floor.Display(g);                           //运动场显示，即蛇运行this.CreateGraphics()
            label2.Text = "分数:"+floor.score.ToString();        //显示
            jibei = floor.score / 50 + 1;               //计算级别
            label1.Text = "级别:"+jibei.ToString();     //显示级别
            int newspeed=200 - jibei * 50;              //重新计算设置速度
            if(ren_speed == true)
            {
                timer1.Interval =newspeed;              //自动设置速度
            }
            if (floor.score >= 500)                      //如果分数为500
            {
                timer1.Enabled = false;                   //结束游戏
                MessageBox.Show("恭喜你通关了");         //显示恭喜消息框
            }
            if (floor.CheckSnake())                      //判断蛇是否死亡
                timer1.Enabled = false;                  //结束游戏
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int k, d = 0;
            k = e.KeyValue;
            if (k == 37)              //左
                d = 3;
            else if (k == 40)         //下
                d = 2;
            else if (k == 38)         //上
                d = 0;
            else if (k == 39)         //右
                d = 1;
            floor.S.TurnDirection(d);
        }
        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("F1开始/重新开始" + 
                "\n" + "F2暂停/继续\n" + "上下右左键为控制蛇的方向键");
            timer1.Enabled = true;
        }
        private void MenuExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //以下两句是为了设置控件样式为双缓冲，这可以有效减少闪烁的问题
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();

        }
        private void 加快ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ren_speed = true;        //玩家设置速度
            timer1.Interval -= 50;
        }
        private void 减速ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ren_speed = true;        //玩家设置速度
            timer1.Interval += 50;
        }
    }
}

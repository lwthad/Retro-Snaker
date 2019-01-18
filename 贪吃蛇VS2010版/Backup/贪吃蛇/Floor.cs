using System;
using System.Drawing;

namespace ̰����
{
    /// <summary>
    /// floor ��ժҪ˵����
    /// </summary>
    public class Floor
    {
        public Floor(Point d)                           //���캯��������Ϊ�˶������Ͻ�λ��
        {
            dot = d;                                    //d�������Ͻ�λ���ֶ�
            s = new Snake(d, 10);                       //���˶���λ��d������ߵĿ���ʵ�����߶����ֶ�
            bean1 = new Bean();                         //ʵ�����������ֶ�
            bean1.Origin = new Point(d.X + 30, d.Y + 30); //�ɲ���dʵ������λ��
        }
        private static int unit = 5;                     //���徲̬��λ���ȣ�������ֶγ�ʼ��Ҫ�ôˣ����農̬
        private int length = 80 * unit;                 //�˶������ȣ����Ÿ���
        private int width = 50 * unit;                  //�˶�����ȣ����Ÿ���
        private Point dot;                              //�˶������Ͻ�λ��
        public int score;                               //��Ϸ����
        private Snake s;                                //�߶����ֶ�
        private Bean bean1;                             //�������ֶ�
        public Snake S                                 //�߶���ֻ������
        {
            get { return s; }
        }

        public void displaybean(Graphics g)             //��ʾ�¶�����
        {
            bean1.UnDisplay(g);                         //����ԭ����
            bean1 = randombean();                       //���������
            bean1.Display(g);                           //��ʾ�¶�
        }

        public void ReSet(Graphics g)                   //���������߷���
        {
            s.UnDisplay(g);                             //������ǰ��
            s.Reset(dot, 10);                           //��������

        }
        private Bean randombean()                       //�������������
        {
            Random random = new Random();                 //����α���������ʵ����
            int x = random.Next(length / unit - 2) + 1;         //��Next����������֮���һ������
            int y = random.Next(width / unit - 2) + 1;          //��Next����������֮���һ������
            Point d = new Point(dot.X + x * 5, dot.Y + y * 5);     //���˶���λ�ú�x,y�������ʵ���������
            Bean bb = new Bean();
            bb.Origin = d;                                //�㸳���¶�λ������
            return bb;                                  //�����¶�
        }
        public void Display(Graphics g)                 //��ʾ�˶�������������Ϊһͼ�ζ���
        {
            Pen p = new Pen(Color.Red);                   //�����ʲ��ú�ɫʵ������
            g.DrawRectangle(p, dot.X, dot.Y, length, width);//���ϱʻ�һλ����dot��������ֱ�Ϊlength��width�ľ���
            s.Display(g);                               //��ʾ��
            CheckBean(g);                               //��鶹�Ƿ񱻳�
            bean1.Display(g);                           //��ʾ��
        }

        public void CheckBean(Graphics g)               //��鶹�Ƿ񱻳ԣ�����Ϊͼ�ζ���
        {
            if (bean1.Origin.Equals(s.getHeadPoint))    //�ж϶���λ���Ƿ�����ͷλ����ͬ
            {
                score = score + 10;                     //������
                this.displaybean(g);                    //��ʾ�¶�
                s.Growth();                             //���Զ�����
            }
        }

        //������Ƿ�ײǽ
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


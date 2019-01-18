using System;
using System.Drawing;

namespace ̰����
{
    /// <summary>
    /// block ��ժҪ˵����
    /// </summary>
    public class Block
    {
        public Block()                                 //���캯��
        {

        }
        private int number;                             //���������ֶ�
        private Point origin;                           //����λ���ֶ�
        private bool ishead=false;                      //������ͷ��־�ֶ�
        public int Number                               //����
        {
            get { return number; }
            set { number = value; }
        }
        public bool Ishead                               //����
        {
            get { return ishead; }
            set { ishead = value; }
        }
        public Point Origin
        {
            get { return origin; }
            set { origin = value; }
        }
        public void Display(Graphics g)             //��ʾ�鷽��
        {
            //Pen p = new Pen(Color.Red);
            //g.DrawRectangle(p, origin.X, origin.Y, 5, 5);
            if (Ishead)                            //����ͷ
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
        public void UnDisplay(Graphics g)           //�����鷽��
        {
            //Pen p = new Pen(Color.Silver);            //��������ɫ��
            //g.DrawRectangle(p, origin.X, origin.Y, 5, 5);
            SolidBrush b = new SolidBrush(Color.Silver);  //���屳��ɫ��ˢ
            //�ñ���ɫ�ػ�ԭ�����μ�����ԭ����
            g.FillRectangle(b, origin.X, origin.Y, 5+1, 5+1);
        }
    }
}


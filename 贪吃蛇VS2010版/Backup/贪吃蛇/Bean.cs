using System;
using System.Drawing;

namespace ̰����
{
    /// <summary>
    /// bean ��ժҪ˵����
    /// </summary>
    public class Bean
    {
        public Bean()//���캯��
        {
        }
        private Point origin;                           //����λ���ֶ�
        public Point Origin                             //����λ������
        {
            get { return origin; }
            set { origin = value; }
        }
        public void Display(Graphics g)                 //��ʾ������
        {
            SolidBrush b = new SolidBrush(Color.Red);     //�����ɫ��ˢ
            g.FillRectangle(b, origin.X, origin.Y, 5, 5);   //��ʵ�ľ���
            //Bitmap b = new Bitmap(Image.FromFile("Blue.gif"));
            //g.DrawImage(b, origin.X, origin.Y, 5, 5);   
        }
        public void UnDisplay(Graphics g)               //����������
        {
            SolidBrush b = new SolidBrush(Color.Silver);  //���屳��ɫ��ˢ
            //�ñ���ɫ�ػ�ԭ�����μ�����ԭ����
            g.FillRectangle(b, origin.X, origin.Y, 5, 5);
        }
    }
}


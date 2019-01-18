using System;
using System.Drawing;
using System.Collections;

namespace ̰����
{
    /// <summary>
    /// snake ��ժҪ˵����
    /// </summary>
    ///
    public class Snake
    {
        ArrayList blockList;            //�ֶ�
        private int headNumber;         //��ͷ�������߳���
        private Point headPoint;        //��ͷλ�ã����Ͻ����꣩
        private int direction = 1;      //0,1,2,3�ֱ�����ϡ��ҡ��¡���
        public Snake()                 //���캯��
        {

        }
        public Snake(Point vertex, int count)                 //������Ϸ��ʼ����
        {
            Block bb;
            Point p = new Point(vertex.X + 25, vertex.Y + 25);//������ʼλ��
            blockList = new ArrayList(count);                   //��ʼ���鳤��Ϊcount
            for (int i = 0; i < count; i++)                    //ͨ��ѭ�����blockList
            {
                p.X = p.X + 5;                                  //x�����
                bb = new Block();                               //ʵ�����¿�
                bb.Origin = p;                                  //���λ�ø�ֵ
                bb.Number = i + 1;                              //���п������ӿ�ʼ
                //�������ͷ�Ͱ�λ�ã����㣩����headPoint
                if (i == count - 1)
                {
                    headPoint = bb.Origin;                      //���ߵ�ͷλ�ø�ֵ
                    bb.Ishead = true;
                }
                blockList.Add(bb);                              //�ѿ���ӵ�blockList��
            }
            headNumber = count;                                 //����ͷ�������߳��ȣ���ֵ
        }


        public Point getHeadPoint                               //ֻ����ͷλ������
        {
            get { return headPoint; }
        }
        public bool getHitSelf                                  //�ж����Ƿ����������ֻ������
        {
            get
            {
                IEnumerator myEnumerator = blockList.GetEnumerator();//���岢ʵ����ö�ٽӿ�
                try
                {
                    while (myEnumerator.MoveNext())               //ͨ��ѭ�������ߵĸ���
                    {
                        Block b = (Block)myEnumerator.Current;      //��ȡ��ǰ��
                        //��ǰ�鲻����ͷ������ͷλ����ͬ
                        if (!b.Ishead && b.Origin.Equals(headPoint))//b.Number != headNumber
                        {
                            return true;                            //����true
                        }
                    }
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.ToString());
                }
                return false;                                       //����false
            }
        }
        public int Direction                                        //�ߵ����з�������
        {
            get { return direction; }
            set { direction = value; }
        }

        public void TurnDirection(int pDirection)                   //�ߵ�ת�򷽷�������Ϊ��Ҫ�ı䷽��
        {
            switch (direction)
            {
                case 0:                                             //ԭ������
                    if (pDirection == 3)                             //����ı䷽��Ϊ��
                        direction = 3;
                    else if (pDirection == 1)                       //����ı䷽��Ϊ��
                        direction = 1;
                    break;
                case 1:
                    if (pDirection == 2)
                        direction = 2;
                    else if (pDirection == 0)
                        direction = 0;
                    break;
                case 2:
                    if (pDirection == 3)
                        direction = 3;
                    else if (pDirection == 1)
                        direction = 1;
                    break;
                case 3:
                    if (pDirection == 2)
                        direction = 2;
                    else if (pDirection == 0)
                        direction = 0;
                    break;
            }
        }

        public void Growth()                                        //����������
        {
            Block b = (Block)blockList[blockList.Count - 1];
            int x = b.Origin.X;                         //��ȡ��ǰ�鼴��ͷ��λ������
            int y = b.Origin.Y;
            b.Ishead = false;  
            switch (direction)                           //���ݵ�ǰ�˶����������¿�����
            {
                case 0:                                 //����y�����
                    y = y - 5;
                    break;
                case 1:
                    x = x + 5;
                    break;
                case 2:
                    y = y + 5;
                    break;
                case 3:
                    x = x - 5;
                    break;
            }
            Point headP = new Point(x, y);          //�����깹��ͷλ�õ�
            Block bb = new Block();                                 //���岢ʵ�����¿�
            bb.Origin = headP;                      //�ѵ㸳���¿��λ������
            bb.Number = b.Number + 1;               //��ǰ�������+1�����¿����������
            bb.Ishead = true; 
            blockList.Add(bb);                      //���¿���ӵ�blockList��
            headNumber++;                          //ͷ����������ߵĳ��ȣ�����
            headPoint = headP;                      //��ͷλ�ø���ֵ            
        }

        public void Display(Graphics g)                         //��ʾ�߷���������Ϊͼ�ζ���
        {
            Block b = new Block();                            //���岢��ʼ���¿�b
            b = (Block)blockList[0];                          //ȡ��blockList�ĵ�һ��Ԫ�ظ�b
            b.UnDisplay(g);                                 //����b����ʾ
            blockList.RemoveAt(0);                          //��blockList���Ƴ���һ��
            foreach (Block b1 in blockList)
            {
                b1.Number--;                               //��ǰ�����������ֵ��1
            }
            headNumber--;
            Growth();
            foreach(Block b1 in  blockList)
            {
                b1.Display(g);
            }  
        }
        public void UnDisplay(Graphics g)                               //�����߷���
        {
            foreach (Block b1 in blockList)
            {
                b1.UnDisplay(g);
            } 
        }
        public void Reset(Point dian, int count)                        //���¿�ʼ��Ϸ
        {                                                               //�빹�캯������
            Block bb;
            Point p = new Point(dian.X + 25, dian.Y + 25);
            blockList = new ArrayList(count);
            for (int i = 0; i < count; i++)
            {
                p.X = p.X + 5;
                bb = new Block();
                bb.Number = i + 1;
                bb.Origin = p;
                //�������ͷ�ͰѶ��㸳��headPoint
                if (i == count - 1)
                {
                    headPoint = bb.Origin;
                    bb.Ishead = true;
                }
                blockList.Add(bb);
            }
            headNumber = count;
            direction = 1;            //���ҷ���
        }
    }
}


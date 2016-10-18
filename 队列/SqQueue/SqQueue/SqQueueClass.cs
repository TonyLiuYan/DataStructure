using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqQueue
{
    /// <summary>
    /// 循环队列类
    /// </summary>
    class SqQueueClass
    {
        private const int MaxSize = 5;

        public string[] data;//存放队中元素
        public int front, rear;//队头和队尾指针

        public SqQueueClass()
        {
            data = new string[MaxSize];//为data分配空间
            rear = 0;//队头和队尾指针置初值
            front = 0;
        }

        /// <summary>
        /// 判断队列是否为空
        /// </summary>
        /// <returns></returns>
        public bool QueueEmpty()
        {
            return (front == rear);
        }

        /// <summary>
        /// 进队列算法
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public bool enQueue(string e)
        {
            if ((rear + 1) % MaxSize == front)//队满上溢出
            {
                return false;
            }
            rear = (rear + 1) % MaxSize;
            data[rear] = e;
            return true;
        }

        /// <summary>
        /// 出队列算法
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool deQueue(ref string e)
        {
            if (front == rear)//队空下溢出
            {
                return false;
            }
            front = (front + 1) % MaxSize;
            e = data[front];
            return true;
        }

        /// <summary>
        /// 将对中所有元素构成一个字符串返回
        /// </summary>
        /// <returns></returns>
        public string DispQueue()
        {
            int i;
            string myStr = String.Empty;

            if (front == rear)
            {
                myStr = "空队";
            }
            else
            {
                i = (front + 1) % MaxSize;
                while (i != rear)
                {
                    myStr += data[i] + ",";
                    i = (i + 1) % MaxSize;
                }
                myStr += data[rear];
            }
            return myStr;
        }

        /// <summary>
        /// 返回队中元素个数
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            return ((rear - front + MaxSize) % MaxSize);
        }

    }
}

using System;
using System.Text;
using System.Xml;

namespace DoAn
{
    class Node
    {
        #region attributes
        private  MatHang data;
        public Node next;
        #endregion
        #region properties
        public MatHang Data
        {

            get => data;
            set => data = value;
        }
        public Node Next
        { get => next;
          set => next = value;
        }

        #region methods
        public Node(MatHang mh)
        {
            this.data = mh;
            this.Next = null;
        }
        public Node()
        {

        }
        #endregion
    }
     public class HashTable
    {  
        #region attributes
        private const int M = 1009;
        private Node[] buckets = new Node[M];
        #endregion
        #region properties
        private int HashFunction(string ma)
        {
            int hash = 0;
            foreach (char c in ma)
            {
                hash += c;
            }
            return hash % M;
        }
        public void Insert(MatHang mh)
        {
            int index = HashFunction(mh.MaMatHang);
            Node newNode = new Node(mh);
            if (buckets[index] == null)
            {
                buckets[index] = newNode;
            } 
            newNode.Next = buckets[index];
            buckets[index]=newNode;

        }
        public MatHang Search(string ma)
        {
            int index = HashFunction(ma);
            Node t = buckets[index];
            while (t != null)
            {
                if (t.Data.MaMatHang == ma )
                {
                    return t.Data;
                }
                t = t.Next;
            }
            return null;
        }
        public bool DeleteKey(string mh)
        {
            int index = HashFunction(mh);
            Node t = buckets[index];
            Node pre = null;
            while (t != null)
            {
                if (t.Data.MaMatHang == mh)
                {
                    if (pre == null)
                        buckets[index] = t.Next;
                    else
                        pre.Next = t.Next;
                    return true;
                }
                pre = t;
                t = t.Next;
            }
            return false;
        }
        public void PrintHashTable()
        {
            for(int i = 0; i<M; i++)
            {
                Console.WriteLine($"Bucket[{i}]: ");
                Node t = buckets[i];
                while (t != null)
                {
                    t.Data.XuatThongTin();
                    t = t.Next;
                }
   
            }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    internal class OrderedList
    {
        public Node Head;
        public void Ordered(string str)
        {
            string text = File.ReadAllText(@"C:\AMD\RFP244\Data_Structure_Programs_244\DataStructurePrograms\DataStructurePrograms\order.txt");
            string[] words = text.Split(' ');
            Array.Sort(words);
            for(int i = 0; i < words.Length; i++)
            {
                Node node = new Node(words[i]);
                if (this.Head == null)
                
                    this.Head = node;
                
                else
                {
                    node.next = this.Head;
                    this.Head = node;
                }
            }
            Node temp = this.Head;
            Node prve = null;
            int flag = 0;
            while(temp != null)
            {
                if (temp.Data.Equals(str))
                {
                    prve.next = temp.next;
                    flag = 1;
                }
                prve = temp;
                temp = temp.next;
            }
            if(flag == 0)
            {
                Node node = new Node(str);
                node.next = this.Head;
                this.Head = node;
            }
            Console.WriteLine("List of the searching Word");
            Node node1 = this.Head;
            string[] array = new string[100];
            int j = 0;
            while (node1 != null)
            {
                array[j] = node1.Data + " ";
                node1 = node1.next;
                j++;
            }
            string contact = string.Concat(array);
            Console.WriteLine(contact);
            File.WriteAllText(@"C:\AMD\RFP244\Data_Structure_Programs_244\DataStructurePrograms\DataStructurePrograms\order.txt", contact);
        }
    }
}

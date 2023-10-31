using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
   class linklist
    {
        private LinkedList<int> list;
        private LinkedListNode<int> listNode;
        public linklist()
        {
          list  = new LinkedList<int>();
          listNode = list.First;
        }
        
        public  void menu()
        {
            Console.Clear();
            Console.WriteLine("============= MENU DANH SACH LIEN KET =============");
            Console.WriteLine("0. Hien thi danh sach");
            Console.WriteLine("1. Them vao dau danh sach");
            Console.WriteLine("2. Them vao cuoi danh sach");
            Console.WriteLine("3. Chen vao sau 1 Node");
            Console.WriteLine("4. Chen vao truoc 1 Node");
            Console.WriteLine("5. Kiem tra Node co gia tri bang x");
            Console.WriteLine("6. Xoa dau");
            Console.WriteLine("7. Xoa cuoi");
            Console.WriteLine("8. Xoa tat ca");
            Console.WriteLine("9. Xoa Node co du lieu bang x");
            Console.WriteLine("10. Tim node");
            Console.WriteLine("11. Thoat");
            Console.WriteLine("====================================================");
            Console.Write("Nhap lua chon cua ban: ");
        }
        public void Choice(int choice)
        {           
           
            switch (choice)
            {
                case 0:
                    display();
                    Console.ReadKey();
                    break;
                case 1:
                    {
                        Console.Write("Nhap phan tu: ");
                        int x = Int32.Parse(Console.ReadLine());
                        add(x);
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Nhap phan tu: ");
                        int x = Int32.Parse(Console.ReadLine());
                        addC(x);
                    }
                    break;
                case 3:
                    {
                        Console.Write("Nhap phan tu can chen: ");
                        int x = Int32.Parse(Console.ReadLine());
                        Console.Write("Chen sau phan tu: ");
                        int y = Int32.Parse(Console.ReadLine());
                        addAfter(x, y);
                    }
                    break;
                case 4:
                    {
                        Console.Write("Nhap phan tu can chen: ");
                        int x = Int32.Parse(Console.ReadLine());
                        Console.Write("Chen sau phan tu: ");
                        int y = Int32.Parse(Console.ReadLine());
                        addBefore(x, y);
                    }
                    break;
                case 5:
                    {
                        Console.Write("Nhap gia tri: ");
                        int x = Int32.Parse(Console.ReadLine());
                        
                        if (Contains(x))
                            Console.WriteLine("Danh sach co chua gia tri " + x);
                        else Console.WriteLine("Danh sach khong chua gia tri " + x);
                        Console.ReadKey(true);
                    }
                    break;
                case 6:
                    {
                        removeD();
                    }
                    break;
                case 7:
                    {
                        removeC();
                    }
                    break;
                case 8:
                    {
                        removeAll();
                    }
                    break;
                case 9:
                    {
                        Console.Write("Nhap gia tri can xoa: ");
                        int x = Int32.Parse(Console.ReadLine());
                        removeX(x);
                    }
                    break;
                case 10:
                    {
                        Console.Write("Nhap gia tri can tim: ");
                        int x = Int32.Parse(Console.ReadLine());
                        find(x);
                    }
                    break;
                case 11:
                    return;
                   
                    default:
                    
                    Console.WriteLine("Lua chon khong hop le: Chon lai");
                    Console.ReadKey();
                    break;


            }
        }
        public void add(int x)
        {
           list.AddFirst(x);
        }
        public void addC(int x)
        {
            list.AddLast(x);
        }
        public void display()
        {
            if(list.Count == 0)
            {
                System.Console.WriteLine("Khong co phan tu nao");
                return;
            }
            foreach (int x in list)
                Console.Write(x + " ");           
        }
        public void removeD()
        {
           list.RemoveFirst();
        }
        public void removeC()
        {
            list.RemoveLast(); 
        }
        public void removeAll()
        {
            list.Clear();
        }
        public bool Contains(int x)
        {
            bool containsValue = list.Contains(x);
            return containsValue;
        }
        public void addAfter(int x, int y)
        {
            LinkedListNode<int> targetNode = list.Find(y);
            if (targetNode != null)
            {
                
                LinkedListNode<int> newNode = new LinkedListNode<int>(x);

                
                list.AddAfter(targetNode, newNode);
            }

        }
        public void addBefore(int x, int y)
        {
            LinkedListNode<int> targetNode = list.Find(y);
            if (targetNode != null)
            {

                LinkedListNode<int> newNode = new LinkedListNode<int>(x);


                list.AddBefore(targetNode, newNode);
            }
        }
        public void removeX(int x)
        {
            
           list.Remove(x);
        }
        public void find(int x)
        {
            LinkedListNode<int> targetNode = list.Find(x);
            if (targetNode != null)
                Console.WriteLine("Nut dau tien co gia tri " + x + " o truoc gia tri: " + targetNode.Next.Value + " va sau gia tri: " + targetNode.Previous.Value);
            else Console.WriteLine("Khong ton tai node mang gia tri " + x);
            Console.ReadKey();
        }
                   
    }
    class program
    {
       
        static void Main(string[] args)
        {
            linklist l = new linklist();         
            while (true)
            {
                l.menu();
                int luachon = Int32.Parse(Console.ReadLine());
                l.Choice(luachon);
                if (luachon == 11)
                    return;
               
            }                 
        }     
    }
}

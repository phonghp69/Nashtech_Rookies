using System;
using System.Collections.Generic;

namespace AssDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> list = new List<Member>();
            list.Add(new Member("Tuan", "Phong", "Male", "01/01/2000", "0986784647", "HP", 22, true));
            list.Add(new Member("van", "phuc", "Male", "01/01/2000", "0986784647", "HP", 22, false));
            Member mb= new Member();
            mb.Add();
            list.Add(mb);
            MyList m = new MyList(list);
            Console.WriteLine("Danh sach sinh vien");
            m.ShowList();
        }
    }
}

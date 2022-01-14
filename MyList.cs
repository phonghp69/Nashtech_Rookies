using System;
using System.Collections.Generic;
namespace AssDay1
{
   internal class MyList{
       private List<Member> list;
       public MyList(List<Member> list){
           this.list= list;
       }
       internal void AddList(){
           Member mb = new Member();
           mb.Add();
           list.Add(mb);
       }
       internal void ShowList()
        {
            foreach (var item in list)
            {
                item.Show();
            }
        }
    }
}
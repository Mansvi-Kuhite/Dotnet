using System;
using System.Collections;

namespace Day5
{

    class Program
    {
        public static void Main()
        {
            var res1=new Resource("Res1");
            var res2=new Resource("Res2");
            res1=null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            System.Console.WriteLine("GC implemented");
            RecordDemo();
            //ArrayCollectionDemo();
            CollectionClassesDemo();
            CollectionClassesDemo2();
        }
        private static void ResourceDemo(){
            using(var manager =new FileManager("DisposableRes")){
                manager.OpenFile("path/to/file.txt");

            }
            using var manager2=new FileManager("DisposableRes");
        }    
    
        private static void RecordDemo(){
            var temp1=new Temp { Id=1, Name="Temp1"};
              var temp2=new Temp { Id=1, Name="Temp1"};
              System.Console.WriteLine(temp1);
              System.Console.WriteLine(temp2);
              System.Console.WriteLine(temp1==temp2);

              var temp3=temp1 with { Id = 2};
              System.Console.WriteLine(temp3);
        }

        public static void ArrayCollectionDemo()
        {
            ArrayList list=new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add("hello");
            list.Add(3.14);

            // foreach (var item in collection)
            // {
                
            // }
            int sum=0;
            foreach(var item in list)
            {
                System.Console.WriteLine($"item: {item}, type: {item.GetType()}");
                sum+=(int)item;
                System.Console.WriteLine($"Sum: {sum}");
            }
        }

        public static void CollectionClassesDemo()
{
    List<string> list=new List<string>();
    list.Add("1");
    list.Add("2");
    list.Add("3");
    list.Add("4");
    System.Console.WriteLine(list.Count);

    foreach(var item in list)
    {
        System.Console.WriteLine(item);
    }

    }    

    public static void CollectionClassesDemo2()  
    {
        List<int> marks=new List<int>(10);
        marks.Add(1);
        marks.Add(1);
        System.Console.WriteLine($"Count: {marks.Count}, Capacity: {marks.Capacity}");

        marks.AddRange(new int[] {1,2,3});
        System.Console.WriteLine($"Count: {marks.Count}, Capacity: {marks.Capacity}");
 
         marks.AddRange(new List<int>  {4,5,6});
                 System.Console.WriteLine($"Count: {marks.Count}, Capacity: {marks.Capacity}");
         
             marks.AddRange(new List<int>  {4,5,6});
                      System.Console.WriteLine($"Count: {marks.Count}, Capacity: {marks.Capacity}");
     
             System.Console.WriteLine($"Marks Avg: {marks.Average()}");
       
    }  


        
    }
}

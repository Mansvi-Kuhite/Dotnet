namespace Day5{
    public class Resource{
        public string Name{ get; set;}

        public Resource(string name){
            Name=name;
            System.Console.WriteLine($"{Name} created");
        }
        ~Resource(){
            System.Console.WriteLine($"{Name}destroyed by GC");
        }
    }
}
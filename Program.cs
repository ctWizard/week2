using System.Xml.Schema;





public class Person
{
    private string Name  {get;set;}
    private int Age {get;set;}
    private Person?[] Child {get;set;}
    public Person(string name, int age,Person?[] child){
        Name=name;
        Age=age;
        Child=child;
    }
    public void DisplayInfo(){
        Console.WriteLine(Name + " " +Age);
        foreach(Person child in Child){
            if (child==null){
            Console.WriteLine("No child");
        }
        else{
            Console.WriteLine("Childs info");
            child.DisplayInfo();
        }
        }
        
    }
    public void NewChild(string name, int age=0){
        int length=0;
        if (Child[0]!=null){
            length=Child.Length;
            Console.WriteLine("length= "+length);
            Person?[] current = Child;
            
        }
        
        
        Person test = new Person(name,age,[null]);
        if (length==0){
            Person[] newList = new Person[1];
            newList[0]=test;
            Child=newList;
        }
        else{
            Person[] newList = new Person[length+1];
            for (int i=0;i<length;i++){
                newList[i]=Child[i];
            }
            newList[length]=test;
            Child=newList;

        }
        

    }

}










//Linked list code

public class Node{
    public int Data;
    public Node Next;
    public Node(int data){
        Data = data;
        Next = null;
    }
}

public class LinkedList{
    private Node head;
    public void Add(int data){
        Node newNode= new Node(data);
        if (head==null){
            head = newNode;
        }
        else{
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void PrintList(){
        Node current = head;
        while (current != null){
            Console.Write(current.Data + " ->");
            current=current.Next;
        }
        Console.WriteLine("null");
    }
    //used ai to walk through the implementation, needs more study
    public void DeleteValue(int val){
        if (head ==null) return;
        if (head.Data==val)
        {
            head = head.Next;
            return; 
        }
        Node current = head;
        Node? prev =null;
        while (current !=null && current.Data !=val)
        {
            prev =current;
            current = current.Next;
        }
        if (current==null)return;

        prev!.Next = current.Next;

    }
    


}
internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Start of week 2 lab");
        Person child = new Person("child",1,[null]);
        Person child2 = new Person("child2",2,[null]);
        Person Corey = new Person("Corey",22,[child,child2]);
        Corey.DisplayInfo();
        Person child3 = new Person("child3",0,[null]);

        Corey.NewChild("child3",0);
        Console.WriteLine("");
        Corey.DisplayInfo();







        //task 2 test
        Console.WriteLine("\ntest add array function by adding mult1 and mult2 \n");
        static void PrintArray(int[] arr){
        foreach (int num in arr){
            Console.WriteLine(num);
        }
        }
        static int[,] addMultArr(int[,] arr1, int[,] arr2){
            int[,] answer=new int[2,3];
            for (int x=0;x<2;x++){
                for (int y=0;y<3;y++){
                    answer[x,y]=arr1[x,y]+arr2[x,y];
                }
            }
            return answer;
        }
        int[,] mult1 ={{1,2,3},{1,2,3}};
        int[,] mult2 ={{1,2,3},{1,2,3}};

        int[,] solved = addMultArr(mult1,mult2);
        foreach(int num in solved)
        {
            Console.WriteLine(num);
        }
        int[] numbers = { 10, 20, 5, 8, 15 };
        //task 3 test
        Console.WriteLine("\nTest linked list");
        LinkedList myList = new LinkedList();
        myList.Add(10);
        myList.Add(20);
        myList.Add(30);
        myList.DeleteValue(20);
        myList.PrintList();
    }
}
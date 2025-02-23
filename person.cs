using System.Globalization;

public class Person{
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
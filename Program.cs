/*Console.WriteLine("Start of week 2 lab");
Person child = new Person("child",1,[null]);
Person child2 = new Person("child2",2,[null]);
Person Corey = new Person("Corey",22,[child,child2]);
Corey.DisplayInfo();
Person child3 = new Person("child3",0,[null]);

Corey.NewChild("child3",0);
Console.WriteLine("");
Corey.DisplayInfo();
*/
using System.Xml.Schema;

int[] numbers ={10,20,5,8,15};
/*static void PrintArray(int[] arr){
    foreach (int num in arr){
        Console.WriteLine(num);
    }
}*/

static int[,] addMultArr(int[,] arr1, int[,] arr2){
    int xLen=arr1.GetLength(0);
    int yLen=arr1.GetLength(0);
    int[,] answer=new int[xLen,yLen];
    for (int x=0;x<xLen;x++){
        for (int y=0;y<yLen;y++){
            answer[x,y]=arr1[x,y]+arr2[x,y];
        }
    }
    return answer;
}

int[,] mult1 ={{1,2,3},{1,2,3}};
int[,] mult2 ={{1,2,3},{1,2,3}};

int[,] solved = addMultArr(mult1,mult2);
foreach(int num in solved){
    Console.WriteLine(num);
}


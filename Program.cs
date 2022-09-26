int strCount = 3;
int colCount = 4;
int [,] arr = new int [strCount,colCount];

Random rnd = new Random();
for (int i = 0; i < strCount; i++)
{
    for (int j = 0; j < colCount; j++)
    {
       arr[i,j] = rnd.Next(1,10); 
        System.Console.Write(arr[i,j] + " ");
    }  
    System.Console.WriteLine();
}
System.Console.WriteLine();

int Temp = 0;
for (int j = 0; j < colCount; j++)
{
    Temp = arr[0,j];
    arr[0,j] = arr[strCount-1,j] ;
    arr[strCount-1,j] = Temp ;
}

for (int i = 0; i < strCount; i++)
{
    for (int j = 0; j < colCount; j++)
    {
        System.Console.Write(arr[i,j] + " ");
    }  
    System.Console.WriteLine();
}    



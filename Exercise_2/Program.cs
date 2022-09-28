//int counter = 12;
//while(counter >= 0)
//{
//    Console.WriteLine("papp" + counter);
//    counter--;
//}



//Console.WriteLine("numer of sum:");
//string a = Console.ReadLine();
//bool check = int.TryParse(a, out int b);
//int sum = 1;
//int num = 1;
//while(num < b)
//{
//    num++;
//    sum += num;
//    Console.WriteLine(" + " + num);
//}
//Console.WriteLine(" = " + sum);



//Console.WriteLine("factorial : ");
//string lel = Console.ReadLine();
//bool num = int.TryParse(lel, out int nan);
//decimal bab = 1;
//do
//{
//    bab *= nan;
//    nan--;
//} while (nan > 0);
//Console.WriteLine("result: "+ bab);




//Console.WriteLine(" n = ");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine("m = ");
//int m = int.Parse(Console.ReadLine());
//int num = n;
//long product = 1;
//do
//{
//    product *= num;
//    num++;
//} while (num <= m);
//Console.WriteLine(" [n...m] =  " + product);    


// for loop
//Console.WriteLine(" n = ");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine(" m = ");
//int m = int.Parse(Console.ReadLine());
//long sum = 1;
//for(int i = 0; i < m; i++)
//{
//    sum *= n;

//}
//Console.WriteLine(" sum = " + sum);




//int n = 6;
//for (int row = 1; row <= n; row++)
//{
//    for (int col = 1; col < row; col++)
//    {
//        Console.WriteLine(" " + col);
//    }
//    Console.WriteLine("");
//}


// try lotto
//using System.Numerics;

//BigInteger sum = 0;
//for(int i1 = 1; i1 < 44; i1++)
//{
//    for (int i2 = 1; i2 < 45; i2++)
//    {
//        for (int i3 = 1; i3 < 46; i3++)
//        {
//            for(int i4 = 1; i4 < 47; i4++)
//            {
//                for(int i5 = 1; i5 < 48; i5++)
//                {
//                    for (int i6 = 1; i6 < 49; i6++)
//                    {
//                        sum++;
//                        Console.WriteLine(sum);
//                    }
//                }
//            }
//        }
//    }
//}
//Console.WriteLine(sum);



// new array

//int[] arr = new int[12];
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = i;
//    Console.WriteLine(arr[i]);
//}


int[] arr = { 1, 4, 2, 5, 23 };
int length = arr.Length;
//Console.WriteLine(length + " " + arr[0]);
int a = length - 1;
int[] newArray = new int[length];
for (int i = 0; i < length; i++)
{
    
    newArray[a] = arr[i];
    a--;
    Console.WriteLine(newArray[i]);
}



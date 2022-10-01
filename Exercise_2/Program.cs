//დაწერეთ პროგრამა რომელიც კლავიატურიდან შეიტანს 10 ელემენტს
//და შეავსებს მასივს. (სცადეთ სხვადასხვა ტიპისთვის)


//Console.WriteLine("Enter the Massive Element: ");
//int[] arr = new int[10];
//for (int i = 0; i < arr.Length; i++)
//{
//    string num = Console.ReadLine();
//    bool check = int.TryParse(num, out int a);
//    if (check)
//    {
//        arr[i] = a;
//    }

//}
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}


//დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოიტანს რიცხვს n-ს
//და დაბეჭდავს 1-დან n მდე რიცხვებს ისე როგორც სურათზეა(სურ 1).
//(თითო ხაზზე ელემენტების რაოდენობა იზრდება 1-ით)

//Console.WriteLine("enter the number : ");
//string num = Console.ReadLine();
//bool check = int.TryParse(num, out int a);


//კლავიატურიდან შემოიტანეთ რიცხვი და დათვალეთ
//1-დან n მდე კენტი რიცხვების ჯამი, ნამრავლი.

//Console.WriteLine("enter the number : ");
//string num = Console.ReadLine();
//bool check = int.TryParse(num, out int a);
//if (check)
//{
//    int summ = 0;
//    int mult = 1;
//    for (int i = 1; i <= a; i++)
//    {
//        if (i % 2 == 1)
//        {
//            summ += i;
//            mult *= i;
//        }
//    }
//    Console.WriteLine(" summ: " + summ + "\n mult:  " + mult);
//}


//დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოტანილი
//რიცხვისთვის დაითვლის 1-დან n მდე ამ რიცხვების კვადრატების ჯამს.
//Console.WriteLine("Enter the number: " );
//string num = Console.ReadLine();
//bool check = int.TryParse(num, out int a);
//if (check)
//{
//    int b = 1;
//    int result = 0;
//    while (b <= a)
//    {
//        result += (b * b);
//        b++;
//    }
//    Console.WriteLine($"result is : {result}");
//}



//დაწერეთ პროგრამა რომელიც შეამოწმებს არის თუ არა სტრინგი პალინდრომი.
//(პალინდრომია სტრინგი თუ ის შებრუნებული სახითაც იგივენაირად იკითხება) asdffdsa

//Console.WriteLine("Enter the string: ");
//string num = Console.ReadLine();
//int a = num.Length;
//int c = a / 2;
//int b = num.Length % 2;
//int i = 0;
//int j = 1;
//if (b == 0)
//{
//    if (j <= c)
//    {
//        while (num[i] == num[a - j])
//        {
//            i++;
//            j++;
//            Console.WriteLine("is iitt");
//        }

//    }
//}
//else
//{
//    Console.WriteLine("no reversable");
//}

//////////
//ვერ გავიგე ეს დავალება
//////////////
//მოცემულია მასივი, რომელიც შეგიძლიათ შეავსთ კლავიატურიდანაც და პროგრამიდანაც.
//დაწერეთ პროგრამა რომელიც დაითვლის ამ მასივში თითოეული ელემენტის რაოდენობას,

//Console.WriteLine("Enter the array elements: ");
//string n = Console.ReadLine();
//bool check = int.TryParse(n, out int a);
//int[] arr = new int[a];
////int arr_length = arr.Length;
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine("Enter the elements: ");
//    string s = Console.ReadLine();
//    bool check_2 = int.TryParse(s, out int elem);
//    arr[i] = elem;
//}
//for(int j = 0; j < arr.Length; j++)
//{
//    Console.WriteLine($"arr. elements {arr[j]}");
//}

/////////////////////////////////////////////////////////
//დაწერეთ პროგრამა რომელიც მასივში დაითვლის
//ამ მასივში უმცირეს,უდიდეს ელემენტს და იპოვნის მედიანას(შუა წევრს)


//int[] arr = new int[5];
//int smallest=0;
//int biggest=0;
//byte po_f = 0;
//for(int i = 0; i < arr.Length; i++)
//{
//    string a = Console.ReadLine();
//    bool check = int.TryParse(a, out int b);
//    arr[i] = b;   
//    while(po_f == 0)
//    {
//        smallest = arr[i];
//        biggest = arr[i];
//        po_f++;
//    }
//    if(arr[i] >= biggest)
//    {
//        biggest = arr[i];
//    }
//    if (arr[i] <= smallest)
//    {
//        smallest = arr[i];
//    }
//    po_f++;


//}
//Console.WriteLine($"the biggest is: {biggest}");
//Console.WriteLine($"\nthe smallest is: {smallest}");
//if ((arr.Length % 2) == 0)
//{
//    Console.WriteLine("NO MEDIUM NUMBER");
//}
//else
//{
//    Console.WriteLine("medium: " + (arr[(arr.Length / 2)]));
//}

//დაწერეთ პროგრამა რომელიც მოცემულ
//მასივს დაბეჭდავს შებრუნებული სახით მაგ 1 2 3 4 —-> 4 3 2 1

Console.WriteLine("Enter the arrays emenemts: ");
int[] arr = new int[4];

for (int i = 0; i < arr.Length; i++)
{
    string a = Console.ReadLine();
    bool check = int.TryParse(a, out int result);
    arr[i] = result;
}
for (int j = 1; j <= (arr.Length); j++)
{
    Console.WriteLine(arr[arr.Length-j]);
}



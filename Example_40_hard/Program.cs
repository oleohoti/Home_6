// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. Определить , является ли это сторонами треугольника. Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.
void Triange(int a, int b, int c)// является или неявляется эти три целых числа сторонами треугольника
{
    bool arg =true;
    int sum = a+b+c;
    int []array =new int[3]; 
    foreach ( int item in array)
    {
        sum+=item;
    }
    Console.WriteLine($"sum = {sum}");
    foreach (double item in array)
    {
        if (item<sum-item)
        {
            arg=true;Console.WriteLine($"{item} < {sum-item}");
        }
        else {arg=false;Console.WriteLine($"{item} > {sum-item}");break;}
    }
    if (arg==false) Console.WriteLine("Треугольник не может существовать с сторонами такой длины");
    else Console.WriteLine("Треугольник может существовать с сторонами такой длины");
}
int []Components(int a, int b, int c)// определение гипотинузы и катетов
{
    int []array=new int[3];
    int gip=a; int kat1 =b; int kat2 = c;
    if (b>a) gip=b; kat1=a;kat2=c;
    if (c>max) gip=c; kat1=a;kat2=b;
    // if (gip*gip==kat1*kat1+kat2*kat2) System.Console.WriteLine("Треугольник прямоугольный");}
    array[0]=gip; array[1]=kat1; array[2]=kat2;
    return array;

}
int[] Vid(int[] info)// равнобедренный, прямоугольный, равносторонний
{
    if(a==b&&b==c) info[3]=1;
    else if (a==b||c==a||c==b) info[3]=2;
    else if (info[0]*info[0]==info[1]*info[1]+info[2]*info[2])info[3]=3;
}
void Perimetr(int[]info)
{
 int perimetr=info[0]+info[1]+info[2];
 info[5]=perimetr;
}
void Ploshad(double[]info)
{
    double pp=p/2;
    double h = 0;
    double s = 0;
    if (info[3]==1){h=2/a*sqrt(pp(pp-a)(pp-b)(pp-c)); s=a*h/2;}
    if(info[3]==2){s=(args*a*s(3,2))/4;}
    if(info[3]==3){s=1/2*a*b;}
    info[4]=s;
}
void Corners(double[]info)
{
double CosA=(b*b+c*c-a*a)/2*c*b;
double CosB=(a*a+c*c-b*b)/2*c*a;
double CosC=(b*b+a*a-c*c)/2*a*b;
}
void Info(double[]info)
{
    Console.WriteLine("Общие хар-ки треугольника:");
    if (info[3]==1) Console.WriteLine("Треугольник является равносторонним");
    if (info[3]==2) Console.WriteLine("Треугольник является равнобедренным");
    if (info[3]==3) Console.WriteLine("Треугольник является прямоугольным");
    Console.WriteLine($"Гипотинуза  равна {info[0]}, первый катет равен {info[1]}, второй катет равен {info[2]}");
    Console.WriteLine($"Площадь равна {info[4]}");
    Console.WriteLine($"Периметр равен {info[5]}");
    Console.WriteLine($"Угол между гипотинузой и первым катетом равен {info[6]} градусам, угол между гипотинузой и вторым катетом {info[7]} градусам, угол между двумя катетами {info[8]} градусам.");

}
Console.WriteLine("Введите три целых числа");
Console.WriteLine("Введите первое число");
int a=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c=Convert.ToDouble(Console.ReadLine());
Triange(a,b,c);
int[]info=new int[8];
int[]Info=Components(a,b,c);

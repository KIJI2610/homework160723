System.Console.WriteLine("Введите числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if(a > b && a > c){
    System.Console.WriteLine("Наибольшее число: "+ a);
}
else if (a < b && c < b){
        System.Console.WriteLine("Наибольшее число: "+ b);
}
else if(c > a && c > b){
    System.Console.WriteLine("Наибольшее число: "+ c);
}
else{
    System.Console.WriteLine("Попробуйте еще раз");
}

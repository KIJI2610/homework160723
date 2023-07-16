System.Console.WriteLine("Введите числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if(a > b){
    System.Console.WriteLine("Наибольшее число: "+ a);
}
else if (a < b){
        System.Console.WriteLine("Наибольшее число: "+ b);
}
else{
    System.Console.WriteLine("Попробуйте еще раз");
}
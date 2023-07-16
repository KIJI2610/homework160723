System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 0; n >= i; i++){
    if (i % 2 == 0){
        System.Console.WriteLine(i);
    }
}
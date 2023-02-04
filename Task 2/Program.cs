// Написать программу масштабирования фигуры



int q;
Console.WriteLine("Введите число вершин: ");
q = int.Parse(Console.ReadLine());
    

int[,] numbers = new int[2,q];

for (int n = 0; n < 2; n++){
    for (int m = 0; m < q; m++){
    Console.WriteLine("Введите координаты вершин сначала по оси Х, затем по оси У: ");
    numbers[n,m] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();}

Console.WriteLine("Введите коэффициент масштабирования: ");
int k = int.Parse(Console.ReadLine());
for (int i = 0; i < 2; i++){
    for (int j = 0; j < q; j++){
    numbers[i,j] = numbers[i,j] * k;

}}


Console.WriteLine();
        for (int i = 0; i < 2; i++)
        {
        for (int j = 0; j < q; j++){
        Console.Write(numbers[i, j] + " ");}
        Console.WriteLine();
        }

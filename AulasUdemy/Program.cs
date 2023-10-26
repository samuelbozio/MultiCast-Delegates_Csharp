

    delegate void OperacoesNumericas(double n1, double n2);

class Program
{
    static void Main(string[] args)
    {

        double a = 10;
        double b = 20;

        OperacoesNumericas on = CalculationService.ShowSum;
        on += CalculationService.ShowMax;
        on.Invoke(a, b);   
        


    }
}





class CalculationService 
{

    public static void ShowMax(double x, double y)
    {
        double max = (x > y)  ? x : y;  
        Console.WriteLine(max);
    }

    public static void ShowSum(double x, double y)
    {
        double sum = x + y;
        Console.WriteLine(sum);
    }



}




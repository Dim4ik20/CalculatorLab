public class Calculator
{
    public double Add(double a, double b) => a + b;
    public double Subtract(double a, double b) => a - b;
    public double Multiply(double a, double b) => a * b;

    public double Divide(double a, double b)
    {
        if (b == 0) throw new DivideByZeroException("Деление на ноль");
        return a / b;
    }

    public long Factorial(int n)
    {
        if (n < 0) throw new ArgumentOutOfRangeException(nameof(n));
        long r = 1;
        for (int i = 2; i <= n; i++) r = checked(r * i);
        return r;
    }

    public bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
            if (n % i == 0) return false;
        return true;
    }
}
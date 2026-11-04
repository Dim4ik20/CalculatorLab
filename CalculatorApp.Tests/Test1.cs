[TestClass]
public class CalculatorTests
{
    private readonly Calculator c = new();

    // Корректные значения
    [TestMethod] public void Add_CorrectValues_ReturnsSum() => Assert.AreEqual(5, c.Add(2, 3));
    [TestMethod] public void Divide_CorrectValues_ReturnsQuotient() => Assert.AreEqual(2.5, c.Divide(10, 4));

    // Граничные условия
    [TestMethod] public void Factorial_Zero_ReturnsOne() => Assert.AreEqual(1, c.Factorial(0));
    [TestMethod] public void Factorial_20_ReturnsMaxLong() => Assert.AreEqual(2432902008176640000L, c.Factorial(20));

    // Исключительные ситуации
    [TestMethod] public void Divide_ByZero_Throws() => Assert.Throws<DivideByZeroException>(() => c.Divide(1, 0));
    [TestMethod] public void Factorial_21_ThrowsOverflow() => Assert.Throws<OverflowException>(() => c.Factorial(21));
    [TestMethod] public void Factorial_Negative_Throws() => Assert.Throws<ArgumentOutOfRangeException>(() => c.Factorial(-1));
}
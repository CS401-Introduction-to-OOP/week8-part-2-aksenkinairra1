namespace Week8;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10;
        object b = a;
        int c = (int)b;
        
        Console.WriteLine($"Original int a: {a}");
        Console.WriteLine($"Boxed object b: {b}");
        Console.WriteLine($"Unboxed int c: {c}");
        
        // Boxing: копіюємо значення 'a' у новий об'єкт у купі
        // Unboxing: копіюємо значення з об'єкта в купі назад у стек
        // Print
    }
}

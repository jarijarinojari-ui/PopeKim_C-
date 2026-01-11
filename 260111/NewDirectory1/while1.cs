namespace _260111.NewDirectory1;

public class while1 {
    public static void Main()
    {
        Console.WriteLine("User count: ");
        int length = int.Parse(Console.ReadLine());
        int[] ages = new int[length];
        float[] heights = new float[length];

        int totalAge = 0;
        float totalHeight = 0.0f;
        int count = 0;
        while (count < length)
        {
            Console.Write($"Enter user {count}'s age: ");
            ages[count] = int.Parse(Console.ReadLine());
            totalAge += ages[count];
                
            Console.Write($"Enter user{count}'s height(cm): ");
            heights[count] = float.Parse(Console.ReadLine());
            totalHeight += heights[count];
                
            
            ++count;
        }
        Console.WriteLine($"Total ages: {totalAge}");
        Console.WriteLine($"Total heights: {totalHeight}");

    }
    
}
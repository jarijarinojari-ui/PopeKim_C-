namespace _260111.NewDirectory1;

public class Dowhile
{
    public static void Main()
    {
        // 1. 배열을 먼저 선언하고 크기를 지정해야 합니다.
        int[] ages = new int[3]; 
        
        // 2. 메서드 내부에서는 private을 빼고 선언합니다.
        int count = 0; 

        do
        {
            Console.WriteLine($"{count + 1}번째 숫자를 입력하세요:");
            // 3. 입력받은 값을 배열에 저장합니다.
            ages[count] = int.Parse(Console.ReadLine());
            
            ++count;
        } while (count < 3);

        // 결과 확인을 위한 출력 코드 (선택 사항)
        Console.WriteLine("입력된 값들: " + string.Join(", ", ages));
    }
}
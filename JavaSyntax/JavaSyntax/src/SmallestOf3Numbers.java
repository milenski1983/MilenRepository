import java.lang.reflect.Array;
import java.util.Scanner;

public class SmallestOf3Numbers {
	public static void main(String[] args){
		
		Scanner scanner = new Scanner(System.in);
		
		int[] numbers = new int[3];
		for (int i = 0; i < numbers.length; i++) {
			numbers[i] = scanner.nextInt();
		}
		scanner.close();
		
		int min = findMin(numbers);
		System.out.printf("The smallest numbers is: %d", min);
	}

	private static int findMin(int[] numbers) {

		int min = Integer.MAX_VALUE;
		for (int i = 0; i < numbers.length; i++) {
			if (numbers[i] < min) {
				min = numbers[i];
			}
		}
		
		return min;
	}

}

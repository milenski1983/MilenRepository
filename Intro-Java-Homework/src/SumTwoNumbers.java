import java.util.Scanner;

public class SumTwoNumbers {
	public static void main(String[] args) {
		
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Enter a number: ");
		int firstNumber = scanner.nextInt();
		System.out.print("Enter another number: ");
		int secondNumber = scanner.nextInt();
		
		int sum = sum(firstNumber, secondNumber);
		System.out.printf("The sum is %1$d%n", sum);
		
		scanner.close();
	}

	private static int sum(int firstNumber, int secondNumber) {

		return firstNumber + secondNumber;
	}

}

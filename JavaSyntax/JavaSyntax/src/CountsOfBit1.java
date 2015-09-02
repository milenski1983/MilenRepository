import java.util.Scanner;


public class CountsOfBit1 {

	public static void main(String[] args) {

		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Enter an integer: ");
		int num = scanner.nextInt();
		int oneCounter = 0;
		
		for (int i = 0; i < 32; i++) {
			if (((num >> i) & 1) != 0) {
				oneCounter++;
			}
		}

		System.out.printf("Number of 1s in the %d are: %d (%s)", num, oneCounter, Integer.toBinaryString(num));
	}

}

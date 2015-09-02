import java.util.Scanner;


public class CountOfEqualBitPairs {
	
	public static void main(String[] args) {
		
		Scanner scanner = new Scanner(System.in);
		System.out.print("Enter an integer: ");
		int num = scanner.nextInt();
		int pairCounter = 0;
		
		String binary = Integer.toBinaryString(num);
		
		for (int i = 0; i < binary.length() - 1; i++) {
			if (binary.charAt(i) == binary.charAt(i + 1)) {
				pairCounter++;
			}
			
		}
		
		System.out.printf("Number of pair bits in the number %d is %d", num, pairCounter);
	}

}

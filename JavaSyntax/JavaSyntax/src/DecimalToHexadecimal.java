import java.util.Scanner;


public class DecimalToHexadecimal {
	
	public static void main(String[] args) {

		System.out.print("Enter a decimal number: ");
		
		Scanner scanner = new Scanner(System.in);
		int decimal = scanner.nextInt();
		scanner.close();
		
		String hex = Integer.toHexString(decimal);
		System.out.printf("Hexadecimal: %s", hex);
		
	}

}

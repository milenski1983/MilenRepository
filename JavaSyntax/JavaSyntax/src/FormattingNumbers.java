import java.math.BigInteger;
import java.util.Scanner;

public class FormattingNumbers {
	public static void main(String[] args) {
		
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Enter an Integer: ");
		int intNum = scanner.nextInt();
		System.out.print("Enter a Float: ");
		float floatNum1 = scanner.nextFloat();
		System.out.print("Enter another Float: ");
		float floatNum2 = scanner.nextFloat();		
		
		System.out.printf("|%-10s|", Integer.toHexString(intNum));
		//System.out.printf("%s", "|");
		System.out.printf("%010d|", Integer.parseInt((Integer.toBinaryString(intNum))));
		System.out.printf("%10.2f|", floatNum1);
		System.out.printf("%-10.3f|", floatNum2);

	}
}

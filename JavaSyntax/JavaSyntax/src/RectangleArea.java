import java.util.Scanner;


public class RectangleArea {
	
	public static void main(String[] args) {
		
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Enter side a: ");
		int a = scanner.nextInt();
		System.out.print("Enter side b: ");
		int b = scanner.nextInt();
		
		int area = a * b;
		System.out.println("The area is " + area);

		scanner.close();
	}

}

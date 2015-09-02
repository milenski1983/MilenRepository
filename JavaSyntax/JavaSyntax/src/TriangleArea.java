import java.util.Scanner;

public class TriangleArea {
	
	public static void main(String[] args) {
		
		char[] pointsName = {'a','b','c'};
		Point[] points = new Point[pointsName.length];
		Scanner input = new Scanner(System.in);
		
		for (int i = 0; i < pointsName.length; i++) {
			char currentPointName = pointsName[i];
			System.out.printf("Enter X for point %1$c: ", currentPointName);
			int x = input.nextInt();
			System.out.printf("Enter Y for point %1$c: ", currentPointName);
			int y = input.nextInt();
			points[i] = new Point(x, y);						
		}

		input.close();
		
		double area = (double)(points[0].getX() * (points[1].getY() - points[2].getY()) 
				+ points[1].getX() * (points[2].getY() - points[0].getY()) 
				+ points[2].getX() * (points[0].getY() - points[1].getY())) / 2;
		
		
		System.out.printf("The area is %.0f", Math.abs(area));
	}

}

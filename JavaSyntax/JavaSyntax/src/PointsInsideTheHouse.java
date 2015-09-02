import java.util.Scanner;


public class PointsInsideTheHouse {
	
	public static void main(String[] args) {

		Triangle roof = new Triangle(new Point(17.5, 3.5), new Point(12.5, 8.5), new Point(22.5, 8.5));		
		Rectangle wallA = new Rectangle(new Point(12.5, 8.5), 5, 5);
		Rectangle wallB = new Rectangle(new Point(20, 8.5), 2.5, 5);
		
		Scanner scanner = new Scanner(System.in);
		System.out.print("X: ");
		double x = scanner.nextDouble();
		System.out.print("Y: ");
		double y = scanner.nextDouble();
		Point point = new Point(x, y);
		
		if (isInsideRoof(point, roof) || isInsideWall(point, wallA) || isInsideWall(point, wallB)) {
			System.out.println("Inside");
		} else {
			System.out.println("Outside");
		}
		
	}

	private static boolean isInsideWall(Point point, Rectangle wall) {
		if (point.getX() >= wall.getInitialPoint().getX()
				&& point.getX() <= (wall.getInitialPoint().getX() + wall.getLength())
				&& point.getY() >= wall.getInitialPoint().getY()
				&& point.getY() <= (wall.getInitialPoint().getY() + wall.getHeight())) {
			return true;
		}
		
		return false;
	}

	private static boolean isInsideRoof(Point point, Triangle roof) {
		double roofArea = roof.area();
		Triangle abpTriangle = new Triangle(roof.getVertex("a"), roof.getVertex("b"), point);
		double abpTriangleArea = abpTriangle.area();
		Triangle apcTriangle = new Triangle(roof.getVertex("a"), point, roof.getVertex("c"));
		double apcTriangleArea = abpTriangle.area();
		Triangle pbcTriangle = new Triangle(point, roof.getVertex("b"), roof.getVertex("c"));
		double pbcTriangleArea = abpTriangle.area();
		
		if ((abpTriangleArea + apcTriangleArea + pbcTriangleArea) == roofArea) {
			return true;
		}
		
		return false;
	}

}

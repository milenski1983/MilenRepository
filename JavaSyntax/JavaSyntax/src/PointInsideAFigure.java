import java.util.Scanner;


public class PointInsideAFigure {
	
	public static void main(String[] args) {
		
		Rectangle[] figure = new Rectangle[3];
		
		figure[0] = new Rectangle(new Point(12.5, 8.5), 5, 5);
		figure[1] = new Rectangle(new Point(20, 8.5), 2.5, 5);
		figure[2] = new Rectangle(new Point(12.5, 6), 10, 2.5);

		Scanner scanner = new Scanner(System.in);
		
		while(scanner.hasNext()){
			String input = scanner.nextLine();
			String[] inputSplited = input.split(" ");
			double x = Double.parseDouble(inputSplited[0]);
			double y = Double.parseDouble(inputSplited[1]);
			
			Point point = new Point(x, y);
			boolean isInside = checkIfThePointIsInside(point, figure);
			
			System.out.println(isInside?"Inside":"Outside");
		}
		
		scanner.close();
		
	}

	private static boolean checkIfThePointIsInside(Point point,
			Rectangle[] figure) {
		
		for (Rectangle rectangle : figure) {
			
			boolean insideX = point.getX() >= rectangle.getInitialPoint().getX() 
					&& point.getX() <= rectangle.getInitialPoint().getX() + rectangle.getLength();
			boolean insideY = point.getY() >= rectangle.getInitialPoint().getY()
					&& point.getY() <= rectangle.getInitialPoint().getY() + rectangle.getHeight();
			
			if (insideX && insideY) {
				return true;
			}			
		}
		
		return false;
	}

}

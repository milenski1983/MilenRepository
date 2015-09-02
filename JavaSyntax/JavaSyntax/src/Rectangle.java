public class Rectangle {
	
	private Point initialPoint;
	private double length;
	private double height;
	private Point[] points = new Point[4];
	
	public Rectangle(Point initialPoint, double length, double height){
		this.initialPoint = initialPoint;
		this.length = length;
		this.height = height;		
	}
	
	public void setPoints(){
		this.points[0] = initialPoint;
		this.points[1] = new Point(initialPoint.getX() + length, initialPoint.getY());
		this.points[2] = new Point(initialPoint.getX() + length, initialPoint.getY() + height);
		this.points[3] = new Point(initialPoint.getX(), initialPoint.getY() + height);
	}
	
	public Point[] getPoints(){
		return this.points;
	}
	
	public Point getInitialPoint(){
		return this.initialPoint;
	}
	
	public double getLength(){
		return this.length;
	}
	
	public double getHeight(){
		return this.height;
	}

}

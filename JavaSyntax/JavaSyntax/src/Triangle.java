
public class Triangle {
	
	private Point[] vertices;
	
	public Triangle(Point a, Point b, Point c){
		this.vertices = new Point[]{a, b, c};
	}

	public Point getVertex(String vertex) {	
		
		String vertexToLower = vertex.toLowerCase();
		switch(vertexToLower){
		case "a":
			return this.vertices[0];
		case "b":
			return this.vertices[1];
		case "c":
			return this.vertices[2];
		default:
			return null;
		}
	}
	
	public double area(){
		return Math.abs(vertices[0].getX() * (vertices[1].getY() - vertices[2].getY())
				+ vertices[1].getX() * (vertices[2].getY() - vertices[0].getY())
				+ vertices[2].getX() * (vertices[0].getY() - vertices[1].getY()));
	}
	
}

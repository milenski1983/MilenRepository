import java.util.Date;

public class CurrentDateTime {
	public static void main(String[] args) {
		Date date = new Date();
		System.out.println(date);
		System.out.printf("Formatted date: %1$tA, %1$td %1$tB %1$tY, %1$tH:%1$tM", date);
		
	}

}

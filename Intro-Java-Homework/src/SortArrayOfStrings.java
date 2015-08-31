import java.lang.reflect.Array;
import java.util.Scanner;


public class SortArrayOfStrings {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		System.out.print("Enter the array length: ");
		int arrayLength = scanner.nextInt();
		
		String[] array = new String[arrayLength];
		
		for (int i = 0; i < array.length; i++) {
			System.out.printf("%1$d: ",i);
			array[i] = scanner.nextLine();
		}
		
		scanner.close();
		
		String[] sortedArray = sortArray(array);
		for (String string : sortedArray) {
			System.out.print(string + " ");			
		}
		
	}

	private static String[] sortArray(String[] array) {
		
		for (int i = 0; i < array.length - 1; i++) {
			for (int j = i + 1; j < array.length; j++) {
				 if (array[j].compareTo(array[i]) < 0) {
					 String temp= array[j];
		             array[j]= array[i]; 
		             array[i]=temp;
				}
			}
		}
		
		return array;
	}

}

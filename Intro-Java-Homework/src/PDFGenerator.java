import java.awt.Color;
import java.io.File;
import java.io.FileOutputStream;
import java.io.FileWriter;
import java.io.IOException;
import java.io.OutputStream;
import java.util.ArrayList;
import org.apache.pdfbox.PDFBox;

import com.itextpdf.text.Anchor;
import com.itextpdf.text.BadElementException;
import com.itextpdf.text.BaseColor;
import com.itextpdf.text.Chapter;
import com.itextpdf.text.Document;
import com.itextpdf.text.DocumentException;
import com.itextpdf.text.Element;
import com.itextpdf.text.Font;
import com.itextpdf.text.List;
import com.itextpdf.text.ListItem;
import com.itextpdf.text.Paragraph;
import com.itextpdf.text.Phrase;
import com.itextpdf.text.Section;
import com.itextpdf.text.pdf.PdfPCell;
import com.itextpdf.text.pdf.PdfPTable;
import com.itextpdf.text.pdf.PdfWriter;

import cards.Card;


public class PDFGenerator {

	public static void main(String[] args) {
		
		String[] specialFaceStrings = {"J", "Q", "K", "A"};
		char[] suits = {'\u2660', '\u2665', '\u2666', '\u2663'};
		ArrayList<Card> cards = new ArrayList<>();
		
		String currentFace = " ";
		char currentSuit = ' '; 
		for (int face = 2; face <= 14; face++) {
			currentFace = String.valueOf(face);
			if (face > 10) {
				currentFace = specialFaceStrings[face - 11];
			}
			
			for (int suit = 0; suit < 4; suit++) {
				currentSuit = suits[suit];
				
				cards.add(new Card(currentFace, currentSuit));
			}
						
		}
		File file = new File("DeckOfCards.pdf");
		Document document = new Document();
		
		try {	
			PdfWriter.getInstance(document, new FileOutputStream(file));
			document.open();
			Paragraph paragraph = new Paragraph();
			for (Card card : cards) {	
				Font font = new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD);
				if (card.getColor() == Color.red) {
					font.setColor(255, 0, 0);
				} else {
					font.setColor(0, 0, 0);
				}
				
				paragraph.add(card.toString() + "\n");
				System.out.println(card.toString());				
			}
			document.add(paragraph);
			
		} catch (Exception e) {
			// TODO: handle exception
			
		} finally {
			document.close();
		}
		
	}

}

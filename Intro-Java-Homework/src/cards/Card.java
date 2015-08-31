package cards;

import java.awt.Color;
import java.util.List;

import com.itextpdf.text.Chunk;
import com.itextpdf.text.ElementListener;

public class Card implements com.itextpdf.text.Element{

	private String face;
	private char suit;
	private Color color;
	
	public Card(String face, char suit){
		this.face = face;
		this.suit = suit;
		this.setColor();
	}
	
	public String getFace(){
		return this.face;
	}
	
	public char getSuit(){
		return this.suit;
	}
	
	public Color getColor(){
		return this.color;
	}
	
	private void setColor(){
		if (this.suit == '\u2665' || this.suit == '\u2663') {
			this.color = new Color(255, 0, 0);
		}else{
			this.color = new Color(0, 0, 0);
		}
	}

	@Override
	public String toString(){
		return (this.face + this.suit);		
	}

	@Override
	public List<Chunk> getChunks() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public boolean isContent() {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean isNestable() {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean process(ElementListener arg0) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public int type() {
		// TODO Auto-generated method stub
		return 0;
	}
}
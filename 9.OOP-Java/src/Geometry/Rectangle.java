package Geometry;

import java.util.List;

public class Rectangle extends PlaneShape{
	
	private double width;
	private double height;
	
	public Rectangle(List<Vertice> newListOfVertices, double newHeight,double newWidth) {
		super(newListOfVertices);
		this.setHeight(newHeight);
		this.setWidth(newWidth);
	}
	
	public double getWidth(){
		return this.width ;
	}
	public void setWidth(double newWidth){
		this.width = newWidth ;
	}
	
	public double getHeight(){
		return this.height ;
	}
	public void setHeight(double newHeight){
		this.height = newHeight ;
	}
	
	public void setListOfVertices(List<Vertice> newListOfVertices){
		if(newListOfVertices.size() != 1){
			throw new IllegalArgumentException("This is not 1 vertices!");
		}
		super.setListOfVertices(newListOfVertices);
	}
	
	@Override
	public double getArea() {
		
		return (this.width * this.height);
	}

	@Override
	public double getPerimeter() {
		
		return (2 * this.width + 2 * this.height);
	}

	@Override
	public String toString() {
		List<Vertice> newList = getListOfVertices();
		String result = "";
		for (int i = 0; i < newList.size(); i++) {
			result += String.format("%s%n", newList.get(i).toString3D());
		}
		result += String.format("Width: %.2f Height: %.2f",
				getWidth(), getHeight());
		return result;
	}
}

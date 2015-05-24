package Geometry;

import java.util.List;

public class Circle extends PlaneShape {
	
	private double radius;
	
	public Circle(List<Vertice> newListOfVertices) {
		super(newListOfVertices);
	}
	
	public double getRadius(){
		return this.radius;
	}
	
	public void setRadius(double newRadius){
		if(newRadius > 0){
			this.radius = newRadius;
		}
		else{
			System.out.println("Invalid radius!");
		}
	}
	
	public void setListOfVertices(List<Vertice> newListOfVertices){
		if(newListOfVertices.size() != 1){
			throw new IllegalArgumentException("This is not 1 vertices!");
		}
		super.setListOfVertices(newListOfVertices);
	}
	
	
	@Override
	public double getArea() {
		
		return Math.PI * this.radius * this.radius;
	}

	@Override
	public double getPerimeter() {
		
		return Math.PI * radius;
	}
	
	@Override
	public String toString() {
		List<Vertice> newList = getListOfVertices();
		String result = "";
		for (int i = 0; i < newList.size(); i++) {
			result += String.format("%s%n", newList.get(i).toString2D());
		}
		result += String.format("Radius: %.2f",
				getRadius());
		return result;
	}
	
}

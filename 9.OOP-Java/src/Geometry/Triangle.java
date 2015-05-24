package Geometry;

import java.util.List;


public class Triangle extends PlaneShape{

	public Triangle(List<Vertice> newListOfVertices) {
		super(newListOfVertices);
	}
	
	public void setListOfVertices(List<Vertice> newListOfVertices){
		if(newListOfVertices.size() != 3){
			throw new IllegalArgumentException("There aren't 3 vertices!");
		}
		super.setListOfVertices(newListOfVertices);
	}
	
	public double calcSideA(){
		double x0 = getListOfVertices().get(0).getX();
		double x1 = getListOfVertices().get(1).getX();
		double y0 = getListOfVertices().get(0).getY();
		double y1 = getListOfVertices().get(1).getY();
		double underRoot =  (x0 - x1) * (x0 - x1) + (y0 - y1) * (y0 - y1) ;
		double a = java.lang.Math.sqrt(underRoot);
		
		return a;
	}
	
	public double calcSideB(){
		double x0 = getListOfVertices().get(0).getX();
		double x1 = getListOfVertices().get(2).getX();
		double y0 = getListOfVertices().get(0).getY();
		double y1 = getListOfVertices().get(2).getY();
		double underRoot =  (x0 - x1) * (x0 - x1) + (y0 - y1) * (y0 - y1) ;
		double b = java.lang.Math.sqrt(underRoot);
		
		return b;
	}
	
	public double calcSideC(){
		double x0 = getListOfVertices().get(1).getX();
		double x1 = getListOfVertices().get(2).getX();
		double y0 = getListOfVertices().get(1).getY();
		double y1 = getListOfVertices().get(2).getY();
		double underRoot =  (x0 - x1) * (x0 - x1) + (y0 - y1) * (y0 - y1) ;
		double c = java.lang.Math.sqrt(underRoot);
		
		return c;
	}
	@Override
	public double getArea() {
		
		 double semiPerimeter = (calcSideA() + calcSideB() + calcSideC()) / 2;
		 
		 double area = semiPerimeter * (semiPerimeter - calcSideA()) * 
				 						(semiPerimeter - calcSideB()) * 
				 						(semiPerimeter - calcSideC());
		 return area;
	}

	@Override
	public double getPerimeter() {
		
		return (calcSideA() + calcSideB() + calcSideC());
	}
	
	@Override
	public String toString() {
		List<Vertice> newList = getListOfVertices();
		String result = "";
		for (int i = 0; i < newList.size(); i++) {
			result += String.format("%s%n", newList.get(i).toString2D());
		}
		return result;
	}
	
	
}

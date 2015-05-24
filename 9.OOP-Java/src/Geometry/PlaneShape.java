package Geometry;

import java.util.List;

public abstract class PlaneShape extends Shape implements IPerimeterMeasurable{
	
	public PlaneShape(List<Vertice> newListOfVertices){
		super(newListOfVertices);
	}
	
	public void setListOfVertices(List<Vertice> newListOfVertices){
		
		for(int i = 0; i < newListOfVertices.size(); i++){
			
			if((newListOfVertices.get(i).getZ()) == null){
				
				throw new IllegalArgumentException("Cannot be given 3D points!");
			}
			
		}
		super.setListOfVertices(newListOfVertices);
	}
	
	public abstract double getArea();
	
	public abstract double getPerimeter();
	
}

package Geometry;

import java.util.List;

public class Sphere extends SpaceShape{
	
	private double radius;
	
	public Sphere(List<Vertice> newListOfVertices, double radius) {
		super(newListOfVertices);
		this.setRadius(radius);
	}
	
	public double getRadius(){
		return this.radius;
	}
	
	public void setRadius(double newRadius){
		if(newRadius > 0){
			this.radius = newRadius;
		}
		else{
			throw new IllegalArgumentException("Invalid radius");
		}
	}
	
	@Override
	public double getVolume() {
		
		return (4/3) * Math.PI * this.radius * this.radius * this.radius;
	}

	@Override
	public double getArea() {
	
		return 4 * Math.PI * this.radius * this.radius;
	}

	@Override
	public String toString() {
		List<Vertice> newList = getListOfVertices();
		String result = "";
		for (int i = 0; i < newList.size(); i++) {
			result += String.format("%s%n", newList.get(i).toString3D());
		}
		result += String.format("Radius: %.2f",
				getRadius());
		return result;
	}
		
}



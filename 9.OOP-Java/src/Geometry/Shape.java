package Geometry;

import java.util.List;

public abstract class Shape implements IAreaMeasurable {

	private List<Vertice> listOfVertices;

	public Shape(List<Vertice> newListOfVertices) {

		this.setListOfVertices(newListOfVertices);
	}

	public List<Vertice> getListOfVertices() {

		return this.listOfVertices;
	}

	public void setListOfVertices(List<Vertice> newListOfVertices) {

		this.listOfVertices = newListOfVertices;
	};

	public abstract double getArea();

}

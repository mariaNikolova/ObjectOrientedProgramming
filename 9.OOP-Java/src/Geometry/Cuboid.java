package Geometry;

import java.util.List;

public class Cuboid extends SpaceShape implements IVolumeMeasurable{

	private double width;
	private double height;
	private double depth;

	public Cuboid(List<Vertice> newListOfVertices, double width, double height, double depth) {
		super(newListOfVertices);
		this.setWidth(width);
		this.setHeight(height);
		this.setDepth(depth);
	}

	public double getWidth() {
		return this.width;
	}

	public void setWidth(double newWidth) {
		if (newWidth > 0) {
			this.width = newWidth;
		} else {
			throw new IllegalArgumentException("Invalid base width!!!");
		}
	}

	public double getHeight() {
		return this.height;
	}

	public void setHeight(double newHeight) {
		if (newHeight > 0) {
			this.height = newHeight;
		} else {
			throw new IllegalArgumentException("Invalid  height!!!");
		}
	}

	public double getDepth() {
		return this.depth;
	}

	public void setDepth(double newDepth) {
		if (newDepth > 0) {
			this.depth = newDepth;
		} else {
			throw new IllegalArgumentException("Invalid depth!!!");
		}
	}

	@Override
	public double getVolume() {

		return this.getWidth() * this.getHeight() * this.getDepth();
	}

	@Override
	public double getArea() {

		return 0;
	}

	@Override
	public String toString() {
		List<Vertice> newList = getListOfVertices();
		String result = "";
		for (int i = 0; i < newList.size(); i++) {
			result += String.format("%s%n", newList.get(i).toString3D());
		}
		result += String.format("Width: %.2f Height: %.2f Depth: %.2f",
				getWidth(), getHeight(), getDepth());
		return result;
	}
}

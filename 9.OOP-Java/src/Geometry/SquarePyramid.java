package Geometry;

import java.util.List;

public class SquarePyramid extends SpaceShape {

	private double baseWidth;
	private double pyramidHeight;

	public SquarePyramid(List<Vertice> newListOfVertices, double baseWidth,
			double pyramidHeight) {
		super(newListOfVertices);
		setBaseWidth(baseWidth);
		setPyramidHeight(pyramidHeight);
	}

	public double getBaseWidth() {
		return this.baseWidth;
	}

	public void setBaseWidth(double newBaseWidth) {
		if (newBaseWidth > 0) {
			this.baseWidth = newBaseWidth;
		} else {
			throw new IllegalArgumentException("Invalid base width!!!");
		}
	}

	public double getPyramidHeight() {
		return this.pyramidHeight;
	}

	public void setPyramidHeight(double newPyramidHeight) {
		if (newPyramidHeight > 0) {
			this.pyramidHeight = newPyramidHeight;
		} else {
			throw new IllegalArgumentException("Invalid pyramid height!!!");
		}
	}

	@Override
	public double getVolume() {
		return (getBaseWidth() * getBaseWidth() * getPyramidHeight()) / 3.0;
	}

	@Override
	public double getArea() {
		double baseArea = getBaseWidth() * getBaseWidth();
		double triangleArea = (Math.sqrt((getBaseWidth() / 2)
				* (getBaseWidth() / 2)
				+ (getPyramidHeight() * getPyramidHeight())) * getBaseWidth()) / 2.0;
		return baseArea + 4 * triangleArea;
	}

	@Override
	public String toString() {
		List<Vertice> newList = getListOfVertices();
		String result = "";
		for (int i = 0; i < newList.size(); i++) {
			result += String.format("%s%n", newList.get(i).toString3D());
		}
		result += String.format("Base width: %.2f Pyramid height: %.2f",
				getBaseWidth(), getPyramidHeight());
		return result;
	}
}

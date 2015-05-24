package Geometry;

import java.util.List;

public abstract class SpaceShape extends Shape implements IVolumeMeasurable {

	public SpaceShape(List<Vertice> newListOfVertices) {
		super(newListOfVertices);
	}

	public void setListOfVertices(List<Vertice> newListOfVertices) {
		if (newListOfVertices.size() != 1) {
			throw new IllegalArgumentException("This is not 1 vertice!");
		}

		for (int i = 0; i < newListOfVertices.size(); i++) {

			if (newListOfVertices.get(i).getX() == null
					|| newListOfVertices.get(i).getY() == null
					|| newListOfVertices.get(i).getZ() == null) {

				throw new IllegalArgumentException(
						"Incorrect array of Vertices!!!");
			}
			super.setListOfVertices(newListOfVertices);
		}
	}

	@Override
	public abstract double getVolume();

	@Override
	public abstract double getArea();

}
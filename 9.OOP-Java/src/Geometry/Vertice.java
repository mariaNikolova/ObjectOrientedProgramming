package Geometry;

public class Vertice {

	private Double x;
	private Double y;
	private Double z;

	public Vertice(double newX, double newY, double newZ) {

		this.setX(newX);
		this.setY(newY);
		this.setZ(newZ);
	}

	public Vertice(double newX, double newY) {

		this.setX(newX);
		this.setY(newY);
	}

	public Double getX() {

		return this.x;
	}

	public void setX(Double newX) {

		this.x = newX;
	}

	public Double getY() {

		return this.y;
	}

	public void setY(Double newY) {

		this.y = newY;
	}

	public Double getZ() {

		return this.z;
	}

	public void setZ(Double newZ) {

		this.z = newZ;
	}

	public String toString3D() {
		return String.format("X: %.2f Y: %.2f Z: %.2f", getX(), getY(), getZ());
	}

	public String toString2D() {
		return String.format("X: %.2f Y: %.2f", getX(), getY());
	}
}

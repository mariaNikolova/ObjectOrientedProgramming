package Geometry;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Arrays;
import java.util.Comparator;
import java.util.List;
import java.util.function.Predicate;
import java.util.stream.Collector;
import java.util.stream.Collectors;
import java.util.stream.Stream;


public class ShapesExamples {

	public static void main(String[] args) {
		Vertice paramTwoFirst = new Vertice(1, 2, 3);

		List<Vertice> list2DVertices = new ArrayList<>();
		list2DVertices.add(paramTwoFirst);

		SquarePyramid squarePyramid = new SquarePyramid(list2DVertices, 50, 100);
		Sphere sphere = new Sphere(list2DVertices,50);
		Cuboid cuboid = new Cuboid(list2DVertices, 20, 40, 60);
		
		List<SpaceShape> shapes = new ArrayList<SpaceShape>();
		shapes.add(squarePyramid);
		shapes.add(sphere);
		shapes.add(cuboid);
		
		List<Shape> orderdByVolume = shapes.stream()
                .filter(s -> s instanceof IVolumeMeasurable)
                .filter(v -> ((IVolumeMeasurable) v).getVolume() > 40)
                .collect(Collectors.toList());
		
		for (Shape shape : orderdByVolume) {
			System.out.println(shape);
		}	
		
		Comparator<IPerimeterMeasurable> comparatorByPerimeter = (
				IPerimeterMeasurable s1, IPerimeterMeasurable s2) -> {
			double diff = s1.getPerimeter() - s2.getPerimeter();
			if (diff < 0) {
				return -1;
			}

			if (diff > 0) {
				return 1;
			}

			return 0;
		};

		List<IPerimeterMeasurable> SortedShapes = Arrays.asList(shapes).stream()
				.filter(s -> s instanceof IPerimeterMeasurable)
				.map(s -> (IPerimeterMeasurable) s)
				.sorted(comparatorByPerimeter)
				.collect(Collectors.toList());
		
		System.out.println();
		for (IPerimeterMeasurable shape : SortedShapes) {
			System.out.println(shape);
		}
		
	}
}

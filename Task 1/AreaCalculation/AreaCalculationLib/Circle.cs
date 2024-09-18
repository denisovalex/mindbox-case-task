namespace AreaCalculationLib
{
	public class Circle : IShape
	{
		public readonly double Radius;
		
		public Circle(double radius) 
		{
			if (radius <= 0)
			{
				throw new ArgumentOutOfRangeException("Radius length must be positive.");
			}

			Radius = radius;
		}

		public double CalculateArea()
		{
			return Math.PI * Math.Pow(Radius, 2);
		}
	}
}

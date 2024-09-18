namespace AreaCalculationLib
{
	//	Возник вопрос к требованию "предусмотреть проверку на то, является ли треугольник прямоугольным":
	//	1) Мы хотим добавить к классу треугольника (где треугольник - это три стороны) дополнительтельную 
	//		функциональность определять тип треугольника?
	//	2) Или здесь делается акцент на подсчёте площади:
	//		2.1) предоставить возможность пользователю считать площадь только по двум катетам или по одной 
	//			стороне в случае равностороннего?
	//		2.2) углубиться в принцип разделения ответственностей и создать для подсчёта площадей фигур 
	//			(в том числе частных случаев фигур) отдельные классы?

	public class Triangle : IShape
	{
		public readonly double SideA;
		public readonly double SideB;
		public readonly double SideC;

		public Triangle(double sideA, double sideB, double sideC)
		{
			if (!IsPositiveSides(sideA, sideB, sideC))
			{
				throw new ArgumentOutOfRangeException("Sides must be positives.");
			}
			
			if (!IsValidTriangle(sideA, sideB, sideC))
			{
				throw new ArgumentException("A triangle with these sides does not exist.");
			}
			
			SideA = sideA;
			SideB = sideB;
			SideC = sideC;
		}

		public double CalculateArea()
		{
			var s = (SideA + SideB + SideC) / 2;
			return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
		}

		private bool IsPositiveSides(double sideA, double sideB, double sideC)
		{
			return sideA > 0 && sideB > 0 && sideC > 0;
		}

		private bool IsValidTriangle(double sideA, double sideB, double sideC)
		{
			return sideA + sideC > sideB && sideA + sideB > sideC && sideB + sideC > sideA;
		}
	}
}

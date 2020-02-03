[System.Serializable]
public class NutrientTracker
{
	public int minimum = 0;
	public int maximum = 100;
	public int current = 5;

	public Nutrient nutrientType;

	public NutrientTracker(int minimum, int maximum, int current, Nutrient nutrientType)
	{
		this.minimum = minimum;
		this.maximum = maximum;
		this.current = current;
		this.nutrientType = nutrientType;
	}

	public NutrientTracker(Nutrient nutrientType)
	{
		minimum = 0;
		maximum = 100;
		current = 5;
		this.nutrientType = nutrientType;
	}
}

public class IronFood : Food
{
	new private void Start()
	{
		base.Start();
		nutrient = NutrientDummyObjects.instance.iron;
	}

	public int ironRestored = 100;

	public override void Eat()
	{
		GameEvents.instance.EatFoodEvent(this);
	}
}
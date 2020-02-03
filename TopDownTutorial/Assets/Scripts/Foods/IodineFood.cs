public class IodineFood : Food
{
	new private void Start()
	{
		base.Start();
		nutrient = NutrientDummyObjects.instance.iodine;
	}

	public int iodineRestored = 100;

	public override void Eat()
	{
		GameEvents.instance.EatFoodEvent(this);
	}
}
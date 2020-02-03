using System.Collections.Generic;
using UnityEngine;

public class NutrientDummyObjects : MonoBehaviour
{
	#region Singleton
	public static NutrientDummyObjects instance;

	private void Awake()
	{
		instance = this;
	}
	#endregion

	public Iodine iodine;
	public Iron iron;

	public List<Nutrient> getAllTypes()
	{
		List<Nutrient> allTypes = new List<Nutrient>();
		allTypes.Add(iodine);
		allTypes.Add(iron);
		return allTypes;
	}
}

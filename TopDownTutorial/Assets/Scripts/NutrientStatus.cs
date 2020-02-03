using UnityEngine;
using System.Collections.Generic;

public class NutrientStatus : MonoBehaviour
{
	public List<NutrientTracker> nutrientTrackers = new List<NutrientTracker>();

	public List<StatusBar> statusBars = new List<StatusBar>();

	public Transform statusBarContainer;
	public GameObject nutrientBarPrefab;

	private void Start()
	{
		foreach (Nutrient nutrient in NutrientDummyObjects.instance.getAllTypes())
		{
			NutrientTracker tracker = new NutrientTracker(nutrient);
			nutrientTrackers.Add(tracker);

			GameObject obj = Instantiate(nutrientBarPrefab, statusBarContainer);
			StatusBar statusBar = obj.GetComponent<StatusBar>();
			statusBar.nutrientTracker = tracker;

			statusBars.Add(statusBar);
		}

		GameEvents.instance.OnEatFood += UpdateNutrientLevels;
	}

	private void UpdateNutrientLevels(Food food)
	{
		//We will probably want to replace this with simply going through all nutrients of all foods.
		//That will be relevant when all foods can have all nutrients.
		foreach (NutrientTracker nutrientTracker in nutrientTrackers)
		{
			//Repeat this structure for each nutrient
			if (food.nutrient is Iodine && nutrientTracker.nutrientType is Iodine)
			{
				nutrientTracker.current = nutrientTracker.maximum;
				GameEvents.instance.NutrientTrackersChangedEvent();
			}

			if (food.nutrient is Iron && nutrientTracker.nutrientType is Iron)
			{
				nutrientTracker.current = nutrientTracker.maximum;
				GameEvents.instance.NutrientTrackersChangedEvent();
			}
		}
	}
	//Right now all foods only have one nutrient that they fulfill
	//Potentially, all foods will have a value for each nutrient, so they can all have different stats

	private void OnDestroy()
	{
		GameEvents.instance.OnEatFood -= UpdateNutrientLevels;
	}
}

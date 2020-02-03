using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Nutrient : MonoBehaviour
{
	public Color color;
	new public string name = "New Nutrient";
	public string description = "A nutrient";
}

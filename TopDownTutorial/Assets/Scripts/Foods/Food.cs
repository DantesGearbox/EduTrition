using UnityEngine;

[ExecuteInEditMode]
public abstract class Food : MonoBehaviour
{
	private SpriteRenderer spriteRenderer;
	public Nutrient nutrient;
	public Sprite UISprite;
	public Sprite mapSprite;
	new public string name = "New food";
	public string description = "A food item";

	public abstract void Eat();

	protected void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
		spriteRenderer.color = nutrient.color;
		spriteRenderer.sprite = mapSprite;
	}

	private void Update()
	{
		//Updating properties in real time while in editor mode
		#if UNITY_EDITOR
		spriteRenderer.color = nutrient.color;
		spriteRenderer.sprite = mapSprite;
		#endif
	}
}

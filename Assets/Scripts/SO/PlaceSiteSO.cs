using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Sites/Place", fileName = "Place")]
public class PlaceSiteSO : ScriptableObject, ITemplate
{
	[SerializeField] private Sprite mainImage;

	[SerializeField] private string title;
	[SerializeField] private string location;
	[SerializeField, Range(0f, 5f)] private float raiting;
	[SerializeField] private float cost;

	[SerializeField] private List<Sprite> additingImages;

	[SerializeField, TextArea()] private string detail;
	[SerializeField, TextArea()] private string description;

	[SerializeField] private JustImageTemplate imageTemplate;

	public Sprite MainImage { get => mainImage; private set => mainImage = value; }
	public string Title { get => title; private set => title = value; }
	public string Location { get => location; private set => location = value; }
	public float Raiting { get => raiting; private set => raiting = value; }
	public List<Sprite> AdditingImages { get => additingImages; private set => additingImages = value; }
	public string Detail { get => detail; private set => detail = value; }
	public string Description { get => description; private set => description = value; }
	public float Cost { get => cost; set => cost = value; }
}

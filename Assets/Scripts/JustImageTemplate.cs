using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class JustImageTemplate : MonoBehaviour, ITemplateHolder
{
	[SerializeField] private Image image;
	[SerializeField] private TextMeshProUGUI mainText;
	[SerializeField] private TextMeshProUGUI subText;

	[SerializeField] private TextMeshProUGUI raiting;

	[SerializeField] private PlaceSO place;
	[SerializeField] private Button openPlaceButton;

	[SerializeField] private PlaceUI placeUITemplate;

	private void Awake()
	{
		openPlaceButton.onClick.AddListener(() =>
		{
			Canvas canvas = FindAnyObjectByType<Canvas>();
			PlaceUI newUITemplate = Instantiate(placeUITemplate, canvas.transform);
			newUITemplate.SetPlaceSO(place);
			newUITemplate.Show();
		});
	}

	public void UpdateVisual()
	{
		if (place != null)
		{
			image.sprite = place.MainImage;
			mainText.text = place.Title;
			subText.text = place.Detail;
			raiting.text = place.Raiting.ToString();
		}
	}

	public void SetTempate(ITemplate template)
	{
		place = template as PlaceSO;
	}
}

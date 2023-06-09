using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class JustImageTemplate : MonoBehaviour, ITemplateHolder
{
	[SerializeField] private Image image;
	[SerializeField] private TextMeshProUGUI mainText;
	[SerializeField] private TextMeshProUGUI subText;

	[SerializeField] private TextMeshProUGUI raiting;

	[SerializeField] private PlaceSiteSO place;

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
		place = template as PlaceSiteSO;
	}
}

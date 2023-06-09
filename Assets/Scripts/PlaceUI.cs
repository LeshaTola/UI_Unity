using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlaceUI : MonoBehaviour
{
	[Header("UI params")]
	[SerializeField] private Image mainImage;
	[SerializeField] private TextMeshProUGUI title;
	[SerializeField] private TextMeshProUGUI location;
	[SerializeField] private TextMeshProUGUI raiting;
	[SerializeField] private TextMeshProUGUI detail;
	[SerializeField] private TextMeshProUGUI description;
	[SerializeField] private TextMeshProUGUI costText;


	[Header("AdditingImages params")]
	[SerializeField] private GameObject additingImagesContainerDeleter;
	[SerializeField] private GameObject additingImagesContainer;
	[SerializeField] private GameObject additingImagesTemplate;

	[Header("Place")]
	[SerializeField] private PlaceSiteSO place;

	private void Awake()
	{
		UpdateUI();
	}

	public void UpdateUI()
	{
		mainImage.sprite = place.MainImage;
		title.text = place.Title;
		location.text = place.Location;
		raiting.text = place.Raiting.ToString();
		detail.text = place.Detail;
		description.text = place.Description;
		costText.text = "$" + place.Cost + "/night";
		UpdateAdditingImageContainer();
	}

	private void UpdateAdditingImageContainer()
	{
		if (additingImagesContainer != null)
		{
			if (place.AdditingImages.Count == 0)
			{
				Destroy(additingImagesContainerDeleter);
				return;
			}
			foreach (Transform child in additingImagesContainer.transform)
			{
				Destroy(child.gameObject);
			}
			foreach (Sprite image in place.AdditingImages)
			{
				GameObject newTemplate = Instantiate(additingImagesTemplate, additingImagesContainer.transform);
				newTemplate.GetComponent<UITemplate>().UpdateVisual(image, " ", " ");
			}
		}
	}
}

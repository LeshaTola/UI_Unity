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
	[SerializeField] private Button ExitButton;


	[Header("AdditingImages params")]
	[SerializeField] private ManyImagesTemplate manyImagesTemplate;

	[Header("Place")]
	[SerializeField] private PlaceSO place;

	private void Awake()
	{
		UpdateUI();
		ExitButton.onClick.AddListener(() =>
		{
			//Hide();
			Destroy(gameObject);
		});
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
		manyImagesTemplate.SetTempate(place.AdditionalInformation);
		manyImagesTemplate.UpdateVisual();
	}


	public void Show()
	{
		gameObject.SetActive(true);
	}

	public void Hide()
	{
		gameObject.SetActive(false);
	}

	public void SetPlaceSO(PlaceSO placeSO)
	{
		place = placeSO;
		UpdateUI();
	}
}

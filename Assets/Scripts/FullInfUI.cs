using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FullInfUI : MonoBehaviour
{
	[Header("UI params")]
	[SerializeField] private Image mainImage;
	[SerializeField] private GameObject modelContainer;
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
	[SerializeField] private FullInfSO place;

	private void Awake()
	{
		MainSite mainScreen;
		mainScreen = FindObjectOfType<MainSite>();
		mainScreen.gameObject.SetActive(false);

		ExitButton.onClick.AddListener(() =>
		{
			mainScreen.gameObject.SetActive(true);
			Destroy(gameObject);
		});

		UpdateUI();
	}

	public void UpdateUI()
	{
		mainImage.sprite = place.MainImage;
		if (place.Model != null)
		{
			Instantiate(place.Model, modelContainer.transform);
		}
		else
		{
			Destroy(modelContainer.gameObject);
		}

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

	public void SetPlaceSO(FullInfSO placeSO)
	{
		place = placeSO;
		UpdateUI();
	}
}

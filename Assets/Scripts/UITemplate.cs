using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UITemplate : MonoBehaviour
{
	[SerializeField] private Image image;
	[SerializeField] private TextMeshProUGUI mainText;
	[SerializeField] private TextMeshProUGUI subText;

	public void UpdateVisual(Sprite sprite, string mainText, string subText)
	{
		image.sprite = sprite;
		this.mainText.text = mainText;
		this.subText.text = subText;
	}

	public void UpdateVisual(TemplateSO manyImages)
	{
		image.sprite = manyImages.Image;
		mainText.text = manyImages.MainText;
		subText.text = manyImages.SubText;
	}
}

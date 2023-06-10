using UnityEngine;

public class ManyImagesTemplate : MonoBehaviour, ITemplateHolder
{
	[Header("AdditingImages params")]
	[SerializeField] private GameObject templatesContainer;
	[SerializeField] private UITemplate template;

	[SerializeField] private ManyImagesSO manyImagesSO;

	public void UpdateVisual()
	{
		if (templatesContainer != null)
		{
			if (manyImagesSO.TemplatesSOList.Count == 0)
			{
				gameObject.SetActive(false);
				return;
			}
			else
			{
				gameObject.SetActive(true);
			}

			foreach (Transform child in templatesContainer.transform)
			{
				Destroy(child.gameObject);
			}

			foreach (TemplateSO miniTemplate in manyImagesSO.TemplatesSOList)
			{
				UITemplate newTemplate = Instantiate(template, templatesContainer.transform);
				newTemplate.UpdateVisual(miniTemplate.Image, miniTemplate.MainText, miniTemplate.SubText);
			}
		}
	}

	public void SetTempate(ITemplate template)
	{
		manyImagesSO = template as ManyImagesSO;
	}
}

using UnityEngine;

public class ManyImagesTemplate : MonoBehaviour, ITemplateHolder
{
	[Header("AdditingImages params")]
	[SerializeField] private GameObject templatesContainer;
	[SerializeField] private UITemplate template;

	[SerializeField] private ManyImagesTemplateSO manyImagesSO;

	public void UpdateVisual()
	{
		if (templatesContainer != null)
		{
			if (manyImagesSO.Templates.Count == 0)
			{
				Destroy(gameObject);
				return;
			}

			foreach (Transform child in templatesContainer.transform)
			{
				Destroy(child.gameObject);
			}

			foreach (TemplateSO miniTemplate in manyImagesSO.Templates)
			{
				UITemplate newTemplate = Instantiate(template, templatesContainer.transform);
				newTemplate.UpdateVisual(miniTemplate.Image, miniTemplate.MainText, miniTemplate.SubText);
			}
		}
	}

	public void SetTempate(ITemplate template)
	{
		manyImagesSO = template as ManyImagesTemplateSO;
	}
}

using System.Collections.Generic;
using UnityEngine;

public class MainSite : MonoBehaviour
{
	[SerializeField] private List<GameObject> scrolList;
	[SerializeField] private List<ScriptableObject> scrolListSO;

	[SerializeField] private Transform container;

	private void Awake()
	{
		UpdateVisual();
	}

	private void UpdateVisual()
	{
		foreach (Transform child in container.transform)
		{
			Destroy(child.gameObject);
		}

		for (int i = 0; i < scrolList.Count; i++)
		{
			ITemplateHolder templateHolder = scrolList[i].GetComponent<ITemplateHolder>();
			templateHolder.SetTempate(scrolListSO[i] as ITemplate);
			GameObject newTemplateHolder = Instantiate(scrolList[i], container);
			newTemplateHolder.GetComponent<ITemplateHolder>().UpdateVisual();
		}
	}
}

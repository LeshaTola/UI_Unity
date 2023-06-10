using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Sites/ManyPlace", fileName = "PlaceM")]
public class ManyImagesSO : ScriptableObject, ITemplate
{
	[SerializeField] private List<TemplateSO> templatesSOList;

	[SerializeField] private ManyImagesTemplate manyImagesTemplate;

	public List<TemplateSO> TemplatesSOList { get => templatesSOList; private set => templatesSOList = value; }
	public ManyImagesTemplate ManyImagesTemplate { get => manyImagesTemplate; private set => manyImagesTemplate = value; }
}

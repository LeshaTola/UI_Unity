using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Sites/ManyPlace", fileName = "PlaceM")]
public class ManyImagesTemplateSO : ScriptableObject, ITemplate
{
	[SerializeField] private List<TemplateSO> templates;

	[SerializeField] private ManyImagesTemplate manyImagesTemplate;

	public List<TemplateSO> Templates { get => templates; private set => templates = value; }
	public ManyImagesTemplate ManyImagesTemplate { get => manyImagesTemplate; private set => manyImagesTemplate = value; }
}

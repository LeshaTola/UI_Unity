using UnityEngine;

public class ModelRotation : MonoBehaviour
{
	[SerializeField] private float rotationSpeed;
	private void Update()
	{
		transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
	}
}

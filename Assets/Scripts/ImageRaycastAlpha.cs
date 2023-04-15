using UnityEngine;
using UnityEngine.UI;

public class ImageRaycastAlpha : MonoBehaviour
{
	private void Start()
	{
		GetComponent<Image>().alphaHitTestMinimumThreshold = 1f;
	}
}

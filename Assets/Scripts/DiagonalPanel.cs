using UnityEngine;

[ExecuteInEditMode]
public class DiagonalPanel : MonoBehaviour
{
	public RectTransform rectTransform;

	public DiagonalAxis axis;

	public float startX;

	public float startY;

	public float endX;

	public float endY;

	private void Start()
	{
	}

	private void Update()
	{
		if (base.enabled && !(rectTransform == null))
		{
			switch (axis)
			{
			case DiagonalAxis.Horizontal:
			{
				float num = (rectTransform.anchoredPosition.y - startY) / (endY - startY);
				rectTransform.anchoredPosition = new Vector2((endX - startX) * num + startX, rectTransform.anchoredPosition.y);
				break;
			}
			case DiagonalAxis.Vertical:
			{
				float num = (rectTransform.anchoredPosition.x - startX) / (endX - startX);
				rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, (endY - startY) * num + startY);
				break;
			}
			}
		}
	}
}

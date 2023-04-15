using System.Collections.Generic;
using UnityEngine;

public class MovableIcon : MonoBehaviour
{
	public RectTransform iconPrefab;

	public float translationSpeed;

	public float rotationSpeed;

	public float space;

	public int iconRow;

	private Menu menu;

	private List<RectTransform> collection;

	private List<float> angles;

	private List<int> timers;

	private Vector2 iconSize;

	private Vector2 halfSize;

	private void Start()
	{
		iconSize = iconPrefab.sizeDelta;
		collection = new List<RectTransform>();
		angles = new List<float>();
		timers = new List<int>();
		menu = Menu.instance;
		halfSize = iconSize / 2f;
		for (int i = 0; i < iconRow; i++)
		{
			RectTransform rectTransform = UnityEngine.Object.Instantiate(iconPrefab);
			rectTransform.SetParent(base.transform, worldPositionStays: false);
			rectTransform.anchoredPosition = new Vector2((float)i * (iconSize.x + space) + halfSize.x, 0f - halfSize.y);
			angles.Add(UnityEngine.Random.Range(0f, 360f));
			timers.Add(UnityEngine.Random.Range(0, 100));
			collection.Add(rectTransform);
		}
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
		for (int i = 0; i < collection.Count; i++)
		{
			RectTransform rectTransform = collection[i];
			if (rectTransform.anchoredPosition.x - halfSize.x > 1000f)
			{
				rectTransform.anchoredPosition = new Vector2(halfSize.x, 0f - halfSize.y);
			}
			else if (rectTransform.anchoredPosition.x + halfSize.x < 0f)
			{
				rectTransform.anchoredPosition = new Vector2(1000f - halfSize.x, 0f - halfSize.y);
			}
			rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x + translationSpeed, 0f - halfSize.y);
			if (timers[i] <= 0)
			{
				angles[i] = UnityEngine.Random.Range(0f, 360f);
				timers[i] = UnityEngine.Random.Range(0, 100);
			}
			else
			{
				List<int> list = timers;
				int index = i;
				list[index]--;
			}
			rectTransform.localRotation = Quaternion.Euler(Vector3.Lerp(rectTransform.localEulerAngles, new Vector3(0f, 0f, angles[i]), rotationSpeed));
		}
	}
}

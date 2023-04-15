using System.Collections.Generic;
using UnityEngine;

public class Picker : MonoBehaviour
{
	public List<Vector2> slotPositions;

	public List<Vector2> buttonPositions;

	private RectTransform rectTransform;

	private Animator animator;

	private RectTransform slotRect;

	private void Awake()
	{
		rectTransform = GetComponent<RectTransform>();
		animator = GetComponent<Animator>();
		slotRect = rectTransform.GetChild(0).GetComponent<RectTransform>();
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Pick(int id)
	{
		int num = 0;
		for (int i = 0; i < 6; i++)
		{
			if (GameManager.instance.vehicles[i] == id)
			{
				num++;
			}
		}
		rectTransform.anchoredPosition = buttonPositions[id];
		slotRect.anchoredPosition = slotPositions[num];
		animator.SetTrigger("Fill");
	}

	public void Drop()
	{
		animator.SetTrigger("Fill");
	}

	public void RefreshPosition(int id)
	{
		int num = 0;
		for (int i = 0; i < 6; i++)
		{
			if (GameManager.instance.vehicles[i] == id)
			{
				num++;
			}
		}
		slotRect.anchoredPosition = slotPositions[num];
	}

	private void Refresh()
	{
		Menu.instance.RefreshSlots();
	}
}

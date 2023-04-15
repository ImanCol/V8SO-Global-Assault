using TMPro;
using UnityEngine;

public class Arrow : MonoBehaviour
{
	public TMP_Dropdown dropdown;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Next()
	{
		int num = dropdown.value + 1;
		if (num >= dropdown.options.Count)
		{
			num = 0;
		}
		dropdown.value = num;
	}

	public void Previous()
	{
		int num = dropdown.value - 1;
		if (num < 0)
		{
			num = dropdown.options.Count - 1;
		}
		dropdown.value = num;
	}
}

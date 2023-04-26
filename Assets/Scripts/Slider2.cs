using TMPro;
using UnityEngine;

public class Slider2 : MonoBehaviour
{
	public RectTransform fill;

	public TextMeshProUGUI number;

	public int value;

	public float endFill;

	public int maxNumber;

	public bool maxText;

	public int rate;

	private int currentNum;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
		if (Mathf.Abs(value - currentNum) > rate)
		{
			if (currentNum < value)
			{
				currentNum += rate;
			}
			else if (currentNum > value)
			{
				currentNum -= rate;
			}
		}
		else
		{
			currentNum = value;
		}
		float x = (float)currentNum / (float)maxNumber * endFill;
		float y = fill.sizeDelta.y;
		fill.sizeDelta = new Vector2(x, y);
		if (number != null)
		{
			if (maxText && currentNum == maxNumber)
			{
				number.text = "MAX";
			}
			else
			{
				number.text = currentNum.ToString();
			}
		}
	}

	private int IntLerp(int a, int b, float t)
	{
		if (t > 0.9999f)
		{
			return b;
		}
		return a + (int)(((float)b - (float)a) * t);
	}
}

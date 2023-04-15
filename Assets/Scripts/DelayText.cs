using TMPro;
using UnityEngine;

public class DelayText : MonoBehaviour
{
	private string text;

	public TextMeshProUGUI textUGUI;

	public void SetText(string s)
	{
		text = s;
	}

	private void ApplyText()
	{
		textUGUI.text = text;
	}
}

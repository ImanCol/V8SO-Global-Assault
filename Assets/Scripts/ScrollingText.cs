using System.Collections;
using TMPro;
using UnityEngine;

public class ScrollingText : MonoBehaviour
{
	public TextMeshProUGUI textMeshProComponent;

	public float scrollSpeed = 10f;

	private TextMeshProUGUI m_cloneTextObject;

	private Coroutine coroutine;

	private RectTransform m_textRectTransform;

	private string sourceText;

	private string tempText;

	private void Awake()
	{
		m_textRectTransform = textMeshProComponent.GetComponent<RectTransform>();
		m_cloneTextObject = UnityEngine.Object.Instantiate(textMeshProComponent);
		RectTransform component = m_cloneTextObject.GetComponent<RectTransform>();
		component.SetParent(m_textRectTransform);
		component.anchorMin = new Vector2(1f, 0.5f);
		component.anchorMax = new Vector2(1f, 0.5f);
		component.pivot = new Vector2(0f, 0.5f);
		component.anchoredPosition3D = new Vector3(0f, 0f, 0f);
		component.localScale = new Vector3(1f, 1f, 1f);
	}

	private void OnEnable()
	{
		coroutine = StartCoroutine("Scroll");
	}

	private void OnDisable()
	{
		StopCoroutine(coroutine);
	}

	private IEnumerator Scroll()
	{
		float width = m_textRectTransform.sizeDelta.x;
		Vector3 startPosition = m_textRectTransform.anchoredPosition;
		float scrollPosition = 0f;
		while (true)
		{
			if (textMeshProComponent.havePropertiesChanged)
			{
				width = m_textRectTransform.sizeDelta.x;
				m_cloneTextObject.text = textMeshProComponent.text;
			}
			m_textRectTransform.anchoredPosition = new Vector3((0f - scrollPosition) % width, startPosition.y, startPosition.z);
			scrollPosition += scrollSpeed * 20f * Time.deltaTime;
			yield return null;
		}
	}
}

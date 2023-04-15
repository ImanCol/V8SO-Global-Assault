using TMPro;
using UnityEngine;

public class ScrollViewLoop : MonoBehaviour
{
	public Animator animator;

	public Animator arrows;

	public TextMeshProUGUI gameModeText;

	public TextMeshProUGUI gameModeDesc;

	private int index;

	private void Start()
	{
	}

	private void Update()
	{
		if (Input.GetButtonDown("P1_RIGHT"))
		{
			animator.SetTrigger("Right");
			arrows.SetTrigger("Right");
		}
		else if (Input.GetButtonDown("P1_LEFT"))
		{
			animator.SetTrigger("Left");
			arrows.SetTrigger("Left");
		}
	}

	private void UpdateText(int i)
	{
		switch (i)
		{
		case 0:
			gameModeText.text = "Arcade";
			gameModeDesc.text = "One player versus AI. Pick your ride,\nyour opponents, your arena, and pick a fight.";
			break;
		case 1:
			gameModeText.text = "Quest";
			gameModeDesc.text = "Story mode. Play through the plot of Vigilante 8\nwith your character of choice. Keep an eye on the gas.";
			break;
		case 2:
			gameModeText.text = "Survival";
			gameModeDesc.text = "One Player versus AI. Fight randomized opponents\nfor as long as you can. Boogie down til you drop.";
			break;
		case 3:
			gameModeText.text = "Multiplayer";
			gameModeDesc.text = "Player versus player, free-for-all. Show 'em who's bad.";
			break;
		case 4:
			gameModeText.text = "Records";
			gameModeDesc.text = "View your current tally.";
			break;
		case 5:
			gameModeText.text = "Options";
			gameModeDesc.text = "Check under the hood.";
			break;
		}
	}

	private void UpdateIndex(int i)
	{
		index = i;
		animator.SetInteger("Index", index);
	}
}

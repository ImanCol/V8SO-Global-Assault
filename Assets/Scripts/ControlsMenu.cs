using UnityEngine;
using UnityEngine.UI;
public class ControlsMenu : Menu
{
    public Dropdown PlayersDropdown;

    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetButtonDown("P1_DOWN"))
        {
            if (PlayersDropdown.value > 0)
            {
                PlayersDropdown.value -= 1;
                Debug.Log("PRESS DOWN");
            }
        }
        if (Input.GetButtonDown("P1_UP"))
        {
            if (PlayersDropdown.value < 17)
            {
                PlayersDropdown.value += 1;
                Debug.Log("PRESS UP");
            }
        }
    }
}
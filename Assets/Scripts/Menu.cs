using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
	public static Menu instance;

	public List<Picker> pickers;

	public List<AudioClip> sounds;

	public List<Material> reflections;

	[HideInInspector]
	public int tick;

	private int pick;

	private static Vector3Int DAT_6DC = new Vector3Int(0, 0, -4096);

	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
	}

	private void Start()
	{
		GameManager.instance.FUN_2DE84(0, DAT_6DC, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue));
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
		tick++;
	}

	public void PickVehicle(int id)
	{
		for (int i = 0; i < 6; i++)
		{
			if (GameManager.instance.vehicles[i] == id)
			{
				return;
			}
		}
		pickers[pick].Pick(id);
		int num = (pick >= 1) ? (pick + 1) : 0;
		GameManager.instance.vehicles[num] = (byte)id;
		pick++;
	}

	public void DropVehicle()
	{
		pick--;
		pickers[pick].Drop();
		int num = (pick >= 1) ? (pick + 1) : 0;
		GameManager.instance.vehicles[num] = byte.MaxValue;
	}

	public void RefreshSlots()
	{
		for (int i = 0; i < pick; i++)
		{
			int num = i;
			if (i >= 1)
			{
				num = i + 1;
			}
			int id = GameManager.instance.vehicles[num];
			pickers[i].RefreshPosition(id);
		}
	}
}

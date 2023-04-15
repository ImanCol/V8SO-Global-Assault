using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatsPanel : MonoBehaviour
{
	public _STATS_TYPE state;

	public Camera camera;

	public Image panel;

	public Image background;

	public Image accelBackground;

	public Image speedBackground;

	public Image armorBackground;

	public Image avoidanceBackground;

	public Image accelPlusBackground;

	public Image speedPlusBackground;

	public Image armorPlusBackground;

	public Image avoidancePlusBackground;

	public TextMeshProUGUI accelText;

	public TextMeshProUGUI speedText;

	public TextMeshProUGUI armorText;

	public TextMeshProUGUI avoidanceText;

	public TextMeshProUGUI accelPlusText;

	public TextMeshProUGUI speedPlusText;

	public TextMeshProUGUI armorPlusText;

	public TextMeshProUGUI avoidancePlusText;

	public List<Image> signs;

	public TextMeshProUGUI desc;

	public List<Image> poses;

	public List<Sprite> panelSprites;

	public List<Sprite> backgroundSprites;

	public List<Sprite> sliderSprites;

	public List<Sprite> sliderPlusSprites;

	public List<Sprite> signSprites;

	public List<Color> textColors;

	public List<Vector3Int> cameraPositions;

	public Slider2 accel;

	public Slider2 speed;

	public Slider2 armor;

	public Slider2 avoidance;

	public Slider2 accelPlus;

	public Slider2 speedPlus;

	public Slider2 armorPlus;

	public Slider2 avoidancePlus;

	public List<Animator> questAnimators;

	private Vehicle vehicle;

	private int cursor;

	private static ushort[] salvagePartOffsets = new ushort[18]
	{
		1,
		1,
		1,
		1,
		1,
		1,
		1,
		1,
		1,
		1,
		1,
		1,
		1,
		1,
		1,
		1,
		1,
		1
	};

	private static Vector3Int DAT_15DE8 = new Vector3Int(-170, 0, 0);

	private void Start()
	{
		SpawnVehicle(0);
	}

	private void Update()
	{
		if (Input.GetButtonDown("P1_RIGHT"))
		{
			poses[cursor].gameObject.SetActive(value: false);
			if (cursor < 17)
			{
				cursor++;
				if (state == _STATS_TYPE.Quest)
				{
					switch (cursor)
					{
					case 5:
						cursor = 6;
						break;
					case 11:
						cursor = 12;
						break;
					case 17:
						cursor = 0;
						break;
					}
				}
			}
			else
			{
				cursor = 0;
			}
			SpawnVehicle(cursor);
			poses[cursor].gameObject.SetActive(value: true);
		}
		else if (Input.GetButtonDown("P1_LEFT"))
		{
			poses[cursor].gameObject.SetActive(value: false);
			if (cursor > 0)
			{
				cursor--;
				if (state == _STATS_TYPE.Quest)
				{
					switch (cursor)
					{
					case 5:
						cursor = 4;
						break;
					case 11:
						cursor = 10;
						break;
					}
				}
			}
			else
			{
				cursor = 17;
				if (state == _STATS_TYPE.Quest)
				{
					cursor = 16;
				}
			}
			SpawnVehicle(cursor);
			poses[cursor].gameObject.SetActive(value: true);
		}
		else if (Input.GetButtonDown("P1_CROSS") && state == _STATS_TYPE.Quest)
		{
			questAnimators[cursor].gameObject.SetActive(value: true);
			questAnimators[cursor].SetTrigger("Next");
		}
	}

	private void FixedUpdate()
	{
		if (vehicle == null)
		{
			return;
		}
		vehicle.vTransform.rotation = Utilities.RotMatrixY(16L, vehicle.vTransform.rotation);
		vehicle.FUN_41AE8();
		vehicle.physics1.Z = 0;
		vehicle.physics1.X = 0;
		GameManager.instance.FUN_2FEE8(vehicle, (ushort)Menu.instance.tick);
		if ((vehicle.flags & 0x12000000) == 268435456)
		{
			int param = 3;
			if (5120 < vehicle.DAT_A6)
			{
				param = 2;
				if (vehicle.DAT_A6 < 8193)
				{
					param = 1;
				}
			}
			GameManager.instance.FUN_1E28C(1, Menu.instance.sounds, param);
			vehicle.flags |= 33554432u;
		}
		vehicle.vTransform.position.z = 67108864;
		vehicle.vTransform.position.x = 67108864;
		GameManager.instance.FUN_2DE18();
		GameManager.instance.FUN_2D9E0(vehicle);
	}

	public void SetState(int value)
	{
		state = (_STATS_TYPE)value;
	}

	public void SpawnVehicle(int id)
	{
		if (this.vehicle != null)
		{
			GameManager.instance.FUN_308C4(this.vehicle);
		}
		switch (id)
		{
		case 0:
			desc.text = "Wonderwagon – a white and pink Baja buggy boasting\nhigh acceleration and avoidance, but low armor.";
			goto IL_00db;
		case 1:
			desc.text = "Thunderbolt – an ultramarine pony car with golden trims,\nboasting high speed and acceleration, but low avoidance.";
			goto IL_00db;
		case 2:
			desc.text = "Dakota Stunt Cycle – a red, white and blue stunt motorcycle\nwith a sidecar attachment, boasting high top speed\nand avoidance, but low armor.";
			goto IL_00db;
		case 3:
			desc.text = "Samson Tow Truck – an orange tow truck with white trims,\nboasting high acceleration and average armor,\nbut low tracking avoidance.";
			goto IL_00db;
		case 4:
			desc.text = "Livingston Truck – a yellow and brown tandem\naxle conventional truck boasting high armor,\nbut low tracking avoidance.";
			goto IL_00db;
		case 5:
			desc.text = "Xanadu RV – a cream-colored motorhome boasting\nhigh armor, but otherwise mediocre stats.";
			goto IL_00db;
		case 6:
			desc.text = "Palomino XIII – a golden concept car from the future,\nboasting high acceleration and top speed,\nbut low tracking avoidance.";
			goto IL_0376;
		case 7:
			desc.text = "El Guerrero – a rusted tan utility vehicle boasting\nhigh acceleration, but low tracking avoidance.";
			goto IL_0376;
		case 8:
			desc.text = "Blue Burro Bus – a white and metal grey tandem-axle\nprison bus, boasting high armor but low top speed.";
			goto IL_0376;
		case 9:
			desc.text = "Excelsior Stretch – a white limousine boasting\naverage balanced stats, but low avoidance.";
			goto IL_0376;
		case 10:
			desc.text = "Tsunami – a futuristic red motorcycle boasting\nhigh top speed and acceleration, but low armor.";
			goto IL_0376;
		case 11:
			desc.text = "Marathon – a blue and yellow subcompact car boasting\nhigh tracking avoidance, but low armor.";
			goto IL_0376;
		case 12:
			desc.text = "Moon Trekker – a stolen white and orange moon rover\nboasting high acceleration and tracking avoidance,\nbut low top speed.";
			goto IL_0611;
		case 13:
			desc.text = "Grubb Dual Loader – a rusted brown waste collection truck\nboasting high armor, but low top speed and tracking\navoidance.";
			goto IL_0611;
		case 14:
			desc.text = "Chrono Stinger – a purple sports car boasting\nhigh acceleration and top speed, but low armor.";
			goto IL_0611;
		case 15:
			desc.text = "Vertigo – a silver concept car boasting high speed\nand acceleration, but low armor.";
			goto IL_0611;
		case 16:
			desc.text = "Goliath Halftrack – a tan open-top armored personnel carrier\nboasting high acceleration and armor, but low top speed\nand avoidance.";
			goto IL_0611;
		case 17:
			{
				desc.text = "Wapiti 4WD – a brown SUV boasting high acceleration.";
				goto IL_0611;
			}
			IL_0611:
			panel.sprite = panelSprites[2];
			background.sprite = backgroundSprites[2];
			accelBackground.sprite = sliderSprites[2];
			speedBackground.sprite = sliderSprites[2];
			armorBackground.sprite = sliderSprites[2];
			avoidanceBackground.sprite = sliderSprites[2];
			accelPlusBackground.sprite = sliderPlusSprites[2];
			speedPlusBackground.sprite = sliderPlusSprites[2];
			armorPlusBackground.sprite = sliderPlusSprites[2];
			avoidancePlusBackground.sprite = sliderPlusSprites[2];
			signs[0].sprite = signSprites[2];
			signs[1].sprite = signSprites[2];
			signs[2].sprite = signSprites[2];
			signs[3].sprite = signSprites[2];
			accelText.color = textColors[2];
			speedText.color = textColors[2];
			armorText.color = textColors[2];
			avoidanceText.color = textColors[2];
			accelPlusText.color = textColors[2];
			speedPlusText.color = textColors[2];
			armorPlusText.color = textColors[2];
			avoidancePlusText.color = textColors[2];
			LevelManager.instance.DAT_E48 = Menu.instance.reflections[2];
			break;
			IL_0376:
			panel.sprite = panelSprites[1];
			background.sprite = backgroundSprites[1];
			accelBackground.sprite = sliderSprites[1];
			speedBackground.sprite = sliderSprites[1];
			armorBackground.sprite = sliderSprites[1];
			avoidanceBackground.sprite = sliderSprites[1];
			accelPlusBackground.sprite = sliderPlusSprites[1];
			speedPlusBackground.sprite = sliderPlusSprites[1];
			armorPlusBackground.sprite = sliderPlusSprites[1];
			avoidancePlusBackground.sprite = sliderPlusSprites[1];
			signs[0].sprite = signSprites[1];
			signs[1].sprite = signSprites[1];
			signs[2].sprite = signSprites[1];
			signs[3].sprite = signSprites[1];
			accelText.color = textColors[1];
			speedText.color = textColors[1];
			armorText.color = textColors[1];
			avoidanceText.color = textColors[1];
			accelPlusText.color = textColors[1];
			speedPlusText.color = textColors[1];
			armorPlusText.color = textColors[1];
			avoidancePlusText.color = textColors[1];
			LevelManager.instance.DAT_E48 = Menu.instance.reflections[1];
			break;
			IL_00db:
			panel.sprite = panelSprites[0];
			background.sprite = backgroundSprites[0];
			accelBackground.sprite = sliderSprites[0];
			speedBackground.sprite = sliderSprites[0];
			armorBackground.sprite = sliderSprites[0];
			avoidanceBackground.sprite = sliderSprites[0];
			accelPlusBackground.sprite = sliderPlusSprites[0];
			speedPlusBackground.sprite = sliderPlusSprites[0];
			armorPlusBackground.sprite = sliderPlusSprites[0];
			avoidancePlusBackground.sprite = sliderPlusSprites[0];
			signs[0].sprite = signSprites[0];
			signs[1].sprite = signSprites[0];
			signs[2].sprite = signSprites[0];
			signs[3].sprite = signSprites[0];
			accelText.color = textColors[0];
			speedText.color = textColors[0];
			armorText.color = textColors[0];
			avoidanceText.color = textColors[0];
			accelPlusText.color = textColors[0];
			speedPlusText.color = textColors[0];
			armorPlusText.color = textColors[0];
			avoidancePlusText.color = textColors[0];
			LevelManager.instance.DAT_E48 = Menu.instance.reflections[0];
			break;
		}
		camera.transform.position = cameraPositions[id];
		accel.value = GameManager.vehicleConfigs[id].DAT_2C[0] * 2;
		speed.value = GameManager.vehicleConfigs[id].DAT_2C[1] * 2;
		armor.value = GameManager.vehicleConfigs[id].DAT_2C[2] * 2;
		avoidance.value = GameManager.vehicleConfigs[id].DAT_2C[3] * 2;
		accelPlus.value = GameManager.instance.vehicleStats[id].accel;
		speedPlus.value = GameManager.instance.vehicleStats[id].speed;
		armorPlus.value = GameManager.instance.vehicleStats[id].armor;
		avoidancePlus.value = GameManager.instance.vehicleStats[id].avoidance;
		ushort param = (ushort)(GameManager.instance.FUN_36558(0, id) ? salvagePartOffsets[id] : 0);
		Vehicle vehicle = LevelManager.instance.xobfList[id].FUN_3C464(param, GameManager.vehicleConfigs[id], typeof(Vehicle));
		vehicle.flags |= 8u;
		GameObject gameObject = new GameObject();
		VigMesh param2 = LevelManager.instance.xobfList[18].FUN_2CB74(gameObject, 56u, init: true);
		vehicle.FUN_4C7E0(param2, gameObject);
		vehicle.screen.x = 67108864;
		vehicle.screen.y = 3078144;
		vehicle.screen.z = 67108864;
		vehicle.ApplyTransformation();
		vehicle.FUN_2D1DC();
		vehicle.FUN_3C9C4(0);
		FUN_536C(vehicle, 512);
		GameManager.instance.FUN_1E28C(1, Menu.instance.sounds, 4);
		this.vehicle = vehicle;
	}

	private void FUN_536C(Vehicle param1, int param2)
	{
		int dAT_E = param1.DAT_E4;
		int num = param1.vCollider.reader.ReadInt32(8);
		VigTransform vigTransform = default(VigTransform);
		vigTransform.rotation = Utilities.RotMatrixYXZ_gte(DAT_15DE8);
		vigTransform.position = default(Vector3Int);
		vigTransform.position.x = 67108864;
		int num2 = vigTransform.rotation.V12 * param1.DAT_58;
		if (num2 < 0)
		{
			num2 += 1023;
		}
		vigTransform.position.y = (num - dAT_E) / 2 - ((num2 >> 10) - 3143680);
		num = vigTransform.rotation.V22 * param1.DAT_58;
		if (num < 0)
		{
			num += 1023;
		}
		vigTransform.position.z = 67108864 - (num >> 10);
		vigTransform.padding = 0;
		GameManager.instance.FUN_2E0E8(vigTransform, param2);
	}
}

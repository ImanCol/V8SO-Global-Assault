using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainBoxcar : TrainEngine
{
    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    public override uint OnCollision(HitDetection hit)
    {
        if (base.FUN_32CF0(hit))
		{
			int num = 0;
			Vector3Int vector3Int = default(Vector3Int);
			do
			{
				num++;
				int num2 = (int)GameManager.FUN_2AC5C();
				vector3Int.x = (num2 * 3051 >> 15) - 1525;
				vector3Int.y = -4577;
				num2 = (int)GameManager.FUN_2AC5C();
				vector3Int.z = (num2 * 3051 >> 15) - 1525;
				LevelManager.instance.FUN_4AAC0(4261412864U, this.screen, vector3Int);
				string text = "Debug1: ";
				Vector3Int vector3Int2 = vector3Int;
				Debug.Log(text + vector3Int2.ToString());
				string text2 = "Debug2: ";
				vector3Int2 = this.screen;
				Debug.Log(text2 + vector3Int2.ToString());
				vector3Int.x = (num2 * 3051 >> 15) - 1525;
				vector3Int.y = -4577;
				num2 = (int)GameManager.FUN_2AC5C();
				vector3Int.z = (num2 * 3051 >> 15) - 1525;
				LevelManager.instance.FUN_4AAC0(4261412864U, this.screen, vector3Int);
				vector3Int.x = (num2 * 3051 >> 15) - 1525;
				vector3Int.y = -4577;
				num2 = (int)GameManager.FUN_2AC5C();
				vector3Int.z = (num2 * 3051 >> 15) - 1525;
				LevelManager.instance.FUN_4AAC0(4261412864U, this.screen, vector3Int);
				vector3Int.x = (num2 * 3051 >> 15) - 1525;
				vector3Int.y = -4577;
				num2 = (int)GameManager.FUN_2AC5C();
				vector3Int.z = (num2 * 3051 >> 15) - 1525;
				LevelManager.instance.FUN_4AAC0(4261412864U, this.screen, vector3Int);
			}
			while (num < 6);
		}
        return 0;
    }

    //FUN_4318 (STEELMIL.DLL)
    public override uint UpdateW(int arg1, int arg2)
    {
        uint uVar1;

        switch (arg1)
        {
            case 0:
                FUN_3AD0();
                uVar1 = 0;
                break;
            case 1:
                FUN_3754();
                uVar1 = 0;
                break;
            case 2:
                FUN_4DC94();
                uVar1 = 0;
                break;
            case 4:
                FUN_38FC();
                goto default;
            default:
                uVar1 = 0;
                break;
            case 8:
                FUN_32B90((uint)arg2);
                uVar1 = 0;
                break;
            case 9:
                uVar1 = 0;

                if (arg2 != 0)
                {
                    uVar1 = 0;

                    if (vMesh == null)
                    {
                        GameManager.instance.FUN_309A0(this);
                        uVar1 = 0;
                    }
                }

                break;
        }

        return uVar1;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        switch (arg1)
        {
            case 20:
                FUN_3838((TrainEngine)arg2);
                return 0;
        }

        return 0;
    }
}

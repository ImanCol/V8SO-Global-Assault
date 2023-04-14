using UnityEngine;

public class Flame1 : VigObject
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
        if (hit.object2.type == 3)
        {
            return 0u;
        }
        if (hit.self.type == 2)
        {
            if (LevelManager.instance.FUN_39AF8((Vehicle)hit.self))
            {
                LevelManager.instance.FUN_4DE54(vTransform.position, 35);
                UIManager.instance.FUN_4E414(vTransform.position, new Color32(128, 128, 0, 8));
            }
        }
        else
        {
            LevelManager.instance.FUN_4DE54(vTransform.position, 35);
            int param = GameManager.instance.FUN_1DD9C();
            GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 69, vTransform.position);
        }
        GameManager.instance.FUN_309A0(this);
        return uint.MaxValue;
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        if (arg1 != 3)
        {
            if (arg1 < 4)
            {
                if (arg1 != 0)
                {
                    return 0u;
                }
                vTransform.position.x += physics1.Z;
                vTransform.position.y += physics1.W;
                vTransform.position.z += physics2.X;
                int num = physics1.Z * 31;
                if (num < 0)
                {
                    num += 31;
                }
                physics1.Z = num >> 5;
                num = physics2.X * 31;
                if (num < 0)
                {
                    num += 31;
                }
                physics2.X = num >> 5;
                bool num2 = GameManager.instance.DAT_DA0 <= vTransform.position.z;
                physics1.W -= 16;
                if ((num2 || vTransform.position.y <= GameManager.instance.DAT_DB0) && vTransform.position.y <= GameManager.instance.terrain.FUN_1B750((uint)vTransform.position.x, (uint)vTransform.position.z))
                {
                    return 0u;
                }
                if (tags != 0)
                {
                    LevelManager.instance.FUN_4DE54(vTransform.position, 138);
                    int param = GameManager.instance.FUN_1DD9C();
                    GameManager.instance.FUN_1E14C(param, GameManager.instance.DAT_C2C, 70);
                    LevelManager.instance.FUN_309C8(this, 1);
                    return uint.MaxValue;
                }
            }
            else if (arg1 != 5)
            {
                return 0u;
            }
        }
        GameManager.instance.FUN_309A0(this);
        return uint.MaxValue;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        if (arg1 != 5)
        {
            return 0u;
        }
        GameManager.instance.FUN_309A0(this);
        return uint.MaxValue;
    }
}

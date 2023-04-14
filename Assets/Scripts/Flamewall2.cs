using UnityEngine;

public class Flamewall2 : VigObject
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
        uint result = 0u;
        if (hit.self.type == 2)
        {
            bool num = LevelManager.instance.FUN_39AF8((Vehicle)hit.self);
            result = 0u;
            if (num)
            {
                int param = GameManager.instance.FUN_1DD9C();
                GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 63, vTransform.position);
                UIManager.instance.FUN_4E414(vTransform.position, new Color32(128, 128, 0, 8));
                result = 0u;
            }
        }
        return result;
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        uint result;
        if (arg1 < 4)
        {
            result = 0u;
            if (arg1 == 2)
            {
                id = 0;
            }
        }
        else
        {
            result = 0u;
        }
        return result;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        uint result = 0u;
        if (arg1 == 5)
        {
            GameManager.instance.FUN_309A0(this);
            result = uint.MaxValue;
        }
        return result;
    }
}

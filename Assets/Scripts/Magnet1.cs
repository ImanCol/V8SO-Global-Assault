using UnityEngine;

public class Magnet1 : VigObject
{
    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        if (arg1 == 4)
        {
            LevelManager.instance.DAT_117C--;
        }
        return 0u;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        if (arg1 != 5)
        {
            return 0u;
        }
        sbyte tags = base.tags;
        BufferedBinaryReader reader;
        ushort timer;
        if (tags != 1)
        {
            VigObject vigObject;
            if (1 < tags)
            {
                if (tags != 2)
                {
                    return 0u;
                }
                vigObject = Utilities.FUN_2CD78(this);
                LevelManager.instance.FUN_4DF20(vigObject.vTransform.position, 13, 2048);
                int param = GameManager.instance.FUN_1DD9C();
                GameManager.instance.FUN_1E628(param, GameManager.instance.DAT_C2C, 63, vigObject.vTransform.position);
                GameManager.instance.FUN_309A0(vigObject);
                return uint.MaxValue;
            }
            if (tags != 0)
            {
                return 0u;
            }
            reader = vData.FUN_2CBB0(193);
            timer = GameManager.instance.timer;
            vAnim.ChangeBuffer(reader);
            base.tags = 1;
            maxHalfHealth = 10;
            DAT_4A = timer;
            vigObject = Utilities.FUN_2CD78(this);
            UIManager.instance.FUN_4E414(vigObject.vTransform.position, new Color32(0, 0, 128, 8));
            return 0u;
        }
        short num = (short)(maxHalfHealth - 1);
        maxHalfHealth = (ushort)num;
        if (num != 0)
        {
            return 0u;
        }
        reader = vData.FUN_2CBB0(194);
        timer = GameManager.instance.timer;
        vAnim.ChangeBuffer(reader);
        base.tags = 2;
        DAT_4A = timer;
        return 0u;
    }
}

using System;

// Token: 0x020000D1 RID: 209
public class Water2 : VigObject
{
    // Token: 0x06000431 RID: 1073 RVA: 0x00007FCE File Offset: 0x000061CE
    protected override void Start()
    {
        base.Start();
    }

    // Token: 0x06000432 RID: 1074 RVA: 0x00007FD6 File Offset: 0x000061D6
    protected override void Update()
    {
        base.Update();
    }

    // Token: 0x06000433 RID: 1075 RVA: 0x00036DB4 File Offset: 0x00034FB4
    public override uint UpdateW(int arg1, int arg2)
    {
        uint num;
        if (arg1 == 2)
        {
            this.physics1.M0 = -1;
            num = 0U;
        }
        else if (arg1 < 3)
        {
            num = 0U;
            if (arg1 == 0)
            {
                short num2 = (short)(this.physics1.M0 - 1);
                this.physics1.M0 = num2;
                if (num2 == -1)
                {
                    Ballistic ballistic = this.DAT_98.ini.FUN_2C17C((ushort)this.physics2.M3, typeof(Ballistic), 8U) as Ballistic;
                    ballistic.vTransform = GameManager.FUN_2A39C();
                    int num3 = (int)GameManager.FUN_2AC5C();
                    int num4 = this.DAT_58;
                    ballistic.vTransform.position.y = 0;
                    ballistic.vTransform.position.x = (num3 * 2 * num4 >> 15) - num4;
                    num3 = (int)GameManager.FUN_2AC5C();
                    num4 = this.DAT_58;
                    ballistic.vTransform.position.z = (num3 * 2 * num4 >> 15) - num4;
                    Utilities.FUN_2CC48(this, ballistic);
                    Utilities.ParentChildren(this, this);
                    this.physics1.M0 = this.physics1.M1;
                }
                num = 0U;
                if (this.child2 == null)
                {
                    GameManager.instance.FUN_309A0(this);
                    num = uint.MaxValue;
                }
            }
        }
        else
        {
            num = 0U;
        }
        return num;
    }

    // Token: 0x06000434 RID: 1076 RVA: 0x00008B83 File Offset: 0x00006D83
    public override uint UpdateW(int arg1, VigObject arg2)
    {
        if (arg1 == 5)
        {
            this.vAnim = null;
            this.flags |= 2U;
            return uint.MaxValue;
        }
        return 0U;
    }

    // Token: 0x0400018A RID: 394
    public XOBF_DB DAT_98;
}

using System;

// Token: 0x020000C1 RID: 193
public class Water4 : VigObject
{
    // Token: 0x060003DF RID: 991 RVA: 0x00007FCE File Offset: 0x000061CE
    protected override void Start()
    {
        base.Start();
    }

    // Token: 0x060003E0 RID: 992 RVA: 0x00007FD6 File Offset: 0x000061D6
    protected override void Update()
    {
        base.Update();
    }

    // Token: 0x060003E1 RID: 993 RVA: 0x00034FAC File Offset: 0x000331AC
    public override uint UpdateW(int arg1, int arg2)
    {
        if (arg1 == 2)
        {
            this.physics1.M0 = -1;
            return 0U;
        }
        if (arg1 < 3 && arg1 == 0)
        {
            short num = (short)(this.physics1.M0 - 1);
            this.physics1.M0 = num;
            if (num == -1)
            {
                Ballistic ballistic = this.DAT_98.ini.FUN_2C17C((ushort)this.physics2.M3, typeof(Ballistic), 8U) as Ballistic;
                ballistic.vTransform = GameManager.FUN_2A39C();
                int num2 = (int)GameManager.FUN_2AC5C();
                int num3 = this.DAT_58;
                ballistic.vTransform.position.y = 0;
                ballistic.vTransform.position.x = (num2 * 2 * num3 >> 15) - num3;
                num2 = (int)GameManager.FUN_2AC5C();
                num3 = this.DAT_58;
                ballistic.vTransform.position.z = (num2 * 2 * num3 >> 15) - num3;
                Utilities.FUN_2CC48(this, ballistic);
                Utilities.ParentChildren(this, this);
                this.physics1.M0 = this.physics1.M1;
            }
            if (this.child2 == null)
            {
                GameManager.instance.FUN_309A0(this);
                return uint.MaxValue;
            }
        }
        return 0U;
    }

    // Token: 0x060003E2 RID: 994 RVA: 0x00008B83 File Offset: 0x00006D83
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

    // Token: 0x0400017F RID: 383
    public XOBF_DB DAT_98;
}

using UnityEngine;

public class Crater : VigObject
{
    public ushort[] indices;

    protected override void Start()
    {
    }

    protected override void Update()
    {
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        if (arg1 == 2)
        {
            int x = screen.x;
            int dAT_ = DAT_58;
            uint num = (uint)(x - dAT_ + 65535) >> 16;
            uint num2 = (uint)(screen.z - dAT_ + 65535) >> 16;
            uint num3 = (uint)(screen.z + dAT_) >> 16;
            bool flag = false;
            int num4 = 0;
            VigTerrain terrain = GameManager.instance.terrain;
            while (num <= (uint)(x + dAT_) >> 16)
            {
                int num5 = num4;
                if (num2 <= num3)
                {
                    uint num6 = num2;
                    do
                    {
                        ushort num7 = indices[num5];
                        num5++;
                        if (num7 != 0)
                        {
                            indices[num4]--;
                            terrain.vertices[terrain.chunks[(num >> 6) * 32 + (num6 >> 6)] * 4096 + (int)((num & 0x3F) * 128 + (num6 & 0x3F) * 2) / 2]--;
                            flag = true;
                        }
                        num6++;
                        num4++;
                    }
                    while (num6 <= num3);
                }
                num++;
                num4 = num5;
            }
            terrain.FUN_50E40(screen.x, screen.z, DAT_58);
            if (!flag)
            {
                UnityEngine.Object.Destroy(base.gameObject);
                return uint.MaxValue;
            }
            GameManager.instance.FUN_30CB0(this, 60);
        }
        return 0u;
    }
}

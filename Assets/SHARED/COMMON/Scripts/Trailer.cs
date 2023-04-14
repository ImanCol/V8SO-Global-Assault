using UnityEngine;

public static class Trailer
{
    public static uint LoadTrailer(Vehicle param1, int param2, int param3)
    {
        if (param2 == 1)
        {
            Body body = param1.body[1].child2 as Body;
            while (body != null)
            {
                if (body.id == 1)
                {
                    short id = param1.id;
                    body.state = _BODY_TYPE.Trailer;
                    body.id = id;
                    body.UpdateW(1, 0);
                    param1.FUN_2D1DC();
                    break;
                }
                body = (body.child as Body);
            }
            return param1.FUN_367A4(param2, param3);
        }
        return 0u;
    }

    public static void FUN_A0(this Body param1)
    {
        VigObject vigObject = Utilities.FUN_2CDB0(param1);
        ConfigContainer configContainer = param1.FUN_2C5F4(33024);
        VigTransform vigTransform = param1.vTransform = GameManager.instance.FUN_2CDF4(param1);
        uint num = 0u;
        Trailer2 trailer = Utilities.FUN_52188(param1.FUN_2CCBC(), typeof(Trailer2)) as Trailer2;
        trailer.type = 10;
        trailer.flags = 136u;
        trailer.maxHalfHealth = vigObject.maxHalfHealth;
        trailer.FUN_4C98C();
        trailer.FUN_305FC();
        trailer.physics1.X = 0;
        trailer.physics1.Y = 0;
        trailer.physics1.Z = 0;
        trailer.physics2.X = 0;
        trailer.physics2.Y = 0;
        trailer.physics2.Z = 0;
        trailer.DAT_A0 = new Vector3Int(100, 28, 48);
        trailer.DAT_A6 = 12288;
        vigObject.DAT_A6 += 12288;
        trailer.DAT_A8 = configContainer.v3_1;
        trailer.DAT_C0 = (Vehicle)vigObject;
        ((Vehicle)vigObject).trailer = trailer;
        trailer.DAT_B4 = Utilities.FUN_24148(trailer.vTransform, trailer.DAT_A8);
        trailer.DAT_B4 = Utilities.FUN_24304(vigObject.vTransform, trailer.DAT_B4);
        int num3;
        do
        {
            ConfigContainer configContainer2 = trailer.FUN_2C5F4((ushort)((num - 32768) & 0xFFFF));
            if (configContainer2 != null)
            {
                Wheel wheel = LevelManager.instance.xobfList[18].ini.FUN_2C17C(28, typeof(Wheel), 8u) as Wheel;
                wheel.physics2.X = -LevelManager.instance.xobfList[18].ini.configContainers[28].v3_1.y;
                int num2 = (int)GameManager.FUN_2AC5C();
                wheel.vr.x = num2 << 4;
                wheel.vr.y = 0;
                wheel.vr.z = (int)((num & 1) << 11);
                wheel.FUN_2C7D0();
                wheel.id = wheel.DAT_1A;
                wheel.screen = configContainer2.v3_1;
                Utilities.FUN_2CC48(trailer, wheel);
                Utilities.ParentChildren(trailer, trailer);
                trailer.DAT_C4[num] = wheel;
                configContainer2 = trailer.vData.ini.FUN_2C5CC(configContainer2, 32768);
                wheel.type = 9;
                if (configContainer2 == null)
                {
                    wheel.physics1.X = 0;
                }
                else
                {
                    wheel.physics1.X = configContainer2.v3_1.y;
                }
                wheel.physics1.M6 = 40;
                wheel.physics1.M7 = 128;
                num3 = wheel.physics2.X * 25734;
                wheel.physics1.Y = wheel.screen.y;
                if (num3 < 0)
                {
                    num3 += 4095;
                }
                wheel.physics2.Y = 16777216 / (num3 >> 12);
                wheel.ApplyTransformation();
            }
            num++;
        }
        while ((int)num < 2);
        Vector3Int[] array = new Vector3Int[3];
        Vector3Int[] array2 = new Vector3Int[3];
        array[0] = trailer.DAT_A8;
        array2[0] = Utilities.FUN_24148(trailer.vTransform, array[0]);
        num3 = 0;
        do
        {
            Wheel wheel = trailer.DAT_C4[num3];
            array[num3 + 1] = default(Vector3Int);
            array[num3 + 1].x = wheel.screen.x;
            array[num3 + 1].y = wheel.screen.y + wheel.physics2.X - 5120;
            array[num3 + 1].z = wheel.screen.z;
            array2[num3 + 1] = Utilities.FUN_24148(trailer.vTransform, array[num3 + 1]);
            int y = trailer.FUN_2CFBC(array2[num3 + 1]);
            array2[num3 + 1].y = y;
            num3++;
        }
        while (num3 < 2);
        trailer.vTransform = Utilities.FUN_2A9F4(array, array2);
        trailer.id2 = trailer.id;
    }
}

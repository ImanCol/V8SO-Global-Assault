using System;
using System.Collections.Generic;

public class Trumpet2 : VigObject
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
        if (hit.self.type == 2 && (hit.self.flags & 0x4000000) == 0)
        {
            Vehicle vehicle = (Vehicle)hit.self;
            if (vehicle.id < 0)
            {
                GameManager.instance.FUN_15AA8(~vehicle.id, 8, byte.MaxValue, 64, 16);
            }
            vehicle.physics1.X += physics1.Z * 6;
            vehicle.physics1.Z += physics2.X * 6;
            int num = (int)GameManager.FUN_2AC5C();
            vehicle.physics1.Y += ((num << 12 >> 15) - 2048) * 128;
            if ((flags & 0x1000000) == 0 && vehicle.shield == 0)
            {
                flags |= 16777216u;
                vehicle.flip = 200;
                int param = GameManager.instance.FUN_1DD9C();
                GameManager.instance.FUN_1E580(param, vData.sndList, 3, vehicle.vTransform.position);
                GameManager.instance.FUN_2F798(this, hit);
                VigTransform param2 = default(VigTransform);
                param2.position = Utilities.FUN_24148(vTransform, hit.position);
                param2.rotation = Utilities.FUN_2A5EC(hit.normal1);
                LevelManager.instance.FUN_4E56C(param2, 123);
                if (tags == 1)
                {
                    vehicle.FUN_39BC4();
                }
            }
        }
        return 0u;
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        uint result;
        if (arg1 == 0)
        {
            vTransform.position.x += physics1.Z;
            vTransform.position.y += physics1.W;
            vTransform.position.z += physics2.X;
            int z = physics1.Z;
            int num = z;
            if (z < 0)
            {
                num = z + 63;
            }
            int w = physics1.W;
            physics1.Z = z - (num >> 6);
            num = w;
            if (w < 0)
            {
                num = w + 63;
            }
            z = physics2.X;
            physics1.W = w - (num >> 6);
            num = z;
            if (z < 0)
            {
                num = z + 63;
            }
            physics2.X = z - (num >> 6);
            VigObject child = child2;
            short num2 = (short)(physics1.M2 * 480 + 1024);
            child.vTransform.rotation.V11 = num2;
            child.vTransform.rotation.V00 = num2;
            short num3 = (short)(physics1.M2 + 1);
            physics1.M2 = num3;
            if (num3 * 65536 >> 16 == 64)
            {
                GameManager.instance.FUN_309A0(this);
                result = uint.MaxValue;
            }
            else
            {
                result = 0u;
                if ((num3 & 1) == 0 && tags == 0)
                {
                    Dictionary<int, Type> dictionary = new Dictionary<int, Type>();
                    dictionary.Add(vData.ini.GetContainerIndex((ushort)DAT_1A, 0), typeof(VigChild));
                    TrumpetBallistic trumpetBallistic = vData.ini.FUN_2C17C((ushort)DAT_1A, typeof(TrumpetBallistic), 8u, dictionary) as TrumpetBallistic;
                    Utilities.ParentChildren(trumpetBallistic, trumpetBallistic);
                    trumpetBallistic.DAT_90 = this;
                    trumpetBallistic.flags = 1610613636u;
                    trumpetBallistic.type = 8;
                    trumpetBallistic.maxHalfHealth = (ushort)((int)maxHalfHealth / 4);
                    trumpetBallistic.DAT_80 = DAT_80;
                    trumpetBallistic.id = id;
                    trumpetBallistic.vTransform = vTransform;
                    trumpetBallistic.child2.vTransform = child.vTransform;
                    trumpetBallistic.FUN_305FC();
                    result = 0u;
                }
            }
        }
        else
        {
            result = 0u;
        }
        return result;
    }
}

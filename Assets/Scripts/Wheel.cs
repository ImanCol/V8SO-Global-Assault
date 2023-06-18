using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Burst;

public enum _WHEEL_TYPE
{
    Unflatten,
    Flatten //FUN_395E0
}

[BurstCompile]
public class Wheel : VigObject
{
    public _WHEEL_TYPE state;

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    //Wheels Pinchadas
    public override uint UpdateW(int arg1, int arg2)
    {
        if (state == _WHEEL_TYPE.Flatten)
        {
            if (arg1 == 2)
            {
                Vehicle vehicle = Utilities.FUN_2CDB0(this) as Vehicle;
                int num = 0;
                flags &= 3221225471u;
                physics2.X += 3072;
                do
                {
                    if (vehicle.wheels[num] != null && (vehicle.wheels[num].flags & 0x40000000) != 0)
                    {
                        return 0u;
                    }
                    num++;
                }
                while (num < 6);
                vehicle.flags &= 4294836223u;
                state = _WHEEL_TYPE.Unflatten;
            }
            return 0u;
        }
        return 0u;
    }

    public new VigObject FUN_2C344(XOBF_DB param1, ushort param2, uint param3)
    {
        ConfigContainer configContainer = param1.ini.configContainers[param2];
        if ((configContainer.flag & 0x7FF) != 2047)
        {
            VigMesh vigMesh = vMesh = param1.FUN_1FD18(base.gameObject, (uint)(configContainer.flag & 0x7FF), init: true);
        }
        else
        {
            vMesh = null;
        }
        if (configContainer.colliderID < 0)
        {
            vCollider = null;
        }
        else
        {
            VigCollider vigCollider = param1.cbbList[configContainer.colliderID];
            vCollider = new VigCollider(vigCollider.buffer);
        }
        vData = param1;
        DAT_1A = (short)param2;
        if ((param3 & 8) == 0)
        {
            vAnim = null;
        }
        else
        {
            BufferedBinaryReader bufferedBinaryReader = new BufferedBinaryReader(param1.animations);
            if (bufferedBinaryReader.GetBuffer() != null)
            {
                int num = bufferedBinaryReader.ReadInt32(param2 * 4 + 4);
                if (num != 0)
                {
                    bufferedBinaryReader.Seek(num, SeekOrigin.Begin);
                }
                else
                {
                    bufferedBinaryReader = null;
                }
            }
            else
            {
                bufferedBinaryReader = null;
            }
            vAnim = bufferedBinaryReader;
        }
        DAT_4A = GameManager.instance.timer;
        if ((param3 & 2) == 0 && configContainer.next != ushort.MaxValue)
        {
            VigObject vigObject = child2 = param1.ini.FUN_2C17C_3(configContainer.next, typeof(WheelChild), param3 | 0x21);
            if (vigObject != null)
            {
                vigObject.ApplyTransformation();
                child2.parent = this;
            }
        }
        else
        {
            child2 = null;
        }
        return this;
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using UnityEngine;

public enum _CHILD_TYPE
{
    Child, //FUN_4CA10
    Default
}

[BurstCompile]
public class VigChild : VigObject
{
    public _CHILD_TYPE state;

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    public override uint OnCollision(HitDetection param1)
    {
        if (state == _CHILD_TYPE.Child)
        {
            VigObject vigObject = Utilities.FUN_2CD78(this);
            if (vigObject.GetType().IsSubclassOf(typeof(VigObject)))
            {
                return 0u;
            }
            return vigObject.OnCollision(param1);
        }
        return base.OnCollision(param1);
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        if (state == _CHILD_TYPE.Child)
        {
            VigObject vigObject = Utilities.FUN_2CD78(this);
            if (!vigObject.GetType().IsSubclassOf(typeof(VigObject)))
            {
                return 0u;
            }
            return vigObject.UpdateW(arg1, arg2);
        }
        return base.UpdateW(arg1, arg2);
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        if (state == _CHILD_TYPE.Child)
        {
            VigObject vigObject = Utilities.FUN_2CD78(this);
            if (!vigObject.GetType().IsSubclassOf(typeof(VigObject)))
            {
                return 0u;
            }
            return vigObject.UpdateW(arg1, arg2);
        }
        return base.UpdateW(arg1, arg2);
    }
}


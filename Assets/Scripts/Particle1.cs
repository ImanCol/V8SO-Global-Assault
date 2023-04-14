using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum _PARTICLE1_TYPE
{
    Default, //FUN_4DE1C
    LaunchRocket //FUN_183C (LAUNCH.DLL)
}

public class Particle1 : VigObject
{
    public _PARTICLE1_TYPE state;

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
        if (state == _PARTICLE1_TYPE.LaunchRocket)
        {
            if (arg1 == 0)
            {
                vTransform.position.x += screen.x;
                vTransform.position.y += screen.y;
                vTransform.position.z += screen.z;
                screen.y += 28;
            }
            return 0u;
        }
        return 0u;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        uint result = 0u;
        switch (state)
        {
            case _PARTICLE1_TYPE.Default:
                if (arg1 == 5)
                {
                    Tuple<List<VigTuple>, VigTuple> param = new Tuple<List<VigTuple>, VigTuple>(GameManager.instance.interObjs, TDAT_74);
                    GameManager.instance.FUN_3094C(param);
                    result = uint.MaxValue;
                }
                else
                {
                    result = 0u;
                }
                break;
            case _PARTICLE1_TYPE.LaunchRocket:
                result = 0u;
                if (arg1 == 5)
                {
                    FUN_4EE8C(GameManager.instance.interObjs);
                    result = 4294967294u;
                }
                break;
        }
        return result;
    }
}

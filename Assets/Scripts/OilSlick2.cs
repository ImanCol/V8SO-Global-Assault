using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public enum _OILSLICK_TYPE
{
    Oilslick,
    Ballistic
}

public class OilSlick2 : VigObject
{
    public _OILSLICK_TYPE state;

    private static byte[] smoke_collider = new byte[32]
    {
        1,
        0,
        0,
        0,
        0,
        192,
        253,
        255,
        0,
        0,
        192,
        255,
        0,
        192,
        253,
        255,
        0,
        64,
        2,
        0,
        0,
        0,
        0,
        0,
        0,
        64,
        2,
        0,
        0,
        0,
        0,
        0
    };

    public bool trigger;

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
        if (hit.self.type == 8 && !trigger)
        {
            VigObject self = hit.self;
            Type type = self.GetType();
            if (type == typeof(Flame1) || type == typeof(Hovermine) || type == typeof(Brimstone) || type == typeof(Flamewall1) || type == typeof(Flamewall2) || type == typeof(Flamewall3) || (type == typeof(Missile) && ((Missile)self).state == _MISSILE_TYPE.Halo) || type == typeof(Furnace2) || type == typeof(Furnace3) || type == typeof(Pipe3) || type == typeof(Pump2))
            {
                Debug.Log("Go 1 Type: " + type);
                CreateBurstFire(chain: true);
            }
            else if (type == typeof(Mine))
            {
                ((Mine)self).DAT_98 = this;
                trigger = true;
            }
            return 0u;
        }
        if (hit.self.type == 3 && !trigger)
        {
            VigObject self = hit.self;
            Type type = self.GetType();
            if (type == typeof(LaunchRocket3) || type == typeof(TestThruster3) || type == typeof(Spark) || type == typeof(Spark2))
            {
                Debug.Log("Go 2 Type: " + type);
                CreateBurstFire(chain: true);
            }
            return 0u;
        }
        if (hit.self.type == 0 && !trigger)
        {
            VigObject self = hit.self;
            Type type = self.GetType();
            if (type == typeof(IngPlant2) || type == typeof(MoltenSteel) || type == typeof(Bonfire))
            {
                Debug.Log("Go 3 Type: " + type);
                CreateBurstFire(chain: true);
            }
            return 0u;
        }
        if (hit.self.type != 2)
        {
            return 0u;
        }
        Vehicle vehicle = (Vehicle)hit.self;
        if ((vehicle.DAT_F6 & 8) != 0 && !trigger)
        {
            Debug.Log("Go 4 Type: " + type);
            CreateBurstFire(chain: true);
            return 0u;
        }
        if ((vehicle.flags & 0x4004000) != 16384)
        {
            return 0u;
        }
        if (vehicle.wheelsType != 0)
        {
            return 0u;
        }
        bool flag = false;
        trigger = true;
        int num = 0;
        do
        {
            Wheel wheel = vehicle.wheels[num];
            if (wheel != null && (wheel.flags & 0x4000000) == 0)
            {
                wheel.flags |= 67108864u;
                flag = true;
            }
            num++;
        }
        while (num < 4);
        if (!flag)
        {
            return 0u;
        }
        OilSlick3 oilSlick = new GameObject().AddComponent<OilSlick3>();
        oilSlick.type = byte.MaxValue;
        oilSlick.child = vehicle;
        GameManager.instance.FUN_30CB0(oilSlick, 180);
        num = ((vehicle.physics2.Y >= 0) ? (vehicle.physics1.W * 16) : (vehicle.physics1.W * -16));
        vehicle.physics2.Y += num;
        return 0u;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        switch (state)
        {
            case _OILSLICK_TYPE.Oilslick:
                if (arg1 == 5)
                {
                    if (trigger && tags-- == 1)
                    {
                        FUN_2C124(220);
                        state = _OILSLICK_TYPE.Ballistic;
                        Utilities.ParentChildren(this, this);
                        return uint.MaxValue;
                    }
                    id = 1000;
                }
                return 0u;
            case _OILSLICK_TYPE.Ballistic:
                if (arg1 == 5)
                {
                    if (parent == null)
                    {
                        GameManager.instance.FUN_309A0(this);
                        return 4294967294u;
                    }
                    VigObject param = FUN_2CCBC();
                    GameManager.instance.FUN_307CC(param);
                    return 4294967294u;
                }
                return 0u;
            default:
                return 0u;
        }
    }

    public void CreateBurstFire(bool chain)
    {
        flags |= 2048u;
        Smoke5 smoke = LevelManager.instance.xobfList[19].InstantiateSmoke(109, GameManager.DAT_9C4);
        smoke.physics1.Z *= 3;
        smoke.physics1.Y *= 4;
        smoke.vTransform = vTransform;
        Utilities.FUN_245AC(ref smoke.vTransform.rotation, new Vector3Int(8192, 8192, 8192));
        smoke.flags &= 4294967263u;
        smoke.type = 8;
        smoke.FUN_30B78();
        smoke.FUN_30BF0();
        GameManager.instance.FUN_30080(GameManager.instance.worldObjs, smoke);
        smoke.vCollider = new VigCollider(smoke_collider);
        GameManager.instance.FUN_30CB0(smoke, 1000);
        int param = GameManager.instance.FUN_1DD9C();
        GameManager.instance.FUN_1E580(param, GameManager.instance.DAT_C2C, 79, vTransform.position);
        param = GameManager.instance.FUN_1DD9C();
        smoke.DAT_18 = (sbyte)param;
        GameManager.instance.FUN_1E098(param, GameManager.instance.DAT_C2C, 80, 0u, param5: true);
        trigger = true;
        if (!chain)
        {
            return;
        }
        List<VigTuple> worldObjs = GameManager.instance.worldObjs;
        for (int i = 0; i < worldObjs.Count; i++)
        {
            VigObject vObject = worldObjs[i].vObject;
            if (vObject.type == 3 && vObject.GetType() == typeof(OilSlick2) && vObject != this)
            {
                OilSlick2 oilSlick = (OilSlick2)vObject;
                if (!oilSlick.trigger && Utilities.FUN_29F6C(vTransform.position, oilSlick.vTransform.position) < 262144)
                {
                    Debug.Log("Go 5 Type: " + vObject);
                    oilSlick.CreateBurstFire(chain: true);
                }
            }
        }
    }
}

using UnityEngine;

public class Particle2 : VigObject
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
        VigObject self = hit.self;
        uint result = 0u;
        if (self.type == 2)
        {
            Vehicle vehicle = (Vehicle)self;
            Utilities.FUN_2A168(out Vector3Int vout, vTransform.position, vehicle.vTransform.position);
            Vector3Int v = new Vector3Int(vout.x * 12, vout.y * 6, vout.z * 12);
            vehicle.FUN_2B370(v, vTransform.position);
            result = 0u;
            if (maxHalfHealth > 0)
            {
                maxHalfHealth--;
            }
            if (vehicle.id < 0)
            {
                GameManager.instance.FUN_15B00(~vehicle.id, byte.MaxValue, 2, 128);
                result = 0u;
            }
        }
        return result;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        uint result = 0u;
        if (arg1 == 5)
        {
            GameManager.instance.FUN_309A0(this);
            result = 4294967294u;
        }
        return result;
    }
}

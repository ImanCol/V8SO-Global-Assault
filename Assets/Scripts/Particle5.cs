using UnityEngine;

public class Particle5 : VigObject
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
        FUN_30BA8();
        FUN_4DC94();
        uint result = 0u;
        if (vMesh == null)
        {
            GameManager.instance.FUN_309A0(this);
            result = uint.MaxValue;
        }
        return result;
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        if (arg1 == 0)
        {
            VigCollider vCollider = base.vCollider;
            Vector3Int v = (vCollider == null || vCollider.reader.ReadUInt16(0) != 1) ? new Vector3Int(0, -DAT_58, 0) : new Vector3Int((vCollider.reader.ReadInt32(4) + vCollider.reader.ReadInt32(16)) / 2, vCollider.reader.ReadInt32(8), vCollider.reader.ReadInt32(24));
            FUN_24700((short)vr.x, 0, 0);
            int num = vr.y;
            if (num < 0)
            {
                num += 7;
            }
            vr.x += num >> 3;
            v = Utilities.FUN_24148(vTransform, v);
            num = GameManager.instance.terrain.FUN_1B750((uint)v.x, (uint)v.z);
            if (v.y < num)
            {
                return 0u;
            }
            FUN_30BA8();
            FUN_4DC94();
            uint result = 0u;
            if (vMesh == null)
            {
                GameManager.instance.FUN_309A0(this);
                result = uint.MaxValue;
            }
            return result;
        }
        return 0u;
    }
}
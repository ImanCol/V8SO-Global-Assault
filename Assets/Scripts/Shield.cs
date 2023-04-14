using UnityEngine;

public class Shield : VigObject
{
    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.transform.localPosition = new Vector3((float)vTransform.position.x / (float)GameManager.instance.translateFactor, (float)(-vTransform.position.y) / (float)GameManager.instance.translateFactor, (float)vTransform.position.z / (float)GameManager.instance.translateFactor);
        base.transform.localRotation = vTransform.rotation.Matrix2Quaternion;
        base.transform.localEulerAngles = new Vector3(0f - base.transform.localEulerAngles.x, base.transform.localEulerAngles.y, 0f - base.transform.localEulerAngles.z);
        base.transform.localScale = vTransform.rotation.Scale;
    }

    public override uint UpdateW(int arg1, VigObject arg2)
    {
        if (arg1 == 5)
        {
            (Utilities.FUN_2CD78(this) as Vehicle).DAT_F6 &= 65534;
            VigObject param = FUN_2CCBC();
            GameManager.instance.FUN_307CC(param);
            return uint.MaxValue;
        }
        return 0u;
    }
}

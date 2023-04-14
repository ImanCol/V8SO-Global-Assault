using UnityEngine;

public class VigShadow : MonoBehaviour
{
    public VigMesh vMesh;

    public VigTransform vTransform;

    public int DAT_24;

    public int DAT_28;

    public Vector3 eulerAngles;

    private void Start()
    {
    }

    private void Update()
    {
        base.transform.localPosition = new Vector3((float)vTransform.position.x / (float)GameManager.instance.translateFactor, (float)(-vTransform.position.y) / (float)GameManager.instance.translateFactor, (float)vTransform.position.z / (float)GameManager.instance.translateFactor);
        base.transform.localRotation = vTransform.rotation.Matrix2Quaternion;
        base.transform.localEulerAngles = eulerAngles;
        base.transform.localEulerAngles = new Vector3(0f - base.transform.localEulerAngles.x, base.transform.localEulerAngles.y, 0f - base.transform.localEulerAngles.z);
        base.transform.localScale = vTransform.rotation.Scale;
    }

    public void FUN_4C73C()
    {
        if (GameManager.instance.DAT_DA0 < vTransform.position.z || vTransform.position.y < GameManager.instance.DAT_DB0)
        {
            VigTransform param = Utilities.CompMatrixLV(GameManager.instance.DAT_F00, vTransform);
            vMesh.FUN_21F70(param);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using Unity.Burst;
using UnityEngine;


[BurstCompile]
public class VigConfig : MonoBehaviour
{
    public int dataID;

    public List<ConfigContainer> configContainers;

    public uint pointerUnk1;

    public VigObject[] obj;

    public int currentID;

    [HideInInspector]
    public XOBF_DB xobf;

    public VigObject FUN_2C17C(ushort param1, Type param2, uint param3)
    {
        Debug.Log("Detectando colision... ushort:" + param1 + " - Type:" + param2 + " - uint:" + param3);
        Debug.Log("configContainer... ushort:" + param1 + " - Type:" + param2 + " - uint:" + param3);
        ConfigContainer configContainer = configContainers[param1]; //error en Cansoncity con el Agua
        VigObject vigObject;
        if ((short)configContainer.flag < 0 || (255 < (short)configContainer.objID && (param3 & 0x20) != 0))
        {
            vigObject = (((param3 & 1) != 0 && (short)configContainer.previous != -1) ? FUN_2C17C(configContainer.previous, typeof(VigObject), param3) : null);
        }
        else
        {
            vigObject = FUN_2BF44(configContainer, param2);
            vigObject.DAT_1A = (short)param1;
            vigObject.id = (short)configContainer.objID;
            if ((param3 & 8) == 0)
            {
                vigObject.vAnim = null;
            }
            else
            {
                byte[] animations = xobf.animations;
                BufferedBinaryReader bufferedBinaryReader = null;
                if (animations.Length != 0)
                {
                    bufferedBinaryReader = new BufferedBinaryReader(animations);
                    int num = bufferedBinaryReader.ReadInt32(param1 * 4 + 4);
                    if (num != 0)
                    {
                        bufferedBinaryReader.Seek(num, SeekOrigin.Begin);
                    }
                    else
                    {
                        bufferedBinaryReader = null;
                    }
                }
                vigObject.vAnim = bufferedBinaryReader;
            }
            vigObject.DAT_4A = GameManager.instance.timer;
            if ((param3 & 1) != 0 && (short)configContainer.previous != -1)
            {
                VigObject vigObject2 = vigObject.child = FUN_2C17C(configContainer.previous, typeof(VigObject), param3);
                if (vigObject2 != null)
                {
                    vigObject2.parent = vigObject;
                    vigObject.child.ApplyTransformation();
                }
            }
            if ((param3 & 2) == 0 && (short)configContainer.next != -1)
            {
                VigObject vigObject2 = vigObject.child2 = FUN_2C17C(configContainer.next, typeof(VigObject), param3 | 0x21);
                if (vigObject2 != null)
                {
                    vigObject2.parent = vigObject;
                    vigObject.child2.ApplyTransformation();
                }
            }
        }
        return vigObject;
    }

    public VigObject FUN_2C17C(ushort param1, Type param2, uint param3, Type param4)
    {
        ConfigContainer configContainer = configContainers[param1];
        VigObject vigObject;
        if ((short)configContainer.flag < 0 || (255 < (short)configContainer.objID && (param3 & 0x20) != 0))
        {
            vigObject = (((param3 & 1) != 0 && (short)configContainer.previous != -1) ? FUN_2C17C(configContainer.previous, typeof(VigObject), param3) : null);
        }
        else
        {
            vigObject = FUN_2BF44(configContainer, param2);
            vigObject.DAT_1A = (short)param1;
            vigObject.id = (short)configContainer.objID;
            if ((param3 & 8) == 0)
            {
                vigObject.vAnim = null;
            }
            else
            {
                byte[] animations = xobf.animations;
                BufferedBinaryReader bufferedBinaryReader = null;
                if (animations.Length != 0)
                {
                    bufferedBinaryReader = new BufferedBinaryReader(animations);
                    int num = bufferedBinaryReader.ReadInt32(param1 * 4 + 4);
                    if (num != 0)
                    {
                        bufferedBinaryReader.Seek(num, SeekOrigin.Begin);
                    }
                    else
                    {
                        bufferedBinaryReader = null;
                    }
                }
                vigObject.vAnim = bufferedBinaryReader;
            }
            vigObject.DAT_4A = GameManager.instance.timer;
            if ((param3 & 1) != 0 && (short)configContainer.previous != -1)
            {
                VigObject vigObject2 = vigObject.child = FUN_2C17C(configContainer.previous, param4, param3);
                if (vigObject2 != null)
                {
                    vigObject2.parent = vigObject;
                    vigObject.child.ApplyTransformation();
                }
            }
            if ((param3 & 2) == 0 && (short)configContainer.next != -1)
            {
                VigObject vigObject2 = vigObject.child2 = FUN_2C17C(configContainer.next, param4, param3 | 0x21);
                if (vigObject2 != null)
                {
                    vigObject2.parent = vigObject;
                    vigObject.child2.ApplyTransformation();
                }
            }
        }
        return vigObject;
    }

    public VigObject FUN_2C17C_2(ushort param1, Type param2, uint param3)
    {
        ConfigContainer configContainer = configContainers[param1];
        VigObject vigObject;
        if ((short)configContainer.flag < 0 || (255 < (short)configContainer.objID && (param3 & 0x20) != 0))
        {
            vigObject = (((param3 & 1) != 0 && (short)configContainer.previous != -1) ? FUN_2C17C_2(configContainer.previous, typeof(Body), param3) : null);
        }
        else
        {
            vigObject = FUN_2BF44(configContainer, param2);
            vigObject.DAT_1A = (short)param1;
            vigObject.id = (short)configContainer.objID;
            if ((param3 & 8) == 0)
            {
                vigObject.vAnim = null;
            }
            else
            {
                byte[] animations = xobf.animations;
                BufferedBinaryReader bufferedBinaryReader = null;
                if (animations.Length != 0)
                {
                    bufferedBinaryReader = new BufferedBinaryReader(animations);
                    int num = bufferedBinaryReader.ReadInt32(param1 * 4 + 4);
                    if (num != 0)
                    {
                        bufferedBinaryReader.Seek(num, SeekOrigin.Begin);
                    }
                    else
                    {
                        bufferedBinaryReader = null;
                    }
                }
                vigObject.vAnim = bufferedBinaryReader;
            }
            vigObject.DAT_4A = GameManager.instance.timer;
            if ((param3 & 1) != 0 && (short)configContainer.previous != -1)
            {
                VigObject vigObject2 = vigObject.child = FUN_2C17C_2(configContainer.previous, typeof(Body), param3);
                if (vigObject2 != null)
                {
                    vigObject2.parent = vigObject;
                    vigObject.child.ApplyTransformation();
                }
            }
            if ((param3 & 2) == 0 && (short)configContainer.next != -1)
            {
                VigObject vigObject2 = vigObject.child2 = FUN_2C17C_2(configContainer.next, typeof(Body), param3 | 0x21);
                if (vigObject2 != null)
                {
                    vigObject2.parent = vigObject;
                    vigObject.child2.ApplyTransformation();
                }
            }
        }
        return vigObject;
    }

    public VigObject FUN_2C17C_3(ushort param1, Type param2, uint param3)
    {
        ConfigContainer configContainer = configContainers[param1];
        VigObject vigObject;
        if ((short)configContainer.flag < 0 || (255 < (short)configContainer.objID && (param3 & 0x20) != 0))
        {
            vigObject = (((param3 & 1) != 0 && (short)configContainer.previous != -1) ? FUN_2C17C(configContainer.previous, param2, param3) : null);
        }
        else
        {
            vigObject = FUN_2BF44(configContainer, param2);
            vigObject.DAT_1A = (short)param1;
            vigObject.id = (short)configContainer.objID;
            if ((param3 & 8) == 0)
            {
                vigObject.vAnim = null;
            }
            else
            {
                byte[] animations = xobf.animations;
                BufferedBinaryReader bufferedBinaryReader = null;
                if (animations.Length != 0)
                {
                    bufferedBinaryReader = new BufferedBinaryReader(animations);
                    int num = bufferedBinaryReader.ReadInt32(param1 * 4 + 4);
                    if (num != 0)
                    {
                        bufferedBinaryReader.Seek(num, SeekOrigin.Begin);
                    }
                    else
                    {
                        bufferedBinaryReader = null;
                    }
                }
                vigObject.vAnim = bufferedBinaryReader;
            }
            vigObject.DAT_4A = GameManager.instance.timer;
            if ((param3 & 1) != 0 && (short)configContainer.previous != -1)
            {
                VigObject vigObject2 = vigObject.child = FUN_2C17C(configContainer.previous, typeof(VigObject), param3);
                if (vigObject2 != null)
                {
                    vigObject2.parent = vigObject;
                    vigObject.child.ApplyTransformation();
                }
            }
            if ((param3 & 2) == 0 && (short)configContainer.next != -1)
            {
                VigObject vigObject2 = vigObject.child2 = FUN_2C17C(configContainer.next, typeof(VigObject), param3 | 0x21);
                if (vigObject2 != null)
                {
                    vigObject2.parent = vigObject;
                    vigObject.child2.ApplyTransformation();
                }
            }
        }
        return vigObject;
    }

    public VigObject FUN_2C17C(ushort param1, Type param2, uint param3, Dictionary<int, Type> param4)
    {
        ConfigContainer configContainer = configContainers[param1];
        VigObject vigObject;
        if ((short)configContainer.flag < 0 || (255 < (short)configContainer.objID && (param3 & 0x20) != 0))
        {
            vigObject = (((param3 & 1) != 0 && (short)configContainer.previous != -1) ? ((!param4.ContainsKey(configContainer.previous)) ? FUN_2C17C(configContainer.previous, typeof(VigObject), param3, param4) : FUN_2C17C(configContainer.previous, param4[configContainer.previous], param3, param4)) : null);
        }
        else
        {
            vigObject = FUN_2BF44(configContainer, param2);
            vigObject.DAT_1A = (short)param1;
            vigObject.id = (short)configContainer.objID;
            if ((param3 & 8) == 0)
            {
                vigObject.vAnim = null;
            }
            else
            {
                byte[] animations = xobf.animations;
                BufferedBinaryReader bufferedBinaryReader = null;
                if (animations.Length != 0)
                {
                    bufferedBinaryReader = new BufferedBinaryReader(animations);
                    int num = bufferedBinaryReader.ReadInt32(param1 * 4 + 4);
                    if (num != 0)
                    {
                        bufferedBinaryReader.Seek(num, SeekOrigin.Begin);
                    }
                    else
                    {
                        bufferedBinaryReader = null;
                    }
                }
                vigObject.vAnim = bufferedBinaryReader;
            }
            vigObject.DAT_4A = GameManager.instance.timer;
            if ((param3 & 1) != 0 && (short)configContainer.previous != -1)
            {
                VigObject vigObject2 = vigObject.child = ((!param4.ContainsKey(configContainer.previous)) ? FUN_2C17C(configContainer.previous, typeof(VigObject), param3, param4) : FUN_2C17C(configContainer.previous, param4[configContainer.previous], param3, param4));
                if (vigObject2 != null)
                {
                    vigObject2.parent = vigObject;
                    vigObject.child.ApplyTransformation();
                }
            }
            if ((param3 & 2) == 0 && (short)configContainer.next != -1)
            {
                VigObject vigObject2 = vigObject.child2 = ((!param4.ContainsKey(configContainer.next)) ? FUN_2C17C(configContainer.next, typeof(VigObject), param3 | 0x21, param4) : FUN_2C17C(configContainer.next, param4[configContainer.next], param3 | 0x21, param4));
                if (vigObject2 != null)
                {
                    vigObject2.parent = vigObject;
                    vigObject.child2.ApplyTransformation();
                }
            }
        }
        return vigObject;
    }

    public VigObject FUN_2C17C(ushort param1, Dictionary<int, Type> param2, uint param3)
    {
        ConfigContainer configContainer = configContainers[param1];
        VigObject vigObject;
        if ((short)configContainer.flag < 0 || (255 < (short)configContainer.objID && (param3 & 0x20) != 0))
        {
            vigObject = (((param3 & 1) != 0 && (short)configContainer.previous != -1) ? FUN_2C17C(configContainer.previous, param2, param3) : null);
        }
        else
        {
            vigObject = ((!param2.ContainsKey(param1)) ? FUN_2BF44(configContainer, typeof(VigObject)) : FUN_2BF44(configContainer, param2[param1]));
            vigObject.DAT_1A = (short)param1;
            vigObject.id = (short)configContainer.objID;
            if ((param3 & 8) == 0)
            {
                vigObject.vAnim = null;
            }
            else
            {
                byte[] animations = xobf.animations;
                BufferedBinaryReader bufferedBinaryReader = null;
                if (animations.Length != 0)
                {
                    bufferedBinaryReader = new BufferedBinaryReader(animations);
                    int num = bufferedBinaryReader.ReadInt32(param1 * 4 + 4);
                    if (num != 0)
                    {
                        bufferedBinaryReader.Seek(num, SeekOrigin.Begin);
                    }
                    else
                    {
                        bufferedBinaryReader = null;
                    }
                }
                vigObject.vAnim = bufferedBinaryReader;
            }
            vigObject.DAT_4A = GameManager.instance.timer;
            if ((param3 & 1) != 0 && (short)configContainer.previous != -1)
            {
                VigObject vigObject2 = vigObject.child = FUN_2C17C(configContainer.previous, param2, param3);
                if (vigObject2 != null)
                {
                    vigObject2.parent = vigObject;
                    vigObject.child.ApplyTransformation();
                }
            }
            if ((param3 & 2) == 0 && (short)configContainer.next != -1)
            {
                VigObject vigObject2 = vigObject.child2 = FUN_2C17C(configContainer.next, param2, param3 | 0x21);
                if (vigObject2 != null)
                {
                    vigObject2.parent = vigObject;
                    vigObject.child2.ApplyTransformation();
                }
            }
        }
        return vigObject;
    }

    public ConfigContainer FUN_2C534(ushort param1, ushort param2)
    {
        if (param1 != ushort.MaxValue)
        {
            uint num = param1;
            do
            {
                ConfigContainer configContainer = configContainers[(int)num];
                if (configContainer.flag == param2)
                {
                    return configContainer;
                }
                num = configContainer.previous;
            }
            while (num != 65535);
        }
        return null;
    }

    public int GetContainerIndex(int start, int id)
    {
        int num = 0;
        int num2 = configContainers[start].next;
        ConfigContainer configContainer = configContainers[num2];
        do
        {
            if (num == id)
            {
                return num2;
            }
            num2 = configContainers[num2].previous;
            ConfigContainer configContainer2 = configContainers[num2];
            num++;
        }
        while (num2 != 65535);
        return -1;
    }

    public ConfigContainer FUN_2C590(int int1, int int2)
    {
        int1 &= 0xFFFF;
        int num = (int1 << 3) - int1 << 2;
        return FUN_2C534(configContainers[num / 28].next, int2 & 0xFFFF);
    }

    public ConfigContainer FUN_2C6D0(ConfigContainer container, int int2)
    {
        return FUN_2C638(container.next, int2 & 0xFFFF);
    }

    public ConfigContainer FUN_2C5CC(ConfigContainer container, int int2)
    {
        return FUN_2C534(container.next, int2 & 0xFFFF);
    }

    public int FUN_2C73C(ConfigContainer container)
    {
        int num = configContainers.IndexOf(container) * 28;
        int num2 = (num << 3) + num;
        int num3 = num2 << 6;
        int num4 = (num2 + num3 << 3) + num;
        num3 = num4 << 15;
        return -((num4 + num3 << 3) + num) >> 2;
    }

    public ConfigContainer FUN_2C638(int int1, int int2)
    {
        int2 &= 0xFFFF;
        if (int1 != 65535)
        {
            do
            {
                int num = int1 & 0xFFFF;
                int num2 = (num << 3) - num << 2;
                num2 /= 28;
                if (configContainers[num2].objID == int2)
                {
                    return configContainers[num2];
                }
                int1 = configContainers[num2].previous;
            }
            while (int1 != 65535);
        }
        return null;
    }

    private ConfigContainer FUN_2C534(int int1, int int2)
    {
        int2 &= 0xFFFF;
        if (int1 != 65535)
        {
            do
            {
                int num = int1 & 0xFFFF;
                int num2 = (num << 3) - num << 2;
                num2 /= 28;
                if (configContainers[num2].flag == int2)
                {
                    return configContainers[num2];
                }
                int1 = configContainers[num2].previous;
            }
            while (int1 != 65535);
        }
        return null;
    }

    public VigObject FUN_2BF44(ConfigContainer container, Type component)
    {
        GameObject gameObject = new GameObject();
        VigObject vigObject = gameObject.AddComponent(component) as VigObject;
        ushort flag = container.flag;
        vigObject.flags = (uint)((((flag & 0x800) != 0) ? 1 : 0) << 4);
        vigObject.vr = container.v3_2;
        vigObject.screen = container.v3_1;
        vigObject.vData = xobf;
        if ((flag & 0x7FF) < 2047)
        {
            VigMesh vigMesh = vigObject.vMesh = xobf.FUN_1FD18(gameObject, (uint)(flag & 0x7FF), init: true);
        }
        if (-1 < container.colliderID)
        {
            VigCollider vigCollider = xobf.cbbList[container.colliderID];
            vigObject.vCollider = new VigCollider(vigCollider.buffer);
        }
        return vigObject;
    }

    private void Awake()
    {
    }

    private void Start()
    {
    }

    private void Update()
    {
    }
}

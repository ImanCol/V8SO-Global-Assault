using UnityEngine;

public class Flash : VigObject
{
    public Color32 DAT_34;
    public int DAT_3C;
    protected override void Start()
    {
    }

    protected override void Update()
    {
    }

    public override uint UpdateW(int arg1, int arg2)
    {
        int num3 = 0;
        int num4 = 0;
        int num5 = 0;
        uint result;
        if (arg1 == 0 && arg2 != 0)
        {
            int num = DAT_3C - 128;
            if (num < 0)
            {
                num = -num;
            }
            num = 128 - num;
            int num2 = num * DAT_34.b;
            if (num2 < 0)
            {
                num2 += 127;
            }
            if (UIManager.instance.flash == null)
            {
                if (Debugstate == 1)
                {
                    Debug.Log(debugMessage1);
                    Debugstate = 0;
                }
            }
            else
            {
                num3 = ((Color32)UIManager.instance.flash.color).b + (num2 >> 7);

            }
            num2 = 255;
            if (num3 < 255)
            {
                num2 = num3;
            }
            num3 = num * DAT_34.g;
            if (num3 < 0)
            {
                num3 += 127;
            }
            if (UIManager.instance.flash != null)
            {
                num4 = ((Color32)UIManager.instance.flash.color).g + (num3 >> 7);
            }

            num3 = 255;
            if (num4 < 255)
            {
                num3 = num4;
            }
            num *= DAT_34.r;
            Color32 c = default(Color32);
            c.b = (byte)num2;
            c.g = (byte)num3;
            if (num < 0)
            {
                num += 127;
            }
            if (UIManager.instance.flash != null)
            {
                num5 = ((Color32)UIManager.instance.flash.color).r + (num >> 7);
            }
            c.r = byte.MaxValue;
            if (num5 < 255)
            {
                c.r = (byte)num5;
            }
            c.a = byte.MaxValue;
            if (UIManager.instance.flash != null)
            {
                UIManager.instance.flash.color = c;

            }
            num = (DAT_3C += DAT_34.a * arg2);
            result = 0u;
            if (255 < num)
            {
                GameManager.instance.FUN_309A0(this);
                result = uint.MaxValue;
            }
        }
        else
        {
            result = 0u;
        }
        return result;
    }
    int Debugstate = 1;
    string debugMessage1 = "Objeto Flash de UI Manager no asignado en Canvas. No podras ver el resplandor de ciertas acciones";
}
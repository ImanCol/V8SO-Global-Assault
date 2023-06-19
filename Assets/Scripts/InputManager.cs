using UnityEngine;
using Rewired;
using Beebyte;
using Beebyte.Obfuscator;

public enum _CONTROLLER_TYPE
{
    None,
    Unsupported,
    JoypadDigital,
    SteeringWheel,
    JoystickAnalog,
    JoypadAnalog,
}
public enum _CONTROLLER_ACTIONS
{
    None,
    CameraReset,
    SteerRight,
    SteerLeft,
    HandBrake,
    BrakeAndReverse,
    Accelerate,
    ViewSelect,
    RearView,
    TargetSelect,
    PrevWeapon,
    NextWeapon,
    Fire,
    MachineGun
}
public enum _CONTROLLER_STEERING
{
    None,
    Steer,
    AccelAndBreak,
    CameraOrbit,
    CameraDolly
}
public class Controller
{
    public _CONTROLLER_TYPE type;
    public short delay;
    public byte[] sequence;
    public byte actions;
    public byte steering;
    public byte DAT_A;
    public byte DAT_B;
    public byte buttons;
    public byte dpad;
    public byte DAT_E;
    public byte DAT_F;
    public byte[] stick;
    public byte[] DAT_14;
    public byte DAT_18;
    public byte DAT_19;
    public uint GetAxis()
    {
        return (uint)((DAT_B << 24) | (DAT_A << 16) | (steering << 8) | actions);
    }
}
public struct PSXInput
{
    public byte DAT_00; //0x00
    public byte DAT_01; //0x01
    public byte DAT_02; //0x02
    public byte DAT_03; //0x03
    public byte DAT_04; //0x04
    public byte DAT_05; //0x05
    public byte DAT_06; //0x06
    public byte DAT_07; //0x07
}

[SkipRename]
public class InputManager : MonoBehaviour
{
    public static InputManager instance;
    public static Controller[] controllers;
    public static PSXInput[,] inputs;
    public static byte[,] axisData;
    public static int[] turnRadius;
    public _CONTROLLER_ACTIONS[] controllerActions;
    public _CONTROLLER_STEERING[] controllerSteerings;
    private Player player;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            player = ReInput.players.GetPlayer(0);
        }
        controllers = new Controller[2];
        inputs = new PSXInput[2, 9];
        for (int i = 0; i < controllers.Length; i++)
        {
            controllers[i] = new Controller();
            controllers[i].sequence = new byte[4];
            controllers[i].stick = new byte[4];
            controllers[i].DAT_14 = new byte[4];
        }
        axisData = new byte[2, 1024];
        int num = 0;
        int num2;
        do
        {
            num2 = 0;
            int num3 = num * 256;
            do
            {
                axisData[0, num3] = (byte)num2;
                axisData[1, num3] = (byte)num2;
                num2++;
                num3 = num2 + num * 256;
            }
            while (num2 < 256);
            num++;
            num3 = 0;
        }
        while (num < 4);
        turnRadius = new int[256];
        num2 = -128;
        int num4 = 0;
        do
        {
            int num5 = num2 * num2 * num2;
            num2++;
            turnRadius[num4] = num5 / 3072;
            num4++;
        }
        while (num2 < 128);
    }
    private void Start()
    {
    }
    private void Update()
    {
        inputs[0, 0].DAT_00 = 0;
        inputs[0, 0].DAT_01 = 115;
        inputs[0, 0].DAT_02 = byte.MaxValue;
        inputs[0, 0].DAT_03 = byte.MaxValue;
        inputs[0, 0].DAT_04 = 128;
        inputs[0, 0].DAT_05 = 128;
        inputs[0, 0].DAT_06 = 128;
        inputs[0, 0].DAT_07 = 128;
        if (player.GetButton("CROSS"))
        {
            inputs[0, 0].DAT_03 &= 191;
        }
        if (player.GetButton("CIRCLE"))
        {
            inputs[0, 0].DAT_03 &= 223;
        }
        if (player.GetButton("SQUARE"))
        {
            inputs[0, 0].DAT_03 &= 127;
        }
        if (player.GetButton("TRIANGLE"))
        {
            inputs[0, 0].DAT_03 &= 239;
        }
        if (player.GetButton("R1"))
        {
            inputs[0, 0].DAT_03 &= 247;
        }
        if (player.GetButton("L1"))
        {
            inputs[0, 0].DAT_03 &= 251;
        }
        if (player.GetAxis("R2") > 0f)
        {
            inputs[0, 0].DAT_03 &= 253;
        }
        if (player.GetAxis("L2") > 0f)
        {
            inputs[0, 0].DAT_03 &= 254;
        }
        if (player.GetButton("DPAD UP"))
        {
            inputs[0, 0].DAT_02 &= 239;
        }
        if (player.GetButton("DPAD DOWN"))
        {
            inputs[0, 0].DAT_02 &= 191;
        }
        if (player.GetButton("DPAD RIGHT"))
        {
            inputs[0, 0].DAT_02 &= 223;
        }
        if (player.GetButton("DPAD LEFT"))
        {
            inputs[0, 0].DAT_02 &= 127;
        }
        if (player.GetButton("START"))
        {
            inputs[0, 0].DAT_02 &= 247;
        }
        if (player.GetButton("SELECT"))
        {
            inputs[0, 0].DAT_02 &= 254;
        }
        inputs[0, 0].DAT_04 = (byte)((int)(player.GetAxis("ANALOG RX") * 127f) + 127);
        inputs[0, 0].DAT_05 = (byte)((int)(0f - player.GetAxis("ANALOG RY") * 127f) + 127);
        inputs[0, 0].DAT_06 = (byte)((int)(player.GetAxis("ANALOG LX") * 127f) + 127);
        inputs[0, 0].DAT_07 = (byte)((int)(0f - player.GetAxis("ANALOG LY") * 127f) + 127);
        for (int i = 1; i < 9; i++)
        {
            inputs[0, i].DAT_00 = inputs[0, 0].DAT_00;
            inputs[0, i].DAT_01 = inputs[0, 0].DAT_01;
            inputs[0, i].DAT_02 = inputs[0, 0].DAT_02;
            inputs[0, i].DAT_03 = inputs[0, 0].DAT_03;
            inputs[0, i].DAT_04 = inputs[0, 0].DAT_04;
            inputs[0, i].DAT_05 = inputs[0, 0].DAT_05;
            inputs[0, i].DAT_06 = inputs[0, 0].DAT_06;
            inputs[0, i].DAT_07 = inputs[0, 0].DAT_07;
        }
    }

    private void FixedUpdate()
    {
        FUN_15540();
    }

    private void FUN_15540()
    {
        if (GameManager.instance.DAT_D08 != GameManager.instance.DAT_CF8)
        {
            GameManager.instance.DAT_D08 = (byte)((GameManager.instance.DAT_D08 + 1) & 7);
        }
        int num = GameManager.instance.DAT_D08 + 1;
        //int num = 1;
        for (int i = 0; i < 2; i++)
        {
            uint num2 = 0u;
            if (inputs[i, num].DAT_00 != byte.MaxValue)
            {
                num2 = (uint)(~((inputs[i, num].DAT_02 << 8) | inputs[i, num].DAT_03));
            }
            controllers[i].type = GetControllerType(i);
            uint num3;
            if (controllers[i].type == _CONTROLLER_TYPE.SteeringWheel)
            {
                num3 = (uint)(((inputs[i, num].DAT_05 == byte.MaxValue) ? 1 : 0) << 6);
                if (inputs[i, num].DAT_07 == byte.MaxValue)
                {
                    num3 |= 4;
                }
                num2 = ((inputs[i, num].DAT_06 != byte.MaxValue) ? ((num2 & 0xFFFF) | num3) : ((num2 & 0xFFFF) | 0x80 | num3));
            }
            num3 = (uint)((int)(num2 & 0xFFFF) | (((int)(num2 & 0xFFFF) & ~GameManager.instance.DAT_CF0[i]) << 16));
            GameManager.instance.DAT_D18[i] = (byte)num3;
            GameManager.instance.DAT_D19[i] = (byte)(num3 >> 8);
            GameManager.instance.DAT_D1A[i] = (byte)(num3 >> 16);
            GameManager.instance.DAT_D1B[i] = (byte)(num3 >> 24);
            controllers[i].buttons = (byte)num3;
            controllers[i].dpad = (byte)(num3 >> 8);
            controllers[i].DAT_E = (byte)(num3 >> 16);
            controllers[i].DAT_F = (byte)(num3 >> 24);
            GameManager.instance.DAT_CF0[i] = (ushort)num2;
            num2 = FUN_150B4((uint)((int)num3 & -134219777), GameManager.DAT_637DC[i, (byte)controllers[i].type], GameManager.DAT_637E0[i, (byte)controllers[i].type]);
            controllers[i].DAT_18 = (byte)(controllers[i].actions & ~(byte)num2);
            controllers[i].DAT_19 = (byte)(controllers[i].steering & ~(byte)(num2 >> 8));
            controllers[i].actions = (byte)num2;
            controllers[i].steering = (byte)(num2 >> 8);
            controllers[i].DAT_A = (byte)(num2 >> 16);
            controllers[i].DAT_B = (byte)(num2 >> 24);
            GameManager.instance.DAT_D1B[i] = (byte)((GameManager.DAT_637E0[i, (byte)controllers[i].type] >> 12) & 1);
            num2 = (uint)((int)num3 & -268435456);
            if (_CONTROLLER_TYPE.JoypadDigital < controllers[i].type)
            {
                ushort num4 = GameManager.instance.DAT_08[i, (byte)controllers[i].type];
                controllers[i].DAT_14[0] = controllers[i].stick[0];
                controllers[i].DAT_14[1] = controllers[i].stick[1];
                controllers[i].DAT_14[2] = controllers[i].stick[2];
                controllers[i].DAT_14[3] = controllers[i].stick[3];
                controllers[i].stick[0] = 128;
                controllers[i].stick[1] = 128;
                controllers[i].stick[2] = 128;
                controllers[i].stick[3] = 128;
                if ((num4 & 0xF) != 0)
                {
                    controllers[i].stick[(num4 & 0xF) - 1] = axisData[i, inputs[i, num].DAT_04];
                }
                if (((num4 >> 4) & 0xF) != 0)
                {
                    controllers[i].stick[((num4 >> 4) & 0xF) - 1] = axisData[i, inputs[i, num].DAT_05];
                }
                if (((num4 >> 8) & 0xF) != 0)
                {
                    controllers[i].stick[((num4 >> 8) & 0xF) - 1] = axisData[i, inputs[i, num].DAT_06];
                }
                if (num4 >> 12 != 0)
                {
                    controllers[i].stick[(num4 >> 12) - 1] = axisData[i, inputs[i, num].DAT_07];
                }
                num3 = 0u;
                if (inputs[i, num].DAT_06 - 128 < -96)
                {
                    num3 = (uint)((((GameManager.instance.DAT_CF4[i, 0] - 128 < -96) ? 1 : 0) ^ 1) << 31);
                }
                if (96 < inputs[i, num].DAT_06 - 128 && GameManager.instance.DAT_CF4[i, 0] - 128 < 97)
                {
                    num3 |= 0x20000000;
                }
                if (inputs[i, num].DAT_07 - 128 < -96 && -97 < GameManager.instance.DAT_CF4[i, 1] - 128)
                {
                    num3 |= 0x10000000;
                }
                if (96 < inputs[i, num].DAT_07 - 128 && GameManager.instance.DAT_CF4[i, 1] - 128 < 97)
                {
                    num2 |= 0x40000000;
                }
                num2 |= num3;
                GameManager.instance.DAT_CF4[i, 0] = inputs[i, num].DAT_06;
                GameManager.instance.DAT_CF4[i, 1] = inputs[i, num].DAT_07;
            }
            if (num2 == 0)
            {
                short delay = controllers[i].delay;
                if (controllers[i].delay != 0)
                {
                    controllers[i].delay = (short)(delay - 1);
                    if (delay == 1)
                    {
                        controllers[i].sequence[0] = 0;
                        controllers[i].sequence[1] = 0;
                        controllers[i].sequence[2] = 0;
                        controllers[i].sequence[3] = 0;
                    }
                }
            }
            else
            {
                num2 = (uint)Utilities.LeadingZeros((int)(num2 >> 1));
                uint num5 = (uint)((((controllers[i].sequence[3] << 24) | (controllers[i].sequence[2] << 16) | (controllers[i].sequence[1] << 8) | controllers[i].sequence[0]) << 4) | (int)num2);
                controllers[i].sequence[0] = (byte)num5;
                controllers[i].sequence[1] = (byte)(num5 >> 8);
                controllers[i].sequence[2] = (byte)(num5 >> 16);
                controllers[i].sequence[3] = (byte)(num5 >> 24);
                controllers[i].delay = 20;
            }
        }
        int num6 = (GameManager.instance.DAT_D18[0] << 24) | (GameManager.instance.DAT_D19[0] << 16) | (GameManager.instance.DAT_D1A[0] << 8) | GameManager.instance.DAT_D1B[0];
        int num7 = (GameManager.instance.DAT_D18[1] << 24) | (GameManager.instance.DAT_D19[1] << 16) | (GameManager.instance.DAT_D1A[1] << 8) | GameManager.instance.DAT_D1B[1];
        GameManager.instance.DAT_CFC[0] = (byte)(num6 | num7);
        GameManager.instance.DAT_CFC[1] = (byte)((num6 | num7) >> 8);
        GameManager.instance.DAT_CFC[2] = (byte)((num6 | num7) >> 16);
        GameManager.instance.DAT_CFC[3] = (byte)((num6 | num7) >> 24);
    }

    private _CONTROLLER_TYPE GetControllerType(int param1)
    {
        if (inputs[param1, 0].DAT_00 != 0)
        {
            return _CONTROLLER_TYPE.None;
        }
        switch (inputs[param1, 0].DAT_01)
        {
            case 83:
                return _CONTROLLER_TYPE.JoystickAnalog;
            case 35:
                return _CONTROLLER_TYPE.SteeringWheel;
            case 65:
                return _CONTROLLER_TYPE.JoypadDigital;
            case 115:
                return _CONTROLLER_TYPE.JoypadAnalog;
            default:
                return _CONTROLLER_TYPE.Unsupported;
        }
    }

    private uint FUN_150B4(uint param1, uint param2, uint param3)
    {
        uint num = 0u;
        if (param1 != 0)
        {
            uint num2 = param1 & 0x10001;
            do
            {
                num |= num2 << (int)(param2 & 0xF);
                param2 = ((param2 >> 4) | (param3 << 28));
                param3 >>= 4;
                num2 = param1 >> 1;
                param1 = (uint)((int)num2 & -32769);
                num2 &= 0x10001;
            }
            while (param1 != 0);
        }
        return num;
    }
}
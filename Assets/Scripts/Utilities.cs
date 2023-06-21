using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using UnityEngine;
using Unity.Burst;
#if UNITY_EDITOR
using UnityEditor;
#endif

//Bastantes datos para optimizar?
[BurstCompile]
[Serializable]
public static class Utilities
{
    public static ushort DAT_10390 = 0;

    public static KeyValuePair<string, Type>[][] commonTypes = new KeyValuePair<string, Type>[1][]
    {
        new KeyValuePair<string, Type>[17]
        {
            new KeyValuePair<string, Type>("SunLensFlare", typeof(SunLensFlare)),
            new KeyValuePair<string, Type>("PU_WeaponUpgrade", typeof(Pickup)),
            new KeyValuePair<string, Type>("PU_RadarJammer", typeof(Pickup)),
            new KeyValuePair<string, Type>("PU_Shield", typeof(Pickup)),
            new KeyValuePair<string, Type>("PU_Health", typeof(Pickup)),
            new KeyValuePair<string, Type>("I_RocktL", typeof(Pickup)),
            new KeyValuePair<string, Type>("I_MisslL", typeof(Pickup)),
            new KeyValuePair<string, Type>("I_Cannon", typeof(Pickup)),
            new KeyValuePair<string, Type>("I_Mortar", typeof(Pickup)),
            new KeyValuePair<string, Type>("I_MineDr", typeof(Pickup)),
            new KeyValuePair<string, Type>("I_FlThrower", typeof(Pickup)),
            new KeyValuePair<string, Type>("I_Special", typeof(Pickup)),
            new KeyValuePair<string, Type>("I_Surprise", typeof(Pickup)),
            new KeyValuePair<string, Type>("I_Hover", typeof(Pickup)),
            new KeyValuePair<string, Type>("I_Float", typeof(Pickup)),
            new KeyValuePair<string, Type>("I_Ski", typeof(Pickup)),
            new KeyValuePair<string, Type>("Placeholder", typeof(Placeholder))
        }
    };

    public static string[] DAT_310 = new string[18]
    {
        "Wonderwagon",
        "Thunderbolt",
        "Dakota Stunt Cycle",
        "Samson Tow Truck",
        "Livingston Truck",
        "Xanadu RV",
        "Palomino XIII",
        "El Guerrero",
        "Blue Burro Bus",
        "Excelsior Stretch",
        "Tsunami",
        "Marathon",
        "Moon Trekker",
        "Grubb Dual Loader",
        "Chrono Stinger",
        "Vertigo",
        "Goliath Halftrack",
        "Wapiti 4WD"
    };

    public static KeyValuePair<string, Type>[][] levelTypes =
    {
        new KeyValuePair<string, Type>[]
        {
            new KeyValuePair<string, Type>("Police", typeof(Police)),
            new KeyValuePair<string, Type>("Sign_SpeedLimit", typeof(SpeedLimit)),
            new KeyValuePair<string, Type>("Ant", typeof(Ant)),
            new KeyValuePair<string, Type>("Observatory", typeof(Observatory)),
            new KeyValuePair<string, Type>("MineEntry", typeof(MineEntry)),
            new KeyValuePair<string, Type>("Billboard", typeof(Billboard)),
            new KeyValuePair<string, Type>("ServiceStation", typeof(ServiceStation)),
            new KeyValuePair<string, Type>("DonutShop", typeof(DonutShop)),
            new KeyValuePair<string, Type>("Projectionbooth", typeof(ProjectionBooth)),
            new KeyValuePair<string, Type>("Wall", typeof(Wall)),
            new KeyValuePair<string, Type>("Gondola", typeof(Gondola)),
            new KeyValuePair<string, Type>("DragStick", typeof(DragStick)),
            new KeyValuePair<string, Type>("GondPole", typeof(GondPole)),
            new KeyValuePair<string, Type>("GondStation", typeof(GondStation)),
            new KeyValuePair<string, Type>("LiftGate", typeof(LiftGate)),
            new KeyValuePair<string, Type>("LiftStation", typeof(LiftStation)),
            new KeyValuePair<string, Type>("Hotel", typeof(Hotel)),
            new KeyValuePair<string, Type>("SkiJump", typeof(SkiJump)),
            new KeyValuePair<string, Type>("BobsledGate", typeof(Bobsled)),
            new KeyValuePair<string, Type>("SlalomG_2", typeof(Slalom)),
            new KeyValuePair<string, Type>("SlalomG_1", typeof(Slalom2)),
            new KeyValuePair<string, Type>("StartSign", typeof(StartSign)),
            new KeyValuePair<string, Type>("FinishSign", typeof(FinishSign)),
            new KeyValuePair<string, Type>("Scoreboard", typeof(Scoreboard)),
            new KeyValuePair<string, Type>("TestThruster", typeof(TestThruster)),
            new KeyValuePair<string, Type>("NASA", typeof(NASA)),
            new KeyValuePair<string, Type>("LaunchVehicle", typeof(LaunchVehicle)),
            new KeyValuePair<string, Type>("WindTunnel", typeof(WindTunnel)),
            new KeyValuePair<string, Type>("GuardTower", typeof(GuardTower)),
            new KeyValuePair<string, Type>("Fence", typeof(Fence)),
            new KeyValuePair<string, Type>("Sharky", typeof(Sharky)),
            new KeyValuePair<string, Type>("LaunchEntry", typeof(LaunchEntry)),
            new KeyValuePair<string, Type>("Gantry", typeof(Gantry)),
            new KeyValuePair<string, Type>("Bridge_1", typeof(Bridge)),
            new KeyValuePair<string, Type>("Cage", typeof(Cage)),
            new KeyValuePair<string, Type>("LockWheel", typeof(LockWheel)),
            new KeyValuePair<string, Type>("LockDam", typeof(LockDam)),
            new KeyValuePair<string, Type>("GATOR_I", typeof(Aligator)),
            new KeyValuePair<string, Type>("Tomb_1", typeof(Tomb)),
            new KeyValuePair<string, Type>("Tomb_2", typeof(Tomb)),
            new KeyValuePair<string, Type>("Tomb_3", typeof(Tomb)),
            new KeyValuePair<string, Type>("Mansion", typeof(Mansion)),
            new KeyValuePair<string, Type>("Mausoleum", typeof(Mausoleum)),
            new KeyValuePair<string, Type>("TransferBooth", typeof(TransferBooth)),
            new KeyValuePair<string, Type>("Transformer", typeof(Transformer)),
            new KeyValuePair<string, Type>("NSwitch", typeof(NSwitch)),
            new KeyValuePair<string, Type>("TurbineShock", typeof(TurbineShock)),
            new KeyValuePair<string, Type>("Turbine", typeof(Turbine)),
            new KeyValuePair<string, Type>("ForkLift", typeof(ForkLift)),
            new KeyValuePair<string, Type>("Bridge_L", typeof(BridgeL)),
            new KeyValuePair<string, Type>("Reactor", typeof(Reactor)),
            new KeyValuePair<string, Type>("ContBuilding", typeof(ContBuilding)),
            new KeyValuePair<string, Type>("Tunnel", typeof(Tunnel)),
            new KeyValuePair<string, Type>("SheetMetalDrum", typeof(SheetMetalDrum)),
            new KeyValuePair<string, Type>("MoltenSteel", typeof(MoltenSteel)),
            new KeyValuePair<string, Type>("Furnace3", typeof(Furnace)),
            new KeyValuePair<string, Type>("IngPlant_LCap", typeof(IngPlant)),
            new KeyValuePair<string, Type>("Cauldron", typeof(Cauldron)),
            new KeyValuePair<string, Type>("Crane", typeof(Crane)),
            new KeyValuePair<string, Type>("Train_Engine", typeof(TrainEngine)),
            new KeyValuePair<string, Type>("Train_Hopper", typeof(TrainHopper)),
            new KeyValuePair<string, Type>("Train_Boxcar", typeof(TrainBoxcar)),
            new KeyValuePair<string, Type>("RailSwitch", typeof(RailSwitch)),
            new KeyValuePair<string, Type>("BridgeS", typeof(BridgeS)),
            new KeyValuePair<string, Type>("BridgeL", typeof(BridgeS)),
            new KeyValuePair<string, Type>("PipeEnd", typeof(Pipe)),
            new KeyValuePair<string, Type>("Glacier_Small", typeof(GlacierSmall)),
            new KeyValuePair<string, Type>("Glacier", typeof(Glacier)),
            new KeyValuePair<string, Type>("OilPlatform", typeof(OilPlatform)),
            new KeyValuePair<string, Type>("SiloRamp", typeof(SiloRamp)),
            new KeyValuePair<string, Type>("SiloCatwalk", typeof(Catwalk)),
            new KeyValuePair<string, Type>("Orca", typeof(Orca)),
            new KeyValuePair<string, Type>("CraneSmall", typeof(CraneSmall)),
            new KeyValuePair<string, Type>("Buoy", typeof(Buoy)),
            new KeyValuePair<string, Type>("weighSign", typeof(WeighSign)),
            new KeyValuePair<string, Type>("Warehouse_1", typeof(Warehouse)),
            new KeyValuePair<string, Type>("Lighthouse", typeof(Lighthouse)),
            new KeyValuePair<string, Type>("DrawBridge", typeof(DrawBridge)),
            new KeyValuePair<string, Type>("Barge", typeof(Barge)),
            new KeyValuePair<string, Type>("CargoTruck", typeof(CargoTruck)),
            new KeyValuePair<string, Type>("CraneLarge", typeof(CraneLarge)),
            new KeyValuePair<string, Type>("Container_1", typeof(Container)),
            new KeyValuePair<string, Type>("OilRig", typeof(Rig)),
            new KeyValuePair<string, Type>("pipe_end_1", typeof(Pipe2)),
            new KeyValuePair<string, Type>("OilPump_1", typeof(Pump)),
            new KeyValuePair<string, Type>("sphere_1", typeof(Sphere)),
            new KeyValuePair<string, Type>("pipe-gateGATE_1", typeof(Pipe4)),
            new KeyValuePair<string, Type>("JTreeS_1", typeof(Destructible2)),
            new KeyValuePair<string, Type>("JTreeT_1", typeof(Destructible2)),
            new KeyValuePair<string, Type>("hanger_1", typeof(Hanger)),
            new KeyValuePair<string, Type>("control_tower_1", typeof(ControlTower)),
            new KeyValuePair<string, Type>("hanger_1_Door1", typeof(HangerDoor)),
            new KeyValuePair<string, Type>("Crane_1", typeof(Crane2)),
            new KeyValuePair<string, Type>("b17_1", typeof(B17)),
            new KeyValuePair<string, Type>("Shack_1", typeof(Shack)),
            new KeyValuePair<string, Type>("TBridge_1", typeof(Bridge2)),
            new KeyValuePair<string, Type>("M1_warehouse_1", typeof(Warehouse2)),
            new KeyValuePair<string, Type>("bonfire_1", typeof(Bonfire)),
            new KeyValuePair<string, Type>("Gallow_1", typeof(Gallow)),
            new KeyValuePair<string, Type>("M1_cactus_1", typeof(Destructible2)),
            new KeyValuePair<string, Type>("M1_cactus2_1", typeof(Destructible2)),
            new KeyValuePair<string, Type>("hotel_1", typeof(Gallow)),
            new KeyValuePair<string, Type>("M1depot_1", typeof(Gallow)),
            new KeyValuePair<string, Type>("M1train_engine_1", typeof(TrainEngine2)),
            new KeyValuePair<string, Type>("M1train_coalcar_1", typeof(Coalcar)),
            new KeyValuePair<string, Type>("M1train_flatbed_1", typeof(Flatbed)),
            new KeyValuePair<string, Type>("dustDevil", typeof(Tornado2)),
            new KeyValuePair<string, Type>("tumbleweed_1", typeof(Tumble)),
            new KeyValuePair<string, Type>("M1gaslight_1", typeof(Destructible2)),
            new KeyValuePair<string, Type>("smPole_1", typeof(Destructible2)),
            new KeyValuePair<string, Type>("Rain", typeof(Rain)),
            new KeyValuePair<string, Type>("SplashS_R", typeof(Splash)),
            new KeyValuePair<string, Type>("parking_meter_1", typeof(ParkingMeter)),
            new KeyValuePair<string, Type>("ArchTransf", typeof(Transformer2)),
            new KeyValuePair<string, Type>("transformer_1", typeof(Transformer3)),
            new KeyValuePair<string, Type>("tranformer_casing_1", typeof(Transformer3)),
            new KeyValuePair<string, Type>("PowePlant_L", typeof(PowerPlant)),
            new KeyValuePair<string, Type>("PowePlant_R", typeof(PowerPlant)),
            new KeyValuePair<string, Type>("Dam_Lever", typeof(Lever)),
            new KeyValuePair<string, Type>("PipeOut_1", typeof(Pipe5)),
            new KeyValuePair<string, Type>("barracade-lg_1", typeof(Barracade)),
            new KeyValuePair<string, Type>("Catwalk_1", typeof(Catwalk2)),
            new KeyValuePair<string, Type>("SplashS_R", typeof(Splash2)),
            new KeyValuePair<string, Type>("Windmill_1", typeof(Windmill)),
            new KeyValuePair<string, Type>("silo_1", typeof(Silo)),
            new KeyValuePair<string, Type>("WWave", typeof(Wave)),
            new KeyValuePair<string, Type>("pump_1", typeof(Pump3)),
            new KeyValuePair<string, Type>("crop_duster", typeof(CropDuster)),
            new KeyValuePair<string, Type>("tree_1", typeof(Destructible2)),
            new KeyValuePair<string, Type>("tree2_1", typeof(Destructible2)),
            new KeyValuePair<string, Type>("palm1_1", typeof(Palm)),
            new KeyValuePair<string, Type>("SplashS_R", typeof(Splash3)),
            new KeyValuePair<string, Type>("BurgerS_1", typeof(BurgerS)),
            new KeyValuePair<string, Type>("Burger_sign_1", typeof(BurgerSign)),
            new KeyValuePair<string, Type>("manhole_1", typeof(Manhole)),
            new KeyValuePair<string, Type>("blimp_1", typeof(Blimp)),
            new KeyValuePair<string, Type>("water_1", typeof(Water3)),
            new KeyValuePair<string, Type>("pelicana_1", typeof(Pelicana)),
            new KeyValuePair<string, Type>("saharan_1", typeof(Pelicana)),
            new KeyValuePair<string, Type>("parking_gate", typeof(ParkingGate)),
            new KeyValuePair<string, Type>("boulder_L", typeof(Boulder)),
            new KeyValuePair<string, Type>("BeamUp", typeof(Beamup)),
            new KeyValuePair<string, Type>("cement_barrier_1", typeof(Barrier)),
            new KeyValuePair<string, Type>("bridge_1", typeof(Bridge3)),
            new KeyValuePair<string, Type>("gondola_1", typeof(Gondola2)),
            new KeyValuePair<string, Type>("liftpole_1", typeof(Liftpole)),
            new KeyValuePair<string, Type>("liftstation_1", typeof(Liftstation)),
            new KeyValuePair<string, Type>("SnowFlake", typeof(Snow)),
            new KeyValuePair<string, Type>("snow_mach_1", typeof(SnowMach)),
            new KeyValuePair<string, Type>("stairs_1", typeof(Stairs)),
            new KeyValuePair<string, Type>("Ball_1", typeof(Ball)),
            new KeyValuePair<string, Type>("Ball_2", typeof(Ball)),
            new KeyValuePair<string, Type>("pine3_1", typeof(Pine)),
            new KeyValuePair<string, Type>("pine1_1", typeof(Destructible2)),
            new KeyValuePair<string, Type>("pine2_1", typeof(Destructible2)),
            new KeyValuePair<string, Type>("radar_1", typeof(Radar)),
            new KeyValuePair<string, Type>("fence_left", typeof(Fence2)),
            new KeyValuePair<string, Type>("fence_right", typeof(Fence2)),
            new KeyValuePair<string, Type>("turret_1", typeof(Turret)),
            new KeyValuePair<string, Type>("MSilo", typeof(Silo2)),
            new KeyValuePair<string, Type>("hq_1", typeof(HQ)),
            new KeyValuePair<string, Type>("hq_2", typeof(HQ2)),
            new KeyValuePair<string, Type>("hq_3", typeof(HQ3)),
            new KeyValuePair<string, Type>("aurora_1", typeof(Aurora)),
            new KeyValuePair<string, Type>("catwalk_1", typeof(Catwalk3)),
            new KeyValuePair<string, Type>("protoSaucer", typeof(Saucer2)),
            new KeyValuePair<string, Type>("M2_elevator_1", typeof(Elevator)),
            new KeyValuePair<string, Type>("M2_Conveyor", typeof(Conveyor)),
            new KeyValuePair<string, Type>("factory_1", typeof(Factory)),
            new KeyValuePair<string, Type>("factory_door", typeof(FactoryDoor))
        }
    };

    public static Type[] vehicleSpecials = new Type[18]
    {
        typeof(Tantrum),
        typeof(Revolver),
        typeof(GloryRockets),
        typeof(Hook),
        typeof(Trumpet),
        typeof(Invasion),
        typeof(MegaCollider),
        typeof(LemmingL),
        typeof(SmogPipe),
        typeof(Lightning),
        typeof(RiftBlade),
        typeof(Disco),
        typeof(Collector),
        typeof(Collector2),
        typeof(Freezer),
        typeof(StarPower),
        typeof(HellGate),
        typeof(Bird)
    };

    public static Dictionary<Type, _SPECIAL_INIT> specialInits = new Dictionary<Type, _SPECIAL_INIT>
    {
        {
            typeof(Revolver),
            Revolver.OnInitialize
        },
        {
            typeof(Collector),
            Collector.OnInitialize
        },
        {
            typeof(StarPower),
            StarPower.OnInitialize
        },
        {
            typeof(HellGate),
            HellGate.OnInitialize
        },
        {
            typeof(Bird),
            Bird.OnInitialize
        }
    };

    public static Dictionary<Type, _OBJECT_INIT> objectInits = new Dictionary<Type, _OBJECT_INIT>
    {
        {
            typeof(Police),
            Police.OnInitialize
        },
        {
            typeof(Ant),
            Ant.OnInitialize
        },
        {
            typeof(TestThruster),
            TestThruster.OnInitialize
        },
        {
            typeof(GuardTower),
            GuardTower.OnInitialize
        },
        {
            typeof(TurbineShock),
            TurbineShock.OnInitialize
        },
        {
            typeof(ForkLift),
            ForkLift.OnInitialize
        },
        {
            typeof(CraneSmall),
            CraneSmall.OnInitialize
        },
        {
            typeof(B17),
            B17.OnInitialize
        },
        {
            typeof(Boulder),
            Boulder.OnInitialize
        },
        {
            typeof(Rain),
            Rain.OnInitialize
        },
        {
            typeof(Splash),
            Splash.OnInitialize
        },
        {
            typeof(Splash2),
            Splash2.OnInitialize
        },
        {
            typeof(Splash3),
            Splash3.OnInitialize
        },
        {
            typeof(Snow),
            Snow.OnInitialize
        }
    };

    public static sbyte[] DAT_106E8 = new sbyte[12]
    {
        -1,
        -1,
        2,
        3,
        4,
        5,
        6,
        7,
        8,
        8,
        9,
        9
    };

    public static KeyValuePair<int, Type>[] weaponTypes = new KeyValuePair<int, Type>[7]
    {
        new KeyValuePair<int, Type>(-1, typeof(MGun)),
        new KeyValuePair<int, Type>(172, typeof(RocketL)),
        new KeyValuePair<int, Type>(184, typeof(MissileL)),
        new KeyValuePair<int, Type>(176, typeof(Cannon)),
        new KeyValuePair<int, Type>(179, typeof(Mortar)),
        new KeyValuePair<int, Type>(208, typeof(MineDr)),
        new KeyValuePair<int, Type>(206, typeof(FlameThrower))
    };

    public static byte[] DAT_10AE0 = new byte[256]
    {
        0,
        1,
        2,
        2,
        3,
        3,
        3,
        3,
        4,
        4,
        4,
        4,
        4,
        4,
        4,
        4,
        5,
        5,
        5,
        5,
        5,
        5,
        5,
        5,
        5,
        5,
        5,
        5,
        5,
        5,
        5,
        5,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        6,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        7,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8
    };

    public static uint FUN_14A54()
    {
        return (uint)(DateTime.Now.Millisecond | (DAT_10390 << 16));
    }

    public static Type FUN_14DAC(KeyValuePair<string, Type>[] pairs, string cmp)
    {
        for (int i = 0; i < pairs.Length; i++)
        {
            if (string.Compare(pairs[i].Key, cmp) == 0)
            {
                return pairs[i].Value;
            }
        }
        return null;
    }

    public static Type FUN_14E1C(int i, string cmp)
    {
        return FUN_14DAC(commonTypes[i], cmp);
    }

    public static VigObject FUN_31D30(Type param1, XOBF_DB param2, short param3, uint param4)
    {
        objectInits.TryGetValue(param1, out _OBJECT_INIT value);
        if (value != null)
        {
            VigObject vigObject = value(param2, param3, param4);
            if (vigObject != null)
            {
                return vigObject;
            }
        }
        if (param2 == null || param3 == -1)
        {
            VigObject obj = new GameObject().AddComponent(param1) as VigObject;
            obj.vData = param2;
            return obj;
        }
        return param2.ini.FUN_2C17C((ushort)param3, param1, param4);
    }

    public static VigObject FUN_31D30_2(Type param1, XOBF_DB param2, short param3, uint param4)
    {
        specialInits.TryGetValue(param1, out _SPECIAL_INIT value);
        if (value != null)
        {
            VigObject vigObject = value(param2, param3);
            if (vigObject != null)
            {
                return vigObject;
            }
        }
        if (param2 == null || param3 == -1)
        {
            VigObject obj = new GameObject().AddComponent(param1) as VigObject;
            obj.vData = param2;
            return obj;
        }
        return param2.ini.FUN_2C17C((ushort)param3, param1, param4);
    }

    public static VigObject FUN_31D30(_VEHICLE_INIT param1, XOBF_DB param2, ushort param3, uint param4)
    {
        if (param1 != null)
        {
            VigObject vigObject = param1(param2, param3, param4);
            if (vigObject != null)
            {
                return vigObject;
            }
            return null;
        }
        return null;
    }

    public static VigShadow FUN_4C44C(VigMesh param1, int param2, int param3, GameObject param4)
    {
        VigShadow vigShadow = param4.AddComponent<VigShadow>();
        vigShadow.vMesh = param1;
        if (param2 < 0)
        {
            param2 += 15;
        }
        vigShadow.DAT_24 = param2 >> 4;
        if (param3 < 0)
        {
            param3 += 15;
        }
        vigShadow.DAT_28 = param3 >> 4;
        return vigShadow;
    }

    public static int FUN_2E5B0(BoundingBox bbox, VigTransform t1, Radius radius, VigTransform t2)
    {
        Vector3Int v = ApplyMatrixSV(t2.rotation, radius.matrixSV);
        uint num = (ushort)v.x;
        uint num2 = (uint)((int)(num << 16) >> 16);
        uint num3 = (uint)(t1.position.x + (bbox.min.x + bbox.max.x) / 2 - t2.position.x);
        uint num4 = (ushort)v.y;
        long num5 = (long)num2 * (long)num3;
        uint num6 = (uint)((int)(num4 << 16) >> 16);
        uint num7 = (uint)(t1.position.y + (bbox.min.y + bbox.max.y) / 2 - t2.position.y);
        uint num8 = (ushort)v.z;
        long num9 = (long)num6 * (long)num7;
        uint num10 = (uint)num9;
        uint num11 = (uint)((int)(num8 << 16) >> 16);
        uint num12 = (uint)(t1.position.z + (bbox.min.z + bbox.max.z) / 2 - t2.position.z);
        long num13 = (long)num11 * (long)num12;
        uint num14 = (uint)num13;
        uint num15 = (uint)((int)num5 + (int)num10);
        uint num16 = num15 + num14;
        int contactOffset = radius.contactOffset;
        v = FUN_24238(t1.rotation, v);
        int num17 = v.x * (bbox.max.x - bbox.min.x);
        int num18 = v.y * (bbox.max.y - bbox.min.y);
        int num19 = v.z * (bbox.max.z - bbox.min.z);
        if (num17 < 0)
        {
            num17 = -num17;
        }
        if (num18 < 0)
        {
            num18 = -num18;
        }
        if (num19 < 0)
        {
            num19 = -num19;
        }
        num19 = num17 + num18 + num19;
        if (num19 < 0)
        {
            num19 += 8191;
        }
        return ((int)(num16 >> 12) | (((int)((ulong)num5 >> 32) + (int)num2 * ((int)num3 >> 31) + (int)num3 * ((int)(num << 16) >> 31) + (int)((ulong)num9 >> 32) + (int)num6 * ((int)num7 >> 31) + (int)num7 * ((int)(num4 << 16) >> 31) + ((num15 < num10) ? 1 : 0) + (int)((ulong)num13 >> 32) + (int)num11 * ((int)num12 >> 31) + (int)num12 * ((int)(num8 << 16) >> 31) + ((num16 < num14) ? 1 : 0)) * 1048576)) - contactOffset - (num19 >> 13);
    }

    public static uint FUN_2E2E8(BoundingBox param1, VigTransform param2, Radius param3, VigTransform param4)
    {
        VigTransform vigTransform = param2;
        Vector3Int normal = ApplyMatrixSV(param4.rotation, param3.matrixSV);
        uint num = (uint)(normal.x << 16 >> 16);
        uint num2 = (uint)(vigTransform.position.x + (param1.min.x + param1.max.x) / 2 - param4.position.x);
        long num3 = (long)num * (long)num2;
        uint num4 = (uint)(normal.y << 16 >> 16);
        uint num5 = (uint)(vigTransform.position.y + (param1.min.y + param1.max.y) / 2 - param4.position.y);
        long num6 = (long)num4 * (long)num5;
        uint num7 = (uint)num6;
        uint num8 = (uint)(normal.z << 16 >> 16);
        uint num9 = (uint)(vigTransform.position.z + (param1.min.z + param1.max.z) / 2 - param4.position.z);
        long num10 = (long)num8 * (long)num9;
        uint num11 = (uint)num10;
        uint num12 = (uint)((int)num3 + (int)num7);
        uint num13 = num12 + num11;
        int num14 = (int)((ulong)num3 >> 32) + (int)num * ((int)num2 >> 31) + (int)num2 * (normal.x << 16 >> 31) + (int)((ulong)num6 >> 32) + (int)num4 * ((int)num5 >> 31) + (int)num5 * (normal.y << 16 >> 31) + ((num12 < num7) ? 1 : 0) + (int)((ulong)num10 >> 32) + (int)num8 * ((int)num9 >> 31) + (int)num9 * (normal.z << 16 >> 31) + ((num13 < num11) ? 1 : 0);
        int num15 = ((int)(num13 >> 12) | (num14 * 1048576)) - param3.contactOffset;
        if (num15 < 0)
        {
            return 1u;
        }
        Vector3Int vector3Int = FUN_24210(vigTransform.rotation, normal);
        vector3Int.x *= param1.max.x - param1.min.x;
        vector3Int.y *= param1.max.y - param1.min.y;
        vector3Int.z *= param1.max.z - param1.min.z;
        if (vector3Int.x < 0)
        {
            vector3Int.x = -vector3Int.x;
        }
        if (vector3Int.y < 0)
        {
            vector3Int.y = -vector3Int.y;
        }
        if (vector3Int.z < 0)
        {
            vector3Int.z = -vector3Int.z;
        }
        int num16 = vector3Int.x + vector3Int.y + vector3Int.z;
        if (num16 < 0)
        {
            num16 += 8191;
        }
        return (uint)(num15 - (num16 >> 13)) >> 31;
    }

    public static bool FUN_281FC(BoundingBox param1, VigTransform param2, BoundingBox param3, VigTransform param4)
    {
        uint num = (ushort)param2.rotation.V00;
        uint num2 = (ushort)param2.rotation.V02;
        Coprocessor.rotationMatrix.rt11 = (short)num;
        Coprocessor.rotationMatrix.rt12 = param2.rotation.V10;
        uint num3 = (ushort)param2.rotation.V11;
        Coprocessor.rotationMatrix.rt31 = (short)num2;
        Coprocessor.rotationMatrix.rt32 = param2.rotation.V12;
        num2 = (ushort)param2.rotation.V20;
        Coprocessor.rotationMatrix.rt13 = (short)num2;
        Coprocessor.rotationMatrix.rt21 = param2.rotation.V01;
        Coprocessor.rotationMatrix.rt22 = (short)num3;
        Coprocessor.rotationMatrix.rt23 = param2.rotation.V21;
        Coprocessor.rotationMatrix.rt33 = param2.rotation.V22;
        Coprocessor.accumulator.ir1 = (short)(param4.position.x - param2.position.x >> 15);
        Coprocessor.accumulator.ir2 = (short)(param4.position.y - param2.position.y >> 15);
        Coprocessor.accumulator.ir3 = (short)(param4.position.z - param2.position.z >> 15);
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 0, lm: false);
        Coprocessor.vector0.vx0 = (short)((param4.position.x - param2.position.x) & 0x7FFF);
        Coprocessor.vector0.vy0 = (short)((param4.position.y - param2.position.y) & 0x7FFF);
        Coprocessor.vector0.vz0 = (short)((param4.position.z - param2.position.z) & 0x7FFF);
        int mac = Coprocessor.mathsAccumulator.mac1;
        int mac2 = Coprocessor.mathsAccumulator.mac2;
        int mac3 = Coprocessor.mathsAccumulator.mac3;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        int mac4 = Coprocessor.mathsAccumulator.mac1;
        int mac5 = Coprocessor.mathsAccumulator.mac2;
        int mac6 = Coprocessor.mathsAccumulator.mac3;
        Coprocessor.vector0.vx0 = param4.rotation.V00;
        Coprocessor.vector0.vy0 = param4.rotation.V10;
        Coprocessor.vector0.vz0 = param4.rotation.V20;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        num3 = (ushort)Coprocessor.accumulator.ir1;
        int ir = Coprocessor.accumulator.ir2;
        num2 = (ushort)Coprocessor.accumulator.ir3;
        Coprocessor.vector0.vx0 = param4.rotation.V01;
        Coprocessor.vector0.vy0 = param4.rotation.V11;
        Coprocessor.vector0.vz0 = param4.rotation.V21;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        int ir2 = Coprocessor.accumulator.ir1;
        uint num4 = (ushort)Coprocessor.accumulator.ir2;
        int ir3 = Coprocessor.accumulator.ir3;
        Coprocessor.vector0.vx0 = param4.rotation.V02;
        Coprocessor.vector0.vy0 = param4.rotation.V12;
        Coprocessor.vector0.vz0 = param4.rotation.V22;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        num = (ushort)Coprocessor.accumulator.ir1;
        int ir4 = Coprocessor.accumulator.ir2;
        uint num5 = (ushort)Coprocessor.accumulator.ir3;
        Coprocessor.rotationMatrix.rt11 = (short)num3;
        Coprocessor.rotationMatrix.rt12 = (short)ir2;
        Coprocessor.rotationMatrix.rt31 = (short)num2;
        Coprocessor.rotationMatrix.rt32 = (short)ir3;
        Coprocessor.rotationMatrix.rt13 = (short)num;
        Coprocessor.rotationMatrix.rt21 = (short)ir;
        Coprocessor.rotationMatrix.rt22 = (short)num4;
        Coprocessor.rotationMatrix.rt23 = (short)ir4;
        Coprocessor.rotationMatrix.rt33 = (short)num5;
        ir4 = param3.min.x + param3.max.x;
        ir = param3.min.y + param3.max.y;
        ir2 = param3.min.z + param3.max.z;
        ir3 = param3.max.x - param3.min.x;
        int num6 = param3.max.y - param3.min.y;
        int num7 = param3.max.z - param3.min.z;
        Coprocessor.accumulator.ir1 = (short)(ir4 >> 16);
        Coprocessor.accumulator.ir2 = (short)(ir >> 16);
        Coprocessor.accumulator.ir3 = (short)(ir2 >> 16);
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 0, lm: false);
        Coprocessor.vector0.vx0 = (short)((ir4 >> 1) & 0x7FFF);
        Coprocessor.vector0.vy0 = (short)((ir >> 1) & 0x7FFF);
        Coprocessor.vector0.vz0 = (short)((ir2 >> 1) & 0x7FFF);
        ir4 = Coprocessor.mathsAccumulator.mac1;
        ir = Coprocessor.mathsAccumulator.mac2;
        ir2 = Coprocessor.mathsAccumulator.mac3;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        int mac7 = Coprocessor.mathsAccumulator.mac1;
        int mac8 = Coprocessor.mathsAccumulator.mac2;
        int mac9 = Coprocessor.mathsAccumulator.mac3;
        mac7 = mac7 + ir4 * 8 + mac4 + mac * 8;
        mac8 = mac8 + ir * 8 + mac5 + mac2 * 8;
        mac3 = mac9 + ir2 * 8 + mac6 + mac3 * 8;
        num = (uint)(((ushort)Coprocessor.rotationMatrix.rt12 << 16) | (ushort)Coprocessor.rotationMatrix.rt11);
        num2 = (uint)((int)num & -2147450880) >> 15;
        num3 = (uint)(((ushort)Coprocessor.rotationMatrix.rt21 << 16) | (ushort)Coprocessor.rotationMatrix.rt13);
        uint num8 = (uint)((int)num2 + ((int)num ^ (((int)num & -2147450880) * 2 - (int)num2)));
        Coprocessor.rotationMatrix.rt11 = (short)num8;
        Coprocessor.rotationMatrix.rt12 = (short)(num8 >> 16);
        num2 = (uint)((int)num3 & -2147450880) >> 15;
        num = (uint)(((ushort)Coprocessor.rotationMatrix.rt23 << 16) | (ushort)Coprocessor.rotationMatrix.rt22);
        uint num9 = (uint)((int)num2 + ((int)num3 ^ (((int)num3 & -2147450880) * 2 - (int)num2)));
        Coprocessor.rotationMatrix.rt13 = (short)num9;
        Coprocessor.rotationMatrix.rt21 = (short)(num9 >> 16);
        num2 = (uint)((int)num & -2147450880) >> 15;
        num3 = (uint)(((ushort)Coprocessor.rotationMatrix.rt32 << 16) | (ushort)Coprocessor.rotationMatrix.rt31);
        uint num10 = (uint)((int)num2 + ((int)num ^ (((int)num & -2147450880) * 2 - (int)num2)));
        Coprocessor.rotationMatrix.rt22 = (short)num10;
        Coprocessor.rotationMatrix.rt23 = (short)(num10 >> 16);
        num2 = (uint)((int)num3 & -2147450880) >> 15;
        num = (ushort)Coprocessor.rotationMatrix.rt33;
        uint num11 = (uint)((int)num2 + ((int)num3 ^ (((int)num3 & -2147450880) * 2 - (int)num2)));
        Coprocessor.rotationMatrix.rt31 = (short)num11;
        Coprocessor.rotationMatrix.rt32 = (short)(num11 >> 16);
        num3 = (uint)((int)(num << 16) >> 31);
        Coprocessor.rotationMatrix.rt33 = (short)((num ^ num3) - num3);
        Coprocessor.accumulator.ir1 = (short)(ir3 >> 16);
        Coprocessor.accumulator.ir2 = (short)(num6 >> 16);
        Coprocessor.accumulator.ir3 = (short)(num7 >> 16);
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 0, lm: false);
        Coprocessor.vector0.vx0 = (short)((ir3 >> 1) & 0x7FFF);
        Coprocessor.vector0.vy0 = (short)((num6 >> 1) & 0x7FFF);
        Coprocessor.vector0.vz0 = (short)((num7 >> 1) & 0x7FFF);
        mac4 = Coprocessor.mathsAccumulator.mac1;
        mac5 = Coprocessor.mathsAccumulator.mac2;
        mac = Coprocessor.mathsAccumulator.mac3;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        ir4 = Coprocessor.mathsAccumulator.mac1;
        mac2 = Coprocessor.mathsAccumulator.mac2;
        ir = Coprocessor.mathsAccumulator.mac3;
        ir4 += mac4 * 8;
        mac2 += mac5 * 8;
        ir += mac * 8;
        if (-1 < mac7 + ir4 - param1.min.x && -1 < mac8 + mac2 - param1.min.y && -1 < mac3 + ir - param1.min.z && mac7 - ir4 - param1.max.x < 1 && mac8 - mac2 - param1.max.y < 1)
        {
            return mac3 - ir < param1.max.z;
        }
        return false;
    }

    public static int FUN_29A9C(List<VigTuple> tuple)
    {
        return tuple.Count;
    }

    public static int FUN_29BD0(int param1)
    {
        if (param1 < 0)
        {
            param1 = -param1;
        }
        int num = LeadingZeros(param1);
        return 31 - num;
    }

    public static int FUN_29C5C(Vector3Int v1, Vector3Int v2)
    {
        int num = v1.x * v2.x;
        int num2 = v1.y * v2.y;
        int num3 = v1.z * v2.z;
        return num + num2 + num3;
    }

    public static int FUN_29DDC(Vector3Int v3)
    {
        Coprocessor.accumulator.ir1 = (short)v3.x;
        Coprocessor.accumulator.ir2 = (short)v3.y;
        Coprocessor.accumulator.ir3 = (short)v3.z;
        Coprocessor.ExecuteSQR(0, lm: true);
        return Coprocessor.mathsAccumulator.mac1 + Coprocessor.mathsAccumulator.mac2 + Coprocessor.mathsAccumulator.mac3;
    }

    public static int FUN_29E24(Vector3Int v3)
    {
        Coprocessor.accumulator.ir1 = (short)v3.x;
        Coprocessor.accumulator.ir2 = (short)v3.y;
        Coprocessor.accumulator.ir3 = (short)v3.z;
        Coprocessor.ExecuteSQR(0, lm: true);
        int mac = Coprocessor.mathsAccumulator.mac1;
        int mac2 = Coprocessor.mathsAccumulator.mac2;
        int mac3 = Coprocessor.mathsAccumulator.mac3;
        return (int)SquareRoot(mac + mac2 + mac3);
    }

    public static int FUN_29E84(Vector3Int phy)
    {
        Vector2Int vector2Int = FUN_2ACD0(phy, phy);
        int y = vector2Int.y;
        int y2 = vector2Int.y;
        y = LeadingZeros(y);
        int num = 35 - y >> 1;
        y = num << 1;
        int num2 = y << 26;
        int num3 = 0;
        if (num2 < 0)
        {
            num3 = vector2Int.y >> 31;
        }
        else
        {
            num3 = (int)((uint)vector2Int.x >> y);
            if (num2 != 0)
            {
                num2 = vector2Int.y << y * -1;
                num3 |= num2;
            }
        }
        int y3 = vector2Int.y;
        return (int)(SquareRoot(num3) << num);
    }

    public static int FUN_29F6C(Vector3Int v1, Vector3Int v2)
    {
        return FUN_29E84(new Vector3Int(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z));
    }

    public static int FUN_29FC8(Vector3Int vin, out Vector3Int vout)
    {
        int num = FUN_29E84(vin);
        if (num == 0)
        {
            vout = new Vector3Int(0, 0, 0);
        }
        else
        {
            int num2 = LeadingZeros(num);
            uint num3 = 12u;
            if (num2 - 1 < 12)
            {
                num3 = (uint)(num2 - 1);
            }
            num2 = num >> (int)(12 - num3);
            vout = new Vector3Int((vin.x << (int)num3) / num2, (vin.y << (int)num3) / num2, (vin.z << (int)num3) / num2);
        }
        return num;
    }

    public static int FUN_2A098(Vector3Int vin, out Vector3Int vout)
    {
        int num = FUN_29E84(vin);
        if (num == 0)
        {
            vout = new Vector3Int(0, 0, 0);
        }
        else
        {
            int num2 = LeadingZeros(num);
            uint num3 = 12u;
            if (num2 - 1 < 12)
            {
                num3 = (uint)(num2 - 1);
            }
            num2 = num >> (int)(12 - num3);
            vout = new Vector3Int((vin.x << (int)num3) / num2, (vin.y << (int)num3) / num2, (vin.z << (int)num3) / num2);
        }
        return num;
    }

    public static VigTransform FUN_2A9F4(Vector3Int[] v1, Vector3Int[] v2)
    {
        FUN_2A168(out Vector3Int vout, v1[0], v1[1]);
        FUN_2A168(out Vector3Int vout2, v1[0], v1[2]);
        Vector3Int n = FUN_2A1E0(vout2, vout);
        n = VectorNormal(n);
        vout2 = FUN_2A1E0(vout, n);
        VigTransform transform = default(VigTransform);
        transform.rotation.V00 = (short)vout.x;
        transform.rotation.V10 = (short)vout.y;
        transform.rotation.V20 = (short)vout.z;
        transform.rotation.V01 = (short)n.x;
        transform.rotation.V11 = (short)n.y;
        transform.rotation.V21 = (short)n.z;
        transform.rotation.V02 = (short)vout2.x;
        transform.rotation.V12 = (short)vout2.y;
        transform.rotation.V22 = (short)vout2.z;
        transform.position.x = v1[0].x;
        transform.position.y = v1[0].y;
        transform.position.z = v1[0].z;
        FUN_2A168(out vout, v2[0], v2[1]);
        FUN_2A168(out vout2, v2[0], v2[2]);
        n = FUN_2A1E0(vout2, vout);
        n = VectorNormal(n);
        vout2 = FUN_2A1E0(vout, n);
        VigTransform m = default(VigTransform);
        m.rotation.V00 = (short)vout.x;
        m.rotation.V10 = (short)vout.y;
        m.rotation.V20 = (short)vout.z;
        m.rotation.V01 = (short)n.x;
        m.rotation.V11 = (short)n.y;
        m.rotation.V21 = (short)n.z;
        m.rotation.V02 = (short)vout2.x;
        m.rotation.V12 = (short)vout2.y;
        m.rotation.V22 = (short)vout2.z;
        m.position.x = v2[0].x;
        m.position.y = v2[0].y;
        m.position.z = v2[0].z;
        VigTransform m2 = FUN_2A3EC(transform);
        return CompMatrixLV(m, m2);
    }

    public static int FUN_2A168(out Vector3Int vout, Vector3Int v1, Vector3Int v2)
    {
        return FUN_29FC8(new Vector3Int(v2.x - v1.x, v2.y - v1.y, v2.z - v1.z), out vout);
    }

    public static Vector2Int FUN_2A1C0(Vector3Int v3)
    {
        return FUN_2ACD0(v3, v3);
    }

    public static long FUN_2AD3C(Vector3Int v3, Vector3Int sv3)
    {
        long num = (long)v3.x * (long)sv3.x;
        long num2 = (long)v3.y * (long)sv3.y;
        long num3 = (long)v3.z * (long)sv3.z;
        int num4 = (int)num + (int)num2;
        int num5 = (int)(num >> 32) + (int)(num2 >> 32) + (((uint)num4 < (uint)num2) ? 1 : 0);
        num4 += (int)num3;
        return ((long)(num5 + ((int)(num3 >> 32) + (((uint)num4 < (uint)num3) ? 1 : 0))) << 32) | (uint)num4;
    }

    public static Vector2Int FUN_2ACD0(Vector3Int v3a, Vector3Int v3b)
    {
        long num = (long)v3a.x * (long)v3b.x;
        long num2 = (long)v3a.y * (long)v3b.y;
        long num3 = (long)v3a.z * (long)v3b.z;
        Vector2Int result = default(Vector2Int);
        result.x = (int)num + (int)num2;
        result.y = (int)(num >> 32) + (int)(num2 >> 32);
        result.y += (((uint)result.x < (uint)num2) ? 1 : 0);
        result.x += (int)num3;
        result.y += (int)(num3 >> 32);
        result.y += (((uint)result.x < (uint)num3) ? 1 : 0);
        return result;
    }

    public static int FUN_2ABC4(uint param1, int param2)
    {
        int num = LeadingZeros(param2);
        uint num2 = (uint)(35 - num >> 1);
        if ((int)(num2 << 27) < 0)
        {
            param1 = (uint)(param2 >> (int)((num2 * 2) & 0x1F));
        }
        else
        {
            param1 >>= (int)((num2 * 2) & 0x1F);
            if (num2 << 27 != 0)
            {
                param1 = (uint)((int)param1 | (param2 << (int)((num2 * -2) & 0x1F)));
            }
        }
        return (int)SquareRoot(param1) << (int)num2;
    }

    public static Matrix3x3 FUN_2A4A4(Matrix3x3 m33)
    {
        long num = SquareRoot(m33.V00 * m33.V00 + m33.V20 * m33.V20);
        int num3;
        int num2;
        if (num != 0L)
        {
            num2 = m33.V00 * (16777216 / (int)num);
            num3 = m33.V20 * (16777216 / (int)num);
        }
        else
        {
            num2 = m33.V00 * -1;
            num3 = m33.V20 * -1;
        }
        if (num2 < 0)
        {
            num2 += 4095;
        }
        num2 >>= 12;
        if (num3 < 0)
        {
            num3 += 4095;
        }
        if (m33.V11 < 0)
        {
            num2 = -num2;
        }
        m33.V22 = (short)num;
        int num4 = num2 * m33.V10 - num3 * m33.V12;
        m33.V20 = 0;
        if (num4 < 0)
        {
            num4 += 4095;
        }
        int num5 = num3 * m33.V00 - num3 * m33.V02;
        m33.V10 = (short)(num4 >> 12);
        if (num5 < 0)
        {
            num5 += 4095;
        }
        num2 = num2 * m33.V00 - num3 * m33.V02;
        m33.V12 = (short)(num5 >> 12);
        if (num2 < 0)
        {
            num2 += 4095;
        }
        m33.V00 = (short)(num2 >> 12);
        m33.V02 = 0;
        return m33;
    }

    public static VigTransform FUN_2A3EC(VigTransform transform)
    {
        VigTransform vigTransform = default(VigTransform);
        vigTransform.rotation = TransposeMatrix(transform.rotation);
        vigTransform.padding = 0;
        vigTransform.position = FUN_24094(vigTransform.rotation, transform.position);
        int z = vigTransform.position.z;
        vigTransform.position.x = -vigTransform.position.x;
        vigTransform.position.z = -z;
        vigTransform.position.y = -vigTransform.position.y;
        return vigTransform;
    }

    public static Vector3Int FUN_2A1E0(Vector3Int v1, Vector3Int v2)
    {
        Coprocessor.rotationMatrix.rt11 = (short)v1.x;
        Coprocessor.rotationMatrix.rt12 = (short)(v1.x >> 16);
        Coprocessor.rotationMatrix.rt22 = (short)v1.y;
        Coprocessor.rotationMatrix.rt23 = (short)(v1.y >> 16);
        Coprocessor.rotationMatrix.rt33 = (short)v1.z;
        Coprocessor.accumulator.ir1 = (short)v2.x;
        Coprocessor.accumulator.ir2 = (short)v2.y;
        Coprocessor.accumulator.ir3 = (short)v2.z;
        Coprocessor.ExecuteOP(12, lm: false);
        return new Vector3Int(Coprocessor.mathsAccumulator.mac1, Coprocessor.mathsAccumulator.mac2, Coprocessor.mathsAccumulator.mac3);
    }

    public static short FUN_2A248(Matrix3x3 m33)
    {
        return (short)(-Ratan2(m33.V12, m33.V22));
    }

    public static short FUN_2A27C(Matrix3x3 m33)
    {
        return (short)Ratan2(m33.V02, m33.V22);
    }

    public static int FUN_2A2AC(Matrix3x3 m33)
    {
        return -Ratan2(m33.V10, m33.V11) << 16 >> 16;
    }

    public static Vector3Int FUN_2A2E0(Matrix3x3 m33)
    {
        short num = FUN_2A27C(m33);
        m33 = RotMatrixY(-num, m33);
        short num2 = FUN_2A248(m33);
        m33 = RotMatrixX(-num2, m33);
        short z = (short)FUN_2A2AC(m33);
        return new Vector3Int(num2, num, z);
    }

    public static Matrix3x3 FUN_2A5EC(Vector3Int sv)
    {
        Vector3Int vector3Int = new Vector3Int(-sv.x, -sv.y, -sv.z);
        Vector3Int vector3Int2;
        if (sv.x == 0 && sv.y == 0)
        {
            vector3Int2 = new Vector3Int(4096, 0, 0);
        }
        else
        {
            vector3Int2 = new Vector3Int(-sv.y, sv.x, 0);
            vector3Int2 = VectorNormal(vector3Int2);
        }
        Coprocessor.rotationMatrix.rt11 = (short)vector3Int2.x;
        Coprocessor.rotationMatrix.rt12 = (short)(vector3Int2.x >> 16);
        Coprocessor.rotationMatrix.rt22 = (short)vector3Int2.y;
        Coprocessor.rotationMatrix.rt23 = (short)(vector3Int2.y >> 16);
        Coprocessor.rotationMatrix.rt33 = (short)vector3Int2.z;
        Coprocessor.accumulator.ir1 = (short)vector3Int.x;
        Coprocessor.accumulator.ir2 = (short)vector3Int.y;
        Coprocessor.accumulator.ir3 = (short)vector3Int.z;
        Coprocessor.ExecuteOP(12, lm: false);
        Matrix3x3 result = default(Matrix3x3);
        result.V00 = (short)vector3Int2.x;
        result.V10 = (short)vector3Int2.y;
        result.V20 = (short)vector3Int2.z;
        result.V01 = (short)vector3Int.x;
        result.V11 = (short)vector3Int.y;
        result.V21 = (short)vector3Int.z;
        result.V02 = (short)Coprocessor.mathsAccumulator.mac1;
        result.V12 = (short)Coprocessor.mathsAccumulator.mac2;
        result.V22 = (short)Coprocessor.mathsAccumulator.mac3;
        return result;
    }

    public static Matrix3x3 FUN_2A724(Vector3Int sv)
    {
        short num = (short)sv.x;
        short num2 = (short)sv.y;
        short num3 = (short)sv.z;
        Vector3Int n = default(Vector3Int);
        n.x = sv.z;
        if (n.x == 0)
        {
            if (sv.x == 0)
            {
                n.x = 4096;
                n.y = 0;
                n.z = 0;
                goto IL_008d;
            }
            n.x = sv.z;
        }
        n.y = 0;
        n.z = -sv.x;
        n = VectorNormal(n);
        goto IL_008d;
    IL_008d:
        Coprocessor.rotationMatrix.rt11 = num;
        Coprocessor.rotationMatrix.rt12 = (short)(num >> 16);
        Coprocessor.rotationMatrix.rt22 = num2;
        Coprocessor.rotationMatrix.rt23 = (short)(num2 >> 16);
        Coprocessor.rotationMatrix.rt33 = num3;
        Coprocessor.accumulator.ir3 = (short)n.z;
        Coprocessor.accumulator.ir1 = (short)n.x;
        Coprocessor.accumulator.ir2 = (short)n.y;
        Coprocessor.ExecuteOP(12, lm: false);
        Matrix3x3 result = default(Matrix3x3);
        result.V00 = (short)n.x;
        result.V10 = (short)n.y;
        result.V20 = (short)n.z;
        result.V02 = num;
        result.V12 = num2;
        result.V22 = num3;
        result.V01 = (short)Coprocessor.mathsAccumulator.mac1;
        result.V11 = (short)Coprocessor.mathsAccumulator.mac2;
        result.V21 = (short)Coprocessor.mathsAccumulator.mac3;
        return result;
    }

    public static void FUN_2A85C(ref Matrix3x3 m33, Vector3Int v1, Vector3Int v2)
    {
        Vector3Int vector3Int = new Vector3Int(-v2.x, -v2.y, -v2.z);
        Vector3Int vector3Int2 = default(Vector3Int);
        if (v1.x == 0 && v1.z == 0)
        {
            vector3Int2.x = 0;
            vector3Int2.z = 4096;
        }
        else
        {
            vector3Int2.x = v1.x;
            vector3Int2.z = v1.z;
        }
        vector3Int2.y = 0;
        Coprocessor.rotationMatrix.rt11 = (short)vector3Int.x;
        Coprocessor.rotationMatrix.rt12 = (short)(vector3Int.x >> 16);
        Coprocessor.rotationMatrix.rt22 = (short)vector3Int.y;
        Coprocessor.rotationMatrix.rt23 = (short)(vector3Int.y >> 16);
        Coprocessor.rotationMatrix.rt33 = (short)vector3Int.z;
        Coprocessor.accumulator.ir3 = (short)vector3Int2.z;
        Coprocessor.accumulator.ir1 = (short)vector3Int2.x;
        Coprocessor.accumulator.ir2 = (short)vector3Int2.y;
        Coprocessor.ExecuteOP(12, lm: false);
        m33.V01 = (short)vector3Int.x;
        m33.V11 = (short)vector3Int.y;
        m33.V21 = (short)vector3Int.z;
        Vector3Int n = new Vector3Int(Coprocessor.mathsAccumulator.mac1, Coprocessor.mathsAccumulator.mac2, Coprocessor.mathsAccumulator.mac3);
        n = VectorNormal(n);
        Coprocessor.rotationMatrix.rt11 = (short)n.x;
        Coprocessor.rotationMatrix.rt12 = (short)(n.x >> 16);
        Coprocessor.rotationMatrix.rt22 = (short)n.y;
        Coprocessor.rotationMatrix.rt23 = (short)(n.y >> 16);
        Coprocessor.rotationMatrix.rt33 = (short)n.z;
        Coprocessor.accumulator.ir3 = (short)vector3Int.z;
        Coprocessor.accumulator.ir1 = (short)vector3Int.x;
        Coprocessor.accumulator.ir2 = (short)vector3Int.y;
        Coprocessor.ExecuteOP(12, lm: false);
        m33.V00 = (short)n.x;
        m33.V10 = (short)n.y;
        m33.V20 = (short)n.z;
        m33.V02 = (short)Coprocessor.mathsAccumulator.mac1;
        m33.V12 = (short)Coprocessor.mathsAccumulator.mac2;
        m33.V22 = (short)Coprocessor.mathsAccumulator.mac3;
    }

    public static Matrix3x3 FUN_2ADB0(Matrix3x3 m33, Vector3Int v3)
    {
        Matrix3x3 m34 = default(Matrix3x3);
        m34.V22 = 4096;
        m34.V11 = 4096;
        m34.V00 = 4096;
        m34.V21 = (short)v3.x;
        m34.V12 = (short)(-v3.x);
        m34.V02 = (short)v3.y;
        m34.V20 = (short)(-v3.y);
        m34.V10 = (short)v3.z;
        m34.V01 = (short)(-v3.z);
        return FUN_247C4(m34, m33);
    }

    public static VigTransform FUN_2C77C(ConfigContainer conf)
    {
        VigTransform result = default(VigTransform);
        result.rotation = RotMatrixYXZ_gte(conf.v3_2);
        result.position.x = conf.v3_1.x;
        result.position.y = conf.v3_1.y;
        result.position.z = conf.v3_1.z;
        return result;
    }

    public static void FUN_2CA94(VigObject obj1, ConfigContainer cont, VigObject obj2)
    {
        obj2.vr = cont.v3_2;
        obj2.screen = cont.v3_1;
        obj2.ApplyTransformation();
        FUN_2CC48(obj1, obj2);
    }

    public static void FUN_2CB04(VigObject obj1, ConfigContainer cont, VigObject obj2)
    {
        obj2.vr = cont.v3_2;
        obj2.screen = cont.v3_1;
        obj2.ApplyTransformation();
        FUN_2CC9C(obj1, obj2);
    }

    public static void FUN_2CC48(VigObject obj1, VigObject obj2)
    {
        VigObject vigObject = obj1.child2;
        if (vigObject != null)
        {
            VigObject child = vigObject.child;
            while (child != null)
            {
                vigObject = vigObject.child;
                child = vigObject.child;
            }
            vigObject.child = obj2;
            obj2.parent = vigObject;
        }
        else
        {
            obj1.child2 = obj2;
            obj2.parent = obj1;
        }
    }

    public static void ParentChildren(VigObject obj, VigObject parent)
    {
        VigObject child = obj.child2;
        if (child != null)
        {
            child.transform.parent = obj.transform;
            ParentChildren2(child, obj);
        }
    }

    public static void ParentChildren2(VigObject obj, VigObject parent)
    {
        VigObject child = obj.child2;
        if (child != null)
        {
            child.transform.parent = obj.transform;
            ParentChildren2(child, obj);
        }
        VigObject child2 = obj.child;
        if (child2 != null)
        {
            child2.transform.parent = parent.transform;
            ParentChildren2(child2, parent);
        }
    }

    public static void ResetMesh(VigObject obj)
    {
        VigMesh vMesh = obj.vMesh;
        VigMesh vLOD = obj.vLOD;
        VigShadow vShadow = obj.vShadow;
        if (vMesh != null)
        {
            vMesh.ClearMeshData();
        }
        if (vLOD != null)
        {
            vLOD.ClearMeshData();
        }
        if (vShadow != null)
        {
            vShadow.vMesh.ClearMeshData();
        }
        VigObject child = obj.child2;
        if (child != null)
        {
            ResetMesh(child);
        }
        VigObject child2 = obj.child;
        if (child2 != null)
        {
            ResetMesh(child2);
        }
    }

    public static void FUN_2CC9C(VigObject obj1, VigObject obj2)
    {
        VigObject child = obj1.child2;
        obj1.child2 = obj2;
        obj2.parent = obj1;
        obj2.child = child;
        if (child != null)
        {
            child.parent = obj2;
        }
    }

    public static VigObject FUN_2CD78(VigObject obj)
    {
        VigObject vigObject = obj.parent;
        while (vigObject != null && vigObject.child2 != obj)
        {
            VigObject parent = vigObject.parent;
            obj = vigObject;
            vigObject = parent;
        }
        return vigObject;
    }

    public static VigObject FUN_2CDB0(VigObject obj)
    {
        VigObject parent = obj.parent;
        while (parent != null)
        {
            obj = FUN_2CD78(obj);
            parent = obj.parent;
        }
        return obj;
    }

    public static Vector3Int FUN_23F58(Vector3Int v3)
    {
        Coprocessor.vector0.vx0 = (short)v3.x;
        Coprocessor.vector0.vy0 = (short)v3.y;
        Coprocessor.vector0.vz0 = (short)v3.z;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.TR, 12, lm: false);
        return new Vector3Int(Coprocessor.mathsAccumulator.mac1, Coprocessor.mathsAccumulator.mac2, Coprocessor.mathsAccumulator.mac3);
    }

    public static Vector3Int FUN_23F7C(Vector3Int v3)
    {
        Coprocessor.accumulator.ir1 = (short)(v3.x >> 15);
        Coprocessor.accumulator.ir2 = (short)(v3.y >> 15);
        Coprocessor.accumulator.ir3 = (short)(v3.z >> 15);
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 0, lm: false);
        Coprocessor.vector0.vx0 = (short)(v3.x & 0x7FFF);
        Coprocessor.vector0.vy0 = (short)(v3.y & 0x7FFF);
        Coprocessor.vector0.vz0 = (short)(v3.z & 0x7FFF);
        int mac = Coprocessor.mathsAccumulator.mac1;
        int mac2 = Coprocessor.mathsAccumulator.mac2;
        int mac3 = Coprocessor.mathsAccumulator.mac3;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        int mac4 = Coprocessor.mathsAccumulator.mac1;
        int mac5 = Coprocessor.mathsAccumulator.mac2;
        int mac6 = Coprocessor.mathsAccumulator.mac3;
        return new Vector3Int(mac4 + mac * 8, mac5 + mac2 * 8, mac6 + mac3 * 8);
    }

    public static void FUN_246BC(VigTransform transform)
    {
        Coprocessor.rotationMatrix.rt11 = transform.rotation.V00;
        Coprocessor.rotationMatrix.rt12 = transform.rotation.V01;
        Coprocessor.rotationMatrix.rt13 = transform.rotation.V02;
        Coprocessor.rotationMatrix.rt21 = transform.rotation.V10;
        Coprocessor.rotationMatrix.rt22 = transform.rotation.V11;
        Coprocessor.rotationMatrix.rt23 = transform.rotation.V12;
        Coprocessor.rotationMatrix.rt31 = transform.rotation.V20;
        Coprocessor.rotationMatrix.rt32 = transform.rotation.V21;
        Coprocessor.rotationMatrix.rt33 = transform.rotation.V22;
        Coprocessor.translationVector._trx = transform.position.x;
        Coprocessor.translationVector._try = transform.position.y;
        Coprocessor.translationVector._trz = transform.position.z;
    }

    public static Matrix3x3 FUN_247C4(Matrix3x3 m1, Matrix3x3 m2)
    {
        Coprocessor.rotationMatrix.rt11 = m1.V00;
        Coprocessor.rotationMatrix.rt12 = m1.V01;
        Coprocessor.rotationMatrix.rt13 = m1.V02;
        Coprocessor.rotationMatrix.rt21 = m1.V10;
        Coprocessor.rotationMatrix.rt22 = m1.V11;
        Coprocessor.rotationMatrix.rt23 = m1.V12;
        Coprocessor.rotationMatrix.rt31 = m1.V20;
        Coprocessor.rotationMatrix.rt32 = m1.V21;
        Coprocessor.rotationMatrix.rt33 = m1.V22;
        return FUN_247F4(m2);
    }

    public static Matrix3x3 FUN_247F4(Matrix3x3 m33)
    {
        Coprocessor.vector0.vx0 = m33.V00;
        Coprocessor.vector0.vy0 = m33.V10;
        Coprocessor.vector0.vz0 = m33.V20;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        Coprocessor.vector1.vx1 = m33.V01;
        Coprocessor.vector1.vy1 = m33.V11;
        Coprocessor.vector1.vz1 = m33.V21;
        short ir = Coprocessor.accumulator.ir1;
        short ir2 = Coprocessor.accumulator.ir2;
        short ir3 = Coprocessor.accumulator.ir3;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V1, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        Coprocessor.vector0.vx0 = m33.V02;
        Coprocessor.vector0.vy0 = m33.V12;
        Coprocessor.vector0.vz0 = m33.V22;
        short ir4 = Coprocessor.accumulator.ir1;
        short ir5 = Coprocessor.accumulator.ir2;
        short ir6 = Coprocessor.accumulator.ir3;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        short ir7 = Coprocessor.accumulator.ir1;
        short ir8 = Coprocessor.accumulator.ir2;
        short ir9 = Coprocessor.accumulator.ir3;
        Matrix3x3 result = default(Matrix3x3);
        result.V00 = ir;
        result.V01 = ir4;
        result.V02 = ir7;
        result.V10 = ir2;
        result.V11 = ir5;
        result.V12 = ir8;
        result.V20 = ir3;
        result.V21 = ir6;
        result.V22 = ir9;
        return result;
    }

    public static Vector3Int FUN_24008(Vector3Int v3)
    {
        Coprocessor.accumulator.ir1 = (short)(v3.x >> 15);
        Coprocessor.accumulator.ir2 = (short)(v3.y >> 15);
        Coprocessor.accumulator.ir3 = (short)(v3.z >> 15);
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 0, lm: false);
        Coprocessor.vector0.vx0 = (short)(v3.x & 0x7FFF);
        Coprocessor.vector0.vy0 = (short)(v3.y & 0x7FFF);
        Coprocessor.vector0.vz0 = (short)(v3.z & 0x7FFF);
        int mac = Coprocessor.mathsAccumulator.mac1;
        int mac2 = Coprocessor.mathsAccumulator.mac2;
        int mac3 = Coprocessor.mathsAccumulator.mac3;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.TR, 12, lm: false);
        int mac4 = Coprocessor.mathsAccumulator.mac1;
        int mac5 = Coprocessor.mathsAccumulator.mac2;
        int mac6 = Coprocessor.mathsAccumulator.mac3;
        return new Vector3Int(mac4 + mac * 8, mac5 + mac2 * 8, mac6 + mac3 * 8);
    }

    public static Vector3Int FUN_2426C(Matrix3x3 m33, Matrix2x4 m24)
    {
        FUN_243B4(m33);
        int x = m24.X;
        int y = m24.Y;
        int z = m24.Z;
        int num = x >> 15;
        int num2 = y >> 15;
        int num3 = z >> 15;
        Coprocessor.accumulator.ir1 = (short)num;
        Coprocessor.accumulator.ir2 = (short)num2;
        Coprocessor.accumulator.ir3 = (short)num3;
        x &= 0x7FFF;
        y &= 0x7FFF;
        z &= 0x7FFF;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 0, lm: false);
        num = ((y << 16) | x);
        Coprocessor.vector0.vx0 = (short)(num & 0xFFFF);
        Coprocessor.vector0.vy0 = (short)(num >> 16);
        Coprocessor.vector0.vz0 = (short)z;
        num = Coprocessor.mathsAccumulator.mac1;
        num2 = Coprocessor.mathsAccumulator.mac2;
        num3 = Coprocessor.mathsAccumulator.mac3;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        num <<= 3;
        num2 <<= 3;
        num3 <<= 3;
        x = Coprocessor.mathsAccumulator.mac1 + num;
        y = Coprocessor.mathsAccumulator.mac2 + num2;
        z = Coprocessor.mathsAccumulator.mac3 + num3;
        return new Vector3Int(x, y, z);
    }

    public static void FUN_245AC(ref Matrix3x3 m33, Vector3Int sv)
    {
        int x = sv.x;
        int y = sv.y;
        int z = sv.z;
        m33._V00 = m33.V00;
        m33._V01 = m33.V01;
        m33._V02 = m33.V02;
        m33._V10 = m33.V10;
        m33._V11 = m33.V11;
        m33._V12 = m33.V12;
        m33._V20 = m33.V20;
        m33._V21 = m33.V21;
        m33._V22 = m33.V22;
        m33.V00 = (short)(m33.V00 * x >> 12);
        m33.V01 = (short)(m33.V01 * y >> 12);
        m33.V02 = (short)(m33.V02 * z >> 12);
        m33.V10 = (short)(m33.V10 * x >> 12);
        m33.V11 = (short)(m33.V11 * y >> 12);
        m33.V12 = (short)(m33.V12 * z >> 12);
        m33.V20 = (short)(m33.V20 * x >> 12);
        m33.V21 = (short)(m33.V21 * y >> 12);
        m33.V22 = (short)(m33.V22 * z >> 12);
        m33.skewed = true;
    }

    public static void FUN_2449C(Matrix3x3 m33, Vector3Int v3, ref Matrix3x3 mout)
    {
        mout._V00 = mout.V00;
        mout._V01 = mout.V01;
        mout._V02 = mout.V02;
        mout._V10 = mout.V10;
        mout._V11 = mout.V11;
        mout._V12 = mout.V12;
        mout._V20 = mout.V20;
        mout._V21 = mout.V21;
        mout._V22 = mout.V22;
        mout.V00 = (short)(m33.V00 * v3.x >> 12);
        mout.V01 = (short)(m33.V01 * v3.y >> 12);
        mout.V02 = (short)(m33.V02 * v3.z >> 12);
        mout.V10 = (short)(m33.V10 * v3.x >> 12);
        mout.V11 = (short)(m33.V11 * v3.y >> 12);
        mout.V12 = (short)(m33.V12 * v3.z >> 12);
        mout.V20 = (short)(m33.V20 * v3.x >> 12);
        mout.V21 = (short)(m33.V21 * v3.y >> 12);
        mout.V22 = (short)(m33.V22 * v3.z >> 12);
        mout.skewed = true;
    }

    public static void FUN_2A454(VigTransform t1, VigTransform t2, out VigTransform t3)
    {
        FUN_248C4(t1.rotation, t2.rotation, out t3.rotation);
        t3.padding = 0;
        t3.position = FUN_24304(t1, t2.position);
    }

    public static void FUN_248C4(Matrix3x3 m1, Matrix3x3 m2, out Matrix3x3 m3)
    {
        FUN_243B4(m1);
        m3 = FUN_247F4(m2);
    }

    public static void FUN_243B4(Matrix3x3 m33)
    {
        int num = m33.GetValue32(0) & 0xFFFF;
        int num2 = m33.GetValue32(0) - num;
        int num3 = m33.GetValue32(1) & 0xFFFF;
        int num4 = m33.GetValue32(1) - num3;
        num |= num4;
        Coprocessor.rotationMatrix.rt11 = (short)(num & 0xFFFF);
        Coprocessor.rotationMatrix.rt12 = (short)(num >> 16);
        num = (m33.GetValue32(2) & 0xFFFF);
        num4 = m33.GetValue32(2) - num;
        num3 |= num4;
        Coprocessor.rotationMatrix.rt31 = (short)(num3 & 0xFFFF);
        Coprocessor.rotationMatrix.rt32 = (short)(num3 >> 16);
        num3 = (m33.GetValue32(3) & 0xFFFF);
        num4 = m33.GetValue32(3) - num3;
        num2 |= num3;
        num4 |= num;
        Coprocessor.rotationMatrix.rt13 = (short)(num2 & 0xFFFF);
        Coprocessor.rotationMatrix.rt21 = (short)(num2 >> 16);
        Coprocessor.rotationMatrix.rt22 = (short)(num4 & 0xFFFF);
        Coprocessor.rotationMatrix.rt23 = (short)(num4 >> 16);
        Coprocessor.rotationMatrix.rt33 = (short)m33.GetValue32(4);
    }

    public static Vector3Int FUN_24304(VigTransform transform, Vector3Int v)
    {
        FUN_243B4(transform.rotation);
        int num = v.x - transform.position.x;
        int num2 = v.y - transform.position.y;
        int num3 = v.z - transform.position.z;
        Coprocessor.accumulator.ir1 = (short)(num >> 15);
        Coprocessor.accumulator.ir2 = (short)(num2 >> 15);
        Coprocessor.accumulator.ir3 = (short)(num3 >> 15);
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 0, lm: false);
        int num4 = Coprocessor.mathsAccumulator.mac1 << 3;
        int num5 = Coprocessor.mathsAccumulator.mac2 << 3;
        int num6 = Coprocessor.mathsAccumulator.mac3 << 3;
        num &= 0x7FFF;
        num2 &= 0x7FFF;
        num3 &= 0x7FFF;
        Coprocessor.vector0.vx0 = (short)num;
        Coprocessor.vector0.vy0 = (short)num2;
        Coprocessor.vector0.vz0 = (short)num3;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        int x = Coprocessor.mathsAccumulator.mac1 + num4;
        int y = Coprocessor.mathsAccumulator.mac2 + num5;
        int z = Coprocessor.mathsAccumulator.mac3 + num6;
        return new Vector3Int(x, y, z);
    }

    public static Vector3Int FUN_24148(VigTransform transform, Vector3Int v)
    {
        Coprocessor.rotationMatrix.rt11 = transform.rotation.V00;
        Coprocessor.rotationMatrix.rt12 = transform.rotation.V01;
        Coprocessor.rotationMatrix.rt13 = transform.rotation.V02;
        Coprocessor.rotationMatrix.rt21 = transform.rotation.V10;
        Coprocessor.rotationMatrix.rt22 = transform.rotation.V11;
        Coprocessor.rotationMatrix.rt23 = transform.rotation.V12;
        Coprocessor.rotationMatrix.rt31 = transform.rotation.V20;
        Coprocessor.rotationMatrix.rt32 = transform.rotation.V21;
        Coprocessor.rotationMatrix.rt33 = transform.rotation.V22;
        Coprocessor.accumulator.ir1 = (short)(v.x >> 15);
        Coprocessor.accumulator.ir2 = (short)(v.y >> 15);
        Coprocessor.accumulator.ir3 = (short)(v.z >> 15);
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 0, lm: false);
        int num = Coprocessor.mathsAccumulator.mac1 << 3;
        int num2 = Coprocessor.mathsAccumulator.mac2 << 3;
        int num3 = Coprocessor.mathsAccumulator.mac3 << 3;
        Coprocessor.translationVector._trx = transform.position.x;
        Coprocessor.translationVector._try = transform.position.y;
        Coprocessor.translationVector._trz = transform.position.z;
        Coprocessor.accumulator.ir1 = (short)(v.x & 0x7FFF);
        Coprocessor.accumulator.ir2 = (short)(v.y & 0x7FFF);
        Coprocessor.accumulator.ir3 = (short)(v.z & 0x7FFF);
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.TR, 12, lm: false);
        int x = Coprocessor.mathsAccumulator.mac1 + num;
        int y = Coprocessor.mathsAccumulator.mac2 + num2;
        int z = Coprocessor.mathsAccumulator.mac3 + num3;
        return new Vector3Int(x, y, z);
    }

    public static Vector3Int FUN_24148_2(VigTransform transform, Vector3Int v)
    {
        Coprocessor2.rotationMatrix.rt11 = transform.rotation.V00;
        Coprocessor2.rotationMatrix.rt12 = transform.rotation.V01;
        Coprocessor2.rotationMatrix.rt13 = transform.rotation.V02;
        Coprocessor2.rotationMatrix.rt21 = transform.rotation.V10;
        Coprocessor2.rotationMatrix.rt22 = transform.rotation.V11;
        Coprocessor2.rotationMatrix.rt23 = transform.rotation.V12;
        Coprocessor2.rotationMatrix.rt31 = transform.rotation.V20;
        Coprocessor2.rotationMatrix.rt32 = transform.rotation.V21;
        Coprocessor2.rotationMatrix.rt33 = transform.rotation.V22;
        Coprocessor2.accumulator.ir1 = (short)(v.x >> 15);
        Coprocessor2.accumulator.ir2 = (short)(v.y >> 15);
        Coprocessor2.accumulator.ir3 = (short)(v.z >> 15);
        Coprocessor2.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 0, lm: false);
        int num = Coprocessor2.mathsAccumulator.mac1 << 3;
        int num2 = Coprocessor2.mathsAccumulator.mac2 << 3;
        int num3 = Coprocessor2.mathsAccumulator.mac3 << 3;
        Coprocessor2.translationVector._trx = transform.position.x;
        Coprocessor2.translationVector._try = transform.position.y;
        Coprocessor2.translationVector._trz = transform.position.z;
        Coprocessor2.accumulator.ir1 = (short)(v.x & 0x7FFF);
        Coprocessor2.accumulator.ir2 = (short)(v.y & 0x7FFF);
        Coprocessor2.accumulator.ir3 = (short)(v.z & 0x7FFF);
        Coprocessor2.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.TR, 12, lm: false);
        int x = Coprocessor2.mathsAccumulator.mac1 + num;
        int y = Coprocessor2.mathsAccumulator.mac2 + num2;
        int z = Coprocessor2.mathsAccumulator.mac3 + num3;
        return new Vector3Int(x, y, z);
    }

    public static Vector3Int FUN_24238(Matrix3x3 m33, Vector3Int v3)
    {
        Coprocessor.vector0.vx0 = (short)v3.x;
        Coprocessor.vector0.vy0 = (short)v3.y;
        Coprocessor.vector0.vz0 = (short)v3.z;
        FUN_243B4(m33);
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        return new Vector3Int(Coprocessor.accumulator.ir1, Coprocessor.accumulator.ir2, Coprocessor.accumulator.ir3);
    }

    public static Vector3Int FUN_24210(Matrix3x3 rot, Vector3Int normal)
    {
        FUN_243B4(rot);
        Coprocessor.vector0.vx0 = (short)normal.x;
        Coprocessor.vector0.vy0 = (short)normal.y;
        Coprocessor.vector0.vz0 = (short)normal.z;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        return new Vector3Int(Coprocessor.accumulator.ir1, Coprocessor.accumulator.ir2, Coprocessor.accumulator.ir3);
    }

    public static Vector3Int FUN_24094(Matrix3x3 rot, Vector3Int v)
    {
        Coprocessor.rotationMatrix.rt11 = rot.V00;
        Coprocessor.rotationMatrix.rt12 = rot.V01;
        Coprocessor.rotationMatrix.rt13 = rot.V02;
        Coprocessor.rotationMatrix.rt21 = rot.V10;
        Coprocessor.rotationMatrix.rt22 = rot.V11;
        Coprocessor.rotationMatrix.rt23 = rot.V12;
        Coprocessor.rotationMatrix.rt31 = rot.V20;
        Coprocessor.rotationMatrix.rt32 = rot.V21;
        Coprocessor.rotationMatrix.rt33 = rot.V22;
        Coprocessor.accumulator.ir1 = (short)(v.x >> 15);
        Coprocessor.accumulator.ir2 = (short)(v.y >> 15);
        Coprocessor.accumulator.ir3 = (short)(v.z >> 15);
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 0, lm: false);
        int num = Coprocessor.mathsAccumulator.mac1 << 3;
        int num2 = Coprocessor.mathsAccumulator.mac2 << 3;
        int num3 = Coprocessor.mathsAccumulator.mac3 << 3;
        Coprocessor.vector0.vx0 = (short)(v.x & 0x7FFF);
        Coprocessor.vector0.vy0 = (short)(v.y & 0x7FFF);
        Coprocessor.vector0.vz0 = (short)(v.z & 0x7FFF);
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        int x = Coprocessor.mathsAccumulator.mac1 + num;
        int y = Coprocessor.mathsAccumulator.mac2 + num2;
        int z = Coprocessor.mathsAccumulator.mac3 + num3;
        return new Vector3Int(x, y, z);
    }

    public static Vector3Int FUN_23EA0(Vector3Int v3)
    {
        Coprocessor.vector0.vx0 = (short)v3.x;
        Coprocessor.vector0.vy0 = (short)v3.y;
        Coprocessor.vector0.vz0 = (short)v3.z;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        return new Vector3Int(Coprocessor.accumulator.ir1, Coprocessor.accumulator.ir2, Coprocessor.accumulator.ir3);
    }

    public static Vector3Int FUN_23ED0(VigTransform transform, Vector3Int v3)
    {
        Coprocessor.rotationMatrix.rt11 = transform.rotation.V00;
        Coprocessor.rotationMatrix.rt12 = transform.rotation.V01;
        Coprocessor.rotationMatrix.rt13 = transform.rotation.V02;
        Coprocessor.rotationMatrix.rt21 = transform.rotation.V10;
        Coprocessor.rotationMatrix.rt22 = transform.rotation.V11;
        Coprocessor.rotationMatrix.rt23 = transform.rotation.V12;
        Coprocessor.rotationMatrix.rt31 = transform.rotation.V20;
        Coprocessor.rotationMatrix.rt32 = transform.rotation.V21;
        Coprocessor.rotationMatrix.rt33 = transform.rotation.V22;
        Coprocessor.translationVector._trx = transform.position.x;
        Coprocessor.translationVector._try = transform.position.y;
        Coprocessor.translationVector._trz = transform.position.z;
        Coprocessor.vector0.vx0 = (short)v3.x;
        Coprocessor.vector0.vy0 = (short)v3.y;
        Coprocessor.vector0.vz0 = (short)v3.z;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        int y = transform.position.y;
        int z = transform.position.z;
        int mac = Coprocessor.mathsAccumulator.mac1;
        int mac2 = Coprocessor.mathsAccumulator.mac2;
        int mac3 = Coprocessor.mathsAccumulator.mac3;
        return new Vector3Int(transform.position.x + mac, y + mac2, z + mac3);
    }

    public static void FUN_24BFC(int param1, Vector2Int param2, Vector2Int param3, Vector3Int in_v0, Vector3Int in_v1, ref Primitive param4)
    {
        Coprocessor.accumulator.ir0 = (short)param1;
        Coprocessor.accumulator.ir1 = (short)(in_v0.x - in_v1.x);
        Coprocessor.accumulator.ir2 = (short)(in_v0.y - in_v1.y);
        Coprocessor.accumulator.ir3 = (short)(in_v0.z - in_v1.z);
        Coprocessor.ExecuteGPF(12, lm: false);
        int ir = Coprocessor.accumulator.ir1;
        int ir2 = Coprocessor.accumulator.ir2;
        int ir3 = Coprocessor.accumulator.ir3;
        Coprocessor.vector0.vx0 = (short)(ir + in_v1.x);
        Coprocessor.vector0.vy0 = (short)(ir2 + in_v1.y);
        Coprocessor.vector0.vz0 = (short)(ir3 + in_v1.z);
        Coprocessor.ExecuteRTPS(12, lm: false);
        param4.screen = new Vector2Int(Coprocessor.screenXYFIFO.sx2, Coprocessor.screenXYFIFO.sy2);
        param4.verts = new Vector3Int(Coprocessor.screenXYZFIFO.sx2, Coprocessor.screenXYZFIFO.sy2, Coprocessor.screenXYZFIFO.sz2);
        Coprocessor.accumulator.ir0 = (short)param1;
        Coprocessor.accumulator.ir1 = (short)(param2.x << 4);
        Coprocessor.accumulator.ir2 = (short)(param2.y << 4);
        Coprocessor.ExecuteGPF(12, lm: false);
        Coprocessor.accumulator.ir0 = (short)(4096 - param1);
        Coprocessor.accumulator.ir1 = (short)(param3.x << 4);
        Coprocessor.accumulator.ir2 = (short)(param3.y << 4);
        Coprocessor.ExecuteGPL(12, lm: false);
        param4.uvs = new Vector2Int(Coprocessor.colorFIFO.r2, Coprocessor.colorFIFO.g2);
    }

    public static int FUN_26B80(int param1, int param2, int param3, int param4, Primitive[] primitives)
    {
        Vector3Int vector3Int = new Vector3Int(Coprocessor.vector0.vx0, Coprocessor.vector0.vy0, Coprocessor.vector0.vz0);
        Vector3Int vector3Int2 = new Vector3Int(Coprocessor.vector1.vx1, Coprocessor.vector1.vy1, Coprocessor.vector1.vz1);
        Vector3Int vector3Int3 = new Vector3Int(Coprocessor.vector2.vx2, Coprocessor.vector2.vy2, Coprocessor.vector2.vz2);
        if (param2 < 0)
        {
            if (param3 < 0)
            {
                if (-1 < param4)
                {
                    primitives[param1 + 2].screen = new Vector2Int(Coprocessor.screenXYFIFO.sx2, Coprocessor.screenXYFIFO.sy2);
                    primitives[param1 + 2].verts = new Vector3Int(Coprocessor.screenXYZFIFO.sx2, Coprocessor.screenXYZFIFO.sy2, Coprocessor.screenXYZFIFO.sz2);
                    int param5 = (param4 << 12) / (param4 - param3);
                    FUN_24BFC((param4 << 12) / (param4 - param2), primitives[param1].uvs, primitives[param1 + 2].uvs, vector3Int, vector3Int3, ref primitives[param1]);
                    FUN_24BFC(param5, primitives[param1 + 1].uvs, primitives[param1 + 2].uvs, vector3Int2, vector3Int3, ref primitives[param1 + 1]);
                    return 3;
                }
                return 0;
            }
            if (param4 < 0)
            {
                primitives[param1 + 1].screen = new Vector2Int(Coprocessor.screenXYFIFO.sx1, Coprocessor.screenXYFIFO.sy1);
                primitives[param1 + 1].verts = new Vector3Int(Coprocessor.screenXYZFIFO.sx1, Coprocessor.screenXYZFIFO.sy1, Coprocessor.screenXYZFIFO.sz1);
                int param6 = (param3 << 12) / (param3 - param4);
                FUN_24BFC((param3 << 12) / (param3 - param2), primitives[param1].uvs, primitives[param1 + 1].uvs, vector3Int, vector3Int2, ref primitives[param1]);
                FUN_24BFC(param6, primitives[param1 + 2].uvs, primitives[param1 + 1].uvs, vector3Int3, vector3Int2, ref primitives[param1 + 2]);
                return 3;
            }
            primitives[param1 + 1].screen = new Vector2Int(Coprocessor.screenXYFIFO.sx1, Coprocessor.screenXYFIFO.sy1);
            primitives[param1 + 1].verts = new Vector3Int(Coprocessor.screenXYZFIFO.sx1, Coprocessor.screenXYZFIFO.sy1, Coprocessor.screenXYZFIFO.sz1);
            primitives[param1 + 3].screen = new Vector2Int(Coprocessor.screenXYFIFO.sx2, Coprocessor.screenXYFIFO.sy2);
            primitives[param1 + 3].verts = new Vector3Int(Coprocessor.screenXYZFIFO.sx2, Coprocessor.screenXYZFIFO.sy2, Coprocessor.screenXYZFIFO.sz2);
            primitives[param1 + 3].uvs = primitives[param1 + 2].uvs;
            int param7 = (param3 << 12) / (param3 - param2);
            FUN_24BFC((param4 << 12) / (param4 - param2), primitives[param1].uvs, primitives[param1 + 2].uvs, vector3Int, vector3Int3, ref primitives[param1 + 2]);
            FUN_24BFC(param7, primitives[param1].uvs, primitives[param1 + 1].uvs, vector3Int, vector3Int2, ref primitives[param1]);
            return 4;
        }
        if (param3 < 0)
        {
            if (param4 < 0)
            {
                primitives[param1].screen = new Vector2Int(Coprocessor.screenXYFIFO.sx0, Coprocessor.screenXYFIFO.sy0);
                primitives[param1].verts = new Vector3Int(Coprocessor.screenXYZFIFO.sx0, Coprocessor.screenXYZFIFO.sy0, Coprocessor.screenXYZFIFO.sz0);
                int param8 = (param2 << 12) / (param2 - param4);
                FUN_24BFC((param2 << 12) / (param2 - param3), primitives[param1 + 1].uvs, primitives[param1].uvs, vector3Int2, vector3Int, ref primitives[param1 + 1]);
                FUN_24BFC(param8, primitives[param1 + 2].uvs, primitives[param1].uvs, vector3Int3, vector3Int, ref primitives[param1 + 2]);
                return 3;
            }
            primitives[param1].screen = new Vector2Int(Coprocessor.screenXYFIFO.sx0, Coprocessor.screenXYFIFO.sy0);
            primitives[param1].verts = new Vector3Int(Coprocessor.screenXYZFIFO.sx0, Coprocessor.screenXYZFIFO.sy0, Coprocessor.screenXYZFIFO.sz0);
            primitives[param1 + 2].screen = new Vector2Int(Coprocessor.screenXYFIFO.sx2, Coprocessor.screenXYFIFO.sy2);
            primitives[param1 + 2].verts = new Vector3Int(Coprocessor.screenXYZFIFO.sx2, Coprocessor.screenXYZFIFO.sy2, Coprocessor.screenXYZFIFO.sz2);
            int param9 = (param2 << 12) / (param2 - param3);
            FUN_24BFC((param4 << 12) / (param4 - param3), primitives[param1 + 1].uvs, primitives[param1 + 2].uvs, vector3Int2, vector3Int3, ref primitives[param1 + 3]);
            FUN_24BFC(param9, primitives[param1 + 1].uvs, primitives[param1].uvs, vector3Int2, vector3Int, ref primitives[param1 + 1]);
            return 4;
        }
        if (param4 < 0)
        {
            primitives[param1].screen = new Vector2Int(Coprocessor.screenXYFIFO.sx0, Coprocessor.screenXYFIFO.sy0);
            primitives[param1].verts = new Vector3Int(Coprocessor.screenXYZFIFO.sx0, Coprocessor.screenXYZFIFO.sy0, Coprocessor.screenXYZFIFO.sz0);
            primitives[param1 + 1].screen = new Vector2Int(Coprocessor.screenXYFIFO.sx1, Coprocessor.screenXYFIFO.sy1);
            primitives[param1 + 1].verts = new Vector3Int(Coprocessor.screenXYZFIFO.sx1, Coprocessor.screenXYZFIFO.sy1, Coprocessor.screenXYZFIFO.sz1);
            int param10 = (param2 << 12) / (param2 - param4);
            FUN_24BFC((param3 << 12) / (param3 - param4), primitives[param1 + 2].uvs, primitives[param1 + 1].uvs, vector3Int3, vector3Int2, ref primitives[param1 + 3]);
            FUN_24BFC(param10, primitives[param1 + 2].uvs, primitives[param1].uvs, vector3Int3, vector3Int, ref primitives[param1 + 2]);
            return 4;
        }
        primitives[param1].screen = new Vector2Int(Coprocessor.screenXYFIFO.sx0, Coprocessor.screenXYFIFO.sy0);
        primitives[param1].verts = new Vector3Int(Coprocessor.screenXYZFIFO.sx0, Coprocessor.screenXYZFIFO.sy0, Coprocessor.screenXYZFIFO.sz0);
        primitives[param1 + 1].screen = new Vector2Int(Coprocessor.screenXYFIFO.sx1, Coprocessor.screenXYFIFO.sy1);
        primitives[param1 + 1].verts = new Vector3Int(Coprocessor.screenXYZFIFO.sx1, Coprocessor.screenXYZFIFO.sy1, Coprocessor.screenXYZFIFO.sz1);
        primitives[param1 + 2].screen = new Vector2Int(Coprocessor.screenXYFIFO.sx2, Coprocessor.screenXYFIFO.sy2);
        primitives[param1 + 2].verts = new Vector3Int(Coprocessor.screenXYZFIFO.sx2, Coprocessor.screenXYZFIFO.sy2, Coprocessor.screenXYZFIFO.sz2);
        return 3;
    }

    public static void FUN_18C54(BinaryReader param1, int param2, BinaryWriter param3, long param4)
    {
        if (0 >= param2)
        {
            return;
        }
        uint num = 2216757315u;
        uint num2 = 2155905153u;
        uint num3 = 0u;
        for (int i = 0; i < param2; i++)
        {
            ushort num4 = param1.ReadUInt16();
            uint num5 = (uint)(num4 << 16);
            if (num5 == 0)
            {
                param3.Write(num4);
                continue;
            }
            int num6 = ((num4 & 0x1F) << 8) - (num4 & 0x1F);
            int num7 = (int)((long)num6 * (long)(int)num >> 32);
            int num8 = ((int)num5 >> 21) & 0x1F;
            int num9 = (num8 << 8) - num8;
            int num10 = (int)((long)num9 * (long)(int)num >> 32);
            num8 = (((int)num5 >> 26) & 0x1F);
            int num11 = (num8 << 8) - num8;
            int num12 = num7 + num6 >> 4;
            num12 -= num6 >> 31;
            num12 &= 0xFF;
            num3 = (uint)(((int)num3 & -256) | num12);
            int num13 = (int)((long)num11 * (long)(int)num >> 32);
            num3 = (uint)((int)num3 & -65281);
            num8 = num10 + num9 >> 4;
            num9 >>= 31;
            num8 = ((num8 - num9) & 0xFF) << 8;
            num3 = (uint)(((int)num3 | num8) & -16711681);
            num8 = num13 + num11 >> 4;
            num11 >>= 31;
            num8 = ((num8 - num11) & 0xFF) << 16;
            num3 = (uint)((int)num3 | num8);
            Color32 color = DpqColor(new Color32((byte)num3, (byte)(num3 >> 8), (byte)(num3 >> 16), (byte)(num3 >> 24)), param4);
            num11 = (color.r << 5) - color.r + 128;
            num6 = (int)((long)num11 * (long)(int)num2 >> 32);
            num12 = (color.g << 5) - color.g + 128;
            int num14 = (int)((long)num12 * (long)(int)num2 >> 32);
            num9 = (color.b << 5) - color.b + 128;
            int num15 = (int)((long)num9 * (long)(int)num2 >> 32);
            num6 = num6 + num11 >> 7;
            num11 >>= 31;
            num6 -= num11;
            num8 = num14 + num12 >> 7;
            num12 >>= 31;
            num8 = num8 - num12 << 5;
            num6 |= num8;
            num8 = num15 + num9 >> 7;
            num9 >>= 31;
            num8 = num8 - num9 << 10;
            num6 |= num8;
            num8 = (num4 & -32768);
            num6 |= num8;
            param3.Write((short)num6);
        }
    }

    public static int FUN_51E08(VigObject param1, ref Vehicle.AI param2, int param3)
    {
        int num = param2.DAT_08 - param1.vTransform.position.x;
        int num2 = param2.DAT_0C - param1.vTransform.position.z;
        int num3 = num;
        if (num < 0)
        {
            num3 = -num;
        }
        if (num3 < param3)
        {
            num3 = num2;
            if (num2 < 0)
            {
                num3 = -num2;
            }
            if (num3 < param3)
            {
                if (0 < param2.DAT_00)
                {
                    short num4 = param2.DAT_02++;
                    Vector2Int vector2Int = default(Vector2Int);
                    vector2Int.x = param2.DAT_04[((ushort)(num4 + 1) << 16 >> 14) / 2];
                    vector2Int.y = param2.DAT_04[((ushort)(num4 + 1) << 16 >> 14) / 2 + 1];
                    if (vector2Int.x != 0 || vector2Int.y != 0)
                    {
                        param2.DAT_08 = vector2Int.x << 16;
                        param2.DAT_0C = vector2Int.y << 16;
                        goto IL_00ea;
                    }
                }
                param2.DAT_00 = -1;
            }
        }
        goto IL_00ea;
    IL_00ea:
        return (int)((long)Ratan2(num, num2) << 20) >> 20;
    }

    public static VigObject FUN_52188(VigObject src, Type type)
    {
        VigObject obj = src.gameObject.AddComponent(type) as VigObject;
        obj.flags = src.flags;
        obj.type = src.type;
        obj.tags = src.tags;
        obj.id = src.id;
        obj.child = src.child;
        obj.child2 = src.child2;
        obj.parent = src.parent;
        obj.DAT_18 = src.DAT_18;
        obj.DAT_19 = src.DAT_19;
        obj.DAT_1A = src.DAT_1A;
        obj.maxHalfHealth = src.maxHalfHealth;
        obj.maxFullHealth = src.maxFullHealth;
        obj.vTransform = src.vTransform;
        obj.vMesh = src.vMesh;
        obj.vr = src.vr;
        obj.DAT_4A = src.DAT_4A;
        obj.screen = src.screen;
        obj.DAT_58 = src.DAT_58;
        obj.vData = src.vData;
        obj.vCollider = src.vCollider;
        obj.vAnim = src.vAnim;
        obj.vLOD = src.vLOD;
        obj.DAT_6C = src.DAT_6C;
        obj.vShadow = src.vShadow;
        obj.PDAT_74 = src.PDAT_74;
        obj.CCDAT_74 = src.CCDAT_74;
        obj.IDAT_74 = src.IDAT_74;
        obj.PDAT_78 = src.PDAT_78;
        obj.IDAT_78 = src.IDAT_78;
        obj.PDAT_7C = src.PDAT_7C;
        obj.IDAT_7C = src.IDAT_7C;
        obj.physics1 = src.physics1;
        obj.physics2 = src.physics2;
        obj.DAT_A0 = src.DAT_A0;
        obj.DAT_A6 = src.DAT_A6;
        src.transform.parent = null;
        UnityEngine.Object.Destroy(src);
        return obj;
    }

    public static int LeadingZeros(int x)
    {
        if ((x & 2147483648u) != 0L)
        {
            x ^= -1;
        }
        if (x == 0)
        {
            return 32;
        }
        x |= x >> 1;
        x |= x >> 2;
        x |= x >> 4;
        x |= x >> 8;
        x |= x >> 16;
        x -= ((x >> 1) & 0x55555555);
        x = ((x >> 2) & 0x33333333) + (x & 0x33333333);
        x = (((x >> 4) + x) & 0xF0F0F0F);
        x += x >> 8;
        x += x >> 16;
        return 32 - (x & 0x3F);
    }

    public static long SquareRoot(long a)
    {
        int num = LeadingZeros((int)a);
        int num2 = 0;
        if (num != 32)
        {
            int num3 = num & -2;
            int num4 = 31 - num3 >> 1;
            int num5 = num3 - 24;
            num2 = ((num5 >= 0) ? ((int)a << num5) : ((int)a >> 24 - num3));
            num2 -= 64;
            num2 <<= 1;
            return (uint)(GameManager.SQRT[num2 / 2] << num4) >> 12;
        }
        return 0L;
    }

    public static int Ratan2(int y, int x)
    {
        bool flag = x < 0;
        if (flag)
        {
            x = -x;
        }
        bool flag2 = y < 0;
        if (flag2)
        {
            y = -y;
        }
        int result = 0;
        int num = 0;
        if (x != 0 || y != 0)
        {
            if (y < x)
            {
                result = x >> 10;
                if (((long)y & 2145386496L) == 0L)
                {
                    switch (x)
                    {
                        case 0:
                            return 0;
                        case -1:
                            if (((long)y & 4194303L) == 2097152)
                            {
                                return 0;
                            }
                            break;
                    }
                    y = (y << 10) / x;
                    num = GameManager.DAT_69C90[(y << 1) / 2];
                    if (flag)
                    {
                        num = 2048 - num;
                    }
                    if (flag2)
                    {
                        num = -num;
                    }
                    return num;
                }
                switch (result)
                {
                    case 0:
                        return 0;
                    case -1:
                        if (y == int.MinValue)
                        {
                            return 0;
                        }
                        break;
                }
                y /= result;
                num = GameManager.DAT_69C90[(y << 1) / 2];
                if (flag)
                {
                    num = 2048 - num;
                }
                if (flag2)
                {
                    num = -num;
                }
                return num;
            }
            result = y >> 10;
            if (((long)x & 2145386496L) != 0L)
            {
                switch (result)
                {
                    case 0:
                        return 0;
                    case -1:
                        if (x == int.MinValue)
                        {
                            return 0;
                        }
                        break;
                }
                y = x / result;
                num = 1024 - GameManager.DAT_69C90[(y << 1) / 2];
                if (flag)
                {
                    num = 2048 - num;
                }
                if (flag2)
                {
                    num = -num;
                }
                return num;
            }
            switch (y)
            {
                case 0:
                    return 0;
                case -1:
                    if (x << 10 == int.MinValue)
                    {
                        return 0;
                    }
                    break;
            }
            y = (x << 10) / y;
            num = 1024 - GameManager.DAT_69C90[(y << 1) / 2];
            if (flag)
            {
                num = 2048 - num;
            }
            if (flag2)
            {
                num = -num;
            }
            return num;
        }
        return result;
    }

    public static long Divdi3(int param1, int param2, int param3, int param4)
    {
        int num = 0;
        if (param2 < 0)
        {
            num = -1;
            param1 = -param1;
            param2 = -((param1 != 0) ? 1 : 0) - param2;
        }
        if (param4 < 0)
        {
            num = ~num;
            param4 = -((-param3 != 0) ? 1 : 0) - param4;
            param3 = -param3;
        }
        long num2 = (long)Udivmoddi4((uint)param1, (uint)param2, (uint)param3, (uint)param4, null);
        if (num != 0)
        {
            num2 = -num2;
        }
        return num2;
    }

    public static ulong Udivmoddi4(uint param1, uint param2, uint param3, uint param4, uint[] param5)
    {
        int num;
        uint num4;
        uint num7;
        uint num3;
        uint num5;
        uint num11;
        uint num2;
        uint num8;
        uint num10;
        uint num6;
        if (param4 == 0)
        {
            if (param2 < param3)
            {
                if (65535 < param3)
                {
                    num = 24;
                    if (param3 < 16777216)
                    {
                        num = 16;
                    }
                }
                else
                {
                    num = (((param3 < 256) ? 1 : 0) ^ 1);
                    num <<= 3;
                }
                num2 = (uint)(32 - (DAT_10AE0[param3 >> num] + num));
                num3 = num2;
                if (num2 != 0)
                {
                    param3 <<= (int)(num2 & 0x1F);
                    param2 = ((param2 << (int)(num2 & 0x1F)) | (param1 >> (int)((32 - num2) & 0x1F)));
                    param1 <<= (int)(num2 & 0x1F);
                }
                num2 = param3 >> 16;
                num4 = param2 / num2;
                if (num2 == 0)
                {
                    return 0uL;
                }
                num5 = num4 * (param3 & 0xFFFF);
                num6 = ((param2 % num2 << 16) | (param1 >> 16));
                num7 = num4;
                if (num6 < num5)
                {
                    num6 += param3;
                    num7 = num4 - 1;
                    if (param3 <= num6 && num6 < num5)
                    {
                        num7 = num4 - 2;
                        num6 += param3;
                    }
                }
                num4 = (num6 - num5) / num2;
                if (num2 == 0)
                {
                    return 0uL;
                }
                num8 = num4 * (param3 & 0xFFFF);
                num5 = (((num6 - num5) % num2 << 16) | (param1 & 0xFFFF));
                num6 = num4;
                if (num5 < num8)
                {
                    num5 += param3;
                    num6 = num4 - 1;
                    if (param3 <= num5 && num5 < num8)
                    {
                        num6 = num4 - 2;
                    }
                }
                if (param5 != null)
                {
                    param5[0] = param1 >> (int)num3;
                    param5[1] = 0u;
                }
                return (num7 << 16) | num6;
            }
            bool flag = 65535 < param3;
            if (param3 == 0)
            {
                if (param4 == 0)
                {
                    return 0uL;
                }
                param3 = 1u / param4;
                flag = (65535 < param3);
            }
            if (!flag)
            {
                num = (((param3 < 256) ? 1 : 0) ^ 1);
                num <<= 3;
            }
            else
            {
                num = 24;
                if (param3 < 16777216)
                {
                    num = 16;
                }
            }
            num2 = (uint)(32 - (DAT_10AE0[param3 >> num] + num));
            num3 = num2;
            uint num9;
            if (num2 == 0)
            {
                num2 = param2;
                num8 = param3;
                num9 = 1u;
            }
            else
            {
                param3 <<= (int)(num2 & 0x1F);
                num4 = param2 >> (int)((32 - num2) & 0x1F);
                num7 = ((param2 << (int)(num2 & 0x1F)) | (param1 >> (int)((32 - num2) & 0x1F)));
                num6 = param3 >> 16;
                if (num6 == 0)
                {
                    return 0uL;
                }
                num10 = num4 / num6;
                num5 = num10 * (param3 & 0xFFFF);
                num4 = ((num4 % num6 << 16) | (num7 >> 16));
                param1 <<= (int)num2;
                if (num4 < num5)
                {
                    num4 += param3;
                    num10--;
                    if (param3 <= num4 && num4 < num5)
                    {
                        num4 += param3;
                        num10--;
                    }
                }
                if (num6 == 0)
                {
                    return 0uL;
                }
                num11 = (num4 - num5) / num6;
                num8 = num11 * (param3 & 0xFFFF);
                num2 = (((num4 - num5) % num6 << 16) | (num7 & 0xFFFF));
                num4 = num10 << 16;
                if (num2 < num8)
                {
                    num4 = num10 << 16;
                    num2 += param3;
                    num11--;
                    if (param3 <= num2 && num2 < num8)
                    {
                        num2 += param3;
                        num11--;
                    }
                }
                num9 = (num4 | num11);
            }
            num4 = param3 >> 16;
            num7 = (num2 - num8) / num4;
            if (num4 == 0)
            {
                return 0uL;
            }
            num5 = num7 * (param3 * 65535);
            num2 = (((num2 - num8) % num4 << 16) | (param1 >> 16));
            num6 = num7;
            if (num2 < num5)
            {
                num2 += param3;
                num6 = num7 - 1;
                if (param3 <= num2 && num2 < num5)
                {
                    num6 = num7 - 2;
                    num2 += param3;
                }
            }
            num7 = (num2 - num5) / num4;
            if (num4 == 0)
            {
                return 0uL;
            }
            num8 = num7 * (param3 & 0xFFFF);
            num4 = (((num2 - num5) % num4 << 16) | (param1 & 0xFFFF));
            num2 = num7;
            if (num4 < num8)
            {
                num4 += param3;
                num2 = num7 - 1;
                if (param3 <= num4 && num4 < num8)
                {
                    num2 = num7 - 2;
                }
            }
            num2 = ((num6 << 16) | num2);
            if (param5 != null)
            {
                param5[0] = num4 - num8 >> (int)num3;
                param5[1] = 0u;
            }
            return ((ulong)num9 << 32) | num2;
        }
        num2 = 0u;
        if (param2 < param4)
        {
            if (param5 != null)
            {
                param5[0] = param1;
                param5[1] = param2;
            }
            return 0uL;
        }
        if (param4 < 65536)
        {
            num = (((param4 < 256) ? 1 : 0) ^ 1);
            num <<= 3;
        }
        else
        {
            num = 24;
            if (param4 < 16777216)
            {
                num = 16;
            }
        }
        num4 = (uint)(32 - (DAT_10AE0[param3 >> num] + num));
        num7 = 32 - num4;
        num3 = num4;
        if (num4 == 0)
        {
            if (param4 < param2 || param3 <= param1)
            {
                num2 = 1u;
                num4 = param1 - param3;
                num7 = (uint)((int)(param2 - param4) - ((param1 < num2) ? 1 : 0));
            }
            else
            {
                num2 = 0u;
            }
            if (param5 != null)
            {
                param5[0] = num4;
                param5[1] = num7;
            }
            return num2;
        }
        num5 = ((param4 << (int)num4) | (param3 >> (int)num7));
        param3 <<= (int)num4;
        num2 = param2 >> (int)num7;
        num6 = ((param2 << (int)num4) | (param1 >> (int)num7));
        num8 = num5 >> 16;
        num10 = num2 / num8;
        if (num8 == 0)
        {
            return 0uL;
        }
        num11 = num10 * (num5 & 0xFFFF);
        num2 = ((num2 % num8 << 16) | (num6 >> 16));
        param1 <<= (int)num4;
        uint num12 = num10;
        if (num2 < num11)
        {
            num2 += num5;
            num12 = num10 - 1;
            if (num5 <= num2 && num2 < num11)
            {
                num12 = num10 - 2;
                num2 += num5;
            }
        }
        num10 = (num2 - num11) / num8;
        if (num8 == 0)
        {
            return 0uL;
        }
        uint num13 = num10 * (num5 & 0xFFFF);
        num6 = (((num2 - num11) % num8 << 16) | (num6 & 0xFFFF));
        num2 = num10;
        if (num6 < num13)
        {
            num6 += num5;
            num2 = num10 - 1;
            if (num5 <= num6 && num6 < num13)
            {
                num2 = num10 - 2;
                num6 += num5;
            }
        }
        num2 = ((num12 << 16) | num2);
        num6 -= num13;
        long num14 = (long)num2 * (long)param3;
        num8 = (uint)num14;
        num10 = (uint)((ulong)num14 >> 32);
        param3 = num8 - param3;
        if (num6 < num10 || (num10 == num6 && param1 < num8))
        {
            num2--;
            num10 = (uint)((int)(num10 - num5) - ((num8 < param3) ? 1 : 0));
            num8 = param3;
        }
        if (param5 != null)
        {
            num6 = (uint)((int)(num6 - num10) - ((param1 < param1 - num8) ? 1 : 0));
            param5[0] = ((num6 << (int)num7) | (param1 - num8 >> (int)num4));
            param5[1] = num6 >> (int)num4;
        }
        return num2;
    }

    public static void SetFogNearFar(int a, int b, int h)
    {
        int num = b - a;
        if (99 >= num)
        {
            return;
        }
        switch (num)
        {
            case 0:
                return;
            case -1:
                if (-a * b == int.MinValue)
                {
                    return;
                }
                break;
        }
        switch (num)
        {
            case 0:
                return;
            case -1:
                if (b << 12 == int.MinValue)
                {
                    return;
                }
                break;
        }
        int num2 = -a * b / num << 8;
        int num3 = num2 / h;
        switch (h)
        {
            case 0:
                return;
            case -1:
                if (num2 == int.MinValue)
                {
                    return;
                }
                break;
        }
        if (num3 < -32768)
        {
            num3 = -32768;
        }
        if (32767 < num3)
        {
            num3 = 32767;
        }
        SetDQA(num3);
        SetDQB((b << 12) / num << 12);
    }

    public static void SetFogNearFar2(int a, int b, int h)
    {
        int num = b - a;
        if (99 >= num)
        {
            return;
        }
        switch (num)
        {
            case 0:
                return;
            case -1:
                if (-a * b == int.MinValue)
                {
                    return;
                }
                break;
        }
        switch (num)
        {
            case 0:
                return;
            case -1:
                if (b << 12 == int.MinValue)
                {
                    return;
                }
                break;
        }
        int num2 = -a * b / num << 8;
        int num3 = num2 / h;
        switch (h)
        {
            case 0:
                return;
            case -1:
                if (num2 == int.MinValue)
                {
                    return;
                }
                break;
        }
        if (num3 < -32768)
        {
            num3 = -32768;
        }
        if (32767 < num3)
        {
            num3 = 32767;
        }
        SetDQA2(num3);
        SetDQB2((b << 12) / num << 12);
    }

    public static void SetFogNearFar3(int a, int b, int h)
    {
        int num = b - a;
        if (99 >= num)
        {
            return;
        }
        switch (num)
        {
            case 0:
                return;
            case -1:
                if (-a * b == int.MinValue)
                {
                    return;
                }
                break;
        }
        switch (num)
        {
            case 0:
                return;
            case -1:
                if (b << 12 == int.MinValue)
                {
                    return;
                }
                break;
        }
        int num2 = -a * b / num << 8;
        int num3 = num2 / h;
        switch (h)
        {
            case 0:
                return;
            case -1:
                if (num2 == int.MinValue)
                {
                    return;
                }
                break;
        }
        if (num3 < -32768)
        {
            num3 = -32768;
        }
        if (32767 < num3)
        {
            num3 = 32767;
        }
        SetDQA3(num3);
        SetDQB3((b << 12) / num << 12);
    }

    public static Matrix3x3 MulMatrix(Matrix3x3 m0, Matrix3x3 m1)
    {
        Coprocessor.rotationMatrix.rt11 = m0.V00;
        Coprocessor.rotationMatrix.rt12 = m0.V01;
        Coprocessor.rotationMatrix.rt13 = m0.V02;
        Coprocessor.rotationMatrix.rt21 = m0.V10;
        Coprocessor.rotationMatrix.rt22 = m0.V11;
        Coprocessor.rotationMatrix.rt23 = m0.V12;
        Coprocessor.rotationMatrix.rt31 = m0.V20;
        Coprocessor.rotationMatrix.rt32 = m0.V21;
        Coprocessor.rotationMatrix.rt33 = m0.V22;
        Coprocessor.vector0.vx0 = m1.V00;
        Coprocessor.vector0.vy0 = m1.V10;
        Coprocessor.vector0.vz0 = m1.V20;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        short ir = Coprocessor.accumulator.ir1;
        short ir2 = Coprocessor.accumulator.ir2;
        short ir3 = Coprocessor.accumulator.ir3;
        Coprocessor.vector0.vx0 = m1.V01;
        Coprocessor.vector0.vy0 = m1.V11;
        Coprocessor.vector0.vz0 = m1.V21;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        short ir4 = Coprocessor.accumulator.ir1;
        short ir5 = Coprocessor.accumulator.ir2;
        short ir6 = Coprocessor.accumulator.ir3;
        Coprocessor.vector0.vx0 = m1.V02;
        Coprocessor.vector0.vy0 = m1.V12;
        Coprocessor.vector0.vz0 = m1.V22;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        short ir7 = Coprocessor.accumulator.ir1;
        short ir8 = Coprocessor.accumulator.ir2;
        short ir9 = Coprocessor.accumulator.ir3;
        Matrix3x3 result = default(Matrix3x3);
        result.V00 = ir;
        result.V01 = ir4;
        result.V20 = ir3;
        result.V21 = ir6;
        result.V02 = ir7;
        result.V10 = ir2;
        result.V11 = ir5;
        result.V12 = ir8;
        result.V22 = ir9;
        return result;
    }

    public static VigTransform CompMatrixLV(VigTransform m0, VigTransform m1)
    {
        Coprocessor.rotationMatrix.rt11 = m0.rotation.V00;
        Coprocessor.rotationMatrix.rt12 = m0.rotation.V01;
        Coprocessor.rotationMatrix.rt13 = m0.rotation.V02;
        Coprocessor.rotationMatrix.rt21 = m0.rotation.V10;
        Coprocessor.rotationMatrix.rt22 = m0.rotation.V11;
        Coprocessor.rotationMatrix.rt23 = m0.rotation.V12;
        Coprocessor.rotationMatrix.rt31 = m0.rotation.V20;
        Coprocessor.rotationMatrix.rt32 = m0.rotation.V21;
        Coprocessor.rotationMatrix.rt33 = m0.rotation.V22;
        Coprocessor.vector0.vx0 = m1.rotation.V00;
        Coprocessor.vector0.vy0 = m1.rotation.V10;
        Coprocessor.vector0.vz0 = m1.rotation.V20;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        uint num = (ushort)Coprocessor.accumulator.ir1;
        int ir = Coprocessor.accumulator.ir2;
        uint num2 = (ushort)Coprocessor.accumulator.ir3;
        Coprocessor.vector0.vx0 = m1.rotation.V01;
        Coprocessor.vector0.vy0 = m1.rotation.V11;
        Coprocessor.vector0.vz0 = m1.rotation.V21;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        int ir2 = Coprocessor.accumulator.ir1;
        uint num3 = (ushort)Coprocessor.accumulator.ir2;
        int ir3 = Coprocessor.accumulator.ir3;
        Coprocessor.vector0.vx0 = m1.rotation.V02;
        Coprocessor.vector0.vy0 = m1.rotation.V12;
        Coprocessor.vector0.vz0 = m1.rotation.V22;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        VigTransform result = default(VigTransform);
        result.rotation.V01 = (short)ir2;
        result.rotation.V00 = (short)num;
        result.rotation.V21 = (short)ir3;
        result.rotation.V20 = (short)num2;
        num = (ushort)Coprocessor.accumulator.ir1;
        ir2 = Coprocessor.accumulator.ir2;
        short ir4 = Coprocessor.accumulator.ir3;
        result.rotation.V22 = ir4;
        result.rotation.V02 = (short)num;
        result.rotation.V10 = (short)ir;
        result.rotation.V11 = (short)num3;
        result.rotation.V12 = (short)ir2;
        num = (uint)m1.position.x;
        num2 = (uint)m1.position.y;
        num3 = (uint)m1.position.z;
        if ((int)num < 0)
        {
            ir2 = -((int)(0 - num) >> 15);
            num = 0 - ((0 - num) & 0x7FFF);
        }
        else
        {
            ir2 = (int)num >> 15;
            num &= 0x7FFF;
        }
        if ((int)num2 < 0)
        {
            ir = -((int)(0 - num2) >> 15);
            num2 = 0 - ((0 - num2) & 0x7FFF);
        }
        else
        {
            ir = (int)num2 >> 15;
            num2 &= 0x7FFF;
        }
        if ((int)num3 < 0)
        {
            ir3 = -((int)(0 - num3) >> 15);
            num3 = 0 - ((0 - num3) & 0x7FFF);
        }
        else
        {
            ir3 = (int)num3 >> 15;
            num3 &= 0x7FFF;
        }
        Coprocessor.accumulator.ir1 = (short)ir2;
        Coprocessor.accumulator.ir2 = (short)ir;
        Coprocessor.accumulator.ir3 = (short)ir3;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 0, lm: false);
        ir2 = Coprocessor.mathsAccumulator.mac1;
        ir = Coprocessor.mathsAccumulator.mac2;
        ir3 = Coprocessor.mathsAccumulator.mac3;
        Coprocessor.accumulator.ir1 = (short)num;
        Coprocessor.accumulator.ir2 = (short)num2;
        Coprocessor.accumulator.ir3 = (short)num3;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        ir2 = ((ir2 >= 0) ? (ir2 << 3) : (ir2 * 8));
        ir = ((ir >= 0) ? (ir << 3) : (ir * 8));
        ir3 = ((ir3 >= 0) ? (ir3 << 3) : (ir3 * 8));
        int mac = Coprocessor.mathsAccumulator.mac1;
        int mac2 = Coprocessor.mathsAccumulator.mac2;
        int mac3 = Coprocessor.mathsAccumulator.mac3;
        int y = m0.position.y;
        int z = m0.position.z;
        result.position = default(Vector3Int);
        result.position.x = mac + ir2 + m0.position.x;
        result.position.y = mac2 + ir + y;
        result.position.z = mac3 + ir3 + z;
        result.padding = 0;
        result.rotation.skewed = false;
        result.rotation._V00 = 0;
        result.rotation._V01 = 0;
        result.rotation._V02 = 0;
        result.rotation._V10 = 0;
        result.rotation._V11 = 0;
        result.rotation._V12 = 0;
        result.rotation._V20 = 0;
        result.rotation._V21 = 0;
        result.rotation._V22 = 0;
        return result;
    }

    public static Vector3Int ApplyMatrixSV(Matrix3x3 m33, Vector3Int v3)
    {
        Coprocessor.rotationMatrix.rt11 = m33.V00;
        Coprocessor.rotationMatrix.rt12 = m33.V01;
        Coprocessor.rotationMatrix.rt13 = m33.V02;
        Coprocessor.rotationMatrix.rt21 = m33.V10;
        Coprocessor.rotationMatrix.rt22 = m33.V11;
        Coprocessor.rotationMatrix.rt23 = m33.V12;
        Coprocessor.rotationMatrix.rt31 = m33.V20;
        Coprocessor.rotationMatrix.rt32 = m33.V21;
        Coprocessor.rotationMatrix.rt33 = m33.V22;
        Coprocessor.vector0.vx0 = (short)v3.x;
        Coprocessor.vector0.vy0 = (short)v3.y;
        Coprocessor.vector0.vz0 = (short)v3.z;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.None, 12, lm: false);
        return new Vector3Int(Coprocessor.accumulator.ir1, Coprocessor.accumulator.ir2, Coprocessor.accumulator.ir3);
    }

    public static void SetRotMatrix(Matrix3x3 m)
    {
        Coprocessor.rotationMatrix.rt11 = m.V00;
        Coprocessor.rotationMatrix.rt12 = m.V01;
        Coprocessor.rotationMatrix.rt13 = m.V02;
        Coprocessor.rotationMatrix.rt21 = m.V10;
        Coprocessor.rotationMatrix.rt22 = m.V11;
        Coprocessor.rotationMatrix.rt23 = m.V12;
        Coprocessor.rotationMatrix.rt31 = m.V20;
        Coprocessor.rotationMatrix.rt32 = m.V21;
        Coprocessor.rotationMatrix.rt33 = m.V22;
    }

    public static void SetRotMatrix2(Matrix3x3 m)
    {
        Coprocessor2.rotationMatrix.rt11 = m.V00;
        Coprocessor2.rotationMatrix.rt12 = m.V01;
        Coprocessor2.rotationMatrix.rt13 = m.V02;
        Coprocessor2.rotationMatrix.rt21 = m.V10;
        Coprocessor2.rotationMatrix.rt22 = m.V11;
        Coprocessor2.rotationMatrix.rt23 = m.V12;
        Coprocessor2.rotationMatrix.rt31 = m.V20;
        Coprocessor2.rotationMatrix.rt32 = m.V21;
        Coprocessor2.rotationMatrix.rt33 = m.V22;
    }

    public static void SetRotMatrix3(Matrix3x3 m)
    {
        Coprocessor3.rotationMatrix.rt11 = m.V00;
        Coprocessor3.rotationMatrix.rt12 = m.V01;
        Coprocessor3.rotationMatrix.rt13 = m.V02;
        Coprocessor3.rotationMatrix.rt21 = m.V10;
        Coprocessor3.rotationMatrix.rt22 = m.V11;
        Coprocessor3.rotationMatrix.rt23 = m.V12;
        Coprocessor3.rotationMatrix.rt31 = m.V20;
        Coprocessor3.rotationMatrix.rt32 = m.V21;
        Coprocessor3.rotationMatrix.rt33 = m.V22;
    }

    public static void SetLightMatrix(Matrix3x3 m)
    {
        Coprocessor.lightMatrix.l11 = m.V00;
        Coprocessor.lightMatrix.l12 = m.V01;
        Coprocessor.lightMatrix.l13 = m.V02;
        Coprocessor.lightMatrix.l21 = m.V10;
        Coprocessor.lightMatrix.l22 = m.V11;
        Coprocessor.lightMatrix.l23 = m.V12;
        Coprocessor.lightMatrix.l31 = m.V20;
        Coprocessor.lightMatrix.l32 = m.V21;
        Coprocessor.lightMatrix.l33 = m.V22;
    }

    public static void SetLightMatrix3(Matrix3x3 m)
    {
        Coprocessor3.lightMatrix.l11 = m.V00;
        Coprocessor3.lightMatrix.l12 = m.V01;
        Coprocessor3.lightMatrix.l13 = m.V02;
        Coprocessor3.lightMatrix.l21 = m.V10;
        Coprocessor3.lightMatrix.l22 = m.V11;
        Coprocessor3.lightMatrix.l23 = m.V12;
        Coprocessor3.lightMatrix.l31 = m.V20;
        Coprocessor3.lightMatrix.l32 = m.V21;
        Coprocessor3.lightMatrix.l33 = m.V22;
    }

    public static void SetColorMatrix(Matrix3x3 m)
    {
        Coprocessor.lightColorMatrix.lr1 = m.V00;
        Coprocessor.lightColorMatrix.lr2 = m.V01;
        Coprocessor.lightColorMatrix.lr3 = m.V02;
        Coprocessor.lightColorMatrix.lg1 = m.V10;
        Coprocessor.lightColorMatrix.lg2 = m.V11;
        Coprocessor.lightColorMatrix.lg3 = m.V12;
        Coprocessor.lightColorMatrix.lb1 = m.V20;
        Coprocessor.lightColorMatrix.lb2 = m.V21;
        Coprocessor.lightColorMatrix.lb3 = m.V22;
    }

    public static void SetColorMatrix2(Matrix3x3 m)
    {
        Coprocessor2.lightColorMatrix.lr1 = m.V00;
        Coprocessor2.lightColorMatrix.lr2 = m.V01;
        Coprocessor2.lightColorMatrix.lr3 = m.V02;
        Coprocessor2.lightColorMatrix.lg1 = m.V10;
        Coprocessor2.lightColorMatrix.lg2 = m.V11;
        Coprocessor2.lightColorMatrix.lg3 = m.V12;
        Coprocessor2.lightColorMatrix.lb1 = m.V20;
        Coprocessor2.lightColorMatrix.lb2 = m.V21;
        Coprocessor2.lightColorMatrix.lb3 = m.V22;
    }

    public static void SetColorMatrix3(Matrix3x3 m)
    {
        Coprocessor3.lightColorMatrix.lr1 = m.V00;
        Coprocessor3.lightColorMatrix.lr2 = m.V01;
        Coprocessor3.lightColorMatrix.lr3 = m.V02;
        Coprocessor3.lightColorMatrix.lg1 = m.V10;
        Coprocessor3.lightColorMatrix.lg2 = m.V11;
        Coprocessor3.lightColorMatrix.lg3 = m.V12;
        Coprocessor3.lightColorMatrix.lb1 = m.V20;
        Coprocessor3.lightColorMatrix.lb2 = m.V21;
        Coprocessor3.lightColorMatrix.lb3 = m.V22;
    }

    public static void SetDQA(int param1)
    {
        Coprocessor.depthQueingA = (short)param1;
    }

    public static void SetDQA2(int param1)
    {
        Coprocessor2.depthQueingA = (short)param1;
    }

    public static void SetDQA3(int param1)
    {
        Coprocessor3.depthQueingA = (short)param1;
    }

    public static void SetDQB(int param1)
    {
        Coprocessor.depthQueingB = (uint)param1;
    }

    public static void SetDQB2(int param1)
    {
        Coprocessor2.depthQueingB = (uint)param1;
    }

    public static void SetDQB3(int param1)
    {
        Coprocessor3.depthQueingB = (uint)param1;
    }

    public static void SetBackColor(int rbk, int gbk, int bbk)
    {
        Coprocessor.backgroundColor._rbk = rbk << 4;
        Coprocessor.backgroundColor._gbk = gbk << 4;
        Coprocessor.backgroundColor._bbk = bbk << 4;
    }

    public static void SetBackColor2(int rbk, int gbk, int bbk)
    {
        Coprocessor2.backgroundColor._rbk = rbk << 4;
        Coprocessor2.backgroundColor._gbk = gbk << 4;
        Coprocessor2.backgroundColor._bbk = bbk << 4;
    }

    public static void SetBackColor3(int rbk, int gbk, int bbk)
    {
        Coprocessor3.backgroundColor._rbk = rbk << 4;
        Coprocessor3.backgroundColor._gbk = gbk << 4;
        Coprocessor3.backgroundColor._bbk = bbk << 4;
    }

    public static void SetFarColor(int rfc, int gfc, int bfc)
    {
        Coprocessor.farColor._rfc = rfc << 4;
        Coprocessor.farColor._gfc = gfc << 4;
        Coprocessor.farColor._bfc = bfc << 4;
    }

    public static void SetFarColor3(int rfc, int gfc, int bfc)
    {
        Coprocessor3.farColor._rfc = rfc << 4;
        Coprocessor3.farColor._gfc = gfc << 4;
        Coprocessor3.farColor._bfc = bfc << 4;
    }

    public static void SetScreenOffset(int param1, int param2)
    {
        Coprocessor.screenOffset.ofx = param1 << 16;
        Coprocessor.screenOffset.ofy = param2 << 16;
    }

    public static void SetProjectionPlane(int param1)
    {
        Coprocessor.projectionPlaneDistance = (ushort)param1;
    }

    public static void SetProjectionPlane3(int param1)
    {
        Coprocessor3.projectionPlaneDistance = (ushort)param1;
    }

    public static Color32 DpqColor(Color32 vin, long p)
    {
        Coprocessor.colorCode.r = vin.r;
        Coprocessor.colorCode.g = vin.g;
        Coprocessor.colorCode.b = vin.b;
        Coprocessor.colorCode.code = vin.a;
        Coprocessor.accumulator.ir0 = (short)p;
        Coprocessor.ExecuteDPCS(12, lm: false);
        return new Color32(Coprocessor.colorFIFO.r2, Coprocessor.colorFIFO.g2, Coprocessor.colorFIFO.b2, Coprocessor.colorFIFO.cd2);
    }

    public static Color32 NormalColorCol(Vector3Int v0, Color32 v1)
    {
        Coprocessor.vector0.vx0 = (short)v0.x;
        Coprocessor.vector0.vy0 = (short)v0.y;
        Coprocessor.vector0.vz0 = (short)v0.z;
        Coprocessor.colorCode.r = v1.r;
        Coprocessor.colorCode.g = v1.g;
        Coprocessor.colorCode.b = v1.b;
        Coprocessor.colorCode.code = v1.a;
        Coprocessor.ExecuteNCCS(12, lm: true);
        return new Color32(Coprocessor.colorFIFO.r2, Coprocessor.colorFIFO.g2, Coprocessor.colorFIFO.b2, Coprocessor.colorFIFO.cd2);
    }

    public static Matrix3x3 TransposeMatrix(Matrix3x3 m)
    {
        Matrix3x3 result = default(Matrix3x3);
        result.V02 = m.V00;
        result.V10 = m.V01;
        result.V00 = m.V00;
        result.V01 = m.V10;
        result.V20 = m.V02;
        result.V21 = m.V12;
        result.V11 = m.V11;
        result.V12 = m.V21;
        result.V02 = m.V20;
        result.V22 = m.V22;
        return result;
    }

    public static Matrix3x3 RotMatrixX(long r, Matrix3x3 min)
    {
        int num;
        int num2;
        if (-1 < r)
        {
            num = GameManager.DAT_65C90[(r & 0xFFF) * 2];
            num2 = GameManager.DAT_65C90[(r & 0xFFF) * 2 + 1];
        }
        else
        {
            r = -r;
            num = -GameManager.DAT_65C90[(r & 0xFFF) * 2];
            num2 = GameManager.DAT_65C90[(r & 0xFFF) * 2 + 1];
        }
        int v = min.V10;
        int v2 = min.V20;
        int v3 = min.V11;
        int v4 = min.V21;
        int v5 = min.V12;
        int v6 = min.V22;
        Matrix3x3 result = default(Matrix3x3);
        result.V00 = min.V00;
        result.V01 = min.V01;
        result.V02 = min.V02;
        result.V10 = (short)(num2 * v - num * v2 >> 12);
        result.V11 = (short)(num2 * v3 - num * v4 >> 12);
        result.V12 = (short)(num2 * v5 - num * v6 >> 12);
        result.V20 = (short)(num * v + num2 * v2 >> 12);
        result.V21 = (short)(num * v3 + num2 * v4 >> 12);
        result.V22 = (short)(num * v5 + num2 * v6 >> 12);
        return result;
    }

    public static Matrix3x3 RotMatrixY(long r, Matrix3x3 min)
    {
        int num;
        int num2;
        if (-1 < r)
        {
            num = -GameManager.DAT_65C90[(r & 0xFFF) * 2];
            num2 = GameManager.DAT_65C90[(r & 0xFFF) * 2 + 1];
        }
        else
        {
            r = -r;
            num = GameManager.DAT_65C90[(r & 0xFFF) * 2];
            num2 = GameManager.DAT_65C90[(r & 0xFFF) * 2 + 1];
        }
        int v = min.V00;
        int v2 = min.V20;
        int v3 = min.V01;
        int v4 = min.V21;
        int v5 = min.V02;
        int v6 = min.V22;
        Matrix3x3 result = default(Matrix3x3);
        result.V00 = (short)(num2 * v - num * v2 >> 12);
        result.V01 = (short)(num2 * v3 - num * v4 >> 12);
        result.V02 = (short)(num2 * v5 - num * v6 >> 12);
        result.V10 = min.V10;
        result.V11 = min.V11;
        result.V12 = min.V12;
        result.V20 = (short)(num * v + num2 * v2 >> 12);
        result.V21 = (short)(num * v3 + num2 * v4 >> 12);
        result.V22 = (short)(num * v5 + num2 * v6 >> 12);
        return result;
    }

    public static Matrix3x3 RotMatrixYXZ_gte(Vector3Int r)
    {
        Matrix3x3 result = default(Matrix3x3);
        int num = (r.y << 16) | (ushort)r.x;
        uint num2 = (uint)(r.z >> 31);
        uint num3 = (uint)(num >> 31);
        uint num4 = (uint)((short)num >> 31);
        int num5 = (((r.z + (int)num2) ^ (int)num2) & 0xFFF) * 2;
        uint num6 = (uint)((((GameManager.DAT_65C90[num5 + 1] << 16) | (ushort)GameManager.DAT_65C90[num5]) * 65536 + num2) ^ num2);
        num5 = ((((num >> 16) + (int)num3) ^ (int)num3) & 0xFFF) * 2;
        uint num7 = (uint)((((GameManager.DAT_65C90[num5 + 1] << 16) | (ushort)GameManager.DAT_65C90[num5]) * 65536 + num3) ^ num3);
        num5 = ((((int)(short)num + (int)num4) ^ (int)num4) & 0xFFF) * 2;
        uint num8 = (uint)((((GameManager.DAT_65C90[num5 + 1] << 16) | (ushort)GameManager.DAT_65C90[num5]) * 65536 + num4) ^ num4);
        num5 = ((((num >> 16) + (int)num3) ^ (int)num3) & 0xFFF) * 2;
        int num9 = ((((GameManager.DAT_65C90[num5 + 1] << 16) | (ushort)GameManager.DAT_65C90[num5]) >> 16 << 16) | (int)(num7 >> 16)) >> 16;
        Coprocessor.accumulator.ir0 = (short)num9;
        int num10 = (int)num8 >> 16;
        Coprocessor.accumulator.ir1 = (short)num10;
        int num11 = (int)num6 >> 16;
        Coprocessor.accumulator.ir2 = (short)num11;
        num5 = (((r.z + (int)num2) ^ (int)num2) & 0xFFF) * 2;
        int num12 = ((((GameManager.DAT_65C90[num5 + 1] << 16) | (ushort)GameManager.DAT_65C90[num5]) >> 16 << 16) | (int)(num6 >> 16)) >> 16;
        Coprocessor.accumulator.ir3 = (short)num12;
        num5 = ((((int)(short)num + (int)num4) ^ (int)num4) & 0xFFF) * 2;
        num = ((((GameManager.DAT_65C90[num5 + 1] << 16) | (ushort)GameManager.DAT_65C90[num5]) >> 16 << 16) | (int)(num8 >> 16)) >> 16;
        Coprocessor.ExecuteGPF(12, lm: false);
        int ir = Coprocessor.accumulator.ir1;
        int ir2 = Coprocessor.accumulator.ir2;
        int ir3 = Coprocessor.accumulator.ir3;
        int num13 = (int)num7 >> 16;
        Coprocessor.accumulator.ir0 = (short)num13;
        Coprocessor.accumulator.ir1 = (short)num10;
        Coprocessor.accumulator.ir2 = (short)num11;
        Coprocessor.accumulator.ir3 = (short)num12;
        Coprocessor.ExecuteGPF(12, lm: false);
        result.SetValue32(4, (short)(num * num9 >> 12));
        int ir4 = Coprocessor.accumulator.ir1;
        int ir5 = Coprocessor.accumulator.ir2;
        int ir6 = Coprocessor.accumulator.ir3;
        Coprocessor.accumulator.ir0 = (short)num12;
        Coprocessor.accumulator.ir1 = (short)num;
        Coprocessor.accumulator.ir2 = (short)ir4;
        Coprocessor.accumulator.ir3 = (short)ir;
        Coprocessor.ExecuteGPF(12, lm: false);
        num6 = (uint)Coprocessor.accumulator.ir1;
        num9 = Coprocessor.accumulator.ir2;
        int ir7 = Coprocessor.accumulator.ir3;
        Coprocessor.accumulator.ir0 = (short)num11;
        Coprocessor.accumulator.ir1 = (short)num;
        Coprocessor.accumulator.ir2 = (short)ir4;
        Coprocessor.accumulator.ir3 = (short)ir;
        Coprocessor.ExecuteGPF(12, lm: false);
        result.SetValue32(2, (int)(num6 & 0xFFFF) | (num10 * -65536));
        num12 = Coprocessor.accumulator.ir1;
        num11 = Coprocessor.accumulator.ir2;
        num10 = Coprocessor.accumulator.ir3;
        result.SetValue32(0, ((num9 - ir2) * 65536) | (int)((long)(ir3 + num11) & 65535L));
        result.SetValue32(1, (num12 << 16) | (int)((long)(num * num13 >> 12) & 65535L));
        result.SetValue32(3, ((ir7 + ir5) * 65536) | (int)((long)(num10 - ir6) & 65535L));
        return result;
    }

    public static Vector3Int VectorNormal(Vector3Int n1)
    {
        int x = n1.x;
        int y = n1.y;
        int z = n1.z;
        return MSC02_OBJ_100(new Vector3Int(x, y, z));
    }

    public static long VectorNormal2(Vector3Int n1, out Vector3Int n2)
    {
        int x = n1.x;
        int y = n1.y;
        int z = n1.z;
        return MSC02_OBJ_100_2(new Vector3Int(x, y, z), out n2);
    }

    public static Matrix3x3 MatrixNormal(Matrix3x3 m33)
    {
        Matrix3x3 result = default(Matrix3x3);
        short rt = Coprocessor.rotationMatrix.rt11;
        short rt2 = Coprocessor.rotationMatrix.rt12;
        short rt3 = Coprocessor.rotationMatrix.rt22;
        short rt4 = Coprocessor.rotationMatrix.rt23;
        short rt5 = Coprocessor.rotationMatrix.rt33;
        Coprocessor.rotationMatrix.rt11 = m33.V00;
        Coprocessor.rotationMatrix.rt12 = (short)(m33.V00 >> 16);
        Coprocessor.rotationMatrix.rt22 = m33.V01;
        Coprocessor.rotationMatrix.rt23 = (short)(m33.V01 >> 16);
        Coprocessor.rotationMatrix.rt33 = m33.V02;
        Coprocessor.accumulator.ir3 = m33.V12;
        Coprocessor.accumulator.ir1 = m33.V10;
        Coprocessor.accumulator.ir2 = m33.V11;
        Coprocessor.ExecuteOP(12, lm: false);
        int mac = Coprocessor.mathsAccumulator.mac1;
        int mac2 = Coprocessor.mathsAccumulator.mac2;
        int mac3 = Coprocessor.mathsAccumulator.mac3;
        Coprocessor.rotationMatrix.rt11 = m33.V10;
        Coprocessor.rotationMatrix.rt12 = (short)(m33.V10 >> 16);
        Coprocessor.rotationMatrix.rt22 = m33.V11;
        Coprocessor.rotationMatrix.rt23 = (short)(m33.V11 >> 16);
        Coprocessor.rotationMatrix.rt33 = m33.V12;
        Coprocessor.ExecuteOP(12, lm: false);
        int mac4 = Coprocessor.mathsAccumulator.mac1;
        int mac5 = Coprocessor.mathsAccumulator.mac2;
        int mac6 = Coprocessor.mathsAccumulator.mac3;
        Coprocessor.vector0.vx0 = m33.V10;
        Coprocessor.vector0.vy0 = (short)(m33.V10 >> 16);
        Coprocessor.vector0.vz0 = m33.V11;
        Coprocessor.vector1.vx1 = m33.V12;
        Coprocessor.vector1.vy1 = (short)(m33.V12 >> 16);
        Coprocessor.rotationMatrix.rt11 = rt;
        Coprocessor.rotationMatrix.rt12 = rt2;
        Coprocessor.rotationMatrix.rt22 = rt3;
        Coprocessor.rotationMatrix.rt23 = rt4;
        Coprocessor.rotationMatrix.rt33 = rt5;
        Vector3Int vector3Int = MSC02_OBJ_100(new Vector3Int(mac4, mac5, mac6));
        result.V00 = (short)vector3Int.x;
        result.V01 = (short)vector3Int.y;
        result.V02 = (short)vector3Int.z;
        Vector3Int vector3Int2 = MSC02_OBJ_100(new Vector3Int((Coprocessor.vector0.vy0 << 16) | (ushort)Coprocessor.vector0.vx0, Coprocessor.vector0.vz0, (Coprocessor.vector1.vy1 << 16) | (ushort)Coprocessor.vector1.vx1));
        result.V10 = (short)vector3Int2.x;
        result.V11 = (short)vector3Int2.y;
        result.V12 = (short)vector3Int2.z;
        Vector3Int vector3Int3 = MSC02_OBJ_100(new Vector3Int(mac, mac2, mac3));
        result.V20 = (short)vector3Int3.x;
        result.V21 = (short)vector3Int3.y;
        result.V22 = (short)vector3Int3.z;
        return result;
    }

    public static Vector3Int MSC02_OBJ_100(Vector3Int normal)
    {
        Coprocessor.accumulator.ir1 = (short)normal.x;
        Coprocessor.accumulator.ir2 = (short)normal.y;
        Coprocessor.accumulator.ir3 = (short)normal.z;
        Coprocessor.ExecuteSQR(0, lm: true);
        int mac = Coprocessor.mathsAccumulator.mac1;
        int mac2 = Coprocessor.mathsAccumulator.mac2;
        int mac3 = Coprocessor.mathsAccumulator.mac3;
        int num = mac + mac2 + mac3;
        int num2 = LeadingZeros(num) & -2;
        int num3 = 31 - num2 >> 1;
        int num4 = num2 - 24;
        int num5;
        if (num4 < 0)
        {
            num4 = 24 - num2;
            num5 = num >> num4;
        }
        else
        {
            num5 = num << num4;
        }
        num5 = num5 - 64 << 1;
        if (num5 >= 0)
        {
            int num6 = GameManager.UNK4[num5 / 2];
            Coprocessor.accumulator.ir0 = (short)num6;
            Coprocessor.accumulator.ir1 = (short)normal.x;
            Coprocessor.accumulator.ir2 = (short)normal.y;
            Coprocessor.accumulator.ir3 = (short)normal.z;
            Coprocessor.ExecuteGPF(0, lm: false);
            mac = Coprocessor.mathsAccumulator.mac1 >> num3;
            mac2 = Coprocessor.mathsAccumulator.mac2 >> num3;
            mac3 = Coprocessor.mathsAccumulator.mac3 >> num3;
        }
        else
        {
            mac = 0;
            mac2 = 0;
            mac3 = 0;
        }
        return new Vector3Int(mac, mac2, mac3);
    }

    public static long MSC02_OBJ_100_2(Vector3Int normal, out Vector3Int result)
    {
        Coprocessor.accumulator.ir1 = (short)normal.x;
        Coprocessor.accumulator.ir2 = (short)normal.y;
        Coprocessor.accumulator.ir3 = (short)normal.z;
        Coprocessor.ExecuteSQR(0, lm: true);
        int mac = Coprocessor.mathsAccumulator.mac1;
        int mac2 = Coprocessor.mathsAccumulator.mac2;
        int mac3 = Coprocessor.mathsAccumulator.mac3;
        int num = mac + mac2 + mac3;
        int num2 = LeadingZeros(num) & -2;
        int num3 = 31 - num2 >> 1;
        int num4 = num2 - 24;
        int num5;
        if (num4 < 0)
        {
            num4 = 24 - num2;
            num5 = num >> num4;
        }
        else
        {
            num5 = num << num4;
        }
        num5 = num5 - 64 << 1;
        if (num5 >= 0)
        {
            int num6 = GameManager.UNK4[num5 / 2];
            Coprocessor.accumulator.ir0 = (short)num6;
            Coprocessor.accumulator.ir1 = (short)normal.x;
            Coprocessor.accumulator.ir2 = (short)normal.y;
            Coprocessor.accumulator.ir3 = (short)normal.z;
            Coprocessor.ExecuteGPF(0, lm: false);
            mac = Coprocessor.mathsAccumulator.mac1 >> num3;
            mac2 = Coprocessor.mathsAccumulator.mac2 >> num3;
            mac3 = Coprocessor.mathsAccumulator.mac3 >> num3;
        }
        else
        {
            mac = 0;
            mac2 = 0;
            mac3 = 0;
        }
        result = new Vector3Int(mac, mac2, mac3);
        return num;
    }

    public static T Clamp<T>(this T val, T min, T max) where T : IComparable<T>
    {
        if (val.CompareTo(min) < 0)
        {
            return min;
        }
        if (val.CompareTo(max) > 0)
        {
            return max;
        }
        return val;
    }

    public static void SetGlobalScale(this Transform transform, Vector3 globalScale)
    {
        transform.localScale = Vector3.one;
        transform.localScale = new Vector3(globalScale.x / transform.lossyScale.x, globalScale.y / transform.lossyScale.y, globalScale.z / transform.lossyScale.z);
    }

    public static float MoveDecimal(int value, int space)
    {
        return (float)((double)value / Math.Pow(10.0, space));
    }

    public static float MoveDecimal(long value, int space)
    {
        return (float)((double)value / Math.Pow(10.0, space));
    }

    public static sbyte ReadSByte(this BinaryReader reader, int offset)
    {
        long position = reader.BaseStream.Position;
        reader.BaseStream.Seek(offset, SeekOrigin.Current);
        sbyte result = reader.ReadSByte();
        reader.BaseStream.Seek(position, SeekOrigin.Begin);
        return result;
    }

    public static byte ReadByte(this BinaryReader reader, int offset)
    {
        long position = reader.BaseStream.Position;
        reader.BaseStream.Seek(offset, SeekOrigin.Current);
        byte result = reader.ReadByte();
        reader.BaseStream.Seek(position, SeekOrigin.Begin);
        return result;
    }

    public static byte[] ReadBytes(this BinaryReader reader, int offset, int length)
    {
        long position = reader.BaseStream.Position;
        reader.BaseStream.Seek(offset, SeekOrigin.Current);
        byte[] result = reader.ReadBytes(length);
        reader.BaseStream.Seek(position, SeekOrigin.Begin);
        return result;
    }

    public static short ReadInt16(this BinaryReader reader, int offset)
    {
        long position = reader.BaseStream.Position;
        reader.BaseStream.Seek(offset, SeekOrigin.Current);
        short result = reader.ReadInt16();
        reader.BaseStream.Seek(position, SeekOrigin.Begin);
        return result;
    }

    public static ushort ReadUInt16(this BinaryReader reader, int offset)
    {
        long position = reader.BaseStream.Position;
        reader.BaseStream.Seek(offset, SeekOrigin.Current);
        ushort result = reader.ReadUInt16();
        reader.BaseStream.Seek(position, SeekOrigin.Begin);
        return result;
    }

    public static int ReadInt32(this BinaryReader reader, int offset)
    {
        long position = reader.BaseStream.Position;
        reader.BaseStream.Seek(offset, SeekOrigin.Current);
        int result = reader.ReadInt32();
        reader.BaseStream.Seek(position, SeekOrigin.Begin);
        return result;
    }

    public static uint ReadUInt32(this BinaryReader reader, int offset)
    {
        long position = reader.BaseStream.Position;
        reader.BaseStream.Seek(offset, SeekOrigin.Current);
        uint result = reader.ReadUInt32();
        reader.BaseStream.Seek(position, SeekOrigin.Begin);
        return result;
    }

    public static string ReadNullTerminatedString(this BinaryReader stream)
    {
        string text = "";
        char c;
        while ((c = stream.ReadChar()) != 0)
        {
            text += c.ToString();
        }
        return text;
    }

    public static void Write(this BinaryWriter writer, int offset, sbyte value)
    {
        long position = writer.BaseStream.Position;
        writer.BaseStream.Seek(offset, SeekOrigin.Current);
        writer.Write(value);
        writer.BaseStream.Seek(position, SeekOrigin.Begin);
    }

    public static void Write(this BinaryWriter writer, int offset, byte value)
    {
        long position = writer.BaseStream.Position;
        writer.BaseStream.Seek(offset, SeekOrigin.Current);
        writer.Write(value);
        writer.BaseStream.Seek(position, SeekOrigin.Begin);
    }

    public static void Write(this BinaryWriter writer, int offset, byte[] value)
    {
        long position = writer.BaseStream.Position;
        writer.BaseStream.Seek(offset, SeekOrigin.Current);
        writer.Write(value);
        writer.BaseStream.Seek(position, SeekOrigin.Begin);
    }

    public static void Write(this BinaryWriter writer, int offset, short value)
    {
        long position = writer.BaseStream.Position;
        writer.BaseStream.Seek(offset, SeekOrigin.Current);
        writer.Write(value);
        writer.BaseStream.Seek(position, SeekOrigin.Begin);
    }

    public static void Write(this BinaryWriter writer, int offset, ushort value)
    {
        long position = writer.BaseStream.Position;
        writer.BaseStream.Seek(offset, SeekOrigin.Current);
        writer.Write(value);
        writer.BaseStream.Seek(position, SeekOrigin.Begin);
    }

    public static void Write(this BinaryWriter writer, int offset, int value)
    {
        long position = writer.BaseStream.Position;
        writer.BaseStream.Seek(offset, SeekOrigin.Current);
        writer.Write(value);
        writer.BaseStream.Seek(position, SeekOrigin.Begin);
    }

    public static void Write(this BinaryWriter writer, int offset, uint value)
    {
        long position = writer.BaseStream.Position;
        writer.BaseStream.Seek(offset, SeekOrigin.Current);
        writer.Write(value);
        writer.BaseStream.Seek(position, SeekOrigin.Begin);
    }

    public static void SaveObjectToFile(UnityEngine.Object obj, string filename)
    {
    }

    public static Vector2 Rotate(this Vector2 v, float degrees)
    {
        float num = Mathf.Sin(degrees * (MathF.PI / 180f));
        float num2 = Mathf.Cos(degrees * (MathF.PI / 180f));
        float x = v.x;
        float y = v.y;
        v.x = num2 * x - num * y;
        v.y = num * x + num2 * y;
        return v;
    }

    public static bool ContainsTupleObject(this List<VigTuple> list, VigObject obj)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].vObject == obj)
            {
                return true;
            }
        }
        return false;
    }
}


public class FixedSizedQueue<T>
{
    ConcurrentQueue<T> q = new ConcurrentQueue<T>();
    private object lockObject = new object();

    public int Limit { get; set; }
    public void Enqueue(T obj)
    {
        q.Enqueue(obj);
        lock (lockObject)
        {
            T overflow;
            while (q.Count > Limit && q.TryDequeue(out overflow)) ;
        }
    }
    public T Dequeue()
    {
        T result;
        q.TryDequeue(out result);
        return result;
    }
    public T Peek()
    {
        T result;
        q.TryPeek(out result);
        return result;
    }
    public T PeekAt(int index)
    {
        T result;
        result = q.ElementAt(index);
        return result;
    }
}

public class BufferedBinaryReader : IDisposable
{
    private readonly Stream stream;

    private byte[] buffer;

    private int bufferSize;

    private int bufferOffset;

    private int numBufferedBytes;

    public long Position => bufferOffset;

    public long Length => bufferSize;

    public int NumBytesAvailable => Math.Max(0, numBufferedBytes - bufferOffset);

    public BufferedBinaryReader(Stream stream, int bufferSize)
    {
        this.stream = stream;
        this.bufferSize = bufferSize;
        buffer = new byte[bufferSize];
        bufferOffset = bufferSize;
    }

    public BufferedBinaryReader(byte[] buffer)
    {
        if (buffer != null)
        {
            bufferSize = buffer.Length;
            this.buffer = buffer;
        }
        else
        {
            bufferSize = 0;
            this.buffer = null;
        }
    }

    public bool FillBuffer()
    {
        int num = bufferSize - bufferOffset;
        int num2 = bufferSize - num;
        bufferOffset = 0;
        numBufferedBytes = num;
        if (num > 0)
        {
            Buffer.BlockCopy(buffer, num2, buffer, 0, num);
        }
        while (num2 > 0)
        {
            int num3 = stream.Read(buffer, num, num2);
            if (num3 == 0)
            {
                return false;
            }
            numBufferedBytes += num3;
            num2 -= num3;
            num += num3;
        }
        return true;
    }

    public void ChangeBuffer(byte[] buffer)
    {
        bufferSize = buffer.Length;
        this.buffer = buffer;
        bufferOffset = 0;
    }

    public void ChangeBuffer(BufferedBinaryReader reader)
    {
        bufferSize = reader.bufferSize;
        buffer = reader.buffer;
        bufferOffset = reader.bufferOffset;
    }

    public byte[] GetBuffer()
    {
        return buffer;
    }

    public byte ReadByte(int offset)
    {
        return buffer[bufferOffset + offset];
    }
    public short ReadInt16()
    {
        var val = (short)((int)buffer[bufferOffset] | (int)buffer[bufferOffset + 1] << 8);
        bufferOffset += 2;
        return val;
    }
    public ushort ReadUInt16()
    {
        var val = (ushort)((int)buffer[bufferOffset] | (int)buffer[bufferOffset + 1] << 8);
        bufferOffset += 2;
        return val;
    }
    public short ReadInt16(int offset)
    {
        return (short)(buffer[bufferOffset + offset] | (buffer[bufferOffset + offset + 1] << 8));
    }

    public ushort ReadUInt16(int offset)
    {
        return (ushort)(buffer[bufferOffset + offset] | (buffer[bufferOffset + offset + 1] << 8));
    }

    public int ReadInt32(int offset)
    {
        return buffer[bufferOffset + offset] | (buffer[bufferOffset + offset + 1] << 8) | (buffer[bufferOffset + offset + 2] << 16) | (buffer[bufferOffset + offset + 3] << 24);
    }

    public Vector3Int ReadSVector(int offset)
    {
        return new Vector3Int(ReadInt16(offset), ReadInt16(offset + 2), ReadInt16(offset + 4));
    }

    public void WriteUInt16(int offset, ushort value)
    {
        buffer[bufferOffset + offset] = (byte)value;
        buffer[bufferOffset + offset + 1] = (byte)(value >> 8);
    }

    public void Dispose()
    {
        if (stream != null)
        {
            stream.Close();
        }
    }

    public void Seek(long offset, SeekOrigin origin)
    {
        switch (origin)
        {
            case SeekOrigin.Begin:
                bufferOffset = (int)offset;
                break;
            case SeekOrigin.Current:
                bufferOffset += (int)offset;
                break;
            case SeekOrigin.End:
                bufferOffset = bufferSize - (int)offset;
                break;
        }
    }
}

[Serializable]
public class VigTuple
{
    public VigObject vObject;

    public uint flag;

    public VigTuple(VigObject o, uint f)
    {
        vObject = o;
        flag = f;
    }
}

[Serializable]
public class VigTuple2
{
    public short type;

    public short id;

    public short[] array;

    public VigTuple2(short t, short index, short[] a)
    {
        type = t;
        id = index;
        array = a;
    }
}

[Serializable]
public class Navigation
{
    public Navigation next;

    public Navigation DAT_04;

    public int aimpIndex;

    public ushort DAT_0C;

    public ushort DAT_0E;

    public byte DAT_10;

    public byte DAT_11;

    public int DAT_14;

    public int DAT_18;
}

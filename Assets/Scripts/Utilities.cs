using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using UnityEngine;
using Unity.Burst;
using System.Threading.Tasks;

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

    public static KeyValuePair<string, Type>[][] levelTypes = new KeyValuePair<string, Type>[][]
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

    /*
        public static KeyValuePair<string, Type>[][] levelTypes = new KeyValuePair<string, Type>[18][]
    {
        new KeyValuePair<string, Type>[10]
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
            new KeyValuePair<string, Type>("Wall", typeof(Wall))
        },
        new KeyValuePair<string, Type>[14]
        {
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
            new KeyValuePair<string, Type>("Scoreboard", typeof(Scoreboard))
        },
        new KeyValuePair<string, Type>[9]
        {
            new KeyValuePair<string, Type>("TestThruster", typeof(TestThruster)),
            new KeyValuePair<string, Type>("NASA", typeof(NASA)),
            new KeyValuePair<string, Type>("LaunchVehicle", typeof(LaunchVehicle)),
            new KeyValuePair<string, Type>("WindTunnel", typeof(WindTunnel)),
            new KeyValuePair<string, Type>("GuardTower", typeof(GuardTower)),
            new KeyValuePair<string, Type>("Fence", typeof(Fence)),
            new KeyValuePair<string, Type>("Sharky", typeof(Sharky)),
            new KeyValuePair<string, Type>("LaunchEntry", typeof(LaunchEntry)),
            new KeyValuePair<string, Type>("Gantry", typeof(Gantry))
        },
        new KeyValuePair<string, Type>[10]
        {
            new KeyValuePair<string, Type>("Bridge_1", typeof(Bridge)),
            new KeyValuePair<string, Type>("Cage", typeof(Cage)),
            new KeyValuePair<string, Type>("LockWheel", typeof(LockWheel)),
            new KeyValuePair<string, Type>("LockDam", typeof(LockDam)),
            new KeyValuePair<string, Type>("GATOR_I", typeof(Aligator)),
            new KeyValuePair<string, Type>("Tomb_1", typeof(Tomb)),
            new KeyValuePair<string, Type>("Tomb_2", typeof(Tomb)),
            new KeyValuePair<string, Type>("Tomb_3", typeof(Tomb)),
            new KeyValuePair<string, Type>("Mansion", typeof(Mansion)),
            new KeyValuePair<string, Type>("Mausoleum", typeof(Mausoleum))
        },
        new KeyValuePair<string, Type>[9]
        {
            new KeyValuePair<string, Type>("TransferBooth", typeof(TransferBooth)),
            new KeyValuePair<string, Type>("Transformer", typeof(Transformer)),
            new KeyValuePair<string, Type>("NSwitch", typeof(NSwitch)),
            new KeyValuePair<string, Type>("TurbineShock", typeof(TurbineShock)),
            new KeyValuePair<string, Type>("Turbine", typeof(Turbine)),
            new KeyValuePair<string, Type>("ForkLift", typeof(ForkLift)),
            new KeyValuePair<string, Type>("Bridge_L", typeof(BridgeL)),
            new KeyValuePair<string, Type>("Reactor", typeof(Reactor)),
            new KeyValuePair<string, Type>("ContBuilding", typeof(ContBuilding))
        },
        new KeyValuePair<string, Type>[13]
        {
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
            new KeyValuePair<string, Type>("BridgeL", typeof(BridgeS))
        },
        new KeyValuePair<string, Type>[7]
        {
            new KeyValuePair<string, Type>("PipeEnd", typeof(Pipe)),
            new KeyValuePair<string, Type>("Glacier_Small", typeof(GlacierSmall)),
            new KeyValuePair<string, Type>("Glacier", typeof(Glacier)),
            new KeyValuePair<string, Type>("OilPlatform", typeof(OilPlatform)),
            new KeyValuePair<string, Type>("SiloRamp", typeof(SiloRamp)),
            new KeyValuePair<string, Type>("SiloCatwalk", typeof(Catwalk)),
            new KeyValuePair<string, Type>("Orca", typeof(Orca))
        },
        new KeyValuePair<string, Type>[10]
        {
            new KeyValuePair<string, Type>("CraneSmall", typeof(CraneSmall)),
            new KeyValuePair<string, Type>("Buoy", typeof(Buoy)),
            new KeyValuePair<string, Type>("weighSign", typeof(WeighSign)),
            new KeyValuePair<string, Type>("Warehouse_1", typeof(Warehouse)),
            new KeyValuePair<string, Type>("Lighthouse", typeof(Lighthouse)),
            new KeyValuePair<string, Type>("DrawBridge", typeof(DrawBridge)),
            new KeyValuePair<string, Type>("Barge", typeof(Barge)),
            new KeyValuePair<string, Type>("CargoTruck", typeof(CargoTruck)),
            new KeyValuePair<string, Type>("CraneLarge", typeof(CraneLarge)),
            new KeyValuePair<string, Type>("Container_1", typeof(Container))
        },
        new KeyValuePair<string, Type>[7]
        {
            new KeyValuePair<string, Type>("OilRig", typeof(Rig)),
            new KeyValuePair<string, Type>("pipe_end_1", typeof(Pipe2)),
            new KeyValuePair<string, Type>("OilPump_1", typeof(Pump)),
            new KeyValuePair<string, Type>("sphere_1", typeof(Sphere)),
            new KeyValuePair<string, Type>("pipe-gateGATE_1", typeof(Pipe4)),
            new KeyValuePair<string, Type>("JTreeS_1", typeof(Destructible2)),
            new KeyValuePair<string, Type>("JTreeT_1", typeof(Destructible2))
        },
        new KeyValuePair<string, Type>[5]
        {
            new KeyValuePair<string, Type>("hanger_1", typeof(Hanger)),
            new KeyValuePair<string, Type>("control_tower_1", typeof(ControlTower)),
            new KeyValuePair<string, Type>("hanger_1_Door1", typeof(HangerDoor)),
            new KeyValuePair<string, Type>("Crane_1", typeof(Crane2)),
            new KeyValuePair<string, Type>("b17_1", typeof(B17))
        },
        new KeyValuePair<string, Type>[15]
        {
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
            new KeyValuePair<string, Type>("M1gaslight_1", typeof(Destructible2))
        },
        new KeyValuePair<string, Type>[13]
        {
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
            new KeyValuePair<string, Type>("Catwalk_1", typeof(Catwalk2))
        },
        new KeyValuePair<string, Type>[8]
        {
            new KeyValuePair<string, Type>("SplashS_R", typeof(Splash2)),
            new KeyValuePair<string, Type>("Windmill_1", typeof(Windmill)),
            new KeyValuePair<string, Type>("silo_1", typeof(Silo)),
            new KeyValuePair<string, Type>("WWave", typeof(Wave)),
            new KeyValuePair<string, Type>("pump_1", typeof(Pump3)),
            new KeyValuePair<string, Type>("crop_duster", typeof(CropDuster)),
            new KeyValuePair<string, Type>("tree_1", typeof(Destructible2)),
            new KeyValuePair<string, Type>("tree2_1", typeof(Destructible2))
        },
        new KeyValuePair<string, Type>[10]
        {
            new KeyValuePair<string, Type>("palm1_1", typeof(Palm)),
            new KeyValuePair<string, Type>("SplashS_R", typeof(Splash3)),
            new KeyValuePair<string, Type>("BurgerS_1", typeof(BurgerS)),
            new KeyValuePair<string, Type>("Burger_sign_1", typeof(BurgerSign)),
            new KeyValuePair<string, Type>("manhole_1", typeof(Manhole)),
            new KeyValuePair<string, Type>("blimp_1", typeof(Blimp)),
            new KeyValuePair<string, Type>("water_1", typeof(Water3)),
            new KeyValuePair<string, Type>("pelicana_1", typeof(Pelicana)),
            new KeyValuePair<string, Type>("saharan_1", typeof(Pelicana)),
            new KeyValuePair<string, Type>("parking_gate", typeof(ParkingGate))
        },
        new KeyValuePair<string, Type>[4]
        {
            new KeyValuePair<string, Type>("boulder_L", typeof(Boulder)),
            new KeyValuePair<string, Type>("BeamUp", typeof(Beamup)),
            new KeyValuePair<string, Type>("cement_barrier_1", typeof(Barrier)),
            new KeyValuePair<string, Type>("bridge_1", typeof(Bridge3))
        },
        new KeyValuePair<string, Type>[11]
        {
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
            new KeyValuePair<string, Type>("pine2_1", typeof(Destructible2))
        },
        new KeyValuePair<string, Type>[10]
        {
            new KeyValuePair<string, Type>("radar_1", typeof(Radar)),
            new KeyValuePair<string, Type>("fence_left", typeof(Fence2)),
            new KeyValuePair<string, Type>("fence_right", typeof(Fence2)),
            new KeyValuePair<string, Type>("turret_1", typeof(Turret)),
            new KeyValuePair<string, Type>("MSilo", typeof(Silo2)),
            new KeyValuePair<string, Type>("hq_1", typeof(HQ)),
            new KeyValuePair<string, Type>("hq_2", typeof(HQ2)),
            new KeyValuePair<string, Type>("hq_3", typeof(HQ3)),
            new KeyValuePair<string, Type>("aurora_1", typeof(Aurora)),
            new KeyValuePair<string, Type>("catwalk_1", typeof(Catwalk3))
        },
        new KeyValuePair<string, Type>[5]
        {
            new KeyValuePair<string, Type>("protoSaucer", typeof(Saucer2)),
            new KeyValuePair<string, Type>("M2_elevator_1", typeof(Elevator)),
            new KeyValuePair<string, Type>("M2_Conveyor", typeof(Conveyor)),
            new KeyValuePair<string, Type>("factory_1", typeof(Factory)),
            new KeyValuePair<string, Type>("factory_door", typeof(FactoryDoor))
        }
    };
    */

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


    public static short[] DAT_65C90 = new short[]
    {
        0, 4096, 6, 4096, 13, 4096, 19, 4096, 25, 4096, 31, 4096, 38, 4096, 44, 4096, 50, 4096,
        57, 4096, 63, 4096, 69, 4095, 75, 4095, 82, 4095, 88, 4095, 94, 4095, 101, 4095, 107,
        4095, 113, 4094, 119, 4094, 126, 4094, 132, 4094, 138, 4094, 144, 4093, 151, 4093, 157,
        4093, 163, 4093, 170, 4092, 176, 4092, 182, 4092, 188, 4092, 195, 4091, 201, 4091, 207,
        4091, 214, 4090, 220, 4090, 226, 4090, 232, 4089, 239, 4089, 245, 4089, 251, 4088, 257,
        4088, 264, 4088, 270, 4087, 276, 4087, 283, 4086, 289, 4086, 295, 4085, 301, 4085, 308,
        4084, 314, 4084, 320, 4083, 326, 4083, 333, 4082, 339, 4082, 345, 4081, 351, 4081, 358,
        4080, 364, 4080, 370, 4079, 376, 4079, 383, 4078, 389, 4077, 395, 4077, 401, 4076, 408,
        4076, 414, 4075, 420, 4074, 426, 4074, 433, 4073, 439, 4072, 445, 4072, 451, 4071, 458,
        4070, 464, 4070, 470, 4069, 476, 4068, 483, 4067, 489, 4067, 495, 4066, 501, 4065, 508,
        4064, 514, 4064, 520, 4063, 526, 4062, 533, 4061, 539, 4060, 545, 4060, 551, 4059, 557,
        4058, 564, 4057, 570, 4056, 576, 4055, 582, 4054, 589, 4053, 595, 4053, 601, 4052, 607,
        4051, 613, 4050, 620, 4049, 626, 4048, 632, 4047, 638, 4046, 644, 4045, 651, 4044, 657,
        4043, 663, 4042, 669, 4041, 675, 4040, 682, 4039, 688, 4038, 694, 4037, 700, 4036, 706,
        4035, 713, 4034, 719, 4032, 725, 4031, 731, 4030, 737, 4029, 744, 4028, 750, 4027, 756,
        4026, 762, 4024, 768, 4023, 774, 4022, 781, 4021, 787, 4020, 793, 4019, 799, 4017, 805,
        4016, 811, 4015, 818, 4014, 824, 4012, 830, 4011, 836, 4010, 842, 4008, 848, 4007, 854,
        4006, 861, 4005, 867, 4003, 873, 4002, 879, 4001, 885, 3999, 891, 3998, 897, 3996, 904,
        3995, 910, 3994, 916, 3992, 922, 3991, 928, 3989, 934, 3988, 940, 3987, 946, 3985, 953,
        3984, 959, 3982, 965, 3981, 971, 3979, 977, 3978, 983, 3976, 989, 3975, 995, 3973, 1001,
        3972, 1007, 3970, 1014, 3969, 1020, 3967, 1026, 3965, 1032, 3964, 1038, 3962, 1044, 3961,
        1050, 3959, 1056, 3958, 1062, 3956, 1068, 3954, 1074, 3953, 1080, 3951, 1086, 3949, 1092,
        3948, 1099, 3946, 1105, 3944, 1111, 3943, 1117, 3941, 1123, 3939, 1129, 3937, 1135, 3936,
        1141, 3934, 1147, 3932, 1153, 3930, 1159, 3929, 1165, 3927, 1171, 3925, 1177, 3923, 1183,
        3921, 1189, 3920, 1195, 3918, 1201, 3916, 1207, 3914, 1213, 3912, 1219, 3910, 1225, 3909,
        1231, 3907, 1237, 3905, 1243, 3903, 1249, 3901, 1255, 3899, 1261, 3897, 1267, 3895, 1273,
        3893, 1279, 3891, 1285, 3889, 1291, 3887, 1297, 3885, 1303, 3883, 1309, 3881, 1315, 3879,
        1321, 3877, 1327, 3875, 1332, 3873, 1338, 3871, 1344, 3869, 1350, 3867, 1356, 3865, 1362,
        3863, 1368, 3861, 1374, 3859, 1380, 3857, 1386, 3854, 1392, 3852, 1398, 3850, 1404, 3848,
        1409, 3846, 1415, 3844, 1421, 3842, 1427, 3839, 1433, 3837, 1439, 3835, 1445, 3833, 1451,
        3831, 1457, 3828, 1462, 3826, 1468, 3824, 1474, 3822, 1480, 3819, 1486, 3817, 1492, 3815,
        1498, 3812, 1503, 3810, 1509, 3808, 1515, 3805, 1521, 3803, 1527, 3801, 1533, 3798, 1538,
        3796, 1544, 3794, 1550, 3791, 1556, 3789, 1562, 3787, 1567, 3784, 1573, 3782, 1579, 3779,
        1585, 3777, 1591, 3775, 1596, 3772, 1602, 3770, 1608, 3767, 1614, 3765, 1620, 3762, 1625,
        3760, 1631, 3757, 1637, 3755, 1643, 3752, 1648, 3750, 1654, 3747, 1660, 3745, 1666, 3742,
        1671, 3739, 1677, 3737, 1683, 3734, 1689, 3732, 1694, 3729, 1700, 3727, 1706, 3724, 1711,
        3721, 1717, 3719, 1723, 3716, 1729, 3713, 1734, 3711, 1740, 3708, 1746, 3705, 1751, 3703,
        1757, 3700, 1763, 3697, 1768, 3695, 1774, 3692, 1780, 3689, 1785, 3686, 1791, 3684, 1797,
        3681, 1802, 3678, 1808, 3675, 1813, 3673, 1819, 3670, 1825, 3667, 1830, 3664, 1836, 3661,
        1842, 3659, 1847, 3656, 1853, 3653, 1858, 3650, 1864, 3647, 1870, 3644, 1875, 3642, 1881,
        3639, 1886, 3636, 1892, 3633, 1898, 3630, 1903, 3627, 1909, 3624, 1914, 3621, 1920, 3618,
        1925, 3615, 1931, 3612, 1936, 3609, 1942, 3606, 1947, 3603, 1953, 3600, 1958, 3597, 1964,
        3594, 1970, 3591, 1975, 3588, 1981, 3585, 1986, 3582, 1992, 3579, 1997, 3576, 2002, 3573,
        2008, 3570, 2013, 3567, 2019, 3564, 2024, 3561, 2030, 3558, 2035, 3555, 2041, 3551, 2046,
        3548, 2052, 3545, 2057, 3542, 2062, 3539, 2068, 3536, 2073, 3532, 2079, 3529, 2084, 3526,
        2090, 3523, 2095, 3520, 2100, 3516, 2106, 3513, 2111, 3510, 2117, 3507, 2122, 3504, 2127,
        3500, 2133, 3497, 2138, 3494, 2143, 3490, 2149, 3487, 2154, 3484, 2159, 3481, 2165, 3477,
        2170, 3474, 2175, 3471, 2181, 3467, 2186, 3464, 2191, 3461, 2197, 3457, 2202, 3454, 2207,
        3450, 2213, 3447, 2218, 3444, 2223, 3440, 2228, 3437, 2234, 3433, 2239, 3430, 2244, 3426,
        2249, 3423, 2255, 3420, 2260, 3416, 2265, 3413, 2270, 3409, 2276, 3406, 2281, 3402, 2286,
        3399, 2291, 3395, 2296, 3392, 2302, 3388, 2307, 3385, 2312, 3381, 2317, 3378, 2322, 3374,
        2328, 3370, 2333, 3367, 2338, 3363, 2343, 3360, 2348, 3356, 2353, 3352, 2359, 3349, 2364,
        3345, 2369, 3342, 2374, 3338, 2379, 3334, 2384, 3331, 2389, 3327, 2394, 3323, 2399, 3320,
        2405, 3316, 2410, 3312, 2415, 3309, 2420, 3305, 2425, 3301, 2430, 3297, 2435, 3294, 2440,
        3290, 2445, 3286, 2450, 3282, 2455, 3279, 2460, 3275, 2465, 3271, 2470, 3267, 2475, 3264,
        2480, 3260, 2485, 3256, 2490, 3252, 2495, 3248, 2500, 3244, 2505, 3241, 2510, 3237, 2515,
        3233, 2520, 3229, 2525, 3225, 2530, 3221, 2535, 3217, 2540, 3214, 2545, 3210, 2550, 3206,
        2555, 3202, 2559, 3198, 2564, 3194, 2569, 3190, 2574, 3186, 2579, 3182, 2584, 3178, 2589,
        3174, 2594, 3170, 2598, 3166, 2603, 3162, 2608, 3158, 2613, 3154, 2618, 3150, 2623, 3146,
        2628, 3142, 2632, 3138, 2637, 3134, 2642, 3130, 2647, 3126, 2652, 3122, 2656, 3118, 2661,
        3114, 2666, 3110, 2671, 3106, 2675, 3102, 2680, 3097, 2685, 3093, 2690, 3089, 2694, 3085,
        2699, 3081, 2704, 3077, 2709, 3073, 2713, 3068, 2718, 3064, 2723, 3060, 2727, 3056, 2732,
        3052, 2737, 3048, 2741, 3043, 2746, 3039, 2751, 3035, 2755, 3031, 2760, 3026, 2765, 3022,
        2769, 3018, 2774, 3014, 2779, 3009, 2783, 3005, 2788, 3001, 2792, 2997, 2797, 2992, 2802,
        2988, 2806, 2984, 2811, 2979, 2815, 2975, 2820, 2971, 2824, 2967, 2829, 2962, 2833, 2958,
        2838, 2953, 2843, 2949, 2847, 2945, 2852, 2940, 2856, 2936, 2861, 2932, 2865, 2927, 2870,
        2923, 2874, 2918, 2878, 2914, 2883, 2910, 2887, 2905, 2892, 2901, 2896, 2896, 2901, 2892,
        2905, 2887, 2910, 2883, 2914, 2878, 2918, 2874, 2923, 2870, 2927, 2865, 2932, 2861, 2936,
        2856, 2940, 2852, 2945, 2847, 2949, 2843, 2953, 2838, 2958, 2833, 2962, 2829, 2967, 2824,
        2971, 2820, 2975, 2815, 2979, 2811, 2984, 2806, 2988, 2802, 2992, 2797, 2997, 2792, 3001,
        2788, 3005, 2783, 3009, 2779, 3014, 2774, 3018, 2769, 3022, 2765, 3026, 2760, 3031, 2755,
        3035, 2751, 3039, 2746, 3043, 2741, 3048, 2737, 3052, 2732, 3056, 2727, 3060, 2723, 3064,
        2718, 3068, 2713, 3073, 2709, 3077, 2704, 3081, 2699, 3085, 2694, 3089, 2690, 3093, 2685,
        3097, 2680, 3102, 2675, 3106, 2671, 3110, 2666, 3114, 2661, 3118, 2656, 3122, 2652, 3126,
        2647, 3130, 2642, 3134, 2637, 3138, 2632, 3142, 2628, 3146, 2623, 3150, 2618, 3154, 2613,
        3158, 2608, 3162, 2603, 3166, 2598, 3170, 2594, 3174, 2589, 3178, 2584, 3182, 2579, 3186,
        2574, 3190, 2569, 3194, 2564, 3198, 2559, 3202, 2555, 3206, 2550, 3210, 2545, 3214, 2540,
        3217, 2535, 3221, 2530, 3225, 2525, 3229, 2520, 3233, 2515, 3237, 2510, 3241, 2505, 3244,
        2500, 3248, 2495, 3252, 2490, 3256, 2485, 3260, 2480, 3264, 2475, 3267, 2470, 3271, 2465,
        3275, 2460, 3279, 2455, 3282, 2450, 3286, 2445, 3290, 2440, 3294, 2435, 3297, 2430, 3301,
        2425, 3305, 2420, 3309, 2415, 3312, 2410, 3316, 2405, 3320, 2399, 3323, 2394, 3327, 2389,
        3331, 2384, 3334, 2379, 3338, 2374, 3342, 2369, 3345, 2364, 3349, 2359, 3352, 2353, 3356,
        2348, 3360, 2343, 3363, 2338, 3367, 2333, 3370, 2328, 3374, 2322, 3378, 2317, 3381, 2312,
        3385, 2307, 3388, 2302, 3392, 2296, 3395, 2291, 3399, 2286, 3402, 2281, 3406, 2276, 3409,
        2270, 3413, 2265, 3416, 2260, 3420, 2255, 3423, 2249, 3426, 2244, 3430, 2239, 3433, 2234,
        3437, 2228, 3440, 2223, 3444, 2218, 3447, 2213, 3450, 2207, 3454, 2202, 3457, 2197, 3461,
        2191, 3464, 2186, 3467, 2181, 3471, 2175, 3474, 2170, 3477, 2165, 3481, 2159, 3484, 2154,
        3487, 2149, 3490, 2143, 3494, 2138, 3497, 2133, 3500, 2127, 3504, 2122, 3507, 2117, 3510,
        2111, 3513, 2106, 3516, 2100, 3520, 2095, 3523, 2090, 3526, 2084, 3529, 2079, 3532, 2073,
        3536, 2068, 3539, 2062, 3542, 2057, 3545, 2052, 3548, 2046, 3551, 2041, 3555, 2035, 3558,
        2030, 3561, 2024, 3564, 2019, 3567, 2013, 3570, 2008, 3573, 2002, 3576, 1997, 3579, 1992,
        3582, 1986, 3585, 1981, 3588, 1975, 3591, 1970, 3594, 1964, 3597, 1958, 3600, 1953, 3603,
        1947, 3606, 1942, 3609, 1936, 3612, 1931, 3615, 1925, 3618, 1920, 3621, 1914, 3624, 1909,
        3627, 1903, 3630, 1898, 3633, 1892, 3636, 1886, 3639, 1881, 3642, 1875, 3644, 1870, 3647,
        1864, 3650, 1858, 3653, 1853, 3656, 1847, 3659, 1842, 3661, 1836, 3664, 1830, 3667, 1825,
        3670, 1819, 3673, 1813, 3675, 1808, 3678, 1802, 3681, 1797, 3684, 1791, 3686, 1785, 3689,
        1780, 3692, 1774, 3695, 1768, 3697, 1763, 3700, 1757, 3703, 1751, 3705, 1746, 3708, 1740,
        3711, 1734, 3713, 1729, 3716, 1723, 3719, 1717, 3721, 1711, 3724, 1706, 3727, 1700, 3729,
        1694, 3732, 1689, 3734, 1683, 3737, 1677, 3739, 1671, 3742, 1666, 3745, 1660, 3747, 1654,
        3750, 1648, 3752, 1643, 3755, 1637, 3757, 1631, 3760, 1625, 3762, 1620, 3765, 1614, 3767,
        1608, 3770, 1602, 3772, 1596, 3775, 1591, 3777, 1585, 3779, 1579, 3782, 1573, 3784, 1567,
        3787, 1562, 3789, 1556, 3791, 1550, 3794, 1544, 3796, 1538, 3798, 1533, 3801, 1527, 3803,
        1521, 3805, 1515, 3808, 1509, 3810, 1503, 3812, 1498, 3815, 1492, 3817, 1486, 3819, 1480,
        3822, 1474, 3824, 1468, 3826, 1462, 3828, 1457, 3831, 1451, 3833, 1445, 3835, 1439, 3837,
        1433, 3839, 1427, 3842, 1421, 3844, 1415, 3846, 1409, 3848, 1404, 3850, 1398, 3852, 1392,
        3854, 1386, 3857, 1380, 3859, 1374, 3861, 1368, 3863, 1362, 3865, 1356, 3867, 1350, 3869,
        1344, 3871, 1338, 3873, 1332, 3875, 1327, 3877, 1321, 3879, 1315, 3881, 1309, 3883, 1303,
        3885, 1297, 3887, 1291, 3889, 1285, 3891, 1279, 3893, 1273, 3895, 1267, 3897, 1261, 3899,
        1255, 3901, 1249, 3903, 1243, 3905, 1237, 3907, 1231, 3909, 1225, 3910, 1219, 3912, 1213,
        3914, 1207, 3916, 1201, 3918, 1195, 3920, 1189, 3921, 1183, 3923, 1177, 3925, 1171, 3927,
        1165, 3929, 1159, 3930, 1153, 3932, 1147, 3934, 1141, 3936, 1135, 3937, 1129, 3939, 1123,
        3941, 1117, 3943, 1111, 3944, 1105, 3946, 1099, 3948, 1092, 3949, 1086, 3951, 1080, 3953,
        1074, 3954, 1068, 3956, 1062, 3958, 1056, 3959, 1050, 3961, 1044, 3962, 1038, 3964, 1032,
        3965, 1026, 3967, 1020, 3969, 1014, 3970, 1007, 3972, 1001, 3973, 995, 3975, 989, 3976,
        983, 3978, 977, 3979, 971, 3981, 965, 3982, 959, 3984, 953, 3985, 946, 3987, 940, 3988,
        934, 3989, 928, 3991, 922, 3992, 916, 3994, 910, 3995, 904, 3996, 897, 3998, 891, 3999,
        885, 4001, 879, 4002, 873, 4003, 867, 4005, 861, 4006, 854, 4007, 848, 4008, 842, 4010,
        836, 4011, 830, 4012, 824, 4014, 818, 4015, 811, 4016, 805, 4017, 799, 4019, 793, 4020,
        787, 4021, 781, 4022, 774, 4023, 768, 4024, 762, 4026, 756, 4027, 750, 4028, 744, 4029,
        737, 4030, 731, 4031, 725, 4032, 719, 4034, 713, 4035, 706, 4036, 700, 4037, 694, 4038,
        688, 4039, 682, 4040, 675, 4041, 669, 4042, 663, 4043, 657, 4044, 651, 4045, 644, 4046,
        638, 4047, 632, 4048, 626, 4049, 620, 4050, 613, 4051, 607, 4052, 601, 4053, 595, 4053,
        589, 4054, 582, 4055, 576, 4056, 570, 4057, 564, 4058, 557, 4059, 551, 4060, 545, 4060,
        539, 4061, 533, 4062, 526, 4063, 520, 4064, 514, 4064, 508, 4065, 501, 4066, 495, 4067,
        489, 4067, 483, 4068, 476, 4069, 470, 4070, 464, 4070, 458, 4071, 451, 4072, 445, 4072,
        439, 4073, 433, 4074, 426, 4074, 420, 4075, 414, 4076, 408, 4076, 401, 4077, 395, 4077,
        389, 4078, 383, 4079, 376, 4079, 370, 4080, 364, 4080, 358, 4081, 351, 4081, 345, 4082,
        339, 4082, 333, 4083, 326, 4083, 320, 4084, 314, 4084, 308, 4085, 301, 4085, 295, 4086,
        289, 4086, 283, 4087, 276, 4087, 270, 4088, 264, 4088, 257, 4088, 251, 4089, 245, 4089,
        239, 4089, 232, 4090, 226, 4090, 220, 4090, 214, 4091, 207, 4091, 201, 4091, 195, 4092,
        188, 4092, 182, 4092, 176, 4092, 170, 4093, 163, 4093, 157, 4093, 151, 4093, 144, 4094,
        138, 4094, 132, 4094, 126, 4094, 119, 4094, 113, 4095, 107, 4095, 101, 4095, 94, 4095,
        88, 4095, 82, 4095, 75, 4095, 69, 4096, 63, 4096, 57, 4096, 50, 4096, 44, 4096, 38, 4096,
        31, 4096, 25, 4096, 19, 4096, 13, 4096, 6, 4096, 0, 4096, -6, 4096, -13, 4096, -19, 4096,
        -25, 4096, -31, 4096, -38, 4096, -44, 4096, -50, 4096, -57, 4096, -63, 4095, -69, 4095,
        -75, 4095, -82, 4095, -88, 4095, -94, 4095, -101, 4095, -107, 4094, -113, 4094, -119,
        4094, -126, 4094, -132, 4094, -138, 4093, -144, 4093, -151, 4093, -157, 4093, -163, 4092,
        -170, 4092, -176, 4092, -182, 4092, -188, 4091, -195, 4091, -201, 4091, -207, 4090, -214,
        4090, -220, 4090, -226, 4089, -232, 4089, -239, 4089, -245, 4088, -251, 4088, -257, 4088,
        -264, 4087, -270, 4087, -276, 4086, -283, 4086, -289, 4085, -295, 4085, -301, 4084, -308,
        4084, -314, 4083, -320, 4083, -326, 4082, -333, 4082, -339, 4081, -345, 4081, -351, 4080,
        -358, 4080, -364, 4079, -370, 4079, -376, 4078, -383, 4077, -389, 4077, -395, 4076, -401,
        4076, -408, 4075, -414, 4074, -420, 4074, -426, 4073, -433, 4072, -439, 4072, -445, 4071,
        -451, 4070, -458, 4070, -464, 4069, -470, 4068, -476, 4067, -483, 4067, -489, 4066, -495,
        4065, -501, 4064, -508, 4064, -514, 4063, -520, 4062, -526, 4061, -533, 4060, -539, 4060,
        -545, 4059, -551, 4058, -557, 4057, -564, 4056, -570, 4055, -576, 4054, -582, 4053, -589,
        4053, -595, 4052, -601, 4051, -607, 4050, -613, 4049, -620, 4048, -626, 4047, -632, 4046,
        -638, 4045, -644, 4044, -651, 4043, -657, 4042, -663, 4041, -669, 4040, -675, 4039, -682,
        4038, -688, 4037, -694, 4036, -700, 4035, -706, 4034, -713, 4032, -719, 4031, -725, 4030,
        -731, 4029, -737, 4028, -744, 4027, -750, 4026, -756, 4024, -762, 4023, -768, 4022, -774,
        4021, -781, 4020, -787, 4019, -793, 4017, -799, 4016, -805, 4015, -811, 4014, -818, 4012,
        -824, 4011, -830, 4010, -836, 4008, -842, 4007, -848, 4006, -854, 4005, -861, 4003, -867,
        4002, -873, 4001, -879, 3999, -885, 3998, -891, 3996, -897, 3995, -904, 3994, -910, 3992,
        -916, 3991, -922, 3989, -928, 3988, -934, 3987, -940, 3985, -946, 3984, -953, 3982, -959,
        3981, -965, 3979, -971, 3978, -977, 3976, -983, 3975, -989, 3973, -995, 3972, -1001, 3970,
        -1007, 3969, -1014, 3967, -1020, 3965, -1026, 3964, -1032, 3962, -1038, 3961, -1044, 3959,
        -1050, 3958, -1056, 3956, -1062, 3954, -1068, 3953, -1074, 3951, -1080, 3949, -1086, 3948,
        -1092, 3946, -1099, 3944, -1105, 3943, -1111, 3941, -1117, 3939, -1123, 3937, -1129, 3936,
        -1135, 3934, -1141, 3932, -1147, 3930, -1153, 3929, -1159, 3927, -1165, 3925, -1171, 3923,
        -1177, 3921, -1183, 3920, -1189, 3918, -1195, 3916, -1201, 3914, -1207, 3912, -1213, 3910,
        -1219, 3909, -1225, 3907, -1231, 3905, -1237, 3903, -1243, 3901, -1249, 3899, -1255, 3897,
        -1261, 3895, -1267, 3893, -1273, 3891, -1279, 3889, -1285, 3887, -1291, 3885, -1297, 3883,
        -1303, 3881, -1309, 3879, -1315, 3877, -1321, 3875, -1327, 3873, -1332, 3871, -1338, 3869,
        -1344, 3867, -1350, 3865, -1356, 3863, -1362, 3861, -1368, 3859, -1374, 3857, -1380, 3854,
        -1386, 3852, -1392, 3850, -1398, 3848, -1404, 3846, -1409, 3844, -1415, 3842, -1421, 3839,
        -1427, 3837, -1433, 3835, -1439, 3833, -1445, 3831, -1451, 3828, -1457, 3826, -1462, 3824,
        -1468, 3822, -1474, 3819, -1480, 3817, -1486, 3815, -1492, 3812, -1498, 3810, -1503, 3808,
        -1509, 3805, -1515, 3803, -1521, 3801, -1527, 3798, -1533, 3796, -1538, 3794, -1544, 3791,
        -1550, 3789, -1556, 3787, -1562, 3784, -1567, 3782, -1573, 3779, -1579, 3777, -1585, 3775,
        -1591, 3772, -1596, 3770, -1602, 3767, -1608, 3765, -1614, 3762, -1620, 3760, -1625, 3757,
        -1631, 3755, -1637, 3752, -1643, 3750, -1648, 3747, -1654, 3745, -1660, 3742, -1666, 3739,
        -1671, 3737, -1677, 3734, -1683, 3732, -1689, 3729, -1694, 3727, -1700, 3724, -1706, 3721,
        -1711, 3719, -1717, 3716, -1723, 3713, -1729, 3711, -1734, 3708, -1740, 3705, -1746, 3703,
        -1751, 3700, -1757, 3697, -1763, 3695, -1768, 3692, -1774, 3689, -1780, 3686, -1785, 3684,
        -1791, 3681, -1797, 3678, -1802, 3675, -1808, 3673, -1813, 3670, -1819, 3667, -1825, 3664,
        -1830, 3661, -1836, 3659, -1842, 3656, -1847, 3653, -1853, 3650, -1858, 3647, -1864, 3644,
        -1870, 3642, -1875, 3639, -1881, 3636, -1886, 3633, -1892, 3630, -1898, 3627, -1903, 3624,
        -1909, 3621, -1914, 3618, -1920, 3615, -1925, 3612, -1931, 3609, -1936, 3606, -1942, 3603,
        -1947, 3600, -1953, 3597, -1958, 3594, -1964, 3591, -1970, 3588, -1975, 3585, -1981, 3582,
        -1986, 3579, -1992, 3576, -1997, 3573, -2002, 3570, -2008, 3567, -2013, 3564, -2019, 3561,
        -2024, 3558, -2030, 3555, -2035, 3551, -2041, 3548, -2046, 3545, -2052, 3542, -2057, 3539,
        -2062, 3536, -2068, 3532, -2073, 3529, -2079, 3526, -2084, 3523, -2090, 3520, -2095, 3516,
        -2100, 3513, -2106, 3510, -2111, 3507, -2117, 3504, -2122, 3500, -2127, 3497, -2133, 3494,
        -2138, 3490, -2143, 3487, -2149, 3484, -2154, 3481, -2159, 3477, -2165, 3474, -2170, 3471,
        -2175, 3467, -2181, 3464, -2186, 3461, -2191, 3457, -2197, 3454, -2202, 3450, -2207, 3447,
        -2213, 3444, -2218, 3440, -2223, 3437, -2228, 3433, -2234, 3430, -2239, 3426, -2244, 3423,
        -2249, 3420, -2255, 3416, -2260, 3413, -2265, 3409, -2270, 3406, -2276, 3402, -2281, 3399,
        -2286, 3395, -2291, 3392, -2296, 3388, -2302, 3385, -2307, 3381, -2312, 3378, -2317, 3374,
        -2322, 3370, -2328, 3367, -2333, 3363, -2338, 3360, -2343, 3356, -2348, 3352, -2353, 3349,
        -2359, 3345, -2364, 3342, -2369, 3338, -2374, 3334, -2379, 3331, -2384, 3327, -2389, 3323,
        -2394, 3320, -2399, 3316, -2405, 3312, -2410, 3309, -2415, 3305, -2420, 3301, -2425, 3297,
        -2430, 3294, -2435, 3290, -2440, 3286, -2445, 3282, -2450, 3279, -2455, 3275, -2460, 3271,
        -2465, 3267, -2470, 3264, -2475, 3260, -2480, 3256, -2485, 3252, -2490, 3248, -2495, 3244,
        -2500, 3241, -2505, 3237, -2510, 3233, -2515, 3229, -2520, 3225, -2525, 3221, -2530, 3217,
        -2535, 3214, -2540, 3210, -2545, 3206, -2550, 3202, -2555, 3198, -2559, 3194, -2564, 3190,
        -2569, 3186, -2574, 3182, -2579, 3178, -2584, 3174, -2589, 3170, -2594, 3166, -2598, 3162,
        -2603, 3158, -2608, 3154, -2613, 3150, -2618, 3146, -2623, 3142, -2628, 3138, -2632, 3134,
        -2637, 3130, -2642, 3126, -2647, 3122, -2652, 3118, -2656, 3114, -2661, 3110, -2666, 3106,
        -2671, 3102, -2675, 3097, -2680, 3093, -2685, 3089, -2690, 3085, -2694, 3081, -2699, 3077,
        -2704, 3073, -2709, 3068, -2713, 3064, -2718, 3060, -2723, 3056, -2727, 3052, -2732, 3048,
        -2737, 3043, -2741, 3039, -2746, 3035, -2751, 3031, -2755, 3026, -2760, 3022, -2765, 3018,
        -2769, 3014, -2774, 3009, -2779, 3005, -2783, 3001, -2788, 2997, -2792, 2992, -2797, 2988,
        -2802, 2984, -2806, 2979, -2811, 2975, -2815, 2971, -2820, 2967, -2824, 2962, -2829, 2958,
        -2833, 2953, -2838, 2949, -2843, 2945, -2847, 2940, -2852, 2936, -2856, 2932, -2861, 2927,
        -2865, 2923, -2870, 2918, -2874, 2914, -2878, 2910, -2883, 2905, -2887, 2901, -2892, 2896,
        -2896, 2892, -2901, 2887, -2905, 2883, -2910, 2878, -2914, 2874, -2918, 2870, -2923, 2865,
        -2927, 2861, -2932, 2856, -2936, 2852, -2940, 2847, -2945, 2843, -2949, 2838, -2953, 2833,
        -2958, 2829, -2962, 2824, -2967, 2820, -2971, 2815, -2975, 2811, -2979, 2806, -2984, 2802,
        -2988, 2797, -2992, 2792, -2997, 2788, -3001, 2783, -3005, 2779, -3009, 2774, -3014, 2769,
        -3018, 2765, -3022, 2760, -3026, 2755, -3031, 2751, -3035, 2746, -3039, 2741, -3043, 2737,
        -3048, 2732, -3052, 2727, -3056, 2723, -3060, 2718, -3064, 2713, -3068, 2709, -3073, 2704,
        -3077, 2699, -3081, 2694, -3085, 2690, -3089, 2685, -3093, 2680, -3097, 2675, -3102, 2671,
        -3106, 2666, -3110, 2661, -3114, 2656, -3118, 2652, -3122, 2647, -3126, 2642, -3130, 2637,
        -3134, 2632, -3138, 2628, -3142, 2623, -3146, 2618, -3150, 2613, -3154, 2608, -3158, 2603,
        -3162, 2598, -3166, 2594, -3170, 2589, -3174, 2584, -3178, 2579, -3182, 2574, -3186, 2569,
        -3190, 2564, -3194, 2559, -3198, 2555, -3202, 2550, -3206, 2545, -3210, 2540, -3214, 2535,
        -3217, 2530, -3221, 2525, -3225, 2520, -3229, 2515, -3233, 2510, -3237, 2505, -3241, 2500,
        -3244, 2495, -3248, 2490, -3252, 2485, -3256, 2480, -3260, 2475, -3264, 2470, -3267, 2465,
        -3271, 2460, -3275, 2455, -3279, 2450, -3282, 2445, -3286, 2440, -3290, 2435, -3294, 2430,
        -3297, 2425, -3301, 2420, -3305, 2415, -3309, 2410, -3312, 2405, -3316, 2399, -3320, 2394,
        -3323, 2389, -3327, 2384, -3331, 2379, -3334, 2374, -3338, 2369, -3342, 2364, -3345, 2359,
        -3349, 2353, -3352, 2348, -3356, 2343, -3360, 2338, -3363, 2333, -3367, 2328, -3370, 2322,
        -3374, 2317, -3378, 2312, -3381, 2307, -3385, 2302, -3388, 2296, -3392, 2291, -3395, 2286,
        -3399, 2281, -3402, 2276, -3406, 2270, -3409, 2265, -3413, 2260, -3416, 2255, -3420, 2249,
        -3423, 2244, -3426, 2239, -3430, 2234, -3433, 2228, -3437, 2223, -3440, 2218, -3444, 2213,
        -3447, 2207, -3450, 2202, -3454, 2197, -3457, 2191, -3461, 2186, -3464, 2181, -3467, 2175,
        -3471, 2170, -3474, 2165, -3477, 2159, -3481, 2154, -3484, 2149, -3487, 2143, -3490, 2138,
        -3494, 2133, -3497, 2127, -3500, 2122, -3504, 2117, -3507, 2111, -3510, 2106, -3513, 2100,
        -3516, 2095, -3520, 2090, -3523, 2084, -3526, 2079, -3529, 2073, -3532, 2068, -3536, 2062,
        -3539, 2057, -3542, 2052, -3545, 2046, -3548, 2041, -3551, 2035, -3555, 2030, -3558, 2024,
        -3561, 2019, -3564, 2013, -3567, 2008, -3570, 2002, -3573, 1997, -3576, 1992, -3579, 1986,
        -3582, 1981, -3585, 1975, -3588, 1970, -3591, 1964, -3594, 1958, -3597, 1953, -3600, 1947,
        -3603, 1942, -3606, 1936, -3609, 1931, -3612, 1925, -3615, 1920, -3618, 1914, -3621, 1909,
        -3624, 1903, -3627, 1898, -3630, 1892, -3633, 1886, -3636, 1881, -3639, 1875, -3642, 1870,
        -3644, 1864, -3647, 1858, -3650, 1853, -3653, 1847, -3656, 1842, -3659, 1836, -3661, 1830,
        -3664, 1825, -3667, 1819, -3670, 1813, -3673, 1808, -3675, 1802, -3678, 1797, -3681, 1791,
        -3684, 1785, -3686, 1780, -3689, 1774, -3692, 1768, -3695, 1763, -3697, 1757, -3700, 1751,
        -3703, 1746, -3705, 1740, -3708, 1734, -3711, 1729, -3713, 1723, -3716, 1717, -3719, 1711,
        -3721, 1706, -3724, 1700, -3727, 1694, -3729, 1689, -3732, 1683, -3734, 1677, -3737, 1671,
        -3739, 1666, -3742, 1660, -3745, 1654, -3747, 1648, -3750, 1643, -3752, 1637, -3755, 1631,
        -3757, 1625, -3760, 1620, -3762, 1614, -3765, 1608, -3767, 1602, -3770, 1596, -3772, 1591,
        -3775, 1585, -3777, 1579, -3779, 1573, -3782, 1567, -3784, 1562, -3787, 1556, -3789, 1550,
        -3791, 1544, -3794, 1538, -3796, 1533, -3798, 1527, -3801, 1521, -3803, 1515, -3805, 1509,
        -3808, 1503, -3810, 1498, -3812, 1492, -3815, 1486, -3817, 1480, -3819, 1474, -3822, 1468,
        -3824, 1462, -3826, 1457, -3828, 1451, -3831, 1445, -3833, 1439, -3835, 1433, -3837, 1427,
        -3839, 1421, -3842, 1415, -3844, 1409, -3846, 1404, -3848, 1398, -3850, 1392, -3852, 1386,
        -3854, 1380, -3857, 1374, -3859, 1368, -3861, 1362, -3863, 1356, -3865, 1350, -3867, 1344,
        -3869, 1338, -3871, 1332, -3873, 1327, -3875, 1321, -3877, 1315, -3879, 1309, -3881, 1303,
        -3883, 1297, -3885, 1291, -3887, 1285, -3889, 1279, -3891, 1273, -3893, 1267, -3895, 1261,
        -3897, 1255, -3899, 1249, -3901, 1243, -3903, 1237, -3905, 1231, -3907, 1225, -3909, 1219,
        -3910, 1213, -3912, 1207, -3914, 1201, -3916, 1195, -3918, 1189, -3920, 1183, -3921, 1177,
        -3923, 1171, -3925, 1165, -3927, 1159, -3929, 1153, -3930, 1147, -3932, 1141, -3934, 1135,
        -3936, 1129, -3937, 1123, -3939, 1117, -3941, 1111, -3943, 1105, -3944, 1099, -3946, 1092,
        -3948, 1086, -3949, 1080, -3951, 1074, -3953, 1068, -3954, 1062, -3956, 1056, -3958, 1050,
        -3959, 1044, -3961, 1038, -3962, 1032, -3964, 1026, -3965, 1020, -3967, 1014, -3969, 1007,
        -3970, 1001, -3972, 995, -3973, 989, -3975, 983, -3976, 977, -3978, 971, -3979, 965, -3981,
        959, -3982, 953, -3984, 946, -3985, 940, -3987, 934, -3988, 928, -3989, 922, -3991, 916,
        -3992, 910, -3994, 904, -3995, 897, -3996, 891, -3998, 885, -3999, 879, -4001, 873, -4002,
        867, -4003, 861, -4005, 854, -4006, 848, -4007, 842, -4008, 836, -4010, 830, -4011, 824,
        -4012, 818, -4014, 811, -4015, 805, -4016, 799, -4017, 793, -4019, 787, -4020, 781, -4021,
        774, -4022, 768, -4023, 762, -4024, 756, -4026, 750, -4027, 744, -4028, 737, -4029, 731,
        -4030, 725, -4031, 719, -4032, 713, -4034, 706, -4035, 700, -4036, 694, -4037, 688, -4038,
        682, -4039, 675, -4040, 669, -4041, 663, -4042, 657, -4043, 651, -4044, 644, -4045, 638,
        -4046, 632, -4047, 626, -4048, 620, -4049, 613, -4050, 607, -4051, 601, -4052, 595, -4053,
        589, -4053, 582, -4054, 576, -4055, 570, -4056, 564, -4057, 557, -4058, 551, -4059, 545,
        -4060, 539, -4060, 533, -4061, 526, -4062, 520, -4063, 514, -4064, 508, -4064, 501, -4065,
        495, -4066, 489, -4067, 483, -4067, 476, -4068, 470, -4069, 464, -4070, 458, -4070, 451,
        -4071, 445, -4072, 439, -4072, 433, -4073, 426, -4074, 420, -4074, 414, -4075, 408, -4076,
        401, -4076, 395, -4077, 389, -4077, 383, -4078, 376, -4079, 370, -4079, 364, -4080, 358,
        -4080, 351, -4081, 345, -4081, 339, -4082, 333, -4082, 326, -4083, 320, -4083, 314, -4084,
        308, -4084, 301, -4085, 295, -4085, 289, -4086, 283, -4086, 276, -4087, 270, -4087, 264,
        -4088, 257, -4088, 251, -4088, 245, -4089, 239, -4089, 232, -4089, 226, -4090, 220, -4090,
        214, -4090, 207, -4091, 201, -4091, 195, -4091, 188, -4092, 182, -4092, 176, -4092, 170,
        -4092, 163, -4093, 157, -4093, 151, -4093, 144, -4093, 138, -4094, 132, -4094, 126, -4094,
        119, -4094, 113, -4094, 107, -4095, 101, -4095, 94, -4095, 88, -4095, 82, -4095, 75,
        -4095, 69, -4095, 63, -4096, 57, -4096, 50, -4096, 44, -4096, 38, -4096, 31, -4096, 25,
        -4096, 19, -4096, 13, -4096, 6, -4096, 0, -4096, -6, -4096, -13, -4096, -19, -4096, -25,
        -4096, -31, -4096, -38, -4096, -44, -4096, -50, -4096, -57, -4096, -63, -4096, -69, -4095,
        -75, -4095, -82, -4095, -88, -4095, -94, -4095, -101, -4095, -107, -4095, -113, -4094,
        -119, -4094, -126, -4094, -132, -4094, -138, -4094, -144, -4093, -151, -4093, -157, -4093,
        -163, -4093, -170, -4092, -176, -4092, -182, -4092, -188, -4092, -195, -4091, -201, -4091,
        -207, -4091, -214, -4090, -220, -4090, -226, -4090, -232, -4089, -239, -4089, -245, -4089,
        -251, -4088, -257, -4088, -264, -4088, -270, -4087, -276, -4087, -283, -4086, -289, -4086,
        -295, -4085, -301, -4085, -308, -4084, -314, -4084, -320, -4083, -326, -4083, -333, -4082,
        -339, -4082, -345, -4081, -351, -4081, -358, -4080, -364, -4080, -370, -4079, -376, -4079,
        -383, -4078, -389, -4077, -395, -4077, -401, -4076, -408, -4076, -414, -4075, -420, -4074,
        -426, -4074, -433, -4073, -439, -4072, -445, -4072, -451, -4071, -458, -4070, -464, -4070,
        -470, -4069, -476, -4068, -483, -4067, -489, -4067, -495, -4066, -501, -4065, -508, -4064,
        -514, -4064, -520, -4063, -526, -4062, -533, -4061, -539, -4060, -545, -4060, -551, -4059,
        -557, -4058, -564, -4057, -570, -4056, -576, -4055, -582, -4054, -589, -4053, -595, -4053,
        -601, -4052, -607, -4051, -613, -4050, -620, -4049, -626, -4048, -632, -4047, -638, -4046,
        -644, -4045, -651, -4044, -657, -4043, -663, -4042, -669, -4041, -675, -4040, -682, -4039,
        -688, -4038, -694, -4037, -700, -4036, -706, -4035, -713, -4034, -719, -4032, -725, -4031,
        -731, -4030, -737, -4029, -744, -4028, -750, -4027, -756, -4026, -762, -4024, -768, -4023,
        -774, -4022, -781, -4021, -787, -4020, -793, -4019, -799, -4017, -805, -4016, -811, -4015,
        -818, -4014, -824, -4012, -830, -4011, -836, -4010, -842, -4008, -848, -4007, -854, -4006,
        -861, -4005, -867, -4003, -873, -4002, -879, -4001, -885, -3999, -891, -3998, -897, -3996,
        -904, -3995, -910, -3994, -916, -3992, -922, -3991, -928, -3989, -934, -3988, -940, -3987,
        -946, -3985, -953, -3984, -959, -3982, -965, -3981, -971, -3979, -977, -3978, -983, -3976,
        -989, -3975, -995, -3973, -1001, -3972, -1007, -3970, -1014, -3969, -1020, -3967, -1026,
        -3965, -1032, -3964, -1038, -3962, -1044, -3961, -1050, -3959, -1056, -3958, -1062, -3956,
        -1068, -3954, -1074, -3953, -1080, -3951, -1086, -3949, -1092, -3948, -1099, -3946, -1105,
        -3944, -1111, -3943, -1117, -3941, -1123, -3939, -1129, -3937, -1135, -3936, -1141, -3934,
        -1147, -3932, -1153, -3930, -1159, -3929, -1165, -3927, -1171, -3925, -1177, -3923, -1183,
        -3921, -1189, -3920, -1195, -3918, -1201, -3916, -1207, -3914, -1213, -3912, -1219, -3910,
        -1225, -3909, -1231, -3907, -1237, -3905, -1243, -3903, -1249, -3901, -1255, -3899, -1261,
        -3897, -1267, -3895, -1273, -3893, -1279, -3891, -1285, -3889, -1291, -3887, -1297, -3885,
        -1303, -3883, -1309, -3881, -1315, -3879, -1321, -3877, -1327, -3875, -1332, -3873, -1338,
        -3871, -1344, -3869, -1350, -3867, -1356, -3865, -1362, -3863, -1368, -3861, -1374, -3859,
        -1380, -3857, -1386, -3854, -1392, -3852, -1398, -3850, -1404, -3848, -1409, -3846, -1415,
        -3844, -1421, -3842, -1427, -3839, -1433, -3837, -1439, -3835, -1445, -3833, -1451, -3831,
        -1457, -3828, -1462, -3826, -1468, -3824, -1474, -3822, -1480, -3819, -1486, -3817, -1492,
        -3815, -1498, -3812, -1503, -3810, -1509, -3808, -1515, -3805, -1521, -3803, -1527, -3801,
        -1533, -3798, -1538, -3796, -1544, -3794, -1550, -3791, -1556, -3789, -1562, -3787, -1567,
        -3784, -1573, -3782, -1579, -3779, -1585, -3777, -1591, -3775, -1596, -3772, -1602, -3770,
        -1608, -3767, -1614, -3765, -1620, -3762, -1625, -3760, -1631, -3757, -1637, -3755, -1643,
        -3752, -1648, -3750, -1654, -3747, -1660, -3745, -1666, -3742, -1671, -3739, -1677, -3737,
        -1683, -3734, -1689, -3732, -1694, -3729, -1700, -3727, -1706, -3724, -1711, -3721, -1717,
        -3719, -1723, -3716, -1729, -3713, -1734, -3711, -1740, -3708, -1746, -3705, -1751, -3703,
        -1757, -3700, -1763, -3697, -1768, -3695, -1774, -3692, -1780, -3689, -1785, -3686, -1791,
        -3684, -1797, -3681, -1802, -3678, -1808, -3675, -1813, -3673, -1819, -3670, -1825, -3667,
        -1830, -3664, -1836, -3661, -1842, -3659, -1847, -3656, -1853, -3653, -1858, -3650, -1864,
        -3647, -1870, -3644, -1875, -3642, -1881, -3639, -1886, -3636, -1892, -3633, -1898, -3630,
        -1903, -3627, -1909, -3624, -1914, -3621, -1920, -3618, -1925, -3615, -1931, -3612, -1936,
        -3609, -1942, -3606, -1947, -3603, -1953, -3600, -1958, -3597, -1964, -3594, -1970, -3591,
        -1975, -3588, -1981, -3585, -1986, -3582, -1992, -3579, -1997, -3576, -2002, -3573, -2008,
        -3570, -2013, -3567, -2019, -3564, -2024, -3561, -2030, -3558, -2035, -3555, -2041, -3551,
        -2046, -3548, -2052, -3545, -2057, -3542, -2062, -3539, -2068, -3536, -2073, -3532, -2079,
        -3529, -2084, -3526, -2090, -3523, -2095, -3520, -2100, -3516, -2106, -3513, -2111, -3510,
        -2117, -3507, -2122, -3504, -2127, -3500, -2133, -3497, -2138, -3494, -2143, -3490, -2149,
        -3487, -2154, -3484, -2159, -3481, -2165, -3477, -2170, -3474, -2175, -3471, -2181, -3467,
        -2186, -3464, -2191, -3461, -2197, -3457, -2202, -3454, -2207, -3450, -2213, -3447, -2218,
        -3444, -2223, -3440, -2228, -3437, -2234, -3433, -2239, -3430, -2244, -3426, -2249, -3423,
        -2255, -3420, -2260, -3416, -2265, -3413, -2270, -3409, -2276, -3406, -2281, -3402, -2286,
        -3399, -2291, -3395, -2296, -3392, -2302, -3388, -2307, -3385, -2312, -3381, -2317, -3378,
        -2322, -3374, -2328, -3370, -2333, -3367, -2338, -3363, -2343, -3360, -2348, -3356, -2353,
        -3352, -2359, -3349, -2364, -3345, -2369, -3342, -2374, -3338, -2379, -3334, -2384, -3331,
        -2389, -3327, -2394, -3323, -2399, -3320, -2405, -3316, -2410, -3312, -2415, -3309, -2420,
        -3305, -2425, -3301, -2430, -3297, -2435, -3294, -2440, -3290, -2445, -3286, -2450, -3282,
        -2455, -3279, -2460, -3275, -2465, -3271, -2470, -3267, -2475, -3264, -2480, -3260, -2485,
        -3256, -2490, -3252, -2495, -3248, -2500, -3244, -2505, -3241, -2510, -3237, -2515, -3233,
        -2520, -3229, -2525, -3225, -2530, -3221, -2535, -3217, -2540, -3214, -2545, -3210, -2550,
        -3206, -2555, -3202, -2559, -3198, -2564, -3194, -2569, -3190, -2574, -3186, -2579, -3182,
        -2584, -3178, -2589, -3174, -2594, -3170, -2598, -3166, -2603, -3162, -2608, -3158, -2613,
        -3154, -2618, -3150, -2623, -3146, -2628, -3142, -2632, -3138, -2637, -3134, -2642, -3130,
        -2647, -3126, -2652, -3122, -2656, -3118, -2661, -3114, -2666, -3110, -2671, -3106, -2675,
        -3102, -2680, -3097, -2685, -3093, -2690, -3089, -2694, -3085, -2699, -3081, -2704, -3077,
        -2709, -3073, -2713, -3068, -2718, -3064, -2723, -3060, -2727, -3056, -2732, -3052, -2737,
        -3048, -2741, -3043, -2746, -3039, -2751, -3035, -2755, -3031, -2760, -3026, -2765, -3022,
        -2769, -3018, -2774, -3014, -2779, -3009, -2783, -3005, -2788, -3001, -2792, -2997, -2797,
        -2992, -2802, -2988, -2806, -2984, -2811, -2979, -2815, -2975, -2820, -2971, -2824, -2967,
        -2829, -2962, -2833, -2958, -2838, -2953, -2843, -2949, -2847, -2945, -2852, -2940, -2856,
        -2936, -2861, -2932, -2865, -2927, -2870, -2923, -2874, -2918, -2878, -2914, -2883, -2910,
        -2887, -2905, -2892, -2901, -2896, -2896, -2901, -2892, -2905, -2887, -2910, -2883, -2914,
        -2878, -2918, -2874, -2923, -2870, -2927, -2865, -2932, -2861, -2936, -2856, -2940, -2852,
        -2945, -2847, -2949, -2843, -2953, -2838, -2958, -2833, -2962, -2829, -2967, -2824, -2971,
        -2820, -2975, -2815, -2979, -2811, -2984, -2806, -2988, -2802, -2992, -2797, -2997, -2792,
        -3001, -2788, -3005, -2783, -3009, -2779, -3014, -2774, -3018, -2769, -3022, -2765, -3026,
        -2760, -3031, -2755, -3035, -2751, -3039, -2746, -3043, -2741, -3048, -2737, -3052, -2732,
        -3056, -2727, -3060, -2723, -3064, -2718, -3068, -2713, -3073, -2709, -3077, -2704, -3081,
        -2699, -3085, -2694, -3089, -2690, -3093, -2685, -3097, -2680, -3102, -2675, -3106, -2671,
        -3110, -2666, -3114, -2661, -3118, -2656, -3122, -2652, -3126, -2647, -3130, -2642, -3134,
        -2637, -3138, -2632, -3142, -2628, -3146, -2623, -3150, -2618, -3154, -2613, -3158, -2608,
        -3162, -2603, -3166, -2598, -3170, -2594, -3174, -2589, -3178, -2584, -3182, -2579, -3186,
        -2574, -3190, -2569, -3194, -2564, -3198, -2559, -3202, -2555, -3206, -2550, -3210, -2545,
        -3214, -2540, -3217, -2535, -3221, -2530, -3225, -2525, -3229, -2520, -3233, -2515, -3237,
        -2510, -3241, -2505, -3244, -2500, -3248, -2495, -3252, -2490, -3256, -2485, -3260, -2480,
        -3264, -2475, -3267, -2470, -3271, -2465, -3275, -2460, -3279, -2455, -3282, -2450, -3286,
        -2445, -3290, -2440, -3294, -2435, -3297, -2430, -3301, -2425, -3305, -2420, -3309, -2415,
        -3312, -2410, -3316, -2405, -3320, -2399, -3323, -2394, -3327, -2389, -3331, -2384, -3334,
        -2379, -3338, -2374, -3342, -2369, -3345, -2364, -3349, -2359, -3352, -2353, -3356, -2348,
        -3360, -2343, -3363, -2338, -3367, -2333, -3370, -2328, -3374, -2322, -3378, -2317, -3381,
        -2312, -3385, -2307, -3388, -2302, -3392, -2296, -3395, -2291, -3399, -2286, -3402, -2281,
        -3406, -2276, -3409, -2270, -3413, -2265, -3416, -2260, -3420, -2255, -3423, -2249, -3426,
        -2244, -3430, -2239, -3433, -2234, -3437, -2228, -3440, -2223, -3444, -2218, -3447, -2213,
        -3450, -2207, -3454, -2202, -3457, -2197, -3461, -2191, -3464, -2186, -3467, -2181, -3471,
        -2175, -3474, -2170, -3477, -2165, -3481, -2159, -3484, -2154, -3487, -2149, -3490, -2143,
        -3494, -2138, -3497, -2133, -3500, -2127, -3504, -2122, -3507, -2117, -3510, -2111, -3513,
        -2106, -3516, -2100, -3520, -2095, -3523, -2090, -3526, -2084, -3529, -2079, -3532, -2073,
        -3536, -2068, -3539, -2062, -3542, -2057, -3545, -2052, -3548, -2046, -3551, -2041, -3555,
        -2035, -3558, -2030, -3561, -2024, -3564, -2019, -3567, -2013, -3570, -2008, -3573, -2002,
        -3576, -1997, -3579, -1992, -3582, -1986, -3585, -1981, -3588, -1975, -3591, -1970, -3594,
        -1964, -3597, -1958, -3600, -1953, -3603, -1947, -3606, -1942, -3609, -1936, -3612, -1931,
        -3615, -1925, -3618, -1920, -3621, -1914, -3624, -1909, -3627, -1903, -3630, -1898, -3633,
        -1892, -3636, -1886, -3639, -1881, -3642, -1875, -3644, -1870, -3647, -1864, -3650, -1858,
        -3653, -1853, -3656, -1847, -3659, -1842, -3661, -1836, -3664, -1830, -3667, -1825, -3670,
        -1819, -3673, -1813, -3675, -1808, -3678, -1802, -3681, -1797, -3684, -1791, -3686, -1785,
        -3689, -1780, -3692, -1774, -3695, -1768, -3697, -1763, -3700, -1757, -3703, -1751, -3705,
        -1746, -3708, -1740, -3711, -1734, -3713, -1729, -3716, -1723, -3719, -1717, -3721, -1711,
        -3724, -1706, -3727, -1700, -3729, -1694, -3732, -1689, -3734, -1683, -3737, -1677, -3739,
        -1671, -3742, -1666, -3745, -1660, -3747, -1654, -3750, -1648, -3752, -1643, -3755, -1637,
        -3757, -1631, -3760, -1625, -3762, -1620, -3765, -1614, -3767, -1608, -3770, -1602, -3772,
        -1596, -3775, -1591, -3777, -1585, -3779, -1579, -3782, -1573, -3784, -1567, -3787, -1562,
        -3789, -1556, -3791, -1550, -3794, -1544, -3796, -1538, -3798, -1533, -3801, -1527, -3803,
        -1521, -3805, -1515, -3808, -1509, -3810, -1503, -3812, -1498, -3815, -1492, -3817, -1486,
        -3819, -1480, -3822, -1474, -3824, -1468, -3826, -1462, -3828, -1457, -3831, -1451, -3833,
        -1445, -3835, -1439, -3837, -1433, -3839, -1427, -3842, -1421, -3844, -1415, -3846, -1409,
        -3848, -1404, -3850, -1398, -3852, -1392, -3854, -1386, -3857, -1380, -3859, -1374, -3861,
        -1368, -3863, -1362, -3865, -1356, -3867, -1350, -3869, -1344, -3871, -1338, -3873, -1332,
        -3875, -1327, -3877, -1321, -3879, -1315, -3881, -1309, -3883, -1303, -3885, -1297, -3887,
        -1291, -3889, -1285, -3891, -1279, -3893, -1273, -3895, -1267, -3897, -1261, -3899, -1255,
        -3901, -1249, -3903, -1243, -3905, -1237, -3907, -1231, -3909, -1225, -3910, -1219, -3912,
        -1213, -3914, -1207, -3916, -1201, -3918, -1195, -3920, -1189, -3921, -1183, -3923, -1177,
        -3925, -1171, -3927, -1165, -3929, -1159, -3930, -1153, -3932, -1147, -3934, -1141, -3936,
        -1135, -3937, -1129, -3939, -1123, -3941, -1117, -3943, -1111, -3944, -1105, -3946, -1099,
        -3948, -1092, -3949, -1086, -3951, -1080, -3953, -1074, -3954, -1068, -3956, -1062, -3958,
        -1056, -3959, -1050, -3961, -1044, -3962, -1038, -3964, -1032, -3965, -1026, -3967, -1020,
        -3969, -1014, -3970, -1007, -3972, -1001, -3973, -995, -3975, -989, -3976, -983, -3978,
        -977, -3979, -971, -3981, -965, -3982, -959, -3984, -953, -3985, -946, -3987, -940, -3988,
        -934, -3989, -928, -3991, -922, -3992, -916, -3994, -910, -3995, -904, -3996, -897, -3998,
        -891, -3999, -885, -4001, -879, -4002, -873, -4003, -867, -4005, -861, -4006, -854, -4007,
        -848, -4008, -842, -4010, -836, -4011, -830, -4012, -824, -4014, -818, -4015, -811, -4016,
        -805, -4017, -799, -4019, -793, -4020, -787, -4021, -781, -4022, -774, -4023, -768, -4024,
        -762, -4026, -756, -4027, -750, -4028, -744, -4029, -737, -4030, -731, -4031, -725, -4032,
        -719, -4034, -713, -4035, -706, -4036, -700, -4037, -694, -4038, -688, -4039, -682, -4040,
        -675, -4041, -669, -4042, -663, -4043, -657, -4044, -651, -4045, -644, -4046, -638, -4047,
        -632, -4048, -626, -4049, -620, -4050, -613, -4051, -607, -4052, -601, -4053, -595, -4053,
        -589, -4054, -582, -4055, -576, -4056, -570, -4057, -564, -4058, -557, -4059, -551, -4060,
        -545, -4060, -539, -4061, -533, -4062, -526, -4063, -520, -4064, -514, -4064, -508, -4065,
        -501, -4066, -495, -4067, -489, -4067, -483, -4068, -476, -4069, -470, -4070, -464, -4070,
        -458, -4071, -451, -4072, -445, -4072, -439, -4073, -433, -4074, -426, -4074, -420, -4075,
        -414, -4076, -408, -4076, -401, -4077, -395, -4077, -389, -4078, -383, -4079, -376, -4079,
        -370, -4080, -364, -4080, -358, -4081, -351, -4081, -345, -4082, -339, -4082, -333, -4083,
        -326, -4083, -320, -4084, -314, -4084, -308, -4085, -301, -4085, -295, -4086, -289, -4086,
        -283, -4087, -276, -4087, -270, -4088, -264, -4088, -257, -4088, -251, -4089, -245, -4089,
        -239, -4089, -232, -4090, -226, -4090, -220, -4090, -214, -4091, -207, -4091, -201, -4091,
        -195, -4092, -188, -4092, -182, -4092, -176, -4092, -170, -4093, -163, -4093, -157, -4093,
        -151, -4093, -144, -4094, -138, -4094, -132, -4094, -126, -4094, -119, -4094, -113, -4095,
        -107, -4095, -101, -4095, -94, -4095, -88, -4095, -82, -4095, -75, -4095, -69, -4096, -63,
        -4096, -57, -4096, -50, -4096, -44, -4096, -38, -4096, -31, -4096, -25, -4096, -19, -4096,
        -13, -4096, -6, -4096, 0, -4096, 6, -4096, 13, -4096, 19, -4096, 25, -4096, 31, -4096, 38,
        -4096, 44, -4096, 50, -4096, 57, -4096, 63, -4095, 69, -4095, 75, -4095, 82, -4095, 88,
        -4095, 94, -4095, 101, -4095, 107, -4094, 113, -4094, 119, -4094, 126, -4094, 132, -4094,
        138, -4093, 144, -4093, 151, -4093, 157, -4093, 163, -4092, 170, -4092, 176, -4092, 182,
        -4092, 188, -4091, 195, -4091, 201, -4091, 207, -4090, 214, -4090, 220, -4090, 226, -4089,
        232, -4089, 239, -4089, 245, -4088, 251, -4088, 257, -4088, 264, -4087, 270, -4087, 276,
        -4086, 283, -4086, 289, -4085, 295, -4085, 301, -4084, 308, -4084, 314, -4083, 320, -4083,
        326, -4082, 333, -4082, 339, -4081, 345, -4081, 351, -4080, 358, -4080, 364, -4079, 370,
        -4079, 376, -4078, 383, -4077, 389, -4077, 395, -4076, 401, -4076, 408, -4075, 414, -4074,
        420, -4074, 426, -4073, 433, -4072, 439, -4072, 445, -4071, 451, -4070, 458, -4070, 464,
        -4069, 470, -4068, 476, -4067, 483, -4067, 489, -4066, 495, -4065, 501, -4064, 508, -4064,
        514, -4063, 520, -4062, 526, -4061, 533, -4060, 539, -4060, 545, -4059, 551, -4058, 557,
        -4057, 564, -4056, 570, -4055, 576, -4054, 582, -4053, 589, -4053, 595, -4052, 601, -4051,
        607, -4050, 613, -4049, 620, -4048, 626, -4047, 632, -4046, 638, -4045, 644, -4044, 651,
        -4043, 657, -4042, 663, -4041, 669, -4040, 675, -4039, 682, -4038, 688, -4037, 694, -4036,
        700, -4035, 706, -4034, 713, -4032, 719, -4031, 725, -4030, 731, -4029, 737, -4028, 744,
        -4027, 750, -4026, 756, -4024, 762, -4023, 768, -4022, 774, -4021, 781, -4020, 787, -4019,
        793, -4017, 799, -4016, 805, -4015, 811, -4014, 818, -4012, 824, -4011, 830, -4010, 836,
        -4008, 842, -4007, 848, -4006, 854, -4005, 861, -4003, 867, -4002, 873, -4001, 879, -3999,
        885, -3998, 891, -3996, 897, -3995, 904, -3994, 910, -3992, 916, -3991, 922, -3989, 928,
        -3988, 934, -3987, 940, -3985, 946, -3984, 953, -3982, 959, -3981, 965, -3979, 971, -3978,
        977, -3976, 983, -3975, 989, -3973, 995, -3972, 1001, -3970, 1007, -3969, 1014, -3967,
        1020, -3965, 1026, -3964, 1032, -3962, 1038, -3961, 1044, -3959, 1050, -3958, 1056, -3956,
        1062, -3954, 1068, -3953, 1074, -3951, 1080, -3949, 1086, -3948, 1092, -3946, 1099, -3944,
        1105, -3943, 1111, -3941, 1117, -3939, 1123, -3937, 1129, -3936, 1135, -3934, 1141, -3932,
        1147, -3930, 1153, -3929, 1159, -3927, 1165, -3925, 1171, -3923, 1177, -3921, 1183, -3920,
        1189, -3918, 1195, -3916, 1201, -3914, 1207, -3912, 1213, -3910, 1219, -3909, 1225, -3907,
        1231, -3905, 1237, -3903, 1243, -3901, 1249, -3899, 1255, -3897, 1261, -3895, 1267, -3893,
        1273, -3891, 1279, -3889, 1285, -3887, 1291, -3885, 1297, -3883, 1303, -3881, 1309, -3879,
        1315, -3877, 1321, -3875, 1327, -3873, 1332, -3871, 1338, -3869, 1344, -3867, 1350, -3865,
        1356, -3863, 1362, -3861, 1368, -3859, 1374, -3857, 1380, -3854, 1386, -3852, 1392, -3850,
        1398, -3848, 1404, -3846, 1409, -3844, 1415, -3842, 1421, -3839, 1427, -3837, 1433, -3835,
        1439, -3833, 1445, -3831, 1451, -3828, 1457, -3826, 1462, -3824, 1468, -3822, 1474, -3819,
        1480, -3817, 1486, -3815, 1492, -3812, 1498, -3810, 1503, -3808, 1509, -3805, 1515, -3803,
        1521, -3801, 1527, -3798, 1533, -3796, 1538, -3794, 1544, -3791, 1550, -3789, 1556, -3787,
        1562, -3784, 1567, -3782, 1573, -3779, 1579, -3777, 1585, -3775, 1591, -3772, 1596, -3770,
        1602, -3767, 1608, -3765, 1614, -3762, 1620, -3760, 1625, -3757, 1631, -3755, 1637, -3752,
        1643, -3750, 1648, -3747, 1654, -3745, 1660, -3742, 1666, -3739, 1671, -3737, 1677, -3734,
        1683, -3732, 1689, -3729, 1694, -3727, 1700, -3724, 1706, -3721, 1711, -3719, 1717, -3716,
        1723, -3713, 1729, -3711, 1734, -3708, 1740, -3705, 1746, -3703, 1751, -3700, 1757, -3697,
        1763, -3695, 1768, -3692, 1774, -3689, 1780, -3686, 1785, -3684, 1791, -3681, 1797, -3678,
        1802, -3675, 1808, -3673, 1813, -3670, 1819, -3667, 1825, -3664, 1830, -3661, 1836, -3659,
        1842, -3656, 1847, -3653, 1853, -3650, 1858, -3647, 1864, -3644, 1870, -3642, 1875, -3639,
        1881, -3636, 1886, -3633, 1892, -3630, 1898, -3627, 1903, -3624, 1909, -3621, 1914, -3618,
        1920, -3615, 1925, -3612, 1931, -3609, 1936, -3606, 1942, -3603, 1947, -3600, 1953, -3597,
        1958, -3594, 1964, -3591, 1970, -3588, 1975, -3585, 1981, -3582, 1986, -3579, 1992, -3576,
        1997, -3573, 2002, -3570, 2008, -3567, 2013, -3564, 2019, -3561, 2024, -3558, 2030, -3555,
        2035, -3551, 2041, -3548, 2046, -3545, 2052, -3542, 2057, -3539, 2062, -3536, 2068, -3532,
        2073, -3529, 2079, -3526, 2084, -3523, 2090, -3520, 2095, -3516, 2100, -3513, 2106, -3510,
        2111, -3507, 2117, -3504, 2122, -3500, 2127, -3497, 2133, -3494, 2138, -3490, 2143, -3487,
        2149, -3484, 2154, -3481, 2159, -3477, 2165, -3474, 2170, -3471, 2175, -3467, 2181, -3464,
        2186, -3461, 2191, -3457, 2197, -3454, 2202, -3450, 2207, -3447, 2213, -3444, 2218, -3440,
        2223, -3437, 2228, -3433, 2234, -3430, 2239, -3426, 2244, -3423, 2249, -3420, 2255, -3416,
        2260, -3413, 2265, -3409, 2270, -3406, 2276, -3402, 2281, -3399, 2286, -3395, 2291, -3392,
        2296, -3388, 2302, -3385, 2307, -3381, 2312, -3378, 2317, -3374, 2322, -3370, 2328, -3367,
        2333, -3363, 2338, -3360, 2343, -3356, 2348, -3352, 2353, -3349, 2359, -3345, 2364, -3342,
        2369, -3338, 2374, -3334, 2379, -3331, 2384, -3327, 2389, -3323, 2394, -3320, 2399, -3316,
        2405, -3312, 2410, -3309, 2415, -3305, 2420, -3301, 2425, -3297, 2430, -3294, 2435, -3290,
        2440, -3286, 2445, -3282, 2450, -3279, 2455, -3275, 2460, -3271, 2465, -3267, 2470, -3264,
        2475, -3260, 2480, -3256, 2485, -3252, 2490, -3248, 2495, -3244, 2500, -3241, 2505, -3237,
        2510, -3233, 2515, -3229, 2520, -3225, 2525, -3221, 2530, -3217, 2535, -3214, 2540, -3210,
        2545, -3206, 2550, -3202, 2555, -3198, 2559, -3194, 2564, -3190, 2569, -3186, 2574, -3182,
        2579, -3178, 2584, -3174, 2589, -3170, 2594, -3166, 2598, -3162, 2603, -3158, 2608, -3154,
        2613, -3150, 2618, -3146, 2623, -3142, 2628, -3138, 2632, -3134, 2637, -3130, 2642, -3126,
        2647, -3122, 2652, -3118, 2656, -3114, 2661, -3110, 2666, -3106, 2671, -3102, 2675, -3097,
        2680, -3093, 2685, -3089, 2690, -3085, 2694, -3081, 2699, -3077, 2704, -3073, 2709, -3068,
        2713, -3064, 2718, -3060, 2723, -3056, 2727, -3052, 2732, -3048, 2737, -3043, 2741, -3039,
        2746, -3035, 2751, -3031, 2755, -3026, 2760, -3022, 2765, -3018, 2769, -3014, 2774, -3009,
        2779, -3005, 2783, -3001, 2788, -2997, 2792, -2992, 2797, -2988, 2802, -2984, 2806, -2979,
        2811, -2975, 2815, -2971, 2820, -2967, 2824, -2962, 2829, -2958, 2833, -2953, 2838, -2949,
        2843, -2945, 2847, -2940, 2852, -2936, 2856, -2932, 2861, -2927, 2865, -2923, 2870, -2918,
        2874, -2914, 2878, -2910, 2883, -2905, 2887, -2901, 2892, -2896, 2896, -2892, 2901, -2887,
        2905, -2883, 2910, -2878, 2914, -2874, 2918, -2870, 2923, -2865, 2927, -2861, 2932, -2856,
        2936, -2852, 2940, -2847, 2945, -2843, 2949, -2838, 2953, -2833, 2958, -2829, 2962, -2824,
        2967, -2820, 2971, -2815, 2975, -2811, 2979, -2806, 2984, -2802, 2988, -2797, 2992, -2792,
        2997, -2788, 3001, -2783, 3005, -2779, 3009, -2774, 3014, -2769, 3018, -2765, 3022, -2760,
        3026, -2755, 3031, -2751, 3035, -2746, 3039, -2741, 3043, -2737, 3048, -2732, 3052, -2727,
        3056, -2723, 3060, -2718, 3064, -2713, 3068, -2709, 3073, -2704, 3077, -2699, 3081, -2694,
        3085, -2690, 3089, -2685, 3093, -2680, 3097, -2675, 3102, -2671, 3106, -2666, 3110, -2661,
        3114, -2656, 3118, -2652, 3122, -2647, 3126, -2642, 3130, -2637, 3134, -2632, 3138, -2628,
        3142, -2623, 3146, -2618, 3150, -2613, 3154, -2608, 3158, -2603, 3162, -2598, 3166, -2594,
        3170, -2589, 3174, -2584, 3178, -2579, 3182, -2574, 3186, -2569, 3190, -2564, 3194, -2559,
        3198, -2555, 3202, -2550, 3206, -2545, 3210, -2540, 3214, -2535, 3217, -2530, 3221, -2525,
        3225, -2520, 3229, -2515, 3233, -2510, 3237, -2505, 3241, -2500, 3244, -2495, 3248, -2490,
        3252, -2485, 3256, -2480, 3260, -2475, 3264, -2470, 3267, -2465, 3271, -2460, 3275, -2455,
        3279, -2450, 3282, -2445, 3286, -2440, 3290, -2435, 3294, -2430, 3297, -2425, 3301, -2420,
        3305, -2415, 3309, -2410, 3312, -2405, 3316, -2399, 3320, -2394, 3323, -2389, 3327, -2384,
        3331, -2379, 3334, -2374, 3338, -2369, 3342, -2364, 3345, -2359, 3349, -2353, 3352, -2348,
        3356, -2343, 3360, -2338, 3363, -2333, 3367, -2328, 3370, -2322, 3374, -2317, 3378, -2312,
        3381, -2307, 3385, -2302, 3388, -2296, 3392, -2291, 3395, -2286, 3399, -2281, 3402, -2276,
        3406, -2270, 3409, -2265, 3413, -2260, 3416, -2255, 3420, -2249, 3423, -2244, 3426, -2239,
        3430, -2234, 3433, -2228, 3437, -2223, 3440, -2218, 3444, -2213, 3447, -2207, 3450, -2202,
        3454, -2197, 3457, -2191, 3461, -2186, 3464, -2181, 3467, -2175, 3471, -2170, 3474, -2165,
        3477, -2159, 3481, -2154, 3484, -2149, 3487, -2143, 3490, -2138, 3494, -2133, 3497, -2127,
        3500, -2122, 3504, -2117, 3507, -2111, 3510, -2106, 3513, -2100, 3516, -2095, 3520, -2090,
        3523, -2084, 3526, -2079, 3529, -2073, 3532, -2068, 3536, -2062, 3539, -2057, 3542, -2052,
        3545, -2046, 3548, -2041, 3551, -2035, 3555, -2030, 3558, -2024, 3561, -2019, 3564, -2013,
        3567, -2008, 3570, -2002, 3573, -1997, 3576, -1992, 3579, -1986, 3582, -1981, 3585, -1975,
        3588, -1970, 3591, -1964, 3594, -1958, 3597, -1953, 3600, -1947, 3603, -1942, 3606, -1936,
        3609, -1931, 3612, -1925, 3615, -1920, 3618, -1914, 3621, -1909, 3624, -1903, 3627, -1898,
        3630, -1892, 3633, -1886, 3636, -1881, 3639, -1875, 3642, -1870, 3644, -1864, 3647, -1858,
        3650, -1853, 3653, -1847, 3656, -1842, 3659, -1836, 3661, -1830, 3664, -1825, 3667, -1819,
        3670, -1813, 3673, -1808, 3675, -1802, 3678, -1797, 3681, -1791, 3684, -1785, 3686, -1780,
        3689, -1774, 3692, -1768, 3695, -1763, 3697, -1757, 3700, -1751, 3703, -1746, 3705, -1740,
        3708, -1734, 3711, -1729, 3713, -1723, 3716, -1717, 3719, -1711, 3721, -1706, 3724, -1700,
        3727, -1694, 3729, -1689, 3732, -1683, 3734, -1677, 3737, -1671, 3739, -1666, 3742, -1660,
        3745, -1654, 3747, -1648, 3750, -1643, 3752, -1637, 3755, -1631, 3757, -1625, 3760, -1620,
        3762, -1614, 3765, -1608, 3767, -1602, 3770, -1596, 3772, -1591, 3775, -1585, 3777, -1579,
        3779, -1573, 3782, -1567, 3784, -1562, 3787, -1556, 3789, -1550, 3791, -1544, 3794, -1538,
        3796, -1533, 3798, -1527, 3801, -1521, 3803, -1515, 3805, -1509, 3808, -1503, 3810, -1498,
        3812, -1492, 3815, -1486, 3817, -1480, 3819, -1474, 3822, -1468, 3824, -1462, 3826, -1457,
        3828, -1451, 3831, -1445, 3833, -1439, 3835, -1433, 3837, -1427, 3839, -1421, 3842, -1415,
        3844, -1409, 3846, -1404, 3848, -1398, 3850, -1392, 3852, -1386, 3854, -1380, 3857, -1374,
        3859, -1368, 3861, -1362, 3863, -1356, 3865, -1350, 3867, -1344, 3869, -1338, 3871, -1332,
        3873, -1327, 3875, -1321, 3877, -1315, 3879, -1309, 3881, -1303, 3883, -1297, 3885, -1291,
        3887, -1285, 3889, -1279, 3891, -1273, 3893, -1267, 3895, -1261, 3897, -1255, 3899, -1249,
        3901, -1243, 3903, -1237, 3905, -1231, 3907, -1225, 3909, -1219, 3910, -1213, 3912, -1207,
        3914, -1201, 3916, -1195, 3918, -1189, 3920, -1183, 3921, -1177, 3923, -1171, 3925, -1165,
        3927, -1159, 3929, -1153, 3930, -1147, 3932, -1141, 3934, -1135, 3936, -1129, 3937, -1123,
        3939, -1117, 3941, -1111, 3943, -1105, 3944, -1099, 3946, -1092, 3948, -1086, 3949, -1080,
        3951, -1074, 3953, -1068, 3954, -1062, 3956, -1056, 3958, -1050, 3959, -1044, 3961, -1038,
        3962, -1032, 3964, -1026, 3965, -1020, 3967, -1014, 3969, -1007, 3970, -1001, 3972, -995,
        3973, -989, 3975, -983, 3976, -977, 3978, -971, 3979, -965, 3981, -959, 3982, -953, 3984,
        -946, 3985, -940, 3987, -934, 3988, -928, 3989, -922, 3991, -916, 3992, -910, 3994, -904,
        3995, -897, 3996, -891, 3998, -885, 3999, -879, 4001, -873, 4002, -867, 4003, -861, 4005,
        -854, 4006, -848, 4007, -842, 4008, -836, 4010, -830, 4011, -824, 4012, -818, 4014, -811,
        4015, -805, 4016, -799, 4017, -793, 4019, -787, 4020, -781, 4021, -774, 4022, -768, 4023,
        -762, 4024, -756, 4026, -750, 4027, -744, 4028, -737, 4029, -731, 4030, -725, 4031, -719,
        4032, -713, 4034, -706, 4035, -700, 4036, -694, 4037, -688, 4038, -682, 4039, -675, 4040,
        -669, 4041, -663, 4042, -657, 4043, -651, 4044, -644, 4045, -638, 4046, -632, 4047, -626,
        4048, -620, 4049, -613, 4050, -607, 4051, -601, 4052, -595, 4053, -589, 4053, -582, 4054,
        -576, 4055, -570, 4056, -564, 4057, -557, 4058, -551, 4059, -545, 4060, -539, 4060, -533,
        4061, -526, 4062, -520, 4063, -514, 4064, -508, 4064, -501, 4065, -495, 4066, -489, 4067,
        -483, 4067, -476, 4068, -470, 4069, -464, 4070, -458, 4070, -451, 4071, -445, 4072, -439,
        4072, -433, 4073, -426, 4074, -420, 4074, -414, 4075, -408, 4076, -401, 4076, -395, 4077,
        -389, 4077, -383, 4078, -376, 4079, -370, 4079, -364, 4080, -358, 4080, -351, 4081, -345,
        4081, -339, 4082, -333, 4082, -326, 4083, -320, 4083, -314, 4084, -308, 4084, -301, 4085,
        -295, 4085, -289, 4086, -283, 4086, -276, 4087, -270, 4087, -264, 4088, -257, 4088, -251,
        4088, -245, 4089, -239, 4089, -232, 4089, -226, 4090, -220, 4090, -214, 4090, -207, 4091,
        -201, 4091, -195, 4091, -188, 4092, -182, 4092, -176, 4092, -170, 4092, -163, 4093, -157,
        4093, -151, 4093, -144, 4093, -138, 4094, -132, 4094, -126, 4094, -119, 4094, -113, 4094,
        -107, 4095, -101, 4095, -94, 4095, -88, 4095, -82, 4095, -75, 4095, -69, 4095, -63, 4096,
        -57, 4096, -50, 4096, -44, 4096, -38, 4096, -31, 4096, -25, 4096, -19, 4096, -13, 4096,
        -6, 4096          };

    // Token: 0x0400044C RID: 1100
    public static short[] DAT_69C90 = new short[]
    {  0, 1, 2, 2, 3, 3, 4, 5, 5, 6, 7, 7, 8, 9, 9,
        10, 10, 11, 12, 12, 13, 14, 14, 15, 16, 16,
        17, 17, 18, 19, 19, 20, 21, 21, 22, 23, 23,
        24, 24, 25, 26, 26, 27, 28, 28, 29, 30, 30,
        31, 31, 32, 33, 33, 34, 35, 35, 36, 36, 37,
        38, 38, 39, 40, 40, 41, 42, 42, 43, 43, 44,
        45, 45, 46, 47, 47, 48, 49, 49, 50, 50, 51,
        52, 52, 53, 54, 54, 55, 55, 56, 57, 57, 58,
        59, 59, 60, 61, 61, 62, 62, 63, 64, 64, 65,
        66, 66, 67, 67, 68, 69, 69, 70, 71, 71, 72,
        73, 73, 74, 74, 75, 76, 76, 77, 78, 78, 79,
        79, 80, 81, 81, 82, 83, 83, 84, 84, 85, 86,
        86, 87, 88, 88, 89, 89, 90, 91, 91, 92, 93,
        93, 94, 94, 95, 96, 96, 97, 98, 98, 99, 99,
        100, 101, 101, 102, 103, 103, 104, 104, 105,
        106, 106, 107, 107, 108, 109, 109, 110, 111,
        111, 112, 112, 113, 114, 114, 115, 116, 116,
        117, 117, 118, 119, 119, 120, 120, 121, 122,
        122, 123, 124, 124, 125, 125, 126, 127, 127,
        128, 128, 129, 130, 130, 131, 131, 132, 133,
        133, 134, 135, 135, 136, 136, 137, 138, 138,
        139, 139, 140, 141, 141, 142, 142, 143, 144,
        144, 145, 145, 146, 147, 147, 148, 148, 149,
        150, 150, 151, 152, 152, 153, 153, 154, 155,
        155, 156, 156, 157, 158, 158, 159, 159, 160,
        161, 161, 162, 162, 163, 164, 164, 165, 165,
        166, 166, 167, 168, 168, 169, 169, 170, 171,
        171, 172, 172, 173, 174, 174, 175, 175, 176,
        177, 177, 178, 178, 179, 180, 180, 181, 181,
        182, 182, 183, 184, 184, 185, 185, 186, 187,
        187, 188, 188, 189, 190, 190, 191, 191, 192,
        192, 193, 194, 194, 195, 195, 196, 197, 197,
        198, 198, 199, 199, 200, 201, 201, 202, 202,
        203, 203, 204, 205, 205, 206, 206, 207, 207,
        208, 209, 209, 210, 210, 211, 211, 212, 213,
        213, 214, 214, 215, 215, 216, 217, 217, 218,
        218, 219, 219, 220, 221, 221, 222, 222, 223,
        223, 224, 225, 225, 226, 226, 227, 227, 228,
        228, 229, 230, 230, 231, 231, 232, 232, 233,
        234, 234, 235, 235, 236, 236, 237, 237, 238,
        239, 239, 240, 240, 241, 241, 242, 242, 243,
        244, 244, 245, 245, 246, 246, 247, 247, 248,
        248, 249, 250, 250, 251, 251, 252, 252, 253,
        253, 254, 254, 255, 256, 256, 257, 257, 258,
        258, 259, 259, 260, 260, 261, 262, 262, 263,
        263, 264, 264, 265, 265, 266, 266, 267, 267,
        268, 269, 269, 270, 270, 271, 271, 272, 272,
        273, 273, 274, 274, 275, 275, 276, 276, 277,
        278, 278, 279, 279, 280, 280, 281, 281, 282,
        282, 283, 283, 284, 284, 285, 285, 286, 286,
        287, 288, 288, 289, 289, 290, 290, 291, 291,
        292, 292, 293, 293, 294, 294, 295, 295, 296,
        296, 297, 297, 298, 298, 299, 299, 300, 300,
        301, 301, 302, 302, 303, 303, 304, 304, 305,
        305, 306, 307, 307, 308, 308, 309, 309, 310,
        310, 311, 311, 312, 312, 313, 313, 314, 314,
        315, 315, 316, 316, 317, 317, 318, 318, 319,
        319, 320, 320, 321, 321, 322, 322, 322, 323,
        323, 324, 324, 325, 325, 326, 326, 327, 327,
        328, 328, 329, 329, 330, 330, 331, 331, 332,
        332, 333, 333, 334, 334, 335, 335, 336, 336,
        337, 337, 338, 338, 339, 339, 340, 340, 340,
        341, 341, 342, 342, 343, 343, 344, 344, 345,
        345, 346, 346, 347, 347, 348, 348, 349, 349,
        349, 350, 350, 351, 351, 352, 352, 353, 353,
        354, 354, 355, 355, 356, 356, 356, 357, 357,
        358, 358, 359, 359, 360, 360, 361, 361, 362,
        362, 362, 363, 363, 364, 364, 365, 365, 366,
        366, 367, 367, 368, 368, 368, 369, 369, 370,
        370, 371, 371, 372, 372, 372, 373, 373, 374,
        374, 375, 375, 376, 376, 377, 377, 377, 378,
        378, 379, 379, 380, 380, 381, 381, 381, 382,
        382, 383, 383, 384, 384, 385, 385, 385, 386,
        386, 387, 387, 388, 388, 388, 389, 389, 390,
        390, 391, 391, 391, 392, 392, 393, 393, 394,
        394, 395, 395, 395, 396, 396, 397, 397, 398,
        398, 398, 399, 399, 400, 400, 401, 401, 401,
        402, 402, 403, 403, 403, 404, 404, 405, 405,
        406, 406, 406, 407, 407, 408, 408, 409, 409,
        409, 410, 410, 411, 411, 411, 412, 412, 413,
        413, 413, 414, 414, 415, 415, 416, 416, 416,
        417, 417, 418, 418, 418, 419, 419, 420, 420,
        420, 421, 421, 422, 422, 422, 423, 423, 424,
        424, 425, 425, 425, 426, 426, 427, 427, 427,
        428, 428, 429, 429, 429, 430, 430, 431, 431,
        431, 432, 432, 432, 433, 433, 434, 434, 434,
        435, 435, 436, 436, 436, 437, 437, 438, 438,
        438, 439, 439, 440, 440, 440, 441, 441, 441,
        442, 442, 443, 443, 443, 444, 444, 445, 445,
        445, 446, 446, 446, 447, 447, 448, 448, 448,
        449, 449, 450, 450, 450, 451, 451, 451, 452,
        452, 453, 453, 453, 454, 454, 454, 455, 455,
        456, 456, 456, 457, 457, 457, 458, 458, 459,
        459, 459, 460, 460, 460, 461, 461, 461, 462,
        462, 463, 463, 463, 464, 464, 464, 465, 465,
        465, 466, 466, 467, 467, 467, 468, 468, 468,
        469, 469, 469, 470, 470, 471, 471, 471, 472,
        472, 472, 473, 473, 473, 474, 474, 474, 475,
        475, 476, 476, 476, 477, 477, 477, 478, 478,
        478, 479, 479, 479, 480, 480, 480, 481, 481,
        481, 482, 482, 483, 483, 483, 484, 484, 484,
        485, 485, 485, 486, 486, 486, 487, 487, 487,
        488, 488, 488, 489, 489, 489, 490, 490, 490,
        491, 491, 491, 492, 492, 492, 493, 493, 493,
        494, 494, 494, 495, 495, 495, 496, 496, 496,
        497, 497, 497, 498, 498, 498, 499, 499, 499,
        500, 500, 500, 501, 501, 501, 502, 502, 502,
        503, 503, 503, 504, 504, 504, 505, 505, 505,
        506, 506, 506, 507, 507, 507, 508, 508, 508,
        509, 509, 509, 510, 510, 510, 511, 511, 511,
        511, 512, 512
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
        return (int)(-Ratan2(m33.V10, m33.V11) << 16 >> 16);
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
            vector3Int2 = Utilities.VectorNormal(vector3Int2);
        }
        Coprocessor.rotationMatrix.rt11 = (short)vector3Int2.x;
        Coprocessor.rotationMatrix.rt12 = (short)(vector3Int2.x >> 16);
        Coprocessor.rotationMatrix.rt22 = (short)vector3Int2.y;
        Coprocessor.rotationMatrix.rt23 = (short)(vector3Int2.y >> 16);
        Coprocessor.rotationMatrix.rt33 = (short)vector3Int2.z;
        Coprocessor.accumulator.ir1 = (short)vector3Int.x;
        Coprocessor.accumulator.ir2 = (short)vector3Int.y;
        Coprocessor.accumulator.ir3 = (short)vector3Int.z;
        Coprocessor.ExecuteOP(12, false);
        return new Matrix3x3
        {
            V00 = (short)vector3Int2.x,
            V10 = (short)vector3Int2.y,
            V20 = (short)vector3Int2.z,
            V01 = (short)vector3Int.x,
            V11 = (short)vector3Int.y,
            V21 = (short)vector3Int.z,
            V02 = (short)Coprocessor.mathsAccumulator.mac1,
            V12 = (short)Coprocessor.mathsAccumulator.mac2,
            V22 = (short)Coprocessor.mathsAccumulator.mac3
        };
    }

    public static Matrix3x3 FUN_2A724(Vector3Int sv)
    {
        short num = (short)sv.x;
        short num2 = (short)sv.y;
        short num3 = (short)sv.z;
        Vector3Int vector3Int = default(Vector3Int);
        vector3Int.x = sv.z;
        if (vector3Int.x == 0)
        {
            if (sv.x == 0)
            {
                vector3Int.x = 4096;
                vector3Int.y = 0;
                vector3Int.z = 0;
                goto IL_8D;
            }
            vector3Int.x = sv.z;
        }
        vector3Int.y = 0;
        vector3Int.z = -sv.x;
        vector3Int = Utilities.VectorNormal(vector3Int);
    IL_8D:
        Coprocessor.rotationMatrix.rt11 = num;
        Coprocessor.rotationMatrix.rt12 = (short)(num >> 16);
        Coprocessor.rotationMatrix.rt22 = num2;
        Coprocessor.rotationMatrix.rt23 = (short)(num2 >> 16);
        Coprocessor.rotationMatrix.rt33 = num3;
        Coprocessor.accumulator.ir3 = (short)vector3Int.z;
        Coprocessor.accumulator.ir1 = (short)vector3Int.x;
        Coprocessor.accumulator.ir2 = (short)vector3Int.y;
        Coprocessor.ExecuteOP(12, false);
        return new Matrix3x3
        {
            V00 = (short)vector3Int.x,
            V10 = (short)vector3Int.y,
            V20 = (short)vector3Int.z,
            V02 = num,
            V12 = num2,
            V22 = num3,
            V01 = (short)Coprocessor.mathsAccumulator.mac1,
            V11 = (short)Coprocessor.mathsAccumulator.mac2,
            V21 = (short)Coprocessor.mathsAccumulator.mac3
        };
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
                    num = DAT_69C90[(y << 1) / 2];
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
                num = DAT_69C90[(y << 1) / 2];
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
                num = 1024 - DAT_69C90[(y << 1) / 2];
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
            num = 1024 - DAT_69C90[(y << 1) / 2];
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

    public static Vector3Int ApplyMatrixSV(Matrix3x3 m, Vector3Int v0)
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
        Coprocessor.vector0.vx0 = (short)v0.x;
        Coprocessor.vector0.vy0 = (short)v0.y;
        Coprocessor.vector0.vz0 = (short)v0.z;
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
            num = DAT_65C90[(r & 0xFFF) * 2];
            num2 = DAT_65C90[(r & 0xFFF) * 2 + 1];
        }
        else
        {
            r = -r;
            num = -DAT_65C90[(r & 0xFFF) * 2];
            num2 = DAT_65C90[(r & 0xFFF) * 2 + 1];
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
            num = -DAT_65C90[(r & 0xFFF) * 2];
            num2 = DAT_65C90[(r & 0xFFF) * 2 + 1];
        }
        else
        {
            r = -r;
            num = DAT_65C90[(r & 0xFFF) * 2];
            num2 = DAT_65C90[(r & 0xFFF) * 2 + 1];
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
        Matrix3x3 m = default(Matrix3x3);
        uint uVar1;
        uint uVar2;
        uint uVar3;
        int iVar4;
        int iVar5;
        int iVar6;
        int iVar7;
        int iVar8;
        int iVar9;
        uint uVar10;
        int iVar11;
        uint uVar12;
        int iVar13;
        uint uVar14;
        int iVar15;
        int iVar16;
        int iVar17;
        int iVar18;
        int iVar19;
        short sVar18;
        short sVar19;
        short sVar20;
        short sVar21;
        short sVar22;
        short sVar23;

        iVar16 = r.y << 0x10 | (ushort)r.x;
        uVar14 = (uint)(r.z >> 0x1f);
        uVar12 = (uint)(iVar16 >> 0x1f);
        uVar10 = (uint)((int)(short)iVar16 >> 0x1f);
        sVar20 = DAT_65C90[(((uint)r.z + uVar14 ^ uVar14) & 0xfff) * 2];
        sVar21 = DAT_65C90[(((uint)r.z + uVar14 ^ uVar14) & 0xfff) * 2 + 1];
        uVar1 = (uint)(sVar21 << 0x10 | (ushort)sVar20) * 0x10000 + uVar14 ^ uVar14;
        sVar22 = DAT_65C90[(((uint)(iVar16 >> 0x10) + uVar12 ^ uVar12) & 0xfff) * 2];
        sVar23 = DAT_65C90[(((uint)(iVar16 >> 0x10) + uVar12 ^ uVar12) & 0xfff) * 2 + 1];
        uVar2 = (uint)(sVar23 << 0x10 | (ushort)sVar22) * 0x10000 + uVar12 ^ uVar12;
        sVar18 = DAT_65C90[(((uint)(int)(short)iVar16 + uVar10 ^ uVar10) & 0xfff) * 2];
        sVar19 = DAT_65C90[(((uint)(int)(short)iVar16 + uVar10 ^ uVar10) & 0xfff) * 2 + 1];
        uVar3 = (uint)(sVar19 << 0x10 | (ushort)sVar18) * 0x10000 + uVar10 ^ uVar10;
        iVar8 = (int)((uint)((sVar23 << 0x10 | (ushort)sVar22) >> 0x10) << 0x10 | uVar2 >> 0x10) >> 0x10;
        Coprocessor.accumulator.ir0 = (short)iVar8;
        iVar7 = (int)uVar3 >> 0x10;
        Coprocessor.accumulator.ir1 = (short)iVar7;
        iVar5 = (int)uVar1 >> 0x10;
        Coprocessor.accumulator.ir2 = (short)iVar5;
        iVar4 = (int)((uint)((sVar21 << 0x10 | (ushort)sVar20) >> 0x10) << 0x10 | uVar1 >> 0x10) >> 0x10;
        Coprocessor.accumulator.ir3 = (short)iVar4;
        Coprocessor.ExecuteGPF(12, false);
        iVar16 = (int)((uint)((sVar19 << 0x10 | (ushort)sVar18) >> 0x10) << 0x10 | uVar3 >> 0x10) >> 0x10;
        iVar9 = Coprocessor.accumulator.ir1;
        iVar11 = Coprocessor.accumulator.ir2;
        iVar13 = Coprocessor.accumulator.ir3;
        iVar19 = (int)uVar2 >> 0x10;
        Coprocessor.accumulator.ir0 = (short)iVar19;
        Coprocessor.accumulator.ir1 = (short)iVar7;
        Coprocessor.accumulator.ir2 = (short)iVar5;
        Coprocessor.accumulator.ir3 = (short)iVar4;
        Coprocessor.ExecuteGPF(12, false);
        m.V22 = (short)(iVar16 * iVar8 >> 12);
        iVar15 = Coprocessor.accumulator.ir1;
        iVar17 = Coprocessor.accumulator.ir2;
        iVar18 = Coprocessor.accumulator.ir3;
        Coprocessor.accumulator.ir0 = (short)iVar4;
        Coprocessor.accumulator.ir1 = (short)iVar16;
        Coprocessor.accumulator.ir2 = (short)iVar15;
        Coprocessor.accumulator.ir3 = (short)iVar9;
        Coprocessor.ExecuteGPF(12, false);
        uVar1 = (uint)(int)Coprocessor.accumulator.ir1;
        iVar8 = Coprocessor.accumulator.ir2;
        iVar6 = Coprocessor.accumulator.ir3;
        Coprocessor.accumulator.ir0 = (short)iVar5;
        Coprocessor.accumulator.ir1 = (short)iVar16;
        Coprocessor.accumulator.ir2 = (short)iVar15;
        Coprocessor.accumulator.ir3 = (short)iVar9;
        Coprocessor.ExecuteGPF(12, false);
        m.V11 = (short)uVar1;
        m.V12 = (short)-iVar7;
        iVar4 = Coprocessor.accumulator.ir1;
        iVar5 = Coprocessor.accumulator.ir2;
        iVar7 = Coprocessor.accumulator.ir3;
        m.V00 = (short)(iVar13 + iVar5);
        m.V01 = (short)(iVar8 - iVar11);
        m.V02 = (short)(iVar16 * iVar19 >> 12);
        m.V10 = (short)iVar4;
        m.V20 = (short)(iVar7 - iVar18);
        m.V21 = (short)(iVar6 + iVar17);
        return m;
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
#if UNITY_EDITOR
        AssetDatabase.CreateAsset(obj, filename);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
#endif
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
    // Token: 0x17000017 RID: 23
    // (get) Token: 0x06000AAC RID: 2732 RVA: 0x0000AC88 File Offset: 0x00008E88
    // (set) Token: 0x06000AAD RID: 2733 RVA: 0x0000AC90 File Offset: 0x00008E90
    public int Limit { get; set; }

    // Token: 0x06000AAE RID: 2734 RVA: 0x0007E438 File Offset: 0x0007C638
    public void Enqueue(T obj)
    {
        this.q.Enqueue(obj);
        object obj2 = this.lockObject;
        lock (obj2)
        {
            T t;
            while (this.q.Count > this.Limit && this.q.TryDequeue(out t))
            {
            }
        }
    }

    // Token: 0x06000AAF RID: 2735 RVA: 0x0007E4A0 File Offset: 0x0007C6A0
    public T Dequeue()
    {
        T t;
        this.q.TryDequeue(out t);
        return t;
    }

    // Token: 0x06000AB0 RID: 2736 RVA: 0x0007E4BC File Offset: 0x0007C6BC
    public T Peek()
    {
        T t;
        this.q.TryPeek(out t);
        return t;
    }

    // Token: 0x06000AB1 RID: 2737 RVA: 0x0000AC99 File Offset: 0x00008E99
    public T PeekAt(int index)
    {
        return this.q.ElementAt(index);
    }

    // Token: 0x040006BE RID: 1726
    private ConcurrentQueue<T> q = new ConcurrentQueue<T>();

    // Token: 0x040006BF RID: 1727
    private object lockObject = new object();
}

public class BufferedBinaryReader : IDisposable
{
    public long Position { get { return bufferOffset; } }
    public long Length { get { return bufferSize; } }

    private readonly Stream stream;
    private byte[] buffer;
    private int bufferSize;
    private int bufferOffset;
    private int numBufferedBytes;

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

    public int NumBytesAvailable { get { return Math.Max(0, numBufferedBytes - bufferOffset); } }

    public bool FillBuffer()
    {
        var numBytesUnread = bufferSize - bufferOffset;
        var numBytesToRead = bufferSize - numBytesUnread;
        bufferOffset = 0;
        numBufferedBytes = numBytesUnread;
        if (numBytesUnread > 0)
        {
            Buffer.BlockCopy(buffer, numBytesToRead, buffer, 0, numBytesUnread);
        }
        while (numBytesToRead > 0)
        {
            var numBytesRead = stream.Read(buffer, numBytesUnread, numBytesToRead);
            if (numBytesRead == 0)
            {
                return false;
            }
            numBufferedBytes += numBytesRead;
            numBytesToRead -= numBytesRead;
            numBytesUnread += numBytesRead;
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

    public byte ReadByte()
    {
        byte val = (byte)(int)buffer[bufferOffset];
        bufferOffset++;
        return val;
    }

    public byte ReadByte(int offset)
    {
        byte val = (byte)(int)buffer[bufferOffset + offset];
        return val;
    }

    public sbyte ReadSByte()
    {
        sbyte val = (sbyte)(int)buffer[bufferOffset];
        bufferOffset++;
        return val;
    }

    public sbyte ReadSByte(int offset)
    {
        sbyte val = (sbyte)(int)buffer[bufferOffset + offset];
        return val;
    }

    public char ReadChar()
    {
        char val = (char)buffer[bufferOffset];
        bufferOffset++;
        return val;
    }

    public bool ReadBool()
    {
        bool val = buffer[bufferOffset] == 1;
        bufferOffset++;
        return val;
    }

    public byte[] ReadBytes(int length)
    {
        byte[] bytes = new byte[length];

        for (int i = 0; i < length; i++)
            bytes[i] = ReadByte();

        return bytes;
    }

    public short ReadInt16()
    {
        var val = (short)((int)buffer[bufferOffset] | (int)buffer[bufferOffset + 1] << 8);
        bufferOffset += 2;
        return val;
    }

    public short ReadInt16(int offset)
    {
        var val = (short)((int)buffer[bufferOffset + offset] | (int)buffer[bufferOffset + offset + 1] << 8);
        return val;
    }

    public ushort ReadUInt16()
    {
        var val = (ushort)((int)buffer[bufferOffset] | (int)buffer[bufferOffset + 1] << 8);
        bufferOffset += 2;
        return val;
    }

    public ushort ReadUInt16(int offset)
    {
        var val = (ushort)((int)buffer[bufferOffset + offset] | (int)buffer[bufferOffset + offset + 1] << 8);
        return val;
    }

    public ushort[] ReadUInt16Array(int length)
    {
        ushort[] ushorts = new ushort[length];

        for (int i = 0; i < length; i++)
            ushorts[i] = ReadUInt16();

        return ushorts;
    }

    public int ReadInt32()
    {
        var val = (int)((int)buffer[bufferOffset] | (int)buffer[bufferOffset + 1] << 8 |
                        (int)buffer[bufferOffset + 2] << 16 | (int)buffer[bufferOffset + 3] << 24);
        bufferOffset += 4;
        return val;
    }

    public int ReadInt32(int offset)
    {
        var val = (int)((int)buffer[bufferOffset + offset] | (int)buffer[bufferOffset + offset + 1] << 8 |
                        (int)buffer[bufferOffset + offset + 2] << 16 | (int)buffer[bufferOffset + offset + 3] << 24);
        return val;
    }

    public uint ReadUInt32()
    {
        var val = (uint)((int)buffer[bufferOffset] | (int)buffer[bufferOffset + 1] << 8 |
                        (int)buffer[bufferOffset + 2] << 16 | (int)buffer[bufferOffset + 3] << 24);
        bufferOffset += 4;
        return val;
    }

    public uint ReadUInt32(int offset)
    {
        var val = (uint)((int)buffer[bufferOffset + offset] | (int)buffer[bufferOffset + offset + 1] << 8 |
                        (int)buffer[bufferOffset + offset + 2] << 16 | (int)buffer[bufferOffset + offset + 3] << 24);
        return val;
    }

    public uint[] ReadUInt32Array(int length)
    {
        uint[] uints = new uint[length];

        for (int i = 0; i < length; i++)
            uints[i] = ReadUInt32();

        return uints;
    }

    public void ReadUInt32Array(uint[] array)
    {
        for (int i = 0; i < array.Length; i++)
            array[i] = ReadUInt32();
    }

    public Vector3Int ReadSVector()
    {
        var val = new Vector3Int(ReadInt16(), ReadInt16(), ReadInt16());
        return val;
    }

    public Vector2Int ReadSVector2()
    {
        var val = new Vector2Int(ReadInt16(), ReadInt16());
        return val;
    }

    public Vector3Int ReadSVector(int offset)
    {
        var val = new Vector3Int(ReadInt16(offset), ReadInt16(offset + 2), ReadInt16(offset + 4));
        return val;
    }

    public Vector2Int ReadSVector2(int offset)
    {
        var val = new Vector2Int(ReadInt16(offset), ReadInt16(offset + 2));
        return val;
    }

    public string ReadString()
    {
        int index = 0;
        List<char> chars = new List<char>();

        do
        {
            chars.Add(ReadChar());
        } while (chars[index++] != 0);

        chars.RemoveAt(chars.Count - 1);
        return new string(chars.ToArray());
    }

    public void Write(byte value)
    {
        buffer[bufferOffset] = value;
        bufferOffset++;
    }

    public void Write(byte[] array)
    {
        for (int i = 0; i < array.Length; i++)
            buffer[bufferOffset++] = array[i];
    }

    public void Write(sbyte value)
    {
        buffer[bufferOffset] = (byte)value;
        bufferOffset++;
    }

    public void Write(char value)
    {
        buffer[bufferOffset] = (byte)value;
        bufferOffset++;
    }

    public void Write(bool value)
    {
        buffer[bufferOffset] = (byte)(value == true ? 1 : 0);
        bufferOffset++;
    }

    public void Write(int offset, byte value)
    {
        buffer[bufferOffset + offset] = value;
    }

    public void Write(short value)
    {
        buffer[bufferOffset] = (byte)value;
        buffer[bufferOffset + 1] = (byte)(value >> 8);
        bufferOffset += 2;
    }

    public void Write(ushort value)
    {
        buffer[bufferOffset] = (byte)value;
        buffer[bufferOffset + 1] = (byte)(value >> 8);
        bufferOffset += 2;
    }

    public void Write(ushort[] array)
    {
        for (int i = 0; i < array.Length; i++)
            Write(array[i]);
    }

    public void Write(int offset, ushort value)
    {
        buffer[bufferOffset + offset] = (byte)value;
        buffer[bufferOffset + offset + 1] = (byte)(value >> 8);
    }

    public void Write(int value)
    {
        buffer[bufferOffset] = (byte)value;
        buffer[bufferOffset + 1] = (byte)(value >> 8);
        buffer[bufferOffset + 2] = (byte)(value >> 0x10);
        buffer[bufferOffset + 3] = (byte)(value >> 0x18);
        bufferOffset += 4;
    }

    public void Write(uint value)
    {
        buffer[bufferOffset] = (byte)value;
        buffer[bufferOffset + 1] = (byte)(value >> 8);
        buffer[bufferOffset + 2] = (byte)(value >> 0x10);
        buffer[bufferOffset + 3] = (byte)(value >> 0x18);
        bufferOffset += 4;
    }

    public void Write(uint[] array)
    {
        for (int i = 0; i < array.Length; i++)
            Write(array[i]);
    }

    public void Write(string value)
    {
        for (int i = 0; i < value.Length; i++)
            Write(value[i]);
    }

    public void Dispose()
    {
        if (stream != null)
            stream.Close();
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
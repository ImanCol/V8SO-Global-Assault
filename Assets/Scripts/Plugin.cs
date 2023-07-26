using System;
using System.Collections.Generic;
using Unity.Burst;
using UnityEngine;
using Rewired;
using System.Net;

namespace V2UnityDiscordIntercept
{
    //[BepInPlugin("c1b6540e-a6ed-4f10-89b3-8e715ee70a78", "V2Unity Discord Intercept", "0.0.7-alpha")]
    [BurstCompile]
    public class Plugin : MonoBehaviour//: BaseUnityPlugin
    {
        public static Plugin instance;
        public const string AppIdentifier = "V8GO-23";

        public static VigServer Server { get; set; }
        public static VigClient Client { get; set; }

        public static bool ShowConnectionWindow { get; set; }
        private Rect connectionWindowRect = new Rect(100, 100, 300, 180);
        public static string ipAddress = "localhost";
        public static int Port { get; set; } = 45454;
        public static string Username = "Player";

        public static bool LogErrors { get; set; } = true;
        public static bool ShowErrorWindow { get; set; }

        public static bool saveLogger = false;

        private float secondsToShowWindow = -1;
        private Rect errorWindowRect = new Rect(200, 200, 800, 400);
        private Vector2 errorWindowScrollPos = Vector2.zero;

        private readonly IList<Exception> errors = new List<Exception>();

        public Player player;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                player = ReInput.players.GetPlayer(0);
            }
            //var harmony = new Harmony("c1b6540e-a6ed-4f10-89b3-8e715ee70a78");
            //harmony.PatchAll();
        }

        private void OnGUI()
        {
            //if (ShowConnectionWindow)
            //    connectionWindowRect = GUILayout.Window(1, connectionWindowRect, ConnectionWindow, "Network Connection");

            if (ShowErrorWindow)
                errorWindowRect = GUILayout.Window(2, errorWindowRect, ErrorWindow, "Errors");

        }
        public void ConnectLobby()
        {
            GameManager.instance.online = true;
            Client = new VigClient();
            Client.ConnectToLobby(ipAddress, Port);
        }
        private void ConnectionWindow(int windowId)
        {
            if (Client == null)
            {
                GUILayout.Label("Username");
                Username = GUILayout.TextField(Username);

                GUILayout.Label("IP Address");
                ipAddress = GUILayout.TextField(ipAddress);

                GUILayout.Label("Port");
                if (int.TryParse(GUILayout.TextField(Port.ToString()), out int newPort))
                {
                    Port = newPort;
                }

                using (new GUILayout.HorizontalScope())
                {
                    if (GUILayout.Button("Close"))
                    {
                        ShowConnectionWindow = false;
                    }

                    GUILayout.FlexibleSpace();
                    if (GUILayout.Button("Connect"))
                    {
                        GameManager.instance.online = true;
                        Client = new VigClient();
                        #if DEBUG
                        Client.ConnectToLobby(ipAddress, Port);
                        #endif
                    }
                }
            }
            else
            {
                GUILayout.Label("Connecting...");
            }

            GUI.DragWindow();
        }

        private void ErrorWindow(int windowId)
        {
            GUILayout.Box("Press F2 to show/hide this window.");

            errorWindowScrollPos = GUILayout.BeginScrollView(errorWindowScrollPos, "box");
            foreach (var error in errors)
            {
                GUILayout.Label(error.ToString(), "box");
            }
            GUILayout.EndScrollView();

            GUI.DragWindow();
        }


        public void Start()
        {
            string ipGlobal = GetPublicIPAddress();
            Debug.Log("IP Global: " + ipGlobal);
        }
        public void Update()
        {
            try
            {
                //Debug.LogWarning("Plugin Client Update..." + Client);
                //Debug.LogWarning("Server Client Update..." + Server);
                if (Client != null)
                {
                    //Debug.Log("Plugin Client Update..." + Client);
                    Client.Update();
                }

                if (Server != null)
                {
                    //Debug.Log("Server Client Update..." + Server);
                    Server.Update();
                }
            }
            catch (Exception e)
            {
                Logger.Log(e.ToString());
                errors.Add(e);

                //string scriptName = "Plugin.cs";
                //int lineNumber = 123;
                //string errorMessage = string.Format("<color=blue><b>{0}:{1}</b></color>: Error en el script", scriptName, lineNumber);
                //Debug.LogError(errorMessage);

#if DEBUG
                //secondsToShowWindow = 3;
                //ShowErrorWindow = true;
#endif
            }

            if (secondsToShowWindow > 0 && ShowErrorWindow)
            {
                secondsToShowWindow -= Time.deltaTime;
                if (secondsToShowWindow <= 0)
                    ShowErrorWindow = false;
            }

            if (player.GetButtonDown("F2"))
            {
                secondsToShowWindow = -1;
                ShowErrorWindow = !ShowErrorWindow;
            }
            //if (Input.GetKeyDown(KeyCode.F2))
            //{
            //    secondsToShowWindow = -1;
            //    ShowErrorWindow = !ShowErrorWindow;
            //}
        }

        public void LateUpdate()
        {
            if (Client != null)
            {
                Client.LateUpdate();
            }

            if (Server != null)
            {
                Server.LateUpdate();
            }
        }


        public static string GetPublicIPAddress()
        {
            string ipAddress = string.Empty;
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    ipAddress = webClient.DownloadString("https://api.ipify.org");
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que pueda ocurrir al obtener la dirección IP pública
                Console.WriteLine("Error al obtener la dirección IP pública: " + ex.Message);
            }

            return ipAddress;
        }

    }
}
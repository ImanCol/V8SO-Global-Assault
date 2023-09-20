using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LoadMap
{
    public class SceneLoader : MonoBehaviour
    {

        public static SceneLoader instance;

        [SerializeField]
        public Canvas canvasLoadScene;
        public static Canvas staticCanvasLoadScene;

        [SerializeField]
        public List<Sprite> Map;
        public static List<Sprite> staticMap;

        [SerializeField]
        public RawImage setMap;
        public static RawImage staticSetMap;

        [SerializeField]
        public TextMeshProUGUI mapDescription;
        public static TextMeshProUGUI staticMapDescription;

        [SerializeField]
        public TextMeshProUGUI loadingStatus;
        public static TextMeshProUGUI staticLoadingStatus;

        private readonly float loadingProgress = 0f;

        public static Task Destroy()
        {
            UnityEngine.Object.DontDestroyOnLoad(instance.gameObject);
            return Task.CompletedTask;
        }

        [System.Obsolete]
        public static Task GetMap(int sceneIndex)
        {
            Debug.Log("Obteniendo...");
            //canvasLoadScene.gameObject.SetActive(false);
            //foreach (Scene item in SceneManager.GetAllScenes())
            //{
            //    if (item.buildIndex >= 1 && item.buildIndex < 19)
            //    {
            //        setMap.texture = Map[item.buildIndex - 1].texture;
            //        Debug.Log("Scene: " + item.buildIndex);
            //        switch (item.buildIndex)
            //        {
            //            case 1:
            //                mapDescription.text = "";
            //                break;
            //            default:
            //                mapDescription.text = "";
            //                break;
            //
            //        }
            //    }
            //}
            staticSetMap.texture = staticMap[sceneIndex - 1].texture;

            //Descripcion Mapa
            switch (sceneIndex)
            {
                case 1:
                    staticMapDescription.text = "";
                    break;
                default:
                    staticMapDescription.text = "";
                    break;
            }
            return Task.CompletedTask;
        }

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
                canvasLoadScene = this.gameObject.GetComponent<Canvas>();
                staticCanvasLoadScene = canvasLoadScene;
                staticMap = Map;
                staticSetMap = setMap;
                staticMapDescription = mapDescription;
                staticLoadingStatus = loadingStatus;
                staticLoadingStatus.text = "";
                staticMapDescription.text = "";
            }
        }

        private void Start()
        {
            //Debug.Log("Get Scene: " + SceneManager.sceneCount.ToString() + " - " + SceneManager.GetActiveScene().buildIndex);
        }

        public static Task SetLoadingStatus(bool isHost)
        {
            if (GameManager.instance)
            {
                if (isHost || !GameManager.instance.online)
                {
                    staticLoadingStatus.text = "Press Space | (X) to Continue...";
                }
                else { staticLoadingStatus.text = "Waiting Host..."; }
            }
            return Task.CompletedTask;

        }

        //public IEnumerator LoadScene(int map)
        //{
        //    AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(map);
        //    asyncLoad.allowSceneActivation = false;
        //
        //    while (!asyncLoad.isDone)
        //    {
        //        loadingProgress = asyncLoad.progress;
        //
        //        // Si la carga está completa (progreso igual a 0.9), permitir la activación de la escena
        //        if (asyncLoad.progress >= 0.9f)
        //        {
        //            asyncLoad.allowSceneActivation = true;
        //        }
        //
        //        yield return null;
        //    }
        //}

    }
}
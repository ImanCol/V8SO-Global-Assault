using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public List<Sprite> Map;
    public RawImage setMap;
    public TextMeshProUGUI mapDescription;
    public TextMeshProUGUI loadingStatus;

    private float loadingProgress = 0f;

    private Task map2()
    {
        foreach (Scene item in SceneManager.GetAllScenes())
        {
            if (item.buildIndex >= 1 && item.buildIndex < 19)
            {
                setMap.texture = Map[item.buildIndex - 1].texture;
                Debug.Log("Scene: " + item.buildIndex);
                switch (item.buildIndex)
                {
                    case 1:
                        mapDescription.text = "";
                        break;
                    default:
                        mapDescription.text = "";
                        break;

                }
            }
        }
        return Task.CompletedTask;

    }

    private void Start()
    {
        map2();
        if (GameManager.instance)
        {
            if (GameManager.instance.isHost)
            {
                loadingStatus.text = "Press BackSpace to Start";
            }
            else { loadingStatus.text = "Waiting Host..."; }
        }
        //Debug.Log("Get Scene: " + SceneManager.sceneCount.ToString() + " - " + SceneManager.GetActiveScene().buildIndex);

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


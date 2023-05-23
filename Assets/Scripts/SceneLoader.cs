using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private float loadingProgress = 0f;
    public IEnumerator LoadScene(int map)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(map);
        asyncLoad.allowSceneActivation = false;

        while (!asyncLoad.isDone)
        {
            loadingProgress = asyncLoad.progress;

            // Si la carga está completa (progreso igual a 0.9), permitir la activación de la escena
            if (asyncLoad.progress >= 0.9f)
            {
                asyncLoad.allowSceneActivation = true;
            }

            yield return null;
        }
    }

}


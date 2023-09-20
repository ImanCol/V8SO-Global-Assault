using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePreloader : MonoBehaviour
{
    public string mainSceneName; // Nombre de la escena principal que deseas cargar después de precargar las demás escenas
    private static bool scenesLoaded = false; // Indicador de que las escenas ya han sido precargadas
    private static ScenePreloader instance; // Instancia única del ScenePreloader

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Evita que el objeto se destruya al cargar una nueva escena
        }
        else
        {
            Destroy(gameObject); // Si ya hay una instancia, destruye este objeto para mantener una única instancia del ScenePreloader
            return;
        }
    }

    private IEnumerator Start()
    {
        if (!scenesLoaded)
        {
            // Cargando todas las escenas en el Build Settings de manera asíncrona
            for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
            {
                string sceneName = SceneUtility.GetScenePathByBuildIndex(i);
                int lastSlash = sceneName.LastIndexOf('/');
                sceneName = sceneName.Substring(lastSlash + 1, sceneName.LastIndexOf('.') - lastSlash - 1);

                if (sceneName != mainSceneName)
                {
                    yield return StartCoroutine(LoadSceneAsync(sceneName));
                }
            }

            scenesLoaded = true; // Marcamos que las escenas han sido precargadas
        }

        // Cargando la escena principal después de cargar todas las demás escenas
        yield return StartCoroutine(LoadSceneAsync(mainSceneName));

        // Volver a la escena principal (escena 0)
        SceneManager.LoadScene(0);
    }

    private IEnumerator LoadSceneAsync(string sceneName)
    {
        var asyncLoad = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        asyncLoad.allowSceneActivation = false;

        while (!asyncLoad.isDone)
        {
            // Puedes agregar aquí una barra de carga o realizar otras operaciones mientras las escenas se cargan
            // asyncLoad.progress te da el progreso de carga (0.0 a 0.9), pero no activaremos la escena hasta que esté completamente cargada
            if (asyncLoad.progress >= 0.9f)
            {
                asyncLoad.allowSceneActivation = true; // Activar la escena cuando esté completamente cargada
            }
            yield return null;
        }
    }
}

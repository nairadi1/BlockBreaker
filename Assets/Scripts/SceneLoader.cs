using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings > currentSceneIndex + 1 ? currentSceneIndex + 1 : 0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

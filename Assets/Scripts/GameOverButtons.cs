using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButtons : MonoBehaviour
{
    public string levelToLoad = "LevelOne";
    public void ReloadGame()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

using UnityEngine.SceneManagement;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NewLevelTrigger : MonoBehaviour
{
    public string LevelToLoad = "NewScene";

    public void NextLevel()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("I have found player");
            SceneManager.LoadScene(LevelToLoad);
        }
    }
}

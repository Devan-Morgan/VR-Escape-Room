using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    // This method should be called when the button is clicked
    public void ReloadCurrentScene()
    {
        // Get the currently active scene and reload it
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}
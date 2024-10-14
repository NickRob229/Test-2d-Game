using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneQuit : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void Exit()
    {
        // If we are in the editor
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        // If we are in a standalone build
        #else
           Application.Quit();
        #endif
    }
}

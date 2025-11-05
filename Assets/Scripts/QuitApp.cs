using UnityEngine;

public class QuitApp : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Quitting application...");


    #if UNITY_EDITOR
            // If running in the Editor, stop play mode instead of quitting
            UnityEditor.EditorApplication.isPlaying = false;
    #else
            // If running as a built app, quit normally
            Application.Quit();
    #endif
        }
    }
}

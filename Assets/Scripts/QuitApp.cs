using UnityEngine;

public class QuitApp : MonoBehaviour
{
    void Update()
    {
        // fermer avec touche échap
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitGame();
        }
    }

    
    public void QuitGame()
    {
        Debug.Log("Fermeture du jeu...");
        Application.Quit();
    }
}
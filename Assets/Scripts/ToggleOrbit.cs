using UnityEngine;

public class ToggleOrbit : MonoBehaviour
{
        // Touche utilisée pour activer/désactiver
        public KeyCode toggleKey = KeyCode.Space;

        // État de l’orbite (activé ou non)
        private bool orbitEnabled = false;
   

    // Update is called once per frame
    void Update()
    {
        // Quand on appuie sur la touche définie
        if (Input.GetKeyDown(toggleKey))
        {

            // On inverse l’état (on “toggle”)
            orbitEnabled = !orbitEnabled;

            Debug.Log("Orbit mode: " + (orbitEnabled ? "ON" : "OFF"));
        }
        // Si le mode orbite est activé, on exécute un comportement
        if (orbitEnabled)
        {
            transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
        }
    }
}

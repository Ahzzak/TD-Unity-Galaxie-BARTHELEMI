using UnityEngine;

public class ToggleOrbit : MonoBehaviour
{
    // Touche utilisée pour activer/désactiver
    public KeyCode toggleKey = KeyCode.Space;

    // Référence vers le script qui fait tourner la planète
    private Orbits orbitScript;

    // État de l’orbite (activé ou non)
    private bool orbitEnabled = true;

    void Start()
    {
        // On récupère le script Orbit sur le même objet
        orbitScript = GetComponent<Orbits>();

        if (orbitScript == null)
        {
            Debug.LogWarning("Aucun script 'Orbit' trouvé sur cet objet !");
        }
    }

    void Update()
    {
        // Quand on appuie sur la touche définie
        if (Input.GetKeyDown(toggleKey))
        {
            orbitEnabled = !orbitEnabled;

            Debug.Log("Orbit mode: " + (orbitEnabled ? "ON" : "OFF"));

            // On active ou désactive le script Orbit
            if (orbitScript != null)
                orbitScript.enabled = orbitEnabled;
        }
    }
}

using UnityEngine;

public class HighlightOnHover : MonoBehaviour
{
    private Renderer rend;
    private Color originalColor;
    public Color highlightColor = Color.white;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // On récupère le Renderer de l'objet pour pouvoir changer sa couleur
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
    } 

    // Update is called once per frame
    void OnMouseEnter()
    {
        //Quand la souris passe sur l'objet
        rend.material.EnableKeyword("_EMISSION");
        rend.material.SetColor("_EmissionColor", highlightColor);
    }
    void OnMouseExit()
    {
        // Quand la souris quitte l'objet
       rend.material.DisableKeyword("_EMISSION");
    }
}

using UnityEngine;

public class MouseHighlight : MonoBehaviour


{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
    }

    void OnMouseExit() {
        GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }

}

using UnityEngine;

public class ToggleOrbit : MonoBehaviour
{
    
    public Orbit orbit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){

/*             if (orbit.enabled == true)
            {
                orbit.enabled = false;
            }
            else
            {
                orbit.enabled = true;
            } */

            orbit.enabled = !orbit.enabled;
        
        }
        

    }
}

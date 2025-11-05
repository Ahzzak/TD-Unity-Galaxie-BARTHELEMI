using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    public Camera cam;
    public Material backgroundMat;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(0f, 0.005f);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f, 100f * Time.deltaTime, 0f);
            backgroundMat.SetTextureOffset("_BaseMap", backgroundMat.GetTextureOffset("_BaseMap") + -offset);
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0f, -100f * Time.deltaTime, 0f);
            backgroundMat.SetTextureOffset("_BaseMap", backgroundMat.GetTextureOffset("_BaseMap") + offset);
        }
    }
}

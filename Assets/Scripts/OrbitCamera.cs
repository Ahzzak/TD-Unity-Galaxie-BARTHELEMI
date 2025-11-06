using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    public Transform target; // obj central rotation (sun)
    public float distance = 10.0f; // Distance entre sun et cam
    public float rotationSpeed = 50.0f; // vitesse rotation flèches
    public float mouseSensitivity = 2.0f; // Sensi souris
    public float zoomSpeed = 5.0f; // Vitesse zoom
    public float minDistance = 2.0f; // Zoom mini
    public float maxDistance = 20.0f; // Zoom max

    private float xRotation = 0.0f;
    private float yRotation = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (target == null)
        {
            Debug.LogWarning("Aucun objet cible défini pour OrbitCamera !");
        }

         // position cam de base
        Vector3 angles = transform.eulerAngles;
        xRotation = angles.y;
        yRotation = angles.x;
    }
    

    // Update is called once per frame
    void LateUpdate()
    {
        if (target == null)
            return;

        // clavier
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");     


        xRotation += horizontal * rotationSpeed * Time.deltaTime;
        yRotation -= vertical * rotationSpeed * Time.deltaTime;
        yRotation = Mathf.Clamp(yRotation, -80, 80);

        // souris
        if (Input.GetMouseButton(1))
        {
            xRotation += Input.GetAxis("Mouse X") * mouseSensitivity;
            yRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity;
            yRotation = Mathf.Clamp(yRotation, -80, 80);
        }

         // zoom molette
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        distance -= scroll * zoomSpeed;
        distance = Mathf.Clamp(distance, minDistance, maxDistance);

     // position cam
        Quaternion rotation = Quaternion.Euler(yRotation, xRotation, 0);
        Vector3 position = rotation * new Vector3(0, 0, -distance) + target.position;

        transform.rotation = rotation;
        transform.position = position;
    }
}


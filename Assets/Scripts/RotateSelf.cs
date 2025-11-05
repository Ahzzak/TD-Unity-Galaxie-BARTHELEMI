using UnityEngine;

public class RotateSelf : MonoBehaviour
{
    [Tooltip("Rotation speed in degrees per second")]
    public float rotationSpeed = 50f;

    private Vector3 rotationAxis;

    [Header("Scale Settings")]
    [Tooltip("Minimum possible scale (uniform)")]
    public float minScale = 20f;

    [Tooltip("Maximum possible scale (uniform)")]
    public float maxScale = 50f;

    void Start()
    {
        // Pick a random axis to rotate around
        rotationAxis = Random.onUnitSphere;

        // Pick a random uniform scale between min and max
        float randomScale = Random.Range(minScale, maxScale);
        transform.localScale = Vector3.one * randomScale;


        // Pick a random normalized axis
        rotationAxis = Random.onUnitSphere;
    }

    void Update()
    {
        // Rotate continuously around that axis
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime, Space.Self);
    }
}
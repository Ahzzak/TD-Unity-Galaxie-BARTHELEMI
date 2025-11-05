using UnityEngine;

public class SunAsteroidSpawner : MonoBehaviour
{
    [Header("Asteroid Setup")]
    public GameObject asteroidPrefab; // Prefab with empty pivot and mesh as a child
    public float orbitRadius = 10f;
    public float orbitSpeed = 20f;
    public int asteroidCount = 1;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)){

            SpawnAsteroids();

        }
    }

    void SpawnAsteroids()
    {
        for (int i = 0; i < asteroidCount; i++)
        {
            // Create pivot (asteroid root)
            GameObject asteroidPivot = Instantiate(asteroidPrefab, transform.position, Quaternion.identity);
            asteroidPivot.transform.parent = transform; // Optional: keeps hierarchy clean

            // Get mesh child (assuming the prefab’s first child is the visible mesh)
            Transform mesh = asteroidPivot.transform.GetChild(0);

            // Place the mesh randomly on a sphere around the sun
            Vector3 randomDir = Random.onUnitSphere;
            mesh.localPosition = randomDir * orbitRadius;

            // Randomize initial rotation for more natural look
            asteroidPivot.transform.rotation = Random.rotation;

        }
    }

}

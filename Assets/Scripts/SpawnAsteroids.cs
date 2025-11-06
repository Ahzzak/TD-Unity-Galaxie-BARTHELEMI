using UnityEngine;

public class SpawnAsteroids : MonoBehaviour
{
   public GameObject[] asteroidPrefabs = {}; // prefabs a utiliser
    public Transform sun; 
    public float spawnRadius = 15f; // distance
    public int spawnHeightRange = 5; // hauteur

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            SpawnNewAsteroid();
        }
    }
        
    void SpawnNewAsteroid()
    {
        if (asteroidPrefabs.Length == 0)
        {
            Debug.LogWarning("Aucun prefab assigné à SpawnAsteroid !");
            return;
        }

        // Sélectionne un prefab aléatoire
        int randomIndex = Random.Range(0, asteroidPrefabs.Length);
        GameObject prefab = asteroidPrefabs[randomIndex];
        

        // Position aléatoire autour du Soleil
        Vector3 randomPos = Random.onUnitSphere * spawnRadius;
        randomPos.y = Random.Range(-spawnHeightRange, spawnHeightRange);
        Vector3 spawnPosition = sun.position + randomPos;

        // instancie l'astéroïde
        GameObject newAsteroid = Instantiate(prefab, spawnPosition, Random.rotation);

        // utilisation script Orbit
    
        newAsteroid.AddComponent<Orbits>().pivot = transform;

    }
}
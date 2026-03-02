using System.Collections;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platform;
    float respawnTime = 1f;
    Vector2 screenB;
    
    void Start()
    {
        StartCoroutine(platformWave());
    }

    void Update()
    {
        screenB = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    void Spawn()
    {
        GameObject platform2 = Instantiate(platform) as GameObject;
        platform2.transform.position = new Vector3(Random.Range(-screenB.x, screenB.y), screenB.y * 1.1f, 0);

    }

    IEnumerator platformWave()
    {
        while (true)
        {
            yield return null;
            Spawn();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsRepeat : MonoBehaviour
{
    public GameObject asteroidPF;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    void SpawnAsteroids()
    {
        GameObject a = Instantiate(asteroidPF) as GameObject;
        a.transform.position = new Vector2(screenBounds.y * -2, Random.Range(-screenBounds.x, screenBounds.x));

    }
    IEnumerator asteroidWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnAsteroids();
        }
    }
}

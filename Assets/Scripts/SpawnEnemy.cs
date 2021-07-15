using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    public float spawnInterval = 20;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 10, Random.Range(6f, spawnInterval));
    }

    // Update is called once per frame

    private void Spawn()
    {
        Instantiate(enemy, transform.position, Quaternion.Euler(0f,0f,180f));
    }
}

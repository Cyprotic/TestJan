using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [SerializeField]
    private Transform pos;
    [SerializeField]
    private float spawnTimer;
    [SerializeField]
    private float spawnTimerMax = 10;
    [SerializeField]
    private GameObject enemy;
    [SerializeField]
    private GameManager gameManager;

    void Start()
    {
        spawnTimer = spawnTimerMax;
    }

    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if ( spawnTimer < 0 )
        {
            Instantiate(enemy, new Vector3(pos.transform.position.x, Random.Range(-5.0f, 5.0f), pos.transform.position.z), Quaternion.identity);
            ChangeDifficulty();
        }
    }

    void ChangeDifficulty()
    {
        spawnTimerMax -= gameManager.difficulty;

        spawnTimer = spawnTimerMax;

        if (spawnTimerMax <= 0)
        {
            spawnTimerMax = 0.1f;
            spawnTimer = 0.1f;
        }
            
    }
}

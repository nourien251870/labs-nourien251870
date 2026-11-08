using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Transform Enemy;
    public Transform spawnPoint;

    void RespawnEnemy()
    {
        Instantiate(Enemy, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            RespawnEnemy();
        }
    }


void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    

}
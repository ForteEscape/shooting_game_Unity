using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spqwn : MonoBehaviour {
    public bool enableSpawn = false;

    public GameObject enemy_weak;
    //public GameObject enemy_standard;
    //public GameObject enemy_strong;

    Vector3[] positions = new Vector3[4];

    //public float spawnDelay;
    //float spawnTimer;

    //GameObject[] enemys = new GameObject[3];

    void spawnEnemy()
    {
        float randomX = Random.Range(-1.5f, 1.5f);
        if (enableSpawn)
        {
            GameObject enemy = (GameObject)Instantiate(enemy_weak, new Vector3(randomX, 1.1f, 0f), rotation: Quaternion.identity);
        }
    }
    
    void Start()
    {
        InvokeRepeating("spawnEnemy", 3, 1);
    }

    void Update()
    {

    }
    
    /*void setCreatePos()
    {
        float viewPosX = 0.0f;
        float viewPosY = 1.2f;
        float gapX = 1.0f / 5.0f;

        for(int i = 0; i<positions.Length; i++)
        {
            viewPosX = gapX + gapX * i;
            Vector3 viewPos = new Vector3(viewPosX, viewPosY, 0);
            Vector3 worldPos = Camera.main.ViewportToWorldPoint(viewPos);
            worldPos.z = 0.0f;
        }
    }

    void setSpawnEnemy()
    {
        enemys[0] = enemy_weak;
        enemys[1] = enemy_standard;
        enemys[2] = enemy_strong;
    }

	// Use this for initialization
	void Start () {
        setSpawnEnemy();
        setCreatePos();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SpawnEnemy()
    {
        if (enableSpawn)
        {
            if(spawnTimer > spawnDelay)
            {
                int index = 0;
                int rand = Random.Range(1, 100);
                if (rand < 50) index = 0;
                else if (rand < 80) index = 1;
                else if (rand < 100) index = 2;

                Vector3 pos = positions[Random.Range(0, 4)];
                Instantiate(enemys[index], pos, Quaternion.identity);

                spawnTimer = 0.0f;
 
            }
        }
    }*/
}

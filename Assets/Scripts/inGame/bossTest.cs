﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossTest : MonoBehaviour {

    public int ShotPerOnce;
    public GameObject boss;
    public GameObject bullet;
    public float speed;
    public float bulletCoolTime = 1f;

    public float testindex_Y = 2;
    public float testindex_X = 2;

    IEnumerator SpellStart()
    {
        float angle = 360 / ShotPerOnce;

        do
        {
            for (int i = 0; i < ShotPerOnce; i++)
            {
                //Debug.Log(i);
                GameObject obj;

                obj = (GameObject)Instantiate(bullet, boss.transform.position, Quaternion.identity);
                obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed * Mathf.Cos(Mathf.PI * testindex_X * i / ShotPerOnce), speed * Mathf.Sin(Mathf.PI * i * testindex_Y / ShotPerOnce)));

                obj.transform.Rotate(new Vector3(0f, 0f, 360 * i / ShotPerOnce - 90));
            }
            yield return new WaitForSeconds(bulletCoolTime);
        } while (true);
    }


    // Use this for initialization
    void Start () {
        StartCoroutine(SpellStart());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

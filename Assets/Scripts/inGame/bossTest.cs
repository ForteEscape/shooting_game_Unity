using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossTest : MonoBehaviour {

    public GameObject bulletPrefab;

    public int shotPerOnce;

    public float bulletSpeed;
    public float bulletCoolTime = 1f;

	// Use this for initialization
	void Start () {
        StartCoroutine(BulletGenerator());
	}

    IEnumerator BulletGenerator()
    {
        yield return new WaitForSeconds(bulletCoolTime);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

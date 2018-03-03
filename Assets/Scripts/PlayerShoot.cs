using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public GameObject Player_MainBullet;
    const float shootDelay = 0.098f;
    float shootTimer = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (shootTimer > shootDelay && Input.GetKey(KeyCode.Z))
        {
            Instantiate(Player_MainBullet, transform.position, transform.rotation);
            shootTimer = 0;
        }
        shootTimer += Time.deltaTime;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float BulletMoveSpeed = 300.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float BulletMoveY = BulletMoveSpeed * Time.deltaTime;
        transform.Translate(0, BulletMoveY, 0);
	}
}

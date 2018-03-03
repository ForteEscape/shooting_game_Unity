using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public int enemyHP = 20;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(enemyHP <= 0)
        {
            Destroy(this.gameObject);
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Bullet"))
        {
            //enemyHP -= ;
        }
    }
}

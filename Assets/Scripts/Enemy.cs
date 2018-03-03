using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public int enemyHP = 20;
    int power;

	// Use this for initialization
	void Start () {
        power = GameObject.Find("Player").GetComponent<Player>().bulletPower;
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Bullet"))
        {
            enemyHP -= power;

            if (enemyHP <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}

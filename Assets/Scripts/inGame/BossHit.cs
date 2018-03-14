using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHit : MonoBehaviour {
    public int bossHP;
    int playerPower;

	// Use this for initialization
	void Start () {
        playerPower = GameObject.Find("PlayerManager").GetComponent<PlayerManager>().bulletPower;
	}
	
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Bullet"))
        {
            bossHP -= playerPower;

            if(bossHP <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_E : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}

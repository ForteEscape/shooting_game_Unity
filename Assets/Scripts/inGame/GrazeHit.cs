using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrazeHit : MonoBehaviour {

    int graze = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Bullet_E"))
        {
            graze++;

            Debug.Log("graze");
        }
    }
}

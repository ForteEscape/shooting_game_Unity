using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("enemy"))
        {
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag.Equals("powerItem"))
        {

        }

        if (other.gameObject.tag.Equals("lifeItem"))
        {

        }
    }
}

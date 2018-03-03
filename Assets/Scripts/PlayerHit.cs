using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour {

    private Player player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("enemy"))
        {
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag.Equals("powerItem"))
        {
            GetComponent<Player>().bulletPower += 5;
        }

        if (other.gameObject.tag.Equals("lifeItem"))
        {
            GetComponent<Player>().lifePoint++;

            if(GetComponent<Player>().lifePoint >= 50)
            {
                GetComponent<Player>().lifePlayer++;
                GetComponent<Player>().lifePoint = 0;
            }
        }
    }
}

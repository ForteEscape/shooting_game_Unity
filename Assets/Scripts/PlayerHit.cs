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

        if (other.gameObject.tag.Equals("Item_power"))
        {
            GetComponent<Player>().bulletPower += 2;
        }

        if (other.gameObject.tag.Equals("item_powerBig"))
        {
            GetComponent<Player>().bulletPower += 10;
        }

        if (other.gameObject.tag.Equals("item_point"))
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

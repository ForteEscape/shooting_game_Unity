using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour {

    private PlayerManager player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("enemy"))
        {
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag.Equals("Item_power"))
        {
            GameObject.Find("PlayerManager").GetComponent<PlayerManager>().bulletPower += 2;
        }

        if (other.gameObject.tag.Equals("item_powerBig"))
        {
            GameObject.Find("PlayerManager").GetComponent<PlayerManager>().bulletPower += 10;
        }

        if (other.gameObject.tag.Equals("item_point"))
        {
            GameObject.Find("PlayerManager").GetComponent<PlayerManager>().lifePoint++;

            if(GameObject.Find("PlayerManager").GetComponent<PlayerManager>().lifePoint >= 50)
            {
                GameObject.Find("PlayerManager").GetComponent<PlayerManager>().PlayerLife++;
                GameObject.Find("PlayerManager").GetComponent<PlayerManager>().lifePoint = 0;
            }
        }

        if (other.gameObject.tag.Equals("item_Life"))
        {
            GameObject.Find("PlayerManager").GetComponent<PlayerManager>().PlayerLife++;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour {
    public float itemMoveSpeed = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        itemMoveCtrl();
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("player"))
        {
            Destroy(this.gameObject);
        }
    }

    void itemMoveCtrl()
    {
        float itemDistanceY = itemMoveSpeed * Time.deltaTime;

        this.gameObject.transform.Translate(0, -1 * itemMoveSpeed, 0);
    }
}

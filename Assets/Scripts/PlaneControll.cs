using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneControll : MonoBehaviour {
    public float FlightMoveSpeed = 250.0f;
    //public float RotateAngle = 20.0f;

    float playerBoundaryRadius = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MoveCtrl();
	}

    void MoveCtrl()
    {
    
        Vector3 ViewPosition = Camera.main.WorldToViewportPoint(transform.position);

        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * FlightMoveSpeed;
        float distanceY = Input.GetAxis("Vertical") * Time.deltaTime * FlightMoveSpeed;

        this.gameObject.transform.Translate(distanceX, 0, 0);
        this.gameObject.transform.Translate(0, distanceY, 0);

        //ViewPosition.x = Mathf.Clamp01(ViewPosition.x);
        //ViewPosition.y = Mathf.Clamp01(ViewPosition.y);

        //Vector3 worldPosition = Camera.main.ViewportToWorldPoint(ViewPosition);
        //transform.position = worldPosition;

        //transform.position = position;

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("enemy"))
        {
            Destroy(this.gameObject);
        }
    }
}

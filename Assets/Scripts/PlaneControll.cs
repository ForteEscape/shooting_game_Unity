using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneControll : MonoBehaviour {
    public float FlightMoveSpeed = 250.0f;
    public float RotateAngle = 20.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MoveCtrl();
	}

    void MoveCtrl()
    {
        float astMove = FlightMoveSpeed * Time.deltaTime;

        float moveX = astMove * Input.GetAxis("Horizontal");
        float moveY = astMove * Input.GetAxis("Vertical");
        float rotateX = Input.GetAxis("Horizontal");

        transform.Translate(moveX, moveY, 0, Space.World);
        transform.eulerAngles = new Vector3(0, -rotateX * RotateAngle, 0);
    }
}

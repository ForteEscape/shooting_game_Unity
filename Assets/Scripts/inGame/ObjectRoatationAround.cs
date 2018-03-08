using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRoatationAround : MonoBehaviour {

    Transform BossCenterCoordinate;
    private Vector3 zAxis = new Vector3(0, 0, 1);
    public float rotateSpeed;

	// Use this for initialization
	void Start () {
        BossCenterCoordinate = GameObject.Find("boss").transform;
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(BossCenterCoordinate.position, zAxis, rotateSpeed);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_scroll : MonoBehaviour {
    public GameObject BackgroundUnderLayout;

    public float scroll_velocity = 0.1f;
    private float bgULDiry = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        bgULDiry += Time.deltaTime * scroll_velocity;

        BackgroundUnderLayout.GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, bgULDiry);
	}
}

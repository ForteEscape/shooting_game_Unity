using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Btn_Setting : MonoBehaviour {

    // Use this for initialization
    void Start () {
      
	}

	// Update is called once per frame
	void Update () {
        if (this.GetComponentInChildren<Text>().text == "Btn_Setting" && Input.GetKey(KeyCode.Z)) 
        {
            Application.LoadLevel("Setting");
        }
	}
}

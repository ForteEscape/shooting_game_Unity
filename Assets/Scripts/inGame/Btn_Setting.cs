using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Btn_Setting : MonoBehaviour {

    public void changeScene()
    {
        Application.LoadLevel("Setting");
    }
}

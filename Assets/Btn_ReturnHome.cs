using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Btn_ReturnHome : MonoBehaviour {

	public void Return()
    {
        Application.LoadLevel("GameTitle");
    }
}

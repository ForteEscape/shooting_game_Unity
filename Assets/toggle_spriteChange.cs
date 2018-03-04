using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggle_spriteChange : MonoBehaviour {
    public Sprite switchOn;
    public Sprite switchOff;
    
    public void OnChangeValue()
    {
        bool onoffSwitch = gameObject.GetComponent<Toggle>().isOn;

        if (onoffSwitch)
        {
            GetComponentInChildren<Image>().sprite = switchOn;
        }
        else
        {
            GetComponentInChildren<Image>().sprite = switchOff;
        }
    }
}

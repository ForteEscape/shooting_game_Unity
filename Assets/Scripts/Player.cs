using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public int lifePlayer = 3;
    public int bulletPower = 2;
    public int lifePoint = 0;

    void Start()
    {
        lifePlayer = 3;
        bulletPower = 2;
        lifePoint = 0;
    }

}

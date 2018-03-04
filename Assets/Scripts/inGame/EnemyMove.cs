using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
    public float enemyMoveSpeed = 3.0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        enemyMoveCtrl();
    }

    void enemyMoveCtrl()
    {
        float distanceEnemyY = enemyMoveSpeed * Time.deltaTime;

        this.gameObject.transform.Translate(0, -1 * distanceEnemyY, 0);
    }
}

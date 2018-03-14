using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1 : MonoBehaviour {

    private BossData bossData;
    public int bossPatern1HP;
    public int bossPatern2HP;
    public int bossPatern3HP;
    public float shot;
    public float bulletSpeed;
    public float shotAngle;
    public float shotAngleRate;
    public GameObject bullet;
    public GameObject boss1;
    public GameObject player;
    private int level;
    public int changeValueCos, changeValueSin;
    GameObject obj;

    Coroutine spell1;
    Coroutine spell2;
    Coroutine spell3;
    Coroutine spell4;


	// Use this for initialization
	void Start () {
        bossData = new BossData(bossPatern1HP);
        level = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if(bossData.getHP() == bossPatern1HP && level == 1)
        {
            spell1 = StartCoroutine(BulletSpell1());
            level++;
        }
        
        if(bossData.getHP() <= bossPatern2HP && level == 2)
        {
            StopCoroutine(spell1);
            spell2 = StartCoroutine(BulletSpell2());
            level++;
        }

        if(bossData.getHP() <= bossPatern3HP && level == 3)
        {
            StopCoroutine(spell2);
            spell3 = StartCoroutine(BulletSpell1());
            spell4 = StartCoroutine(BulletSpell3());
            level++;
        }

        if(bossData.getHP() <= 0)
        {
            StopCoroutine(spell3);
            StopCoroutine(spell4);

            Destroy(boss1);
        }
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Bullet"))
        {
            bossData.decreaseHP(1);
        }
    }

    IEnumerator BulletSpell1()
    {
        do
        {
            yield return new WaitForSeconds(1.2f);
            for (int i = 0; i < shot; i++)
            {
                obj = (GameObject)Instantiate(bullet, boss1.transform.position, Quaternion.identity);

                obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed * Mathf.Cos(Mathf.PI * changeValueCos * i / shot), bulletSpeed * Mathf.Sin(Mathf.PI * i * changeValueSin / shot)));
            }

            yield return new WaitForSeconds(1.2f);
            for(int i = 0; i< shot; i++)
            {
                obj = (GameObject)Instantiate(bullet, boss1.transform.position, Quaternion.identity);

                obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed * Mathf.Cos(Mathf.PI * 2 * i / shot + Mathf.PI / 2), bulletSpeed * Mathf.Sin(Mathf.PI * i * 2 / shot + Mathf.PI / 2)));
            }
        } while (true);
    }

    IEnumerator BulletSpell2()
    {
        float angle;
        int rotate;
        angle = 0;
        rotate = 0;

        do
        {
            obj = Instantiate(bullet, boss1.transform.position, Quaternion.identity);

            obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed * Mathf.Cos(Mathf.PI * angle), bulletSpeed * Mathf.Sin(Mathf.PI * angle)));

            if(angle > 2)
            {
                angle = 0;
            }
            if(angle < 2)
            {
                angle += shotAngle;
            }

            if(rotate == 0)
            {
                shotAngle += shotAngleRate;
                shotAngleRate += shotAngleRate / 500;
                if(shotAngle > 0.15)
                {
                    rotate = 1;
                }
            }

            if(rotate == 1)
            {
                shotAngle -= shotAngleRate;
                shotAngleRate -= shotAngleRate / 500;
                if(shotAngle < 0.05)
                {
                    rotate = 0;
                }
            }

            yield return new WaitForSeconds(0.018f);
        } while (true);
    }

    IEnumerator BulletSpell3()
    {
        Vector2 v;

        do
        {
            obj = (GameObject)Instantiate(bullet, boss1.transform.position, Quaternion.identity);

            v = player.transform.position - boss1.transform.position;
            obj.GetComponent<Rigidbody2D>().AddForce(v.normalized * bulletSpeed);

            yield return new WaitForSeconds(0.29f);
        } while (true);
    }
}

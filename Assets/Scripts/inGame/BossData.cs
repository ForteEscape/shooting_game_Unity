using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossData
{
    private int HP;

    public BossData(int _HP)
    {
        HP = _HP;
    }

    public void decreaseHP(int damage)
    {
        HP -= damage;
    }

    public int getHP()
    {
        return HP;
    }
}
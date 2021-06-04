using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Monster 
{
    [SerializeField] MonsterBase _base;
    [SerializeField] int level;
    public MonsterBase Base
    {
        get {
            return _base;
        }
    }

    public int Level
    {
        get {
            return level;
        }
    }

    public int HP { get; set; }

    public void Init()
    {
        HP = MaxHp;
    }

    public int MaxHp {
        get { return Mathf.FloorToInt((Base.MaxHp * Level) / 100f) + 5; }
    }

    public int Attack {
        get { return Mathf.FloorToInt((Base.Attack * Level) / 100f) + 5; }
    }

    public int Defense {
        get { return Mathf.FloorToInt((Base.Defense * Level) / 100f) + 5; }
    }

    public bool TakeDamage(string answer, Monster attacker)
    {
        float modifiers = Random.Range(0.9f, 1f);
        float a = (2 * attacker.Level + 10) / 250f;
        float d = a * ((float) attacker.Attack / Defense) + 2;
        int damage = Mathf.FloorToInt(d * modifiers);

        HP -= damage;
        if (HP <= 0)
        {
            HP = 0;
            return true;
        }
        return false;
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPolice : MonoBehaviour
{
    public EnemyWaveSpawner enemyWaveSpawner;
    
    private float bossLife1 = 15f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BossHealth(); 
    }

    public void BossHealth()
    {
        if(bossLife1 <= 10)
        {
            Vector3 size = new Vector3(500, 500, 500);
            gameObject.transform.localScale = size;
        }

        if (bossLife1 <= 5)
        {
            Vector3 size = new Vector3(700, 700, 700);
            gameObject.transform.localScale = size;
        }

        if (bossLife1 <= 0)
        {
            gameObject.SetActive(false); 
        }
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"<b>COLLIDING WITH BULLET THE BOSS HEALTH LIFE {collision.gameObject.name} </b>");
        if (collision.gameObject.name == "Bullet(Clone)")
        {
            bossLife1--;
            Debug.Log("COLLIDING WITH BULLET THE BOSS HEALTH LIFE " + bossLife1);
        }
    }

}

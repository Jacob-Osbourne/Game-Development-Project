﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staffProjectiles : MonoBehaviour

{
    public GameObject me;
    private int playerDamage;
    // Start is called before the first frame update
    void Start()
    {
        playerDamage = GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<PlayerChar>().playerDamage;
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(me, 5.0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            EnemyHealth enemy;
            enemy = other.gameObject.GetComponent<EnemyHealth>();
            enemy.damageEnemy(playerDamage);
            //Destroy(me);

        }

        if (other.tag == "GLBoss")
        {
            GrassLandsBoss glBoss;
            glBoss = other.gameObject.GetComponent<GrassLandsBoss>();
            glBoss.BossHits();
            //Destroy(me);
        }

        Destroy(me);
    }
         
}


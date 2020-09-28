﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float health = 100f;

    private CharacterAnimation animationScript;
    private EnemyMovement enemyMovement;

    private bool characterDied;
    public bool is_Player;

    private HealthUI health_UI;
    void Awake() {
        animationScript = GetComponentInChildren<CharacterAnimation>();
        if(is_Player)
        {
        health_UI = GetComponent<HealthUI>();
        }
    }

    public void ApplyDamage(float damage, bool knockDown)
    {
        if(characterDied)
        {return;}

        health -= damage;

        // dsiplay health UI
        if(is_Player)
        {
        health_UI.DisplayHealth(health);
        }
        
        if(health <= 0f)
        {
            animationScript.Death();
            characterDied = true;
            
            // if is player deactivate enemy script 
            if(is_Player)
            {
                GameObject.FindWithTag(Tags.Enemy_Tag).GetComponent<EnemyMovement>().enabled = false;
            }
            
            return;
        }
        if(!is_Player)
            {
                if(knockDown)
                {
                    if(Random.Range(0,2) > 0)
                    {
                        animationScript.KnockDown();
                    }
                }else
                {
                    if(Random.Range(0,3) > 1)
                    {
                        animationScript.Hit();
                    }
                } // if its player
            }
        



    } // apply damage
} // class

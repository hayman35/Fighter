using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public float health = 100f;
    private CharacterAnimation animationScript;
    private EnemyMovement enemyMovement;

    private bool characterDied;
    public bool is_Player;

    //private HealthUI health_UI;
    private Image enemy_Health_UI,health_UI;

    void Awake() {
        animationScript = GetComponentInChildren<CharacterAnimation>();
        enemy_Health_UI = GameObject.FindWithTag(Tags.Enemy_Health_UI).GetComponent<Image>();
        health_UI = GameObject.FindWithTag(Tags.Health_UI).GetComponent<Image>();
    }

    public void ApplyDamage(float damage, bool knockDown)
    {
        if(characterDied)
        {return;}

        health -= damage;

        if(is_Player)
        {
            DisplayHealthPlayer(health);
        }
        else
        {
            DisplayHealthEnemy(health);
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

    public void DisplayHealthEnemy(float value)
{
    value /= 100f;
    if(value < 0f)
    {value =0f;}

    enemy_Health_UI.fillAmount = value;
}

public void DisplayHealthPlayer(float value)
{
    value /= 100f;
    if(value < 0f)
    {value =0f;}

    health_UI.fillAmount = value;
}

} // class

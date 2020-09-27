using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationDelegate : MonoBehaviour
{

    public GameObject left_Arm_Attack_Point, left_Leg_Attack_Point, right_Leg_Attack_Point, right_Arm_Attack_Point;

    public float stand_Up_Timer = 2f;

    private CharacterAnimation animation;

    private AudioSource audioSource;

    [SerializeField]
    private AudioClip whoosh_Sound, fall_Sound, ground_Hit_Sound, dead_Sound;

    private EnemyMovement enemyMovement;

    void Awake() {
        animation = GetComponent<CharacterAnimation>();

        audioSource = GetComponent<AudioSource>();

        if(gameObject.CompareTag(Tags.Enemy_Tag))
        {
            enemyMovement = GetComponentInParent<EnemyMovement>();
        }
    } 

    void left_Arm_Attack_On()
    {
        left_Arm_Attack_Point.SetActive(true);
    }
    void left_Arm_Attack_Off()
    {
        if(left_Arm_Attack_Point.activeInHierarchy)
        {
            left_Arm_Attack_Point.SetActive(false);
        }
    }

    void right_Arm_Attack_On()
    {
        left_Arm_Attack_Point.SetActive(true);
    }
    void right_Arm_Attack_Off()
    {
        if(right_Arm_Attack_Point.activeInHierarchy)
        {
            right_Arm_Attack_Point.SetActive(false);
        }
    }

    void left_Leg_Attack_On()
    {
        left_Leg_Attack_Point.SetActive(true);
    }

    void left_Leg_Attack_Off()
    {
        if(left_Leg_Attack_Point.activeInHierarchy)
        {
            left_Leg_Attack_Point.SetActive(false);
        }
    }

    void right_Leg_Attack_On()
    {
        right_Leg_Attack_Point.SetActive(true);
    }

    void right_Leg_Attack_Off()
    {
        if(right_Leg_Attack_Point.activeInHierarchy)
        {
            right_Leg_Attack_Point.SetActive(false);
        }
    }

    void TagLeft_Arm()
    {
        left_Arm_Attack_Point.tag = Tags.Left_Arm_Tag;
    }
    void UnTagLeft_Arm()
    {
        left_Arm_Attack_Point.tag = Tags.Untagged_Tag;
    }

    void TagLeft_Leg()
    {
        left_Leg_Attack_Point.tag = Tags.Left_Leg_Tag;
    } 
    void UnTagLeft_Leg()
    {
        left_Leg_Attack_Point.tag = Tags.Untagged_Tag;
    }
  
  
    void Enemy_StandUp()
    {
        StartCoroutine(StandUpAfterTime());
    }
    IEnumerator StandUpAfterTime()
    {
        yield return new WaitForSeconds(stand_Up_Timer);
        animation.Standup();
    }
    

    public void Attack_FX_Sound()
    {
        audioSource.volume = 0.2f;
        audioSource.clip = whoosh_Sound;
        audioSource.Play();
    }
    
    void CharacterDiedSound()
    {
        audioSource.volume = 1f;
        audioSource.clip = dead_Sound;
        audioSource.Play();
    }

    void Enemy_Knocked_Down()
    {
        audioSource.clip = fall_Sound;
        audioSource.Play();
    }

    void Enemy_Hit_Ground()
    {
        audioSource.clip = ground_Hit_Sound;
        audioSource.Play();
    }


    void DistableMovement()
    {
        enemyMovement.enabled = false;

        transform.parent.gameObject.layer = 0;
    }
    void EnableMovement()
    {
        enemyMovement.enabled = true;
        transform.parent.gameObject.layer = 10;
    }







} // class

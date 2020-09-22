using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationDelegate : MonoBehaviour
{

    public GameObject left_Arm_Attack_Point, left_Leg_Attack_Point, right_Leg_Attack_Point, right_Arm_Attack_Point;

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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }












} // class

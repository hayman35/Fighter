 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ComboState
{
    NONE,
    Punch_1,
    Punch_2,
    Punch_3,
    Kick_1,
    Kick_2
}
public class PlayerAttack : MonoBehaviour
{
    private CharacterAnimation player_Animation;
    private bool activateTimerToReset;
    private float default_Combo_Timer = 0.4f;
    private float current_Combo_Timer;

    private ComboState current_Combo_State;
    private void Awake() {
        player_Animation = GetComponentInChildren<CharacterAnimation>();
    }
    // Start is called before the first frame update
    void Start()
    {
        current_Combo_State = ComboState.NONE;
        current_Combo_Timer = default_Combo_Timer;
    }

    // Update is called once per frame
    void Update()
    {
        ComboAttack();
        ResetComboState();
    }

    void ComboAttack()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
           if (current_Combo_State == ComboState.Punch_3 ||
           current_Combo_State == ComboState.Kick_1 ||
           current_Combo_State == ComboState.Kick_2)
           {
                return;
           }
            current_Combo_State++;
            activateTimerToReset = true;
            current_Combo_Timer = default_Combo_Timer;

            if (current_Combo_State == ComboState.Punch_1)
            {
                player_Animation.Punch_1();
            }

            if (current_Combo_State == ComboState.Punch_2)
            {
                player_Animation.Punch_2();
            }

            if (current_Combo_State == ComboState.Punch_3)
            {
                player_Animation.Punch_3();
            }
            
        } 

        if (Input.GetKeyDown(KeyCode.X))
        {
            
            // return meaning exit cuz we have no combos to perform
            if (current_Combo_State == ComboState.Kick_2 ||
            current_Combo_State == ComboState.Punch_3)
            {return;}


            // we can set the current combo state to kick 1 to chain the combo 
            if(current_Combo_State == ComboState.NONE ||
            current_Combo_State == ComboState.Punch_1 ||
            current_Combo_State == ComboState.Punch_2)
            {
                current_Combo_State = ComboState.Kick_1;
            }
           
           else if(current_Combo_State == ComboState.Kick_1)
            {
                // move to kick 2
                current_Combo_State++;
            }
            
            activateTimerToReset = true;
            current_Combo_Timer = default_Combo_Timer;
            if (current_Combo_State == ComboState.Kick_1)
            {
            player_Animation.Kick_1();
            }
            if (current_Combo_State == ComboState.Kick_2)
            {
            player_Animation.Kick_2();
            }
        } 
        
    } // combo attacks

    void ResetComboState() 
    {
        if (activateTimerToReset)
        {
            current_Combo_Timer -= Time.deltaTime;

            if (current_Combo_Timer <= 0f)
            {
                current_Combo_State = ComboState.NONE;

                activateTimerToReset = false;
                current_Combo_Timer = default_Combo_Timer;
            }
        }
    }
} // class

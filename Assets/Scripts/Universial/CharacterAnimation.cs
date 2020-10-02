using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator animator;

    private void Awake() {
        animator = GetComponent<Animator>();
    }

    public void Walk(bool move)
    {
        animator.SetBool(AnimationTags.Movement, move);

    }

    public void Punch_1()
    {
        animator.SetTrigger(AnimationTags.Punch_1_TRIGGER);
        
    }

    public void Jump()
    {
        animator.SetTrigger(AnimationTags.Jump_Animation);
        
    }
     public void Punch_2()
    {
        animator.SetTrigger(AnimationTags.Punch_2_TRIGGER);
        
    }
     public void Punch_3()
    {
        animator.SetTrigger(AnimationTags.Punch_3_TRIGGER);
        
    }
     public void Kick_1()
    {
        animator.SetTrigger(AnimationTags.Kick_1_TRIGGER);
        
    }
     public void Kick_2()
    {
        animator.SetTrigger(AnimationTags.Kick_2_TRIGGER);
        
    }

    // ENEMY ANIMATIONS 

    public void EnemyAttack(int attack)
    {
        if(attack == 0)
        {
            animator.SetTrigger(AnimationTags.Attack_1_Trigger);
        }

        if(attack == 1)
        {
            animator.SetTrigger(AnimationTags.Attack_2_Trigger);
        }

        if(attack == 2)
        {
            animator.SetTrigger(AnimationTags.Attack_3_Trigger);
        }
    }

    public void Play_IdleAnimation()
    {
        animator.Play(AnimationTags.Idle_Animation);
    }

    public void KnockDown()
    {
        animator.SetTrigger(AnimationTags.Knock_Down_Trigger);
    }

    public void StandUp()
    {
        animator.SetTrigger(AnimationTags.Stand_up_Trigger);
    }
    
    public void Hit()
    {
        animator.SetTrigger(AnimationTags.Hit_Trigger);
    }

    public void Death()
    {
        animator.SetTrigger(AnimationTags.Death_Trigger);
    }

   
}

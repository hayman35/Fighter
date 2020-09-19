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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

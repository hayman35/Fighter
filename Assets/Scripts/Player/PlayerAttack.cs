 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private CharacterAnimation player_Animation;

    private void Awake() {
        player_Animation = GetComponentInChildren<CharacterAnimation>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ComboAttack();
    }

    void ComboAttack()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            player_Animation.Punch_1();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            player_Animation.Kick_1();
        }
        
    }
}

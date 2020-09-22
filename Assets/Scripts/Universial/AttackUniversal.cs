using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackUniversal : MonoBehaviour
{
    public LayerMask collisionLayer;
    public float radius = 1f;
    public float damage = 2f;

    public bool is_Player, is_Enemy;

    public GameObject hit_FX_Prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DetectCollision();
    }

    void DetectCollision()
    {
        Collider[] hit = Physics.OverlapSphere(transform.position,radius,collisionLayer);

        if(hit.Length > 0)
        {
            if(is_Player)
            {
                Vector3 hitFx_Pos = hit[0].transform.position;
                hitFx_Pos.y += 1.3f;

                if(hit[0].transform.forward.x > 0)
                {
                    hitFx_Pos.x += 0.3f;
                } else if(hit[0].transform.forward.x < 0)
                {
                    hitFx_Pos.x -= 0.3f;
                }
                
                Instantiate(hit_FX_Prefab,hitFx_Pos,Quaternion.identity);

                if(gameObject.CompareTag(Tags.Left_Arm_Tag) ||
                gameObject.CompareTag(Tags.Left_Leg_Tag))
                {
                    // hit[0].GetComponent<HealthScript>().ApplyDamage(damage,true);
                } else
                {
                    // hit[0].GetComponent<HealthScript>().ApplyDamage(damage,false);
                }


            } // if its player

            gameObject.SetActive(false);
        }
    }
} // class 

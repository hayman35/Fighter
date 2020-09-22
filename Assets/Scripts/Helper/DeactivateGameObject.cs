using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateGameObject : MonoBehaviour
{
    public float timer = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DeactivateAfterTime",timer);
    }

    void DeactivateAfterTime()
    {
        gameObject.SetActive(false);
    }
}

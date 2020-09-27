using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCamera : MonoBehaviour
{
  public float power = 0.2f;
  public float duration = 0.2f;
  public float slowDownAmount = 1f;
  private bool shouldShake;
  private float initalDuration;

  private Vector3 startPosition;

  private void Start() {
      startPosition = transform.localPosition;
      initalDuration = duration;
  }

  private void Update() {
      Shake();
  }

  void Shake()
  {
      if(shouldShake)
      {
          if(duration > 0f)
          {
              transform.localPosition = startPosition + Random.insideUnitSphere * power;
              duration -= Time.deltaTime * slowDownAmount;
          } else
          {
              shouldShake = false;
              duration = initalDuration;
              transform.localPosition = startPosition;
          }
      } // if we should shake the camera 
  } // shake

    public bool ShouldShake
    {
        get
        {
            return shouldShake;
        }
        set 
        {
            shouldShake = value;
        }
    }

} // class

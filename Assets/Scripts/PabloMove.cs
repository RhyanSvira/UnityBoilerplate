using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PabloMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform left, center, right;
    public readonly float inputDelay = 0.25f;
    public float t=0;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    
    /*implementation of delaying inputs is based on the following
     code by Unity forum user Dextozz:
     private readonly float delayBetweenInputs = 1f;
    private float t;

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && t >= 0)
        {
            // Your action here
            t = delayBetweenInputs;
        }
  
        t -= Time.deltaTime;
    }
    link:
    https://discussions.unity.com/t/how-to-slow-down-input-getkey-speed/796997
    */
    
    void Update()
    {
        t -= Time.deltaTime;
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && t <= 0){
            if (rb.position.x == center.position.x)
            {
                transform.position = left.position;
                t = inputDelay;
            }
            else if (rb.position.x == right.position.x)
            {
                transform.position = center.position;
                t = inputDelay;
            }else if (rb.position.x == left.position.x)
            {
                transform.position = right.position;
                t = inputDelay;
            }
        }
        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && t <= 0){
            if (rb.position.x == center.position.x){
                transform.position = right.position;
                t = inputDelay;
            } 
            else if (rb.position.x == left.position.x)
            {
                transform.position = center.position;
                t = inputDelay;
            } 
            else if (rb.position.x == right.position.x)
            {
                transform.position = left.position;
                t = inputDelay;
            }
            
        }

    }
}

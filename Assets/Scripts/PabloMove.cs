using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PabloMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform left, center, right;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)){
            if (rb.position.x == center.position.x)
            {
                transform.position = left.position;
            }
            else if (rb.position.x == right.position.x)
            {
                transform.position = center.position;
            }else if (rb.position.x == left.position.x)
            {
                transform.position = right.position;
            }
        }
        if (Input.GetKey(KeyCode.D)){
            if (rb.position.x == center.position.x){
                transform.position = right.position;
            } 
            else if (rb.position.x == left.position.x)
            {
                transform.position = center.position;
            } 
            else if (rb.position.x == right.position.x)
            {
                transform.position = left.position;
            }
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeyMove : MonoBehaviour
{
    publuic float speed=2.0f;
    publuic float leaftBound=-4.0f;
    publuic float rightBound=4.0f;
    private int direction=1;//1 for right, -1 for left

}
    void Update()
{
    transform.Translate(Vector3 * speed * direction * Time.deltaTime);
    if (transform.position.x >= rightBound) ;
}
    {
        direction = -1;
    }
     else if (transform.position.x <= leftBound)
    {
        direction = 1;
   }
 }
}
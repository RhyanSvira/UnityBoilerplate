using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnBarrel : MonoBehaviour
{
    public Rigidbody2D projectile;
    public float speed = 4;
    public readonly float InputDelay = 0.75f;
    public float t=0;
    public int counter = 0;
    
    // Update is called once per frame
    void Update()
    {
        t -= Time.deltaTime;
        if (Input.GetMouseButton(0) && t <= 0)
        {
            Rigidbody2D p =Instantiate(projectile, transform.position, transform.rotation);
            counter++;
            t =InputDelay;
            
        }
    }
}

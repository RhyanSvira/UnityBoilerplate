using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    // Update is called once per frame
    void Start()
    {
        Destroy(gameObject, 10f);
    }

    void OnCollisionEnter()
    {
        Destroy(gameObject);
    }
}

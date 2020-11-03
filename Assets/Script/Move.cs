using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 5f) ;
    }

    public float speed;
  
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        
    }
}

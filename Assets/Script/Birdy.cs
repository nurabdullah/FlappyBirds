using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdy : MonoBehaviour
{

    public bool isDead;
    public float velocity = 1f;
    public Rigidbody2D Rg2d;
    public GameManeger managerGame;
    public GameObject DeatScreen;

    private void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        // tıklamayı al 
        if (Input.GetMouseButtonDown(0))
        {
            //havada kuşu sıçrat 
            Rg2d.velocity = Vector2.up * velocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision )
    {
        if (collision.gameObject.name == "ScorArea")
        {
            managerGame.UpdateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeadArea")
        {
            isDead = true;
            Time.timeScale = 0;
            
            DeatScreen.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] LineRenderer line;
    Rigidbody2D rb;

    void Awake(){
        rb=GetComponent<Rigidbody2D>();
        Time.timeScale=.75f;
    }

    void Update()
    {
        transform.up=-transform.position;
        line.SetPosition(1,transform.position);
    }

    [SerializeField] float force=1;

    void FixedUpdate()
    {
        rb.AddForce(transform.right*force*Input.GetAxisRaw("Horizontal"));
    }
    
}
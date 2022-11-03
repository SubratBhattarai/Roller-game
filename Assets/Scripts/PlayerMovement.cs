using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rbody;
    public float speed = 500f;
    public float power = 200f;
    public float miny = -1f;
    private void Start()
    {
        rbody = GetComponent<Rigidbody>();
        
    }

    void FixedUpdate()
    {
        rbody.AddForce(0, 0, power * Time.deltaTime);
        float movehorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(movehorizontal, 0, 0);
        rbody.AddForce(movement * speed * Time.deltaTime);

        if(rbody.position.y < miny)
        {
            FindObjectOfType<Endgame>().Ending();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSweetScript : MonoBehaviour
{
    public float speed = 100;
    public Rigidbody2D rb;

    public void FixedUpdate()
    {
        //supports full WASD movement but up & down are blocked due to game's needs

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 tempVect = new Vector3(h, v, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime;
        rb.MovePosition(rb.transform.position + tempVect);
    }
}

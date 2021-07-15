using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed = 6f;

    // Start is called before the first frame update
    void Start()
    {
    rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        Vector2 deltaVector = new Vector2(h, v);

        rb.velocity = deltaVector.normalized * speed;


    }
}

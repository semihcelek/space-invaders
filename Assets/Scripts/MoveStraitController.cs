using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStraitController : MonoBehaviour
{
    public Vector2 velocity;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = velocity;
    }
}

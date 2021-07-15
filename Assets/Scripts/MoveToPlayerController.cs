using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 2f;

    void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        Vector3 travel = (playerObject.transform.position - transform.position).normalized; // a bullet's move direction
        Vector2 velocity = new Vector2(travel.x, travel.y);
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = velocity * speed;
    }

}

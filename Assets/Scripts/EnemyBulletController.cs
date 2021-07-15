using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="Enemy")
        {
            Physics2D.IgnoreCollision(collision.transform.GetComponent<Collider2D>(), transform.GetComponent<Collider2D>());
        } else
        {
            Destroy(gameObject);

            if (collision.gameObject.tag =="Player")
            {
                Debug.Log("Game over :)");
            }

            if(collision.gameObject.tag !="Wall")
            {
                Destroy(collision.gameObject);
            }
        }
    }
}

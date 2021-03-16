using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collision : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
   
    public void TPPlayerToSpawn()
    {
        transform.position = new Vector3(0, 10, 5);

        rb.velocity = Vector3.zero;

        Physics.SyncTransforms();
    }

    private void OnControllerColliderHit(ControllerColliderHit collision)
    {
        //print("beep");
        if (collision.gameObject.CompareTag("Obstacle1"))
        {
            print("collision detected 1");

            transform.position = new Vector3(112, 1001, 61);

            rb.velocity = Vector3.zero;

            Physics.SyncTransforms();
        }

        if (collision.gameObject.CompareTag("Obstacle2"))
        {
            print("collision detected 2");

            transform.position = new Vector3(0, 10, 5);

            rb.velocity = Vector3.zero;

            Physics.SyncTransforms();
        }

        if (collision.gameObject.CompareTag("Obstacle3"))
        {
            print("collision detected 3");

            transform.position = new Vector3(0, 10, 5);

            rb.velocity = Vector3.zero;

            Physics.SyncTransforms();
        }
    }  
}

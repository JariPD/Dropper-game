using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    void Update()
    {
        /*if (transform.position.x < -50)
        {
            transform.position = new Vector3(0f, 5, 0f);

            rb.velocity = Vector3.zero;

            Physics.SyncTransforms();
        }

        if (transform.position.x < 50)
        {
            transform.position = new Vector3(0f, 5, 0f);

            rb.velocity = Vector3.zero;

            Physics.SyncTransforms();
        }

        if (transform.position.y < 50)
        {
            transform.position = new Vector3(0f, 5, 0f);

            rb.velocity = Vector3.zero;

            Physics.SyncTransforms();
        }*/
    } 
}

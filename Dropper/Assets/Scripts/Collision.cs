using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Collision : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    
    private FirstPersonController FPC;
    private TimeToGO TTG;

    private void Start()
    {
        FPC = FindObjectOfType<FirstPersonController>();
        TTG = FindObjectOfType<TimeToGO>();
    }

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

            //turns powerup off
            FPC.ChangeForceBack();

            //turns the powerup Text on
            TTG.TurnOnPowerUpText();
        }

        if (collision.gameObject.CompareTag("Obstacle2"))
        {
            print("collision detected 2");

            transform.position = new Vector3(133, 1005, 61);

            rb.velocity = Vector3.zero;

            Physics.SyncTransforms();

            //turns powerup off
            FPC.ChangeForceBack();

            //turns the powerup Text on
            TTG.TurnOnPowerUpText();
        }

        if (collision.gameObject.CompareTag("Obstacle3"))
        {
            print("collision detected 3");

            transform.position = new Vector3(112, 1369, 1746);

            rb.velocity = Vector3.zero;

            Physics.SyncTransforms();

            //turns powerup off
            FPC.ChangeForceBack();

            //turns the powerup Text on
            TTG.TurnOnPowerUpText();
        }
    }  
}

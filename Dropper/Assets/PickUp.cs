using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float height = 0.5f;
    [SerializeField] private Text pickUpField;

    private float timerPickupText = 3f;
    private bool isActive;
    Vector3 pos;

    private FirstPersonController FPC;
    private TimeToGO TTG;

    private void Start()
    {
        pos = transform.position;
        FPC = FindObjectOfType<FirstPersonController>();
        TTG = FindObjectOfType<TimeToGO>();
    }

    private void Update()
    {
        //rotate
        transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime);

        //up and down
        float newY = Mathf.Sin(Time.time * speed) * height + pos.y;
     
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);

        if (isActive)
        {
            timerPickupText -= Time.deltaTime;
            pickUpField.text = "PowerUp Timer: " + Mathf.Round(timerPickupText);
            if (timerPickupText <= 0)
            {
                pickUpField.gameObject.SetActive(false);

                timerPickupText = 0;
                //removes powerup
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //mesh renderer uit
            GetComponent<MeshRenderer>().enabled = false;

            //force set higher to slow fall
            FPC.ChangeForce();

            //turns the powerup Text on
            TTG.TurnOnPowerUpText();

            isActive = true;
        }
    }
}

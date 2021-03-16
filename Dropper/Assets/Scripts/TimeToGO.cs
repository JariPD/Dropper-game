using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class TimeToGO : MonoBehaviour
{
    [SerializeField] private Text timeField;
    
    [SerializeField] private GameObject goText;
    [SerializeField] private GameObject timeText;
    [SerializeField] private GameObject pickUpText;

    private Collision col;

    float timeLeft = 999.0f;

    private FirstPersonController FPC;

    private void Start()
    {
        FPC = FindObjectOfType<FirstPersonController>();
        col = FindObjectOfType<Collision>();
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        timeField.text = "Time Left: " + Mathf.Round(timeLeft);
        if (timeLeft < 0)
        {                       
            FPC.LockPlayer(true);

            goText.SetActive(true);
            timeText.SetActive(false);

            Respawn();
        }
    }

    private void Respawn()
    {
        if (timeLeft < 0 && Input.GetKey(KeyCode.Q))
        {
            FPC.LockPlayer(false);
            
            goText.SetActive(false);

            timeLeft = 45f;
            timeText.SetActive(true);

            col.TPPlayerToSpawn();
        }
    }

    public void TurnOnPowerUpText()
    {
        pickUpText.SetActive(true);
    }

    public void TurnOfPowerUpText()
    {
        pickUpText.SetActive(false);
    }
}

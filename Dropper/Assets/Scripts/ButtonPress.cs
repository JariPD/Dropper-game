using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPress : MonoBehaviour
{
    private float timePassed;
    private float lerpDuration = 0.5f;

    private Vector3 startValue;
    private Vector3 endValue;

    void Start()
    {
        startValue = transform.position;
        endValue = startValue + Vector3.down * 0.11f;
    }

    IEnumerator ButtonLerp()
    {
        float t = 0;

        while (t < 1)
        {
            t += Time.deltaTime / lerpDuration;

            transform.position = Vector3.Lerp(startValue, endValue, t);

            yield return null;
        }

        SceneManager.LoadScene("NielsLevel2");

        while (t > 0)
        {
            t -= Time.deltaTime / lerpDuration;

            transform.position = Vector3.Lerp(startValue, endValue, t);

            yield return null;
        }
    }

    void OnMouseDown()
    {
        print("button pressed");

        StartCoroutine(ButtonLerp());
    }
}

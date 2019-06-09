using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteToggle : MonoBehaviour
{

    public Sprite sprite1;
    public Sprite sprite2;
    public int toggleInterval;
    public float toggleCount;

    void Start()
    {
        this.GetComponent<SpriteRenderer>().sprite = sprite1;
        toggleCount = 0.0f;
    }

    void Update()
    {
        toggleCount += Time.deltaTime;
        if (toggleCount > toggleInterval)
        {
            if (this.GetComponent<SpriteRenderer>().sprite == sprite1) //currently sprite 1
            {
                this.GetComponent<SpriteRenderer>().sprite = sprite2;
            }
            else
            {
                this.GetComponent<SpriteRenderer>().sprite = sprite1;
            }
            toggleCount = 0.0f;
        }
    }
}

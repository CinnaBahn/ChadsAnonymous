using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killEarth : MonoBehaviour
{
    public int score;

    void OnCollisionEnter2D(Collision2D col)
    {
        score--;
        Destroy(col.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killEarth : MonoBehaviour
{
    public int score;
    public Color deadSky;
    int startScore;
    Color startColor;
    Camera cam;

    void Start()
    {
        cam = GameObject.FindGameObjectsWithTag("MainCamera")[0].GetComponent<Camera>();
        startColor = cam.backgroundColor;
        startScore = score;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        score--;
        Destroy(col.gameObject);
        cam.backgroundColor = Color.Lerp(deadSky, startColor, (1f * score)/startScore);
    }
}

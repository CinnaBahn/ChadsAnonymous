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

        switch (score)
        {
            case 8:
                Destroy(transform.GetChild(0).gameObject);
                break;
            case 6:
                Destroy(transform.GetChild(1).gameObject);
                break;
            case 4:
                Destroy(transform.GetChild(2).gameObject);
                break;
            case 2:
                Destroy(transform.GetChild(3).gameObject);
                break;
            case 0:
                Destroy(transform.GetChild(4).gameObject);
                break;
        }
        //getChild -> use index to destroy children one by one
    }
}

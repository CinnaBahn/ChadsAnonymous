using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killEarth : MonoBehaviour
{
    public int score;
    public GameObject explosion;
    private GameObject manager;

    audioManager aM;
    
    public Color deadSky;
    int startScore;
    Color startColor;
    Camera cam;

    

    void Start()
    {
        cam = GameObject.FindGameObjectsWithTag("MainCamera")[0].GetComponent<Camera>();
        manager = GameObject.Find("Manager");
        aM = manager.GetComponent<audioManager>();
        startColor = cam.backgroundColor;
        startScore = score;
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        score--;
        aM.explosion();
        Destroy(col.gameObject);
        ContactPoint2D contact = col.GetContact(0);
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        GameObject exp = Instantiate(explosion, pos, rot);
        exp.transform.eulerAngles = new Vector3(0f, 0f, exp.transform.eulerAngles.z + 180f);
        exp.SetActive(true);
        cam.backgroundColor = Color.Lerp(deadSky, startColor, (1f * score)/startScore);


        switch (score)
        {
            case 8:
            case 6:
            case 4:
            case 2:
            case 0:
                Destroy(transform.GetChild(0).gameObject);
                break;
        }
    }
}

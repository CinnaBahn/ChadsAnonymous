using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockMissles : MonoBehaviour
{
    GameObject aM;
    audioManager audioM;

    private void Start()
    {
        aM = GameObject.Find("Manager");
        audioM = aM.GetComponent<audioManager>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(col.gameObject);
        audioM.slurp();
    }
}

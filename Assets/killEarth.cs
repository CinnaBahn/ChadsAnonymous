using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killEarth : MonoBehaviour
{
    public int score;
    public GameObject explosion;
    
    void OnCollisionEnter2D(Collision2D col)
    {
        score--;
        Destroy(col.gameObject);
        ContactPoint2D contact = col.GetContact(0);
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        GameObject exp = Instantiate(explosion, pos, rot);
        exp.transform.eulerAngles = new Vector3(0f, 0f, exp.transform.eulerAngles.z + 180f);
        exp.SetActive(true);
    }
}

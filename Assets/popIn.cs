using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popIn : MonoBehaviour
{
    public float speed;
    public bool vanish;
    Vector3 startSize;
    float progress;
    bool vanishing = false;

    void Start()
    {
        startSize = transform.localScale / 10f;
        transform.localScale = startSize;
        if (vanish)
        {
            Invoke("Vanish", 1);
        }
    }

    void Update()
    {
        transform.localScale = Vector3.Lerp(startSize, startSize * 10f, progress);
        if (!vanishing)
        {
            progress += (Time.deltaTime / speed);
        }
        else
        {
            progress -= (Time.deltaTime / speed);
            if (progress < 0.1f)
            {
                Destroy(gameObject);
            }
        }
    }

    public void Vanish()
    {
        vanishing = true;
    }
}

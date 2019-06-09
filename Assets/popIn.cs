using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popIn : MonoBehaviour
{
    Vector3 startSize;
    float progress;

    void Start()
    {
        startSize = transform.localScale / 10f;
        transform.localScale = startSize;
    }

    void Update()
    {
        transform.localScale = Vector3.Lerp(startSize, startSize * 10f, progress);
        progress += Time.deltaTime;
    }
}

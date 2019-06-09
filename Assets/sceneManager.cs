using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class sceneManager : MonoBehaviour
{
    GameObject spawner;
    GameObject cv;
    GameObject manager;
    GameObject earf;
    GameObject pG;
    GameObject gv;

    Timer t;
    killEarth kE;

    bool gameStarted = false;
    bool gameRestart = false;
    bool gameOver = false;

    private void Awake()
    {
        spawner = GameObject.Find("spawner");
        spawner.SetActive(false);
        cv = GameObject.Find("Canvas");
        cv.SetActive(false);
        pG = GameObject.Find("Polygod_01");
        gv = GameObject.Find("GameOver");
        gv.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        earf = GameObject.Find("earth");
        kE = earf.GetComponent<killEarth>();
        t = cv.transform.GetChild(0).GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !gameStarted)
        {
            spawner.SetActive(true);
            cv.SetActive(true);
            gameStarted = true;
            pG.SetActive(false);

        }
        if (kE.score <= 0)
        {
            gameOver = true;
            t.enabled = false;
            spawner.SetActive(false);
            gv.SetActive(true);
            gameStarted = true;
        }
        if (Input.GetButtonDown("Fire2") && gameOver)
        {
            SceneManager.LoadScene("Defend");
        }
    }
}

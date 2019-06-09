using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{

    AudioSource calm;
    AudioSource siren;
    AudioSource toms;
    AudioSource crash;
    AudioSource highHat;
    AudioSource anxiety;

    GameObject earth;
    GameObject music;

    killEarth ke;
    GameObject expl;
    AudioSource explos;

    public audioManager()
    {

    }

    private void Awake()
    {
        earth = GameObject.Find("earth");
        ke = earth.GetComponent<killEarth>();
        music = GameObject.Find("Music");
        expl = GameObject.Find("Explosion");
        explos = expl.GetComponent<AudioSource>();

        Component[] sounds = music.GetComponents(typeof(AudioSource));
        calm = (AudioSource)sounds[0];
        siren = (AudioSource)sounds[1];
        toms = (AudioSource)sounds[2];
        highHat = (AudioSource)sounds[3];
        crash = (AudioSource)sounds[4];
        anxiety = (AudioSource)sounds[5];

        calm.volume = 1;
        siren.volume = 0;
        toms.volume = 0;
        highHat.volume = 0;
        crash.volume = 0;
        anxiety.volume = 0;
    }

    // Update is called once per frame
    void Update()
    {
        switch (ke.score)
        {
            case 8:
                siren.volume = 1;
                break;
            case 7:
                siren.volume = 1;
                break;
            case 6:
                toms.volume = .6f;
                break;
            case 5:
                toms.volume = .6f;
                break;
            case 4:
                crash.volume = .6f;
                break;
            case 3:
                crash.volume = .6f;
                break;
            case 2:
                highHat.volume = .4f;
                break;
            case 1:
                highHat.volume = .4f;
                break;
            case 0:
                anxiety.volume = 1;
                calm.volume = 0;
                siren.volume = 0;
                toms.volume = 0;
                highHat.volume = 0;
                crash.volume = 0;
                break;
            default:
                //do nothing my guy
                break;

        }
    }

    void explosion()
    {
        explos.Play();
    }
}

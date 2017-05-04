using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    private AudioSource xpl;
    public AudioClip xpL;
    public GameObject ship;
    public static SoundManager instance = null;

    void Awake()
    {
        //Check if there is already an instance of SoundManager
        if (instance == null)
            //if not, set it to this.
            instance = this;
        //If instance already exists:
        else if (instance != this)
            //Destroy this, this enforces our singleton pattern so there can only be one instance of SoundManager.
            Destroy(gameObject);

        //Set SoundManager to DontDestroyOnLoad so that it won't be destroyed when reloading our scene.
        DontDestroyOnLoad(gameObject);
    }

    public void PlaySound(AudioClip clip)
    {
        if (ship.GetComponent<DamageHandler>().health <= 0)
        {
            print("EXPLOSION");
            xpl.clip = clip;
            xpl.Play();
        }
        
    }


    // Update is called once per frame
    void Update () {
        PlaySound(xpL);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileSpawn : MonoBehaviour {

    private float cooldown = 2f;
    public GameObject missile;
    private Vector3 position;

    // Use this for initialization
    void Start () {
        
    }

    void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 45;
    }

    // Update is called once per frame
    void Update () {
        float t = 0.01415f;//Time.deltaTime;
        cooldown -= t;
        //print("T: "+t+", cd: "+cooldown);
        //print(cooldown);
        if (cooldown <= 0)
        { 
            position = new Vector3(Random.Range(13f, 25f), Random.Range(5f, -5f), 0);
            Instantiate(missile, position, Quaternion.identity);
            cooldown = 3.7f;
            
        }
    }

}

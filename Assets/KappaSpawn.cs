using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KappaSpawn : MonoBehaviour
{

    private float cooldown = 8f;
    public GameObject kappa;
    private Vector3 position;
 
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        //print(Time.deltaTime);
        //print(cooldown);
        if (cooldown <= 0)
        {
            position = new Vector3(Random.Range(15f, 25f), Random.Range(5f, -5f), 0);
            Instantiate(kappa, position, Quaternion.identity);
            cooldown = Random.Range(3f, 20f);
        }
    }

}

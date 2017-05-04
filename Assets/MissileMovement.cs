using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMovement : MonoBehaviour
{

    public float maxSpeed = 5f;
    private float timer = 10f;    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;
        
        Vector2 posX = transform.position;
        posX.x -= maxSpeed * Time.deltaTime;
        transform.position = posX;
        
        if (timer <= 0)
        {
                Destroy(gameObject);
        }

    }

}


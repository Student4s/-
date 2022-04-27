using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Player;
    
    public float timeBTWshoot =2f;
    
    private float currenttimeBTWshoot=0f;
    private float visionRadius = 10;
    
    
    
    void Update()
    {
        if (Vector2.Distance(transform.position, Player.transform.position)<=visionRadius)
            if (currenttimeBTWshoot <= 0)
            {
                Instantiate(Enemy,transform.position, transform.rotation);
                currenttimeBTWshoot = timeBTWshoot;
            }
            else
                currenttimeBTWshoot -= Time.deltaTime;
    }
}

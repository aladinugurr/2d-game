using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
   public GameObject attacker;
   public  GameObject[] enemies;


    // Start is called before the first frame update
    void Start()
    {
      enemies =  GameObject.FindGameObjectsWithTag("enemy");
       

     
    }
   
    // Update is called once per frame
    void Update()
    {
        foreach (var enemy in enemies)
        {
            attacker = GameObject.FindGameObjectWithTag("attack_item");
            
        }
       
    }
}

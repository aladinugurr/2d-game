using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tower : MonoBehaviour
{
    // Start is called before the first frame update
    
   public GameObject attacker;   
  
    void Start()
    {
        Instantiate(attacker, new Vector3(-7.48f, -1f, -1f), Quaternion.identity);
      



    }

    // Update is called once per frame
    void Update()
    {

    }
}

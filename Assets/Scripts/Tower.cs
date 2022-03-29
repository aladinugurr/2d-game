using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tower1;
    public GameObject tower2;
    public GameObject attacker;
    public GameObject attacker2;

    void Start()
    {
        Instantiate(attacker, new Vector3(-7.48f, -1f, -1f), Quaternion.identity);
        Instantiate(attacker2, new Vector3(-7.48f, 1f, -1f), Quaternion.identity);
        Instantiate(tower1, new Vector3(-7.48f, -1f, -1f), Quaternion.identity);
        Instantiate(tower2, new Vector3(-7.48f, 1f, -1f), Quaternion.identity);
        attacker = GameObject.FindGameObjectWithTag("attack_item");      
        Debug.Log(attacker);
    



    }

    // Update is called once per frame
    void Update()
    {
      
    }
}

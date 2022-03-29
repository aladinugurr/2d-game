using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack_item : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject damager;
    void Start()
    {
        Instantiate(damager, new Vector3(-7.48f, 0, -1f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

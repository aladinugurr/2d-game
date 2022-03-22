using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusman : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject tesla;

    void Start()
    {
      
        Instantiate(enemy1, new Vector3(6f, 0,-1f), Quaternion.identity);
        Instantiate(enemy2, new Vector3(6f, 1f,-1f), Quaternion.identity);
        Instantiate(tesla, new Vector3(6f, -1f,-1f), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
      
    }
}

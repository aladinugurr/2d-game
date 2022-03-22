using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusman : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    void Start()
    {
      
        Instantiate(enemy, new Vector2(2f, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime);
    }
}

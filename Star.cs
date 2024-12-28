using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{

    public static int StarCount = 0;
    public AudioSource pickedstar;

    // Start is called before the first frame update
    void Start()
    {
        ++Star.StarCount;
        Debug.Log(StarCount);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            pickedstar.Play();
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.Rotate(0, 0, 2);
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public static int CoinCount = 0;
    public AudioSource pickedcoin;

    // Start is called before the first frame update
    void Start()
    {
        ++Coin.CoinCount;
        Debug.Log(CoinCount);
         
    }

   void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pickedcoin.Play();
            Destroy(gameObject);
        }
    }


}

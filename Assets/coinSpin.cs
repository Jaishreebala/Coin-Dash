using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpin : MonoBehaviour
{
    public GameObject[] coins;
    // Start is called before the first frame update
    void Start()
    {
        coins = GameObject.FindGameObjectsWithTag("Coin");
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject coin in coins)
        {
            rotate(coin);
        }
    }
    void rotate(GameObject coin)
    {
        coin.transform.Rotate(2, 0, 0);
    }
}

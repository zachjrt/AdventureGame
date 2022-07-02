using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{

    public GameObject coin;
    public GameObject dagger;
    public GameObject sword;
    public GameObject potion;
    public GameObject potion2;
    public GameObject shield;

    // Start is called before the first frame update
    void Start()
    {
        //GlobalInventory.coin = true;
        coin.SetActive(GlobalInventory.coin);
        dagger.SetActive(GlobalInventory.dagger);
        sword.SetActive(GlobalInventory.sword);
        potion.SetActive(GlobalInventory.potion);
        potion2.SetActive(GlobalInventory.potion2);
        shield.SetActive(GlobalInventory.shield);


    }

    // Update is called once per frame
    void Update()
    {
        coin.SetActive(GlobalInventory.coin);
        dagger.SetActive(GlobalInventory.dagger);
        sword.SetActive(GlobalInventory.sword);
        potion.SetActive(GlobalInventory.potion);
        potion2.SetActive(GlobalInventory.potion2);
        shield.SetActive(GlobalInventory.shield);
    }
}

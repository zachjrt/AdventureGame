using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Well : MonoBehaviour
{

    public GameObject button;
 
    // Start is called before the first frame update
    void Start()
    {
       button.SetActive(GlobalInventory.coin);
    }

    public void son()
    {
        SceneManager.LoadScene("Son");
    }
    public void coinToss()
    {
        GlobalInventory.sword = true;
        GlobalInventory.coin = false;
        SceneManager.LoadScene("WellSword");
    }
}

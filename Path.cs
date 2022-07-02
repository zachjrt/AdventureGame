using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Path : MonoBehaviour
{
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        button.SetActive(GlobalInventory.coin);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void small()
    {
        GlobalInventory.potion = true;
        SceneManager.LoadScene("Lake");
    }
    public void big()
    {
        GlobalInventory.potion2 = true;
        GlobalInventory.coin = false;
        SceneManager.LoadScene("Lake");
    }
}

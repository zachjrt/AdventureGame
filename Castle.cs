using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Castle : MonoBehaviour
{
    // Start is called before the first frame update

    private void Start()
    {
        GlobalInventory.coin = false;
        GlobalInventory.dagger = false;
        GlobalInventory.sword = false;
        GlobalInventory.potion = false;
        GlobalInventory.potion2 = false;
        GlobalInventory.shield = false;
    }
    public void knight()
    {
        SceneManager.LoadScene("Knight");
    }
    public void firefighter()
    {
        GlobalInventory.coin = true;
        SceneManager.LoadScene("Firefighter");
    }
}

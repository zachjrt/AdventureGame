using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Son : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GlobalInventory.sword) {
            GlobalInventory.coin = true;
        }
        else
        {
            GlobalInventory.dagger = true;
        }
      
    }

    public void forest()
    {
        SceneManager.LoadScene("Forest");
    }
    public void mountains()
    {
        SceneManager.LoadScene("Mountain");
    }
}

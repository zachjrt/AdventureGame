using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Remains : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GlobalInventory.shield = true;
    }

    // Update is called once per frame
    public void fall()
    {
        SceneManager.LoadScene("Fall");
    }
    public void mountain()
    {
        SceneManager.LoadScene("Mountain");
    }
}

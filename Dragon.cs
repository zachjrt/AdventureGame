using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dragon : MonoBehaviour
{

    public Text CarlHealthText;
    public Text CarlAttackText;
    public Text CarlDefenseText;

    public Text dragonHealthText;
    public Text dragonAttackText;
    public Text dragonDefenseText;

    int carlHealth;
    int carlAttack;
    int carlDefense;

    int dragonHealth;
    int dragonAttack;
    int dragonDefense;

    public GameObject healButton;

    // Start is called before the first frame update
    void Start()
    {
        dragonHealth = 10;
        dragonAttack = 4;
        dragonDefense = 1;



        carlHealth = 10;
        if (GlobalInventory.shield)
        {
            carlDefense = 1;
        }
        else
        {
            carlDefense = 0;
        }
        if (GlobalInventory.dagger)
        {
            carlAttack = 2;
        }
        else if (GlobalInventory.sword)
        {
            carlAttack = 3;
        }
        else
        {
            carlAttack = 1;
        }

        if (!GlobalInventory.potion && !GlobalInventory.potion2)
        {
            healButton.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        CarlHealthText.text = "Health: " + carlHealth;
        CarlAttackText.text = "Attack: " + carlAttack;
        CarlDefenseText.text = "Defense: " + carlDefense;

        dragonHealthText.text = "Health: " + dragonHealth;

        if (carlHealth <= 0)
        {
            SceneManager.LoadScene("Fail");
        } 
        if (dragonHealth <= 0)
        {
            SceneManager.LoadScene("Win");
        }
    }

    public void attack()
    {
        carlHealth -= dragonAttack - carlDefense;
        dragonHealth -= carlAttack - dragonDefense;
        
    }
    public void heal()
    {
        if (GlobalInventory.potion)
        {
            if (carlHealth < 6) {
                carlHealth += 5;
            }
            else
            {
                carlHealth = 10;
            }
            carlHealth -= dragonAttack - carlDefense;
            GlobalInventory.potion = false;
            healButton.SetActive(false);
        }
        if (GlobalInventory.potion2)
        {
            carlHealth = 10;
            carlHealth -= dragonAttack - carlDefense;
            GlobalInventory.potion2 = false;
            healButton.SetActive(false);
        }
        

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interaction : MonoBehaviour
{
    private PlayerInput playerInput;
    private GameObject target;
    private Hero hero;

    void Awake()
    {
        playerInput = GetComponentInParent<PlayerInput>();
        hero = GetComponent<Hero>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        target = other.gameObject;
        
        switch (other.gameObject.tag)
        {
            case "Resource":
                Debug.Log("resource interacted");
                playerInput.SwitchCurrentActionMap("Resource");
                break;

            case "Base":
                playerInput.SwitchCurrentActionMap("Base");
                break;

            case "Tower":
                playerInput.SwitchCurrentActionMap("Tower");
                break;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        playerInput.SwitchCurrentActionMap("Movement");
        target = null;
    }

    void OnReload()
    {
        Tower tower = GetComponent<Tower>();
        if (tower && tower.isEmpty)
        {
            if (tower.Reload(hero.numResources))
            {
                hero.numResources -= tower.costToReload;
            }
        } else {
            Debug.Log("You need more resources to reload this turret");
        }
    }

    void OnHarvest()
    {
        Debug.Log("harvesting");
        Resource resource = GetComponent<Resource>();
        if (resource)
        {
            hero.numResources += resource.Harvest();
        }
    }
}

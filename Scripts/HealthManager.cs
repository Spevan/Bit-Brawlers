using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    int health;
    public Image healthIcon;
    public Sprite healthSprite1;
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
    }

    public void healthUpdate(int damage)
    {
        health = health - damage;
        switch(health)
        {
            case 3:
                healthIcon.sprite = healthSprite1;
                break;
            case 2:
                break;
            case 1:
                break;
            case 0:
                break;
            default:
                break;
        }
    }
}

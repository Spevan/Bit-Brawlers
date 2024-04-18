using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static float score;
    public TextMeshProUGUI scoreDisplay, timerDisplay;
    int health, timer;
    public Image healthIcon, inventoryDisplay;
    public Sprite healthSprite1;
    public GameObject playerInventory, itemHeld;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreDisplay.SetText("Points: " + score);
        health = 3;
        timer = 100;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timer > 0)
        {
            timer--;
            timerDisplay.SetText("" + timer);
            Timer();
        }

        if (playerInventory.gameObject.transform.childCount > 0)
        {
            itemHeld = playerInventory.transform.GetChild(0).gameObject;
            inventoryDisplay.gameObject.SetActive(true);
            inventoryDisplay.sprite = itemHeld.GetComponent<SpriteRenderer>().sprite;
        }
        else
        {
            inventoryDisplay.gameObject.SetActive(false);
        }
    }

    public void scoreUpdate()
    {
        score++;
        scoreDisplay.SetText("Points: " + score);
    }

    public void healthUpdate(int damage)
    {
        health = health - damage;
        switch (health)
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

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1);
    }
}

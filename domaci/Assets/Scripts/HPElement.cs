using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HPElement : MonoBehaviour
{
    [SerializeField] private Image playerImage;
    [SerializeField] private Image healthBar;

    public void setPlayerImage(Sprite img){
        playerImage.sprite = img;
    }

    public void setPlayerHealth(float amount,Color color){
        healthBar.fillAmount = amount;
        healthBar.color = color;
    }
}

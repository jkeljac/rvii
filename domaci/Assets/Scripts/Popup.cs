using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Popup : MonoBehaviour
{
    [SerializeField] private HPElement playerHealthBar;
    [SerializeField] private Color playerColor;
    [SerializeField] private Color enemyColor;

    [SerializeField] private RectTransform content;
    [SerializeField] private Sprite playerImage;
    [SerializeField] private Sprite enemyImage;
    [SerializeField] private GameObject prefab;

    void OnEnable(){
        
        Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

        playerHealthBar.setPlayerImage(playerImage);
        playerHealthBar.setPlayerHealth(player.Health/100,playerColor);

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        
        for (int i = 0; i < enemies.Length; i++)
        {
            Enemy enemy = enemies[i].GetComponent<Enemy>();
            GameObject enemyHealth = Instantiate(prefab,GameObject.FindGameObjectWithTag("Content").transform);
                        
            if(enemyHealth != null){
                
                HPElement enemyElement = enemyHealth.GetComponent<HPElement>();
                enemyElement.setPlayerImage(enemyImage);
                enemyElement.setPlayerHealth(enemy.Health/100,enemyColor);
            }
        }
    }

    private void OnDisable() {
        foreach (Transform child in content.transform)
        {
            Destroy(child.gameObject);
        }
    }
}

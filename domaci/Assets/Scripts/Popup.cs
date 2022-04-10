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
    /*    Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerHealthBar.setPlayerImage(playerImage);
        playerHealthBar.setPlayerHealth(player.Health/100,playerColor);
     
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        for(int i=0;i<enemies.Length;i++){
            Debug.Log(i);
            GameObject enemyBarObj = Instantiate(prefab, GameObject.FindGameObjectWithTag("Content").transform);
            if(enemyBarObj!=null){
                Enemy enemy = enemies[i].GetComponent<Enemy>();
                if(enemy == null){
                    Debug.Log("!!!!");
                }
                HPElement enemyBar = enemyBarObj.GetComponent<HPElement>();
                enemyBar.setPlayerImage(enemyImage);
                enemyBar.setPlayerHealth((float)enemy.Health/(float)(100),enemyColor);
             //   Debug.Log(enemy.Health);
            }
        }*/
        Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

        playerHealthBar.setPlayerImage(playerImage);
        playerHealthBar.setPlayerHealth(player.Health/100,playerColor);

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        
        for (int i = 0; i < enemies.Length; i++)
        {
            
            Debug.Log(enemies[i]);
        }
        
        for (int i = 0; i < enemies.Length; i++)
        {
            GameObject enemyBarObj = Instantiate(prefab,GameObject.FindGameObjectWithTag("Content").transform);
            
            Debug.Log(enemies[i]);
            
            if(enemyBarObj != null){
                Enemy enemy = enemies[i].GetComponent<Enemy>();
                
                
                HPElement enemyBar = enemyBarObj.GetComponent<HPElement>();
                enemyBar.setPlayerImage(enemyImage);
                enemyBar.setPlayerHealth((float)enemy.Health/(float)(100),enemyColor);
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

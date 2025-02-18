using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Platformer
{
    public class GameManager : MonoBehaviour
    {
        public int coinsCounter = 0;

        public GameObject playerGameObject;
        private PlayerWalk player;
        public GameObject deathPlayerPrefab;
        public Text coinText;

        void Start()
        {
            player = GameObject.Find("Player").GetComponent<PlayerWalk>();
        }

        /*void Update()
        {
            coinText.text = coinsCounter.ToString();
            if(player.deathState == true)
            {
                
                playerGameObject.SetActive(false);
                //Change player to dead player prefab
                GameObject deathPlayer = (GameObject)Instantiate(deathPlayerPrefab, playerGameObject.transform.position, playerGameObject.transform.rotation);
                deathPlayer.transform.localScale = new Vector3(playerGameObject.transform.localScale.x, playerGameObject.transform.localScale.y, playerGameObject.transform.localScale.z);
                player.deathState = false;
                // Reload the scene after 3 seconds
                Invoke("ReloadLevel", 3);
            }
        }*/

        private void ReloadLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

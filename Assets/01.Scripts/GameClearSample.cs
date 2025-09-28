using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClearSample : MonoBehaviour
{
    [SerializeField]
    GameObject gameClear; // 게임 클리어 화면 폴더

    void Start()
    {
        gameClear.SetActive(false); // 게임 클리어 화면 폴더 비활성화
        // if (gameClear.activeSelf == false) {
        //     GameObject.Find("Light 2D").SetActive(true);
        // }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        // 플레이어가 골 지점에 닿으면 클리어
        if (other.gameObject.tag == "Player" && gameObject.tag == "Goal") {
            // 키를 다 얻었는지 확인
            if (GameObject.FindGameObjectsWithTag("KeyCountFull").Length 
                == GameObject.Find("KeyCountFull").transform.childCount) {
                gameClear.SetActive(true); // 게임 클리어 화면 활성화
                Time.timeScale = 0; // 게임 초기화
                // GameObject.Find("Light 2D").SetActive(false);
            }
        }
    }
}

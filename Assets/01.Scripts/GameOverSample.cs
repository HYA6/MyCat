using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverSample : MonoBehaviour
{
    [SerializeField]
    GameObject gameOver; // 게임 오버 폴더

    [SerializeField]
    float maxTime = 5f; // 타임어택 최대 시간

    float timeLeft; // 스크립트 내에서의 채우기 양

    Image timeBarFull; // 줄어드는 타임바 이미지

    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false); // 게임 오버 폴더 비활성화
        timeBarFull = GetComponent<Image>(); // 스크립트가 적용된 이미지(타임바 이미지)
        timeLeft = maxTime; // 채우기 양을 타임어택 최대 시간으로 설정
        Time.timeScale = 1f;
        // if (gameOver.activeSelf == false) {
        //     GameObject.Find("Light 2D").SetActive(true);
        // }
    }

    // Update is called once per frame
    void Update()
    {   
        // 채우기 양이 0보다 크면 채우기 양을 줄인다.
        if (timeLeft > 0) {
            timeLeft -= Time.deltaTime;
            timeBarFull.fillAmount = timeLeft / maxTime; // 채우기 양 설정
        // 채우기 양이 0보다 작으면 게임 오버 화면을 활성화한다.
        } else {
            gameOver.SetActive(true); // 게임 오버 폴더 활성화
            Time.timeScale = 0;
        }
    }
}

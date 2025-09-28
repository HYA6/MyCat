using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySample : MonoBehaviour
{
    // 플레이어와 키 아이템 충돌 감지
    private void OnTriggerEnter2D(Collider2D other) {
        // 키와 충돌한 오브젝트의 태그가 Player이고 해당 키의 태그가 KeyItem이면
        if (other.gameObject.tag == "Player" && gameObject.tag == "KeyItem") {
            gameObject.SetActive(false); // 플레이어와 충돌한 키를 비활성화 한다.
            
            // 플레이어와 충돌한 키 이름의 마지막 숫자
            int kLastName = int.Parse(gameObject.name.Substring(gameObject.name.Length-1, 1));

            // 채워진 키 카운트 활성화시키기
            GameObject.Find("KeyCountFull").transform.GetChild(kLastName-1).gameObject.SetActive(true);

            // 빈 키 카운트 비활성화시키기
            GameObject.Find("KeyCountBlank").transform.GetChild(kLastName-1).gameObject.SetActive(false);
        }
    }
}

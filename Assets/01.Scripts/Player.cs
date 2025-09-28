using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 4f; // 움직이는 속도

    // Update is called once per frame
    void Update()
    {
        Vector3 moveToX = new Vector3(moveSpeed * Time.deltaTime, 0, 0); // X축 이동
        Vector3 moveToY = new Vector3(0, moveSpeed * Time.deltaTime, 0); // Y축 이동

        // 누른 키가 '왼쪽 방향키'라면
        if (Input.GetKey(KeyCode.LeftArrow)) {
            // 좌표를 왼쪽으로 움직인다.
            transform.position -= moveToX;
        // 누른 키가 '오른쪽 방향키'라면
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            // 좌표를 오른쪽으로 움직인다.
            transform.position += moveToX;
        }

        // 누른 키가 '위쪽 방향키'라면
        if (Input.GetKey(KeyCode.UpArrow)) {
            // 좌표를 위쪽으로 움직인다.
            transform.position += moveToY;
        // 누른 키가 '아래쪽 방향키'라면
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            // 좌표를 아래쪽으로 움직인다.
            transform.position -= moveToY;
        }
    }
}

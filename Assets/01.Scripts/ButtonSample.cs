using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSample : MonoBehaviour
{

    [SerializeField]
    GameObject sp; // 설명 UI창

    // close 버튼을 누르면
    public void OnClickClose()
    {
        Application.Quit(); // 게임 종료
    }

    // setting 창 띄우기(토글)
    public void OnClickSetting()
    {
        if (sp.activeSelf == true) {
            sp.SetActive(false);
        } else {
            sp.SetActive(true);
        }
    }

    // setting 창 닫기
    public void OnClickSettingOut()
    {
        sp.SetActive(false);
    }

    // reset 버튼을 누르면
    public void OnClickReset()
    {
        // 게임 다시 시작
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // home 버튼을 누르면
    public void OnClickHome()
    {
        // 시작 화면으로
        SceneManager.LoadScene("StartTest");
    }

    // start 버튼을 누르면
    public void OnClickStart()
    {
        // 게임 시작
        SceneManager.LoadScene("MyCatTest");
    }

    // 1번째 스테이지 next 버튼
    // public void OnClickNextTo2()
    // {
    //     // 2번째 스테이지
    //     SceneManager.LoadScene("MyCat2");
    // }
    // // 2번째 스테이지 next 버튼
    // public void OnClickNextTo3()
    // {
    //     // 3번째 스테이지
    //     SceneManager.LoadScene("MyCat3");
    // }
    // // 3번째 스테이지에서 next 버튼을 누르면
    // public void OnClickNextTo4()
    // {
    //     // 마지막 스테이지
    //     SceneManager.LoadScene("MyCat4");
    // }
}
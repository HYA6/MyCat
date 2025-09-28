using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    GameObject sp;

    // start 버튼을 누르면
    public void OnClickStart()
    {
        // 게임 시작
        SceneManager.LoadScene("MyCat1");
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
        SceneManager.LoadScene("Start");
    }

    // next 버튼을 누르면
    public void OnClickNextTo2()
    {
        // 2번째 스테이지
        SceneManager.LoadScene("MyCat2");
    }
    // next 버튼을 누르면
    public void OnClickNextTo3()
    {
        // 3번째 스테이지
        SceneManager.LoadScene("MyCat3");
    }
    // next 버튼을 누르면
    public void OnClickNextTo4()
    {
        // 마지막 스테이지
        SceneManager.LoadScene("MyCat4");
    }

    // close 버튼을 누르면
    public void OnClickClose()
    {
        Application.Quit(); // 게임 종료
    }

    
    // setting 창 띄우기
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
}
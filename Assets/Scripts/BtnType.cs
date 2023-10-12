using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnType : MonoBehaviour
{
    public BTNType currentType;
    

    void Start()
    {
        
    }

    public void OnBtnClick()
    {
        switch (currentType)
        {
            case BTNType.Start:
                Debug.Log("St");
                SceneManager.LoadScene("Level 1");
                break;
        // 옵션 추가
            case BTNType.Option:
                GameObject.Find("Main").transform.Find("Main").gameObject.SetActive(false);
                GameObject.Find("Option").transform.Find("Option").gameObject.SetActive(true);

                break;
        // 종료
            case BTNType.Quit:
                Application.Quit();
                break;
        // 옵션에서 뒤로가기
            case BTNType.Back:
                GameObject.Find("Main").transform.Find("Main").gameObject.SetActive(true);
                GameObject.Find("Option").transform.Find("Option").gameObject.SetActive(false);
                break;

        }
    }

    

}

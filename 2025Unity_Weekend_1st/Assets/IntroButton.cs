using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroButton : MonoBehaviour
{
    public void ButtonPlay()
    {
        Debug.Log("플레이 버튼이 실행 되었습니다.");

        SceneManager.LoadScene(1);
    }

    public void ButtonLevelEditor()
    {
        Debug.Log("레벨 에디터 버튼이 실행되었습니다");
    }
    public void ButtonSetting()
    {
        Debug.Log("세팅 버튼이 실행되었습니다.");
    }
    public void ButtonNews()
    {
        Debug.Log("뉴스 버튼이 실행되었습니다.");
    }
    public void ButtonWishList()
    {
        Debug.Log("위시 버튼이 실행되었습니다.");
    }
    public void ButtonDiscord()
    {
        Debug.Log("디스코드 버튼이 실행되었습니다.");
    }
    public void ButtonCredit()
    {
        Debug.Log("크레딧 버튼이 실행되었습니다.");
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroButton : MonoBehaviour
{
    public void ButtonPlay()
    {
        Debug.Log("�÷��� ��ư�� ���� �Ǿ����ϴ�.");

        SceneManager.LoadScene(1);
    }

    public void ButtonLevelEditor()
    {
        Debug.Log("���� ������ ��ư�� ����Ǿ����ϴ�");
    }
    public void ButtonSetting()
    {
        Debug.Log("���� ��ư�� ����Ǿ����ϴ�.");
    }
    public void ButtonNews()
    {
        Debug.Log("���� ��ư�� ����Ǿ����ϴ�.");
    }
    public void ButtonWishList()
    {
        Debug.Log("���� ��ư�� ����Ǿ����ϴ�.");
    }
    public void ButtonDiscord()
    {
        Debug.Log("���ڵ� ��ư�� ����Ǿ����ϴ�.");
    }
    public void ButtonCredit()
    {
        Debug.Log("ũ���� ��ư�� ����Ǿ����ϴ�.");
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginCheak : MonoBehaviour
{
    public Sprite[] pic;
    public InputField userNameInput;
    public InputField passwordInput;
    public Button loginButton;
    public Image Avatar;
    public Image Accountpass;
    public Image PassWord;

    public static String userName;
    public static Sprite avatar;

    void Start()
    {
        //ΪButton���OnClick�¼�
        loginButton.onClick.AddListener(OnLoginButtonClicked);
    }


    private void Update()
    {
        if (userNameInput.text == "fishman01")
        {
            Avatar.sprite = pic[5];
            Accountpass.sprite = pic[4];
            if(passwordInput.text == "114514")
            {
                PassWord.sprite = pic[4];
            }
        }
        else if(userNameInput.text == "fishman02")
        {
            Avatar.sprite = pic[5];
            Accountpass.sprite = pic[4];
            if (passwordInput.text == "114514")
            {
                PassWord.sprite = pic[4];
            }
        }
        else if(userNameInput.text == "fishman03")
        {
            Avatar.sprite = pic[5];
            Accountpass.sprite = pic[4];
            if (passwordInput.text == "114514")
            {
                PassWord.sprite = pic[4];
            }
        }
        else
        {
            Accountpass.sprite = pic[0];
        }
    }
    void OnLoginButtonClicked()
    {
        // �����û�����������֤
        if((userNameInput.text == "fishman01" && passwordInput.text == "114514")
            || (userNameInput.text == "fishman02" && passwordInput.text == "114514")
            || (userNameInput.text == "fishman03" && passwordInput.text == "114514"))
        {
            // ��֤ͨ������ת����Ϸ����
            userName = userNameInput.text;
            avatar = Avatar.sprite;
            SceneManager.LoadScene("CampusScenes");
        }
        else
        {
            // ��֤ʧ�ܣ�������ʾ��Ϣ
            Debug.Log("�û������������");
        }

    }
}


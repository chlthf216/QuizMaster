using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Program : MonoBehaviour
{

    private void Start()
    {
        Debug.Log("Hello, World!");
        Publisher publisher = new Publisher();
        publisher.msg += ResultProcess;
        publisher.msg += ResultProcess;


        publisher.SendMessage("�߰� ���� �ּ���!");

        Debug.Log("�۾� �Ϸ�!");
    }
    void ResultProcess(string msg)
    {
        Debug.Log($"�޼��� ����: {msg}");
    }

}

public class Publisher
{
    public delegate void OnMessage(string msg);
    public event OnMessage msg;
    public void SendMessage(string text)
    {
        Debug.Log($"ChatGpt API�� ����մϴ�. (1�аɸ�)...{text}");

        msg?.Invoke(text);
    }
}
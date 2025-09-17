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


        publisher.SendMessage("추가 문제 주세요!");

        Debug.Log("작업 완료!");
    }
    void ResultProcess(string msg)
    {
        Debug.Log($"메세지 수신: {msg}");
    }

}

public class Publisher
{
    public delegate void OnMessage(string msg);
    public event OnMessage msg;
    public void SendMessage(string text)
    {
        Debug.Log($"ChatGpt API와 통신합니다. (1분걸림)...{text}");

        msg?.Invoke(text);
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chat : MonoBehaviour
{
    public static Text textChat;
    [SerializeField]
    private GameObject playerObject;
    public static string playerName = "Ostap";
    // Start is called before the first frame update
    void Start()
    {
        textChat = GetComponent<Text>();
        if (playerObject)
            playerName = playerObject.name;
    }

    internal static void playerAddTextLine(string text)
    {
        addTextLine(playerName, text);
    }

    internal static void addTextLine(string actor_name, string text)
    {
        textChat.text += "\n" + actor_name + ": " + text;
    }
}

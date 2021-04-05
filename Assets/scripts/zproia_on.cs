using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zproia_on : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        playerMove.is_visible_zproia = true;
        chat.addTextLine(other.gameObject.name, "я підняв зброю!");
        chat.playerAddTextLine("Давай знешкодим ворога!");
        Destroy(this.gameObject);
    }


}
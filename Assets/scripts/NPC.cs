using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField]
    private GameObject Player;
    private Animator PlayerAnimator;
    void Start()
    {
        PlayerAnimator = Player.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerAnimator.SetTrigger("is_hi");
            chat.playerAddTextLine("����� �������, ���� ����������!");
            chat.addTextLine(this.gameObject.name, "³����, �������.");
            chat.addTextLine(this.gameObject.name, "����� ������, ������� ����������!");
            chat.addTextLine(this.gameObject.name, "�� ������� � �����. ³���� ����� � ���������� ����������!");
            chat.playerAddTextLine("��������!");
        }
    }
}


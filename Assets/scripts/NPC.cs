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
            chat.playerAddTextLine("Бажаю здоровю, пане Полковнику!");
            chat.addTextLine(this.gameObject.name, "Вільно, рядовий.");
            chat.addTextLine(this.gameObject.name, "Поруч вороги, потрібно знешкодити!");
            chat.addTextLine(this.gameObject.name, "За будівляю є зброя. Візьми зброю і нейтралізуй противника!");
            chat.playerAddTextLine("слухаюсь!");
        }
    }
}


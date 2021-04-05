using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called before the first fram
    [SerializeField]
    private int hp = 100;
    void OnTriggerStay(Collider other)
    {
        chat.addTextLine(this.gameObject.name, "Hp = "+ hp.ToString());
        if (other.tag == "Player")
        {
            hp -= 20;
        }
        if (hp < 1)
            Destroy(this.gameObject);
    }

}

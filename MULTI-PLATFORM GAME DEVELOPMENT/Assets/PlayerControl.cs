using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float maxHp = 100.0f;
    public float currentHp = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        currentHp = maxHp;
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        currentHp -= 15.0f;
    }
}

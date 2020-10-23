using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPoint : MonoBehaviour
{
    public Image healthPointImage;
    public Image healthPointEffect;
    private float hurtSpeed = 0.003f;

    private PlayerControl player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>;

    }

    void Update() {

        healthPointImage.fillAmount = player.currentHp / player.maxHp;
        if (healthPointEffect.fillAmount > healthPointImage.fillAmount)
        {
            healthPointEffecct.fillAmount -= hurtSpeed;

        }
        else {
            healthPointEffect.fillAmount = healthPointImage.fillAmount;
        }
    }
}

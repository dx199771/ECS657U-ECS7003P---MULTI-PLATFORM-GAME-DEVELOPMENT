using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    //public AudioSource tickSource;
    public float maxHp = 100.0f;
    public float currentHp = 10.0f;
    public GameObject[] shoppingCart;
    string[] existedItems = new string[4];
    string[] targetItems = new string[4];
    public float score;
    public GameObject timer;

    // Start is called before the first frame update
    void Start()
    {
        currentHp = maxHp;
        //tickSource = GetComponent<AudioSource>();

    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Pedestrain"))
        {
            currentHp -= 15.0f;
            //tickSource.Play();
            SoundManager.PlaySound(SoundManager.Sound.HeroHurt);
        }
        if (currentHp <= 0)
        {
            score = 0;
            FindObjectOfType<GameManager>().EndGame(score);
        }
        if (collision.CompareTag("Finish")) {

            string slot1 = GameObject.Find("ShoppingListPanel").GetComponent<ShoppingList>().sprite1.ToString();
            string slot2 = GameObject.Find("ShoppingListPanel").GetComponent<ShoppingList>().sprite2.ToString();
            string slot3 = GameObject.Find("ShoppingListPanel").GetComponent<ShoppingList>().sprite3.ToString();
            string slot4 = GameObject.Find("ShoppingListPanel").GetComponent<ShoppingList>().sprite4.ToString();
            float time = timer.GetComponent<Timer>().currentTime;
            targetItems[0] = slot1;
            targetItems[1] = slot2;
            targetItems[2] = slot3;
            targetItems[3] = slot4;

            for (int i = 0; i < shoppingCart.Length; i++)
            {
                if (shoppingCart[i].transform.childCount > 0)
                {
                    existedItems[i] = shoppingCart[i].transform.GetChild(0).GetComponent<Image>().sprite.ToString();
                    Debug.Log(existedItems[i]);
                }
            }

            //compare shopping list and shopping cart
            for (int i = 0; i < existedItems.Length; i++)
            {
                for (int j = 0; j < targetItems.Length; j++)
                {
                    Debug.Log(j + "," + existedItems[j]);

                    if (targetItems[i] == existedItems[j])
                    {
                        if (targetItems[i] != "" && existedItems[i] != "")
                        {
                            score += 25; //pick one correct item +25 score
                            targetItems[i] = "";
                            existedItems[i] = "";
                        }
                    }
                    
                }
            }
            // score calculator
            // if time large than 200, score is 0
            // if time less than 200, then final score equal score /(time/500)
            if (time >= 200)
                score = 0;
            else
               score =  score / (time / 100);
            Debug.Log(score);

            FindObjectOfType<GameManager>().EndGame(score);
        }
    }

}

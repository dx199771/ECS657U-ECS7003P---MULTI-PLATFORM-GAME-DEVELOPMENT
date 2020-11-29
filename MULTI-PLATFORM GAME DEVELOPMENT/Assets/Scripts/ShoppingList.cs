using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoppingList : MonoBehaviour
{

    public GameObject img;
    public GameObject img2;
    public GameObject img3;
    public GameObject img4;
    public GameObject img5;
    public GameObject img6;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;
    public string[] spritePath = { "Tile-_0002_pumpkin", "Tile-_0003_chips-yellow", "Tile-_0003_grape", "Tile-_0009_aubergine", "Tile-_0009_VD", "Tile-_0011_steak 1", "Tile-_0012_cheese", "Tile-_0014_VB", "Tile-_0017_mask"};
    // Start is called before the first frame update
    void Start()
    {
        int randomSprite1 = Random.Range(0, spritePath.Length);
        int randomSprite2 = Random.Range(0, spritePath.Length);
        int randomSprite3 = Random.Range(0, spritePath.Length);
        int randomSprite4 = Random.Range(0, spritePath.Length);
        int randomSprite5 = Random.Range(0, spritePath.Length);
        int randomSprite6 = Random.Range(0, spritePath.Length);

        sprite1 = Resources.Load<Sprite>("Image/" + spritePath[randomSprite1]);
        sprite2 = Resources.Load<Sprite>("Image/" + spritePath[randomSprite2]);
        sprite3 = Resources.Load<Sprite>("Image/" + spritePath[randomSprite3]);
        sprite4 = Resources.Load<Sprite>("Image/" + spritePath[randomSprite4]);
        sprite5 = Resources.Load<Sprite>("Image/" + spritePath[randomSprite5]);
        sprite6 = Resources.Load<Sprite>("Image/" + spritePath[randomSprite6]);
        img.GetComponent<Image>().sprite = sprite1;
        img2.GetComponent<Image>().sprite = sprite2;
        img3.GetComponent<Image>().sprite = sprite3;
        img4.GetComponent<Image>().sprite = sprite4;
        img5.GetComponent<Image>().sprite = sprite5;
        img6.GetComponent<Image>().sprite = sprite6;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

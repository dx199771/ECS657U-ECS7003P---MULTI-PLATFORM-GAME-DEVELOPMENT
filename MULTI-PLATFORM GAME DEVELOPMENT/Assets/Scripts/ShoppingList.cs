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
    //all the pickable object names
    public string[] spritePath = { "Tile-_0002_pumpkin", "Tile-_0003_chips-yellow", "Tile-_0004_orange", "Tile-_0005_tomato", "Tile-_0007_milk-blue", "Tile-_0009_aubergine", "Tile-_0014_VB", "Tile-_0011_steak 1", "Tile-_0012_cheese", "Tile-_0017_mask", "Tile-_0000_AntiWipe", "Tile-_0000_Oatmeal", "Tile-_0004_Nurofen", "Tile-_0004_Water1", "Tile-_0005_Beer" };
    // Start is called before the first frame update
    void Start()
    {
        //when scene start
        //generate 6 random numbers
        int randomSprite1 = Random.Range(0, spritePath.Length);
        int randomSprite2 = Random.Range(0, spritePath.Length);
        int randomSprite3 = Random.Range(0, spritePath.Length);
        int randomSprite4 = Random.Range(0, spritePath.Length);
        int randomSprite5 = Random.Range(0, spritePath.Length);
        int randomSprite6 = Random.Range(0, spritePath.Length);
        //load 6 random pickable object images from all the pickable images
        sprite1 = Resources.Load<Sprite>("Image/" + spritePath[randomSprite1]);
        sprite2 = Resources.Load<Sprite>("Image/" + spritePath[randomSprite2]);
        sprite3 = Resources.Load<Sprite>("Image/" + spritePath[randomSprite3]);
        sprite4 = Resources.Load<Sprite>("Image/" + spritePath[randomSprite4]);
        sprite5 = Resources.Load<Sprite>("Image/" + spritePath[randomSprite5]);
        sprite6 = Resources.Load<Sprite>("Image/" + spritePath[randomSprite6]);
        //assign random object images to shopping list image
        img.GetComponent<Image>().sprite = sprite1;
        img2.GetComponent<Image>().sprite = sprite2;
        img3.GetComponent<Image>().sprite = sprite3;
        img4.GetComponent<Image>().sprite = sprite4;
        img5.GetComponent<Image>().sprite = sprite5;
        img6.GetComponent<Image>().sprite = sprite6;
    }

}

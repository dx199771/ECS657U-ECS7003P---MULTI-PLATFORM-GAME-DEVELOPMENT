using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoppingList : MonoBehaviour
{
    public Sprite slot1;
    public Sprite slot2;
    public Sprite slot3;
    public GameObject img;
    public GameObject img2;
    public GameObject img3;

    public string[] spritePath = { "Tile-_0002_pumpkin", "Tile-_0003_chips-yellow", "Tile-_0003_grape", "Tile-_0009_aubergine", "Tile-_0009_VD", "Tile-_0011_steak 1", "Tile-_0012_cheese", "Tile-_0014_VB", "Tile-_0017_mask", "Tile-_0018_cream-tissue" };
    // Start is called before the first frame update
    void Start()
    {
        int randomSprite1 = Random.Range(0, spritePath.Length);
        int randomSprite2 = Random.Range(0, spritePath.Length);
        int randomSprite3 = Random.Range(0, spritePath.Length);

        var sprite1 = Resources.Load<Sprite>("Image/" + spritePath[randomSprite1]);
        var sprite2 = Resources.Load<Sprite>("Image/" + spritePath[randomSprite2]);
        var sprite3 = Resources.Load<Sprite>("Image/" + spritePath[randomSprite3]);
        
        Debug.Log(sprite1);
        img.GetComponent<Image>().sprite = sprite1;
        img2.GetComponent<Image>().sprite = sprite2;
        img3.GetComponent<Image>().sprite = sprite3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;
    public string[] staticDirections = { "Static North", "Static West", "Static South", "Static East" };
    public string[] runDirections = { "Run North", "Run West", "Run South", "Run East" };

    int lastDirection;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame


    public void SetDirection(Vector2 _direction) {

        string[] directionArray = null;
        if (_direction.magnitude < 0.01)
        {
            directionArray = staticDirections;
        }
        else {
            directionArray = runDirections;
            lastDirection = DirectionToIndex(_direction);
        }
        anim.Play(directionArray[lastDirection]);
    }
    private int DirectionToIndex(Vector2 _direction)
    {
        Vector2 norDir = _direction.normalized;
        float step = 360 / 4;
        float offset = step / 2;
        float angle = Vector2.SignedAngle(Vector2.up, norDir);
        angle += offset;
        if (angle < 0) {
            angle += 360;
        }
        float stepCount = angle / step;
        
        return Mathf.FloorToInt(stepCount);


    }
}

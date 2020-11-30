using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcAnimation : MonoBehaviour
{
    private Animator anim;
    public int character;
    public string[] staticDirections;
    public string[] runDirections;

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
            //Debug.Log(_direction);
        }
        anim.Play(directionArray[lastDirection]);
    }
    //convert moving direction into 4 different directions
    //each direction has different moving animation
    private int DirectionToIndex(Vector2 _direction)
    {
        Vector2 norDir = _direction.normalized;
        float step = 360 / 4; //4 directions in 360degree
        float offset = step / 2;
        float angle = Vector2.SignedAngle(Vector2.up, norDir);
        angle += offset;
        if (angle < 0) {
            angle += 360;
        }
        float stepCount = angle / step; //convert into 4 indexes
        
        return Mathf.FloorToInt(stepCount);


    }
}

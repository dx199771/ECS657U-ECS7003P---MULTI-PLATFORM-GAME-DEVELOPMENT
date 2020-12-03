using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform heroTransform;
    public float zoomSpeed = 1;
    public float targetOrtho;
    public float smoothSpeed = 2.0f;
    public float minOrtho = 1.0f;
    public float maxOrtho = 5.0f;
    public GameObject dialog;
    public float followSpeed;


    void Start()
    {
        heroTransform = GameObject.FindGameObjectWithTag("Player").transform; //initiate camera position on the player
    }

    // Update is called once per frame
    void Update()
    {

        if (dialog.activeSelf == false) //if dialog stop playing
        {
            Vector3 temp = heroTransform.position; //take player's position
            temp.x = heroTransform.position.x;
            temp.y = heroTransform.position.y;
            temp.z = -1;
            ZoomAnimation(temp); //zoom in effect

        }
    }
    void ZoomAnimation(Vector3 temp)
    {
        targetOrtho = Mathf.Clamp(targetOrtho, minOrtho, maxOrtho); //calculate target camera position
        Camera.main.orthographicSize = Mathf.MoveTowards(Camera.main.orthographicSize, targetOrtho, smoothSpeed * Time.deltaTime); //smooth zoom in player position
        transform.position = Vector3.Lerp(transform.position, temp, Time.deltaTime* followSpeed); //smooth translate player position
    }
}

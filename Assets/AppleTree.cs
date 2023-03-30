using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    public GameObject applePrefab;
    public float speed = 1f;
    public float leftAndrightEdge;
    public float chanceToChangeDirections = 0.1f;
    public float SecondsBetweenAppleDrop = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DropApple", 2f, SecondsBetweenAppleDrop);
    }

    // Update is called once per frame
    void Update()
    {
        //Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        if(pos.x < -leftAndrightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if(pos.x > leftAndrightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }
    private void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }

    void DropApple()
    {
        GameObject apple = Instantiate(applePrefab) as GameObject;
        apple.transform.position = transform.position;
    }
}

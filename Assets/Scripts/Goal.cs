using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Paddle opponentPaddle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider self)
    {
        opponentPaddle.score++;
        GameObject.Find("Ball").GetComponent<Ball>().ReturnToCenter();
    }
}

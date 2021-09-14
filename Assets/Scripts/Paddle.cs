using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public int score;
    public int playerSpeed;

    public string left, right;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        playerSpeed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left)) {
            transform.Translate(new Vector3(-1 * Time.deltaTime, 0, 0) * playerSpeed);
        }
        else if (Input.GetKey(right)) {
            transform.Translate(new Vector3(1 * Time.deltaTime, 0, 0) * playerSpeed);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    Rigidbody rb;
    public Paddle paddle0, paddle1;
    public Text countText;
    public Text winText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        countText.enabled = false;
        winText.enabled = false;
        ReturnToCenter();
    }

    public void ReturnToCenter()
    {
        transform.position = new Vector3(0f, 0f, 0f);

        if (paddle0.score >= 10)
        {
            winText.enabled = true;
            winText.text = "Player 0 wins!";
            Time.timeScale = 0;
        }
        else if (paddle1.score >= 10)
        {

            winText.enabled = true;
            winText.text = "Player 1 wins!";
            Time.timeScale = 0;
        }
        else
        {
            StartCoroutine(Countdown());
        }
    }

    public IEnumerator Countdown()
    {
        countText.enabled = true;

        rb.velocity = new Vector3(0, 0, 0);

        for (int i = 3; i > 0; i--)
        {
            countText.text = i.ToString();
            yield return new WaitForSeconds(1);
        }

        countText.enabled = false;

        int velX = Random.Range(1, 3) == 1 ? Random.Range(-4, -7) : Random.Range(4, 7);
        int velZ = Random.Range(1, 3) == 1 ? Random.Range(-4, -7) : Random.Range(4, 7);

        rb.velocity = new Vector3(velX, 0, velZ);

        yield return null;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

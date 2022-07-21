using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    bool SwipeLeft;
    bool SwipeRight;
    public float speed = 0.2f;
    private int[] lines = {-8, -4, 0};
    private int currentLane = 1;
    private float x = 0;

    private void Start() {
        transform.position = new Vector3(0 , 0 , lines[currentLane]);

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle" || collision.gameObject.tag == "Car")
        {
            Debug.Log("end"); // end the game @Parham
        }
    }

    private void Update() {
        transform.localEulerAngles = new Vector3(0, -90, 0);
        SwipeLeft = Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow);
        SwipeRight = Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow);
        if (SwipeLeft)
        {
            if ( currentLane > 0 ){
                currentLane -= 1;
            }
        }
        else if (SwipeRight)
        {
            if ( currentLane < 2 ){
                currentLane += 1;
            }
        }
        x -= speed;
        transform.position = new Vector3(x , 0 , lines[currentLane]);   
    }

}
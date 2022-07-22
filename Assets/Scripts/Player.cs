using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    bool SwipeLeft;
    bool SwipeRight;
    [HideInInspector]
    bool SwipeUp;
    public float speed = 0.2f;
    private int[] lines = {-8, -4, 0};
    private int currentLane = 1;
<<<<<<< HEAD
<<<<<<< HEAD
    private float x = 0;
=======

>>>>>>> 35d7abf5e9b8ac215ca3eb92bb8a9e8d641d10e4
    public float JumpPower = 8f;
    private float y = 0f;
    private Animator m_animator;
    public bool InJump;
    public bool isGrounded = true;

    private Rigidbody rb;

    public float x = 0;
    public Vector3 spawn = new Vector3(0, 0, -4);

    private void Start() {
        m_animator = GetComponent<Animator>();
<<<<<<< HEAD
<<<<<<< HEAD
=======
    public float x = 0;
    public Vector3 spawn = new Vector3(0, 0, -4);

    private void Start() {
=======
        rb = GetComponent<Rigidbody>();
>>>>>>> 31fe3ac798268fac8e14b156119c8b45bf7d5060
        transform.position = spawn;

>>>>>>> ddb76c40c3e4b2c3914af469e66de7e6fedb8023
=======
        transform.position = spawn;
>>>>>>> 35d7abf5e9b8ac215ca3eb92bb8a9e8d641d10e4
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle" || collision.gameObject.tag == "Car")
        {
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
            SceneManager.LoadScene("Menu");
        }
        if (collision.gameObject.tag == "Portal_Forest"){
            SceneManager.LoadScene("Forest");
        }
        if (collision.gameObject.tag == "Untagged"){
            isGrounded = true;
        }
    }

    private void Update() {
        transform.localEulerAngles = new Vector3(0, -90, 0);
        SwipeLeft = Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow);
        SwipeRight = Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow);
        SwipeUp = Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetButton("Jump");
        if (SwipeLeft)
        {   m_animator.Play("TurnLeft");
            if ( currentLane > 0 ){
                currentLane -= 1;
            }
        }
        else if (SwipeRight)
        {   m_animator.Play("TurnRight");
            if ( currentLane < 2 ){
                currentLane += 1;
            }
        }
        if (isGrounded)
        {
            if(m_animator.GetCurrentAnimatorStateInfo(0).IsName("Fall"))
            {
                m_animator.Play("Fall");
                InJump = false;
                isGrounded = true;
            }
            if (SwipeUp)
            {
                isGrounded = false;
                InJump = true;
                rb.AddForce(0, JumpPower, 0, ForceMode.Impulse);
                m_animator.CrossFadeInFixedTime("BasicMotions@jump" , 0.1f);
            } else
            {
                isGrounded = true;
                m_animator.Play("Fall");
            }   
        }
 
        x -= speed;
        transform.position = new Vector3(x , transform.position.y , lines[currentLane]);   
    }

}
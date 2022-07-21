using UnityEngine;
using System.Collections;
[System.Serializable]
public enum SIDE{Left , Mid , Right}

public class Player : MonoBehaviour {
    public SIDE m_Side = SIDE.Mid;
    float newXPose = 0.0f;
    public bool SwipeLeft;
    public bool SwipeRight;
    public float XValue;
    private CharacterController m_char;
    public float speed = 80.0f;
    public Rigidbody player;

    private void Start() {
        m_char = GetComponent<CharacterController>();
        transform.position = new Vector3(-4.44f , 0.12f , -4.05f);
    }

    private void Update() {
        SwipeLeft = Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow);
        SwipeRight = Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow);
        if (SwipeLeft)
        {
            if(m_Side == SIDE.Mid)
            {
                newXPose = -XValue;
                m_Side = SIDE.Left;
            }else if(m_Side == SIDE.Right)
            {
                newXPose = 0;
                m_Side = SIDE.Mid;
            }
        }
        else if (SwipeRight)
        {
            if(m_Side == SIDE.Mid)
            {
                newXPose = XValue;
                m_Side = SIDE.Right;
            }else if(m_Side == SIDE.Left)
            {
                newXPose = 0;
                m_Side = SIDE.Mid;

            }
    }
        m_char.Move((newXPose-transform.position.x) * Vector3.right);
}
}
using UnityEngine;

public class CameraFollower : MonoBehaviour {
    public GameObject player;

    private void FixedUpdate() {
        this.transform.position = new Vector3(player.transform.position.x + 2, 4, -4);
    }
}
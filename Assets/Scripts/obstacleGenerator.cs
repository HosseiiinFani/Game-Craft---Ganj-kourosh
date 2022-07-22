using UnityEngine;
using System;
using System.Collections.Generic;

 [Serializable]
 public struct Obstacle {
    public GameObject obstacle;
    public float scaleX;
    public float scaleY;
    public float scaleZ;
 }

public class obstacleGenerator : MonoBehaviour {
    public int layers = 5;
    public Obstacle[] objects;
    public int distance = 20;
    private int[] z_choices = {0, -4, -8};
    private System.Random z_random = new System.Random();
    private System.Random should_generate = new System.Random();
    private System.Random object_random = new System.Random();

    private void Start() {
        for( int layer = 0 ; layer < layers ; layer++ ) {
            List<int> remainingChoices = new List<int>(z_choices);
            for( int line = 0 ; line < 2 ; line++ ) {
                int generate = should_generate.Next(100);
                if ( generate >= 50 ) {
                    int index = z_random.Next(remainingChoices.Count);
                    int z = remainingChoices[index];
                    int removeIndex = remainingChoices.IndexOf(z);
                    remainingChoices.RemoveAt(removeIndex);
                    int objectIndex = object_random.Next(objects.Length);
                    Vector3 position = new Vector3(-1*layer*distance, 1 * 0.7f , z);
                    Obstacle selectedPrefab = objects[objectIndex];
                    GameObject obstacle = Instantiate(selectedPrefab.obstacle, position, Quaternion.identity);
                    obstacle.transform.localScale = new Vector3(selectedPrefab.scaleX * 0.85f, selectedPrefab.scaleY * 0.85f, selectedPrefab.scaleZ * 0.85f);
                    obstacle.tag = "Obstacle";
                    BoxCollider bc = obstacle.AddComponent<BoxCollider>() as BoxCollider;
                    bc.size = new Vector3(selectedPrefab.scaleX * 0.1f, selectedPrefab.scaleY * 0.1f, selectedPrefab.scaleZ * 0.1f);
                }
            }
        }
    }
}
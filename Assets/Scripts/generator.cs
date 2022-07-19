using UnityEngine;

public class cargenerator: MonoBehaviour {
    public GameObject[] myObjects;

 void Update() {
        

        int randomIndex = Random.Range(0, myObjects.Length);
        Vector3 RandomSpawnPosition = new Vector3(Random.Range(-20,-90),0, Random.Range(1,-8));
        GameObject instantiatedObject = Instantiate(myObjects[randomIndex], RandomSpawnPosition , Quaternion.identity) as GameObject;

  }

}
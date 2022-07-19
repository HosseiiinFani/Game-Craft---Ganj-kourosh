using UnityEngine;
using System.Collections;

public class CarGenerator : MonoBehaviour
{
    public GameObject[] carPrefab;
    
    void Start()
    {

            StartCoroutine(GneratorCars());

    }

    void Update()
    {
        
    }

    private IEnumerator GneratorCars()
    {
        while (true)
        {
            yield return new WaitForSeconds(2.0f);
             int randomIndex = Random.Range(0, carPrefab.Length);
            GameObject instantiatedObject = Instantiate(carPrefab[randomIndex], new Vector3(-19,0,-15) ,Quaternion.identity) as GameObject;
        }
        }

    }
using System.Collections;
using UnityEngine;

public class cargenerator : MonoBehaviour
{
    public GameObject carPrefab;
    
    // Start is called before the first frame update
    void Start()
    {

            StartCoroutine(GneratorCars());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator GneratorCars()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            GameObject newcar = Instantiate(carPrefab);
            newcar.transform.position = transform.position;
        }
        }

    }
using UnityEngine;

public class cargenerator : MonoBehaviour
{
    public GameObject carPrefab;
    
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
            yield return new WaitForSeconds(2f);
            GameObject newcar = Instantiate(carPrefab);
            newcar.transform.position = transform.position;
        }
        }

    }
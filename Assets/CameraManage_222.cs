using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManage22222 : MonoBehaviour
{
    [SerializeField] private GameObject cameraOne;
    [SerializeField] private GameObject cameraTwo;
    [SerializeField] private float delay = .5f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SwitchCamera());
    }

    // Update is called once per frame
    IEnumerator SwitchCamera()
    {
        while (true)
        {
            cameraOne.SetActive(false);
            cameraTwo.SetActive(false);
            yield return new WaitForSeconds(delay);
            cameraOne.SetActive(true);
            cameraTwo.SetActive(false);
            yield return new WaitForSeconds(delay);
            cameraOne.SetActive(false);
            cameraTwo.SetActive(true);
            yield return new WaitForSeconds(delay);
            cameraOne.SetActive(true);
            cameraTwo.SetActive(true);
            yield return new WaitForSeconds(delay); 
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public Material bStar;

    private void Update()
    {
        bStar.EnableKeyword("StarBoolean");
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Star")
        {
            bStar.SetFloat("StarBoolean", 1f);
            other.gameObject.SetActive(false);
            StartCoroutine(StopStar());
        }
    }

    IEnumerator StopStar()
    {
        yield return new WaitForSeconds(5);

        bStar.SetFloat("StarBoolean", 0f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScenes : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject thePlayer;
    public GameObject cutSceneCam;

    void OnTriggerEnter (Collider other) {

        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        cutSceneCam.SetActive(true);
        thePlayer.SetActive(false);
        StartCoroutine(FinishCut());

    }

    IEnumerator FinishCut() {
        yield return new WaitForSeconds(10); //however long the cut scene is
        thePlayer.SetActive(true);
        cutSceneCam.SetActive(false);
    }
}

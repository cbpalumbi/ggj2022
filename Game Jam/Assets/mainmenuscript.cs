using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenuscript : MonoBehaviour
{
    public void GoToLevel1() {
        SceneManager.LoadScene("Level1");
    }
    
}

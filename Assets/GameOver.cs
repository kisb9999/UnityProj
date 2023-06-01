using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public Text points;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Setup(float score){
        gameObject.SetActive(true);
        points.text = score.ToString() + " Points";
    }

    public void RetryButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

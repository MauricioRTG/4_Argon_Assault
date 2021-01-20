using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MusicPlayer : MonoBehaviour
{
    private void Awake()
    {
        //GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadFirstScene", 2f);
    }
    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}

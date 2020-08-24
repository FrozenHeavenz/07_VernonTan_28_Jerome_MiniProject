using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator transAni;
    public string gameScene;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(gameScene);
        StartCoroutine(MenuTrans());
    }

    IEnumerator MenuTrans()
    {
        transAni.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(gameScene);
    }

    public void Quit()
    {
        Application.Quit();
    }
    
}

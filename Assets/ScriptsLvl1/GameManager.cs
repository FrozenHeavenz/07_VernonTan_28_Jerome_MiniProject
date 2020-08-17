using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int Score;
    public static int Hp;

    public Text Score_txt;
    public Text Hp_Txt;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        Hp = 20;
    }

    // Update is called once per frame
    void Update()
    {
        Updatehealth();
        Updatescore();
    }

    public void Updatehealth()
    {
        Hp_Txt.text = "Health : " + Hp;
    }

    public void Updatescore()
    {
        Score_txt.text = "Score : " + Score;
    }
}

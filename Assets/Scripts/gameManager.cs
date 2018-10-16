using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    private static gameManager instance;
    public Punteggio points;
    public LifeManager life;
    public GameObject PallinaPrefab;
    public GameObject spawn;

    private GameObject Ui;
    

    public static gameManager I
    {
        get { return instance; }
        set { instance = value; }
    }

    private void Awake()
    {
        if (I == null)
            I = this;
        else
        {
            GameObject.Destroy(this.gameObject);
        }
    }


    // Use this for initialization
    void Start()
    {
        spawn.GetComponent<SpawnPalline>().Spawn(PallinaPrefab);
        points = new Punteggio(0);
        life = new LifeManager();
        Ui = GameObject.Find("UI");
        Ui.GetComponent<DisplayUI>().Score = points.Punti;
        Ui.GetComponent<DisplayUI>().Lives = life.lifeManager;
    }

    
    // Update is called once per frame
    void Update()
    {
        //chiedo se gameover()

    }

    public void LoseLife()
    {
        if (life.lifeManager > 0)
        {
            life.lifeManager -= 1;
            spawn.GetComponent<SpawnPalline>().Spawn(PallinaPrefab);
            Ui.GetComponent<DisplayUI>().Lives = life.lifeManager;
        }

        else
        {
            Ui.GetComponent<DisplayUI>().GameOver = true;
        }
        }

    public void AddPoints(int valore)
    {
        points.Punti += valore;
        Ui.GetComponent<DisplayUI>().Score = points.Punti;
    }

   
}

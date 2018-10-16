using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {

    private static gameManager instance;
    public Punteggio points;
    public LifeManager life;
    public GameObject PallinaPrefab;
    public GameObject spawn;

    private GameObject Ui;

    public static gameManager I {
        get { return instance; }
        set { instance = value; }
    }

    private void Awake () {
        if (I == null)
            I = this;
        else {
            GameObject.Destroy (this.gameObject);
        }
    }

    // Use this for initialization
    void Start () {
        spawn.GetComponent<SpawnPalline> ().Spawn (PallinaPrefab);
        points = new Punteggio (0);
        life = new LifeManager ();

        Ui = GameObject.Find ("UI");
        Ui.GetComponent<DisplayUI> ().Score = points.Punti;
        Ui.GetComponent<DisplayUI> ().Lives = life.lifeManager;
        Ui.GetComponent<DisplayUI> ().Palline = ContatorePalline.contatorePalline;
    }

    // Update is called once per frame
    void Update () {
        //chiedo se gameover()
        Ui.GetComponent<DisplayUI> ().Palline = ContatorePalline.contatorePalline;

        if (life.lifeManager <= 0 && Input.GetKeyDown (KeyCode.R)) {
            ResetGame ();
        }
    }

    public void LoseLife () {

        if (ContatorePalline.contatorePalline == 0) {
            life.lifeManager -= 1; // perdo vita
            if (life.lifeManager > 0) {
                spawn.GetComponent<SpawnPalline> ().Spawn (PallinaPrefab);
                Ui.GetComponent<DisplayUI> ().Lives = life.lifeManager;
            }// ho vite quindi respawn
            else {
                Ui.GetComponent<DisplayUI> ().GameOver = true;
            }//gameOvers
        }// se ho zero palline perdo vita e fine gioco
    }

    public void AddPoints (int valore) {
        points.Punti += valore;
        Ui.GetComponent<DisplayUI> ().Score = points.Punti;
    }

    private void ResetGame () {
        spawn.GetComponent<SpawnPalline> ().Spawn (PallinaPrefab);
        points = new Punteggio (0);
        life = new LifeManager ();

        Ui = GameObject.Find ("UI");
        Ui.GetComponent<DisplayUI> ().Score = points.Punti;
        Ui.GetComponent<DisplayUI> ().Lives = life.lifeManager;
        Ui.GetComponent<DisplayUI> ().Palline = ContatorePalline.contatorePalline;

        Ui.GetComponent<DisplayUI> ().GameOver = false;
    }

}
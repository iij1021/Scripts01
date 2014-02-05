using UnityEngine;
using System.Collections;

public class GuiBalas : MonoBehaviour {

    public Fogo fogo;
    // posicao Gui
    private float bx = 0.01f;
    private float by = 0.01f;

    // Largura e altura do gui
    private float labelx = 0.15f;
    private float labely = 0.12f;

    // Texturas para Balas
    public Texture BalaCheia;
    public Texture BalaVazia;

    void Start()
    {
        fogo.GetComponentInChildren<Fogo>();

    }
	void Update () {

        
	}

        IEnumerator TotalBalas(){

        //GUI.Label(new Rect(Screen.width * bx,Screen.height *by,Screen.width*labelx,Screen.height*labely),"Balas"+fogo.PenteBalas);
        if (fogo.PenteBalas > 0)
        {

            GUI.Box(new Rect(Screen.width * bx, Screen.height * by, Screen.width * labelx, Screen.height * labely), BalaCheia);
        }
        else if(fogo.PenteVazio == 0)
        {
            GUI.Box(new Rect(Screen.width * bx, Screen.height * by, Screen.width * labelx, Screen.height * labely), BalaVazia);
            yield return new WaitForSeconds(5);

        }
        else
        {

        }
    }

    void OnGUI()
    {
        StartCoroutine(TotalBalas());
    }
}

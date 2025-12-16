using UnityEngine;
using UnityEngine.SceneManagement;

public class botoes : MonoBehaviour
{
    public void iniciar()
    {
        SceneManager.LoadScene("Geral");
    }
    public void sair()
    {
            Application.Quit();
    }
    public void quiz()
    {
        SceneManager.LoadScene("Quiz");
    }public void hinos()
    {
        SceneManager.LoadScene("Hinos");
    }
}

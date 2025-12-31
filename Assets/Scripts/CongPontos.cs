using UnityEngine;
using TMPro;

public class CongPontos : MonoBehaviour
{
    public GameObject painelConfig;
    public GameObject painelPerguntas;
    public GameObject painelRespostas;
    public Perguntas perguntas;
    public TextMeshProUGUI txtPlacarT1;
    public TextMeshProUGUI txtPlacarT2;
    void Start()
    {
        painelConfig.SetActive(false);
        painelPerguntas.SetActive(true);
        txtPlacarT1.text = ConfigTimes.PontosTime1.ToString();
        txtPlacarT2.text = ConfigTimes.PontosTime2.ToString();
       
    }
    void Update()
    {
        perguntas.AtualizarPlacar();
        mostraPlacarT1();
        mostraPlacarT2();
    }
    public void arrumaPontos()
    {
        painelConfig.SetActive(true);
        painelPerguntas.SetActive(false);
         painelRespostas.SetActive(false);
         perguntas.AtualizarPlacar();
    }
    public void pontosArrumado()
    {
        painelConfig.SetActive(false);
        painelPerguntas.SetActive(true);
    }
        public void maisPontoT1()
    {
        ConfigTimes.PontosTime1++;
        perguntas.AtualizarPlacar();
        mostraPlacarT1();
    }

    public void maisPontoT2()
    {
        ConfigTimes.PontosTime2++;
        perguntas.AtualizarPlacar();
        mostraPlacarT2();
    }

    public void menosPontoT1()
    {
        if (ConfigTimes.PontosTime1 > 0)
            ConfigTimes.PontosTime1--;

        perguntas.AtualizarPlacar();
        mostraPlacarT1();
        
    }

    public void menosPontoT2()
    {
        if (ConfigTimes.PontosTime2 > 0)
            ConfigTimes.PontosTime2--;

        perguntas.AtualizarPlacar();
        mostraPlacarT2();
    }

    void mostraPlacarT1()
    {
        txtPlacarT1.text = ConfigTimes.PontosTime1.ToString();
    }
    void mostraPlacarT2()
    {
        txtPlacarT2.text = ConfigTimes.PontosTime2.ToString();
    }

}

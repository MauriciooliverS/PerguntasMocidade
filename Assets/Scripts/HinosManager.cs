using UnityEngine;
using TMPro;

public class HinosManager : MonoBehaviour
{
    [Header("Painéis")]
    public GameObject painelBotoes;
    public GameObject painelHino;

    [Header("Resposta")]
    public TextMeshProUGUI txtResposta;

    [Header("Áudio")]
    public AudioSource audioSource;
    public AudioClip[] hinos; // 10 hinos

    [Header("Respostas")]
    [TextArea(2, 5)]
    public string[] respostas; // 10 respostas

    int hinoAtual = -1;

    void Start()
    {
        painelHino.SetActive(false);
        txtResposta.gameObject.SetActive(false);
    }

    // 🔹 BOTÃO DO HINO (APENAS ABRE A TELA)
    public void AbrirHino(int index)
    {
        hinoAtual = index;

        painelBotoes.SetActive(false);
        painelHino.SetActive(true);

        txtResposta.text = respostas[index];
        txtResposta.gameObject.SetActive(false);

        audioSource.Stop();
        audioSource.time = 0f;
    }

    // 🔊 BOTÃO "TOCAR HINO"
    public void TocarHino()
    {
        if (hinoAtual < 0) return;

        audioSource.Stop();
        audioSource.time = 0f;
        audioSource.clip = hinos[hinoAtual];
        audioSource.Play();
    }

    // 👁️ BOTÃO "MOSTRAR RESPOSTA"
    public void MostrarResposta()
    {
        txtResposta.gameObject.SetActive(true);
    }

    // 🔴 TIME VERMELHO
    public void PontoVermelho()
    {
        ConfigTimes.PontosTime1++;
    }

    // 🔵 TIME AZUL
    public void PontoAzul()
    {
        ConfigTimes.PontosTime2++;
    }

    // ⬅️ VOLTAR
    public void Voltar()
    {
        audioSource.Stop();
        painelHino.SetActive(false);
        painelBotoes.SetActive(true);
    }
}

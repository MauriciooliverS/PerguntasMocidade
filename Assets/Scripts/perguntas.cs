using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Perguntas : MonoBehaviour
{
    [Header("Painel Geral das Perguntas")]
    public GameObject painelBotoesPerguntas;

    [Header("Botões das Perguntas")]
    public Button[] botoesPerguntas;

    [Header("Painel da Pergunta")]
    public GameObject painelPergunta;

    public TextMeshProUGUI txtPergunta;
    public TextMeshProUGUI txtResposta;

    [Header("Botões de Controle")]
    public Button btnMostrarResposta;
    public Button btnTimeAzul;
    public Button btnTimeVermelho;
    public Button btnNinguem;

    [Header("Placar")]
    public TextMeshProUGUI txtPlacar;

    int perguntaAtual = -1;

    void Start()
    {
        painelPergunta.SetActive(false);
        txtResposta.gameObject.SetActive(false);
        ConfigTimes.PontosTime1 = 0;
        ConfigTimes.PontosTime2 = 0;

        AtualizarPlacar();

        for (int i = 0; i < botoesPerguntas.Length; i++)
        {
            int index = i;
            botoesPerguntas[i].onClick.AddListener(() => AbrirPergunta(index));
        }

        btnMostrarResposta.onClick.AddListener(MostrarResposta);
        btnTimeAzul.onClick.AddListener(PontoTimeAzul);
        btnTimeVermelho.onClick.AddListener(PontoTimeVermelho);
        btnNinguem.onClick.AddListener(NinguemPontuou);
    }

    // =========================
    // FLUXO
    // =========================

    void AbrirPergunta(int index)
    {
        perguntaAtual = index;

        painelBotoesPerguntas.SetActive(false);
        painelPergunta.SetActive(true);

        txtPergunta.text = perguntas[index];
        txtResposta.text = respostas[index];

        // Esconde a resposta no início
        txtResposta.gameObject.SetActive(false);

        // Remove a pergunta escolhida definitivamente
        botoesPerguntas[index].gameObject.SetActive(false);

        // Botões de pontuação só depois da resposta
        btnTimeAzul.gameObject.SetActive(false);
        btnTimeVermelho.gameObject.SetActive(false);
        btnNinguem.gameObject.SetActive(false);

        btnMostrarResposta.gameObject.SetActive(true);
    }

    void MostrarResposta()
    {
        txtResposta.gameObject.SetActive(true);

        btnMostrarResposta.gameObject.SetActive(false);
        btnTimeAzul.gameObject.SetActive(true);
        btnTimeVermelho.gameObject.SetActive(true);
        btnNinguem.gameObject.SetActive(true);
    }

    void FecharPergunta()
    {
        painelPergunta.SetActive(false);
        painelBotoesPerguntas.SetActive(true);

        AtualizarPlacar();
    }

    // =========================
    // PONTUAÇÃO
    // =========================

    void PontoTimeAzul()
    {
        ConfigTimes.PontosTime1++;
        FecharPergunta();
    }

    void PontoTimeVermelho()
    {
        ConfigTimes.PontosTime2++;
        FecharPergunta();
    }

    void NinguemPontuou()
    {
        FecharPergunta();
    }

    public void AtualizarPlacar()
    {
        txtPlacar.text =
            "Time Azul: " + ConfigTimes.PontosTime1 +
            "\nTime Vermelho: " + ConfigTimes.PontosTime2;
    }

    // =========================
    // PERGUNTAS
    // =========================
    [Header("Perguntas")]
    [TextArea(2, 4)]
    public string[] perguntas =
    {
        "Qual profeta confrontou o rei Acabe e os profetas de Baal no Monte Carmelo?",
        "Qual era o nome da mãe de Samuel?",
        "Quem sucedeu Moisés como líder de Israel?",
        "Qual profeta teve uma visão de um vale de ossos secos?",
        "Quem foi o sacerdote que criou Samuel e que teve dois filhos perversos?",
        "Que rei babilônico destruiu Jerusalém e levou o povo cativo?",
        "Qual personagem bíblico fez um voto imprudente que envolveu sua filha ao voltar de batalha?",
        "Quem foi a única mulher juíza mencionada na Bíblia?",
        "Em que livro aparece a expressão “tudo é vaidade”?",
        "Quem substituiu Elias como profeta?",
        "Qual é o nome do rio que Naamã precisava se lavar para ser curado da lepra?",
        "Qual rei pediu sabedoria a Deus ao invés de riquezas?",
        "Em qual livro encontramos o relato da queda das muralhas de Jericó?",
        "Qual profeta viu uma visão de quatro criaturas vivas acompanhadas de rodas dentro de rodas?",
        "Quem era o rei de Salém que abençoou Abraão após a vitória contra os reis?",
        "Qual profeta foi levado ao céu em um redemoinho?",
        "Quem liderou a reconstrução dos muros de Jerusalém após o exílio babilônico?",
        "Quem declarou: “Eu sei que o meu Redentor vive”?",
        "Qual profeta teve uma visão de um rolo voador que simbolizava maldição sobre os desobedientes?",
        "Que rei de Judá recebeu uma carta do profeta Isaías dizendo que morreria, mas orou a Deus e teve sua vida prolongada?"
    };

    [Header("Respostas")]
    [TextArea(2, 4)]
    public string[] respostas =
    {
        "Elias — 1 Reis 18",
        "Ana — 1 Samuel 1:20",
        "Josué — Números 27:18–23; Josué 1:1–2",
        "Ezequiel — Ezequiel 37:1–14",
        "Eli — 1 Samuel 1–4",
        "Nabucodonosor — 2 Reis 25",
        "Jefté — Juízes 11:30–40",
        "Débora — Juízes 4–5",
        "Eclesiastes — Eclesiastes 1:2",
        "Eliseu — 1 Reis 19:19–21; 2 Reis 2",
        "Rio Jordão — 2 Reis 5:10–14",
        "Salomão — 1 Reis 3:5–14",
        "Livro de Josué — Josué 6",
        "Ezequiel — Ezequiel 1:4–28",
        "Melquisedeque — Gênesis 14:18–20",
        "Elias — 2 Reis 2:11",
        "Neemias — Neemias 2–6",
        "Jó — Jó 19:25",
        "Zacarias — Zacarias 5:1–4",
        "Ezequias — 2 Reis 20:1–6; Isaías 38"
    };
}

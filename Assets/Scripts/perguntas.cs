using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizBiblico : MonoBehaviour
{
    [Header("Botões das Perguntas")]
    public Button[] botoesPerguntas; // 20 botões

    [Header("Painel da Pergunta")]
    public GameObject painelPergunta;
    public TextMeshProUGUI txtPergunta;
    public TextMeshProUGUI txtResposta;

    [Header("Botões de Pontuação")]
    public Button btnPontoTime1;
    public Button btnPontoTime2;
    public Button btnNinguem;

    [Header("Placar")]
    public TextMeshProUGUI txtPlacar;

    void Start()
    {
        painelPergunta.SetActive(false);
        AtualizarPlacar();

        for (int i = 0; i < botoesPerguntas.Length; i++)
        {
            int index = i; // evita bug de closure
            botoesPerguntas[i].onClick.AddListener(() => SelecionarPergunta(index));
        }

        btnPontoTime1.onClick.AddListener(PontoTime1);
        btnPontoTime2.onClick.AddListener(PontoTime2);
        btnNinguem.onClick.AddListener(NinguemPontuou);
    }

    // =========================
    // FLUXO DO JOGO
    // =========================

    void SelecionarPergunta(int index)
    {
        painelPergunta.SetActive(true);

        txtPergunta.text = perguntas[index];
        txtResposta.text = respostas[index];

        // Remove a pergunta escolhida
        botoesPerguntas[index].gameObject.SetActive(false);
    }

    void PontoTime1()
    {
        ConfigTimes.PontosTime1++;
        FecharPergunta();
    }

    void PontoTime2()
    {
        ConfigTimes.PontosTime2++;
        FecharPergunta();
    }

    void NinguemPontuou()
    {
        FecharPergunta();
    }

    void FecharPergunta()
    {
        painelPergunta.SetActive(false);
        AtualizarPlacar();
    }

    void AtualizarPlacar()
    {
        txtPlacar.text =
            $"{ConfigTimes.NomeTime1}: {ConfigTimes.PontosTime1}\n" +
            $"{ConfigTimes.NomeTime2}: {ConfigTimes.PontosTime2}";
    }

    // =========================
    // PERGUNTAS
    // =========================
    [Header("Perguntas")]
    [TextArea(2, 4)]
    public string[] perguntas =
    {
        // AT (20)
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
        "Que rei de Judá recebeu uma carta do profeta Isaías dizendo que morreria, mas orou a Deus e teve sua vida prolongada?",

        // NT (16)
        "Quem foi o primeiro mártir cristão?",
        "Qual apóstolo duvidou da ressurreição de Jesus até vê-Lo pessoalmente?",
        "Em que cidade os discípulos foram chamados “cristãos” pela primeira vez?",
        "Quem escreveu o livro de Atos dos Apóstolos?",
        "Qual apóstolo era médico?",
        "Quem substituiu Judas Iscariotes entre os Doze apóstolos?",
        "Em qual ilha Paulo sofreu naufrágio?",
        "Qual livro do Novo Testamento foi escrito para um homem chamado Teófilo?",
        "Qual carta do Novo Testamento fala especialmente sobre a supremacia de Cristo e a nova aliança, mas tem autor desconhecido?",
        "Qual evangelho tem o maior número de parábolas?",
        "Em qual concílio descrito em Atos discutiu-se a necessidade de circuncisão para os gentios?",
        "Quem foi o casal que mentiu ao Espírito Santo e morreu diante dos apóstolos?",
        "Quantas igrejas da Ásia Menor receberam cartas específicas em Apocalipse 2–3?",
        "Qual apóstolo menciona em uma de suas cartas ter sido “arrebatado ao terceiro céu”?",
        "Quem foi a primeira pessoa a reconhecer Jesus como o Cristo no caminho de Cesareia de Filipe?",
        "Quem acompanhou Paulo na primeira viagem missionária, mas depois se separou dele?"
    };

    // =========================
    // RESPOSTAS
    // =========================
    [Header("Respostas")]
    [TextArea(2, 4)]
    public string[] respostas =
    {
        // AT
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
        "Ezequias — 2 Reis 20:1–6; Isaías 38",

        // NT
        "Estevão — Atos 7:54–60",
        "Tomé — João 20:24–29",
        "Antioquia — Atos 11:26",
        "Lucas — Atos 1:1; Lucas 1:1–4",
        "Lucas — Colossenses 4:14",
        "Matias — Atos 1:23–26",
        "Malta — Atos 28:1",
        "Lucas e Atos — Lucas 1; Atos 1",
        "Hebreus — autor desconhecido",
        "Evangelho de Lucas",
        "Concílio de Jerusalém — Atos 15",
        "Ananias e Safira — Atos 5",
        "Sete igrejas — Apocalipse 2–3",
        "Paulo — 2 Coríntios 12:2",
        "Pedro — Mateus 16:16",
        "João Marcos — Atos 13; 15"
    };
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private AudioSource audio;
    [SerializeField] private AudioClip som;
    [SerializeField] private string proximaCena;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audio = GetComponent<AudioSource>();

    }
    // Update is called once per frame
    void Update()
    {

    }
    public void MudaDeCena()
    {
        SceneManager.LoadScene(proximaCena);
    }

    public void jogar()
    {
        TocarSom();
        SceneManager.LoadScene("MenuPersonagens");
    }
    public void gato()
    {
        SceneManager.LoadScene("historia");
    }
    public void caramelo()
    {
        SceneManager.LoadScene("historia");
    }

    private void OnMouseDown()
    {

    }
    public void creditos()
    {
        SceneManager.LoadScene("creditos");
    }

    public void Voltar()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
  
    public void pular()
    {
        SceneManager.LoadScene("caramelo");
    }
    public void prosseguir()
    {
        SceneManager.LoadScene("corredor principal");
    }
    public void continua()
    {
        SceneManager.LoadScene("CorredorBifurcacao");
    }
    public void irpeladireita()
    {
        SceneManager.LoadScene("BatalhaDireita");
    }
    public void lutar()
    {
        SceneManager.LoadScene("Batalha");
    }
    public void voltarparaomenu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
    public void fugir()
    {
        SceneManager.LoadScene("fugir");
    }
    public void irpelaesquerda()
    {
        SceneManager.LoadScene("CenaDaEsquerda");
    }
    public void ir()
    {
        SceneManager.LoadScene("LutaDaEsquerda");
    }
    public void q()
    {
        SceneManager.LoadScene("luta");   
    }
    public void ()
    {
        SceneManager.LoadScene("FugirDasIguanas");
    }

    public void continuar()
    {
        SceneManager.LoadScene("voce morreu");
    }
    public void sair()
    {
        SceneManager.LoadScene("saindo");
    }
    public void s()
    {
        SceneManager.LoadScene("voceganhou");
    }
    public void MenuPrincipal()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void TocarSom()
    {
        audio.PlayOneShot(som);
    }
  
}

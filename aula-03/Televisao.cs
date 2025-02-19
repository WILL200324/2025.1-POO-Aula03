namespace aula_03;

class Televisao 
{
    //O método construtor possui o mesmo 
    //nome da classe. Ele não possui retorno (nem mesmo o void)
    //este método é executado sempre que uma instancia da classe
    // é criada.
    //Por padrão, o C# cria um método construtor publico vazio,
    //mas podemos criar métodos construtores com outras
    public Televisao(float tamanho)
    {
        this.Tamanho = tamanho;
    }



    //Get: permite que seja executada a 
    //leitura do valor atual da propriedade
    //Set: permite que seja atribuido um 
    // valor para a propriedade
    
    //classes, propriedades e métodos possuem modificadores de acesso
    //public: visiveis a todo o projeto
    //internal: visiveis somente no namespace
    //protecde: visiveis somente na classe e nas classes que herdam
    //private: visiveis somente na classe que foram criados
    public float Tamanho { get;  private set; } 
    public int Resolucao { get; set; }
    public int Volume { get; set; }
    public int Canal { get; set; }

    public bool stado { get; set; }
}
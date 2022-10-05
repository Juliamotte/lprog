using Modelos;

class Aula5  {


  public static void Main (string[] args){
    
    Aluno aluno1 = new Aluno(0);
    aluno1.Cpf = "422.657.877-99";
    Impressora.Imprimir(aluno1);
    
    Aluno aluno2 = new Aluno(1);
    aluno2.Cpf = "660.036.460-20";
    Impressora.Imprimir(aluno2);
    
    Pessoa pessoa1 = new Pessoa(1);
    pessoa1.Cpf = "588.401.710-37";
    Impressora.Imprimir(pessoa1);
    
    Pessoa pessoa2 = (pessoa) aluno2;
    Impressora.Imprimir(pessoa2);

    Aluno aluno3 = (Aluno) pessoa2;
    Impressora.Imprimir(aluno3);

    Familiar familiar1 = new Familiar();
    familiar1.Cpf = "069.705.690-20";
    Impressora.Imprimir(familiar1);

  }
  
}

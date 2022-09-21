namespace Modelos {

  class Impressora {
    
    public static void print (Pessoa pessoa) {
    Console.WriteLine(
      ".........................\n" +
      "Nome: " + aluno.nome + "\n" +
      "CPF : " + aluno.Cpf + "\n"  +
      "........................."
    );
  }
  
  public static void print (Aluno aluno) {
  Console.WriteLine(
      ".........................\n" +
      "Matricula: " + aluno.matricula + "\n" +
      "Nome: " + aluno.nome + "\n" +
      "CPF : " + aluno.Cpf + "\n"  +
      "Periodo: " + aluno.periodo + "\n" +
      "........................."
    );
  }
}

  public static void print (Familiar familiar) {
  Console.WriteLine(
      ".........................\n" +
      "Nome: " + familiar.nome + "\n" +
      "CPF : " + familiar.Cpf + "\n"  +
      "Parentesco: " +familiar.Parentesco + "\n" +
      "........................."
    );
  }
}
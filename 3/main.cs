using System;
using Modelos;

class MainClass {

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
  public static void Main (string[] args) {
    Aluno aluno1 = new Aluno {
     matricula = "2020ENEL123",
     nome = "Julia",
     periodo = 0
    };
    print(aluno1);
    Aluno aluno2 = new Aluno();
    print(aluno2);
    Aluno aluno3 = new Aluno(2);
    print(aluno3);
    Aluno aluno4 = new Aluno("20212enel0233", "Julia");
    print(aluno4);
    Aluno aluno5 = new Aluno("20201enel543", "Kauan", 3);
    print(aluno5);

  }
}
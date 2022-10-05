using Modelos;

class Aula5 {
class Aula6 {

  public static void Main (string[] args) {
    Aluno aluno1 = new Aluno(0);
@@ -9,7 +9,8 @@ class Aula5 {
    Aluno aluno2 = new Aluno(1);
    aluno2.Cpf = "660.036.460-20";
    Impressora.Imprimir(aluno2);
    Pessoa pessoa1 = new Pessoa();
    //Pessoa pessoa1 = new Pessoa();
    Pessoa pessoa1 = new Professor();
    pessoa1.Cpf = "588.401.710-37";
    Impressora.Imprimir(pessoa1);
    Pessoa pessoa2 = (Pessoa) aluno2;
@@ -19,6 +20,9 @@ class Aula5 {
    Professor professor1 = new Professor();
    professor1.Cpf = "851.152.090-20";
    Impressora.Imprimir(professor1);
    Familiar familiar1 = new Familiar();
    familiar1.Cpf = "069.705.690-20";
    Impressora.Imprimir(familiar1);
  }

}
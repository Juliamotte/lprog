namespace modelos {

class Aluno {
  public string matricula;
  public int periodo;

  public bool Matricular(Disciplina disciplina){
    return this.periodo == disciplina.semestre;
  }
}
  public override bool Validar() {
    return this.Matricula != null &&
      this.Matricula.Length > 0;
  }
}
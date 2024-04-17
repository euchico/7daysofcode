namespace DayTwo;

internal class Paciente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string EstadoSaude { get; set; }
    public Paciente? ProximoPaciente { get; set; }

    public Paciente(int id, string nome, string estadoSaude)
    {
        this.Id = id;
        this.Nome = nome;
        this.EstadoSaude = estadoSaude;
        this.ProximoPaciente = null;
    }
}

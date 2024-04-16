namespace DayTwo;

internal class Paciente
{
    private static int ultimoId = 0;

    public int Id { get; set; }
    public string Nome { get; set; }
    public string EstadoDeSaude { get; set; }
    public int ProximoPaciente { get; set; }

    public Paciente(string Nome, string EstadoDeSaude)
    {
        this.Nome = Nome;
        this.EstadoDeSaude = EstadoDeSaude;
        this.Id = ultimoId++;
    }
}

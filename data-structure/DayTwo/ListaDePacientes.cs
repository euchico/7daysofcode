namespace DayTwo;

internal class ListaDePacientes
{
    public List<Paciente> ListaDePaciente { get; set; }

    public ListaDePacientes()
    {
        ListaDePaciente = new List<Paciente>();
    }

    public void AddPaciente(string Nome, string EstadoDeSaude)
    {
        Paciente item = new Paciente(Nome, EstadoDeSaude);

        ListItems.Add(item);
    }
}

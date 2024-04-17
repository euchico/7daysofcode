namespace DayTwo;

internal class DayTwo
{
    static void Main(string[] args)
    {
        ListaDePacientes listaDePacientes = new ListaDePacientes();

        listaDePacientes.AdicionarPaciente(1, "Giovanna", "Estável");
        listaDePacientes.AdicionarPaciente(2, "Lucas", "Tratamento intensivo");
        listaDePacientes.AdicionarPaciente(3, "Alex", "Crítico");
        listaDePacientes.AdicionarPaciente(4, "Beatriz", "Estável");

        listaDePacientes.RemoverPaciente(3);

        listaDePacientes.ListarPacientes();
    }
}

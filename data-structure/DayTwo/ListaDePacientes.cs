namespace DayTwo;

internal class ListaDePacientes
{
    public Paciente? Head { get; set; }
    public Paciente? Tail { get; set; }
    public List<Paciente> ListaDePaciente { get; set; }

    public ListaDePacientes()
    {
        this.Head = null;
        this.Tail = null;
    }

    public void AdicionarPaciente(int id, string nome, string estadoSaude)
    {
        Paciente novoPaciente = new Paciente(id, nome, estadoSaude);

        if (this.Head == null ) 
        {
            this.Head = novoPaciente;
            this.Tail = novoPaciente;
        }
        else
        {
            this.Tail.ProximoPaciente = novoPaciente;
            this.Tail = novoPaciente;
        }
    }

    public void RemoverPaciente(int id)
    {
        if (this.Head == null) { }
        else if (this.Head.Id == id) 
        { 
            this.Head = this.Head.ProximoPaciente;
            if (this.Head == null)
            {
                this.Tail = null;
            }
        }
        else
        {
            Paciente pacienteAtual = this.Head;

            while (pacienteAtual.ProximoPaciente != null) 
            {
                if (pacienteAtual.ProximoPaciente.Id == id)
                {
                    pacienteAtual.ProximoPaciente = pacienteAtual.ProximoPaciente.ProximoPaciente;

                    if (pacienteAtual.ProximoPaciente == null)
                    {
                        this.Tail = pacienteAtual;
                    }
                }

                pacienteAtual = pacienteAtual.ProximoPaciente;
            }
        }
    }

    public void ListarPacientes()
    {
        if (this.Head == null)
        {
            Console.WriteLine("Não há pacientes nesta lista.");
        }
        else
        {
            Paciente pacienteAtual = this.Head;

            while (pacienteAtual != null)
            {
                Console.WriteLine($"Nome: {pacienteAtual.Nome}, ID: {pacienteAtual.Id}, Estado de saúde: {pacienteAtual.EstadoSaude}");
                pacienteAtual = pacienteAtual.ProximoPaciente;
            }
        }
    }
}

using Cliente.model;

namespace Cliente.view
{
    public class Interface
    {
        private string? _inputName;
        private string? _inputCPF;
        private string? _inputDate;
        private string? _inputIncome;
        private string? _inputStatus;
        private string? _inputNOfDependents;
        private List<string>? _errorList;

        public string InputName
        {
            get { return _inputName; }
            set { _inputName = value; }
        }
        public string InputCPF
        {
            get { return _inputCPF; }
            set { _inputCPF = value; }
        }

        public string InputDate
        {
            get { return _inputDate; }
            set { _inputDate = value; }
        }

        public string InputIncome
        {
            get { return _inputIncome; }
            set { _inputIncome = value; }
        }

        public string InputStatus
        {
            get { return _inputStatus; }
            set { _inputStatus = value; }
        }

        public string InputNOfDependents
        {
            get { return _inputNOfDependents; }
            set { _inputNOfDependents = value; }
        }

        public List<string> ErrorList
        {
            get { return _errorList; }
            set { _errorList = value; }
        }

        public void Title()
        {
            Console.WriteLine("---- BEM-VINDO AO CADASTRO DE CLIENTE -----");
            Console.WriteLine("");
        }
        public void GetName()
        {
            Console.WriteLine("Insira o nome do cliente: ");
            this._inputName = Console.ReadLine();
        }

        public void GetCPF()
        {
            Console.WriteLine("Insira o CPF: ");
            this._inputCPF = Console.ReadLine();
        }

        public void GetDate()
        {
            Console.WriteLine("Insira da data de nascimento (dd/mm/aaaa): ");
            this._inputDate = Console.ReadLine();
        }
        public void GetIncome()
        {
            Console.WriteLine("Insira a renda mensal: ");
            this._inputIncome = Console.ReadLine();
        }

        public void GetStatus()
        {
            Console.WriteLine("Insira o estado civil (C, S, V ou D):  ");
            this._inputStatus = Console.ReadLine();
        }

        public void GetDependents()
        {
            Console.WriteLine("Insira o número de dependentes (de 0 a 10):  ");
            this._inputNOfDependents = Console.ReadLine();
        }

        public void ShowData(Client c)
        {
            Console.WriteLine("---- CLIENTE CADASTRADO ----");
            Console.WriteLine("");
            Console.WriteLine($"Nome: {c.Nome}");
            Console.WriteLine($"CPF: {c.CPF}");
            Console.WriteLine($"Data de nascimento: {c.Dt_Nascimento}");
            Console.WriteLine($"Renda mensal: {c.Renda_Mensal}");
            Console.WriteLine($"Estado civil: {c.Estado_Civil}");
            Console.WriteLine($"Número de dependentes: {c.Dependentes}");

        }

        public void ErrorMessages(int n)
        {
            this._errorList = new List<string>
            {
                $"Erro no nome: {_inputName} -> O nome não pode ser vazio!" ,
                $"Erro no nome: {_inputName} -> O nome deve possuir pelo menos 5 caracteres",
                $"Erro no CPF: {_inputCPF} -> Favor insira um CPF válido (11 caracteres, apenas números).",
                $"Erro na data de nascimento: {_inputDate} -> O cliente deve ter pelo menos 18 anos!",
                $"Erro na data de nascimento: { _inputDate} -> Favor insira uma data no formato DD,MM,AAAA. ",
                $"Erro na renda mensal: {_inputIncome} -> Insira um valor válido em $.",
                $"Erro no estado civil: {_inputStatus} -> Favor insira um estado civil válido (C, S, V ou D).",
                $"Erro no número de dependentes: {_inputNOfDependents} -> Favor insira um valor válido (entre 0 e 10)."
            };
            Console.WriteLine($"{ErrorList[n]}");
        }
    }
}

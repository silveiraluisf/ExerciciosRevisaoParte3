using Cliente.model;
using Cliente.view;

namespace Cliente.controller
{
    public class ClientController
    {
        public static void ValidatorMaster(List<Data> clients, Interface a, Client c)
        {
            for (int i = 0; i < clients?.Count; i++)
            {
                Erro e = new();
                Data r = clients[i];
                NameValidate(a, c, r, e);
                CPFValidate(a, c, r, e);
                BirthDateValidate(a, c, r, e);
                IncomeValidate(a, c, r, e);
                StatusValidate(a, c, r, e);
                DependentsValidate(a, c, r, e);
                SerializationController.SerializeErrorsJson(r, e);
            }
        }

        public static void NameValidate(Interface a, Client c, Data r, Erro e)
        {
            string? name = r?.Nome;
            switch (name?.Length)
            {
                case 0:
                    e.Nome = "O nome não pode ser vazio";
                    break;
                case < 5:
                    e.Nome = "O nome deve ter pelo menos 5 caracteres";
                    break;
                case >= 5:
                    c.Nome = name;
                    //Console.WriteLine($"{c.Nome} VALIDADO ");
                    break;
            }
        }

        public static void CPFValidate(Interface a, Client c, Data r, Erro e)
        {
            string? inputCPF = r?.CPF;
            long outputCPF;
            switch (inputCPF?.Length)
            {
                case 11:
                    bool parseSuccess = long.TryParse(inputCPF, out outputCPF);
                    if (parseSuccess)
                    {
                        c.CPF = outputCPF;
                        //Console.WriteLine($"{c.CPF} VALIDADO ");
                    }
                    else
                    {
                        e.Cpf = "Favor insira um CPF valido(11 caracteres, apenas numeros).";
                    }
                    break;
                default:
                    e.Cpf = "Favor insira um CPF valido(11 caracteres, apenas numeros).";
                    break;
            }
        }

        public static void BirthDateValidate(Interface a, Client c, Data r, Erro e)
        {
            string? inputDate = r?.Dt_Nascimento;
            DateTime now = DateTime.Now;
            TimeSpan eighteenYears = new(6574, 0, 0, 0);
            bool parseSuccess = DateTime.TryParse(inputDate, out DateTime outputDate);
            if (parseSuccess)
            {
                c.Dt_Nascimento = Convert.ToDateTime(outputDate);
                TimeIntervalController timeInterval = new(outputDate, now);
                if (timeInterval.Duration > eighteenYears)
                {
                    outputDate = (DateTime)c.Dt_Nascimento;
                    //Console.WriteLine($"{c.Dt_Nascimento} VALIDADA ");
                }
                else
                {
                    e.Dt_nascimento = "O cliente deve ter pelo menos 18 anos!";
                }
            }
            else
            {
                e.Dt_nascimento = "Favor insira uma data no formato DD,MM,AAAA.";
            }
        }

        public static void IncomeValidate(Interface a, Client c, Data r, Erro e)
        {
            string? inputIncome = r?.Renda_Mensal;
            bool parseSuccess = float.TryParse(inputIncome, out float outputIncome);
            if (parseSuccess)
            {
                c.Renda_Mensal = (float)Convert.ToDouble(outputIncome);
                //Console.WriteLine($"{c.Renda_Mensal} VALIDADA ");
            }
            else
            {
                //Console.WriteLine($"{r.Renda_Mensal} PROBLEMA ");
                e.Renda_mensal = "Insira um valor valido em $.";
            }
        }

        public static void StatusValidate(Interface a, Client c, Data r, Erro e)
        {
            string? inputStatus = r?.Estado_Civil;
            bool parseSuccess = char.TryParse(inputStatus, out char outputStatus);
            if (parseSuccess)
            {
                Convert.ToChar(outputStatus);
                switch (char.ToUpper(outputStatus))
                {
                    case 'C':
                        c.Estado_Civil = 'C';
                        //Console.WriteLine($"{c.Estado_Civil} VALIDADO ");
                        break;
                    case 'S':
                        c.Estado_Civil = 'S';
                        //Console.WriteLine($"{c.Estado_Civil} VALIDADO ");
                        break;
                    case 'V':
                        c.Estado_Civil = 'V';
                        //Console.WriteLine($"{c.Estado_Civil} VALIDADO ");
                        break;
                    case 'D':
                        c.Estado_Civil = 'D';
                        //Console.WriteLine($"{c.Estado_Civil} VALIDADO ");
                        break;
                    default:
                        e.Estado_civil = "Favor insira um estado civil valido (C, S, V ou D).";
                        break;
                }
            }
            else
            {
                e.Estado_civil = "Favor insira um estado civil valido (C, S, V ou D).";
            }
        }

        public static void DependentsValidate(Interface a, Client c, Data r, Erro e)
        {
            string? inputDependents = r?.Dependentes;
            bool parseSuccess = int.TryParse(inputDependents, out int outputDependents);
            if (parseSuccess)
            {
                c.Dependentes = Convert.ToInt32(outputDependents);
                int n = (int)c.Dependentes;
                switch (n)
                {
                    case >= 0 and <= 10:
                        c.Dependentes = outputDependents;
                        //Console.WriteLine($"{c.Dependentes} VALIDADO ");
                        break;
                    default:
                        e.Dependentes = "Favor insira um valor valido (entre 0 e 10).";
                        break;
                }
            }
            else
            {
                e.Dependentes = "Favor insira um valor valido (entre 0 e 10).";
            }
        }
    }     
}
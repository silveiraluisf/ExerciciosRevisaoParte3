using Cliente.model;
using Cliente.view;
using System.Text.Json;

namespace Cliente.controller
{
    public class ClientController
    {
        public void DeserializeJson()
        {
            var path = "C:\\Users\\silve\\source\\repos\\ExerciciosRevisaoParte3\\Cliente\\data\\clientes.json";

            string jsonString;
            _ = new Root();

            jsonString = File.ReadAllText(path); //GetType().Name = String

            //Console.WriteLine(jsonString); //WORKS           

            var clients = JsonSerializer.Deserialize<List<Root>>(jsonString);
            Root? client = clients?.First();
            foreach (Root c in clients)
            {
                Console.WriteLine($"Nome: {c.Nome}");
                //SystemController s = new SystemController();
                //s.OpenInterface();
            }
        }

        public void ShowClient(Interface a, Client c)
        {
            a.ShowData(c);
        }

        public void NameValidate(Interface a, Client c, Root r)
        {
            string? name = r?.Nome;
            switch (name?.Length)
            {
                case 0:
                    //a.ErrorMessages(0);
                    //a.GetName();
                    //NameValidate(a, c);
                    break;
                case < 5:
                    //a.ErrorMessages(1);
                    //a.GetName();
                    //NameValidate(a, c);
                    break;
                case >= 5:
                    c.Nome = name;
                    break;
            }
        }

        public void CPFValidate(Interface a, Client c, Root r)
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
                    }
                    else
                    {
                        //a.ErrorMessages(2);
                        //a.GetCPF();
                        //CPFValidate(a, c);
                    }
                    break;
                default:
                    //a.ErrorMessages(2);
                    //a.GetCPF();
                    //CPFValidate(a, c);
                    break;
            }
        }

        public void BirthDateValidate(Interface a, Client c, Root r)
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
                }
                else
                {
                    //a.ErrorMessages(3);
                    //a.GetDate();
                    //BirthDateValidate(a, c);
                }
            }
            else
            {
                //a.ErrorMessages(4);
                //a.GetDate();
                //BirthDateValidate(a, c);
            }
        }

        public void IncomeValidate(Interface a, Client c, Root r)
        {
            string? inputIncome = r?.Renda_Mensal;
            float outputIncome;
            bool parseSuccess = float.TryParse(inputIncome, out outputIncome);
            if (parseSuccess)
            {
                c.Renda_Mensal = (float)Convert.ToDouble(outputIncome);
            }
            else
            {
                //a.ErrorMessages(5);
                //a.GetIncome();
                //IncomeValidate(a, c);
            }
        }

        public void StatusValidate(Interface a, Client c, Root r)
        {
            string? inputStatus = r?.Estado_Civil;
            char outputStatus;
            bool parseSuccess = char.TryParse(inputStatus, out outputStatus);
            if (parseSuccess)
            {
                Convert.ToChar(outputStatus);
                switch (char.ToUpper(outputStatus))
                {
                    case 'C':
                        c.Estado_Civil = 'C';
                        break;
                    case 'S':
                        c.Estado_Civil = 'S';
                        break;
                    case 'V':
                        c.Estado_Civil = 'V';
                        break;
                    case 'D':
                        c.Estado_Civil = 'D';
                        break;
                    default:
                        //a.ErrorMessages(6);
                        //a.GetStatus();
                        //StatusValidate(a, c);
                        break;
                }
            }
            else
            {
                //a.ErrorMessages(6);
                //a.GetStatus();
                //StatusValidate(a, c);
            }
        }

        public void DependentsValidate(Interface a, Client c, Root r)
        {
            string? inputDependents = r?.Dependentes;
            int outputDependents;
            bool parseSuccess = int.TryParse(inputDependents, out outputDependents);
            if (parseSuccess)
            {
                c.Dependentes = Convert.ToInt32(outputDependents);
                int n = (int)c.Dependentes;
                switch (n)
                {
                    case >= 0 and <= 10:
                        c.Dependentes = outputDependents;
                        break;
                    default:
                        //a.ErrorMessages(7);
                        //a.GetDependents();
                        //DependentsValidate(a, c);
                        break;
                }
            }
            else
            {
                //a.ErrorMessages(7);
                //a.GetDependents();
                //DependentsValidate(a, c);
            }
        }
    }
}
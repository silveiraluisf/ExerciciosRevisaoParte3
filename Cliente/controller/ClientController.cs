using Cliente.model;
using Cliente.view;

namespace Cliente.controller
{
    public class ClientController
    {
        public void AddClientName(Interface a)
        {
            a.GetName();
        }

        public void AddClientCPF(Interface a)
        {
            a.GetCPF();
        }

        public void AddClientBirthDate(Interface a)
        {
            a.GetDate();
        }

        public void AddClientIncome(Interface a)
        {
            a.GetIncome();
        }

        public void AddClientMaritalStatus(Interface a)
        {
            a.GetStatus();
        }

        public void AddNumberOfDependents(Interface a)
        {
            a.GetDependents();
        }

        public void ShowClient(Interface a, Client c)
        {
            a.ShowData(c);
        }

        public void NameValidate(Interface a, Client c)
        {
            string name = a.InputName;
            switch (name.Length)
            {
                case 0:
                    a.ErrorMessages(0);
                    a.GetName();
                    NameValidate(a, c);
                    break;
                case < 5:
                    a.ErrorMessages(1);
                    a.GetName();
                    NameValidate(a, c);
                    break;
                case >= 5:
                    c.Nome = name;
                    break;
            }
        }

        public void CPFValidate(Interface a, Client c)
        {
            string inputCPF = a.InputCPF;
            long outputCPF;
            switch (inputCPF.Length)
            {
                case 11:
                    bool parseSuccess = long.TryParse(inputCPF, out outputCPF);
                    if (parseSuccess)
                    {
                        c.CPF = outputCPF;
                    }
                    else
                    {
                        a.ErrorMessages(2);
                        a.GetCPF();
                        CPFValidate(a, c);
                    }
                    break;
                default:
                    a.ErrorMessages(2);
                    a.GetCPF();
                    CPFValidate(a, c);
                    break;
            }
        }

        public void BirthDateValidate(Interface a, Client c)
        {
            string inputDate = a.InputDate;
            DateTime outputDate;
            DateTime now = DateTime.Now;
            TimeSpan eighteenYears = new TimeSpan(6574, 0, 0, 0);
            bool parseSuccess = DateTime.TryParse(inputDate, out outputDate);
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
                    a.ErrorMessages(3);
                    a.GetDate();
                    BirthDateValidate(a, c);
                }
            }
            else
            {
                a.ErrorMessages(4);
                a.GetDate();
                BirthDateValidate(a, c);
            }
        }

        public void IncomeValidate(Interface a, Client c)
        {
            string inputIncome = a.InputIncome;
            float outputIncome;
            bool parseSuccess = float.TryParse(inputIncome, out outputIncome);
            if (parseSuccess)
            {
                c.Renda_Mensal = (float)Convert.ToDouble(outputIncome);
            }
            else
            {
                a.ErrorMessages(5);
                a.GetIncome();
                IncomeValidate(a, c);
            }
        }

        public void StatusValidate(Interface a, Client c)
        {
            string inputStatus = a.InputStatus;
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
                        a.ErrorMessages(6);
                        a.GetStatus();
                        StatusValidate(a, c);
                        break;
                }
            }
            else
            {
                a.ErrorMessages(6);
                a.GetStatus();
                StatusValidate(a, c);
            }
        }

        public void DependentsValidate(Interface a, Client c)
        {
            string inputDependents = a.InputNOfDependents;
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
                        a.ErrorMessages(7);
                        a.GetDependents();
                        DependentsValidate(a, c);
                        break;
                }
            }
            else
            {
                a.ErrorMessages(7);
                a.GetDependents();
                DependentsValidate(a, c);
            }
        }
    }
}
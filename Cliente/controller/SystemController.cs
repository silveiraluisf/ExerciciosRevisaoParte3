using Cliente.view;
using Cliente.model;

namespace Cliente.controller
{
    internal class SystemController
    {
        public SystemController()
        {
            object value = new ClientController();
        }

        public void OpenInterface()
        {
            ClientController x = new ClientController();
            Interface a = new Interface();
            Client c = new Client();

            a.Title();
            x.AddClientName(a);
            x.AddClientCPF(a);
            x.AddClientBirthDate(a);
            x.AddClientIncome(a);
            x.AddClientMaritalStatus(a);
            x.AddNumberOfDependents(a);
            x.NameValidate(a, c);
            x.CPFValidate(a, c);
            x.BirthDateValidate(a, c);
            x.IncomeValidate(a, c);
            x.StatusValidate(a, c);
            x.DependentsValidate(a, c);
            x.ShowClient(a, c);
        }
    }
}

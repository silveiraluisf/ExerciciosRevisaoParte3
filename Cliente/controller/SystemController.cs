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
            Root r = new Root();

            x.DeserializeJson();
            a.Title();
            //x.AddClientName(a);
            //x.AddClientCPF(a);
            //x.AddClientBirthDate(a);
            //x.AddClientIncome(a);
            //x.AddClientMaritalStatus(a);
            //x.AddNumberOfDependents(a);
            //x.NameValidate(a, c, r);
            //x.CPFValidate(a, c, r);
            //x.BirthDateValidate(a, c, r);
            //x.IncomeValidate(a, c, r);
            //x.StatusValidate(a, c, r);
            //x.DependentsValidate(a, c, r);
            //x.ShowClient(a, c);
        }
    }
}

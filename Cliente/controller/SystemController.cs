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
            List<Root> roots = new List<Root>();
            a.Title();
            ClientController.DeserializeJson();           
            ClientController.ValidatorMaster(roots, a, c);
            //x.ShowClient(a, c);
        }
    }
}

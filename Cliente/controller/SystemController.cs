using Cliente.view;

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
            Interface a = new();
            a.Title();
            ClientController.DeserializeClientsJson();
            //ClientController.SerializeErrorsJson();
        }
    }
}

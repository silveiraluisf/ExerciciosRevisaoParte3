using Cliente.view;

namespace Cliente.controller
{
    internal class SystemController
    {
        public void OpenInterface()
        {
            Interface a = new();
            a.Title();
            SerializationController.DeserializeClientsJson();
        }
    }
}

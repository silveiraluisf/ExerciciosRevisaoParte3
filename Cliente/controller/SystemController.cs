using Cliente.view;

namespace Cliente.controller
{
    internal class SystemController
    {
        public void OpenInterface()
        {
            Interface @interface = new();
            @interface.Title();            
            SerializationController.DeserializeClientsJson();
        }
    }
}

namespace iMessengerCoreAPI.Repo
{
    public class DialoguesClients : IDialoguesClients
    {
        public IReadOnlyList<RGDialogsClients> BuildBase()
        {
            List<RGDialogsClients> listClientsDialogues = new RGDialogsClients().Init();
            
            return listClientsDialogues;
        }
    }
}

namespace iMessengerCoreAPI.Processors
{
    public interface IRequestProcessor
    {
        Guid GetFromRepoDialoguesByClients(List<Guid> ListClients);
    }
}

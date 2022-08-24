namespace iMessengerCoreAPI.Processors
{
    public class RequestProcessor : IRequestProcessor
    {
        private readonly IDialoguesClients _dialoguesClients;

        public RequestProcessor(IDialoguesClients dialoguesBase)
        {
            _dialoguesClients = dialoguesBase;
        }

        public Guid GetFromRepoDialoguesByClients(List<Guid> ListClients)
        {

            var query = _dialoguesClients.BuildBase()
                .GroupBy(id=>id.IDRGDialog)
                .Where(dialog=>ListClients.All(q=>dialog.Any(client=>client.IDClient==q)))
                .ToList();

            if (query.Any())
            {
                return query.FirstOrDefault().Key;
            }
            else
            {
                return Guid.Empty;
            }
        }
    }
}

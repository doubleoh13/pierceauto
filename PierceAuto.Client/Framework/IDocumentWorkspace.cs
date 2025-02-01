namespace PierceAuto.Client.Framework;

internal interface IDocumentWorkspace : IWorkspace
{
    Task Edit(object document);
}
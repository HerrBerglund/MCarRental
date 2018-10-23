using System.ServiceModel;

namespace MCarRentalService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMCarRentalService" in both code and config file together.
    [ServiceContract]
    public interface IMCarRentalService
    {
        [OperationContract]
        string GetMessage(string name);
    }
}
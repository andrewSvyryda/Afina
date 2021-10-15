using System.ServiceModel;
using DTO;

namespace Server
{
    
    [ServiceContract]
    public interface IAuthenticateService
    {
        [OperationContract]
        int Login(LogInDTO data);

        [OperationContract]
        bool Register(RegisterDTO data);
    }
}
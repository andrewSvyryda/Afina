using System.ServiceModel;
using DTO;

namespace Server
{
    
    
    [ServiceContract]
    public interface IAuthenticateService
    {
        [OperationContract]
        bool Login(LogInDTO data);

        [OperationContract]
        bool Register(RegisterDTO data);
    }
}

using System.Runtime.Serialization;

namespace Server
{
    [DataContract]
    public enum AuthenticateResponse {NONE, TEACHER, STUDENT}
}

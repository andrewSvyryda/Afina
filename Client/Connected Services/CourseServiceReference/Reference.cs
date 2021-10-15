﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.CourseServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CourseDTO", Namespace="http://schemas.datacontract.org/2004/07/DTO")]
    [System.SerializableAttribute()]
    public partial class CourseDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CourseServiceReference.ICourseService")]
    public interface ICourseService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/GetCourses", ReplyAction="http://tempuri.org/ICourseService/GetCoursesResponse")]
        Client.CourseServiceReference.CourseDTO[] GetCourses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/GetCourses", ReplyAction="http://tempuri.org/ICourseService/GetCoursesResponse")]
        System.Threading.Tasks.Task<Client.CourseServiceReference.CourseDTO[]> GetCoursesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/CreateCourse", ReplyAction="http://tempuri.org/ICourseService/CreateCourseResponse")]
        void CreateCourse(Client.CourseServiceReference.CourseDTO course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/CreateCourse", ReplyAction="http://tempuri.org/ICourseService/CreateCourseResponse")]
        System.Threading.Tasks.Task CreateCourseAsync(Client.CourseServiceReference.CourseDTO course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/DeleteCourse", ReplyAction="http://tempuri.org/ICourseService/DeleteCourseResponse")]
        bool DeleteCourse(int courseId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/DeleteCourse", ReplyAction="http://tempuri.org/ICourseService/DeleteCourseResponse")]
        System.Threading.Tasks.Task<bool> DeleteCourseAsync(int courseId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/ChangeCourse", ReplyAction="http://tempuri.org/ICourseService/ChangeCourseResponse")]
        void ChangeCourse(int courseId, Client.CourseServiceReference.CourseDTO course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/ChangeCourse", ReplyAction="http://tempuri.org/ICourseService/ChangeCourseResponse")]
        System.Threading.Tasks.Task ChangeCourseAsync(int courseId, Client.CourseServiceReference.CourseDTO course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/GetCoursesByTeacherId", ReplyAction="http://tempuri.org/ICourseService/GetCoursesByTeacherIdResponse")]
        Client.CourseServiceReference.CourseDTO[] GetCoursesByTeacherId(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/GetCoursesByTeacherId", ReplyAction="http://tempuri.org/ICourseService/GetCoursesByTeacherIdResponse")]
        System.Threading.Tasks.Task<Client.CourseServiceReference.CourseDTO[]> GetCoursesByTeacherIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/Subscribe", ReplyAction="http://tempuri.org/ICourseService/SubscribeResponse")]
        bool Subscribe(int userId, int courseId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/Subscribe", ReplyAction="http://tempuri.org/ICourseService/SubscribeResponse")]
        System.Threading.Tasks.Task<bool> SubscribeAsync(int userId, int courseId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICourseServiceChannel : Client.CourseServiceReference.ICourseService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CourseServiceClient : System.ServiceModel.ClientBase<Client.CourseServiceReference.ICourseService>, Client.CourseServiceReference.ICourseService {
        
        public CourseServiceClient() {
        }
        
        public CourseServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CourseServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CourseServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CourseServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client.CourseServiceReference.CourseDTO[] GetCourses() {
            return base.Channel.GetCourses();
        }
        
        public System.Threading.Tasks.Task<Client.CourseServiceReference.CourseDTO[]> GetCoursesAsync() {
            return base.Channel.GetCoursesAsync();
        }
        
        public void CreateCourse(Client.CourseServiceReference.CourseDTO course) {
            base.Channel.CreateCourse(course);
        }
        
        public System.Threading.Tasks.Task CreateCourseAsync(Client.CourseServiceReference.CourseDTO course) {
            return base.Channel.CreateCourseAsync(course);
        }
        
        public bool DeleteCourse(int courseId) {
            return base.Channel.DeleteCourse(courseId);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteCourseAsync(int courseId) {
            return base.Channel.DeleteCourseAsync(courseId);
        }
        
        public void ChangeCourse(int courseId, Client.CourseServiceReference.CourseDTO course) {
            base.Channel.ChangeCourse(courseId, course);
        }
        
        public System.Threading.Tasks.Task ChangeCourseAsync(int courseId, Client.CourseServiceReference.CourseDTO course) {
            return base.Channel.ChangeCourseAsync(courseId, course);
        }
        
        public Client.CourseServiceReference.CourseDTO[] GetCoursesByTeacherId(int id) {
            return base.Channel.GetCoursesByTeacherId(id);
        }
        
        public System.Threading.Tasks.Task<Client.CourseServiceReference.CourseDTO[]> GetCoursesByTeacherIdAsync(int id) {
            return base.Channel.GetCoursesByTeacherIdAsync(id);
        }
        
        public bool Subscribe(int userId, int courseId) {
            return base.Channel.Subscribe(userId, courseId);
        }
        
        public System.Threading.Tasks.Task<bool> SubscribeAsync(int userId, int courseId) {
            return base.Channel.SubscribeAsync(userId, courseId);
        }
    }
}

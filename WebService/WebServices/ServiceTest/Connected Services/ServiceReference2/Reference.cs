﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceTest.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.WebClientSoap")]
    public interface WebClientSoap {
        
        // CODEGEN: Generating message contract since element name GetAllCinemasResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllCinemas", ReplyAction="*")]
        ServiceTest.ServiceReference2.GetAllCinemasResponse GetAllCinemas(ServiceTest.ServiceReference2.GetAllCinemasRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllCinemas", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceTest.ServiceReference2.GetAllCinemasResponse> GetAllCinemasAsync(ServiceTest.ServiceReference2.GetAllCinemasRequest request);
        
        // CODEGEN: Generating message contract since element name cinemaLocation from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCinemaByLocation", ReplyAction="*")]
        ServiceTest.ServiceReference2.GetCinemaByLocationResponse GetCinemaByLocation(ServiceTest.ServiceReference2.GetCinemaByLocationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCinemaByLocation", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceTest.ServiceReference2.GetCinemaByLocationResponse> GetCinemaByLocationAsync(ServiceTest.ServiceReference2.GetCinemaByLocationRequest request);
        
        // CODEGEN: Generating message contract since element name weekDay from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllMoviesDetailsByDay", ReplyAction="*")]
        ServiceTest.ServiceReference2.GetAllMoviesDetailsByDayResponse GetAllMoviesDetailsByDay(ServiceTest.ServiceReference2.GetAllMoviesDetailsByDayRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllMoviesDetailsByDay", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceTest.ServiceReference2.GetAllMoviesDetailsByDayResponse> GetAllMoviesDetailsByDayAsync(ServiceTest.ServiceReference2.GetAllMoviesDetailsByDayRequest request);
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllMoviesDetailsByName", ReplyAction="*")]
        ServiceTest.ServiceReference2.GetAllMoviesDetailsByNameResponse GetAllMoviesDetailsByName(ServiceTest.ServiceReference2.GetAllMoviesDetailsByNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllMoviesDetailsByName", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceTest.ServiceReference2.GetAllMoviesDetailsByNameResponse> GetAllMoviesDetailsByNameAsync(ServiceTest.ServiceReference2.GetAllMoviesDetailsByNameRequest request);
        
        // CODEGEN: Generating message contract since element name details from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateReservation", ReplyAction="*")]
        ServiceTest.ServiceReference2.CreateReservationResponse CreateReservation(ServiceTest.ServiceReference2.CreateReservationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateReservation", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceTest.ServiceReference2.CreateReservationResponse> CreateReservationAsync(ServiceTest.ServiceReference2.CreateReservationRequest request);
        
        // CODEGEN: Generating message contract since element name GetAllReservationsByUserResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllReservationsByUser", ReplyAction="*")]
        ServiceTest.ServiceReference2.GetAllReservationsByUserResponse GetAllReservationsByUser(ServiceTest.ServiceReference2.GetAllReservationsByUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllReservationsByUser", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceTest.ServiceReference2.GetAllReservationsByUserResponse> GetAllReservationsByUserAsync(ServiceTest.ServiceReference2.GetAllReservationsByUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteReservation", ReplyAction="*")]
        bool DeleteReservation(int reservationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteReservation", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> DeleteReservationAsync(int reservationId);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllCinemasRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllCinemas", Namespace="http://tempuri.org/", Order=0)]
        public ServiceTest.ServiceReference2.GetAllCinemasRequestBody Body;
        
        public GetAllCinemasRequest() {
        }
        
        public GetAllCinemasRequest(ServiceTest.ServiceReference2.GetAllCinemasRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllCinemasRequestBody {
        
        public GetAllCinemasRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllCinemasResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllCinemasResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceTest.ServiceReference2.GetAllCinemasResponseBody Body;
        
        public GetAllCinemasResponse() {
        }
        
        public GetAllCinemasResponse(ServiceTest.ServiceReference2.GetAllCinemasResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllCinemasResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceTest.ServiceReference2.ArrayOfString GetAllCinemasResult;
        
        public GetAllCinemasResponseBody() {
        }
        
        public GetAllCinemasResponseBody(ServiceTest.ServiceReference2.ArrayOfString GetAllCinemasResult) {
            this.GetAllCinemasResult = GetAllCinemasResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCinemaByLocationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCinemaByLocation", Namespace="http://tempuri.org/", Order=0)]
        public ServiceTest.ServiceReference2.GetCinemaByLocationRequestBody Body;
        
        public GetCinemaByLocationRequest() {
        }
        
        public GetCinemaByLocationRequest(ServiceTest.ServiceReference2.GetCinemaByLocationRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCinemaByLocationRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string cinemaLocation;
        
        public GetCinemaByLocationRequestBody() {
        }
        
        public GetCinemaByLocationRequestBody(string cinemaLocation) {
            this.cinemaLocation = cinemaLocation;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCinemaByLocationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCinemaByLocationResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceTest.ServiceReference2.GetCinemaByLocationResponseBody Body;
        
        public GetCinemaByLocationResponse() {
        }
        
        public GetCinemaByLocationResponse(ServiceTest.ServiceReference2.GetCinemaByLocationResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCinemaByLocationResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int GetCinemaByLocationResult;
        
        public GetCinemaByLocationResponseBody() {
        }
        
        public GetCinemaByLocationResponseBody(int GetCinemaByLocationResult) {
            this.GetCinemaByLocationResult = GetCinemaByLocationResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllMoviesDetailsByDayRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllMoviesDetailsByDay", Namespace="http://tempuri.org/", Order=0)]
        public ServiceTest.ServiceReference2.GetAllMoviesDetailsByDayRequestBody Body;
        
        public GetAllMoviesDetailsByDayRequest() {
        }
        
        public GetAllMoviesDetailsByDayRequest(ServiceTest.ServiceReference2.GetAllMoviesDetailsByDayRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllMoviesDetailsByDayRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int cinemaId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string weekDay;
        
        public GetAllMoviesDetailsByDayRequestBody() {
        }
        
        public GetAllMoviesDetailsByDayRequestBody(int cinemaId, string weekDay) {
            this.cinemaId = cinemaId;
            this.weekDay = weekDay;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllMoviesDetailsByDayResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllMoviesDetailsByDayResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceTest.ServiceReference2.GetAllMoviesDetailsByDayResponseBody Body;
        
        public GetAllMoviesDetailsByDayResponse() {
        }
        
        public GetAllMoviesDetailsByDayResponse(ServiceTest.ServiceReference2.GetAllMoviesDetailsByDayResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllMoviesDetailsByDayResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceTest.ServiceReference2.ArrayOfString GetAllMoviesDetailsByDayResult;
        
        public GetAllMoviesDetailsByDayResponseBody() {
        }
        
        public GetAllMoviesDetailsByDayResponseBody(ServiceTest.ServiceReference2.ArrayOfString GetAllMoviesDetailsByDayResult) {
            this.GetAllMoviesDetailsByDayResult = GetAllMoviesDetailsByDayResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllMoviesDetailsByNameRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllMoviesDetailsByName", Namespace="http://tempuri.org/", Order=0)]
        public ServiceTest.ServiceReference2.GetAllMoviesDetailsByNameRequestBody Body;
        
        public GetAllMoviesDetailsByNameRequest() {
        }
        
        public GetAllMoviesDetailsByNameRequest(ServiceTest.ServiceReference2.GetAllMoviesDetailsByNameRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllMoviesDetailsByNameRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int cinemaId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string name;
        
        public GetAllMoviesDetailsByNameRequestBody() {
        }
        
        public GetAllMoviesDetailsByNameRequestBody(int cinemaId, string name) {
            this.cinemaId = cinemaId;
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllMoviesDetailsByNameResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllMoviesDetailsByNameResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceTest.ServiceReference2.GetAllMoviesDetailsByNameResponseBody Body;
        
        public GetAllMoviesDetailsByNameResponse() {
        }
        
        public GetAllMoviesDetailsByNameResponse(ServiceTest.ServiceReference2.GetAllMoviesDetailsByNameResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllMoviesDetailsByNameResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceTest.ServiceReference2.ArrayOfString GetAllMoviesDetailsByNameResult;
        
        public GetAllMoviesDetailsByNameResponseBody() {
        }
        
        public GetAllMoviesDetailsByNameResponseBody(ServiceTest.ServiceReference2.ArrayOfString GetAllMoviesDetailsByNameResult) {
            this.GetAllMoviesDetailsByNameResult = GetAllMoviesDetailsByNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateReservationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateReservation", Namespace="http://tempuri.org/", Order=0)]
        public ServiceTest.ServiceReference2.CreateReservationRequestBody Body;
        
        public CreateReservationRequest() {
        }
        
        public CreateReservationRequest(ServiceTest.ServiceReference2.CreateReservationRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateReservationRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceTest.ServiceReference2.ArrayOfString details;
        
        public CreateReservationRequestBody() {
        }
        
        public CreateReservationRequestBody(ServiceTest.ServiceReference2.ArrayOfString details) {
            this.details = details;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateReservationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateReservationResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceTest.ServiceReference2.CreateReservationResponseBody Body;
        
        public CreateReservationResponse() {
        }
        
        public CreateReservationResponse(ServiceTest.ServiceReference2.CreateReservationResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateReservationResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool CreateReservationResult;
        
        public CreateReservationResponseBody() {
        }
        
        public CreateReservationResponseBody(bool CreateReservationResult) {
            this.CreateReservationResult = CreateReservationResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllReservationsByUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllReservationsByUser", Namespace="http://tempuri.org/", Order=0)]
        public ServiceTest.ServiceReference2.GetAllReservationsByUserRequestBody Body;
        
        public GetAllReservationsByUserRequest() {
        }
        
        public GetAllReservationsByUserRequest(ServiceTest.ServiceReference2.GetAllReservationsByUserRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllReservationsByUserRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int userId;
        
        public GetAllReservationsByUserRequestBody() {
        }
        
        public GetAllReservationsByUserRequestBody(int userId) {
            this.userId = userId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllReservationsByUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllReservationsByUserResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceTest.ServiceReference2.GetAllReservationsByUserResponseBody Body;
        
        public GetAllReservationsByUserResponse() {
        }
        
        public GetAllReservationsByUserResponse(ServiceTest.ServiceReference2.GetAllReservationsByUserResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllReservationsByUserResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceTest.ServiceReference2.ArrayOfString GetAllReservationsByUserResult;
        
        public GetAllReservationsByUserResponseBody() {
        }
        
        public GetAllReservationsByUserResponseBody(ServiceTest.ServiceReference2.ArrayOfString GetAllReservationsByUserResult) {
            this.GetAllReservationsByUserResult = GetAllReservationsByUserResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebClientSoapChannel : ServiceTest.ServiceReference2.WebClientSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebClientSoapClient : System.ServiceModel.ClientBase<ServiceTest.ServiceReference2.WebClientSoap>, ServiceTest.ServiceReference2.WebClientSoap {
        
        public WebClientSoapClient() {
        }
        
        public WebClientSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebClientSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebClientSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebClientSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceTest.ServiceReference2.GetAllCinemasResponse ServiceTest.ServiceReference2.WebClientSoap.GetAllCinemas(ServiceTest.ServiceReference2.GetAllCinemasRequest request) {
            return base.Channel.GetAllCinemas(request);
        }
        
        public ServiceTest.ServiceReference2.ArrayOfString GetAllCinemas() {
            ServiceTest.ServiceReference2.GetAllCinemasRequest inValue = new ServiceTest.ServiceReference2.GetAllCinemasRequest();
            inValue.Body = new ServiceTest.ServiceReference2.GetAllCinemasRequestBody();
            ServiceTest.ServiceReference2.GetAllCinemasResponse retVal = ((ServiceTest.ServiceReference2.WebClientSoap)(this)).GetAllCinemas(inValue);
            return retVal.Body.GetAllCinemasResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceTest.ServiceReference2.GetAllCinemasResponse> ServiceTest.ServiceReference2.WebClientSoap.GetAllCinemasAsync(ServiceTest.ServiceReference2.GetAllCinemasRequest request) {
            return base.Channel.GetAllCinemasAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceTest.ServiceReference2.GetAllCinemasResponse> GetAllCinemasAsync() {
            ServiceTest.ServiceReference2.GetAllCinemasRequest inValue = new ServiceTest.ServiceReference2.GetAllCinemasRequest();
            inValue.Body = new ServiceTest.ServiceReference2.GetAllCinemasRequestBody();
            return ((ServiceTest.ServiceReference2.WebClientSoap)(this)).GetAllCinemasAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceTest.ServiceReference2.GetCinemaByLocationResponse ServiceTest.ServiceReference2.WebClientSoap.GetCinemaByLocation(ServiceTest.ServiceReference2.GetCinemaByLocationRequest request) {
            return base.Channel.GetCinemaByLocation(request);
        }
        
        public int GetCinemaByLocation(string cinemaLocation) {
            ServiceTest.ServiceReference2.GetCinemaByLocationRequest inValue = new ServiceTest.ServiceReference2.GetCinemaByLocationRequest();
            inValue.Body = new ServiceTest.ServiceReference2.GetCinemaByLocationRequestBody();
            inValue.Body.cinemaLocation = cinemaLocation;
            ServiceTest.ServiceReference2.GetCinemaByLocationResponse retVal = ((ServiceTest.ServiceReference2.WebClientSoap)(this)).GetCinemaByLocation(inValue);
            return retVal.Body.GetCinemaByLocationResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceTest.ServiceReference2.GetCinemaByLocationResponse> ServiceTest.ServiceReference2.WebClientSoap.GetCinemaByLocationAsync(ServiceTest.ServiceReference2.GetCinemaByLocationRequest request) {
            return base.Channel.GetCinemaByLocationAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceTest.ServiceReference2.GetCinemaByLocationResponse> GetCinemaByLocationAsync(string cinemaLocation) {
            ServiceTest.ServiceReference2.GetCinemaByLocationRequest inValue = new ServiceTest.ServiceReference2.GetCinemaByLocationRequest();
            inValue.Body = new ServiceTest.ServiceReference2.GetCinemaByLocationRequestBody();
            inValue.Body.cinemaLocation = cinemaLocation;
            return ((ServiceTest.ServiceReference2.WebClientSoap)(this)).GetCinemaByLocationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceTest.ServiceReference2.GetAllMoviesDetailsByDayResponse ServiceTest.ServiceReference2.WebClientSoap.GetAllMoviesDetailsByDay(ServiceTest.ServiceReference2.GetAllMoviesDetailsByDayRequest request) {
            return base.Channel.GetAllMoviesDetailsByDay(request);
        }
        
        public ServiceTest.ServiceReference2.ArrayOfString GetAllMoviesDetailsByDay(int cinemaId, string weekDay) {
            ServiceTest.ServiceReference2.GetAllMoviesDetailsByDayRequest inValue = new ServiceTest.ServiceReference2.GetAllMoviesDetailsByDayRequest();
            inValue.Body = new ServiceTest.ServiceReference2.GetAllMoviesDetailsByDayRequestBody();
            inValue.Body.cinemaId = cinemaId;
            inValue.Body.weekDay = weekDay;
            ServiceTest.ServiceReference2.GetAllMoviesDetailsByDayResponse retVal = ((ServiceTest.ServiceReference2.WebClientSoap)(this)).GetAllMoviesDetailsByDay(inValue);
            return retVal.Body.GetAllMoviesDetailsByDayResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceTest.ServiceReference2.GetAllMoviesDetailsByDayResponse> ServiceTest.ServiceReference2.WebClientSoap.GetAllMoviesDetailsByDayAsync(ServiceTest.ServiceReference2.GetAllMoviesDetailsByDayRequest request) {
            return base.Channel.GetAllMoviesDetailsByDayAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceTest.ServiceReference2.GetAllMoviesDetailsByDayResponse> GetAllMoviesDetailsByDayAsync(int cinemaId, string weekDay) {
            ServiceTest.ServiceReference2.GetAllMoviesDetailsByDayRequest inValue = new ServiceTest.ServiceReference2.GetAllMoviesDetailsByDayRequest();
            inValue.Body = new ServiceTest.ServiceReference2.GetAllMoviesDetailsByDayRequestBody();
            inValue.Body.cinemaId = cinemaId;
            inValue.Body.weekDay = weekDay;
            return ((ServiceTest.ServiceReference2.WebClientSoap)(this)).GetAllMoviesDetailsByDayAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceTest.ServiceReference2.GetAllMoviesDetailsByNameResponse ServiceTest.ServiceReference2.WebClientSoap.GetAllMoviesDetailsByName(ServiceTest.ServiceReference2.GetAllMoviesDetailsByNameRequest request) {
            return base.Channel.GetAllMoviesDetailsByName(request);
        }
        
        public ServiceTest.ServiceReference2.ArrayOfString GetAllMoviesDetailsByName(int cinemaId, string name) {
            ServiceTest.ServiceReference2.GetAllMoviesDetailsByNameRequest inValue = new ServiceTest.ServiceReference2.GetAllMoviesDetailsByNameRequest();
            inValue.Body = new ServiceTest.ServiceReference2.GetAllMoviesDetailsByNameRequestBody();
            inValue.Body.cinemaId = cinemaId;
            inValue.Body.name = name;
            ServiceTest.ServiceReference2.GetAllMoviesDetailsByNameResponse retVal = ((ServiceTest.ServiceReference2.WebClientSoap)(this)).GetAllMoviesDetailsByName(inValue);
            return retVal.Body.GetAllMoviesDetailsByNameResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceTest.ServiceReference2.GetAllMoviesDetailsByNameResponse> ServiceTest.ServiceReference2.WebClientSoap.GetAllMoviesDetailsByNameAsync(ServiceTest.ServiceReference2.GetAllMoviesDetailsByNameRequest request) {
            return base.Channel.GetAllMoviesDetailsByNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceTest.ServiceReference2.GetAllMoviesDetailsByNameResponse> GetAllMoviesDetailsByNameAsync(int cinemaId, string name) {
            ServiceTest.ServiceReference2.GetAllMoviesDetailsByNameRequest inValue = new ServiceTest.ServiceReference2.GetAllMoviesDetailsByNameRequest();
            inValue.Body = new ServiceTest.ServiceReference2.GetAllMoviesDetailsByNameRequestBody();
            inValue.Body.cinemaId = cinemaId;
            inValue.Body.name = name;
            return ((ServiceTest.ServiceReference2.WebClientSoap)(this)).GetAllMoviesDetailsByNameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceTest.ServiceReference2.CreateReservationResponse ServiceTest.ServiceReference2.WebClientSoap.CreateReservation(ServiceTest.ServiceReference2.CreateReservationRequest request) {
            return base.Channel.CreateReservation(request);
        }
        
        public bool CreateReservation(ServiceTest.ServiceReference2.ArrayOfString details) {
            ServiceTest.ServiceReference2.CreateReservationRequest inValue = new ServiceTest.ServiceReference2.CreateReservationRequest();
            inValue.Body = new ServiceTest.ServiceReference2.CreateReservationRequestBody();
            inValue.Body.details = details;
            ServiceTest.ServiceReference2.CreateReservationResponse retVal = ((ServiceTest.ServiceReference2.WebClientSoap)(this)).CreateReservation(inValue);
            return retVal.Body.CreateReservationResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceTest.ServiceReference2.CreateReservationResponse> ServiceTest.ServiceReference2.WebClientSoap.CreateReservationAsync(ServiceTest.ServiceReference2.CreateReservationRequest request) {
            return base.Channel.CreateReservationAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceTest.ServiceReference2.CreateReservationResponse> CreateReservationAsync(ServiceTest.ServiceReference2.ArrayOfString details) {
            ServiceTest.ServiceReference2.CreateReservationRequest inValue = new ServiceTest.ServiceReference2.CreateReservationRequest();
            inValue.Body = new ServiceTest.ServiceReference2.CreateReservationRequestBody();
            inValue.Body.details = details;
            return ((ServiceTest.ServiceReference2.WebClientSoap)(this)).CreateReservationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceTest.ServiceReference2.GetAllReservationsByUserResponse ServiceTest.ServiceReference2.WebClientSoap.GetAllReservationsByUser(ServiceTest.ServiceReference2.GetAllReservationsByUserRequest request) {
            return base.Channel.GetAllReservationsByUser(request);
        }
        
        public ServiceTest.ServiceReference2.ArrayOfString GetAllReservationsByUser(int userId) {
            ServiceTest.ServiceReference2.GetAllReservationsByUserRequest inValue = new ServiceTest.ServiceReference2.GetAllReservationsByUserRequest();
            inValue.Body = new ServiceTest.ServiceReference2.GetAllReservationsByUserRequestBody();
            inValue.Body.userId = userId;
            ServiceTest.ServiceReference2.GetAllReservationsByUserResponse retVal = ((ServiceTest.ServiceReference2.WebClientSoap)(this)).GetAllReservationsByUser(inValue);
            return retVal.Body.GetAllReservationsByUserResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceTest.ServiceReference2.GetAllReservationsByUserResponse> ServiceTest.ServiceReference2.WebClientSoap.GetAllReservationsByUserAsync(ServiceTest.ServiceReference2.GetAllReservationsByUserRequest request) {
            return base.Channel.GetAllReservationsByUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceTest.ServiceReference2.GetAllReservationsByUserResponse> GetAllReservationsByUserAsync(int userId) {
            ServiceTest.ServiceReference2.GetAllReservationsByUserRequest inValue = new ServiceTest.ServiceReference2.GetAllReservationsByUserRequest();
            inValue.Body = new ServiceTest.ServiceReference2.GetAllReservationsByUserRequestBody();
            inValue.Body.userId = userId;
            return ((ServiceTest.ServiceReference2.WebClientSoap)(this)).GetAllReservationsByUserAsync(inValue);
        }
        
        public bool DeleteReservation(int reservationId) {
            return base.Channel.DeleteReservation(reservationId);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteReservationAsync(int reservationId) {
            return base.Channel.DeleteReservationAsync(reservationId);
        }
    }
}

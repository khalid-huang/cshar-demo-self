// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ProcessGrpcService.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ProcessService {
  public static partial class ProcessGrpcSdkService
  {
    static readonly string __ServiceName = "processService.ProcessGrpcSdkService";

    static readonly grpc::Marshaller<global::ProcessService.HealthCheckRequest> __Marshaller_processService_HealthCheckRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ProcessService.HealthCheckRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ProcessService.HealthCheckResponse> __Marshaller_processService_HealthCheckResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ProcessService.HealthCheckResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ProcessService.StartServerSessionRequest> __Marshaller_processService_StartServerSessionRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ProcessService.StartServerSessionRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ProcessService.ProcessResponse> __Marshaller_processService_ProcessResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ProcessService.ProcessResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ProcessService.ProcessTerminateRequest> __Marshaller_processService_ProcessTerminateRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ProcessService.ProcessTerminateRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::ProcessService.HealthCheckRequest, global::ProcessService.HealthCheckResponse> __Method_OnHealthCheck = new grpc::Method<global::ProcessService.HealthCheckRequest, global::ProcessService.HealthCheckResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "OnHealthCheck",
        __Marshaller_processService_HealthCheckRequest,
        __Marshaller_processService_HealthCheckResponse);

    static readonly grpc::Method<global::ProcessService.StartServerSessionRequest, global::ProcessService.ProcessResponse> __Method_OnStartServerSession = new grpc::Method<global::ProcessService.StartServerSessionRequest, global::ProcessService.ProcessResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "OnStartServerSession",
        __Marshaller_processService_StartServerSessionRequest,
        __Marshaller_processService_ProcessResponse);

    static readonly grpc::Method<global::ProcessService.ProcessTerminateRequest, global::ProcessService.ProcessResponse> __Method_OnProcessTerminate = new grpc::Method<global::ProcessService.ProcessTerminateRequest, global::ProcessService.ProcessResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "OnProcessTerminate",
        __Marshaller_processService_ProcessTerminateRequest,
        __Marshaller_processService_ProcessResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ProcessService.ProcessGrpcServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ProcessGrpcSdkService</summary>
    [grpc::BindServiceMethod(typeof(ProcessGrpcSdkService), "BindService")]
    public abstract partial class ProcessGrpcSdkServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::ProcessService.HealthCheckResponse> OnHealthCheck(global::ProcessService.HealthCheckRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::ProcessService.ProcessResponse> OnStartServerSession(global::ProcessService.StartServerSessionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::ProcessService.ProcessResponse> OnProcessTerminate(global::ProcessService.ProcessTerminateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ProcessGrpcSdkService</summary>
    public partial class ProcessGrpcSdkServiceClient : grpc::ClientBase<ProcessGrpcSdkServiceClient>
    {
      /// <summary>Creates a new client for ProcessGrpcSdkService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ProcessGrpcSdkServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ProcessGrpcSdkService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ProcessGrpcSdkServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ProcessGrpcSdkServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ProcessGrpcSdkServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::ProcessService.HealthCheckResponse OnHealthCheck(global::ProcessService.HealthCheckRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OnHealthCheck(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ProcessService.HealthCheckResponse OnHealthCheck(global::ProcessService.HealthCheckRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_OnHealthCheck, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ProcessService.HealthCheckResponse> OnHealthCheckAsync(global::ProcessService.HealthCheckRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OnHealthCheckAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ProcessService.HealthCheckResponse> OnHealthCheckAsync(global::ProcessService.HealthCheckRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_OnHealthCheck, null, options, request);
      }
      public virtual global::ProcessService.ProcessResponse OnStartServerSession(global::ProcessService.StartServerSessionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OnStartServerSession(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ProcessService.ProcessResponse OnStartServerSession(global::ProcessService.StartServerSessionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_OnStartServerSession, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ProcessService.ProcessResponse> OnStartServerSessionAsync(global::ProcessService.StartServerSessionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OnStartServerSessionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ProcessService.ProcessResponse> OnStartServerSessionAsync(global::ProcessService.StartServerSessionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_OnStartServerSession, null, options, request);
      }
      public virtual global::ProcessService.ProcessResponse OnProcessTerminate(global::ProcessService.ProcessTerminateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OnProcessTerminate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ProcessService.ProcessResponse OnProcessTerminate(global::ProcessService.ProcessTerminateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_OnProcessTerminate, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ProcessService.ProcessResponse> OnProcessTerminateAsync(global::ProcessService.ProcessTerminateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OnProcessTerminateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ProcessService.ProcessResponse> OnProcessTerminateAsync(global::ProcessService.ProcessTerminateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_OnProcessTerminate, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ProcessGrpcSdkServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ProcessGrpcSdkServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ProcessGrpcSdkServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_OnHealthCheck, serviceImpl.OnHealthCheck)
          .AddMethod(__Method_OnStartServerSession, serviceImpl.OnStartServerSession)
          .AddMethod(__Method_OnProcessTerminate, serviceImpl.OnProcessTerminate).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ProcessGrpcSdkServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_OnHealthCheck, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProcessService.HealthCheckRequest, global::ProcessService.HealthCheckResponse>(serviceImpl.OnHealthCheck));
      serviceBinder.AddMethod(__Method_OnStartServerSession, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProcessService.StartServerSessionRequest, global::ProcessService.ProcessResponse>(serviceImpl.OnStartServerSession));
      serviceBinder.AddMethod(__Method_OnProcessTerminate, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProcessService.ProcessTerminateRequest, global::ProcessService.ProcessResponse>(serviceImpl.OnProcessTerminate));
    }

  }
}
#endregion

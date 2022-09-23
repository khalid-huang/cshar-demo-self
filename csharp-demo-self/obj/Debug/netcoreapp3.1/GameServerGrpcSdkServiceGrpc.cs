// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GameServerGrpcSdkService.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Tencentcloud.Gse.Grpcsdk {
  public static partial class GameServerGrpcSdkService
  {
    static readonly string __ServiceName = "tencentcloud.gse.grpcsdk.GameServerGrpcSdkService";

    static readonly grpc::Marshaller<global::Tencentcloud.Gse.Grpcsdk.HealthCheckRequest> __Marshaller_tencentcloud_gse_grpcsdk_HealthCheckRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tencentcloud.Gse.Grpcsdk.HealthCheckRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Tencentcloud.Gse.Grpcsdk.HealthCheckResponse> __Marshaller_tencentcloud_gse_grpcsdk_HealthCheckResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tencentcloud.Gse.Grpcsdk.HealthCheckResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Tencentcloud.Gse.Grpcsdk.StartGameServerSessionRequest> __Marshaller_tencentcloud_gse_grpcsdk_StartGameServerSessionRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tencentcloud.Gse.Grpcsdk.StartGameServerSessionRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Tencentcloud.Gse.Grpcsdk.GseResponse> __Marshaller_tencentcloud_gse_grpcsdk_GseResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tencentcloud.Gse.Grpcsdk.GseResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Tencentcloud.Gse.Grpcsdk.ProcessTerminateRequest> __Marshaller_tencentcloud_gse_grpcsdk_ProcessTerminateRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tencentcloud.Gse.Grpcsdk.ProcessTerminateRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::Tencentcloud.Gse.Grpcsdk.HealthCheckRequest, global::Tencentcloud.Gse.Grpcsdk.HealthCheckResponse> __Method_OnHealthCheck = new grpc::Method<global::Tencentcloud.Gse.Grpcsdk.HealthCheckRequest, global::Tencentcloud.Gse.Grpcsdk.HealthCheckResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "OnHealthCheck",
        __Marshaller_tencentcloud_gse_grpcsdk_HealthCheckRequest,
        __Marshaller_tencentcloud_gse_grpcsdk_HealthCheckResponse);

    static readonly grpc::Method<global::Tencentcloud.Gse.Grpcsdk.StartGameServerSessionRequest, global::Tencentcloud.Gse.Grpcsdk.GseResponse> __Method_OnStartGameServerSession = new grpc::Method<global::Tencentcloud.Gse.Grpcsdk.StartGameServerSessionRequest, global::Tencentcloud.Gse.Grpcsdk.GseResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "OnStartGameServerSession",
        __Marshaller_tencentcloud_gse_grpcsdk_StartGameServerSessionRequest,
        __Marshaller_tencentcloud_gse_grpcsdk_GseResponse);

    static readonly grpc::Method<global::Tencentcloud.Gse.Grpcsdk.ProcessTerminateRequest, global::Tencentcloud.Gse.Grpcsdk.GseResponse> __Method_OnProcessTerminate = new grpc::Method<global::Tencentcloud.Gse.Grpcsdk.ProcessTerminateRequest, global::Tencentcloud.Gse.Grpcsdk.GseResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "OnProcessTerminate",
        __Marshaller_tencentcloud_gse_grpcsdk_ProcessTerminateRequest,
        __Marshaller_tencentcloud_gse_grpcsdk_GseResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Tencentcloud.Gse.Grpcsdk.GameServerGrpcSdkServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GameServerGrpcSdkService</summary>
    [grpc::BindServiceMethod(typeof(GameServerGrpcSdkService), "BindService")]
    public abstract partial class GameServerGrpcSdkServiceBase
    {
      /// <summary>
      /// 接收健康检查请求
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Tencentcloud.Gse.Grpcsdk.HealthCheckResponse> OnHealthCheck(global::Tencentcloud.Gse.Grpcsdk.HealthCheckRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// 接收游戏会话
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Tencentcloud.Gse.Grpcsdk.GseResponse> OnStartGameServerSession(global::Tencentcloud.Gse.Grpcsdk.StartGameServerSessionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// 结束游戏进程
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Tencentcloud.Gse.Grpcsdk.GseResponse> OnProcessTerminate(global::Tencentcloud.Gse.Grpcsdk.ProcessTerminateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GameServerGrpcSdkService</summary>
    public partial class GameServerGrpcSdkServiceClient : grpc::ClientBase<GameServerGrpcSdkServiceClient>
    {
      /// <summary>Creates a new client for GameServerGrpcSdkService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GameServerGrpcSdkServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GameServerGrpcSdkService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GameServerGrpcSdkServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GameServerGrpcSdkServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GameServerGrpcSdkServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// 接收健康检查请求
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tencentcloud.Gse.Grpcsdk.HealthCheckResponse OnHealthCheck(global::Tencentcloud.Gse.Grpcsdk.HealthCheckRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OnHealthCheck(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// 接收健康检查请求
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tencentcloud.Gse.Grpcsdk.HealthCheckResponse OnHealthCheck(global::Tencentcloud.Gse.Grpcsdk.HealthCheckRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_OnHealthCheck, null, options, request);
      }
      /// <summary>
      /// 接收健康检查请求
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tencentcloud.Gse.Grpcsdk.HealthCheckResponse> OnHealthCheckAsync(global::Tencentcloud.Gse.Grpcsdk.HealthCheckRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OnHealthCheckAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// 接收健康检查请求
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tencentcloud.Gse.Grpcsdk.HealthCheckResponse> OnHealthCheckAsync(global::Tencentcloud.Gse.Grpcsdk.HealthCheckRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_OnHealthCheck, null, options, request);
      }
      /// <summary>
      /// 接收游戏会话
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tencentcloud.Gse.Grpcsdk.GseResponse OnStartGameServerSession(global::Tencentcloud.Gse.Grpcsdk.StartGameServerSessionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OnStartGameServerSession(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// 接收游戏会话
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tencentcloud.Gse.Grpcsdk.GseResponse OnStartGameServerSession(global::Tencentcloud.Gse.Grpcsdk.StartGameServerSessionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_OnStartGameServerSession, null, options, request);
      }
      /// <summary>
      /// 接收游戏会话
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tencentcloud.Gse.Grpcsdk.GseResponse> OnStartGameServerSessionAsync(global::Tencentcloud.Gse.Grpcsdk.StartGameServerSessionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OnStartGameServerSessionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// 接收游戏会话
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tencentcloud.Gse.Grpcsdk.GseResponse> OnStartGameServerSessionAsync(global::Tencentcloud.Gse.Grpcsdk.StartGameServerSessionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_OnStartGameServerSession, null, options, request);
      }
      /// <summary>
      /// 结束游戏进程
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tencentcloud.Gse.Grpcsdk.GseResponse OnProcessTerminate(global::Tencentcloud.Gse.Grpcsdk.ProcessTerminateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OnProcessTerminate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// 结束游戏进程
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tencentcloud.Gse.Grpcsdk.GseResponse OnProcessTerminate(global::Tencentcloud.Gse.Grpcsdk.ProcessTerminateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_OnProcessTerminate, null, options, request);
      }
      /// <summary>
      /// 结束游戏进程
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tencentcloud.Gse.Grpcsdk.GseResponse> OnProcessTerminateAsync(global::Tencentcloud.Gse.Grpcsdk.ProcessTerminateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OnProcessTerminateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// 结束游戏进程
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tencentcloud.Gse.Grpcsdk.GseResponse> OnProcessTerminateAsync(global::Tencentcloud.Gse.Grpcsdk.ProcessTerminateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_OnProcessTerminate, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GameServerGrpcSdkServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GameServerGrpcSdkServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GameServerGrpcSdkServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_OnHealthCheck, serviceImpl.OnHealthCheck)
          .AddMethod(__Method_OnStartGameServerSession, serviceImpl.OnStartGameServerSession)
          .AddMethod(__Method_OnProcessTerminate, serviceImpl.OnProcessTerminate).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GameServerGrpcSdkServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_OnHealthCheck, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Tencentcloud.Gse.Grpcsdk.HealthCheckRequest, global::Tencentcloud.Gse.Grpcsdk.HealthCheckResponse>(serviceImpl.OnHealthCheck));
      serviceBinder.AddMethod(__Method_OnStartGameServerSession, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Tencentcloud.Gse.Grpcsdk.StartGameServerSessionRequest, global::Tencentcloud.Gse.Grpcsdk.GseResponse>(serviceImpl.OnStartGameServerSession));
      serviceBinder.AddMethod(__Method_OnProcessTerminate, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Tencentcloud.Gse.Grpcsdk.ProcessTerminateRequest, global::Tencentcloud.Gse.Grpcsdk.GseResponse>(serviceImpl.OnProcessTerminate));
    }

  }
}
#endregion

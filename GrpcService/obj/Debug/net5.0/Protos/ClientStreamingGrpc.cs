// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/ClientStreaming.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService.Protos {
  public static partial class ClientSteaming
  {
    static readonly string __ServiceName = "ClientSteaming.ClientSteaming";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::GrpcService.Protos.ClientSteamingMessageRequest> __Marshaller_ClientSteaming_ClientSteamingMessageRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.Protos.ClientSteamingMessageRequest.Parser));
    static readonly grpc::Marshaller<global::GrpcService.Protos.ClientSteamingMessageReply> __Marshaller_ClientSteaming_ClientSteamingMessageReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.Protos.ClientSteamingMessageReply.Parser));

    static readonly grpc::Method<global::GrpcService.Protos.ClientSteamingMessageRequest, global::GrpcService.Protos.ClientSteamingMessageReply> __Method_SendMessage = new grpc::Method<global::GrpcService.Protos.ClientSteamingMessageRequest, global::GrpcService.Protos.ClientSteamingMessageReply>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "SendMessage",
        __Marshaller_ClientSteaming_ClientSteamingMessageRequest,
        __Marshaller_ClientSteaming_ClientSteamingMessageReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.Protos.ClientStreamingReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ClientSteaming</summary>
    [grpc::BindServiceMethod(typeof(ClientSteaming), "BindService")]
    public abstract partial class ClientSteamingBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Protos.ClientSteamingMessageReply> SendMessage(grpc::IAsyncStreamReader<global::GrpcService.Protos.ClientSteamingMessageRequest> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ClientSteamingBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SendMessage, serviceImpl.SendMessage).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ClientSteamingBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SendMessage, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::GrpcService.Protos.ClientSteamingMessageRequest, global::GrpcService.Protos.ClientSteamingMessageReply>(serviceImpl.SendMessage));
    }

  }
}
#endregion

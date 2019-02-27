// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: hierarchy/grpcapi.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace SKF.Enlight.API.Hierarchy {
  public static partial class Hierarchy
  {
    static readonly string __ServiceName = "grpcapi.Hierarchy";

    static readonly grpc::Marshaller<global::SKF.Enlight.API.Common.Void> __Marshaller_common_Void = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Common.Void.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Common.PrimitiveString> __Marshaller_common_PrimitiveString = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Common.PrimitiveString.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Hierarchy.Node> __Marshaller_grpcapi_Node = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Hierarchy.Node.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Hierarchy.Nodes> __Marshaller_grpcapi_Nodes = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Hierarchy.Nodes.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Hierarchy.GetAncestorsInput> __Marshaller_grpcapi_GetAncestorsInput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Hierarchy.GetAncestorsInput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Hierarchy.GetAncestorsOutput> __Marshaller_grpcapi_GetAncestorsOutput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Hierarchy.GetAncestorsOutput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Common.Origin> __Marshaller_common_Origin = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Common.Origin.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Hierarchy.SaveNodeInput> __Marshaller_grpcapi_SaveNodeInput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Hierarchy.SaveNodeInput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Hierarchy.DeleteNodeInput> __Marshaller_grpcapi_DeleteNodeInput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Hierarchy.DeleteNodeInput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Hierarchy.GetEventsInput> __Marshaller_grpcapi_GetEventsInput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Hierarchy.GetEventsInput.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SKF.Enlight.API.Hierarchy.GetEventsOutput> __Marshaller_grpcapi_GetEventsOutput = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SKF.Enlight.API.Hierarchy.GetEventsOutput.Parser.ParseFrom);

    static readonly grpc::Method<global::SKF.Enlight.API.Common.Void, global::SKF.Enlight.API.Common.PrimitiveString> __Method_DeepPing = new grpc::Method<global::SKF.Enlight.API.Common.Void, global::SKF.Enlight.API.Common.PrimitiveString>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeepPing",
        __Marshaller_common_Void,
        __Marshaller_common_PrimitiveString);

    static readonly grpc::Method<global::SKF.Enlight.API.Common.PrimitiveString, global::SKF.Enlight.API.Hierarchy.Node> __Method_GetNode = new grpc::Method<global::SKF.Enlight.API.Common.PrimitiveString, global::SKF.Enlight.API.Hierarchy.Node>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetNode",
        __Marshaller_common_PrimitiveString,
        __Marshaller_grpcapi_Node);

    static readonly grpc::Method<global::SKF.Enlight.API.Common.PrimitiveString, global::SKF.Enlight.API.Hierarchy.Nodes> __Method_GetNodes = new grpc::Method<global::SKF.Enlight.API.Common.PrimitiveString, global::SKF.Enlight.API.Hierarchy.Nodes>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetNodes",
        __Marshaller_common_PrimitiveString,
        __Marshaller_grpcapi_Nodes);

    static readonly grpc::Method<global::SKF.Enlight.API.Common.PrimitiveString, global::SKF.Enlight.API.Hierarchy.Nodes> __Method_GetChildNodes = new grpc::Method<global::SKF.Enlight.API.Common.PrimitiveString, global::SKF.Enlight.API.Hierarchy.Nodes>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetChildNodes",
        __Marshaller_common_PrimitiveString,
        __Marshaller_grpcapi_Nodes);

    static readonly grpc::Method<global::SKF.Enlight.API.Common.PrimitiveString, global::SKF.Enlight.API.Hierarchy.Node> __Method_GetParentNode = new grpc::Method<global::SKF.Enlight.API.Common.PrimitiveString, global::SKF.Enlight.API.Hierarchy.Node>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetParentNode",
        __Marshaller_common_PrimitiveString,
        __Marshaller_grpcapi_Node);

    static readonly grpc::Method<global::SKF.Enlight.API.Hierarchy.GetAncestorsInput, global::SKF.Enlight.API.Hierarchy.GetAncestorsOutput> __Method_GetAncestors = new grpc::Method<global::SKF.Enlight.API.Hierarchy.GetAncestorsInput, global::SKF.Enlight.API.Hierarchy.GetAncestorsOutput>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAncestors",
        __Marshaller_grpcapi_GetAncestorsInput,
        __Marshaller_grpcapi_GetAncestorsOutput);

    static readonly grpc::Method<global::SKF.Enlight.API.Common.Origin, global::SKF.Enlight.API.Common.PrimitiveString> __Method_GetNodeIdByOrigin = new grpc::Method<global::SKF.Enlight.API.Common.Origin, global::SKF.Enlight.API.Common.PrimitiveString>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetNodeIdByOrigin",
        __Marshaller_common_Origin,
        __Marshaller_common_PrimitiveString);

    static readonly grpc::Method<global::SKF.Enlight.API.Hierarchy.SaveNodeInput, global::SKF.Enlight.API.Common.PrimitiveString> __Method_SaveNode = new grpc::Method<global::SKF.Enlight.API.Hierarchy.SaveNodeInput, global::SKF.Enlight.API.Common.PrimitiveString>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SaveNode",
        __Marshaller_grpcapi_SaveNodeInput,
        __Marshaller_common_PrimitiveString);

    static readonly grpc::Method<global::SKF.Enlight.API.Hierarchy.DeleteNodeInput, global::SKF.Enlight.API.Common.Void> __Method_DeleteNode = new grpc::Method<global::SKF.Enlight.API.Hierarchy.DeleteNodeInput, global::SKF.Enlight.API.Common.Void>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteNode",
        __Marshaller_grpcapi_DeleteNodeInput,
        __Marshaller_common_Void);

    static readonly grpc::Method<global::SKF.Enlight.API.Hierarchy.GetEventsInput, global::SKF.Enlight.API.Hierarchy.GetEventsOutput> __Method_GetEvents = new grpc::Method<global::SKF.Enlight.API.Hierarchy.GetEventsInput, global::SKF.Enlight.API.Hierarchy.GetEventsOutput>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetEvents",
        __Marshaller_grpcapi_GetEventsInput,
        __Marshaller_grpcapi_GetEventsOutput);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::SKF.Enlight.API.Hierarchy.GrpcapiReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Hierarchy</summary>
    public abstract partial class HierarchyBase
    {
      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.Common.PrimitiveString> DeepPing(global::SKF.Enlight.API.Common.Void request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.Hierarchy.Node> GetNode(global::SKF.Enlight.API.Common.PrimitiveString request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.Hierarchy.Nodes> GetNodes(global::SKF.Enlight.API.Common.PrimitiveString request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.Hierarchy.Nodes> GetChildNodes(global::SKF.Enlight.API.Common.PrimitiveString request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.Hierarchy.Node> GetParentNode(global::SKF.Enlight.API.Common.PrimitiveString request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.Hierarchy.GetAncestorsOutput> GetAncestors(global::SKF.Enlight.API.Hierarchy.GetAncestorsInput request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.Common.PrimitiveString> GetNodeIdByOrigin(global::SKF.Enlight.API.Common.Origin request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.Common.PrimitiveString> SaveNode(global::SKF.Enlight.API.Hierarchy.SaveNodeInput request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.Common.Void> DeleteNode(global::SKF.Enlight.API.Hierarchy.DeleteNodeInput request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SKF.Enlight.API.Hierarchy.GetEventsOutput> GetEvents(global::SKF.Enlight.API.Hierarchy.GetEventsInput request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Hierarchy</summary>
    public partial class HierarchyClient : grpc::ClientBase<HierarchyClient>
    {
      /// <summary>Creates a new client for Hierarchy</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public HierarchyClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Hierarchy that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public HierarchyClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected HierarchyClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected HierarchyClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::SKF.Enlight.API.Common.PrimitiveString DeepPing(global::SKF.Enlight.API.Common.Void request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeepPing(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.Common.PrimitiveString DeepPing(global::SKF.Enlight.API.Common.Void request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeepPing, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Common.PrimitiveString> DeepPingAsync(global::SKF.Enlight.API.Common.Void request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeepPingAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Common.PrimitiveString> DeepPingAsync(global::SKF.Enlight.API.Common.Void request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeepPing, null, options, request);
      }
      public virtual global::SKF.Enlight.API.Hierarchy.Node GetNode(global::SKF.Enlight.API.Common.PrimitiveString request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetNode(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.Hierarchy.Node GetNode(global::SKF.Enlight.API.Common.PrimitiveString request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetNode, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Hierarchy.Node> GetNodeAsync(global::SKF.Enlight.API.Common.PrimitiveString request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetNodeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Hierarchy.Node> GetNodeAsync(global::SKF.Enlight.API.Common.PrimitiveString request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetNode, null, options, request);
      }
      public virtual global::SKF.Enlight.API.Hierarchy.Nodes GetNodes(global::SKF.Enlight.API.Common.PrimitiveString request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetNodes(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.Hierarchy.Nodes GetNodes(global::SKF.Enlight.API.Common.PrimitiveString request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetNodes, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Hierarchy.Nodes> GetNodesAsync(global::SKF.Enlight.API.Common.PrimitiveString request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetNodesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Hierarchy.Nodes> GetNodesAsync(global::SKF.Enlight.API.Common.PrimitiveString request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetNodes, null, options, request);
      }
      public virtual global::SKF.Enlight.API.Hierarchy.Nodes GetChildNodes(global::SKF.Enlight.API.Common.PrimitiveString request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetChildNodes(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.Hierarchy.Nodes GetChildNodes(global::SKF.Enlight.API.Common.PrimitiveString request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetChildNodes, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Hierarchy.Nodes> GetChildNodesAsync(global::SKF.Enlight.API.Common.PrimitiveString request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetChildNodesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Hierarchy.Nodes> GetChildNodesAsync(global::SKF.Enlight.API.Common.PrimitiveString request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetChildNodes, null, options, request);
      }
      public virtual global::SKF.Enlight.API.Hierarchy.Node GetParentNode(global::SKF.Enlight.API.Common.PrimitiveString request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetParentNode(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.Hierarchy.Node GetParentNode(global::SKF.Enlight.API.Common.PrimitiveString request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetParentNode, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Hierarchy.Node> GetParentNodeAsync(global::SKF.Enlight.API.Common.PrimitiveString request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetParentNodeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Hierarchy.Node> GetParentNodeAsync(global::SKF.Enlight.API.Common.PrimitiveString request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetParentNode, null, options, request);
      }
      public virtual global::SKF.Enlight.API.Hierarchy.GetAncestorsOutput GetAncestors(global::SKF.Enlight.API.Hierarchy.GetAncestorsInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAncestors(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.Hierarchy.GetAncestorsOutput GetAncestors(global::SKF.Enlight.API.Hierarchy.GetAncestorsInput request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAncestors, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Hierarchy.GetAncestorsOutput> GetAncestorsAsync(global::SKF.Enlight.API.Hierarchy.GetAncestorsInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAncestorsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Hierarchy.GetAncestorsOutput> GetAncestorsAsync(global::SKF.Enlight.API.Hierarchy.GetAncestorsInput request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAncestors, null, options, request);
      }
      public virtual global::SKF.Enlight.API.Common.PrimitiveString GetNodeIdByOrigin(global::SKF.Enlight.API.Common.Origin request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetNodeIdByOrigin(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.Common.PrimitiveString GetNodeIdByOrigin(global::SKF.Enlight.API.Common.Origin request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetNodeIdByOrigin, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Common.PrimitiveString> GetNodeIdByOriginAsync(global::SKF.Enlight.API.Common.Origin request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetNodeIdByOriginAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Common.PrimitiveString> GetNodeIdByOriginAsync(global::SKF.Enlight.API.Common.Origin request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetNodeIdByOrigin, null, options, request);
      }
      public virtual global::SKF.Enlight.API.Common.PrimitiveString SaveNode(global::SKF.Enlight.API.Hierarchy.SaveNodeInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SaveNode(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.Common.PrimitiveString SaveNode(global::SKF.Enlight.API.Hierarchy.SaveNodeInput request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SaveNode, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Common.PrimitiveString> SaveNodeAsync(global::SKF.Enlight.API.Hierarchy.SaveNodeInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SaveNodeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Common.PrimitiveString> SaveNodeAsync(global::SKF.Enlight.API.Hierarchy.SaveNodeInput request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SaveNode, null, options, request);
      }
      public virtual global::SKF.Enlight.API.Common.Void DeleteNode(global::SKF.Enlight.API.Hierarchy.DeleteNodeInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteNode(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.Common.Void DeleteNode(global::SKF.Enlight.API.Hierarchy.DeleteNodeInput request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteNode, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Common.Void> DeleteNodeAsync(global::SKF.Enlight.API.Hierarchy.DeleteNodeInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteNodeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Common.Void> DeleteNodeAsync(global::SKF.Enlight.API.Hierarchy.DeleteNodeInput request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteNode, null, options, request);
      }
      public virtual global::SKF.Enlight.API.Hierarchy.GetEventsOutput GetEvents(global::SKF.Enlight.API.Hierarchy.GetEventsInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetEvents(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::SKF.Enlight.API.Hierarchy.GetEventsOutput GetEvents(global::SKF.Enlight.API.Hierarchy.GetEventsInput request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetEvents, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Hierarchy.GetEventsOutput> GetEventsAsync(global::SKF.Enlight.API.Hierarchy.GetEventsInput request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetEventsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::SKF.Enlight.API.Hierarchy.GetEventsOutput> GetEventsAsync(global::SKF.Enlight.API.Hierarchy.GetEventsInput request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetEvents, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override HierarchyClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new HierarchyClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(HierarchyBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_DeepPing, serviceImpl.DeepPing)
          .AddMethod(__Method_GetNode, serviceImpl.GetNode)
          .AddMethod(__Method_GetNodes, serviceImpl.GetNodes)
          .AddMethod(__Method_GetChildNodes, serviceImpl.GetChildNodes)
          .AddMethod(__Method_GetParentNode, serviceImpl.GetParentNode)
          .AddMethod(__Method_GetAncestors, serviceImpl.GetAncestors)
          .AddMethod(__Method_GetNodeIdByOrigin, serviceImpl.GetNodeIdByOrigin)
          .AddMethod(__Method_SaveNode, serviceImpl.SaveNode)
          .AddMethod(__Method_DeleteNode, serviceImpl.DeleteNode)
          .AddMethod(__Method_GetEvents, serviceImpl.GetEvents).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, HierarchyBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_DeepPing, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.Common.Void, global::SKF.Enlight.API.Common.PrimitiveString>(serviceImpl.DeepPing));
      serviceBinder.AddMethod(__Method_GetNode, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.Common.PrimitiveString, global::SKF.Enlight.API.Hierarchy.Node>(serviceImpl.GetNode));
      serviceBinder.AddMethod(__Method_GetNodes, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.Common.PrimitiveString, global::SKF.Enlight.API.Hierarchy.Nodes>(serviceImpl.GetNodes));
      serviceBinder.AddMethod(__Method_GetChildNodes, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.Common.PrimitiveString, global::SKF.Enlight.API.Hierarchy.Nodes>(serviceImpl.GetChildNodes));
      serviceBinder.AddMethod(__Method_GetParentNode, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.Common.PrimitiveString, global::SKF.Enlight.API.Hierarchy.Node>(serviceImpl.GetParentNode));
      serviceBinder.AddMethod(__Method_GetAncestors, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.Hierarchy.GetAncestorsInput, global::SKF.Enlight.API.Hierarchy.GetAncestorsOutput>(serviceImpl.GetAncestors));
      serviceBinder.AddMethod(__Method_GetNodeIdByOrigin, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.Common.Origin, global::SKF.Enlight.API.Common.PrimitiveString>(serviceImpl.GetNodeIdByOrigin));
      serviceBinder.AddMethod(__Method_SaveNode, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.Hierarchy.SaveNodeInput, global::SKF.Enlight.API.Common.PrimitiveString>(serviceImpl.SaveNode));
      serviceBinder.AddMethod(__Method_DeleteNode, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.Hierarchy.DeleteNodeInput, global::SKF.Enlight.API.Common.Void>(serviceImpl.DeleteNode));
      serviceBinder.AddMethod(__Method_GetEvents, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SKF.Enlight.API.Hierarchy.GetEventsInput, global::SKF.Enlight.API.Hierarchy.GetEventsOutput>(serviceImpl.GetEvents));
    }

  }
}
#endregion

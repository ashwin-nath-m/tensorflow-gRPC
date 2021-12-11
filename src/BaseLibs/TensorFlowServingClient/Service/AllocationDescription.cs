// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tensorflow/core/framework/allocation_description.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow {

  /// <summary>Holder for reflection information generated from tensorflow/core/framework/allocation_description.proto</summary>
  public static partial class AllocationDescriptionReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/core/framework/allocation_description.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AllocationDescriptionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZ0ZW5zb3JmbG93L2NvcmUvZnJhbWV3b3JrL2FsbG9jYXRpb25fZGVzY3Jp",
            "cHRpb24ucHJvdG8SCnRlbnNvcmZsb3ciowEKFUFsbG9jYXRpb25EZXNjcmlw",
            "dGlvbhIXCg9yZXF1ZXN0ZWRfYnl0ZXMYASABKAMSFwoPYWxsb2NhdGVkX2J5",
            "dGVzGAIgASgDEhYKDmFsbG9jYXRvcl9uYW1lGAMgASgJEhUKDWFsbG9jYXRp",
            "b25faWQYBCABKAMSHAoUaGFzX3NpbmdsZV9yZWZlcmVuY2UYBSABKAgSCwoD",
            "cHRyGAYgASgEQjwKGG9yZy50ZW5zb3JmbG93LmZyYW1ld29ya0IbQWxsb2Nh",
            "dGlvbkRlc2NyaXB0aW9uUHJvdG9zUAH4AQFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.AllocationDescription), global::Tensorflow.AllocationDescription.Parser, new[]{ "RequestedBytes", "AllocatedBytes", "AllocatorName", "AllocationId", "HasSingleReference", "Ptr" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AllocationDescription : pb::IMessage<AllocationDescription> {
    private static readonly pb::MessageParser<AllocationDescription> _parser = new pb::MessageParser<AllocationDescription>(() => new AllocationDescription());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AllocationDescription> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.AllocationDescriptionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AllocationDescription() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AllocationDescription(AllocationDescription other) : this() {
      requestedBytes_ = other.requestedBytes_;
      allocatedBytes_ = other.allocatedBytes_;
      allocatorName_ = other.allocatorName_;
      allocationId_ = other.allocationId_;
      hasSingleReference_ = other.hasSingleReference_;
      ptr_ = other.ptr_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AllocationDescription Clone() {
      return new AllocationDescription(this);
    }

    /// <summary>Field number for the "requested_bytes" field.</summary>
    public const int RequestedBytesFieldNumber = 1;
    private long requestedBytes_;
    /// <summary>
    /// Total number of bytes requested
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RequestedBytes {
      get { return requestedBytes_; }
      set {
        requestedBytes_ = value;
      }
    }

    /// <summary>Field number for the "allocated_bytes" field.</summary>
    public const int AllocatedBytesFieldNumber = 2;
    private long allocatedBytes_;
    /// <summary>
    /// Total number of bytes allocated if known
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long AllocatedBytes {
      get { return allocatedBytes_; }
      set {
        allocatedBytes_ = value;
      }
    }

    /// <summary>Field number for the "allocator_name" field.</summary>
    public const int AllocatorNameFieldNumber = 3;
    private string allocatorName_ = "";
    /// <summary>
    /// Name of the allocator used
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AllocatorName {
      get { return allocatorName_; }
      set {
        allocatorName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "allocation_id" field.</summary>
    public const int AllocationIdFieldNumber = 4;
    private long allocationId_;
    /// <summary>
    /// Identifier of the allocated buffer if known
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long AllocationId {
      get { return allocationId_; }
      set {
        allocationId_ = value;
      }
    }

    /// <summary>Field number for the "has_single_reference" field.</summary>
    public const int HasSingleReferenceFieldNumber = 5;
    private bool hasSingleReference_;
    /// <summary>
    /// Set if this tensor only has one remaining reference
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasSingleReference {
      get { return hasSingleReference_; }
      set {
        hasSingleReference_ = value;
      }
    }

    /// <summary>Field number for the "ptr" field.</summary>
    public const int PtrFieldNumber = 6;
    private ulong ptr_;
    /// <summary>
    /// Address of the allocation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Ptr {
      get { return ptr_; }
      set {
        ptr_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AllocationDescription);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AllocationDescription other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RequestedBytes != other.RequestedBytes) return false;
      if (AllocatedBytes != other.AllocatedBytes) return false;
      if (AllocatorName != other.AllocatorName) return false;
      if (AllocationId != other.AllocationId) return false;
      if (HasSingleReference != other.HasSingleReference) return false;
      if (Ptr != other.Ptr) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RequestedBytes != 0L) hash ^= RequestedBytes.GetHashCode();
      if (AllocatedBytes != 0L) hash ^= AllocatedBytes.GetHashCode();
      if (AllocatorName.Length != 0) hash ^= AllocatorName.GetHashCode();
      if (AllocationId != 0L) hash ^= AllocationId.GetHashCode();
      if (HasSingleReference != false) hash ^= HasSingleReference.GetHashCode();
      if (Ptr != 0UL) hash ^= Ptr.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RequestedBytes != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(RequestedBytes);
      }
      if (AllocatedBytes != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(AllocatedBytes);
      }
      if (AllocatorName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(AllocatorName);
      }
      if (AllocationId != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(AllocationId);
      }
      if (HasSingleReference != false) {
        output.WriteRawTag(40);
        output.WriteBool(HasSingleReference);
      }
      if (Ptr != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(Ptr);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RequestedBytes != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RequestedBytes);
      }
      if (AllocatedBytes != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(AllocatedBytes);
      }
      if (AllocatorName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AllocatorName);
      }
      if (AllocationId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(AllocationId);
      }
      if (HasSingleReference != false) {
        size += 1 + 1;
      }
      if (Ptr != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Ptr);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AllocationDescription other) {
      if (other == null) {
        return;
      }
      if (other.RequestedBytes != 0L) {
        RequestedBytes = other.RequestedBytes;
      }
      if (other.AllocatedBytes != 0L) {
        AllocatedBytes = other.AllocatedBytes;
      }
      if (other.AllocatorName.Length != 0) {
        AllocatorName = other.AllocatorName;
      }
      if (other.AllocationId != 0L) {
        AllocationId = other.AllocationId;
      }
      if (other.HasSingleReference != false) {
        HasSingleReference = other.HasSingleReference;
      }
      if (other.Ptr != 0UL) {
        Ptr = other.Ptr;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            RequestedBytes = input.ReadInt64();
            break;
          }
          case 16: {
            AllocatedBytes = input.ReadInt64();
            break;
          }
          case 26: {
            AllocatorName = input.ReadString();
            break;
          }
          case 32: {
            AllocationId = input.ReadInt64();
            break;
          }
          case 40: {
            HasSingleReference = input.ReadBool();
            break;
          }
          case 48: {
            Ptr = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

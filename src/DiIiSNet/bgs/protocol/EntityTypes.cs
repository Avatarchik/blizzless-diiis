// Generated by ProtoGen, Version=2.4.1.473, Culture=neutral, PublicKeyToken=55f7125234beb589.  DO NOT EDIT!
#pragma warning disable 1591, 0612
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace bgs.protocol {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
  public static partial class EntityTypes {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_bgs_protocol_EntityId__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::bgs.protocol.EntityId, global::bgs.protocol.EntityId.Builder> internal__static_bgs_protocol_EntityId__FieldAccessorTable;
    internal static pbd::MessageDescriptor internal__static_bgs_protocol_Identity__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::bgs.protocol.Identity, global::bgs.protocol.Identity.Builder> internal__static_bgs_protocol_Identity__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static EntityTypes() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "CiRiZ3MvbG93L3BiL2NsaWVudC9lbnRpdHlfdHlwZXMucHJvdG8SDGJncy5w" + 
          "cm90b2NvbBo3YmdzL2xvdy9wYi9jbGllbnQvZ2xvYmFsX2V4dGVuc2lvbnMv" + 
          "ZmllbGRfb3B0aW9ucy5wcm90bxo5YmdzL2xvdy9wYi9jbGllbnQvZ2xvYmFs" + 
          "X2V4dGVuc2lvbnMvbWVzc2FnZV9vcHRpb25zLnByb3RvIkgKCEVudGl0eUlk" + 
          "EhoKBGhpZ2gYASACKAZCBoL5KwIIAlIEaGlnaBIYCgNsb3cYAiACKAZCBoL5" + 
          "KwIIAlIDbG93OgaC+SsCCAEilQEKCElkZW50aXR5Ej8KCmFjY291bnRfaWQY" + 
          "ASABKAsyFi5iZ3MucHJvdG9jb2wuRW50aXR5SWRCCIr5KwQ6AhABUglhY2Nv" + 
          "dW50SWQSSAoPZ2FtZV9hY2NvdW50X2lkGAIgASgLMhYuYmdzLnByb3RvY29s" + 
          "LkVudGl0eUlkQgiK+SsEOgIQAlINZ2FtZUFjY291bnRJZEIcCg1ibmV0LnBy" + 
          "b3RvY29sQgtFbnRpdHlQcm90bw==");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_bgs_protocol_EntityId__Descriptor = Descriptor.MessageTypes[0];
        internal__static_bgs_protocol_EntityId__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::bgs.protocol.EntityId, global::bgs.protocol.EntityId.Builder>(internal__static_bgs_protocol_EntityId__Descriptor,
                new string[] { "High", "Low", });
        internal__static_bgs_protocol_Identity__Descriptor = Descriptor.MessageTypes[1];
        internal__static_bgs_protocol_Identity__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::bgs.protocol.Identity, global::bgs.protocol.Identity.Builder>(internal__static_bgs_protocol_Identity__Descriptor,
                new string[] { "AccountId", "GameAccountId", });
        pb::ExtensionRegistry registry = pb::ExtensionRegistry.CreateInstance();
        RegisterAllExtensions(registry);
        global::bgs.protocol.FieldOptions.RegisterAllExtensions(registry);
        global::bgs.protocol.MessageOptions.RegisterAllExtensions(registry);
        return registry;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          global::bgs.protocol.FieldOptions.Descriptor, 
          global::bgs.protocol.MessageOptions.Descriptor, 
          }, assigner);
    }
    #endregion
    
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
  public sealed partial class EntityId : pb::GeneratedMessage<EntityId, EntityId.Builder> {
    private EntityId() { }
    private static readonly EntityId defaultInstance = new EntityId().MakeReadOnly();
    private static readonly string[] _entityIdFieldNames = new string[] { "high", "low" };
    private static readonly uint[] _entityIdFieldTags = new uint[] { 9, 17 };
    public static EntityId DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override EntityId DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override EntityId ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::bgs.protocol.EntityTypes.internal__static_bgs_protocol_EntityId__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<EntityId, EntityId.Builder> InternalFieldAccessors {
      get { return global::bgs.protocol.EntityTypes.internal__static_bgs_protocol_EntityId__FieldAccessorTable; }
    }
    
    public const int HighFieldNumber = 1;
    private bool hasHigh;
    private ulong high_;
    public bool HasHigh {
      get { return hasHigh; }
    }
    public ulong High {
      get { return high_; }
    }
    
    public const int LowFieldNumber = 2;
    private bool hasLow;
    private ulong low_;
    public bool HasLow {
      get { return hasLow; }
    }
    public ulong Low {
      get { return low_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasHigh) return false;
        if (!hasLow) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _entityIdFieldNames;
      if (hasHigh) {
        output.WriteFixed64(1, field_names[0], High);
      }
      if (hasLow) {
        output.WriteFixed64(2, field_names[1], Low);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasHigh) {
          size += pb::CodedOutputStream.ComputeFixed64Size(1, High);
        }
        if (hasLow) {
          size += pb::CodedOutputStream.ComputeFixed64Size(2, Low);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static EntityId ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static EntityId ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static EntityId ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static EntityId ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static EntityId ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static EntityId ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static EntityId ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static EntityId ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static EntityId ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static EntityId ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private EntityId MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(EntityId prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
    public sealed partial class Builder : pb::GeneratedBuilder<EntityId, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(EntityId cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private EntityId result;
      
      private EntityId PrepareBuilder() {
        if (resultIsReadOnly) {
          EntityId original = result;
          result = new EntityId();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override EntityId MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::bgs.protocol.EntityId.Descriptor; }
      }
      
      public override EntityId DefaultInstanceForType {
        get { return global::bgs.protocol.EntityId.DefaultInstance; }
      }
      
      public override EntityId BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is EntityId) {
          return MergeFrom((EntityId) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(EntityId other) {
        if (other == global::bgs.protocol.EntityId.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasHigh) {
          High = other.High;
        }
        if (other.HasLow) {
          Low = other.Low;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_entityIdFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _entityIdFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 9: {
              result.hasHigh = input.ReadFixed64(ref result.high_);
              break;
            }
            case 17: {
              result.hasLow = input.ReadFixed64(ref result.low_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasHigh {
        get { return result.hasHigh; }
      }
      public ulong High {
        get { return result.High; }
        set { SetHigh(value); }
      }
      public Builder SetHigh(ulong value) {
        PrepareBuilder();
        result.hasHigh = true;
        result.high_ = value;
        return this;
      }
      public Builder ClearHigh() {
        PrepareBuilder();
        result.hasHigh = false;
        result.high_ = 0;
        return this;
      }
      
      public bool HasLow {
        get { return result.hasLow; }
      }
      public ulong Low {
        get { return result.Low; }
        set { SetLow(value); }
      }
      public Builder SetLow(ulong value) {
        PrepareBuilder();
        result.hasLow = true;
        result.low_ = value;
        return this;
      }
      public Builder ClearLow() {
        PrepareBuilder();
        result.hasLow = false;
        result.low_ = 0;
        return this;
      }
    }
    static EntityId() {
      object.ReferenceEquals(global::bgs.protocol.EntityTypes.Descriptor, null);
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
  public sealed partial class Identity : pb::GeneratedMessage<Identity, Identity.Builder> {
    private Identity() { }
    private static readonly Identity defaultInstance = new Identity().MakeReadOnly();
    private static readonly string[] _identityFieldNames = new string[] { "account_id", "game_account_id" };
    private static readonly uint[] _identityFieldTags = new uint[] { 10, 18 };
    public static Identity DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override Identity DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override Identity ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::bgs.protocol.EntityTypes.internal__static_bgs_protocol_Identity__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<Identity, Identity.Builder> InternalFieldAccessors {
      get { return global::bgs.protocol.EntityTypes.internal__static_bgs_protocol_Identity__FieldAccessorTable; }
    }
    
    public const int AccountIdFieldNumber = 1;
    private bool hasAccountId;
    private global::bgs.protocol.EntityId accountId_;
    public bool HasAccountId {
      get { return hasAccountId; }
    }
    public global::bgs.protocol.EntityId AccountId {
      get { return accountId_ ?? global::bgs.protocol.EntityId.DefaultInstance; }
    }
    
    public const int GameAccountIdFieldNumber = 2;
    private bool hasGameAccountId;
    private global::bgs.protocol.EntityId gameAccountId_;
    public bool HasGameAccountId {
      get { return hasGameAccountId; }
    }
    public global::bgs.protocol.EntityId GameAccountId {
      get { return gameAccountId_ ?? global::bgs.protocol.EntityId.DefaultInstance; }
    }
    
    public override bool IsInitialized {
      get {
        if (HasAccountId) {
          if (!AccountId.IsInitialized) return false;
        }
        if (HasGameAccountId) {
          if (!GameAccountId.IsInitialized) return false;
        }
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _identityFieldNames;
      if (hasAccountId) {
        output.WriteMessage(1, field_names[0], AccountId);
      }
      if (hasGameAccountId) {
        output.WriteMessage(2, field_names[1], GameAccountId);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasAccountId) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, AccountId);
        }
        if (hasGameAccountId) {
          size += pb::CodedOutputStream.ComputeMessageSize(2, GameAccountId);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static Identity ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Identity ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Identity ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Identity ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Identity ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Identity ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Identity ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static Identity ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static Identity ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Identity ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private Identity MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(Identity prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
    public sealed partial class Builder : pb::GeneratedBuilder<Identity, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(Identity cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private Identity result;
      
      private Identity PrepareBuilder() {
        if (resultIsReadOnly) {
          Identity original = result;
          result = new Identity();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override Identity MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::bgs.protocol.Identity.Descriptor; }
      }
      
      public override Identity DefaultInstanceForType {
        get { return global::bgs.protocol.Identity.DefaultInstance; }
      }
      
      public override Identity BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is Identity) {
          return MergeFrom((Identity) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(Identity other) {
        if (other == global::bgs.protocol.Identity.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasAccountId) {
          MergeAccountId(other.AccountId);
        }
        if (other.HasGameAccountId) {
          MergeGameAccountId(other.GameAccountId);
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_identityFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _identityFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              global::bgs.protocol.EntityId.Builder subBuilder = global::bgs.protocol.EntityId.CreateBuilder();
              if (result.hasAccountId) {
                subBuilder.MergeFrom(AccountId);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              AccountId = subBuilder.BuildPartial();
              break;
            }
            case 18: {
              global::bgs.protocol.EntityId.Builder subBuilder = global::bgs.protocol.EntityId.CreateBuilder();
              if (result.hasGameAccountId) {
                subBuilder.MergeFrom(GameAccountId);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              GameAccountId = subBuilder.BuildPartial();
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasAccountId {
       get { return result.hasAccountId; }
      }
      public global::bgs.protocol.EntityId AccountId {
        get { return result.AccountId; }
        set { SetAccountId(value); }
      }
      public Builder SetAccountId(global::bgs.protocol.EntityId value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasAccountId = true;
        result.accountId_ = value;
        return this;
      }
      public Builder SetAccountId(global::bgs.protocol.EntityId.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasAccountId = true;
        result.accountId_ = builderForValue.Build();
        return this;
      }
      public Builder MergeAccountId(global::bgs.protocol.EntityId value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasAccountId &&
            result.accountId_ != global::bgs.protocol.EntityId.DefaultInstance) {
            result.accountId_ = global::bgs.protocol.EntityId.CreateBuilder(result.accountId_).MergeFrom(value).BuildPartial();
        } else {
          result.accountId_ = value;
        }
        result.hasAccountId = true;
        return this;
      }
      public Builder ClearAccountId() {
        PrepareBuilder();
        result.hasAccountId = false;
        result.accountId_ = null;
        return this;
      }
      
      public bool HasGameAccountId {
       get { return result.hasGameAccountId; }
      }
      public global::bgs.protocol.EntityId GameAccountId {
        get { return result.GameAccountId; }
        set { SetGameAccountId(value); }
      }
      public Builder SetGameAccountId(global::bgs.protocol.EntityId value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasGameAccountId = true;
        result.gameAccountId_ = value;
        return this;
      }
      public Builder SetGameAccountId(global::bgs.protocol.EntityId.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasGameAccountId = true;
        result.gameAccountId_ = builderForValue.Build();
        return this;
      }
      public Builder MergeGameAccountId(global::bgs.protocol.EntityId value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasGameAccountId &&
            result.gameAccountId_ != global::bgs.protocol.EntityId.DefaultInstance) {
            result.gameAccountId_ = global::bgs.protocol.EntityId.CreateBuilder(result.gameAccountId_).MergeFrom(value).BuildPartial();
        } else {
          result.gameAccountId_ = value;
        }
        result.hasGameAccountId = true;
        return this;
      }
      public Builder ClearGameAccountId() {
        PrepareBuilder();
        result.hasGameAccountId = false;
        result.gameAccountId_ = null;
        return this;
      }
    }
    static Identity() {
      object.ReferenceEquals(global::bgs.protocol.EntityTypes.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
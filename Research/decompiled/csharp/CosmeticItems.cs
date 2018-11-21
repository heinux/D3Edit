// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CosmeticItems.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace D3.CosmeticItems {

  /// <summary>Holder for reflection information generated from CosmeticItems.proto</summary>
  public static partial class CosmeticItemsReflection {

    #region Descriptor
    /// <summary>File descriptor for CosmeticItems.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CosmeticItemsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNDb3NtZXRpY0l0ZW1zLnByb3RvEhBEMy5Db3NtZXRpY0l0ZW1zGhFHYW1l",
            "QmFsYW5jZS5wcm90byI1CgxDb3NtZXRpY0l0ZW0SDAoEZ2JpZBgBIAEoDxIX",
            "Cg9leHBpcmF0aW9uX3RpbWUYAiABKAMiRwoNQ29zbWV0aWNJdGVtcxI2Cg5j",
            "b3NtZXRpY19pdGVtcxgBIAMoCzIeLkQzLkNvc21ldGljSXRlbXMuQ29zbWV0",
            "aWNJdGVtIlMKFUNvc21ldGljSXRlbVNhdmVkRGF0YRI6Cg5jb3NtZXRpY19p",
            "dGVtcxgBIAEoCzIiLkQzLkdhbWVCYWxhbmNlLkJpdFBhY2tlZEdiaWRBcnJh",
            "eWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::D3.GameBalance.GameBalanceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::D3.CosmeticItems.CosmeticItem), global::D3.CosmeticItems.CosmeticItem.Parser, new[]{ "Gbid", "ExpirationTime" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::D3.CosmeticItems.CosmeticItems), global::D3.CosmeticItems.CosmeticItems.Parser, new[]{ "CosmeticItems_" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::D3.CosmeticItems.CosmeticItemSavedData), global::D3.CosmeticItems.CosmeticItemSavedData.Parser, new[]{ "CosmeticItems" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CosmeticItem : pb::IMessage<CosmeticItem> {
    private static readonly pb::MessageParser<CosmeticItem> _parser = new pb::MessageParser<CosmeticItem>(() => new CosmeticItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CosmeticItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::D3.CosmeticItems.CosmeticItemsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CosmeticItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CosmeticItem(CosmeticItem other) : this() {
      gbid_ = other.gbid_;
      expirationTime_ = other.expirationTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CosmeticItem Clone() {
      return new CosmeticItem(this);
    }

    /// <summary>Field number for the "gbid" field.</summary>
    public const int GbidFieldNumber = 1;
    private int gbid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Gbid {
      get { return gbid_; }
      set {
        gbid_ = value;
      }
    }

    /// <summary>Field number for the "expiration_time" field.</summary>
    public const int ExpirationTimeFieldNumber = 2;
    private long expirationTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ExpirationTime {
      get { return expirationTime_; }
      set {
        expirationTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CosmeticItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CosmeticItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Gbid != other.Gbid) return false;
      if (ExpirationTime != other.ExpirationTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Gbid != 0) hash ^= Gbid.GetHashCode();
      if (ExpirationTime != 0L) hash ^= ExpirationTime.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Gbid != 0) {
        output.WriteRawTag(13);
        output.WriteSFixed32(Gbid);
      }
      if (ExpirationTime != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(ExpirationTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Gbid != 0) {
        size += 1 + 4;
      }
      if (ExpirationTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExpirationTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CosmeticItem other) {
      if (other == null) {
        return;
      }
      if (other.Gbid != 0) {
        Gbid = other.Gbid;
      }
      if (other.ExpirationTime != 0L) {
        ExpirationTime = other.ExpirationTime;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 13: {
            Gbid = input.ReadSFixed32();
            break;
          }
          case 16: {
            ExpirationTime = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CosmeticItems : pb::IMessage<CosmeticItems> {
    private static readonly pb::MessageParser<CosmeticItems> _parser = new pb::MessageParser<CosmeticItems>(() => new CosmeticItems());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CosmeticItems> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::D3.CosmeticItems.CosmeticItemsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CosmeticItems() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CosmeticItems(CosmeticItems other) : this() {
      cosmeticItems_ = other.cosmeticItems_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CosmeticItems Clone() {
      return new CosmeticItems(this);
    }

    /// <summary>Field number for the "cosmetic_items" field.</summary>
    public const int CosmeticItems_FieldNumber = 1;
    private static readonly pb::FieldCodec<global::D3.CosmeticItems.CosmeticItem> _repeated_cosmeticItems_codec
        = pb::FieldCodec.ForMessage(10, global::D3.CosmeticItems.CosmeticItem.Parser);
    private readonly pbc::RepeatedField<global::D3.CosmeticItems.CosmeticItem> cosmeticItems_ = new pbc::RepeatedField<global::D3.CosmeticItems.CosmeticItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::D3.CosmeticItems.CosmeticItem> CosmeticItems_ {
      get { return cosmeticItems_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CosmeticItems);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CosmeticItems other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!cosmeticItems_.Equals(other.cosmeticItems_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= cosmeticItems_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      cosmeticItems_.WriteTo(output, _repeated_cosmeticItems_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += cosmeticItems_.CalculateSize(_repeated_cosmeticItems_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CosmeticItems other) {
      if (other == null) {
        return;
      }
      cosmeticItems_.Add(other.cosmeticItems_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            cosmeticItems_.AddEntriesFrom(input, _repeated_cosmeticItems_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class CosmeticItemSavedData : pb::IMessage<CosmeticItemSavedData> {
    private static readonly pb::MessageParser<CosmeticItemSavedData> _parser = new pb::MessageParser<CosmeticItemSavedData>(() => new CosmeticItemSavedData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CosmeticItemSavedData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::D3.CosmeticItems.CosmeticItemsReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CosmeticItemSavedData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CosmeticItemSavedData(CosmeticItemSavedData other) : this() {
      cosmeticItems_ = other.cosmeticItems_ != null ? other.cosmeticItems_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CosmeticItemSavedData Clone() {
      return new CosmeticItemSavedData(this);
    }

    /// <summary>Field number for the "cosmetic_items" field.</summary>
    public const int CosmeticItemsFieldNumber = 1;
    private global::D3.GameBalance.BitPackedGbidArray cosmeticItems_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::D3.GameBalance.BitPackedGbidArray CosmeticItems {
      get { return cosmeticItems_; }
      set {
        cosmeticItems_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CosmeticItemSavedData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CosmeticItemSavedData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CosmeticItems, other.CosmeticItems)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (cosmeticItems_ != null) hash ^= CosmeticItems.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (cosmeticItems_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CosmeticItems);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (cosmeticItems_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CosmeticItems);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CosmeticItemSavedData other) {
      if (other == null) {
        return;
      }
      if (other.cosmeticItems_ != null) {
        if (cosmeticItems_ == null) {
          cosmeticItems_ = new global::D3.GameBalance.BitPackedGbidArray();
        }
        CosmeticItems.MergeFrom(other.CosmeticItems);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (cosmeticItems_ == null) {
              cosmeticItems_ = new global::D3.GameBalance.BitPackedGbidArray();
            }
            input.ReadMessage(cosmeticItems_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
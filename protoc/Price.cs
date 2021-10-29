// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: price.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Price {

  /// <summary>Holder for reflection information generated from price.proto</summary>
  public static partial class PriceReflection {

    #region Descriptor
    /// <summary>File descriptor for price.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PriceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtwcmljZS5wcm90bxIFcHJpY2UiPgoMUHJpY2VSZXF1ZXN0EhEKCW1vZGVs",
            "Q29kZRgCIAEoCRINCgVjb2xvchgDIAEoCRIMCgR5ZWFyGAQgASgFIjEKClBy",
            "aWNlUmVwbHkSDQoFcHJpY2UYASABKAUSFAoMY3VycmVuY3lDb2RlGAIgASgJ",
            "MjwKBlByaWNlchIyCghHZXRQcmljZRITLnByaWNlLlByaWNlUmVxdWVzdBoR",
            "LnByaWNlLlByaWNlUmVwbHliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Price.PriceRequest), global::Price.PriceRequest.Parser, new[]{ "ModelCode", "Color", "Year" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Price.PriceReply), global::Price.PriceReply.Parser, new[]{ "Price", "CurrencyCode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PriceRequest : pb::IMessage<PriceRequest> {
    private static readonly pb::MessageParser<PriceRequest> _parser = new pb::MessageParser<PriceRequest>(() => new PriceRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PriceRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Price.PriceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PriceRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PriceRequest(PriceRequest other) : this() {
      modelCode_ = other.modelCode_;
      color_ = other.color_;
      year_ = other.year_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PriceRequest Clone() {
      return new PriceRequest(this);
    }

    /// <summary>Field number for the "modelCode" field.</summary>
    public const int ModelCodeFieldNumber = 2;
    private string modelCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ModelCode {
      get { return modelCode_; }
      set {
        modelCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "color" field.</summary>
    public const int ColorFieldNumber = 3;
    private string color_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Color {
      get { return color_; }
      set {
        color_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "year" field.</summary>
    public const int YearFieldNumber = 4;
    private int year_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Year {
      get { return year_; }
      set {
        year_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PriceRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PriceRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ModelCode != other.ModelCode) return false;
      if (Color != other.Color) return false;
      if (Year != other.Year) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ModelCode.Length != 0) hash ^= ModelCode.GetHashCode();
      if (Color.Length != 0) hash ^= Color.GetHashCode();
      if (Year != 0) hash ^= Year.GetHashCode();
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
      if (ModelCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ModelCode);
      }
      if (Color.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Color);
      }
      if (Year != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Year);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ModelCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ModelCode);
      }
      if (Color.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Color);
      }
      if (Year != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Year);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PriceRequest other) {
      if (other == null) {
        return;
      }
      if (other.ModelCode.Length != 0) {
        ModelCode = other.ModelCode;
      }
      if (other.Color.Length != 0) {
        Color = other.Color;
      }
      if (other.Year != 0) {
        Year = other.Year;
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
          case 18: {
            ModelCode = input.ReadString();
            break;
          }
          case 26: {
            Color = input.ReadString();
            break;
          }
          case 32: {
            Year = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class PriceReply : pb::IMessage<PriceReply> {
    private static readonly pb::MessageParser<PriceReply> _parser = new pb::MessageParser<PriceReply>(() => new PriceReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PriceReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Price.PriceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PriceReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PriceReply(PriceReply other) : this() {
      price_ = other.price_;
      currencyCode_ = other.currencyCode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PriceReply Clone() {
      return new PriceReply(this);
    }

    /// <summary>Field number for the "price" field.</summary>
    public const int PriceFieldNumber = 1;
    private int price_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Price {
      get { return price_; }
      set {
        price_ = value;
      }
    }

    /// <summary>Field number for the "currencyCode" field.</summary>
    public const int CurrencyCodeFieldNumber = 2;
    private string currencyCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CurrencyCode {
      get { return currencyCode_; }
      set {
        currencyCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PriceReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PriceReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Price != other.Price) return false;
      if (CurrencyCode != other.CurrencyCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Price != 0) hash ^= Price.GetHashCode();
      if (CurrencyCode.Length != 0) hash ^= CurrencyCode.GetHashCode();
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
      if (Price != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Price);
      }
      if (CurrencyCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CurrencyCode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Price != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Price);
      }
      if (CurrencyCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CurrencyCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PriceReply other) {
      if (other == null) {
        return;
      }
      if (other.Price != 0) {
        Price = other.Price;
      }
      if (other.CurrencyCode.Length != 0) {
        CurrencyCode = other.CurrencyCode;
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
          case 8: {
            Price = input.ReadInt32();
            break;
          }
          case 18: {
            CurrencyCode = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

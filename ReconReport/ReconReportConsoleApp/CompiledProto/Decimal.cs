// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: common/decimal.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cqg {

  /// <summary>Holder for reflection information generated from common/decimal.proto</summary>
  public static partial class DecimalReflection {

    #region Descriptor
    /// <summary>File descriptor for common/decimal.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DecimalReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRjb21tb24vZGVjaW1hbC5wcm90bxIDY3FnIjYKB0RlY2ltYWwSFgoLc2ln",
            "bmlmaWNhbmQYASABKBI6ATASEwoIZXhwb25lbnQYAiABKBE6ATBCDkIMRGVj",
            "aW1hbFByb3Rv"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cqg.Decimal), global::Cqg.Decimal.Parser, new[]{ "Significand", "Exponent" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Number is represented as a decimal floating point significand (limited by 64 bits including sign)
  /// and 32-bit exponent.
  /// The value represented is significand * (10 ^ exponent)
  /// </summary>
  public sealed partial class Decimal : pb::IMessage<Decimal>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Decimal> _parser = new pb::MessageParser<Decimal>(() => new Decimal());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Decimal> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cqg.DecimalReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Decimal() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Decimal(Decimal other) : this() {
      _hasBits0 = other._hasBits0;
      significand_ = other.significand_;
      exponent_ = other.exponent_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Decimal Clone() {
      return new Decimal(this);
    }

    /// <summary>Field number for the "significand" field.</summary>
    public const int SignificandFieldNumber = 1;
    private readonly static long SignificandDefaultValue = 0L;

    private long significand_;
    /// <summary>
    /// Significand (aka mantissa) of the decimal.  Signed.
    /// It can have trailing zeros (not normalized).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Significand {
      get { if ((_hasBits0 & 1) != 0) { return significand_; } else { return SignificandDefaultValue; } }
      set {
        _hasBits0 |= 1;
        significand_ = value;
      }
    }
    /// <summary>Gets whether the "significand" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasSignificand {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "significand" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearSignificand() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "exponent" field.</summary>
    public const int ExponentFieldNumber = 2;
    private readonly static int ExponentDefaultValue = 0;

    private int exponent_;
    /// <summary>
    /// Exponent of the decimal.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Exponent {
      get { if ((_hasBits0 & 2) != 0) { return exponent_; } else { return ExponentDefaultValue; } }
      set {
        _hasBits0 |= 2;
        exponent_ = value;
      }
    }
    /// <summary>Gets whether the "exponent" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasExponent {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "exponent" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearExponent() {
      _hasBits0 &= ~2;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Decimal);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Decimal other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Significand != other.Significand) return false;
      if (Exponent != other.Exponent) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasSignificand) hash ^= Significand.GetHashCode();
      if (HasExponent) hash ^= Exponent.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HasSignificand) {
        output.WriteRawTag(8);
        output.WriteSInt64(Significand);
      }
      if (HasExponent) {
        output.WriteRawTag(16);
        output.WriteSInt32(Exponent);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasSignificand) {
        output.WriteRawTag(8);
        output.WriteSInt64(Significand);
      }
      if (HasExponent) {
        output.WriteRawTag(16);
        output.WriteSInt32(Exponent);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasSignificand) {
        size += 1 + pb::CodedOutputStream.ComputeSInt64Size(Significand);
      }
      if (HasExponent) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(Exponent);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Decimal other) {
      if (other == null) {
        return;
      }
      if (other.HasSignificand) {
        Significand = other.Significand;
      }
      if (other.HasExponent) {
        Exponent = other.Exponent;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Significand = input.ReadSInt64();
            break;
          }
          case 16: {
            Exponent = input.ReadSInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Significand = input.ReadSInt64();
            break;
          }
          case 16: {
            Exponent = input.ReadSInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code

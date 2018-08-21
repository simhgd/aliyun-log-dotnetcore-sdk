//
// Log.Generated.cs
//
// Author:
//       MiNG <developer@ming.gz.cn>
//
// Copyright (c) 2018 Alibaba Cloud
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Log.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf {

  /// <summary>Holder for reflection information generated from Log.proto</summary>
  public static partial class LogReflection {

    #region Descriptor
    /// <summary>File descriptor for Log.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LogReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CglMb2cucHJvdG8SNGFsaXl1bi5hcGkubG9nLmluZnJhc3RydWN0dXJlLnNl",
            "cmlhbGl6YXRpb24ucHJvdG9idWYaHmdvb2dsZS9wcm90b2J1Zi93cmFwcGVy",
            "cy5wcm90byKtAQoDTG9nEgwKBFRpbWUYASABKA0SUwoIQ29udGVudHMYAiAD",
            "KAsyQS5hbGl5dW4uYXBpLmxvZy5pbmZyYXN0cnVjdHVyZS5zZXJpYWxpemF0",
            "aW9uLnByb3RvYnVmLkxvZy5Db250ZW50GkMKB0NvbnRlbnQSCwoDS2V5GAEg",
            "ASgJEisKBVZhbHVlGAIgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1Zh",
            "bHVlIkIKBkxvZ1RhZxILCgNLZXkYASABKAkSKwoFVmFsdWUYAiABKAsyHC5n",
            "b29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWUi6AEKCExvZ0dyb3VwEkcKBExv",
            "Z3MYASADKAsyOS5hbGl5dW4uYXBpLmxvZy5pbmZyYXN0cnVjdHVyZS5zZXJp",
            "YWxpemF0aW9uLnByb3RvYnVmLkxvZxIQCghDYXRlZ29yeRgCIAEoCRINCgVU",
            "b3BpYxgDIAEoCRIOCgZTb3VyY2UYBCABKAkSEwoLTWFjaGluZVVVSUQYBSAB",
            "KAkSTQoHTG9nVGFncxgGIAMoCzI8LmFsaXl1bi5hcGkubG9nLmluZnJhc3Ry",
            "dWN0dXJlLnNlcmlhbGl6YXRpb24ucHJvdG9idWYuTG9nVGFnImQKDExvZ0dy",
            "b3VwTGlzdBJUCgxsb2dHcm91cExpc3QYASADKAsyPi5hbGl5dW4uYXBpLmxv",
            "Zy5pbmZyYXN0cnVjdHVyZS5zZXJpYWxpemF0aW9uLnByb3RvYnVmLkxvZ0dy",
            "b3VwQj6qAjtBbGl5dW4uQXBpLkxvZ1NlcnZpY2UuSW5mcmFzdHJ1Y3R1cmUu",
            "U2VyaWFsaXphdGlvbi5Qcm90b2J1ZmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.Log), global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.Log.Parser, new[]{ "Time", "Contents" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.Log.Types.Content), global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.Log.Types.Content.Parser, new[]{ "Key", "Value" }, null, null, null)}),
            new pbr::GeneratedClrTypeInfo(typeof(global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.LogTag), global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.LogTag.Parser, new[]{ "Key", "Value" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.LogGroup), global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.LogGroup.Parser, new[]{ "Logs", "Category", "Topic", "Source", "MachineUUID", "LogTags" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.LogGroupList), global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.LogGroupList.Parser, new[]{ "LogGroupList_" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Log : pb::IMessage<Log> {
    private static readonly pb::MessageParser<Log> _parser = new pb::MessageParser<Log>(() => new Log());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Log> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.LogReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Log() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Log(Log other) : this() {
      time_ = other.time_;
      contents_ = other.contents_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Log Clone() {
      return new Log(this);
    }

    /// <summary>Field number for the "Time" field.</summary>
    public const int TimeFieldNumber = 1;
    private uint time_;
    /// <summary>
    /// UNIX Time Format
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "Contents" field.</summary>
    public const int ContentsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.Log.Types.Content> _repeated_contents_codec
        = pb::FieldCodec.ForMessage(18, global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.Log.Types.Content.Parser);
    private readonly pbc::RepeatedField<global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.Log.Types.Content> contents_ = new pbc::RepeatedField<global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.Log.Types.Content>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.Log.Types.Content> Contents {
      get { return contents_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Log);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Log other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Time != other.Time) return false;
      if(!contents_.Equals(other.contents_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Time != 0) hash ^= Time.GetHashCode();
      hash ^= contents_.GetHashCode();
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
      if (Time != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Time);
      }
      contents_.WriteTo(output, _repeated_contents_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Time != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Time);
      }
      size += contents_.CalculateSize(_repeated_contents_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Log other) {
      if (other == null) {
        return;
      }
      if (other.Time != 0) {
        Time = other.Time;
      }
      contents_.Add(other.contents_);
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
            Time = input.ReadUInt32();
            break;
          }
          case 18: {
            contents_.AddEntriesFrom(input, _repeated_contents_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Log message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class Content : pb::IMessage<Content> {
        private static readonly pb::MessageParser<Content> _parser = new pb::MessageParser<Content>(() => new Content());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Content> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.Log.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Content() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Content(Content other) : this() {
          key_ = other.key_;
          Value = other.Value;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Content Clone() {
          return new Content(this);
        }

        /// <summary>Field number for the "Key" field.</summary>
        public const int KeyFieldNumber = 1;
        private string key_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Key {
          get { return key_; }
          set {
            key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "Value" field.</summary>
        public const int ValueFieldNumber = 2;
        private static readonly pb::FieldCodec<string> _single_value_codec = pb::FieldCodec.ForClassWrapper<string>(18);
        private string value_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Value {
          get { return value_; }
          set {
            value_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Content);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Content other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Key != other.Key) return false;
          if (Value != other.Value) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Key.Length != 0) hash ^= Key.GetHashCode();
          if (value_ != null) hash ^= Value.GetHashCode();
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
          if (Key.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Key);
          }
          if (value_ != null) {
            _single_value_codec.WriteTagAndValue(output, Value);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Key.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
          }
          if (value_ != null) {
            size += _single_value_codec.CalculateSizeWithTag(Value);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Content other) {
          if (other == null) {
            return;
          }
          if (other.Key.Length != 0) {
            Key = other.Key;
          }
          if (other.value_ != null) {
            if (value_ == null || other.Value != "") {
              Value = other.Value;
            }
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
                Key = input.ReadString();
                break;
              }
              case 18: {
                string value = _single_value_codec.Read(input);
                if (value_ == null || value != "") {
                  Value = value;
                }
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  public sealed partial class LogTag : pb::IMessage<LogTag> {
    private static readonly pb::MessageParser<LogTag> _parser = new pb::MessageParser<LogTag>(() => new LogTag());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LogTag> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.LogReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogTag() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogTag(LogTag other) : this() {
      key_ = other.key_;
      Value = other.Value;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogTag Clone() {
      return new LogTag(this);
    }

    /// <summary>Field number for the "Key" field.</summary>
    public const int KeyFieldNumber = 1;
    private string key_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Key {
      get { return key_; }
      set {
        key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Value" field.</summary>
    public const int ValueFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_value_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string value_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LogTag);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LogTag other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Key != other.Key) return false;
      if (Value != other.Value) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Key.Length != 0) hash ^= Key.GetHashCode();
      if (value_ != null) hash ^= Value.GetHashCode();
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
      if (Key.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Key);
      }
      if (value_ != null) {
        _single_value_codec.WriteTagAndValue(output, Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Key.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
      }
      if (value_ != null) {
        size += _single_value_codec.CalculateSizeWithTag(Value);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LogTag other) {
      if (other == null) {
        return;
      }
      if (other.Key.Length != 0) {
        Key = other.Key;
      }
      if (other.value_ != null) {
        if (value_ == null || other.Value != "") {
          Value = other.Value;
        }
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
            Key = input.ReadString();
            break;
          }
          case 18: {
            string value = _single_value_codec.Read(input);
            if (value_ == null || value != "") {
              Value = value;
            }
            break;
          }
        }
      }
    }

  }

  public sealed partial class LogGroup : pb::IMessage<LogGroup> {
    private static readonly pb::MessageParser<LogGroup> _parser = new pb::MessageParser<LogGroup>(() => new LogGroup());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LogGroup> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.LogReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogGroup() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogGroup(LogGroup other) : this() {
      logs_ = other.logs_.Clone();
      category_ = other.category_;
      topic_ = other.topic_;
      source_ = other.source_;
      machineUUID_ = other.machineUUID_;
      logTags_ = other.logTags_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogGroup Clone() {
      return new LogGroup(this);
    }

    /// <summary>Field number for the "Logs" field.</summary>
    public const int LogsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.Log> _repeated_logs_codec
        = pb::FieldCodec.ForMessage(10, global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.Log.Parser);
    private readonly pbc::RepeatedField<global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.Log> logs_ = new pbc::RepeatedField<global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.Log>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.Log> Logs {
      get { return logs_; }
    }

    /// <summary>Field number for the "Category" field.</summary>
    public const int CategoryFieldNumber = 2;
    private string category_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Category {
      get { return category_; }
      set {
        category_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Topic" field.</summary>
    public const int TopicFieldNumber = 3;
    private string topic_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Topic {
      get { return topic_; }
      set {
        topic_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Source" field.</summary>
    public const int SourceFieldNumber = 4;
    private string source_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Source {
      get { return source_; }
      set {
        source_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "MachineUUID" field.</summary>
    public const int MachineUUIDFieldNumber = 5;
    private string machineUUID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MachineUUID {
      get { return machineUUID_; }
      set {
        machineUUID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "LogTags" field.</summary>
    public const int LogTagsFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.LogTag> _repeated_logTags_codec
        = pb::FieldCodec.ForMessage(50, global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.LogTag.Parser);
    private readonly pbc::RepeatedField<global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.LogTag> logTags_ = new pbc::RepeatedField<global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.LogTag>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.LogTag> LogTags {
      get { return logTags_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LogGroup);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LogGroup other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!logs_.Equals(other.logs_)) return false;
      if (Category != other.Category) return false;
      if (Topic != other.Topic) return false;
      if (Source != other.Source) return false;
      if (MachineUUID != other.MachineUUID) return false;
      if(!logTags_.Equals(other.logTags_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= logs_.GetHashCode();
      if (Category.Length != 0) hash ^= Category.GetHashCode();
      if (Topic.Length != 0) hash ^= Topic.GetHashCode();
      if (Source.Length != 0) hash ^= Source.GetHashCode();
      if (MachineUUID.Length != 0) hash ^= MachineUUID.GetHashCode();
      hash ^= logTags_.GetHashCode();
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
      logs_.WriteTo(output, _repeated_logs_codec);
      if (Category.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Category);
      }
      if (Topic.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Topic);
      }
      if (Source.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Source);
      }
      if (MachineUUID.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(MachineUUID);
      }
      logTags_.WriteTo(output, _repeated_logTags_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += logs_.CalculateSize(_repeated_logs_codec);
      if (Category.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Category);
      }
      if (Topic.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Topic);
      }
      if (Source.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Source);
      }
      if (MachineUUID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MachineUUID);
      }
      size += logTags_.CalculateSize(_repeated_logTags_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LogGroup other) {
      if (other == null) {
        return;
      }
      logs_.Add(other.logs_);
      if (other.Category.Length != 0) {
        Category = other.Category;
      }
      if (other.Topic.Length != 0) {
        Topic = other.Topic;
      }
      if (other.Source.Length != 0) {
        Source = other.Source;
      }
      if (other.MachineUUID.Length != 0) {
        MachineUUID = other.MachineUUID;
      }
      logTags_.Add(other.logTags_);
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
            logs_.AddEntriesFrom(input, _repeated_logs_codec);
            break;
          }
          case 18: {
            Category = input.ReadString();
            break;
          }
          case 26: {
            Topic = input.ReadString();
            break;
          }
          case 34: {
            Source = input.ReadString();
            break;
          }
          case 42: {
            MachineUUID = input.ReadString();
            break;
          }
          case 50: {
            logTags_.AddEntriesFrom(input, _repeated_logTags_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class LogGroupList : pb::IMessage<LogGroupList> {
    private static readonly pb::MessageParser<LogGroupList> _parser = new pb::MessageParser<LogGroupList>(() => new LogGroupList());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LogGroupList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.LogReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogGroupList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogGroupList(LogGroupList other) : this() {
      logGroupList_ = other.logGroupList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogGroupList Clone() {
      return new LogGroupList(this);
    }

    /// <summary>Field number for the "logGroupList" field.</summary>
    public const int LogGroupList_FieldNumber = 1;
    private static readonly pb::FieldCodec<global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.LogGroup> _repeated_logGroupList_codec
        = pb::FieldCodec.ForMessage(10, global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.LogGroup.Parser);
    private readonly pbc::RepeatedField<global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.LogGroup> logGroupList_ = new pbc::RepeatedField<global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.LogGroup>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Aliyun.Api.LogService.Infrastructure.Serialization.Protobuf.LogGroup> LogGroupList_ {
      get { return logGroupList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LogGroupList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LogGroupList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!logGroupList_.Equals(other.logGroupList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= logGroupList_.GetHashCode();
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
      logGroupList_.WriteTo(output, _repeated_logGroupList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += logGroupList_.CalculateSize(_repeated_logGroupList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LogGroupList other) {
      if (other == null) {
        return;
      }
      logGroupList_.Add(other.logGroupList_);
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
            logGroupList_.AddEntriesFrom(input, _repeated_logGroupList_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

/**
 * Autogenerated by Thrift
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Transport;
namespace Apache.Hadoop.Hive
{

  [Serializable]
  public partial class Table : TBase
  {
    private string _tableName;
    private string _dbName;
    private string _owner;
    private int _createTime;
    private int _lastAccessTime;
    private int _retention;
    private StorageDescriptor _sd;
    private List<FieldSchema> _partitionKeys;
    private Dictionary<string, string> _parameters;
    private string _viewOriginalText;
    private string _viewExpandedText;
    private string _tableType;
    private PrincipalPrivilegeSet _privileges;

    public string TableName
    {
      get
      {
        return _tableName;
      }
      set
      {
        __isset.tableName = true;
        this._tableName = value;
      }
    }

    public string DbName
    {
      get
      {
        return _dbName;
      }
      set
      {
        __isset.dbName = true;
        this._dbName = value;
      }
    }

    public string Owner
    {
      get
      {
        return _owner;
      }
      set
      {
        __isset.owner = true;
        this._owner = value;
      }
    }

    public int CreateTime
    {
      get
      {
        return _createTime;
      }
      set
      {
        __isset.createTime = true;
        this._createTime = value;
      }
    }

    public int LastAccessTime
    {
      get
      {
        return _lastAccessTime;
      }
      set
      {
        __isset.lastAccessTime = true;
        this._lastAccessTime = value;
      }
    }

    public int Retention
    {
      get
      {
        return _retention;
      }
      set
      {
        __isset.retention = true;
        this._retention = value;
      }
    }

    public StorageDescriptor Sd
    {
      get
      {
        return _sd;
      }
      set
      {
        __isset.sd = true;
        this._sd = value;
      }
    }

    public List<FieldSchema> PartitionKeys
    {
      get
      {
        return _partitionKeys;
      }
      set
      {
        __isset.partitionKeys = true;
        this._partitionKeys = value;
      }
    }

    public Dictionary<string, string> Parameters
    {
      get
      {
        return _parameters;
      }
      set
      {
        __isset.parameters = true;
        this._parameters = value;
      }
    }

    public string ViewOriginalText
    {
      get
      {
        return _viewOriginalText;
      }
      set
      {
        __isset.viewOriginalText = true;
        this._viewOriginalText = value;
      }
    }

    public string ViewExpandedText
    {
      get
      {
        return _viewExpandedText;
      }
      set
      {
        __isset.viewExpandedText = true;
        this._viewExpandedText = value;
      }
    }

    public string TableType
    {
      get
      {
        return _tableType;
      }
      set
      {
        __isset.tableType = true;
        this._tableType = value;
      }
    }

    public PrincipalPrivilegeSet Privileges
    {
      get
      {
        return _privileges;
      }
      set
      {
        __isset.privileges = true;
        this._privileges = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool tableName;
      public bool dbName;
      public bool owner;
      public bool createTime;
      public bool lastAccessTime;
      public bool retention;
      public bool sd;
      public bool partitionKeys;
      public bool parameters;
      public bool viewOriginalText;
      public bool viewExpandedText;
      public bool tableType;
      public bool privileges;
    }

    public Table() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              TableName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              DbName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              Owner = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              CreateTime = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              LastAccessTime = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              Retention = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.Struct) {
              Sd = new StorageDescriptor();
              Sd.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.List) {
              {
                PartitionKeys = new List<FieldSchema>();
                TList _list66 = iprot.ReadListBegin();
                for( int _i67 = 0; _i67 < _list66.Count; ++_i67)
                {
                  FieldSchema _elem68 = new FieldSchema();
                  _elem68 = new FieldSchema();
                  _elem68.Read(iprot);
                  PartitionKeys.Add(_elem68);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.Map) {
              {
                Parameters = new Dictionary<string, string>();
                TMap _map69 = iprot.ReadMapBegin();
                for( int _i70 = 0; _i70 < _map69.Count; ++_i70)
                {
                  string _key71;
                  string _val72;
                  _key71 = iprot.ReadString();
                  _val72 = iprot.ReadString();
                  Parameters[_key71] = _val72;
                }
                iprot.ReadMapEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.String) {
              ViewOriginalText = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.String) {
              ViewExpandedText = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.String) {
              TableType = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 13:
            if (field.Type == TType.Struct) {
              Privileges = new PrincipalPrivilegeSet();
              Privileges.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("Table");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (TableName != null && __isset.tableName) {
        field.Name = "tableName";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(TableName);
        oprot.WriteFieldEnd();
      }
      if (DbName != null && __isset.dbName) {
        field.Name = "dbName";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(DbName);
        oprot.WriteFieldEnd();
      }
      if (Owner != null && __isset.owner) {
        field.Name = "owner";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Owner);
        oprot.WriteFieldEnd();
      }
      if (__isset.createTime) {
        field.Name = "createTime";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(CreateTime);
        oprot.WriteFieldEnd();
      }
      if (__isset.lastAccessTime) {
        field.Name = "lastAccessTime";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(LastAccessTime);
        oprot.WriteFieldEnd();
      }
      if (__isset.retention) {
        field.Name = "retention";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Retention);
        oprot.WriteFieldEnd();
      }
      if (Sd != null && __isset.sd) {
        field.Name = "sd";
        field.Type = TType.Struct;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        Sd.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (PartitionKeys != null && __isset.partitionKeys) {
        field.Name = "partitionKeys";
        field.Type = TType.List;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, PartitionKeys.Count));
          foreach (FieldSchema _iter73 in PartitionKeys)
          {
            _iter73.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (Parameters != null && __isset.parameters) {
        field.Name = "parameters";
        field.Type = TType.Map;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.String, TType.String, Parameters.Count));
          foreach (string _iter74 in Parameters.Keys)
          {
            oprot.WriteString(_iter74);
            oprot.WriteString(Parameters[_iter74]);
            oprot.WriteMapEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (ViewOriginalText != null && __isset.viewOriginalText) {
        field.Name = "viewOriginalText";
        field.Type = TType.String;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ViewOriginalText);
        oprot.WriteFieldEnd();
      }
      if (ViewExpandedText != null && __isset.viewExpandedText) {
        field.Name = "viewExpandedText";
        field.Type = TType.String;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ViewExpandedText);
        oprot.WriteFieldEnd();
      }
      if (TableType != null && __isset.tableType) {
        field.Name = "tableType";
        field.Type = TType.String;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(TableType);
        oprot.WriteFieldEnd();
      }
      if (Privileges != null && __isset.privileges) {
        field.Name = "privileges";
        field.Type = TType.Struct;
        field.ID = 13;
        oprot.WriteFieldBegin(field);
        Privileges.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("Table(");
      sb.Append("TableName: ");
      sb.Append(TableName);
      sb.Append(",DbName: ");
      sb.Append(DbName);
      sb.Append(",Owner: ");
      sb.Append(Owner);
      sb.Append(",CreateTime: ");
      sb.Append(CreateTime);
      sb.Append(",LastAccessTime: ");
      sb.Append(LastAccessTime);
      sb.Append(",Retention: ");
      sb.Append(Retention);
      sb.Append(",Sd: ");
      sb.Append(Sd== null ? "<null>" : Sd.ToString());
      sb.Append(",PartitionKeys: ");
      sb.Append(PartitionKeys);
      sb.Append(",Parameters: ");
      sb.Append(Parameters);
      sb.Append(",ViewOriginalText: ");
      sb.Append(ViewOriginalText);
      sb.Append(",ViewExpandedText: ");
      sb.Append(ViewExpandedText);
      sb.Append(",TableType: ");
      sb.Append(TableType);
      sb.Append(",Privileges: ");
      sb.Append(Privileges== null ? "<null>" : Privileges.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}

using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求合成或分解 message
 */
public class ReqNuclearFusionMessage : Message 
{
	//合成id
	int _particleId;	
	//操作类型 0 合成 1分解
	byte _operateType;	
	//本批数量
	int _num;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//合成id
		SerializeUtils.WriteInt(stream, _particleId);
		//操作类型 0 合成 1分解
		SerializeUtils.WriteByte(stream, _operateType);
		//本批数量
		SerializeUtils.WriteInt(stream, _num);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//合成id
		_particleId = SerializeUtils.ReadInt(stream);
		//操作类型 0 合成 1分解
		_operateType = SerializeUtils.ReadByte(stream);
		//本批数量
		_num = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 合成id
	 */
	public int ParticleId
	{
		set { _particleId = value; }
	    get { return _particleId; }
	}
	
	/**
	 * 操作类型 0 合成 1分解
	 */
	public byte OperateType
	{
		set { _operateType = value; }
	    get { return _operateType; }
	}
	
	/**
	 * 本批数量
	 */
	public int Num
	{
		set { _num = value; }
	    get { return _num; }
	}
	
	
	public override int GetId() 
	{
		return 110201;
	}
}
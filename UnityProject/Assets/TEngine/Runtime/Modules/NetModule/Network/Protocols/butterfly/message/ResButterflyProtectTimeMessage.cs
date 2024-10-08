using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 地狱蝶保护时间信息 message
 */
public class ResButterflyProtectTimeMessage : Message 
{
	//地狱蝶保护时间[单位秒]
	int _protectTimeSeconds;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//地狱蝶保护时间[单位秒]
		SerializeUtils.WriteInt(stream, _protectTimeSeconds);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//地狱蝶保护时间[单位秒]
		_protectTimeSeconds = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 地狱蝶保护时间[单位秒]
	 */
	public int ProtectTimeSeconds
	{
		set { _protectTimeSeconds = value; }
	    get { return _protectTimeSeconds; }
	}
	
	
	public override int GetId() 
	{
		return 211301;
	}
}
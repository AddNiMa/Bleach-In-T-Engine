using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 使用替身 message
 */
public class ReqUseSubstituteMessage : Message 
{
	//1:替身,2:魂玉
	int _type;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//1:替身,2:魂玉
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//1:替身,2:魂玉
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 1:替身,2:魂玉
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	
	public override int GetId() 
	{
		return 310203;
	}
}
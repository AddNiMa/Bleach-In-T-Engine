using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 进入地狱蝶回复 message
 */
public class ResEnterButterflyMessage : Message 
{
	//0：成功，1：未开放，2：等级不够
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0：成功，1：未开放，2：等级不够
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0：成功，1：未开放，2：等级不够
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0：成功，1：未开放，2：等级不够
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 211201;
	}
}
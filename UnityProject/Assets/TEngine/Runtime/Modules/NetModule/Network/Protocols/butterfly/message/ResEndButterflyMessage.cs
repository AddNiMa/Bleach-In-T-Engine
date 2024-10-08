using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 结束地狱蝶回复 message
 */
public class ResEndButterflyMessage : Message 
{
	//0：抢夺成功，1：抢夺失败
	int _result;	
	//抢夺个数
	int _robCount;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0：抢夺成功，1：抢夺失败
		SerializeUtils.WriteInt(stream, _result);
		//抢夺个数
		SerializeUtils.WriteInt(stream, _robCount);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0：抢夺成功，1：抢夺失败
		_result = SerializeUtils.ReadInt(stream);
		//抢夺个数
		_robCount = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0：抢夺成功，1：抢夺失败
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 抢夺个数
	 */
	public int RobCount
	{
		set { _robCount = value; }
	    get { return _robCount; }
	}
	
	
	public override int GetId() 
	{
		return 211203;
	}
}
using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复开始战斗消息 message
 */
public class ResStartPeerlessBattleMessage : Message 
{
	//0:成功 1：其他
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:成功 1：其他
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:成功 1：其他
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0:成功 1：其他
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 817104;
	}
}
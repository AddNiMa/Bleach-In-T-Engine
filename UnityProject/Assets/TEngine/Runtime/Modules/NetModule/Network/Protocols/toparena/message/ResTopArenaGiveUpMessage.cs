using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复放弃挑战 message
 */
public class ResTopArenaGiveUpMessage : Message 
{
	//0:放弃成功，1：没有对手
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:放弃成功，1：没有对手
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:放弃成功，1：没有对手
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0:放弃成功，1：没有对手
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 503110;
	}
}
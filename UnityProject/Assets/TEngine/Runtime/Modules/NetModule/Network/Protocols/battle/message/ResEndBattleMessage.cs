using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 结束战斗回复 message
 */
public class ResEndBattleMessage : Message 
{
	//0：成功  1：数据有异常
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0：成功  1：数据有异常
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0：成功  1：数据有异常
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0：成功  1：数据有异常
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 400202;
	}
}
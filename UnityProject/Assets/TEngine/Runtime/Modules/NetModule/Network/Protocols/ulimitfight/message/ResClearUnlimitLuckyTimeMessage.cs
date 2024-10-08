using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 响应重置数据倒计时信息 message
 */
public class ResClearUnlimitLuckyTimeMessage : Message 
{
	//倒计时[单位秒]
	int _seconds;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//倒计时[单位秒]
		SerializeUtils.WriteInt(stream, _seconds);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//倒计时[单位秒]
		_seconds = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 倒计时[单位秒]
	 */
	public int Seconds
	{
		set { _seconds = value; }
	    get { return _seconds; }
	}
	
	
	public override int GetId() 
	{
		return 221107;
	}
}
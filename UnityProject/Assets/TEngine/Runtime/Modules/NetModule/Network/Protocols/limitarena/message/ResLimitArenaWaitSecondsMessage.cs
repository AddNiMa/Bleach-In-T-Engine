using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 距离开启秒数 message
 */
public class ResLimitArenaWaitSecondsMessage : Message 
{
	//距离开启秒数 0：已开启 其他：开启剩余秒数
	int _seconds;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//距离开启秒数 0：已开启 其他：开启剩余秒数
		SerializeUtils.WriteInt(stream, _seconds);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//距离开启秒数 0：已开启 其他：开启剩余秒数
		_seconds = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 距离开启秒数 0：已开启 其他：开启剩余秒数
	 */
	public int Seconds
	{
		set { _seconds = value; }
	    get { return _seconds; }
	}
	
	
	public override int GetId() 
	{
		return 502106;
	}
}
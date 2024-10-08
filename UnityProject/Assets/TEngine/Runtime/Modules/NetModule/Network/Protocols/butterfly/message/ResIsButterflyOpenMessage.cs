using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 回复地狱蝶是否开启 message
 */
public class ResIsButterflyOpenMessage : Message 
{
	//地狱蝶是否已开启，0-未开启，1-已开启
	int _isOpen;	
	//未开启时，到开启剩余的秒数，已开启时，此参数为0
	int _waitSeconds;	
	//开启时，系统持续的秒数，未开启时，此参数为0
	int _lastSeconds;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//地狱蝶是否已开启，0-未开启，1-已开启
		SerializeUtils.WriteInt(stream, _isOpen);
		//未开启时，到开启剩余的秒数，已开启时，此参数为0
		SerializeUtils.WriteInt(stream, _waitSeconds);
		//开启时，系统持续的秒数，未开启时，此参数为0
		SerializeUtils.WriteInt(stream, _lastSeconds);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//地狱蝶是否已开启，0-未开启，1-已开启
		_isOpen = SerializeUtils.ReadInt(stream);
		//未开启时，到开启剩余的秒数，已开启时，此参数为0
		_waitSeconds = SerializeUtils.ReadInt(stream);
		//开启时，系统持续的秒数，未开启时，此参数为0
		_lastSeconds = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 地狱蝶是否已开启，0-未开启，1-已开启
	 */
	public int IsOpen
	{
		set { _isOpen = value; }
	    get { return _isOpen; }
	}
	
	/**
	 * 未开启时，到开启剩余的秒数，已开启时，此参数为0
	 */
	public int WaitSeconds
	{
		set { _waitSeconds = value; }
	    get { return _waitSeconds; }
	}
	
	/**
	 * 开启时，系统持续的秒数，未开启时，此参数为0
	 */
	public int LastSeconds
	{
		set { _lastSeconds = value; }
	    get { return _lastSeconds; }
	}
	
	
	public override int GetId() 
	{
		return 211208;
	}
}
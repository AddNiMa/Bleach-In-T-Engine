using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * Buff开始 message
 */
public class ResBuffStartMessage : Message 
{
	//Buff信息
	BuffInfo _info;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//Buff信息
		SerializeUtils.WriteBean(stream, _info);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//Buff信息
		_info = SerializeUtils.ReadBean<BuffInfo>(stream);
	}
	
	/**
	 * Buff信息
	 */
	public BuffInfo Info
	{
		set { _info = value; }
	    get { return _info; }
	}
	
	
	public override int GetId() 
	{
		return 203101;
	}
}
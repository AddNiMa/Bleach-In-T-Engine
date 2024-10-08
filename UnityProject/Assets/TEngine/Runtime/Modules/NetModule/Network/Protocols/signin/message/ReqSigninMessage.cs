using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 前端请求签到 message
 */
public class ReqSigninMessage : Message 
{
	//签到类型（0：普通签到，1：补签）
	int _type;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//签到类型（0：普通签到，1：补签）
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//签到类型（0：普通签到，1：补签）
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 签到类型（0：普通签到，1：补签）
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	
	public override int GetId() 
	{
		return 305201;
	}
}
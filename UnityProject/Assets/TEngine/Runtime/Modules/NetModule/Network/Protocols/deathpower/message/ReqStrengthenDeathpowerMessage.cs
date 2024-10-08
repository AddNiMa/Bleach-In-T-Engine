using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 前端请求强化死神之力 message
 */
public class ReqStrengthenDeathpowerMessage : Message 
{
	//死神之力id
	int _powerId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//死神之力id
		SerializeUtils.WriteInt(stream, _powerId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//死神之力id
		_powerId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 死神之力id
	 */
	public int PowerId
	{
		set { _powerId = value; }
	    get { return _powerId; }
	}
	
	
	public override int GetId() 
	{
		return 309201;
	}
}
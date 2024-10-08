using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 被踢号 message
 */
public class ResPlayerKickedMessage : Message 
{
	//踢号类型，1-被顶号，2-gm封账号
	int _type;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//踢号类型，1-被顶号，2-gm封账号
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//踢号类型，1-被顶号，2-gm封账号
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 踢号类型，1-被顶号，2-gm封账号
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	
	public override int GetId() 
	{
		return 100107;
	}
}
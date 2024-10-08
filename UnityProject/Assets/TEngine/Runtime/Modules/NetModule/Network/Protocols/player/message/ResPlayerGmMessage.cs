using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * GM指令返回 message
 */
public class ResPlayerGmMessage : Message 
{
	//返回
	string _ret;	
	//什么类型的返回(0:默认类型,1:玩家属性)
	int _type;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//返回
		SerializeUtils.WriteString(stream, _ret);
		//什么类型的返回(0:默认类型,1:玩家属性)
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//返回
		_ret = SerializeUtils.ReadString(stream);
		//什么类型的返回(0:默认类型,1:玩家属性)
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 返回
	 */
	public string Ret
	{
		set { _ret = value; }
	    get { return _ret; }
	}
	
	/**
	 * 什么类型的返回(0:默认类型,1:玩家属性)
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	
	public override int GetId() 
	{
		return 105106;
	}
}